namespace pjQLLNV
{
    partial class qlTK
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
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KIEMSOAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbMess = new System.Windows.Forms.Label();
            this.lbQLTK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTK3 = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbKS = new System.Windows.Forms.ComboBox();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.lbMahoa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lịchSửTruyCậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAIKHOAN,
            this.MATKHAU,
            this.QUYEN,
            this.KIEMSOAT});
            this.dgvTK.Location = new System.Drawing.Point(296, 33);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.Size = new System.Drawing.Size(453, 340);
            this.dgvTK.TabIndex = 0;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            this.dgvTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellContentClick);
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài khoản";
            this.TAIKHOAN.Name = "TAIKHOAN";
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mã hóa";
            this.MATKHAU.Name = "MATKHAU";
            // 
            // QUYEN
            // 
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Quyền hạn";
            this.QUYEN.Name = "QUYEN";
            // 
            // KIEMSOAT
            // 
            this.KIEMSOAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KIEMSOAT.DataPropertyName = "KIEMSOAT";
            this.KIEMSOAT.HeaderText = "Kiểm soát";
            this.KIEMSOAT.Name = "KIEMSOAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(101, 73);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(130, 26);
            this.txtTK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(101, 108);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(127, 26);
            this.txtMK.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 266);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa TK";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::pjQLLNV.Properties.Resources.exit;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(123, 266);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(123, 221);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa TK";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 221);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 35);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm TK";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Location = new System.Drawing.Point(11, 151);
            this.lbMess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(49, 20);
            this.lbMess.TabIndex = 8;
            this.lbMess.Text = "          ";
            // 
            // lbQLTK
            // 
            this.lbQLTK.AutoSize = true;
            this.lbQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLTK.Location = new System.Drawing.Point(7, 9);
            this.lbQLTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQLTK.Name = "lbQLTK";
            this.lbQLTK.Size = new System.Drawing.Size(216, 24);
            this.lbQLTK.TabIndex = 9;
            this.lbQLTK.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTK3);
            this.groupBox1.Controls.Add(this.lbTK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbKS);
            this.groupBox1.Controls.Add(this.cbb1);
            this.groupBox1.Controls.Add(this.lbMahoa);
            this.groupBox1.Controls.Add(this.lbQLTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbMess);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(40, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 340);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbTK3
            // 
            this.lbTK3.AutoSize = true;
            this.lbTK3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK3.Location = new System.Drawing.Point(12, 33);
            this.lbTK3.Name = "lbTK3";
            this.lbTK3.Size = new System.Drawing.Size(122, 16);
            this.lbTK3.TabIndex = 16;
            this.lbTK3.Text = "Tài khoản của bạn:";
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(140, 33);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(0, 16);
            this.lbTK.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kiểm soát";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quyền";
            // 
            // cbbKS
            // 
            this.cbbKS.FormattingEnabled = true;
            this.cbbKS.Items.AddRange(new object[] {
            "bat",
            "tat"});
            this.cbbKS.Location = new System.Drawing.Point(102, 176);
            this.cbbKS.Name = "cbbKS";
            this.cbbKS.Size = new System.Drawing.Size(129, 28);
            this.cbbKS.TabIndex = 11;
            this.cbbKS.Text = "bat";
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbb1.Location = new System.Drawing.Point(101, 142);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(129, 28);
            this.cbb1.TabIndex = 11;
            this.cbb1.Text = "user";
            // 
            // lbMahoa
            // 
            this.lbMahoa.AutoSize = true;
            this.lbMahoa.Location = new System.Drawing.Point(97, 151);
            this.lbMahoa.Name = "lbMahoa";
            this.lbMahoa.Size = new System.Drawing.Size(0, 20);
            this.lbMahoa.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::pjQLLNV.Properties.Resources.bgr2;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửTruyCậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lịchSửTruyCậpToolStripMenuItem
            // 
            this.lịchSửTruyCậpToolStripMenuItem.Name = "lịchSửTruyCậpToolStripMenuItem";
            this.lịchSửTruyCậpToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.lịchSửTruyCậpToolStripMenuItem.Text = "Lịch sử truy cập";
            this.lịchSửTruyCậpToolStripMenuItem.Click += new System.EventHandler(this.lịchSửTruyCậpToolStripMenuItem_Click);
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Location = new System.Drawing.Point(134, 133);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(0, 20);
            this.lbTG.TabIndex = 12;
            // 
            // qlTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pjQLLNV.Properties.Resources.bgr;
            this.ClientSize = new System.Drawing.Size(794, 413);
            this.Controls.Add(this.lbTG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "qlTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.qlTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Label lbQLTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMahoa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lịchSửTruyCậpToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KIEMSOAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbKS;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbTK3;
    }
}