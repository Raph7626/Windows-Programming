using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=.\\SQLEXPRESS; Initial Catalog=QLSV; Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            try
            {
                conn.Open();

                string sql = "select * from SinhVien where 1=1;";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSV.DataSource = dt;

                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
