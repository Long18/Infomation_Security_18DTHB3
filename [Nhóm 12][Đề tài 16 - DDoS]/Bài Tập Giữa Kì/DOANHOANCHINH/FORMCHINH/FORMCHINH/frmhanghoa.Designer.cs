namespace FORMCHINH
{
    partial class frmhanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhanghoa));
            this.cboChatlieu = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.lblchatlieu = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lbltenhang = new System.Windows.Forms.Label();
            this.lblmahang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltieude = new System.Windows.Forms.Label();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChatlieu
            // 
            this.cboChatlieu.FormattingEnabled = true;
            this.cboChatlieu.Location = new System.Drawing.Point(121, 110);
            this.cboChatlieu.Name = "cboChatlieu";
            this.cboChatlieu.Size = new System.Drawing.Size(251, 24);
            this.cboChatlieu.TabIndex = 29;
            this.cboChatlieu.SelectedIndexChanged += new System.EventHandler(this.cboChatlieu_SelectedIndexChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(121, 146);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(250, 22);
            this.txtsoluong.TabIndex = 28;
            // 
            // lblchatlieu
            // 
            this.lblchatlieu.AutoSize = true;
            this.lblchatlieu.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchatlieu.Location = new System.Drawing.Point(14, 113);
            this.lblchatlieu.Name = "lblchatlieu";
            this.lblchatlieu.Size = new System.Drawing.Size(70, 16);
            this.lblchatlieu.TabIndex = 27;
            this.lblchatlieu.Text = "Chất liệu";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.Location = new System.Drawing.Point(14, 146);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(72, 16);
            this.lblsoluong.TabIndex = 26;
            this.lblsoluong.Text = "Số lượng";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(121, 182);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(250, 22);
            this.txtdongia.TabIndex = 25;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(122, 72);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(250, 22);
            this.txttenhang.TabIndex = 23;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(122, 36);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(250, 22);
            this.txtmahang.TabIndex = 22;
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldongia.Location = new System.Drawing.Point(14, 185);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(62, 16);
            this.lbldongia.TabIndex = 18;
            this.lbldongia.Text = "Đơn giá";
            // 
            // lbltenhang
            // 
            this.lbltenhang.AutoSize = true;
            this.lbltenhang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenhang.Location = new System.Drawing.Point(14, 75);
            this.lbltenhang.Name = "lbltenhang";
            this.lbltenhang.Size = new System.Drawing.Size(72, 16);
            this.lbltenhang.TabIndex = 16;
            this.lbltenhang.Text = "Tên hàng";
            // 
            // lblmahang
            // 
            this.lblmahang.AutoSize = true;
            this.lblmahang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahang.Location = new System.Drawing.Point(14, 39);
            this.lblmahang.Name = "lblmahang";
            this.lblmahang.Size = new System.Drawing.Size(68, 16);
            this.lblmahang.TabIndex = 15;
            this.lblmahang.Text = "Mã hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboChatlieu);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.lblchatlieu);
            this.groupBox1.Controls.Add(this.lblsoluong);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txttenhang);
            this.groupBox1.Controls.Add(this.txtmahang);
            this.groupBox1.Controls.Add(this.lbldongia);
            this.groupBox1.Controls.Add(this.lbltenhang);
            this.groupBox1.Controls.Add(this.lblmahang);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 399);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // lbltieude
            // 
            this.lbltieude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.Blue;
            this.lbltieude.Location = new System.Drawing.Point(398, 66);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(279, 29);
            this.lbltieude.TabIndex = 23;
            this.lbltieude.Text = "DANH MỤC HÀNG HÓA";
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(709, 598);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 50);
            this.btnsua.TabIndex = 69;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(904, 598);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 50);
            this.btnthoat.TabIndex = 67;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseWaitCursor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(507, 598);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 50);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(291, 598);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 50);
            this.btnthem.TabIndex = 65;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.AllowUserToDeleteRows = false;
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.tenhang,
            this.chatlieu,
            this.soluong,
            this.dongia});
            this.dgvhanghoa.Location = new System.Drawing.Point(458, 112);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.ReadOnly = true;
            this.dgvhanghoa.RowHeadersWidth = 51;
            this.dgvhanghoa.RowTemplate.Height = 24;
            this.dgvhanghoa.Size = new System.Drawing.Size(638, 442);
            this.dgvhanghoa.TabIndex = 71;
            this.dgvhanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mahang
            // 
            this.mahang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahang.HeaderText = "Mã hàng";
            this.mahang.MinimumWidth = 6;
            this.mahang.Name = "mahang";
            this.mahang.ReadOnly = true;
            // 
            // tenhang
            // 
            this.tenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.MinimumWidth = 6;
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            // 
            // chatlieu
            // 
            this.chatlieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chatlieu.HeaderText = "Chất liệu";
            this.chatlieu.MinimumWidth = 6;
            this.chatlieu.Name = "chatlieu";
            this.chatlieu.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // frmhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 719);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltieude);
            this.Name = "frmhanghoa";
            this.Text = "frmhanghoa";
            this.Load += new System.EventHandler(this.frmhanghoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChatlieu;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label lblchatlieu;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lbltenhang;
        private System.Windows.Forms.Label lblmahang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltieude;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
    }
}