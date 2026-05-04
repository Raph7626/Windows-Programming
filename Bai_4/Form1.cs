using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham frm = new frmQuanLySanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lậpĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapDonHang frm = new frmLapDonHang();
            frm.MdiParent = this;
            frm.Show();

        }

        private void danhSáchĐơnHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCapNhatDonHang frm = new frmCapNhatDonHang();
            frm.MdiParent = this;
            frm.Show();

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
