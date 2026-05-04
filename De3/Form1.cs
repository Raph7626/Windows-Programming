using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if(rdNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            
            dgDuLieu.Rows.Add(txtMa.Text, txtTen.Text, date.Text,gioiTinh,cbNoiSinh.Text);
        }

        int vitrichon = 0;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitrichon >= 0)
            {
                string gioiTinh;
                if (rdNam.Checked == true)
                    gioiTinh = "Nam";
                else
                    gioiTinh = "Nữ";

                dgDuLieu.Rows[vitrichon].Cells[0].Value = txtMa.Text;
                dgDuLieu.Rows[vitrichon].Cells[1].Value = txtTen.Text;
                dgDuLieu.Rows[vitrichon].Cells[2].Value = date.Text;
                dgDuLieu.Rows[vitrichon].Cells[3].Value = gioiTinh;
                dgDuLieu.Rows[vitrichon].Cells[4].Value = cbNoiSinh.Text;

                MessageBox.Show("Sửa thành công!");
            }


        }

        private void dgDuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon = e.RowIndex;
            txtMa.Text = dgDuLieu.Rows[vitrichon].Cells[0].Value.ToString();
            txtTen.Text = dgDuLieu.Rows[vitrichon].Cells[1].Value.ToString();
            date.Value = Convert.ToDateTime(dgDuLieu.Rows[vitrichon].Cells[2].Value);
            string gioiTinh = dgDuLieu.Rows[vitrichon].Cells[3].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            cbNoiSinh.Text = dgDuLieu.Rows[vitrichon].Cells[4].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(vitrichon >= 0)
            {
                dgDuLieu.Rows.RemoveAt(vitrichon);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            FormTimKiem f = new FormTimKiem(dgDuLieu);
            f.ShowDialog();
        }
    }
}
