using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bai_4
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        List<DonHang> dsDonHang = new List<DonHang>();
        string fileDonHang = "donhang.json";
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cboLoaiThongKe.Items.AddRange(new string[] { "Theo mặt hàng", "Theo ngày tháng" });
            cboLoaiThongKe.SelectedIndex = 0;
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(fileDonHang)) return;

            dsDonHang = JsonConvert.DeserializeObject<List<DonHang>>(System.IO.File.ReadAllText(fileDonHang));
            var dsLoc = dsDonHang.Where(dh => dh.NgayLap.Date >= dtpTuNgay.Value.Date
                                           && dh.NgayLap.Date <= dtpDenNgay.Value.Date).ToList();

            List<ThongKeItem> ketQua = new List<ThongKeItem>();

            if (cboLoaiThongKe.SelectedIndex == 0)
            {
                ketQua = dsLoc.SelectMany(dh => dh.ChiTiet)
                    .GroupBy(ct => ct.TenSP)
                    .Select(g => new ThongKeItem
                    {
                        Nhan = g.Key,
                        SoLuong = g.Sum(x => x.SoLuong),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    }).ToList();
            }
            else
            {
                ketQua = dsLoc.GroupBy(dh => dh.NgayLap.ToShortDateString())
                    .Select(g => new ThongKeItem
                    {
                        Nhan = g.Key,
                        SoLuong = g.Sum(dh => dh.ChiTiet.Sum(ct => ct.SoLuong)),
                        DoanhThu = g.Sum(dh => dh.TongTien)
                    }).OrderBy(x => DateTime.Parse(x.Nhan)).ToList();
            }

            dgvThongKe.DataSource = ketQua;

            VeBieuDo(ketQua);
        }

        private void VeBieuDo(List<ThongKeItem> data)
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("BIỂU ĐỒ DOANH THU");

            Series series = new Series("Doanh Thu");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                series.Points.AddXY(item.Nhan, item.DoanhThu);
            }

            chartDoanhThu.Series.Add(series);

            chartDoanhThu.Series["Doanh Thu"].IsValueShownAsLabel = true;
            chartDoanhThu.Series["Doanh Thu"].LabelFormat = "{0:N0}";
        }
    }

    public class ThongKeItem
    {
        public string Nhan { get; set; }
        public int SoLuong { get; set; }
        public double DoanhThu { get; set; }
    }
}
