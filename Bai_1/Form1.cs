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

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTatCaFile();
            LoadCombo();
        }

        List<Tinh> dsTinh = new List<Tinh>();
        List<Khoa> dsKhoa = new List<Khoa>();
        List<Lop> dsLop = new List<Lop>();
        List<SinhVien> dsSV = new List<SinhVien>();

        void SaveFile<T>(List<T> data, string filePath)
        {
            string jsonstr = JsonConvert.SerializeObject(data, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(jsonstr);
            }
        }
        List<T> LoadFile<T>(string filePath)
        {
            if (!File.Exists(filePath)) return new List<T>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()) ?? new List<T>();
            }
        }
        void LoadTatCaFile()
        {
            dsTinh = LoadFile<Tinh>("tinh.json");
            dsKhoa = LoadFile<Khoa>("khoa.json");
            dsLop = LoadFile<Lop>("lop.json");
            dsSV = LoadFile<SinhVien>("sinhvien.json");
            HienThiTatCaGrid();
        }
        void LoadCombo()
        {
            cbMK.DataSource = null;
            cbMK.DisplayMember = "TenKhoa";
            cbMK.ValueMember = "MaKhoa";
            cbMK.DataSource = dsKhoa;

            cbNS.DataSource = null;
            cbNS.DisplayMember = "TenTinh";
            cbNS.ValueMember = "MaTinh";
            cbNS.DataSource = dsTinh;

            cbK.DataSource = null;
            cbK.DisplayMember = "TenKhoa";
            cbK.ValueMember = "MaKhoa";
            cbK.DataSource = dsKhoa;

            cbL.DataSource = null;
            cbL.DisplayMember = "TenLop";
            cbL.ValueMember = "MaLop";
            cbL.DataSource = dsLop;
        }
        private void btnTT_Click(object sender, EventArgs e)
        {
            dsTinh.Add(new Tinh(txtMT.Text, txtTT.Text));
            SaveFile(dsTinh, "tinh.json");
            HienThiGridTinh();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dsKhoa.Add(new Khoa(txtMK.Text, txtTK.Text));
            SaveFile(dsKhoa, "khoa.json");
            HienThiGridKhoa();
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            dsLop.Add(new Lop(txtML.Text, txtTL.Text, cbMK.SelectedValue.ToString()));
            SaveFile(dsLop, "lop.json");
            HienThiGridLop();
        }
        private void btnTSV_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSV = txtMa.Text,
                HoTen = txtTen.Text,
                GioiTinh = rdbNam.Checked ? "Nam" : "Nữ",
                NgaySinh = dtpNS.Value,
                MaTinh = cbNS.SelectedValue?.ToString(),
                MaKhoa = cbK.SelectedValue?.ToString(),
                MaLop = cbL.SelectedValue?.ToString()
            };
            dsSV.Add(sv);
            SaveFile(dsSV, "sinhvien.json");
            HienThiGridSV();
        }

        void HienThiGridTinh() { dgvTinh.DataSource = null; dgvTinh.DataSource = dsTinh; }
        void HienThiGridKhoa() { dgvKhoa.DataSource = null; dgvKhoa.DataSource = dsKhoa; }
        void HienThiGridLop() { dgvLop.DataSource = null; dgvLop.DataSource = dsLop; }
        void HienThiGridSV() 
        {
            var data = dsSV.Select(sv => new
            {
                sv.MaSV,
                sv.HoTen,
                sv.GioiTinh,
                sv.NgaySinh,

                TenTinh = dsTinh.FirstOrDefault(t => t.MaTinh == sv.MaTinh)?.TenTinh,
                TenKhoa = dsKhoa.FirstOrDefault(k => k.MaKhoa == sv.MaKhoa)?.TenKhoa,
                TenLop = dsLop.FirstOrDefault(l => l.MaLop == sv.MaLop)?.TenLop
            }).ToList();

            dgvSV.DataSource = null;
            dgvSV.DataSource = data;
        }
        void HienThiTatCaGrid() { HienThiGridTinh(); HienThiGridKhoa(); HienThiGridLop(); HienThiGridSV(); }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            var tinh = dsTinh.FirstOrDefault(x => x.MaTinh == txtMT.Text);
            if (tinh != null)
            {
                tinh.TenTinh = txtTT.Text;
                SaveFile(dsTinh, "tinh.json");
                HienThiGridTinh();
            }
        }

        private void btnXT_Click(object sender, EventArgs e)
        {
            var tinh = dsTinh.FirstOrDefault(x => x.MaTinh == txtMT.Text);
            if (tinh != null)
            {
                dsTinh.Remove(tinh);
                SaveFile(dsTinh, "tinh.json");
                HienThiGridTinh();
            }
        }

        private void dgvTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i>=0)
            {
                txtMT.Text = dgvTinh.Rows[i].Cells[0].Value.ToString();
                txtTT.Text = dgvTinh.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void btnSK_Click(object sender, EventArgs e)
        {
            var khoa = dsKhoa.FirstOrDefault(x => x.MaKhoa == txtMK.Text);
            if (khoa != null)
            {
                khoa.TenKhoa = txtTK.Text;
                SaveFile(dsKhoa, "khoa.json");
                HienThiGridKhoa();
            }
        }

        private void btnXK_Click(object sender, EventArgs e)
        {
            var khoa = dsKhoa.FirstOrDefault(x => x.MaKhoa == txtMK.Text);
            if (khoa != null)
            {
                dsKhoa.Remove(khoa);
                SaveFile(dsKhoa, "khoa.json");
                HienThiGridKhoa();
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMK.Text = dgvKhoa.Rows[i].Cells[0].Value.ToString();
                txtTK.Text = dgvKhoa.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            var lop = dsLop.FirstOrDefault(x => x.MaLop == txtML.Text);
            if (lop != null)
            {
                lop.TenLop = txtTL.Text;
                lop.MaKhoa = cbMK.SelectedValue.ToString();
                SaveFile(dsLop, "lop.json");
                HienThiGridLop();
            }
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            var lop = dsLop.FirstOrDefault(x => x.MaLop == txtML.Text);
            if (lop != null)
            {
                dsLop.Remove(lop);
                SaveFile(dsLop, "lop.json");
                HienThiGridLop();
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtML.Text = dgvLop.Rows[i].Cells[0].Value.ToString();
                txtTL.Text = dgvLop.Rows[i].Cells[1].Value.ToString();
                cbMK.Text = dgvLop.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void btnSSV_Click(object sender, EventArgs e)
        {
            var sv = dsSV.FirstOrDefault(x => x.MaSV == txtMa.Text);
            if (sv != null)
            {
                sv.HoTen = txtTen.Text;
                sv.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                sv.NgaySinh = dtpNS.Value;
                sv.MaTinh = cbNS.SelectedValue?.ToString();
                sv.MaKhoa = cbK.SelectedValue?.ToString();
                sv.MaLop = cbL.SelectedValue?.ToString();

                SaveFile(dsSV, "sinhvien.json");
                HienThiGridSV();
            }
        }

        private void btnXSV_Click(object sender, EventArgs e)
        {
            var sv = dsSV.FirstOrDefault(x => x.MaSV == txtMa.Text);
            if (sv != null)
            {
                dsSV.Remove(sv);
                SaveFile(dsSV, "sinhvien.json");
                HienThiGridSV();
            }
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMa.Text = dgvSV.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dgvSV.Rows[i].Cells[1].Value.ToString();
                dtpNS.Value = Convert.ToDateTime(dgvSV.Rows[i].Cells[3].Value);
                string gt = dgvSV.Rows[i].Cells[2].Value.ToString();
                if (gt == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                cbNS.Text = dgvSV.Rows[i].Cells[4].Value.ToString();
                cbK.Text = dgvSV.Rows[i].Cells[5].Value.ToString();
                cbL.Text = dgvSV.Rows[i].Cells[6].Value.ToString();

            }
        }
    }


    public class Tinh
    {
        public string MaTinh { get; set; }
        public string TenTinh { get; set; }
        public Tinh() { }
        public Tinh(string ma, string ten) { MaTinh = ma; TenTinh = ten; }
    }

    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public Khoa() { }
        public Khoa(string ma, string ten) { MaKhoa = ma; TenKhoa = ten; }
    }

    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKhoa { get; set; }
        public Lop() { }
        public Lop(string ma, string ten, string makhoa) { MaLop = ma; TenLop = ten; MaKhoa = makhoa; }
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaTinh { get; set; }
        public string MaKhoa { get; set; }
        public string MaLop { get; set; }
        public SinhVien() { }
    }
}
