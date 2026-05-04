using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-4C3209M\\SQLEXPRESS;Initial Catalog = De5;Integrated Security = True");
        void ThanhToan()
        {
            string ban = cbBan.Text;

            string sql = "select * from DatHang where soBan = N'" + ban + "'";

            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            dt.Fill(ds);

            dataGridView1.DataSource = ds;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThanhToan();

            if (dataGridView1.Rows.Count > 0)
            {
                int gia = Convert.ToInt32(dataGridView1.Rows[0].Cells[4].Value);
                int soLuong = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value);

                txtTien.Text = (gia * soLuong).ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
