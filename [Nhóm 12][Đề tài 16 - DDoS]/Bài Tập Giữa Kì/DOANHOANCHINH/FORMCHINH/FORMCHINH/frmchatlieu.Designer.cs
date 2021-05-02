namespace FORMCHINH
{
    partial class frmchatlieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchatlieu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.machatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmacl = new System.Windows.Forms.Label();
            this.lbltencl = new System.Windows.Forms.Label();
            this.txtmacl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttencl = new System.Windows.Forms.TextBox();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machatlieu,
            this.tenchatlieu});
            this.dataGridView1.Location = new System.Drawing.Point(454, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // machatlieu
            // 
            this.machatlieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machatlieu.HeaderText = "Mã chất liệu";
            this.machatlieu.Name = "machatlieu";
            this.machatlieu.ReadOnly = true;
            // 
            // tenchatlieu
            // 
            this.tenchatlieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenchatlieu.HeaderText = "Tên chất liệu";
            this.tenchatlieu.Name = "tenchatlieu";
            this.tenchatlieu.ReadOnly = true;
            // 
            // lblmacl
            // 
            this.lblmacl.AutoSize = true;
            this.lblmacl.Location = new System.Drawing.Point(6, 46);
            this.lblmacl.Name = "lblmacl";
            this.lblmacl.Size = new System.Drawing.Size(79, 17);
            this.lblmacl.TabIndex = 1;
            this.lblmacl.Text = "Mã chất liệu";
            // 
            // lbltencl
            // 
            this.lbltencl.AutoSize = true;
            this.lbltencl.Location = new System.Drawing.Point(6, 124);
            this.lbltencl.Name = "lbltencl";
            this.lbltencl.Size = new System.Drawing.Size(85, 17);
            this.lbltencl.TabIndex = 2;
            this.lbltencl.Text = "Tên chất liệu";
            // 
            // txtmacl
            // 
            this.txtmacl.Location = new System.Drawing.Point(91, 43);
            this.txtmacl.Name = "txtmacl";
            this.txtmacl.Size = new System.Drawing.Size(228, 23);
            this.txtmacl.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttencl);
            this.groupBox1.Controls.Add(this.lblmacl);
            this.groupBox1.Controls.Add(this.txtmacl);
            this.groupBox1.Controls.Add(this.lbltencl);
            this.groupBox1.Location = new System.Drawing.Point(33, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chất liệu";
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(91, 121);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(228, 23);
            this.txttencl.TabIndex = 5;
            // 
            // btnsua
            // 
            this.btnsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.Image")));
            this.btnsua.Location = new System.Drawing.Point(543, 430);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 50);
            this.btnsua.TabIndex = 69;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(724, 430);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 50);
            this.btnthoat.TabIndex = 67;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseWaitCursor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(358, 430);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 50);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(168, 430);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 50);
            this.btnthem.TabIndex = 65;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmchatlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 492);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmchatlieu";
            this.Text = "frmchatlieu";
            this.Load += new System.EventHandler(this.frmchatlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblmacl;
        private System.Windows.Forms.Label lbltencl;
        private System.Windows.Forms.TextBox txtmacl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn machatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchatlieu;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.TextBox txttencl;
    }
}