namespace De3
{
    partial class FormTimKiem
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
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdNamTK = new System.Windows.Forms.RadioButton();
            this.rdNuTK = new System.Windows.Forms.RadioButton();
            this.cbNoiSinhTK = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(228, 61);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(100, 22);
            this.txtMaTK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nơi Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới Tính";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdNamTK
            // 
            this.rdNamTK.AutoSize = true;
            this.rdNamTK.Location = new System.Drawing.Point(210, 179);
            this.rdNamTK.Name = "rdNamTK";
            this.rdNamTK.Size = new System.Drawing.Size(57, 20);
            this.rdNamTK.TabIndex = 7;
            this.rdNamTK.TabStop = true;
            this.rdNamTK.Text = "Nam";
            this.rdNamTK.UseVisualStyleBackColor = true;
            // 
            // rdNuTK
            // 
            this.rdNuTK.AutoSize = true;
            this.rdNuTK.Location = new System.Drawing.Point(362, 184);
            this.rdNuTK.Name = "rdNuTK";
            this.rdNuTK.Size = new System.Drawing.Size(45, 20);
            this.rdNuTK.TabIndex = 8;
            this.rdNuTK.TabStop = true;
            this.rdNuTK.Text = "Nữ";
            this.rdNuTK.UseVisualStyleBackColor = true;
            // 
            // cbNoiSinhTK
            // 
            this.cbNoiSinhTK.FormattingEnabled = true;
            this.cbNoiSinhTK.Location = new System.Drawing.Point(228, 119);
            this.cbNoiSinhTK.Name = "cbNoiSinhTK";
            this.cbNoiSinhTK.Size = new System.Drawing.Size(121, 24);
            this.cbNoiSinhTK.TabIndex = 9;
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNoiSinhTK);
            this.Controls.Add(this.rdNuTK);
            this.Controls.Add(this.rdNamTK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTK);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdNamTK;
        private System.Windows.Forms.RadioButton rdNuTK;
        private System.Windows.Forms.ComboBox cbNoiSinhTK;
    }
}