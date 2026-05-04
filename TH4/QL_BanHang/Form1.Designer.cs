namespace QL_BanHang
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
            this.tpSanPham    = new System.Windows.Forms.TabPage();
            this.tpLapDon     = new System.Windows.Forms.TabPage();
            this.tpDanhSach   = new System.Windows.Forms.TabPage();
            this.tpThongKe    = new System.Windows.Forms.TabPage();

            // Tab Sản phẩm
            this.lblTimKiem   = new System.Windows.Forms.Label();
            this.tbTimKiem    = new System.Windows.Forms.TextBox();
            this.lblMaSP      = new System.Windows.Forms.Label();
            this.lblTenSP     = new System.Windows.Forms.Label();
            this.lblDonVi     = new System.Windows.Forms.Label();
            this.lblDonGia    = new System.Windows.Forms.Label();
            this.lblTonKho    = new System.Windows.Forms.Label();
            this.lblNhapThem  = new System.Windows.Forms.Label();
            this.tbMaSP       = new System.Windows.Forms.TextBox();
            this.tbTenSP      = new System.Windows.Forms.TextBox();
            this.tbDonVi      = new System.Windows.Forms.TextBox();
            this.tbDonGia     = new System.Windows.Forms.TextBox();
            this.tbTonKho     = new System.Windows.Forms.TextBox();
            this.tbNhapThem   = new System.Windows.Forms.TextBox();
            this.btThemSP     = new System.Windows.Forms.Button();
            this.btSuaSP      = new System.Windows.Forms.Button();
            this.btXoaSP      = new System.Windows.Forms.Button();
            this.btNhapHang   = new System.Windows.Forms.Button();
            this.dgSanPham    = new System.Windows.Forms.DataGridView();

            // Tab Lập đơn
            this.lblSPTitle   = new System.Windows.Forms.Label();
            this.lblGioTitle  = new System.Windows.Forms.Label();
            this.lblMaSPDon   = new System.Windows.Forms.Label();
            this.lblTenSPDon  = new System.Windows.Forms.Label();
            this.lblDonGiaDon = new System.Windows.Forms.Label();
            this.lblSoLuong   = new System.Windows.Forms.Label();
            this.lblTongLabel = new System.Windows.Forms.Label();
            this.lblTong      = new System.Windows.Forms.Label();
            this.tbMaSPDon    = new System.Windows.Forms.TextBox();
            this.tbTenSPDon   = new System.Windows.Forms.TextBox();
            this.tbDonGiaDon  = new System.Windows.Forms.TextBox();
            this.tbSoLuong    = new System.Windows.Forms.TextBox();
            this.dgSPLapDon   = new System.Windows.Forms.DataGridView();
            this.dgGioHang    = new System.Windows.Forms.DataGridView();
            this.btThemVaoGio = new System.Windows.Forms.Button();
            this.btXoaKhoiGio = new System.Windows.Forms.Button();
            this.btXacNhan    = new System.Windows.Forms.Button();

            // Tab Danh sách đơn
            this.lblTu        = new System.Windows.Forms.Label();
            this.lblDen       = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMaDon     = new System.Windows.Forms.Label();
            this.lblTTDon     = new System.Windows.Forms.Label();
            this.lblDSTitle   = new System.Windows.Forms.Label();
            this.lblCTTitle   = new System.Windows.Forms.Label();
            this.dtpTu        = new System.Windows.Forms.DateTimePicker();
            this.dtpDen       = new System.Windows.Forms.DateTimePicker();
            this.cbTrangThai  = new System.Windows.Forms.ComboBox();
            this.tbMaDon      = new System.Windows.Forms.TextBox();
            this.tbTrangThai  = new System.Windows.Forms.TextBox();
            this.dgDonHang    = new System.Windows.Forms.DataGridView();
            this.dgChiTiet    = new System.Windows.Forms.DataGridView();
            this.btLoc        = new System.Windows.Forms.Button();
            this.btHuyDon     = new System.Windows.Forms.Button();
            this.btThanhToan  = new System.Windows.Forms.Button();

            // Tab Thống kê
            this.lblTuTK      = new System.Windows.Forms.Label();
            this.lblDenTK     = new System.Windows.Forms.Label();
            this.lblThang     = new System.Windows.Forms.Label();
            this.lblNam       = new System.Windows.Forms.Label();
            this.dtpTuTK      = new System.Windows.Forms.DateTimePicker();
            this.dtpDenTK     = new System.Windows.Forms.DateTimePicker();
            this.cbThang      = new System.Windows.Forms.ComboBox();
            this.cbNam        = new System.Windows.Forms.ComboBox();
            this.dgThongKe    = new System.Windows.Forms.DataGridView();
            this.btTKMatHang  = new System.Windows.Forms.Button();
            this.btTKNgay     = new System.Windows.Forms.Button();
            this.btTKThang    = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSPLapDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKe)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tpSanPham, this.tpLapDon, this.tpDanhSach, this.tpThongKe });
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(980, 620);
            this.tabMain.TabIndex = 0;

            this.tpSanPham.Name  = "tpSanPham";  this.tpSanPham.Text  = "Sản phẩm";        this.tpSanPham.TabIndex  = 0;
            this.tpLapDon.Name   = "tpLapDon";   this.tpLapDon.Text   = "Lập đơn hàng";    this.tpLapDon.TabIndex   = 1;
            this.tpDanhSach.Name = "tpDanhSach"; this.tpDanhSach.Text = "Danh sách đơn";   this.tpDanhSach.TabIndex = 2;
            this.tpThongKe.Name  = "tpThongKe";  this.tpThongKe.Text  = "Thống kê";        this.tpThongKe.TabIndex  = 3;

            // ===================== tpSanPham =====================
            this.lblTimKiem.Text = "Tìm kiếm:";
            this.lblTimKiem.Location = new System.Drawing.Point(10, 12);
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.TabIndex = 0;

            this.tbTimKiem.Location = new System.Drawing.Point(85, 9);
            this.tbTimKiem.Size = new System.Drawing.Size(200, 22);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);

            this.lblMaSP.Text = "Mã SP:";
            this.lblMaSP.Location = new System.Drawing.Point(10, 50);
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.TabIndex = 2;

            this.tbMaSP.Location = new System.Drawing.Point(85, 47);
            this.tbMaSP.Size = new System.Drawing.Size(140, 22);
            this.tbMaSP.TabIndex = 3;

            this.lblTenSP.Text = "Tên SP:";
            this.lblTenSP.Location = new System.Drawing.Point(10, 82);
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.TabIndex = 4;

            this.tbTenSP.Location = new System.Drawing.Point(85, 79);
            this.tbTenSP.Size = new System.Drawing.Size(300, 22);
            this.tbTenSP.TabIndex = 5;

            this.lblDonVi.Text = "Đơn vị:";
            this.lblDonVi.Location = new System.Drawing.Point(10, 114);
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.TabIndex = 6;

            this.tbDonVi.Location = new System.Drawing.Point(85, 111);
            this.tbDonVi.Size = new System.Drawing.Size(100, 22);
            this.tbDonVi.TabIndex = 7;

            this.lblDonGia.Text = "Đơn giá:";
            this.lblDonGia.Location = new System.Drawing.Point(10, 146);
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.TabIndex = 8;

            this.tbDonGia.Location = new System.Drawing.Point(85, 143);
            this.tbDonGia.Size = new System.Drawing.Size(120, 22);
            this.tbDonGia.TabIndex = 9;

            this.lblTonKho.Text = "Tồn kho:";
            this.lblTonKho.Location = new System.Drawing.Point(10, 178);
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.TabIndex = 10;

            this.tbTonKho.Location = new System.Drawing.Point(85, 175);
            this.tbTonKho.Size = new System.Drawing.Size(100, 22);
            this.tbTonKho.TabIndex = 11;

            this.btThemSP.Text = "Thêm";
            this.btThemSP.Location = new System.Drawing.Point(10, 210);
            this.btThemSP.Size = new System.Drawing.Size(75, 26);
            this.btThemSP.TabIndex = 12;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);

            this.btSuaSP.Text = "Sửa";
            this.btSuaSP.Location = new System.Drawing.Point(95, 210);
            this.btSuaSP.Size = new System.Drawing.Size(75, 26);
            this.btSuaSP.TabIndex = 13;
            this.btSuaSP.Click += new System.EventHandler(this.btSuaSP_Click);

            this.btXoaSP.Text = "Xóa";
            this.btXoaSP.Location = new System.Drawing.Point(180, 210);
            this.btXoaSP.Size = new System.Drawing.Size(75, 26);
            this.btXoaSP.TabIndex = 14;
            this.btXoaSP.Click += new System.EventHandler(this.btXoaSP_Click);

            this.lblNhapThem.Text = "Nhập thêm SL:";
            this.lblNhapThem.Location = new System.Drawing.Point(10, 250);
            this.lblNhapThem.AutoSize = true;
            this.lblNhapThem.TabIndex = 15;

            this.tbNhapThem.Location = new System.Drawing.Point(105, 247);
            this.tbNhapThem.Size = new System.Drawing.Size(80, 22);
            this.tbNhapThem.TabIndex = 16;

            this.btNhapHang.Text = "Nhập hàng";
            this.btNhapHang.Location = new System.Drawing.Point(195, 245);
            this.btNhapHang.Size = new System.Drawing.Size(90, 26);
            this.btNhapHang.TabIndex = 17;
            this.btNhapHang.Click += new System.EventHandler(this.btNhapHang_Click);

            this.dgSanPham.Location = new System.Drawing.Point(10, 285);
            this.dgSanPham.Size = new System.Drawing.Size(920, 270);
            this.dgSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSanPham.AllowUserToAddRows = false;
            this.dgSanPham.AllowUserToDeleteRows = false;
            this.dgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSanPham.MultiSelect = false;
            this.dgSanPham.ReadOnly = true;
            this.dgSanPham.RowHeadersVisible = false;
            this.dgSanPham.TabIndex = 18;
            this.dgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellClick);

            this.tpSanPham.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTimKiem, this.tbTimKiem,
                this.lblMaSP, this.tbMaSP, this.lblTenSP, this.tbTenSP,
                this.lblDonVi, this.tbDonVi, this.lblDonGia, this.tbDonGia,
                this.lblTonKho, this.tbTonKho,
                this.btThemSP, this.btSuaSP, this.btXoaSP,
                this.lblNhapThem, this.tbNhapThem, this.btNhapHang,
                this.dgSanPham });

            // ===================== tpLapDon =====================
            this.lblSPTitle.Text = "Danh sách sản phẩm";
            this.lblSPTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSPTitle.Location = new System.Drawing.Point(10, 8);
            this.lblSPTitle.AutoSize = true;
            this.lblSPTitle.TabIndex = 0;

            this.dgSPLapDon.Location = new System.Drawing.Point(10, 28);
            this.dgSPLapDon.Size = new System.Drawing.Size(440, 270);
            this.dgSPLapDon.AllowUserToAddRows = false;
            this.dgSPLapDon.AllowUserToDeleteRows = false;
            this.dgSPLapDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSPLapDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSPLapDon.MultiSelect = false;
            this.dgSPLapDon.ReadOnly = true;
            this.dgSPLapDon.RowHeadersVisible = false;
            this.dgSPLapDon.TabIndex = 1;
            this.dgSPLapDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSPLapDon_CellClick);

            this.lblMaSPDon.Text = "Mã SP:";
            this.lblMaSPDon.Location = new System.Drawing.Point(10, 310);
            this.lblMaSPDon.AutoSize = true;
            this.lblMaSPDon.TabIndex = 2;

            this.tbMaSPDon.Location = new System.Drawing.Point(80, 307);
            this.tbMaSPDon.Size = new System.Drawing.Size(120, 22);
            this.tbMaSPDon.ReadOnly = true;
            this.tbMaSPDon.TabIndex = 3;

            this.lblTenSPDon.Text = "Tên SP:";
            this.lblTenSPDon.Location = new System.Drawing.Point(10, 338);
            this.lblTenSPDon.AutoSize = true;
            this.lblTenSPDon.TabIndex = 4;

            this.tbTenSPDon.Location = new System.Drawing.Point(80, 335);
            this.tbTenSPDon.Size = new System.Drawing.Size(250, 22);
            this.tbTenSPDon.ReadOnly = true;
            this.tbTenSPDon.TabIndex = 5;

            this.lblDonGiaDon.Text = "Đơn giá:";
            this.lblDonGiaDon.Location = new System.Drawing.Point(10, 366);
            this.lblDonGiaDon.AutoSize = true;
            this.lblDonGiaDon.TabIndex = 6;

            this.tbDonGiaDon.Location = new System.Drawing.Point(80, 363);
            this.tbDonGiaDon.Size = new System.Drawing.Size(120, 22);
            this.tbDonGiaDon.ReadOnly = true;
            this.tbDonGiaDon.TabIndex = 7;

            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.Location = new System.Drawing.Point(10, 394);
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.TabIndex = 8;

            this.tbSoLuong.Location = new System.Drawing.Point(80, 391);
            this.tbSoLuong.Size = new System.Drawing.Size(80, 22);
            this.tbSoLuong.Text = "1";
            this.tbSoLuong.TabIndex = 9;

            this.btThemVaoGio.Text = "Thêm vào giỏ";
            this.btThemVaoGio.Location = new System.Drawing.Point(10, 425);
            this.btThemVaoGio.Size = new System.Drawing.Size(120, 26);
            this.btThemVaoGio.TabIndex = 10;
            this.btThemVaoGio.Click += new System.EventHandler(this.btThemVaoGio_Click);

            this.lblGioTitle.Text = "Giỏ hàng";
            this.lblGioTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGioTitle.Location = new System.Drawing.Point(465, 8);
            this.lblGioTitle.AutoSize = true;
            this.lblGioTitle.TabIndex = 11;

            this.dgGioHang.Location = new System.Drawing.Point(465, 28);
            this.dgGioHang.Size = new System.Drawing.Size(480, 270);
            this.dgGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGioHang.AllowUserToAddRows = false;
            this.dgGioHang.AllowUserToDeleteRows = false;
            this.dgGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGioHang.MultiSelect = false;
            this.dgGioHang.ReadOnly = true;
            this.dgGioHang.RowHeadersVisible = false;
            this.dgGioHang.TabIndex = 12;

            this.btXoaKhoiGio.Text = "Xóa khỏi giỏ";
            this.btXoaKhoiGio.Location = new System.Drawing.Point(465, 310);
            this.btXoaKhoiGio.Size = new System.Drawing.Size(120, 26);
            this.btXoaKhoiGio.TabIndex = 13;
            this.btXoaKhoiGio.Click += new System.EventHandler(this.btXoaKhoiGio_Click);

            this.lblTongLabel.Text = "Tổng tiền:";
            this.lblTongLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongLabel.Location = new System.Drawing.Point(465, 350);
            this.lblTongLabel.AutoSize = true;
            this.lblTongLabel.TabIndex = 14;

            this.lblTong.Text = "0 đ";
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTong.Location = new System.Drawing.Point(570, 348);
            this.lblTong.AutoSize = true;
            this.lblTong.TabIndex = 15;

            this.btXacNhan.Text = "Xác nhận đặt hàng";
            this.btXacNhan.Location = new System.Drawing.Point(700, 425);
            this.btXacNhan.Size = new System.Drawing.Size(160, 26);
            this.btXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btXacNhan.TabIndex = 16;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);

            this.tpLapDon.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSPTitle, this.dgSPLapDon,
                this.lblMaSPDon, this.tbMaSPDon,
                this.lblTenSPDon, this.tbTenSPDon,
                this.lblDonGiaDon, this.tbDonGiaDon,
                this.lblSoLuong, this.tbSoLuong, this.btThemVaoGio,
                this.lblGioTitle, this.dgGioHang,
                this.btXoaKhoiGio, this.lblTongLabel, this.lblTong, this.btXacNhan });

            // ===================== tpDanhSach =====================
            this.lblTu.Text = "Từ ngày:";
            this.lblTu.Location = new System.Drawing.Point(10, 12);
            this.lblTu.AutoSize = true;
            this.lblTu.TabIndex = 0;

            this.dtpTu.Location = new System.Drawing.Point(75, 9);
            this.dtpTu.Size = new System.Drawing.Size(130, 22);
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Value = System.DateTime.Today.AddDays(-30);
            this.dtpTu.TabIndex = 1;

            this.lblDen.Text = "Đến ngày:";
            this.lblDen.Location = new System.Drawing.Point(215, 12);
            this.lblDen.AutoSize = true;
            this.lblDen.TabIndex = 2;

            this.dtpDen.Location = new System.Drawing.Point(285, 9);
            this.dtpDen.Size = new System.Drawing.Size(130, 22);
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.TabIndex = 3;

            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Location = new System.Drawing.Point(425, 12);
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.TabIndex = 4;

            this.cbTrangThai.Location = new System.Drawing.Point(505, 9);
            this.cbTrangThai.Size = new System.Drawing.Size(140, 22);
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Items.AddRange(new object[] { "-- Tất cả --", "Đã thanh toán", "Đã hủy" });
            this.cbTrangThai.SelectedIndex = 0;
            this.cbTrangThai.TabIndex = 5;

            this.btLoc.Text = "Lọc";
            this.btLoc.Location = new System.Drawing.Point(660, 7);
            this.btLoc.Size = new System.Drawing.Size(65, 26);
            this.btLoc.TabIndex = 6;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);

            this.lblDSTitle.Text = "Danh sách đơn hàng";
            this.lblDSTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDSTitle.Location = new System.Drawing.Point(10, 45);
            this.lblDSTitle.AutoSize = true;
            this.lblDSTitle.TabIndex = 7;

            this.dgDonHang.Location = new System.Drawing.Point(10, 65);
            this.dgDonHang.Size = new System.Drawing.Size(450, 280);
            this.dgDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.dgDonHang.AllowUserToAddRows = false;
            this.dgDonHang.AllowUserToDeleteRows = false;
            this.dgDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDonHang.MultiSelect = false;
            this.dgDonHang.ReadOnly = true;
            this.dgDonHang.RowHeadersVisible = false;
            this.dgDonHang.TabIndex = 8;
            this.dgDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDonHang_CellClick);

            this.lblMaDon.Text = "Mã đơn:";
            this.lblMaDon.Location = new System.Drawing.Point(10, 358);
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.TabIndex = 9;

            this.tbMaDon.Location = new System.Drawing.Point(80, 355);
            this.tbMaDon.Size = new System.Drawing.Size(130, 22);
            this.tbMaDon.ReadOnly = true;
            this.tbMaDon.TabIndex = 10;

            this.lblTTDon.Text = "Trạng thái:";
            this.lblTTDon.Location = new System.Drawing.Point(10, 386);
            this.lblTTDon.AutoSize = true;
            this.lblTTDon.TabIndex = 11;

            this.tbTrangThai.Location = new System.Drawing.Point(80, 383);
            this.tbTrangThai.Size = new System.Drawing.Size(130, 22);
            this.tbTrangThai.ReadOnly = true;
            this.tbTrangThai.TabIndex = 12;

            this.btHuyDon.Text = "Hủy đơn";
            this.btHuyDon.Location = new System.Drawing.Point(10, 420);
            this.btHuyDon.Size = new System.Drawing.Size(90, 26);
            this.btHuyDon.TabIndex = 13;
            this.btHuyDon.Click += new System.EventHandler(this.btHuyDon_Click);

            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.Location = new System.Drawing.Point(110, 420);
            this.btThanhToan.Size = new System.Drawing.Size(90, 26);
            this.btThanhToan.TabIndex = 14;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);

            this.lblCTTitle.Text = "Chi tiết đơn";
            this.lblCTTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCTTitle.Location = new System.Drawing.Point(475, 45);
            this.lblCTTitle.AutoSize = true;
            this.lblCTTitle.TabIndex = 15;

            this.dgChiTiet.Location = new System.Drawing.Point(475, 65);
            this.dgChiTiet.Size = new System.Drawing.Size(470, 380);
            this.dgChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChiTiet.AllowUserToAddRows = false;
            this.dgChiTiet.AllowUserToDeleteRows = false;
            this.dgChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChiTiet.MultiSelect = false;
            this.dgChiTiet.ReadOnly = true;
            this.dgChiTiet.RowHeadersVisible = false;
            this.dgChiTiet.TabIndex = 16;

            this.tpDanhSach.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTu, this.dtpTu, this.lblDen, this.dtpDen,
                this.lblTrangThai, this.cbTrangThai, this.btLoc,
                this.lblDSTitle, this.dgDonHang,
                this.lblMaDon, this.tbMaDon, this.lblTTDon, this.tbTrangThai,
                this.btHuyDon, this.btThanhToan,
                this.lblCTTitle, this.dgChiTiet });

            // ===================== tpThongKe =====================
            this.lblTuTK.Text = "Từ ngày:";
            this.lblTuTK.Location = new System.Drawing.Point(10, 15);
            this.lblTuTK.AutoSize = true;
            this.lblTuTK.TabIndex = 0;

            this.dtpTuTK.Location = new System.Drawing.Point(75, 12);
            this.dtpTuTK.Size = new System.Drawing.Size(130, 22);
            this.dtpTuTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuTK.Value = System.DateTime.Today.AddMonths(-1);
            this.dtpTuTK.TabIndex = 1;

            this.lblDenTK.Text = "Đến ngày:";
            this.lblDenTK.Location = new System.Drawing.Point(215, 15);
            this.lblDenTK.AutoSize = true;
            this.lblDenTK.TabIndex = 2;

            this.dtpDenTK.Location = new System.Drawing.Point(285, 12);
            this.dtpDenTK.Size = new System.Drawing.Size(130, 22);
            this.dtpDenTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenTK.TabIndex = 3;

            this.btTKMatHang.Text = "TK theo mặt hàng";
            this.btTKMatHang.Location = new System.Drawing.Point(430, 10);
            this.btTKMatHang.Size = new System.Drawing.Size(150, 26);
            this.btTKMatHang.TabIndex = 4;
            this.btTKMatHang.Click += new System.EventHandler(this.btTKMatHang_Click);

            this.lblThang.Text = "Tháng:";
            this.lblThang.Location = new System.Drawing.Point(10, 55);
            this.lblThang.AutoSize = true;
            this.lblThang.TabIndex = 5;

            this.cbThang.Location = new System.Drawing.Point(65, 52);
            this.cbThang.Size = new System.Drawing.Size(70, 22);
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.Items.AddRange(new object[] { "1","2","3","4","5","6","7","8","9","10","11","12" });
            this.cbThang.SelectedIndex = 0;
            this.cbThang.TabIndex = 6;

            this.lblNam.Text = "Năm:";
            this.lblNam.Location = new System.Drawing.Point(150, 55);
            this.lblNam.AutoSize = true;
            this.lblNam.TabIndex = 7;

            this.cbNam.Location = new System.Drawing.Point(190, 52);
            this.cbNam.Size = new System.Drawing.Size(80, 22);
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.TabIndex = 8;

            this.btTKNgay.Text = "TK theo ngày";
            this.btTKNgay.Location = new System.Drawing.Point(285, 50);
            this.btTKNgay.Size = new System.Drawing.Size(130, 26);
            this.btTKNgay.TabIndex = 9;
            this.btTKNgay.Click += new System.EventHandler(this.btTKNgay_Click);

            this.btTKThang.Text = "TK theo tháng";
            this.btTKThang.Location = new System.Drawing.Point(430, 50);
            this.btTKThang.Size = new System.Drawing.Size(130, 26);
            this.btTKThang.TabIndex = 10;
            this.btTKThang.Click += new System.EventHandler(this.btTKThang_Click);

            this.dgThongKe.Location = new System.Drawing.Point(10, 90);
            this.dgThongKe.Size = new System.Drawing.Size(920, 460);
            this.dgThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgThongKe.AllowUserToAddRows = false;
            this.dgThongKe.AllowUserToDeleteRows = false;
            this.dgThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgThongKe.ReadOnly = true;
            this.dgThongKe.RowHeadersVisible = false;
            this.dgThongKe.TabIndex = 11;

            this.tpThongKe.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTuTK, this.dtpTuTK, this.lblDenTK, this.dtpDenTK, this.btTKMatHang,
                this.lblThang, this.cbThang, this.lblNam, this.cbNam,
                this.btTKNgay, this.btTKThang, this.dgThongKe });

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.MinimumSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSPLapDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKe)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl  tabMain;
        private System.Windows.Forms.TabPage     tpSanPham, tpLapDon, tpDanhSach, tpThongKe;
        private System.Windows.Forms.Label       lblTimKiem, lblMaSP, lblTenSP, lblDonVi, lblDonGia, lblTonKho, lblNhapThem;
        private System.Windows.Forms.TextBox     tbTimKiem, tbMaSP, tbTenSP, tbDonVi, tbDonGia, tbTonKho, tbNhapThem;
        private System.Windows.Forms.Button      btThemSP, btSuaSP, btXoaSP, btNhapHang;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.Label       lblSPTitle, lblGioTitle, lblMaSPDon, lblTenSPDon, lblDonGiaDon, lblSoLuong, lblTongLabel, lblTong;
        private System.Windows.Forms.TextBox     tbMaSPDon, tbTenSPDon, tbDonGiaDon, tbSoLuong;
        private System.Windows.Forms.DataGridView dgSPLapDon, dgGioHang;
        private System.Windows.Forms.Button      btThemVaoGio, btXoaKhoiGio, btXacNhan;
        private System.Windows.Forms.Label       lblTu, lblDen, lblTrangThai, lblMaDon, lblTTDon, lblDSTitle, lblCTTitle;
        private System.Windows.Forms.DateTimePicker dtpTu, dtpDen;
        private System.Windows.Forms.ComboBox    cbTrangThai;
        private System.Windows.Forms.TextBox     tbMaDon, tbTrangThai;
        private System.Windows.Forms.DataGridView dgDonHang, dgChiTiet;
        private System.Windows.Forms.Button      btLoc, btHuyDon, btThanhToan;
        private System.Windows.Forms.Label       lblTuTK, lblDenTK, lblThang, lblNam;
        private System.Windows.Forms.DateTimePicker dtpTuTK, dtpDenTK;
        private System.Windows.Forms.ComboBox    cbThang, cbNam;
        private System.Windows.Forms.DataGridView dgThongKe;
        private System.Windows.Forms.Button      btTKMatHang, btTKNgay, btTKThang;
    }
}
