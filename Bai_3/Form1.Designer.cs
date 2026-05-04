namespace Bai_3
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
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpSach = new System.Windows.Forms.TabPage();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btnTongtien = new System.Windows.Forms.Label();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThongke = new System.Windows.Forms.TabPage();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.tpNXB = new System.Windows.Forms.TabPage();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.dgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.btnXoaLoai = new System.Windows.Forms.Button();
            this.btnSuaLoai = new System.Windows.Forms.Button();
            this.tpLoaiSach = new System.Windows.Forms.TabPage();
            this.txtTenLS = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTacgia = new System.Windows.Forms.TabPage();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnSuaTG = new System.Windows.Forms.Button();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.tpSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.tpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.tbThongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.tpNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).BeginInit();
            this.tpLoaiSach.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTacgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(123, 32);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(308, 26);
            this.txtMaTG.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã tác giả:";
            // 
            // tpSach
            // 
            this.tpSach.Controls.Add(this.cbLoai);
            this.tpSach.Controls.Add(this.txtMaSach);
            this.tpSach.Controls.Add(this.cbNXB);
            this.tpSach.Controls.Add(this.cbTacGia);
            this.tpSach.Controls.Add(this.dgvSach);
            this.tpSach.Controls.Add(this.btnXoaSach);
            this.tpSach.Controls.Add(this.btnSuaSach);
            this.tpSach.Controls.Add(this.btnThemSach);
            this.tpSach.Controls.Add(this.txtSL);
            this.tpSach.Controls.Add(this.txtDonGia);
            this.tpSach.Controls.Add(this.label13);
            this.tpSach.Controls.Add(this.label12);
            this.tpSach.Controls.Add(this.label11);
            this.tpSach.Controls.Add(this.label10);
            this.tpSach.Controls.Add(this.label9);
            this.tpSach.Controls.Add(this.label8);
            this.tpSach.Controls.Add(this.txtTenSach);
            this.tpSach.Controls.Add(this.label7);
            this.tpSach.Location = new System.Drawing.Point(4, 29);
            this.tpSach.Name = "tpSach";
            this.tpSach.Padding = new System.Windows.Forms.Padding(3);
            this.tpSach.Size = new System.Drawing.Size(943, 445);
            this.tpSach.TabIndex = 3;
            this.tpSach.Text = "Sách";
            this.tpSach.UseVisualStyleBackColor = true;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(0, 195);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 28;
            this.dgvSach.Size = new System.Drawing.Size(947, 266);
            this.dgvSach.TabIndex = 19;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(637, 153);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(84, 29);
            this.btnXoaSach.TabIndex = 18;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(523, 153);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(84, 29);
            this.btnSuaSach.TabIndex = 17;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(413, 153);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(84, 29);
            this.btnThemSach.TabIndex = 16;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(99, 154);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(136, 26);
            this.txtSL.TabIndex = 15;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(473, 111);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(248, 26);
            this.txtDonGia.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Số lượng: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Đơn giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "NXB:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tác giả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Loại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(473, 20);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(248, 26);
            this.txtTenSach.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã sách:";
            // 
            // cbTK
            // 
            this.cbTK.FormattingEnabled = true;
            this.cbTK.Items.AddRange(new object[] {
            "Loại",
            "Tác giả",
            "NXB"});
            this.cbTK.Location = new System.Drawing.Point(163, 35);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(218, 28);
            this.cbTK.TabIndex = 1;
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.Controls.Add(this.txtTongtien);
            this.tpHoaDon.Controls.Add(this.btnTongtien);
            this.tpHoaDon.Controls.Add(this.dgvBanHang);
            this.tpHoaDon.Controls.Add(this.btnXoaHD);
            this.tpHoaDon.Controls.Add(this.btnSuaHD);
            this.tpHoaDon.Controls.Add(this.btnThemHD);
            this.tpHoaDon.Controls.Add(this.txtSDT);
            this.tpHoaDon.Controls.Add(this.txtTenKH);
            this.tpHoaDon.Controls.Add(this.txtMaHD);
            this.tpHoaDon.Controls.Add(this.label16);
            this.tpHoaDon.Controls.Add(this.label15);
            this.tpHoaDon.Controls.Add(this.label14);
            this.tpHoaDon.Location = new System.Drawing.Point(4, 29);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoaDon.Size = new System.Drawing.Size(943, 445);
            this.tpHoaDon.TabIndex = 4;
            this.tpHoaDon.Text = "Bán hàng";
            this.tpHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(450, 75);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(273, 26);
            this.txtTongtien.TabIndex = 11;
            // 
            // btnTongtien
            // 
            this.btnTongtien.AutoSize = true;
            this.btnTongtien.Location = new System.Drawing.Point(361, 75);
            this.btnTongtien.Name = "btnTongtien";
            this.btnTongtien.Size = new System.Drawing.Size(79, 20);
            this.btnTongtien.TabIndex = 10;
            this.btnTongtien.Text = "Tổng tiền:";
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AllowUserToAddRows = false;
            this.dgvBanHang.AllowUserToDeleteRows = false;
            this.dgvBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Location = new System.Drawing.Point(0, 176);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.RowHeadersWidth = 62;
            this.dgvBanHang.RowTemplate.Height = 28;
            this.dgvBanHang.Size = new System.Drawing.Size(947, 269);
            this.dgvBanHang.TabIndex = 9;
            this.dgvBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHang_CellClick);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(641, 123);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(92, 31);
            this.btnXoaHD.TabIndex = 8;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(505, 123);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(92, 31);
            this.btnSuaHD.TabIndex = 7;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(375, 123);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(92, 31);
            this.btnThemHD.TabIndex = 6;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(80, 69);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(253, 26);
            this.txtSDT.TabIndex = 5;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(450, 19);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(273, 26);
            this.txtTenKH.TabIndex = 4;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(122, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(211, 26);
            this.txtMaHD.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "SĐT:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên khách:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã hóa đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên tác giả: ";
            // 
            // tbThongke
            // 
            this.tbThongke.Controls.Add(this.dgvThongKe);
            this.tbThongke.Controls.Add(this.btnThongKe);
            this.tbThongke.Controls.Add(this.cbTK);
            this.tbThongke.Controls.Add(this.label17);
            this.tbThongke.Location = new System.Drawing.Point(4, 29);
            this.tbThongke.Name = "tbThongke";
            this.tbThongke.Padding = new System.Windows.Forms.Padding(3);
            this.tbThongke.Size = new System.Drawing.Size(943, 445);
            this.tbThongke.TabIndex = 5;
            this.tbThongke.Text = "Thống kê";
            this.tbThongke.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(-4, 104);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 62;
            this.dgvThongKe.RowTemplate.Height = 28;
            this.dgvThongKe.Size = new System.Drawing.Size(951, 345);
            this.dgvThongKe.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(469, 30);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(121, 36);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Thống kê theo:";
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(296, 119);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(112, 46);
            this.btnXoaNXB.TabIndex = 6;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // tpNXB
            // 
            this.tpNXB.Controls.Add(this.dgvNXB);
            this.tpNXB.Controls.Add(this.btnXoaNXB);
            this.tpNXB.Controls.Add(this.btnSuaNXB);
            this.tpNXB.Controls.Add(this.btnThemNXB);
            this.tpNXB.Controls.Add(this.txtTenNXB);
            this.tpNXB.Controls.Add(this.txtMaNXB);
            this.tpNXB.Controls.Add(this.label2);
            this.tpNXB.Controls.Add(this.label1);
            this.tpNXB.Location = new System.Drawing.Point(4, 29);
            this.tpNXB.Name = "tpNXB";
            this.tpNXB.Padding = new System.Windows.Forms.Padding(3);
            this.tpNXB.Size = new System.Drawing.Size(943, 445);
            this.tpNXB.TabIndex = 1;
            this.tpNXB.Text = "Nhà xuất bản";
            this.tpNXB.UseVisualStyleBackColor = true;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(-4, 171);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersWidth = 62;
            this.dgvNXB.RowTemplate.Height = 28;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(947, 271);
            this.dgvNXB.TabIndex = 7;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.Location = new System.Drawing.Point(160, 119);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(112, 46);
            this.btnSuaNXB.TabIndex = 5;
            this.btnSuaNXB.Text = "Sửa";
            this.btnSuaNXB.UseVisualStyleBackColor = true;
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(27, 119);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(112, 46);
            this.btnThemNXB.TabIndex = 4;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(126, 75);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(291, 26);
            this.txtTenNXB.TabIndex = 3;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(126, 31);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(291, 26);
            this.txtMaNXB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NXB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            // 
            // txtMaLS
            // 
            this.txtMaLS.Location = new System.Drawing.Point(137, 23);
            this.txtMaLS.Name = "txtMaLS";
            this.txtMaLS.Size = new System.Drawing.Size(272, 26);
            this.txtMaLS.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên loại sách: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã loại sách: ";
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(30, 120);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(106, 41);
            this.btnThemLoai.TabIndex = 4;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.AllowUserToAddRows = false;
            this.dgvLoaiSach.AllowUserToDeleteRows = false;
            this.dgvLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSach.Location = new System.Drawing.Point(0, 167);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.RowHeadersWidth = 62;
            this.dgvLoaiSach.RowTemplate.Height = 28;
            this.dgvLoaiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSach.Size = new System.Drawing.Size(943, 282);
            this.dgvLoaiSach.TabIndex = 7;
            this.dgvLoaiSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSach_CellClick);
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Location = new System.Drawing.Point(303, 120);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(106, 41);
            this.btnXoaLoai.TabIndex = 6;
            this.btnXoaLoai.Text = "Xóa";
            this.btnXoaLoai.UseVisualStyleBackColor = true;
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Location = new System.Drawing.Point(167, 120);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(106, 41);
            this.btnSuaLoai.TabIndex = 5;
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.UseVisualStyleBackColor = true;
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // tpLoaiSach
            // 
            this.tpLoaiSach.Controls.Add(this.dgvLoaiSach);
            this.tpLoaiSach.Controls.Add(this.btnXoaLoai);
            this.tpLoaiSach.Controls.Add(this.btnSuaLoai);
            this.tpLoaiSach.Controls.Add(this.btnThemLoai);
            this.tpLoaiSach.Controls.Add(this.txtTenLS);
            this.tpLoaiSach.Controls.Add(this.txtMaLS);
            this.tpLoaiSach.Controls.Add(this.label4);
            this.tpLoaiSach.Controls.Add(this.label3);
            this.tpLoaiSach.Location = new System.Drawing.Point(4, 29);
            this.tpLoaiSach.Name = "tpLoaiSach";
            this.tpLoaiSach.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoaiSach.Size = new System.Drawing.Size(943, 445);
            this.tpLoaiSach.TabIndex = 0;
            this.tpLoaiSach.Text = "Loại sách";
            this.tpLoaiSach.UseVisualStyleBackColor = true;
            // 
            // txtTenLS
            // 
            this.txtTenLS.Location = new System.Drawing.Point(137, 79);
            this.txtTenLS.Name = "txtTenLS";
            this.txtTenLS.Size = new System.Drawing.Size(272, 26);
            this.txtTenLS.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLoaiSach);
            this.tabControl1.Controls.Add(this.tpNXB);
            this.tabControl1.Controls.Add(this.tpTacgia);
            this.tabControl1.Controls.Add(this.tpSach);
            this.tabControl1.Controls.Add(this.tpHoaDon);
            this.tabControl1.Controls.Add(this.tbThongke);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 478);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpTacgia
            // 
            this.tpTacgia.Controls.Add(this.dgvTacGia);
            this.tpTacgia.Controls.Add(this.btnXoaTG);
            this.tpTacgia.Controls.Add(this.btnSuaTG);
            this.tpTacgia.Controls.Add(this.btnThemTG);
            this.tpTacgia.Controls.Add(this.txtTenTG);
            this.tpTacgia.Controls.Add(this.txtMaTG);
            this.tpTacgia.Controls.Add(this.label6);
            this.tpTacgia.Controls.Add(this.label5);
            this.tpTacgia.Location = new System.Drawing.Point(4, 29);
            this.tpTacgia.Name = "tpTacgia";
            this.tpTacgia.Padding = new System.Windows.Forms.Padding(3);
            this.tpTacgia.Size = new System.Drawing.Size(943, 445);
            this.tpTacgia.TabIndex = 2;
            this.tpTacgia.Text = "Tác giả";
            this.tpTacgia.UseVisualStyleBackColor = true;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Location = new System.Drawing.Point(0, 177);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersWidth = 62;
            this.dgvTacGia.RowTemplate.Height = 28;
            this.dgvTacGia.Size = new System.Drawing.Size(943, 272);
            this.dgvTacGia.TabIndex = 7;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);
            // 
            // btnXoaTG
            // 
            this.btnXoaTG.Location = new System.Drawing.Point(328, 131);
            this.btnXoaTG.Name = "btnXoaTG";
            this.btnXoaTG.Size = new System.Drawing.Size(103, 40);
            this.btnXoaTG.TabIndex = 6;
            this.btnXoaTG.Text = "Xóa";
            this.btnXoaTG.UseVisualStyleBackColor = true;
            this.btnXoaTG.Click += new System.EventHandler(this.btnXoaTG_Click);
            // 
            // btnSuaTG
            // 
            this.btnSuaTG.Location = new System.Drawing.Point(175, 131);
            this.btnSuaTG.Name = "btnSuaTG";
            this.btnSuaTG.Size = new System.Drawing.Size(103, 40);
            this.btnSuaTG.TabIndex = 5;
            this.btnSuaTG.Text = "Sửa";
            this.btnSuaTG.UseVisualStyleBackColor = true;
            this.btnSuaTG.Click += new System.EventHandler(this.btnSuaTG_Click);
            // 
            // btnThemTG
            // 
            this.btnThemTG.Location = new System.Drawing.Point(21, 131);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(103, 40);
            this.btnThemTG.TabIndex = 4;
            this.btnThemTG.Text = "Thêm";
            this.btnThemTG.UseVisualStyleBackColor = true;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(122, 86);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(309, 26);
            this.txtTenTG.TabIndex = 3;
            // 
            // cbTacGia
            // 
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(473, 64);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(248, 28);
            this.cbTacGia.TabIndex = 20;
            // 
            // cbNXB
            // 
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(100, 111);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(248, 28);
            this.cbNXB.TabIndex = 23;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(99, 20);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(248, 26);
            this.txtMaSach.TabIndex = 25;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(100, 64);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(247, 28);
            this.cbLoai.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpSach.ResumeLayout(false);
            this.tpSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.tpHoaDon.ResumeLayout(false);
            this.tpHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.tbThongke.ResumeLayout(false);
            this.tbThongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.tpNXB.ResumeLayout(false);
            this.tpNXB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSach)).EndInit();
            this.tpLoaiSach.ResumeLayout(false);
            this.tpLoaiSach.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpTacgia.ResumeLayout(false);
            this.tpTacgia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpSach;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTK;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label btnTongtien;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbThongke;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.TabPage tpNXB;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Button btnSuaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.DataGridView dgvLoaiSach;
        private System.Windows.Forms.Button btnXoaLoai;
        private System.Windows.Forms.Button btnSuaLoai;
        private System.Windows.Forms.TabPage tpLoaiSach;
        private System.Windows.Forms.TextBox txtTenLS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTacgia;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.Button btnXoaTG;
        private System.Windows.Forms.Button btnSuaTG;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtMaSach;
    }
}

