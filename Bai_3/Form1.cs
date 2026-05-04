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
using System.IO;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<LoaiSach> listLoai = new List<LoaiSach>();
        List<TacGia> listTG = new List<TacGia>();
        List<NXB> listNXB = new List<NXB>();
        List<Sach> listSach = new List<Sach>();
        List<HoaDon> listHD = new List<HoaDon>();

        string fLoai = "loai.json";
        string fTG = "tg.json";
        string fNXB = "nxb.json";
        string fSach = "sach.json";
        string fHD = "hd.json";

        void SaveFile<T>(List<T> list, string file)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(list, Formatting.Indented));
        }

        List<T> LoadFile<T>(string file)
        {
            if (!File.Exists(file)) return new List<T>();
            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(file)) ?? new List<T>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listLoai = LoadFile<LoaiSach>(fLoai);
            listTG = LoadFile<TacGia>(fTG);
            listNXB = LoadFile<NXB>(fNXB);
            listSach = LoadFile<Sach>(fSach);
            listHD = LoadFile<HoaDon>(fHD);

            dgvLoaiSach.DataSource = listLoai;
            dgvTacGia.DataSource = listTG;
            dgvNXB.DataSource = listNXB;
            dgvSach.DataSource = listSach;
            dgvBanHang.DataSource = listHD;
        }
        void LoadComboBox()
        {
            cbLoai.DataSource = null;
            cbLoai.DataSource = listLoai.ToList();
            cbLoai.DisplayMember = "TenLS";
            cbLoai.ValueMember = "TenLS";

            cbTacGia.DataSource = listTG.ToList();
            cbTacGia.DisplayMember = "TenTG";
            cbTacGia.ValueMember = "TenTG";

            cbNXB.DataSource = listNXB.ToList();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "TenNXB";
        }
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            listLoai.Add(new LoaiSach { MaLS = txtMaLS.Text, TenLS = txtTenLS.Text });
            SaveFile(listLoai, fLoai);
            dgvLoaiSach.DataSource = null;
            dgvLoaiSach.DataSource = listLoai;
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            var x = listLoai.FirstOrDefault(i => i.MaLS == txtMaLS.Text);
            if (x != null) x.TenLS = txtTenLS.Text;
            SaveFile(listLoai, fLoai);
            dgvLoaiSach.DataSource = null;
            dgvLoaiSach.DataSource = listLoai;
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            listLoai.RemoveAll(x => x.MaLS == txtMaLS.Text);
            SaveFile(listLoai, fLoai);
            dgvLoaiSach.DataSource = null;
            dgvLoaiSach.DataSource = listLoai;
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            listNXB.Add(new NXB { MaNXB = txtMaNXB.Text, TenNXB = txtTenNXB.Text });
            SaveFile(listNXB, fNXB);
            dgvNXB.DataSource = null;
            dgvNXB.DataSource = listNXB;
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            var nxb = listNXB.FirstOrDefault(x => x.MaNXB == txtMaNXB.Text);
            if (nxb != null)
            {
                nxb.TenNXB = txtTenNXB.Text;

                SaveFile(listNXB, fNXB);
                dgvNXB.DataSource = null;
                dgvNXB.DataSource = listNXB;
            }
        }
        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            listNXB.RemoveAll(x => x.MaNXB == txtMaNXB.Text);
            SaveFile(listNXB, fNXB);
            dgvNXB.DataSource = null;
            dgvNXB.DataSource = listNXB;
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            listTG.Add(new TacGia { MaTG = txtMaTG.Text, TenTG = txtTenTG.Text });
            SaveFile(listTG, fTG);
            dgvTacGia.DataSource = null;
            dgvTacGia.DataSource = listTG;
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            var tg = listTG.FirstOrDefault(x => x.MaTG == txtMaTG.Text);
            if (tg != null)
            {
                tg.TenTG = txtTenTG.Text;

                SaveFile(listTG, fTG);
                dgvTacGia.DataSource = null;
                dgvTacGia.DataSource = listTG;
            }
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            listTG.RemoveAll(x => x.MaTG == txtMaTG.Text);
            SaveFile(listTG, fTG);
            dgvTacGia.DataSource = null;
            dgvTacGia.DataSource = listTG;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Sach s = new Sach()
            {
                MaSach = txtMaSach.Text,
                TenSach = txtTenSach.Text,
                Loai = cbLoai.Text,
                TacGia = cbTacGia.Text,
                NXB = cbNXB.Text,
                SoLuong = int.Parse(txtSL.Text),
                DonGia = decimal.Parse(txtDonGia.Text)
            };

            listSach.Add(s);
            SaveFile(listSach, fSach);
            dgvSach.DataSource = null;
            dgvSach.DataSource = listSach;
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            var s = listSach.FirstOrDefault(x => x.MaSach.Trim() == txtMaSach.Text.Trim());

            if (s != null)
            {
                int.TryParse(txtSL.Text, out int sl);
                decimal.TryParse(txtDonGia.Text, out decimal gia);

                s.TenSach = txtTenSach.Text;
                s.Loai = cbLoai.Text;
                s.TacGia = cbTacGia.Text;
                s.NXB = cbNXB.Text;
                s.SoLuong = sl;
                s.DonGia = gia;

                SaveFile(listSach, fSach);
                dgvSach.DataSource = null;
                dgvSach.DataSource = listSach;
            }
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            listSach.RemoveAll(x => x.MaSach == txtMaSach.Text);
            SaveFile(listSach, fSach);
            dgvSach.DataSource = null;
            dgvSach.DataSource = listSach;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            decimal tong = 0;

            foreach (var s in listSach)
                tong += s.SoLuong * s.DonGia;

            txtTongtien.Text = tong.ToString();

            listHD.Add(new HoaDon
            {
                MaHD = txtMaHD.Text,
                TenKH = txtTenKH.Text,
                SDT = txtSDT.Text,
                TongTien = tong
            });

            SaveFile(listHD, fHD);
            dgvBanHang.DataSource = null;
            dgvBanHang.DataSource = listHD;
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            var hd = listHD.FirstOrDefault(x => x.MaHD == txtMaHD.Text);

            if (hd != null)
            {
                decimal.TryParse(txtTongtien.Text, out decimal tong);

                hd.TenKH = txtTenKH.Text;
                hd.SDT = txtSDT.Text;
                hd.TongTien = tong;

                SaveFile(listHD, fHD);
                dgvBanHang.DataSource = null;
                dgvBanHang.DataSource = listHD;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            listHD.RemoveAll(x => x.MaHD == txtMaHD.Text);
            SaveFile(listHD, fHD);
            dgvBanHang.DataSource = null;
            dgvBanHang.DataSource = listHD;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string loai = cbTK.Text;

            if (loai == "Loại")
            {
                var data = listSach.GroupBy(x => x.Loai)
                    .Select(g => new { Loai = g.Key, SL = g.Sum(x => x.SoLuong) }).ToList();

                dgvThongKe.DataSource = data;
            }
            else if (loai == "Tác giả")
            {
                var data = listSach.GroupBy(x => x.TacGia)
                    .Select(g => new { TacGia = g.Key, SL = g.Sum(x => x.SoLuong) }).ToList();

                dgvThongKe.DataSource = data;
            }
            else if (loai == "NXB")
            {
                var data = listSach.GroupBy(x => x.NXB)
                    .Select(g => new { NXB = g.Key, SL = g.Sum(x => x.SoLuong) }).ToList();

                dgvThongKe.DataSource = data;
            }
        }

        private void dgvLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                var row = dgvLoaiSach.Rows[i];

                txtMaLS.Text = row.Cells["MaLS"].Value?.ToString();
                txtTenLS.Text = row.Cells["TenLS"].Value?.ToString();
            }
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                var row = dgvNXB.Rows[i];

                txtMaNXB.Text = row.Cells["MaNXB"].Value?.ToString();
                txtTenNXB.Text = row.Cells["TenNXB"].Value?.ToString();
            }
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                var row = dgvTacGia.Rows[i];

                txtMaTG.Text = row.Cells["MaTG"].Value?.ToString();
                txtTenTG.Text = row.Cells["TenTG"].Value?.ToString();
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                var row = dgvSach.Rows[i];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                cbLoai.Text = row.Cells["Loai"].Value.ToString();
                cbTacGia.Text = row.Cells["TacGia"].Value.ToString();
                cbNXB.Text = row.Cells["NXB"].Value.ToString();
                txtSL.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                var row = dgvBanHang.Rows[i];

                txtMaHD.Text = row.Cells["MaHD"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtTongtien.Text = row.Cells["TongTien"].Value?.ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpSach)
            {
                LoadComboBox();
            }
        }

    }
    public class LoaiSach
    {
        public string MaLS { get; set; }
        public string TenLS { get; set; }
    }

    public class TacGia
    {
        public string MaTG { get; set; }
        public string TenTG { get; set; }
    }
    public class NXB
    {
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
    }
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string Loai { get; set; }
        public string TacGia { get; set; }
        public string NXB { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }

    public class HoaDon
    {
        public string MaHD { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public decimal TongTien { get; set; }
    }
}
