namespace De4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNgoaiNgu = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbMa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDiem = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbPhanLoai = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgThongKe = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiem)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNgoaiNgu);
            this.tabPage1.Controls.Add(this.txtVan);
            this.tabPage1.Controls.Add(this.txtToan);
            this.tabPage1.Controls.Add(this.txtTen);
            this.tabPage1.Controls.Add(this.cbMa);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgDiem);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lí điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNgoaiNgu
            // 
            this.txtNgoaiNgu.Location = new System.Drawing.Point(681, 73);
            this.txtNgoaiNgu.Name = "txtNgoaiNgu";
            this.txtNgoaiNgu.Size = new System.Drawing.Size(94, 22);
            this.txtNgoaiNgu.TabIndex = 4;
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(392, 79);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(155, 22);
            this.txtVan.TabIndex = 3;
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(110, 79);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(155, 22);
            this.txtToan.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(420, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(273, 22);
            this.txtTen.TabIndex = 7;
            this.txtTen.TabStop = false;
            // 
            // cbMa
            // 
            this.cbMa.FormattingEnabled = true;
            this.cbMa.Location = new System.Drawing.Point(111, 24);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(154, 24);
            this.cbMa.TabIndex = 1;
            this.cbMa.SelectedIndexChanged += new System.EventHandler(this.cbMa_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.Location = new System.Drawing.Point(447, 126);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 31);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Silver;
            this.btnSua.Location = new System.Drawing.Point(310, 126);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 31);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Location = new System.Drawing.Point(173, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 31);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điểm Ngoại Ngữ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Điểm Văn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV";
            // 
            // dgDiem
            // 
            this.dgDiem.AllowUserToAddRows = false;
            this.dgDiem.AllowUserToDeleteRows = false;
            this.dgDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDiem.Location = new System.Drawing.Point(3, 181);
            this.dgDiem.Name = "dgDiem";
            this.dgDiem.RowHeadersWidth = 51;
            this.dgDiem.RowTemplate.Height = 24;
            this.dgDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDiem.Size = new System.Drawing.Size(786, 237);
            this.dgDiem.TabIndex = 2;
            this.dgDiem.TabStop = false;
            this.dgDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDiem_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbPhanLoai);
            this.tabPage3.Controls.Add(this.btnThongKe);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dgThongKe);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbPhanLoai
            // 
            this.cbPhanLoai.FormattingEnabled = true;
            this.cbPhanLoai.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung Bình"});
            this.cbPhanLoai.Location = new System.Drawing.Point(156, 21);
            this.cbPhanLoai.Name = "cbPhanLoai";
            this.cbPhanLoai.Size = new System.Drawing.Size(196, 24);
            this.cbPhanLoai.TabIndex = 9;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Silver;
            this.btnThongKe.Location = new System.Drawing.Point(472, 24);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(92, 37);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Phân loại sinh viên";
            // 
            // dgThongKe
            // 
            this.dgThongKe.AllowUserToAddRows = false;
            this.dgThongKe.AllowUserToDeleteRows = false;
            this.dgThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgThongKe.Location = new System.Drawing.Point(3, 181);
            this.dgThongKe.Name = "dgThongKe";
            this.dgThongKe.RowHeadersWidth = 51;
            this.dgThongKe.RowTemplate.Height = 24;
            this.dgThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgThongKe.Size = new System.Drawing.Size(786, 237);
            this.dgThongKe.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lí điểm thi(Nguyễn Duy Kiên_2451160799)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiem)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDiem;
        private System.Windows.Forms.TextBox txtNgoaiNgu;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cbMa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbPhanLoai;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgThongKe;
    }
}

