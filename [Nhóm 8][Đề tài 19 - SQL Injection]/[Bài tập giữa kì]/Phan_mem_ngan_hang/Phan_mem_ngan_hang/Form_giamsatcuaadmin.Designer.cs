namespace Phan_mem_ngan_hang
{
    partial class Form_giamsatcuaadmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandoimatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_tat = new System.Windows.Forms.RadioButton();
            this.rbt_bat = new System.Windows.Forms.RadioButton();
            this.btn_xoalichsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOTENNV,
            this.thoigiandangnhap,
            this.thoigiandoimatkhau});
            this.dataGridView1.Location = new System.Drawing.Point(185, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HOTENNV
            // 
            this.HOTENNV.HeaderText = "TÀI KHOẢN NHÂN VIÊN";
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Width = 200;
            // 
            // thoigiandangnhap
            // 
            this.thoigiandangnhap.HeaderText = "NỘI DUNG";
            this.thoigiandangnhap.Name = "thoigiandangnhap";
            this.thoigiandangnhap.ToolTipText = "THỜI GIAN ";
            this.thoigiandangnhap.Width = 350;
            // 
            // thoigiandoimatkhau
            // 
            this.thoigiandoimatkhau.HeaderText = "THỜI GIAN TRUY CẬP";
            this.thoigiandoimatkhau.Name = "thoigiandoimatkhau";
            this.thoigiandoimatkhau.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "GIÁM SÁT HOẠT ĐỘNG USER";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.rbt_tat);
            this.groupBox1.Controls.Add(this.rbt_bat);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BẬT/TẮT GIÁM SÁT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbt_tat
            // 
            this.rbt_tat.AutoSize = true;
            this.rbt_tat.Location = new System.Drawing.Point(73, 20);
            this.rbt_tat.Name = "rbt_tat";
            this.rbt_tat.Size = new System.Drawing.Size(55, 24);
            this.rbt_tat.TabIndex = 1;
            this.rbt_tat.Text = "TẮT";
            this.rbt_tat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbt_tat.UseVisualStyleBackColor = true;
            this.rbt_tat.CheckedChanged += new System.EventHandler(this.rbt_tat_CheckedChanged);
            // 
            // rbt_bat
            // 
            this.rbt_bat.AutoSize = true;
            this.rbt_bat.Checked = true;
            this.rbt_bat.Location = new System.Drawing.Point(6, 21);
            this.rbt_bat.Name = "rbt_bat";
            this.rbt_bat.Size = new System.Drawing.Size(56, 24);
            this.rbt_bat.TabIndex = 0;
            this.rbt_bat.TabStop = true;
            this.rbt_bat.Text = "BẬT";
            this.rbt_bat.UseVisualStyleBackColor = true;
            this.rbt_bat.CheckedChanged += new System.EventHandler(this.rbt_bat_CheckedChanged);
            // 
            // btn_xoalichsu
            // 
            this.btn_xoalichsu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoalichsu.Location = new System.Drawing.Point(964, 90);
            this.btn_xoalichsu.Name = "btn_xoalichsu";
            this.btn_xoalichsu.Size = new System.Drawing.Size(115, 31);
            this.btn_xoalichsu.TabIndex = 3;
            this.btn_xoalichsu.Text = "Xóa lịch sừ";
            this.btn_xoalichsu.UseVisualStyleBackColor = true;
            this.btn_xoalichsu.Click += new System.EventHandler(this.btn_xoalichsu_Click);
            // 
            // Form_giamsatcuaadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Phan_mem_ngan_hang.Properties.Resources.Bg_verification_of_employees_cvs;
            this.ClientSize = new System.Drawing.Size(1127, 667);
            this.Controls.Add(this.btn_xoalichsu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_giamsatcuaadmin";
            this.Text = "Form_giamsatcuaadmin";
            this.Load += new System.EventHandler(this.Form_giamsatcuaadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandoimatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_tat;
        private System.Windows.Forms.RadioButton rbt_bat;
        private System.Windows.Forms.Button btn_xoalichsu;
    }
}