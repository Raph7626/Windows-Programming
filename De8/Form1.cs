using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-4C3209M\\SQLEXPRESS;Initial Catalog = De8; Integrated Security = True");
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        void DatHang()
        {
            string sql = "Select * from Dathang";
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            dt.Fill(ds);
            dataGridView1.DataSource = ds;
            cbDoUong.DataSource = ds;
            cbDoUong.DisplayMember = "doUong";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            DatHang();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select soBan as 'Số bàn',doUong as 'Tên đồ uống', soLuong as 'Số Lượng',gia as 'Giá',ngay as 'Ngày' from DatHang where 1=1";
            if (chkDoUong.Checked)
            {
                sql += " and doUong = N'" + cbDoUong.Text + "'" ;
            }
            if (chkNgay.Checked)
            {
                sql += " and ngay between '" + dtTuNgay.Value.ToString("yyyy-MM-dd") + "' and  '" + dtDenNgay.Value.ToString("yyyy-MM-dd") + "'";
            }
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            dt.Fill(ds);
            dataGridView1.DataSource = ds;
            int tong = 0;
            foreach(DataRow row in ds.Rows)
            {
                tong += Convert.ToInt32(row["Số lượng"]) * Convert.ToInt32(row["Giá"]);
            }
            txtDoanhThu.Text = tong + "";

        }
    }
}
