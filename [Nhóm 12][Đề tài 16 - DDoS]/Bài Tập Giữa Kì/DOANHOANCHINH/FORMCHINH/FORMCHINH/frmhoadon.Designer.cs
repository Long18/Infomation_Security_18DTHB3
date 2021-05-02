namespace FORMCHINH
{
    partial class frmhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhoadon));
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.dtpngayban = new System.Windows.Forms.DateTimePicker();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.lblngayban = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltenhang = new System.Windows.Forms.Label();
            this.cbotenhang = new System.Windows.Forms.ComboBox();
            this.cbotenkhach = new System.Windows.Forms.ComboBox();
            this.lblmahd = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(122, 232);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(250, 22);
            this.txtthanhtien.TabIndex = 32;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.Location = new System.Drawing.Point(10, 232);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(82, 16);
            this.lblthanhtien.TabIndex = 30;
            this.lblthanhtien.Text = "Thành tiền";
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkhach.Location = new System.Drawing.Point(10, 106);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(118, 16);
            this.lbltenkhach.TabIndex = 28;
            this.lbltenkhach.Text = "Tên khách hàng";
            // 
            // dtpngayban
            // 
            this.dtpngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayban.Location = new System.Drawing.Point(122, 70);
            this.dtpngayban.Name = "dtpngayban";
            this.dtpngayban.Size = new System.Drawing.Size(200, 22);
            this.dtpngayban.TabIndex = 27;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(122, 168);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(250, 22);
            this.txtsoluong.TabIndex = 25;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(122, 198);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(250, 22);
            this.txtdongia.TabIndex = 24;
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(122, 36);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(250, 22);
            this.txtmahd.TabIndex = 22;
            // 
            // lblngayban
            // 
            this.lblngayban.AutoSize = true;
            this.lblngayban.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngayban.Location = new System.Drawing.Point(10, 75);
            this.lblngayban.Name = "lblngayban";
            this.lblngayban.Size = new System.Drawing.Size(72, 16);
            this.lblngayban.TabIndex = 20;
            this.lblngayban.Text = "Ngày bán";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldongia.Location = new System.Drawing.Point(10, 201);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(62, 16);
            this.lbldongia.TabIndex = 19;
            this.lbldongia.Text = "Đơn giá";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.Location = new System.Drawing.Point(10, 171);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(72, 16);
            this.lblsoluong.TabIndex = 18;
            this.lblsoluong.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltenhang);
            this.groupBox1.Controls.Add(this.cbotenhang);
            this.groupBox1.Controls.Add(this.cbotenkhach);
            this.groupBox1.Controls.Add(this.txtthanhtien);
            this.groupBox1.Controls.Add(this.lblthanhtien);
            this.groupBox1.Controls.Add(this.lbltenkhach);
            this.groupBox1.Controls.Add(this.dtpngayban);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txtmahd);
            this.groupBox1.Controls.Add(this.lblngayban);
            this.groupBox1.Controls.Add(this.lbldongia);
            this.groupBox1.Controls.Add(this.lblsoluong);
            this.groupBox1.Controls.Add(this.lblmahd);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 399);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // lbltenhang
            // 
            this.lbltenhang.AutoSize = true;
            this.lbltenhang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenhang.Location = new System.Drawing.Point(10, 140);
            this.lbltenhang.Name = "lbltenhang";
            this.lbltenhang.Size = new System.Drawing.Size(72, 16);
            this.lbltenhang.TabIndex = 36;
            this.lbltenhang.Text = "Tên hàng";
            // 
            // cbotenhang
            // 
            this.cbotenhang.FormattingEnabled = true;
            this.cbotenhang.Location = new System.Drawing.Point(122, 137);
            this.cbotenhang.Name = "cbotenhang";
            this.cbotenhang.Size = new System.Drawing.Size(250, 24);
            this.cbotenhang.TabIndex = 34;
            // 
            // cbotenkhach
            // 
            this.cbotenkhach.FormattingEnabled = true;
            this.cbotenkhach.Location = new System.Drawing.Point(122, 103);
            this.cbotenkhach.Name = "cbotenkhach";
            this.cbotenkhach.Size = new System.Drawing.Size(250, 24);
            this.cbotenkhach.TabIndex = 33;
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahd.Location = new System.Drawing.Point(10, 39);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(91, 16);
            this.lblmahd.TabIndex = 15;
            this.lblmahd.Text = "Mã hóa đơn";
            // 
            // lbltieude
            // 
            this.lbltieude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.Blue;
            this.lbltieude.Location = new System.Drawing.Point(476, 54);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(260, 29);
            this.lbltieude.TabIndex = 30;
            this.lbltieude.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(790, 561);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 50);
            this.btnsua.TabIndex = 75;
            this.btnsua.Text = "Sửa";
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(970, 561);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 50);
            this.btnthoat.TabIndex = 73;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseWaitCursor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(602, 561);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 50);
            this.btnxoa.TabIndex = 74;
            this.btnxoa.Text = "Xóa";
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(419, 561);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 50);
            this.btnthem.TabIndex = 71;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AllowUserToAddRows = false;
            this.dgvhoadon.AllowUserToDeleteRows = false;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.ngayban,
            this.tenkhachhang,
            this.tenhang,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dgvhoadon.Location = new System.Drawing.Point(538, 100);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.ReadOnly = true;
            this.dgvhoadon.RowTemplate.Height = 24;
            this.dgvhoadon.Size = new System.Drawing.Size(678, 399);
            this.dgvhoadon.TabIndex = 78;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellClick);
            // 
            // mahoadon
            // 
            this.mahoadon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.ReadOnly = true;
            // 
            // ngayban
            // 
            this.ngayban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayban.HeaderText = "Ngày Bán";
            this.ngayban.Name = "ngayban";
            this.ngayban.ReadOnly = true;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            // 
            // tenhang
            // 
            this.tenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 715);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltieude);
            this.Name = "frmhoadon";
            this.Text = "frmhoadon";
            this.Load += new System.EventHandler(this.frmhoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.DateTimePicker dtpngayban;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label lblngayban;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.Label lbltieude;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.ComboBox cbotenhang;
        private System.Windows.Forms.ComboBox cbotenkhach;
        private System.Windows.Forms.Label lbltenhang;
    }
}