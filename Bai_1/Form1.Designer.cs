namespace Bai_1
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
            this.tpTinh = new System.Windows.Forms.TabPage();
            this.btnXT = new System.Windows.Forms.Button();
            this.btnST = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.dgvTinh = new System.Windows.Forms.DataGridView();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtMT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpKhoa = new System.Windows.Forms.TabPage();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXK = new System.Windows.Forms.Button();
            this.btnSK = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.tpLop = new System.Windows.Forms.TabPage();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnXL = new System.Windows.Forms.Button();
            this.btnSL = new System.Windows.Forms.Button();
            this.btnTL = new System.Windows.Forms.Button();
            this.cbMK = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.txtML = new System.Windows.Forms.TextBox();
            this.tpSV = new System.Windows.Forms.TabPage();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.btnXSV = new System.Windows.Forms.Button();
            this.btnSSV = new System.Windows.Forms.Button();
            this.btnTSV = new System.Windows.Forms.Button();
            this.cbL = new System.Windows.Forms.ComboBox();
            this.cbK = new System.Windows.Forms.ComboBox();
            this.cbNS = new System.Windows.Forms.ComboBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinh)).BeginInit();
            this.tpKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.tpLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.tpSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpTinh);
            this.tabControl1.Controls.Add(this.tpKhoa);
            this.tabControl1.Controls.Add(this.tpLop);
            this.tabControl1.Controls.Add(this.tpSV);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tpTinh
            // 
            this.tpTinh.Controls.Add(this.btnXT);
            this.tpTinh.Controls.Add(this.btnST);
            this.tpTinh.Controls.Add(this.btnTT);
            this.tpTinh.Controls.Add(this.dgvTinh);
            this.tpTinh.Controls.Add(this.txtTT);
            this.tpTinh.Controls.Add(this.txtMT);
            this.tpTinh.Controls.Add(this.label2);
            this.tpTinh.Controls.Add(this.label1);
            this.tpTinh.Location = new System.Drawing.Point(4, 29);
            this.tpTinh.Name = "tpTinh";
            this.tpTinh.Padding = new System.Windows.Forms.Padding(3);
            this.tpTinh.Size = new System.Drawing.Size(792, 417);
            this.tpTinh.TabIndex = 0;
            this.tpTinh.Text = "Tỉnh";
            this.tpTinh.UseVisualStyleBackColor = true;
            // 
            // btnXT
            // 
            this.btnXT.Location = new System.Drawing.Point(666, 56);
            this.btnXT.Name = "btnXT";
            this.btnXT.Size = new System.Drawing.Size(108, 36);
            this.btnXT.TabIndex = 7;
            this.btnXT.Text = "Xóa";
            this.btnXT.UseVisualStyleBackColor = true;
            this.btnXT.Click += new System.EventHandler(this.btnXT_Click);
            // 
            // btnST
            // 
            this.btnST.Location = new System.Drawing.Point(531, 56);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(108, 36);
            this.btnST.TabIndex = 6;
            this.btnST.Text = "Sửa";
            this.btnST.UseVisualStyleBackColor = true;
            this.btnST.Click += new System.EventHandler(this.btnST_Click);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(399, 56);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(108, 36);
            this.btnTT.TabIndex = 5;
            this.btnTT.Text = "Thêm";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // dgvTinh
            // 
            this.dgvTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinh.Location = new System.Drawing.Point(-4, 139);
            this.dgvTinh.Name = "dgvTinh";
            this.dgvTinh.RowHeadersWidth = 62;
            this.dgvTinh.RowTemplate.Height = 28;
            this.dgvTinh.Size = new System.Drawing.Size(800, 278);
            this.dgvTinh.TabIndex = 4;
            this.dgvTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinh_CellClick);
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(107, 84);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(247, 26);
            this.txtTT.TabIndex = 3;
            // 
            // txtMT
            // 
            this.txtMT.Location = new System.Drawing.Point(107, 33);
            this.txtMT.Name = "txtMT";
            this.txtMT.Size = new System.Drawing.Size(247, 26);
            this.txtMT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tỉnh";
            // 
            // tpKhoa
            // 
            this.tpKhoa.Controls.Add(this.dgvKhoa);
            this.tpKhoa.Controls.Add(this.txtTK);
            this.tpKhoa.Controls.Add(this.txtMK);
            this.tpKhoa.Controls.Add(this.label4);
            this.tpKhoa.Controls.Add(this.label3);
            this.tpKhoa.Controls.Add(this.btnXK);
            this.tpKhoa.Controls.Add(this.btnSK);
            this.tpKhoa.Controls.Add(this.btnTK);
            this.tpKhoa.Location = new System.Drawing.Point(4, 29);
            this.tpKhoa.Name = "tpKhoa";
            this.tpKhoa.Padding = new System.Windows.Forms.Padding(3);
            this.tpKhoa.Size = new System.Drawing.Size(792, 417);
            this.tpKhoa.TabIndex = 1;
            this.tpKhoa.Text = "Khoa";
            this.tpKhoa.UseVisualStyleBackColor = true;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(0, 139);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 62;
            this.dgvKhoa.RowTemplate.Height = 28;
            this.dgvKhoa.Size = new System.Drawing.Size(792, 282);
            this.dgvKhoa.TabIndex = 7;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(114, 79);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(248, 26);
            this.txtTK.TabIndex = 6;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(114, 24);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(248, 26);
            this.txtMK.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khoa";
            // 
            // btnXK
            // 
            this.btnXK.Location = new System.Drawing.Point(665, 44);
            this.btnXK.Name = "btnXK";
            this.btnXK.Size = new System.Drawing.Size(105, 35);
            this.btnXK.TabIndex = 2;
            this.btnXK.Text = "Xóa";
            this.btnXK.UseVisualStyleBackColor = true;
            this.btnXK.Click += new System.EventHandler(this.btnXK_Click);
            // 
            // btnSK
            // 
            this.btnSK.Location = new System.Drawing.Point(530, 44);
            this.btnSK.Name = "btnSK";
            this.btnSK.Size = new System.Drawing.Size(105, 35);
            this.btnSK.TabIndex = 1;
            this.btnSK.Text = "Sửa";
            this.btnSK.UseVisualStyleBackColor = true;
            this.btnSK.Click += new System.EventHandler(this.btnSK_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(397, 44);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(105, 35);
            this.btnTK.TabIndex = 0;
            this.btnTK.Text = "Thêm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // tpLop
            // 
            this.tpLop.Controls.Add(this.dgvLop);
            this.tpLop.Controls.Add(this.btnXL);
            this.tpLop.Controls.Add(this.btnSL);
            this.tpLop.Controls.Add(this.btnTL);
            this.tpLop.Controls.Add(this.cbMK);
            this.tpLop.Controls.Add(this.label8);
            this.tpLop.Controls.Add(this.label7);
            this.tpLop.Controls.Add(this.label6);
            this.tpLop.Controls.Add(this.label5);
            this.tpLop.Controls.Add(this.txtTL);
            this.tpLop.Controls.Add(this.txtML);
            this.tpLop.Location = new System.Drawing.Point(4, 29);
            this.tpLop.Name = "tpLop";
            this.tpLop.Padding = new System.Windows.Forms.Padding(3);
            this.tpLop.Size = new System.Drawing.Size(792, 417);
            this.tpLop.TabIndex = 2;
            this.tpLop.Text = "Lớp";
            this.tpLop.UseVisualStyleBackColor = true;
            // 
            // dgvLop
            // 
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(-4, 184);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.RowTemplate.Height = 28;
            this.dgvLop.Size = new System.Drawing.Size(800, 237);
            this.dgvLop.TabIndex = 10;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // btnXL
            // 
            this.btnXL.Location = new System.Drawing.Point(672, 63);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(106, 44);
            this.btnXL.TabIndex = 9;
            this.btnXL.Text = "Xóa";
            this.btnXL.UseVisualStyleBackColor = true;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(550, 63);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(106, 44);
            this.btnSL.TabIndex = 8;
            this.btnSL.Text = "Sửa";
            this.btnSL.UseVisualStyleBackColor = true;
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // btnTL
            // 
            this.btnTL.Location = new System.Drawing.Point(429, 63);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(106, 44);
            this.btnTL.TabIndex = 7;
            this.btnTL.Text = "Thêm";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // cbMK
            // 
            this.cbMK.FormattingEnabled = true;
            this.cbMK.Location = new System.Drawing.Point(117, 120);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(284, 28);
            this.cbMK.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã lớp";
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(117, 72);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(284, 26);
            this.txtTL.TabIndex = 1;
            // 
            // txtML
            // 
            this.txtML.Location = new System.Drawing.Point(117, 22);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(284, 26);
            this.txtML.TabIndex = 0;
            // 
            // tpSV
            // 
            this.tpSV.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tpSV.Controls.Add(this.dgvSV);
            this.tpSV.Controls.Add(this.btnXSV);
            this.tpSV.Controls.Add(this.btnSSV);
            this.tpSV.Controls.Add(this.btnTSV);
            this.tpSV.Controls.Add(this.cbL);
            this.tpSV.Controls.Add(this.cbK);
            this.tpSV.Controls.Add(this.cbNS);
            this.tpSV.Controls.Add(this.rdbNu);
            this.tpSV.Controls.Add(this.rdbNam);
            this.tpSV.Controls.Add(this.dtpNS);
            this.tpSV.Controls.Add(this.txtTen);
            this.tpSV.Controls.Add(this.txtMa);
            this.tpSV.Controls.Add(this.label15);
            this.tpSV.Controls.Add(this.label14);
            this.tpSV.Controls.Add(this.label13);
            this.tpSV.Controls.Add(this.label12);
            this.tpSV.Controls.Add(this.label11);
            this.tpSV.Controls.Add(this.label10);
            this.tpSV.Controls.Add(this.label9);
            this.tpSV.Location = new System.Drawing.Point(4, 29);
            this.tpSV.Name = "tpSV";
            this.tpSV.Padding = new System.Windows.Forms.Padding(3);
            this.tpSV.Size = new System.Drawing.Size(792, 417);
            this.tpSV.TabIndex = 3;
            this.tpSV.Text = "Sinh viên";
            // 
            // dgvSV
            // 
            this.dgvSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(0, 225);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 62;
            this.dgvSV.RowTemplate.Height = 28;
            this.dgvSV.Size = new System.Drawing.Size(796, 192);
            this.dgvSV.TabIndex = 18;
            this.dgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellClick);
            // 
            // btnXSV
            // 
            this.btnXSV.Location = new System.Drawing.Point(649, 177);
            this.btnXSV.Name = "btnXSV";
            this.btnXSV.Size = new System.Drawing.Size(93, 42);
            this.btnXSV.TabIndex = 17;
            this.btnXSV.Text = "Xóa";
            this.btnXSV.UseVisualStyleBackColor = true;
            this.btnXSV.Click += new System.EventHandler(this.btnXSV_Click);
            // 
            // btnSSV
            // 
            this.btnSSV.Location = new System.Drawing.Point(541, 177);
            this.btnSSV.Name = "btnSSV";
            this.btnSSV.Size = new System.Drawing.Size(93, 42);
            this.btnSSV.TabIndex = 16;
            this.btnSSV.Text = "Sửa";
            this.btnSSV.UseVisualStyleBackColor = true;
            this.btnSSV.Click += new System.EventHandler(this.btnSSV_Click);
            // 
            // btnTSV
            // 
            this.btnTSV.Location = new System.Drawing.Point(433, 177);
            this.btnTSV.Name = "btnTSV";
            this.btnTSV.Size = new System.Drawing.Size(93, 42);
            this.btnTSV.TabIndex = 15;
            this.btnTSV.Text = "Thêm";
            this.btnTSV.UseVisualStyleBackColor = true;
            this.btnTSV.Click += new System.EventHandler(this.btnTSV_Click);
            // 
            // cbL
            // 
            this.cbL.FormattingEnabled = true;
            this.cbL.Location = new System.Drawing.Point(474, 127);
            this.cbL.Name = "cbL";
            this.cbL.Size = new System.Drawing.Size(269, 28);
            this.cbL.TabIndex = 14;
            // 
            // cbK
            // 
            this.cbK.FormattingEnabled = true;
            this.cbK.Location = new System.Drawing.Point(474, 77);
            this.cbK.Name = "cbK";
            this.cbK.Size = new System.Drawing.Size(269, 28);
            this.cbK.TabIndex = 13;
            // 
            // cbNS
            // 
            this.cbNS.FormattingEnabled = true;
            this.cbNS.Location = new System.Drawing.Point(474, 31);
            this.cbNS.Name = "cbNS";
            this.cbNS.Size = new System.Drawing.Size(269, 28);
            this.cbNS.TabIndex = 12;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(202, 125);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(54, 24);
            this.rdbNu.TabIndex = 11;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(120, 125);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(67, 24);
            this.rdbNam.TabIndex = 10;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNS
            // 
            this.dtpNS.Location = new System.Drawing.Point(108, 177);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(248, 26);
            this.dtpNS.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(87, 74);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(269, 26);
            this.txtTen.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(87, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(269, 26);
            this.txtMa.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(392, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Lớp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Khoa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(392, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nơi sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giới tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Họ tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.tabControl1.ResumeLayout(false);
            this.tpTinh.ResumeLayout(false);
            this.tpTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinh)).EndInit();
            this.tpKhoa.ResumeLayout(false);
            this.tpKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.tpLop.ResumeLayout(false);
            this.tpLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.tpSV.ResumeLayout(false);
            this.tpSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTinh;
        private System.Windows.Forms.TabPage tpKhoa;
        private System.Windows.Forms.TabPage tpLop;
        private System.Windows.Forms.TabPage tpSV;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtMT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXT;
        private System.Windows.Forms.Button btnST;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.DataGridView dgvTinh;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXK;
        private System.Windows.Forms.Button btnSK;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.TextBox txtML;
        private System.Windows.Forms.ComboBox cbMK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXL;
        private System.Windows.Forms.Button btnSL;
        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Button btnXSV;
        private System.Windows.Forms.Button btnSSV;
        private System.Windows.Forms.Button btnTSV;
        private System.Windows.Forms.ComboBox cbL;
        private System.Windows.Forms.ComboBox cbK;
        private System.Windows.Forms.ComboBox cbNS;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

