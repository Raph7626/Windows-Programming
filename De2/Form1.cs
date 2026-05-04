using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void dgDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach(DataGridViewRow row in dgDuLieu.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    tong += Convert.ToInt32(row.Cells[4].Value);
                }
            }
            txtTongTien.Text = tong + "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenHang.Text == "Bánh mì") txtDonGia.Text = "15000";
            else if (cbTenHang.Text == "Sữa") txtDonGia.Text = "10000";
            else txtDonGia.Text = "5000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgDuLieu.Rows.Clear();
            txtTongTien.Clear();
            txtTen.Clear();
            cbTenHang.Text = "";
            numSoLuong.Value = 0;
            txtDonGia.Clear();

        }

        int stt = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            stt += 1;
            int sl = Convert.ToInt32(numSoLuong.Value);
            int dg = int.Parse(txtDonGia.Text);
            int tt = sl * dg;
            dgDuLieu.Rows.Add(stt,cbTenHang.Text,numSoLuong.Value,txtDonGia.Text,tt);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDuLieu.CurrentRow != null)
                dgDuLieu.Rows.Remove(dgDuLieu.CurrentRow);
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }



        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = contextMenuStrip1.SourceControl;
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                control.ForeColor = c.Color;
            }
        }
    }
}
