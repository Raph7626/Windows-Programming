namespace QL_SinhVien
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoSV = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblLocKhoa = new System.Windows.Forms.Label();
            this.lblLocGT = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.tbHoSV = new System.Windows.Forms.TextBox();
            this.tbTenSV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbLocKhoa = new System.Windows.Forms.ComboBox();
            this.cbLocGT = new System.Windows.Forms.ComboBox();
            this.dgSinhVien = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLoc = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chương Trình Quản Lý Sinh Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(20, 68);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(75, 15);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã Sinh viên";
            // 
            // lblHoSV
            // 
            this.lblHoSV.AutoSize = true;
            this.lblHoSV.Location = new System.Drawing.Point(260, 68);
            this.lblHoSV.Name = "lblHoSV";
            this.lblHoSV.Size = new System.Drawing.Size(74, 15);
            this.lblHoSV.TabIndex = 3;
            this.lblHoSV.Text = "Họ Sinh viên";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(500, 68);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(77, 15);
            this.lblTenSV.TabIndex = 5;
            this.lblTenSV.Text = "Tên Sinh viên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 110);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 15);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(310, 110);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(52, 15);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(510, 110);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(54, 15);
            this.lblMaKhoa.TabIndex = 12;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblLocKhoa
            // 
            this.lblLocKhoa.AutoSize = true;
            this.lblLocKhoa.Location = new System.Drawing.Point(20, 148);
            this.lblLocKhoa.Name = "lblLocKhoa";
            this.lblLocKhoa.Size = new System.Drawing.Size(86, 15);
            this.lblLocKhoa.TabIndex = 14;
            this.lblLocKhoa.Text = "Lọc theo Khoa:";
            // 
            // lblLocGT
            // 
            this.lblLocGT.AutoSize = true;
            this.lblLocGT.Location = new System.Drawing.Point(280, 148);
            this.lblLocGT.Name = "lblLocGT";
            this.lblLocGT.Size = new System.Drawing.Size(74, 15);
            this.lblLocGT.TabIndex = 16;
            this.lblLocGT.Text = "Lọc theo GT:";
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(118, 65);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(130, 23);
            this.tbMaSV.TabIndex = 2;
            // 
            // tbHoSV
            // 
            this.tbHoSV.Location = new System.Drawing.Point(355, 65);
            this.tbHoSV.Name = "tbHoSV";
            this.tbHoSV.Size = new System.Drawing.Size(130, 23);
            this.tbHoSV.TabIndex = 4;
            // 
            // tbTenSV
            // 
            this.tbTenSV.Location = new System.Drawing.Point(595, 65);
            this.tbTenSV.Name = "tbTenSV";
            this.tbTenSV.Size = new System.Drawing.Size(130, 23);
            this.tbTenSV.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(103, 107);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(170, 23);
            this.dtpNgaySinh.TabIndex = 8;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // rbNam
            // 
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(380, 109);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(55, 20);
            this.rbNam.TabIndex = 10;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            this.rbNu.Location = new System.Drawing.Point(440, 109);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(50, 20);
            this.rbNu.TabIndex = 11;
            this.rbNu.Text = "Nữ";
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhoa.Items.AddRange(new object[] {
            "TOAN",
            "HOAH",
            "DIAL",
            "CNTT",
            "LY",
            "HOA"});
            this.cbMaKhoa.Location = new System.Drawing.Point(575, 107);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(150, 23);
            this.cbMaKhoa.TabIndex = 13;
            // 
            // cbLocKhoa
            // 
            this.cbLocKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocKhoa.Items.AddRange(new object[] {
            "-- Tất cả --",
            "TOAN",
            "HOAH",
            "DIAL",
            "CNTT",
            "LY",
            "HOA"});
            this.cbLocKhoa.Location = new System.Drawing.Point(118, 145);
            this.cbLocKhoa.Name = "cbLocKhoa";
            this.cbLocKhoa.Size = new System.Drawing.Size(140, 23);
            this.cbLocKhoa.TabIndex = 15;
            // 
            // cbLocGT
            // 
            this.cbLocGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocGT.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Nam",
            "Nữ"});
            this.cbLocGT.Location = new System.Drawing.Point(370, 145);
            this.cbLocGT.Name = "cbLocGT";
            this.cbLocGT.Size = new System.Drawing.Size(110, 23);
            this.cbLocGT.TabIndex = 17;
            // 
            // dgSinhVien
            // 
            this.dgSinhVien.AllowUserToAddRows = false;
            this.dgSinhVien.AllowUserToDeleteRows = false;
            this.dgSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSinhVien.Location = new System.Drawing.Point(20, 185);
            this.dgSinhVien.MultiSelect = false;
            this.dgSinhVien.Name = "dgSinhVien";
            this.dgSinhVien.ReadOnly = true;
            this.dgSinhVien.RowHeadersVisible = false;
            this.dgSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSinhVien.Size = new System.Drawing.Size(740, 275);
            this.dgSinhVien.TabIndex = 19;
            this.dgSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSinhVien_CellClick);
            this.dgSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSinhVien_CellContentClick);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btThem.Location = new System.Drawing.Point(140, 475);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 28);
            this.btThem.TabIndex = 20;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSua.Location = new System.Drawing.Point(240, 475);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 28);
            this.btSua.TabIndex = 21;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXoa.Location = new System.Drawing.Point(340, 475);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 28);
            this.btXoa.TabIndex = 22;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLoc
            // 
            this.btLoc.Location = new System.Drawing.Point(495, 143);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(65, 26);
            this.btLoc.TabIndex = 18;
            this.btLoc.Text = "Lọc";
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(580, 475);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 28);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 521);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.tbMaSV);
            this.Controls.Add(this.lblHoSV);
            this.Controls.Add(this.tbHoSV);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.tbTenSV);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.cbMaKhoa);
            this.Controls.Add(this.lblLocKhoa);
            this.Controls.Add(this.cbLocKhoa);
            this.Controls.Add(this.lblLocGT);
            this.Controls.Add(this.cbLocGT);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.dgSinhVien);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label        lblTitle, lblMaSV, lblHoSV, lblTenSV;
        private System.Windows.Forms.Label        lblNgaySinh, lblGioiTinh, lblMaKhoa, lblLocKhoa, lblLocGT;
        private System.Windows.Forms.TextBox      tbMaSV, tbHoSV, tbTenSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton  rbNam, rbNu;
        private System.Windows.Forms.ComboBox     cbMaKhoa, cbLocKhoa, cbLocGT;
        private System.Windows.Forms.DataGridView dgSinhVien;
        private System.Windows.Forms.Button       btThem, btSua, btXoa, btLoc, btThoat;
    }
}
