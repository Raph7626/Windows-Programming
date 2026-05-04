using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
            LoadDanhSachSP();
        }

        List<SanPham> danhSachSP = new List<SanPham>();
        string tenFile = "sanpham.json";

        private void Luu()
        {
            string chuoiJson = JsonConvert.SerializeObject(danhSachSP, Formatting.Indented);
            File.WriteAllText(tenFile, chuoiJson);
        }

        private void LoadDanhSachSP()
        {
            if (File.Exists(tenFile))
            {
                string chuoiJson = File.ReadAllText(tenFile);
                danhSachSP = JsonConvert.DeserializeObject<List<SanPham>>(chuoiJson) ?? new List<SanPham>();
            }
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = danhSachSP;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            var ketQua = danhSachSP .Where(s => s.TenSP.ToLower().Contains(tuKhoa)).ToList();

            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = ketQua;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (danhSachSP.Any(s => s.MaSP == txtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }

            SanPham spMoi = new SanPham
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                DonVi = cmbDonViTinh.Text,
                DonGia = double.Parse(nudDonGia.Text),
                TonKho = int.Parse(txtTonKho.Text)
            };
            danhSachSP.Add(spMoi);
            Luu();
            LoadDanhSachSP(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sp = danhSachSP.FirstOrDefault(s => s.MaSP == txtMaSP.Text);

            if (sp != null)
            {
                sp.TenSP = txtTenSP.Text;
                sp.DonVi = cmbDonViTinh.Text;
                sp.DonGia = double.Parse(nudDonGia.Text);
                sp.TonKho = int.Parse(txtTonKho.Text);

                Luu();
                LoadDanhSachSP();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sp = danhSachSP.FirstOrDefault(s => s.MaSP == txtMaSP.Text);

            if (sp != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    danhSachSP.Remove(sp);
                    Luu();
                    LoadDanhSachSP();
                }
            }
        }

        private void btnNhapThem_Click(object sender, EventArgs e)
        {
            var spSua = danhSachSP.FirstOrDefault(sp => sp.MaSP == txtMaSP.Text);

            if (spSua != null)
            {
                if (int.TryParse(txtTonKho.Text, out int slNhapThem) && slNhapThem > 0)
                {
                    spSua.TonKho += slNhapThem;
                    Luu();
                    LoadDanhSachSP();
                    MessageBox.Show($"Đã nhập thêm {slNhapThem}. Tổng tồn kho hiện tại: {spSua.TonKho}", "Thành công");
                    txtMaSP.Clear();
                    txtTenSP.Clear();
                    txtTonKho.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng > 0 vào ô Tồn kho để nhập thêm!");
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dong = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = dong.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dong.Cells["TenSP"].Value.ToString();
                cmbDonViTinh.Text = dong.Cells["DonVi"].Value.ToString();
                nudDonGia.Text = dong.Cells["DonGia"].Value.ToString();
                txtTonKho.Text = dong.Cells["TonKho"].Value.ToString();
            }
        }
    }
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonVi { get; set; }
        public double DonGia { get; set; }
        public int TonKho { get; set; }
    }
}
