using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection chuoiKetNoi = new SqlConnection("Data Source = DESKTOP-4C3209M\\SQLEXPRESS; Initial Catalog = De4; Integrated Security = True");
        int vitrichon = 0;
        void QuanLiDiem()
        {
            string sql = "select *,(diemToan+diemVan+diemNgoaiNgu)/3.0 as 'Điểm TB' from Diem";
            SqlDataAdapter dt = new SqlDataAdapter(sql,chuoiKetNoi);
            DataTable ds = new DataTable();
            dt.Fill(ds);
            dgDiem.DataSource = ds;
            cbMa.DataSource = ds;
            cbMa.DisplayMember = "maSV";

        }
        void ThongKe()
        {
            string loai = cbPhanLoai.Text;
            string sql = "";
            if(loai == "Giỏi")
            {
                 sql = "select * ,(diemToan+diemVan+diemNgoaiNgu)/3.0 as 'Điểm TB' from Diem where (diemToan+diemVan+diemNgoaiNgu)/3.0 >= 8 ";
            }
            else if(loai == "Khá")
            {
                 sql = "select * ,(diemToan+diemVan+diemNgoaiNgu)/3.0 as 'Điểm TB' from Diem where (diemToan+diemVan+diemNgoaiNgu)/3.0 < 8 and (diemToan+diemVan+diemNgoaiNgu)/3.0 >=6.5 ";
            }
            else
            {
                 sql = "select * ,(diemToan+diemVan+diemNgoaiNgu)/3.0 as 'Điểm TB' from Diem where (diemToan+diemVan+diemNgoaiNgu)/3.0 <6.5 ";

            }

            SqlDataAdapter dt = new SqlDataAdapter(sql,chuoiKetNoi);
            DataTable ds = new DataTable();
            dt.Fill(ds);
            dgThongKe.DataSource = ds;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chuoiKetNoi.Open();
            QuanLiDiem();
            
            
        }

        private void cbMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbMa.SelectedIndex;

            if (i >= 0)
            {
                txtTen.Text = dgDiem.Rows[i].Cells[1].Value.ToString();
                txtToan.Text = dgDiem.Rows[i].Cells[2].Value.ToString();
                txtVan.Text = dgDiem.Rows[i].Cells[3].Value.ToString();
                txtNgoaiNgu.Text = dgDiem.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into Diem values(@maSV,@hoTen,@diemToan,@diemVan,@diemNgoaiNgu)";
            SqlCommand cmd = new SqlCommand(sql, chuoiKetNoi);
            cmd.Parameters.AddWithValue("@maSV", cbMa.Text);
            cmd.Parameters.AddWithValue("@hoTen", txtTen.Text);
            cmd.Parameters.AddWithValue("@diemToan", txtToan.Text);
            cmd.Parameters.AddWithValue("@diemVan", txtVan.Text);
            cmd.Parameters.AddWithValue("@diemNgoaiNgu", txtNgoaiNgu.Text);

            cmd.ExecuteNonQuery();
            QuanLiDiem();

        }

        private void dgDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             vitrichon = e.RowIndex;
            if(vitrichon >= 0)
            {
                cbMa.Text = dgDiem.Rows[vitrichon].Cells[0].Value.ToString();
                txtToan.Text = dgDiem.Rows[vitrichon].Cells[2].Value.ToString();
                txtVan.Text = dgDiem.Rows[vitrichon].Cells[3].Value.ToString();
                txtNgoaiNgu.Text = dgDiem.Rows[vitrichon].Cells[4].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(dgDiem.Rows[vitrichon].Cells[0].Value);
            string sql = "update Diem " +
                          "set hoTen = @hoTen, " +
                          "diemToan = @diemToan, " +
                          "diemVan = @diemVan, " +
                          "diemNgoaiNgu = @diemNgoaiNgu " +
                          "where maSV = " + ma;
            SqlCommand cmd = new SqlCommand(sql, chuoiKetNoi);
            cmd.Parameters.AddWithValue("@hoTen", txtTen.Text);
            cmd.Parameters.AddWithValue("@diemToan", txtToan.Text);
            cmd.Parameters.AddWithValue("@diemVan", txtVan.Text);
            cmd.Parameters.AddWithValue("@diemNgoaiNgu", txtNgoaiNgu.Text);
            cmd.ExecuteNonQuery();
            QuanLiDiem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from Diem where maSV = @maSV";

            SqlCommand cmd = new SqlCommand(sql, chuoiKetNoi);
            cmd.Parameters.AddWithValue("@maSV", cbMa.Text);
            cmd.ExecuteNonQuery();
            QuanLiDiem();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }
    }
}
