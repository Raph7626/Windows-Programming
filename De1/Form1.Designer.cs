namespace De1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.cbPhim = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panelGhe = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(56, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chọn phim:";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(56, 105);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(254, 16);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "Mời bạn chọn ghế trong phòng chiếu phim";
            // 
            // cbPhim
            // 
            this.cbPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPhim.FormattingEnabled = true;
            this.cbPhim.Items.AddRange(new object[] {
            "Doraemon",
            "Conan",
            "Siêu nhân",
            "Tiểu La Hắc"});
            this.cbPhim.Location = new System.Drawing.Point(135, 48);
            this.cbPhim.Name = "cbPhim";
            this.cbPhim.Size = new System.Drawing.Size(413, 24);
            this.cbPhim.TabIndex = 2;
            this.cbPhim.SelectedIndexChanged += new System.EventHandler(this.cbPhim_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Location = new System.Drawing.Point(656, 455);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(116, 33);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(56, 463);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(78, 16);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Thành Tiền:";
            // 
            // panelGhe
            // 
            this.panelGhe.AutoScroll = true;
            this.panelGhe.Location = new System.Drawing.Point(59, 138);
            this.panelGhe.Name = "panelGhe";
            this.panelGhe.Size = new System.Drawing.Size(713, 296);
            this.panelGhe.TabIndex = 5;
            this.panelGhe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGhe_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.panelGhe);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cbPhim);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình bán vé xem phim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.ComboBox cbPhim;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panelGhe;
    }
}

