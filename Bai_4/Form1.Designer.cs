namespace Bai_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐơnHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.lậpĐơnHàngToolStripMenuItem,
            this.danhSáchĐơnHàngToolStripMenuItem,
            this.danhSáchĐơnHàngToolStripMenuItem1,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1175, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // lậpĐơnHàngToolStripMenuItem
            // 
            this.lậpĐơnHàngToolStripMenuItem.Name = "lậpĐơnHàngToolStripMenuItem";
            this.lậpĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.lậpĐơnHàngToolStripMenuItem.Text = "Lập đơn hàng";
            this.lậpĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.lậpĐơnHàngToolStripMenuItem_Click);
            // 
            // danhSáchĐơnHàngToolStripMenuItem
            // 
            this.danhSáchĐơnHàngToolStripMenuItem.Name = "danhSáchĐơnHàngToolStripMenuItem";
            this.danhSáchĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(16, 29);
            // 
            // danhSáchĐơnHàngToolStripMenuItem1
            // 
            this.danhSáchĐơnHàngToolStripMenuItem1.Name = "danhSáchĐơnHàngToolStripMenuItem1";
            this.danhSáchĐơnHàngToolStripMenuItem1.Size = new System.Drawing.Size(181, 32);
            this.danhSáchĐơnHàngToolStripMenuItem1.Text = "Cập nhật đơn hàng";
            this.danhSáchĐơnHàngToolStripMenuItem1.Click += new System.EventHandler(this.danhSáchĐơnHàngToolStripMenuItem1_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 605);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý cửa hàng đồ ăn nhanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐơnHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}

