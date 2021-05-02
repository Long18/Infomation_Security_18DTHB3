namespace Phan_mem_ngan_hang
{
    partial class Danhsachchinhanhcongty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_dschinhanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_thongtinchinhanh = new System.Windows.Forms.GroupBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenchinhanh = new System.Windows.Forms.TextBox();
            this.txt_machinhanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dschinhanh)).BeginInit();
            this.grb_thongtinchinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dschinhanh
            // 
            this.dgv_dschinhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dschinhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_dschinhanh.Location = new System.Drawing.Point(153, 354);
            this.dgv_dschinhanh.Name = "dgv_dschinhanh";
            this.dgv_dschinhanh.Size = new System.Drawing.Size(892, 284);
            this.dgv_dschinhanh.TabIndex = 0;
            this.dgv_dschinhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dschinhanh_CellClick);
            this.dgv_dschinhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Mã chi nhánh";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên chi nhánh";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 350;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(592, 132);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 29);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(592, 257);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(85, 29);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(592, 194);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(85, 29);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(375, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH CHI NHÁNH CỦA CÔNG TY";
            // 
            // grb_thongtinchinhanh
            // 
            this.grb_thongtinchinhanh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grb_thongtinchinhanh.Controls.Add(this.txt_diachi);
            this.grb_thongtinchinhanh.Controls.Add(this.txt_tenchinhanh);
            this.grb_thongtinchinhanh.Controls.Add(this.txt_machinhanh);
            this.grb_thongtinchinhanh.Controls.Add(this.label4);
            this.grb_thongtinchinhanh.Controls.Add(this.label3);
            this.grb_thongtinchinhanh.Controls.Add(this.label2);
            this.grb_thongtinchinhanh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongtinchinhanh.Location = new System.Drawing.Point(153, 106);
            this.grb_thongtinchinhanh.Name = "grb_thongtinchinhanh";
            this.grb_thongtinchinhanh.Size = new System.Drawing.Size(368, 205);
            this.grb_thongtinchinhanh.TabIndex = 5;
            this.grb_thongtinchinhanh.TabStop = false;
            this.grb_thongtinchinhanh.Text = "Thông tin chi nhánh";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(187, 128);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(100, 23);
            this.txt_diachi.TabIndex = 5;
            // 
            // txt_tenchinhanh
            // 
            this.txt_tenchinhanh.Location = new System.Drawing.Point(187, 80);
            this.txt_tenchinhanh.Name = "txt_tenchinhanh";
            this.txt_tenchinhanh.Size = new System.Drawing.Size(100, 23);
            this.txt_tenchinhanh.TabIndex = 4;
            // 
            // txt_machinhanh
            // 
            this.txt_machinhanh.Location = new System.Drawing.Point(187, 33);
            this.txt_machinhanh.Name = "txt_machinhanh";
            this.txt_machinhanh.Size = new System.Drawing.Size(100, 23);
            this.txt_machinhanh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên chi nhánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chi nhánh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phan_mem_ngan_hang.Properties.Resources.background_powerpoint_cong_nghe_42;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1459, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Danhsachchinhanhcongty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_thongtinchinhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_dschinhanh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Danhsachchinhanhcongty";
            this.Size = new System.Drawing.Size(1459, 641);
            this.Load += new System.EventHandler(this.Danhsachchinhanhcongty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dschinhanh)).EndInit();
            this.grb_thongtinchinhanh.ResumeLayout(false);
            this.grb_thongtinchinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dschinhanh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_thongtinchinhanh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenchinhanh;
        private System.Windows.Forms.TextBox txt_machinhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
