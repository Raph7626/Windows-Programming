namespace QL_Sach
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
            this.tabMain      = new System.Windows.Forms.TabControl();
            this.tpLoaiSach   = new System.Windows.Forms.TabPage();
            this.tpNXB        = new System.Windows.Forms.TabPage();
            this.tpTacgia     = new System.Windows.Forms.TabPage();
            this.tpSach       = new System.Windows.Forms.TabPage();
            this.tpHoaDon     = new System.Windows.Forms.TabPage();
            this.tpThongke    = new System.Windows.Forms.TabPage();
            this.lblMaLoai    = new System.Windows.Forms.Label();
            this.lblTenLoai   = new System.Windows.Forms.Label();
            this.tbMaLoai     = new System.Windows.Forms.TextBox();
            this.tbTenLoai    = new System.Windows.Forms.TextBox();
            this.btThemLoai   = new System.Windows.Forms.Button();
            this.btSuaLoai    = new System.Windows.Forms.Button();
            this.btXoaLoai    = new System.Windows.Forms.Button();
            this.dgLoaiSach   = new System.Windows.Forms.DataGridView();
            this.lblMaNXB     = new System.Windows.Forms.Label();
            this.lblTenNXB    = new System.Windows.Forms.Label();
            this.tbMaNXB      = new System.Windows.Forms.TextBox();
            this.tbTenNXB     = new System.Windows.Forms.TextBox();
            this.btThemNXB    = new System.Windows.Forms.Button();
            this.btSuaNXB     = new System.Windows.Forms.Button();
            this.btXoaNXB     = new System.Windows.Forms.Button();
            this.dgNXB        = new System.Windows.Forms.DataGridView();
            this.lblMaTG      = new System.Windows.Forms.Label();
            this.lblTenTG     = new System.Windows.Forms.Label();
            this.tbMaTG       = new System.Windows.Forms.TextBox();
            this.tbTenTG      = new System.Windows.Forms.TextBox();
            this.btThemTG     = new System.Windows.Forms.Button();
            this.btSuaTG      = new System.Windows.Forms.Button();
            this.btXoaTG      = new System.Windows.Forms.Button();
            this.dgTacgia     = new System.Windows.Forms.DataGridView();
            this.lblMaSach    = new System.Windows.Forms.Label();
            this.lblTenSach   = new System.Windows.Forms.Label();
            this.lblLoai      = new System.Windows.Forms.Label();
            this.lblTacGia    = new System.Windows.Forms.Label();
            this.lblNXBs      = new System.Windows.Forms.Label();
            this.lblDonGia    = new System.Windows.Forms.Label();
            this.lblSoLuong   = new System.Windows.Forms.Label();
            this.tbMaSach     = new System.Windows.Forms.TextBox();
            this.tbTenSach    = new System.Windows.Forms.TextBox();
            this.cbLoai       = new System.Windows.Forms.ComboBox();
            this.cbTacGia     = new System.Windows.Forms.ComboBox();
            this.cbNXB        = new System.Windows.Forms.ComboBox();
            this.tbDonGia     = new System.Windows.Forms.TextBox();
            this.tbSoLuong    = new System.Windows.Forms.TextBox();
            this.btThemSach   = new System.Windows.Forms.Button();
            this.btSuaSach    = new System.Windows.Forms.Button();
            this.btXoaSach    = new System.Windows.Forms.Button();
            this.dgSach       = new System.Windows.Forms.DataGridView();
            this.lblMaHD      = new System.Windows.Forms.Label();
            this.lblTenKhach  = new System.Windows.Forms.Label();
            this.lblSDT       = new System.Windows.Forms.Label();
            this.lblSachHD    = new System.Windows.Forms.Label();
            this.lblSLBan     = new System.Windows.Forms.Label();
            this.lblGiaBan    = new System.Windows.Forms.Label();
            this.tbMaHD       = new System.Windows.Forms.TextBox();
            this.tbTenKhach   = new System.Windows.Forms.TextBox();
            this.tbSDT        = new System.Windows.Forms.TextBox();
            this.cbSachHD     = new System.Windows.Forms.ComboBox();
            this.tbSLBan      = new System.Windows.Forms.TextBox();
            this.tbGiaBan     = new System.Windows.Forms.TextBox();
            this.btThemHD     = new System.Windows.Forms.Button();
            this.btXoaHD      = new System.Windows.Forms.Button();
            this.btThemCT     = new System.Windows.Forms.Button();
            this.dgHoaDon     = new System.Windows.Forms.DataGridView();
            this.dgChiTiet    = new System.Windows.Forms.DataGridView();
            this.lblTKLoai    = new System.Windows.Forms.Label();
            this.lblTKTG      = new System.Windows.Forms.Label();
            this.lblTKNXB     = new System.Windows.Forms.Label();
            this.dgTKLoai     = new System.Windows.Forms.DataGridView();
            this.dgTKTacGia   = new System.Windows.Forms.DataGridView();
            this.dgTKNXB      = new System.Windows.Forms.DataGridView();
            this.btLamMoiTK   = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTacgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTKLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTKTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTKNXB)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tpLoaiSach, this.tpNXB, this.tpTacgia, this.tpSach, this.tpHoaDon, this.tpThongke });
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(960, 600);
            this.tabMain.TabIndex = 0;

            this.tpLoaiSach.Name = "tpLoaiSach"; this.tpLoaiSach.Text = "Loại sách";   this.tpLoaiSach.TabIndex = 0;
            this.tpNXB.Name      = "tpNXB";      this.tpNXB.Text      = "Nhà xuất bản"; this.tpNXB.TabIndex      = 1;
            this.tpTacgia.Name   = "tpTacgia";   this.tpTacgia.Text   = "Tác giả";      this.tpTacgia.TabIndex   = 2;
            this.tpSach.Name     = "tpSach";      this.tpSach.Text     = "Sách";         this.tpSach.TabIndex     = 3;
            this.tpHoaDon.Name   = "tpHoaDon";   this.tpHoaDon.Text   = "Bán hàng";    this.tpHoaDon.TabIndex   = 4;
            this.tpThongke.Name  = "Thongke";     this.tpThongke.Text  = "Thống kê";    this.tpThongke.TabIndex  = 5;

            // ===================== tpLoaiSach =====================
            this.lblMaLoai.Text = "Mã Loại:";
            this.lblMaLoai.Location = new System.Drawing.Point(10, 15);
            this.lblMaLoai.AutoSize = true;

            this.lblTenLoai.Text = "Tên Loại:";
            this.lblTenLoai.Location = new System.Drawing.Point(10, 45);
            this.lblTenLoai.AutoSize = true;

            this.tbMaLoai.Location = new System.Drawing.Point(90, 12);
            this.tbMaLoai.Size = new System.Drawing.Size(150, 22);

            this.tbTenLoai.Location = new System.Drawing.Point(90, 42);
            this.tbTenLoai.Size = new System.Drawing.Size(250, 22);

            this.btThemLoai.Text = "Thêm";
            this.btThemLoai.Location = new System.Drawing.Point(10, 75);
            this.btThemLoai.Size = new System.Drawing.Size(75, 26);
            this.btThemLoai.Click += new System.EventHandler(this.btThemLoai_Click);

            this.btSuaLoai.Text = "Sửa";
            this.btSuaLoai.Location = new System.Drawing.Point(95, 75);
            this.btSuaLoai.Size = new System.Drawing.Size(75, 26);
            this.btSuaLoai.Click += new System.EventHandler(this.btSuaLoai_Click);

            this.btXoaLoai.Text = "Xóa";
            this.btXoaLoai.Location = new System.Drawing.Point(180, 75);
            this.btXoaLoai.Size = new System.Drawing.Size(75, 26);
            this.btXoaLoai.Click += new System.EventHandler(this.btXoaLoai_Click);

            this.dgLoaiSach.Location = new System.Drawing.Point(10, 115);
            this.dgLoaiSach.Size = new System.Drawing.Size(900, 420);
            this.dgLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLoaiSach.AllowUserToAddRows = false;
            this.dgLoaiSach.AllowUserToDeleteRows = false;
            this.dgLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoaiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLoaiSach.MultiSelect = false;
            this.dgLoaiSach.ReadOnly = true;
            this.dgLoaiSach.RowHeadersVisible = false;
            this.dgLoaiSach.TabIndex = 0;
            this.dgLoaiSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoaiSach_CellClick);

            this.tpLoaiSach.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaLoai, this.tbMaLoai, this.lblTenLoai, this.tbTenLoai,
                this.btThemLoai, this.btSuaLoai, this.btXoaLoai, this.dgLoaiSach });

            // ===================== tpNXB =====================
            this.lblMaNXB.Text = "Mã NXB:";
            this.lblMaNXB.Location = new System.Drawing.Point(10, 15);
            this.lblMaNXB.AutoSize = true;

            this.lblTenNXB.Text = "Tên NXB:";
            this.lblTenNXB.Location = new System.Drawing.Point(10, 45);
            this.lblTenNXB.AutoSize = true;

            this.tbMaNXB.Location = new System.Drawing.Point(90, 12);
            this.tbMaNXB.Size = new System.Drawing.Size(150, 22);

            this.tbTenNXB.Location = new System.Drawing.Point(90, 42);
            this.tbTenNXB.Size = new System.Drawing.Size(250, 22);

            this.btThemNXB.Text = "Thêm";
            this.btThemNXB.Location = new System.Drawing.Point(10, 75);
            this.btThemNXB.Size = new System.Drawing.Size(75, 26);
            this.btThemNXB.Click += new System.EventHandler(this.btThemNXB_Click);

            this.btSuaNXB.Text = "Sửa";
            this.btSuaNXB.Location = new System.Drawing.Point(95, 75);
            this.btSuaNXB.Size = new System.Drawing.Size(75, 26);
            this.btSuaNXB.Click += new System.EventHandler(this.btSuaNXB_Click);

            this.btXoaNXB.Text = "Xóa";
            this.btXoaNXB.Location = new System.Drawing.Point(180, 75);
            this.btXoaNXB.Size = new System.Drawing.Size(75, 26);
            this.btXoaNXB.Click += new System.EventHandler(this.btXoaNXB_Click);

            this.dgNXB.Location = new System.Drawing.Point(10, 115);
            this.dgNXB.Size = new System.Drawing.Size(900, 420);
            this.dgNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNXB.AllowUserToAddRows = false;
            this.dgNXB.AllowUserToDeleteRows = false;
            this.dgNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNXB.MultiSelect = false;
            this.dgNXB.ReadOnly = true;
            this.dgNXB.RowHeadersVisible = false;
            this.dgNXB.TabIndex = 0;
            this.dgNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNXB_CellClick);

            this.tpNXB.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaNXB, this.tbMaNXB, this.lblTenNXB, this.tbTenNXB,
                this.btThemNXB, this.btSuaNXB, this.btXoaNXB, this.dgNXB });

            // ===================== tpTacgia =====================
            this.lblMaTG.Text = "Mã TG:";
            this.lblMaTG.Location = new System.Drawing.Point(10, 15);
            this.lblMaTG.AutoSize = true;

            this.lblTenTG.Text = "Tên Tác Giả:";
            this.lblTenTG.Location = new System.Drawing.Point(10, 45);
            this.lblTenTG.AutoSize = true;

            this.tbMaTG.Location = new System.Drawing.Point(110, 12);
            this.tbMaTG.Size = new System.Drawing.Size(150, 22);

            this.tbTenTG.Location = new System.Drawing.Point(110, 42);
            this.tbTenTG.Size = new System.Drawing.Size(250, 22);

            this.btThemTG.Text = "Thêm";
            this.btThemTG.Location = new System.Drawing.Point(10, 75);
            this.btThemTG.Size = new System.Drawing.Size(75, 26);
            this.btThemTG.Click += new System.EventHandler(this.btThemTG_Click);

            this.btSuaTG.Text = "Sửa";
            this.btSuaTG.Location = new System.Drawing.Point(95, 75);
            this.btSuaTG.Size = new System.Drawing.Size(75, 26);
            this.btSuaTG.Click += new System.EventHandler(this.btSuaTG_Click);

            this.btXoaTG.Text = "Xóa";
            this.btXoaTG.Location = new System.Drawing.Point(180, 75);
            this.btXoaTG.Size = new System.Drawing.Size(75, 26);
            this.btXoaTG.Click += new System.EventHandler(this.btXoaTG_Click);

            this.dgTacgia.Location = new System.Drawing.Point(10, 115);
            this.dgTacgia.Size = new System.Drawing.Size(900, 420);
            this.dgTacgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTacgia.AllowUserToAddRows = false;
            this.dgTacgia.AllowUserToDeleteRows = false;
            this.dgTacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTacgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTacgia.MultiSelect = false;
            this.dgTacgia.ReadOnly = true;
            this.dgTacgia.RowHeadersVisible = false;
            this.dgTacgia.TabIndex = 0;
            this.dgTacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTacgia_CellClick);

            this.tpTacgia.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaTG, this.tbMaTG, this.lblTenTG, this.tbTenTG,
                this.btThemTG, this.btSuaTG, this.btXoaTG, this.dgTacgia });

            // ===================== tpSach =====================
            this.lblMaSach.Text = "Mã Sách:";
            this.lblMaSach.Location = new System.Drawing.Point(10, 15);
            this.lblMaSach.AutoSize = true;

            this.lblTenSach.Text = "Tên Sách:";
            this.lblTenSach.Location = new System.Drawing.Point(10, 45);
            this.lblTenSach.AutoSize = true;

            this.lblLoai.Text = "Loại:";
            this.lblLoai.Location = new System.Drawing.Point(10, 75);
            this.lblLoai.AutoSize = true;

            this.lblTacGia.Text = "Tác Giả:";
            this.lblTacGia.Location = new System.Drawing.Point(10, 105);
            this.lblTacGia.AutoSize = true;

            this.lblNXBs.Text = "NXB:";
            this.lblNXBs.Location = new System.Drawing.Point(10, 135);
            this.lblNXBs.AutoSize = true;

            this.lblDonGia.Text = "Đơn Giá:";
            this.lblDonGia.Location = new System.Drawing.Point(310, 75);
            this.lblDonGia.AutoSize = true;

            this.lblSoLuong.Text = "Số Lượng:";
            this.lblSoLuong.Location = new System.Drawing.Point(310, 105);
            this.lblSoLuong.AutoSize = true;

            this.tbMaSach.Location = new System.Drawing.Point(90, 12);
            this.tbMaSach.Size = new System.Drawing.Size(150, 22);

            this.tbTenSach.Location = new System.Drawing.Point(90, 42);
            this.tbTenSach.Size = new System.Drawing.Size(400, 22);

            this.cbLoai.Location = new System.Drawing.Point(90, 72);
            this.cbLoai.Size = new System.Drawing.Size(200, 22);
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.TabIndex = 0;

            this.cbTacGia.Location = new System.Drawing.Point(90, 102);
            this.cbTacGia.Size = new System.Drawing.Size(200, 22);
            this.cbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTacGia.TabIndex = 1;

            this.cbNXB.Location = new System.Drawing.Point(90, 132);
            this.cbNXB.Size = new System.Drawing.Size(200, 22);
            this.cbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNXB.TabIndex = 2;

            this.tbDonGia.Location = new System.Drawing.Point(390, 72);
            this.tbDonGia.Size = new System.Drawing.Size(120, 22);

            this.tbSoLuong.Location = new System.Drawing.Point(390, 102);
            this.tbSoLuong.Size = new System.Drawing.Size(120, 22);

            this.btThemSach.Text = "Thêm";
            this.btThemSach.Location = new System.Drawing.Point(10, 165);
            this.btThemSach.Size = new System.Drawing.Size(75, 26);
            this.btThemSach.Click += new System.EventHandler(this.btThemSach_Click);

            this.btSuaSach.Text = "Sửa";
            this.btSuaSach.Location = new System.Drawing.Point(95, 165);
            this.btSuaSach.Size = new System.Drawing.Size(75, 26);
            this.btSuaSach.Click += new System.EventHandler(this.btSuaSach_Click);

            this.btXoaSach.Text = "Xóa";
            this.btXoaSach.Location = new System.Drawing.Point(180, 165);
            this.btXoaSach.Size = new System.Drawing.Size(75, 26);
            this.btXoaSach.Click += new System.EventHandler(this.btXoaSach_Click);

            this.dgSach.Location = new System.Drawing.Point(10, 205);
            this.dgSach.Size = new System.Drawing.Size(900, 330);
            this.dgSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSach.AllowUserToAddRows = false;
            this.dgSach.AllowUserToDeleteRows = false;
            this.dgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSach.MultiSelect = false;
            this.dgSach.ReadOnly = true;
            this.dgSach.RowHeadersVisible = false;
            this.dgSach.TabIndex = 0;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);

            this.tpSach.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaSach, this.tbMaSach, this.lblTenSach, this.tbTenSach,
                this.lblLoai, this.cbLoai, this.lblTacGia, this.cbTacGia, this.lblNXBs, this.cbNXB,
                this.lblDonGia, this.tbDonGia, this.lblSoLuong, this.tbSoLuong,
                this.btThemSach, this.btSuaSach, this.btXoaSach, this.dgSach });

            // ===================== tpHoaDon =====================
            this.lblMaHD.Text = "Mã HD:";
            this.lblMaHD.Location = new System.Drawing.Point(10, 15);
            this.lblMaHD.AutoSize = true;

            this.lblTenKhach.Text = "Tên Khách:";
            this.lblTenKhach.Location = new System.Drawing.Point(10, 45);
            this.lblTenKhach.AutoSize = true;

            this.lblSDT.Text = "SĐT:";
            this.lblSDT.Location = new System.Drawing.Point(10, 75);
            this.lblSDT.AutoSize = true;

            this.tbMaHD.Location = new System.Drawing.Point(90, 12);
            this.tbMaHD.Size = new System.Drawing.Size(130, 22);

            this.tbTenKhach.Location = new System.Drawing.Point(90, 42);
            this.tbTenKhach.Size = new System.Drawing.Size(180, 22);

            this.tbSDT.Location = new System.Drawing.Point(90, 72);
            this.tbSDT.Size = new System.Drawing.Size(130, 22);

            this.btThemHD.Text = "Tạo HĐ";
            this.btThemHD.Location = new System.Drawing.Point(10, 105);
            this.btThemHD.Size = new System.Drawing.Size(80, 26);
            this.btThemHD.Click += new System.EventHandler(this.btThemHD_Click);

            this.btXoaHD.Text = "Xóa HĐ";
            this.btXoaHD.Location = new System.Drawing.Point(100, 105);
            this.btXoaHD.Size = new System.Drawing.Size(80, 26);
            this.btXoaHD.Click += new System.EventHandler(this.btXoaHD_Click);

            this.dgHoaDon.Location = new System.Drawing.Point(10, 145);
            this.dgHoaDon.Size = new System.Drawing.Size(400, 370);
            this.dgHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgHoaDon.AllowUserToAddRows = false;
            this.dgHoaDon.AllowUserToDeleteRows = false;
            this.dgHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHoaDon.MultiSelect = false;
            this.dgHoaDon.ReadOnly = true;
            this.dgHoaDon.RowHeadersVisible = false;
            this.dgHoaDon.TabIndex = 0;
            this.dgHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoaDon_CellClick);

            this.lblSachHD.Text = "Sách:";
            this.lblSachHD.Location = new System.Drawing.Point(430, 15);
            this.lblSachHD.AutoSize = true;

            this.cbSachHD.Location = new System.Drawing.Point(490, 12);
            this.cbSachHD.Size = new System.Drawing.Size(420, 22);
            this.cbSachHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSachHD.TabIndex = 0;
            this.cbSachHD.SelectedIndexChanged += new System.EventHandler(this.cbSachHD_SelectedIndexChanged);

            this.lblSLBan.Text = "Số Lượng:";
            this.lblSLBan.Location = new System.Drawing.Point(430, 45);
            this.lblSLBan.AutoSize = true;

            this.lblGiaBan.Text = "Giá Bán:";
            this.lblGiaBan.Location = new System.Drawing.Point(430, 75);
            this.lblGiaBan.AutoSize = true;

            this.tbSLBan.Location = new System.Drawing.Point(510, 42);
            this.tbSLBan.Size = new System.Drawing.Size(80, 22);

            this.tbGiaBan.Location = new System.Drawing.Point(510, 72);
            this.tbGiaBan.Size = new System.Drawing.Size(100, 22);

            this.btThemCT.Text = "Thêm vào HĐ";
            this.btThemCT.Location = new System.Drawing.Point(430, 105);
            this.btThemCT.Size = new System.Drawing.Size(120, 26);
            this.btThemCT.Click += new System.EventHandler(this.btThemCT_Click);

            this.dgChiTiet.Location = new System.Drawing.Point(430, 145);
            this.dgChiTiet.Size = new System.Drawing.Size(490, 370);
            this.dgChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChiTiet.AllowUserToAddRows = false;
            this.dgChiTiet.AllowUserToDeleteRows = false;
            this.dgChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChiTiet.MultiSelect = false;
            this.dgChiTiet.ReadOnly = true;
            this.dgChiTiet.RowHeadersVisible = false;
            this.dgChiTiet.TabIndex = 1;

            this.tpHoaDon.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaHD, this.tbMaHD, this.lblTenKhach, this.tbTenKhach, this.lblSDT, this.tbSDT,
                this.btThemHD, this.btXoaHD, this.dgHoaDon,
                this.lblSachHD, this.cbSachHD, this.lblSLBan, this.tbSLBan, this.lblGiaBan, this.tbGiaBan,
                this.btThemCT, this.dgChiTiet });

            // ===================== tpThongke =====================
            this.lblTKLoai.Text = "Theo Loại Sách";
            this.lblTKLoai.Location = new System.Drawing.Point(10, 8);
            this.lblTKLoai.AutoSize = true;
            this.lblTKLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblTKTG.Text = "Theo Tác Giả";
            this.lblTKTG.Location = new System.Drawing.Point(320, 8);
            this.lblTKTG.AutoSize = true;
            this.lblTKTG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblTKNXB.Text = "Theo NXB";
            this.lblTKNXB.Location = new System.Drawing.Point(635, 8);
            this.lblTKNXB.AutoSize = true;
            this.lblTKNXB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.dgTKLoai.Location = new System.Drawing.Point(10, 28);
            this.dgTKLoai.Size = new System.Drawing.Size(290, 480);
            this.dgTKLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTKLoai.AllowUserToAddRows = false;
            this.dgTKLoai.AllowUserToDeleteRows = false;
            this.dgTKLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTKLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTKLoai.ReadOnly = true;
            this.dgTKLoai.RowHeadersVisible = false;
            this.dgTKLoai.TabIndex = 0;

            this.dgTKTacGia.Location = new System.Drawing.Point(320, 28);
            this.dgTKTacGia.Size = new System.Drawing.Size(290, 480);
            this.dgTKTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTKTacGia.AllowUserToAddRows = false;
            this.dgTKTacGia.AllowUserToDeleteRows = false;
            this.dgTKTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTKTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTKTacGia.ReadOnly = true;
            this.dgTKTacGia.RowHeadersVisible = false;
            this.dgTKTacGia.TabIndex = 1;

            this.dgTKNXB.Location = new System.Drawing.Point(635, 28);
            this.dgTKNXB.Size = new System.Drawing.Size(280, 480);
            this.dgTKNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTKNXB.AllowUserToAddRows = false;
            this.dgTKNXB.AllowUserToDeleteRows = false;
            this.dgTKNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTKNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTKNXB.ReadOnly = true;
            this.dgTKNXB.RowHeadersVisible = false;
            this.dgTKNXB.TabIndex = 2;

            this.btLamMoiTK.Text = "Làm mới";
            this.btLamMoiTK.Location = new System.Drawing.Point(400, 515);
            this.btLamMoiTK.Size = new System.Drawing.Size(80, 26);
            this.btLamMoiTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLamMoiTK.Click += new System.EventHandler(this.btLamMoiTK_Click);

            this.tpThongke.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTKLoai, this.lblTKTG, this.lblTKNXB,
                this.dgTKLoai, this.dgTKTacGia, this.dgTKNXB, this.btLamMoiTK });

            // ===================== Form =====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTacgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTKLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTKTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTKNXB)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl  tabMain;
        private System.Windows.Forms.TabPage     tpLoaiSach, tpNXB, tpTacgia, tpSach, tpHoaDon, tpThongke;
        private System.Windows.Forms.Label       lblMaLoai, lblTenLoai;
        private System.Windows.Forms.TextBox     tbMaLoai, tbTenLoai;
        private System.Windows.Forms.Button      btThemLoai, btSuaLoai, btXoaLoai;
        private System.Windows.Forms.DataGridView dgLoaiSach;
        private System.Windows.Forms.Label       lblMaNXB, lblTenNXB;
        private System.Windows.Forms.TextBox     tbMaNXB, tbTenNXB;
        private System.Windows.Forms.Button      btThemNXB, btSuaNXB, btXoaNXB;
        private System.Windows.Forms.DataGridView dgNXB;
        private System.Windows.Forms.Label       lblMaTG, lblTenTG;
        private System.Windows.Forms.TextBox     tbMaTG, tbTenTG;
        private System.Windows.Forms.Button      btThemTG, btSuaTG, btXoaTG;
        private System.Windows.Forms.DataGridView dgTacgia;
        private System.Windows.Forms.Label       lblMaSach, lblTenSach, lblLoai, lblTacGia, lblNXBs, lblDonGia, lblSoLuong;
        private System.Windows.Forms.TextBox     tbMaSach, tbTenSach, tbDonGia, tbSoLuong;
        private System.Windows.Forms.ComboBox    cbLoai, cbTacGia, cbNXB;
        private System.Windows.Forms.Button      btThemSach, btSuaSach, btXoaSach;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.Label       lblMaHD, lblTenKhach, lblSDT, lblSachHD, lblSLBan, lblGiaBan;
        private System.Windows.Forms.TextBox     tbMaHD, tbTenKhach, tbSDT, tbSLBan, tbGiaBan;
        private System.Windows.Forms.ComboBox    cbSachHD;
        private System.Windows.Forms.Button      btThemHD, btXoaHD, btThemCT;
        private System.Windows.Forms.DataGridView dgHoaDon, dgChiTiet;
        private System.Windows.Forms.Label       lblTKLoai, lblTKTG, lblTKNXB;
        private System.Windows.Forms.DataGridView dgTKLoai, dgTKTacGia, dgTKNXB;
        private System.Windows.Forms.Button      btLamMoiTK;
    }
}
