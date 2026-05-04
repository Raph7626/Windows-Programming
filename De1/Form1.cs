using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tongTien = 0;
        ToolTip tip = new ToolTip();
        
        int LayGia(string tenGhe)
        {
            char hang = tenGhe[0];
            if (hang == 'A') return 25000;
            else if (hang == 'B') return 30000;
            else if (hang == 'C') return 35000;
            else if (hang == 'D') return 40000;
            else if (hang == 'E') return 45000;
            else if (hang == 'F') return 50000;
            return 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int startX = 20;
            int startY = 20;

            int width = 50;
            int height = 40;

            int khoangCach = 10;

            char[] hang = { 'A', 'B', 'C', 'D', 'E', 'F' };

            for(int i = 0;i < hang.Length;i++)
            {
                for(int j = 1; j <= 6; j++)
                {
                    Button btn = new Button();

                    btn.Text = hang[i].ToString() + j;

                    btn.Left = startX + j * (width + khoangCach);
                    btn.Top = startY + i * (height + khoangCach);

                    btn.Width = width;
                    btn.Height = height;

                    int gia = LayGia(btn.Text);
                    tip.SetToolTip(btn, "Giá: " + gia + "đ");
                    panelGhe.Controls.Add(btn); 
                }
            }

        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblThongBao.Text =  "Mời bạn chọn ghế trong phòng chiếu phim: " + cbPhim.Text;
        }

        private void panelGhe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
