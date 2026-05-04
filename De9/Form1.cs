using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-4C3209M\\SQLEXPRESS; Initial Catalog = De9; Integrated Security = True ");
        int vitrichon;
        private void Form1_Load(object sender, EventArgs e)
        {

            conn.Open();

            ThongKe();

        }
        int stt = 0;
        void ThongKe()
        {
            
            string sql = "select STT,hoTen,gioiTinh,loaiPhong,soPhongThue from  KhachHang";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            dt.Fill(ds);

            string sqlLoai = "select DISTINCT loaiPhong from KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoai, conn);
            DataTable dtLoai = new DataTable();
            da.Fill(dtLoai);

            cbLoaiPhong.DataSource = dtLoai;
            cbLoaiPhong.DisplayMember = "loaiPhong";
            dgDuLieu.DataSource = ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (rdNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else {
                gioiTinh = "Nữ";
            }
            string sql = "insert into KhachHang(hoTen,gioiTinh,loaiPhong,soPhongThue) values (@ten,@gioiTinh,@loaiPhong,@soPhong)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten", txtTen.Text);
            cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@loaiPhong", cbLoaiPhong.Text);
            cmd.Parameters.AddWithValue("@soPhong", txtSoPhong.Text);
            cmd.ExecuteNonQuery();
            ThongKe();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(dgDuLieu.Rows[vitrichon].Cells[0].Value);

            string sql = "delete from KhachHang where STT = " + stt;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            ThongKe();
        }

        private void dgDuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon = e.RowIndex;
            if(vitrichon >= 0)
            {
                txtTen.Text = dgDuLieu.Rows[vitrichon].Cells[1].Value.ToString();
                string gioiTinh = dgDuLieu.Rows[vitrichon].Cells[2].Value.ToString();
                cbLoaiPhong.Text = dgDuLieu.Rows[vitrichon].Cells[3].Value.ToString();
                txtSoPhong.Text = dgDuLieu.Rows[vitrichon].Cells[4].Value.ToString();
                if(gioiTinh == "Nam")
                {
                    rdNam.Checked = true;
                }
                if(gioiTinh == "Nữ")
                {
                    rdNu.Checked = true;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(dgDuLieu.Rows[vitrichon].Cells[0].Value);
            string gioiTinh = "";
            if (rdNam.Checked = true)
            {
                gioiTinh = "Nam";
                
            }
            if (rdNu.Checked = true)
            {
                gioiTinh = "Nữ";
                
            }
            string sql = "update KhachHang " +
                         "Set hoTen = @hoTen, " +
                         "gioiTinh = @gioiTinh, " +
                         "loaiPhong = @loaiPhong, " +
                         "soPhongThue = @soPhong " +
                         "where STT = " + stt;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hoTen", txtTen.Text);
            cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@loaiPhong", cbLoaiPhong.Text);
            cmd.Parameters.AddWithValue("@soPhong", txtSoPhong.Text);
            cmd.ExecuteNonQuery();
            ThongKe();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            string sql = "select STT,hoTen,gioiTinh,loaiPhong,soPhongThue from  KhachHang where hoTen = N'" + ten + "'";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            dt.Fill(ds);
            dgDuLieu.DataSource = ds;
            


        }
    }
}
