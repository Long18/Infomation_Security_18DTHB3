namespace FORMCHINH
{
    partial class frmkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkhachhang));
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdiachikhach = new System.Windows.Forms.TextBox();
            this.txtdienthoaikhach = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblmakhach = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dienthoai
            // 
            this.dienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dienthoai.HeaderText = "Điện thoại";
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // tenkhach
            // 
            this.tenkhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkhach.HeaderText = "Tên khách";
            this.tenkhach.Name = "tenkhach";
            this.tenkhach.ReadOnly = true;
            // 
            // makhach
            // 
            this.makhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makhach.HeaderText = "Mã khách";
            this.makhach.Name = "makhach";
            this.makhach.ReadOnly = true;
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AllowUserToDeleteRows = false;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhach,
            this.tenkhach,
            this.diachi,
            this.dienthoai});
            this.dgvkhachhang.Location = new System.Drawing.Point(447, 119);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.ReadOnly = true;
            this.dgvkhachhang.RowTemplate.Height = 24;
            this.dgvkhachhang.Size = new System.Drawing.Size(649, 437);
            this.dgvkhachhang.TabIndex = 32;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // txtdiachikhach
            // 
            this.txtdiachikhach.Location = new System.Drawing.Point(132, 106);
            this.txtdiachikhach.Name = "txtdiachikhach";
            this.txtdiachikhach.Size = new System.Drawing.Size(250, 22);
            this.txtdiachikhach.TabIndex = 27;
            // 
            // txtdienthoaikhach
            // 
            this.txtdienthoaikhach.Location = new System.Drawing.Point(132, 138);
            this.txtdienthoaikhach.Name = "txtdienthoaikhach";
            this.txtdienthoaikhach.Size = new System.Drawing.Size(250, 22);
            this.txtdienthoaikhach.TabIndex = 25;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(132, 72);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(250, 22);
            this.txttenkhach.TabIndex = 23;
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(132, 36);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(250, 22);
            this.txtmakhach.TabIndex = 22;
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldienthoai.Location = new System.Drawing.Point(14, 141);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(79, 16);
            this.lbldienthoai.TabIndex = 19;
            this.lbldienthoai.Text = "Điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.Location = new System.Drawing.Point(14, 109);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(55, 16);
            this.lbldiachi.TabIndex = 18;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkhach.Location = new System.Drawing.Point(14, 75);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(79, 16);
            this.lbltenkhach.TabIndex = 16;
            this.lbltenkhach.Text = "Tên khách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiachikhach);
            this.groupBox1.Controls.Add(this.txtdienthoaikhach);
            this.groupBox1.Controls.Add(this.txttenkhach);
            this.groupBox1.Controls.Add(this.txtmakhach);
            this.groupBox1.Controls.Add(this.lbldienthoai);
            this.groupBox1.Controls.Add(this.lbldiachi);
            this.groupBox1.Controls.Add(this.lbltenkhach);
            this.groupBox1.Controls.Add(this.lblmakhach);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 399);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // lblmakhach
            // 
            this.lblmakhach.AutoSize = true;
            this.lblmakhach.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakhach.Location = new System.Drawing.Point(14, 39);
            this.lblmakhach.Name = "lblmakhach";
            this.lblmakhach.Size = new System.Drawing.Size(75, 16);
            this.lblmakhach.TabIndex = 15;
            this.lblmakhach.Text = "Mã khách";
            // 
            // lbltieude
            // 
            this.lbltieude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltieude.AutoSize = true;
            this.lbltieude.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.Blue;
            this.lbltieude.Location = new System.Drawing.Point(406, 73);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(312, 29);
            this.lbltieude.TabIndex = 24;
            this.lbltieude.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(719, 618);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 50);
            this.btnsua.TabIndex = 63;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(906, 618);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 50);
            this.btnthoat.TabIndex = 61;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseWaitCursor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(529, 618);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 50);
            this.btnxoa.TabIndex = 62;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(340, 618);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 50);
            this.btnthem.TabIndex = 59;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 732);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltieude);
            this.Name = "frmkhachhang";
            this.Text = "frmkhachhang";
            this.Load += new System.EventHandler(this.frmkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhach;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.TextBox txtdiachikhach;
        private System.Windows.Forms.TextBox txtdienthoaikhach;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblmakhach;
        private System.Windows.Forms.Label lbltieude;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}