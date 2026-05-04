using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Bai_4
{
    public partial class frmLapDonHang : Form
    {
        public frmLapDonHang()
        {
            InitializeComponent();
        }
        List<SanPham> dsKho = new List<SanPham>();
        List<ChiTietDonHang> gioHang = new List<ChiTietDonHang>();
        string fileSP = "sanpham.json";
        string fileDon = "donhang.json";
        private void frmLapDonHang_Load(object sender, EventArgs e)
        {
            LoadKho();
            dtpNgayLap.Value = DateTime.Now;
        }

        private void LoadKho()
        {
            if (File.Exists(fileSP))
            {
                dsKho = JsonConvert.DeserializeObject<List<SanPham>>(File.ReadAllText(fileSP)) ?? new List<SanPham>();
            }
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = dsKho;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            var spChon = (SanPham)dgvSanPham.CurrentRow.DataBoundItem;
            int slMua = (int)nudSoLuong.Value;

            if (slMua <= 0) return;
            if (slMua > spChon.TonKho)
            {
                MessageBox.Show($"Không đủ hàng! Trong kho chỉ còn {spChon.TonKho}", "Thông báo");
                return;
            }
            var itemTrongGio = gioHang.FirstOrDefault(x => x.MaSP == spChon.MaSP);
            if (itemTrongGio != null)
            {
                if (itemTrongGio.SoLuong + slMua > spChon.TonKho)
                {
                    MessageBox.Show("Tổng số lượng trong giỏ vượt quá tồn kho!");
                    return;
                }
                itemTrongGio.SoLuong += slMua;
            }
            else
            {
                gioHang.Add(new ChiTietDonHang
                {
                    MaSP = spChon.MaSP,
                    TenSP = spChon.TenSP,
                    SoLuong = slMua,
                    DonGia = spChon.DonGia
                });
            }

            CapNhatHienThiGioHang();
        }

        private void CapNhatHienThiGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;
            lblTongTien.Text = gioHang.Sum(x => x.ThanhTien).ToString("N0");
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0 || string.IsNullOrEmpty(txtKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách và chọn sản phẩm!");
                return;
            }

            foreach (var item in gioHang)
            {
                var spKho = dsKho.First(x => x.MaSP == item.MaSP);
                spKho.TonKho -= item.SoLuong;
            }

            DonHang dh = new DonHang
            {
                MaDon = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                NgayLap = dtpNgayLap.Value,
                TenKhach = txtKhachHang.Text,
                ChiTiet = new List<ChiTietDonHang>(gioHang),
                TongTien = gioHang.Sum(x => x.ThanhTien),
                TrangThai = "Mới"
            };

            File.WriteAllText(fileSP, JsonConvert.SerializeObject(dsKho, Formatting.Indented));

            List<DonHang> dsDonHang = new List<DonHang>();
            if (File.Exists(fileDon))
                dsDonHang = JsonConvert.DeserializeObject<List<DonHang>>(File.ReadAllText(fileDon));

            dsDonHang.Add(dh);
            File.WriteAllText(fileDon, JsonConvert.SerializeObject(dsDonHang, Formatting.Indented));

            MessageBox.Show("Lập đơn hàng thành công!");
            gioHang.Clear();
            txtKhachHang.Clear();
            CapNhatHienThiGioHang();
            LoadKho(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng để sửa!");
                return;
            }

            var itemChon = (ChiTietDonHang)dgvGioHang.CurrentRow.DataBoundItem;

            var spKho = dsKho.FirstOrDefault(x => x.MaSP == itemChon.MaSP);
            int soLuongMoi = (int)nudSoLuong.Value;

            if (soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            if (spKho != null && soLuongMoi > spKho.TonKho)
            {
                MessageBox.Show($"Không đủ hàng! Kho chỉ còn {spKho.TonKho}");
                return;
            }

            itemChon.SoLuong = soLuongMoi;

            CapNhatHienThiGioHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                var itemXoa = (ChiTietDonHang)dgvGioHang.CurrentRow.DataBoundItem;
                gioHang.Remove(itemXoa);
                CapNhatHienThiGioHang();
            }
        }
    }

    public class ChiTietDonHang
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien => SoLuong * DonGia;
    }

    public class DonHang
    {
        public string MaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string TenKhach { get; set; }
        public List<ChiTietDonHang> ChiTiet { get; set; }
        public double TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
