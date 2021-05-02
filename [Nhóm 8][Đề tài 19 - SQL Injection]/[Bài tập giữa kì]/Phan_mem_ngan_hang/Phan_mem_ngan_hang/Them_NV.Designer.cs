namespace Phan_mem_ngan_hang
{
    partial class Them_NV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCHINHANH = new System.Windows.Forms.ComboBox();
            this.cboPHONGBAN = new System.Windows.Forms.ComboBox();
            this.radNU = new System.Windows.Forms.RadioButton();
            this.radNAM = new System.Windows.Forms.RadioButton();
            this.dtpNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.txtCHUCVU = new System.Windows.Forms.TextBox();
            this.txtLUONG = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(220, 525);
            this.bntThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(91, 31);
            this.bntThoat.TabIndex = 13;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntThem
            // 
            this.bntThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.Location = new System.Drawing.Point(90, 525);
            this.bntThem.Margin = new System.Windows.Forms.Padding(2);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(97, 31);
            this.bntThem.TabIndex = 10;
            this.bntThem.Text = "Cập nhật";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(490, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÊM THÔNG TIN NHÂN VIÊN";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column5,
            this.Column7});
            this.dgvNhanvien.Location = new System.Drawing.Point(401, 117);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(1027, 404);
            this.dgvNhanvien.TabIndex = 8;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "MÃ NHÂN VIÊN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phòng ban";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "CHỨC VỤ";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Lương cơ bản";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Chi nhánh";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.txt_tendangnhap);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboCHINHANH);
            this.groupBox1.Controls.Add(this.cboPHONGBAN);
            this.groupBox1.Controls.Add(this.radNU);
            this.groupBox1.Controls.Add(this.radNAM);
            this.groupBox1.Controls.Add(this.dtpNGAYSINH);
            this.groupBox1.Controls.Add(this.txtCHUCVU);
            this.groupBox1.Controls.Add(this.txtLUONG);
            this.groupBox1.Controls.Add(this.txtTEN);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(141, 208);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(151, 23);
            this.txt_matkhau.TabIndex = 25;
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(141, 166);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(151, 23);
            this.txt_tendangnhap.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tên Đăng nhập:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mật khẩu:";
            // 
            // cboCHINHANH
            // 
            this.cboCHINHANH.FormattingEnabled = true;
            this.cboCHINHANH.Location = new System.Drawing.Point(141, 357);
            this.cboCHINHANH.Margin = new System.Windows.Forms.Padding(2);
            this.cboCHINHANH.Name = "cboCHINHANH";
            this.cboCHINHANH.Size = new System.Drawing.Size(151, 24);
            this.cboCHINHANH.TabIndex = 21;
            // 
            // cboPHONGBAN
            // 
            this.cboPHONGBAN.FormattingEnabled = true;
            this.cboPHONGBAN.Location = new System.Drawing.Point(141, 318);
            this.cboPHONGBAN.Margin = new System.Windows.Forms.Padding(2);
            this.cboPHONGBAN.Name = "cboPHONGBAN";
            this.cboPHONGBAN.Size = new System.Drawing.Size(151, 24);
            this.cboPHONGBAN.TabIndex = 20;
            this.cboPHONGBAN.SelectedIndexChanged += new System.EventHandler(this.cboPHONGBAN_SelectedIndexChanged);
            // 
            // radNU
            // 
            this.radNU.AutoSize = true;
            this.radNU.Location = new System.Drawing.Point(235, 130);
            this.radNU.Margin = new System.Windows.Forms.Padding(2);
            this.radNU.Name = "radNU";
            this.radNU.Size = new System.Drawing.Size(43, 20);
            this.radNU.TabIndex = 19;
            this.radNU.TabStop = true;
            this.radNU.Text = "Nữ";
            this.radNU.UseVisualStyleBackColor = true;
            // 
            // radNAM
            // 
            this.radNAM.AutoSize = true;
            this.radNAM.Location = new System.Drawing.Point(141, 130);
            this.radNAM.Margin = new System.Windows.Forms.Padding(2);
            this.radNAM.Name = "radNAM";
            this.radNAM.Size = new System.Drawing.Size(53, 20);
            this.radNAM.TabIndex = 18;
            this.radNAM.TabStop = true;
            this.radNAM.Text = "Nam";
            this.radNAM.UseVisualStyleBackColor = true;
            this.radNAM.CheckedChanged += new System.EventHandler(this.radNAM_CheckedChanged);
            // 
            // dtpNGAYSINH
            // 
            this.dtpNGAYSINH.Location = new System.Drawing.Point(141, 93);
            this.dtpNGAYSINH.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNGAYSINH.Name = "dtpNGAYSINH";
            this.dtpNGAYSINH.Size = new System.Drawing.Size(151, 23);
            this.dtpNGAYSINH.TabIndex = 17;
            // 
            // txtCHUCVU
            // 
            this.txtCHUCVU.Location = new System.Drawing.Point(141, 242);
            this.txtCHUCVU.Margin = new System.Windows.Forms.Padding(2);
            this.txtCHUCVU.Name = "txtCHUCVU";
            this.txtCHUCVU.Size = new System.Drawing.Size(151, 23);
            this.txtCHUCVU.TabIndex = 15;
            this.txtCHUCVU.TextChanged += new System.EventHandler(this.txtCHUCVU_TextChanged);
            // 
            // txtLUONG
            // 
            this.txtLUONG.Location = new System.Drawing.Point(141, 280);
            this.txtLUONG.Margin = new System.Windows.Forms.Padding(2);
            this.txtLUONG.Name = "txtLUONG";
            this.txtLUONG.Size = new System.Drawing.Size(151, 23);
            this.txtLUONG.TabIndex = 14;
            this.txtLUONG.TextChanged += new System.EventHandler(this.txtLUONG_TextChanged);
            // 
            // txtTEN
            // 
            this.txtTEN.Location = new System.Drawing.Point(141, 60);
            this.txtTEN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(151, 23);
            this.txtTEN.TabIndex = 13;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(141, 27);
            this.txtMANV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(151, 23);
            this.txtMANV.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 363);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chi nhánh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 321);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phòng ban:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lương cơ bản:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chức vụ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã NV:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phan_mem_ngan_hang.Properties.Resources.background_dep_danh_cho_power_point_120717382;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1469, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Them_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 597);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Them_NV";
            this.Text = "Them_NV";
            this.Load += new System.EventHandler(this.Them_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCHINHANH;
        private System.Windows.Forms.ComboBox cboPHONGBAN;
        private System.Windows.Forms.RadioButton radNU;
        private System.Windows.Forms.RadioButton radNAM;
        private System.Windows.Forms.DateTimePicker dtpNGAYSINH;
        private System.Windows.Forms.TextBox txtCHUCVU;
        private System.Windows.Forms.TextBox txtLUONG;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendangnhap;
    }
}