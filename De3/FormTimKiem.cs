using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De3
{
    public partial class FormTimKiem : Form
    {
        DataGridView data;
        public FormTimKiem(DataGridView dg)
        {
            InitializeComponent();
            data = dg;

        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtMaTK.Text.ToLower();
            string noiSinh = cbNoiSinhTK.Text.ToLower();
            string gioiTinh = "";

            if (rdNamTK.Checked) gioiTinh = "Nam";
            else if (rdNuTK.Checked) gioiTinh = "Nữ";

            for (int i = 0; i < data.Rows.Count; i++)
            {
                bool match = true;

                // Mã SV
                if (ma != "" && !data.Rows[i].Cells[0].Value.ToString().ToLower().Contains(ma))
                    match = false;

                // Nơi sinh
                if (noiSinh != "" && !data.Rows[i].Cells[4].Value.ToString().ToLower().Contains(noiSinh))
                    match = false;

                // Giới tính
                if (gioiTinh != "" && data.Rows[i].Cells[3].Value.ToString() != gioiTinh)
                    match = false;

                // Hiển thị / ẩn dòng
                data.Rows[i].Visible = match;
            }

        }
    }
}
