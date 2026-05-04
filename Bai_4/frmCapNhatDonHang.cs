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


namespace Bai_4
{
    public partial class frmCapNhatDonHang : Form
    {
        public frmCapNhatDonHang()
        {
            InitializeComponent();
        }
        List<DonHang> dsDonHang = new List<DonHang>();
        List<SanPham> dsSanPham = new List<SanPham>();
        string pathDonHang = "donhang.json";
        string pathSanPham = "sanpham.json";

        private void frmCapNhatDonHang_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.AddRange(new string[] { "Tất cả", "Mới", "Đã thanh toán", "Đã hủy" });
            cboTrangThai.SelectedIndex = 0;
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            if (System.IO.File.Exists(pathDonHang))
            {
                dsDonHang = JsonConvert.DeserializeObject<List<DonHang>>(System.IO.File.ReadAllText(pathDonHang)) ?? new List<DonHang>();
            }
            if (System.IO.File.Exists(pathSanPham))
            {
                dsSanPham = JsonConvert.DeserializeObject<List<SanPham>>(System.IO.File.ReadAllText(pathSanPham)) ?? new List<SanPham>();
            }
            LocDonHang();
        }

        private void LocDonHang()
        {
            DateTime ngayLoc = dtpNgayTim.Value.Date;
            string trangThai = cboTrangThai.SelectedItem.ToString();

            var ketQua = dsDonHang.Where(dh => dh.NgayLap.Date == ngayLoc).ToList();

            if (trangThai != "Tất cả")
            {
                ketQua = ketQua.Where(dh => dh.TrangThai == trangThai).ToList();
            }

            dgvDonHang.DataSource = null;
            dgvDonHang.DataSource = ketQua;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LocDonHang();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần sửa!");
                return;
            }

            DonHang dh = (DonHang)dgvDonHang.CurrentRow.DataBoundItem;

            if (dh.TrangThai != "Mới")
            {
                MessageBox.Show("Chỉ có thể sửa đơn hàng đang ở trạng thái 'Mới'!");
                return;
            }
            int soLuongMoi = (int)nudSLM.Value;
            if (soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng mới phải lớn hơn 0!");
                return;
            }
            var ct = dh.ChiTiet.FirstOrDefault();
            if (ct == null) return;

            var spTrongKho = dsSanPham.FirstOrDefault(s => s.MaSP == ct.MaSP);
            if (spTrongKho == null) return;

            int chenhLech = soLuongMoi - ct.SoLuong;

            if (chenhLech > 0) 
            {
                if (spTrongKho.TonKho < chenhLech)
                {
                    MessageBox.Show($"Kho không đủ hàng! Hiện tại chỉ còn {spTrongKho.TonKho} sản phẩm.");
                    return;
                }
                spTrongKho.TonKho -= chenhLech;
            }
            else if (chenhLech < 0)
            {
                spTrongKho.TonKho += Math.Abs(chenhLech);
            }

            ct.SoLuong = soLuongMoi;
            dh.TongTien = dh.ChiTiet.Sum(x => x.SoLuong * x.DonGia);

            LuuDuLieu();
            MessageBox.Show("Cập nhật số lượng và tồn kho thành công!");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null) return;
            var dh = (DonHang)dgvDonHang.CurrentRow.DataBoundItem;

            if (dh.TrangThai == "Mới")
            {
                dh.TrangThai = "Đã thanh toán";
                LuuDuLieu();
                MessageBox.Show("Đã cập nhật trạng thái: Đã thanh toán");
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null) return;
            var dh = (DonHang)dgvDonHang.CurrentRow.DataBoundItem;

            if (dh.TrangThai != "Mới")
            {
                MessageBox.Show("Chỉ được hủy đơn hàng ở trạng thái 'Mới'");
                return;
            }

            if (MessageBox.Show("Xác nhận hủy đơn? Sản phẩm sẽ được trả lại kho.", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var ct in dh.ChiTiet)
                {
                    var sp = dsSanPham.FirstOrDefault(s => s.MaSP == ct.MaSP);
                    if (sp != null) sp.TonKho += ct.SoLuong;
                }

                dh.TrangThai = "Đã hủy";
                LuuDuLieu();
                MessageBox.Show("Đã hủy đơn và hoàn kho thành công.");
            }
        }
        private void LuuDuLieu()
        {
            System.IO.File.WriteAllText(pathDonHang, JsonConvert.SerializeObject(dsDonHang, Formatting.Indented));
            System.IO.File.WriteAllText(pathSanPham, JsonConvert.SerializeObject(dsSanPham, Formatting.Indented));
            LocDonHang();
        }
    }
}