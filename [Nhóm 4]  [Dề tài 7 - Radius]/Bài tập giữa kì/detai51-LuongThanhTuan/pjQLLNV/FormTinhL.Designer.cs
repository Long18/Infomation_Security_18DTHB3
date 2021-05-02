namespace pjQLLNV
{
    partial class FormTinhL
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
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.THANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUCLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLSP = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lbMess = new System.Windows.Forms.Label();
            this.btnTinhL = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMucL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.txtThemMasp = new System.Windows.Forms.TextBox();
            this.txtThemT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThemSLSP = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbMess2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbThemMANV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTL
            // 
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.THANG,
            this.MANV,
            this.TENNV,
            this.MASP,
            this.SLSP,
            this.DONGIA,
            this.MUCLUONG});
            this.dgvTL.Location = new System.Drawing.Point(279, 58);
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.Size = new System.Drawing.Size(554, 326);
            this.dgvTL.TabIndex = 0;
            this.dgvTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTL_CellClick);
            // 
            // THANG
            // 
            this.THANG.DataPropertyName = "THANG";
            this.THANG.HeaderText = "Tháng";
            this.THANG.Name = "THANG";
            this.THANG.Width = 50;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            this.MANV.Width = 70;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên NV";
            this.TENNV.Name = "TENNV";
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩn";
            this.MASP.Name = "MASP";
            this.MASP.Width = 70;
            // 
            // SLSP
            // 
            this.SLSP.DataPropertyName = "SLSP";
            this.SLSP.HeaderText = "Số lượng SP";
            this.SLSP.Name = "SLSP";
            this.SLSP.Width = 50;
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // MUCLUONG
            // 
            this.MUCLUONG.DataPropertyName = "MUCLUONG";
            this.MUCLUONG.HeaderText = "Mức lương";
            this.MUCLUONG.Name = "MUCLUONG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(101, 51);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(140, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(101, 77);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(140, 20);
            this.txtMaSP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng SP";
            // 
            // txtSLSP
            // 
            this.txtSLSP.Location = new System.Drawing.Point(103, 154);
            this.txtSLSP.Name = "txtSLSP";
            this.txtSLSP.Size = new System.Drawing.Size(140, 20);
            this.txtSLSP.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(15, 282);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 39);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = " Sửa SLSP";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Enabled = false;
            this.txtThang.Location = new System.Drawing.Point(101, 27);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(140, 20);
            this.txtThang.TabIndex = 2;
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Location = new System.Drawing.Point(100, 232);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(37, 13);
            this.lbMess.TabIndex = 1;
            this.lbMess.Text = "          ";
            // 
            // btnTinhL
            // 
            this.btnTinhL.Location = new System.Drawing.Point(95, 282);
            this.btnTinhL.Name = "btnTinhL";
            this.btnTinhL.Size = new System.Drawing.Size(94, 39);
            this.btnTinhL.TabIndex = 62;
            this.btnTinhL.Text = "Tính lương và lưu lại";
            this.btnTinhL.UseVisualStyleBackColor = true;
            this.btnTinhL.Click += new System.EventHandler(this.btnTinhL_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng lương NV";
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(101, 256);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(140, 20);
            this.txtTL.TabIndex = 2;
            this.txtTL.Text = "0";
            // 
            // txtDG
            // 
            this.txtDG.Enabled = false;
            this.txtDG.Location = new System.Drawing.Point(101, 100);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(140, 20);
            this.txtDG.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, -30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "TÍNH LƯƠNG NHÂN VIÊN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::pjQLLNV.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(195, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Mức lương";
            // 
            // txtMucL
            // 
            this.txtMucL.Enabled = false;
            this.txtMucL.Location = new System.Drawing.Point(101, 126);
            this.txtMucL.Name = "txtMucL";
            this.txtMucL.Size = new System.Drawing.Size(140, 20);
            this.txtMucL.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thưởng thêm";
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(101, 180);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(140, 20);
            this.txtThuong.TabIndex = 2;
            this.txtThuong.Text = "0";
            // 
            // txtThemMasp
            // 
            this.txtThemMasp.Location = new System.Drawing.Point(100, 77);
            this.txtThemMasp.Name = "txtThemMasp";
            this.txtThemMasp.Size = new System.Drawing.Size(140, 20);
            this.txtThemMasp.TabIndex = 69;
            // 
            // txtThemT
            // 
            this.txtThemT.Location = new System.Drawing.Point(100, 27);
            this.txtThemT.Name = "txtThemT";
            this.txtThemT.Size = new System.Drawing.Size(140, 20);
            this.txtThemT.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Mã SP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Tháng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Mã NV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "THÊM XÓA BẢNG LƯƠNG";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 72;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Số lượng SP";
            // 
            // txtThemSLSP
            // 
            this.txtThemSLSP.Location = new System.Drawing.Point(100, 103);
            this.txtThemSLSP.Name = "txtThemSLSP";
            this.txtThemSLSP.Size = new System.Drawing.Size(140, 20);
            this.txtThemSLSP.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(160, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 34);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbMess2
            // 
            this.lbMess2.AutoSize = true;
            this.lbMess2.Location = new System.Drawing.Point(21, 138);
            this.lbMess2.Name = "lbMess2";
            this.lbMess2.Size = new System.Drawing.Size(37, 13);
            this.lbMess2.TabIndex = 1;
            this.lbMess2.Text = "          ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Controls.Add(this.txtTL);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMucL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbMess);
            this.groupBox1.Controls.Add(this.txtDG);
            this.groupBox1.Controls.Add(this.txtSLSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThuong);
            this.groupBox1.Controls.Add(this.btnTinhL);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 326);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "TÍNH LƯƠNG NHÂN VIÊN";
            this.label15.Click += new System.EventHandler(this.label13_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbThemMANV);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.lbMess2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtThemSLSP);
            this.groupBox2.Controls.Add(this.txtThemMasp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtThemT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(840, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 326);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // cbbThemMANV
            // 
            this.cbbThemMANV.FormattingEnabled = true;
            this.cbbThemMANV.Location = new System.Drawing.Point(100, 50);
            this.cbbThemMANV.Name = "cbbThemMANV";
            this.cbbThemMANV.Size = new System.Drawing.Size(140, 21);
            this.cbbThemMANV.TabIndex = 73;
            // 
            // FormTinhL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pjQLLNV.Properties.Resources.bgr;
            this.ClientSize = new System.Drawing.Size(1113, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTL);
            this.Name = "FormTinhL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính lương NV";
            this.Load += new System.EventHandler(this.FormTinhL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSLSP;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Button btnTinhL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMucL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.TextBox txtThemMasp;
        private System.Windows.Forms.TextBox txtThemT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThemSLSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbMess2;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUCLUONG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbThemMANV;
    }
}