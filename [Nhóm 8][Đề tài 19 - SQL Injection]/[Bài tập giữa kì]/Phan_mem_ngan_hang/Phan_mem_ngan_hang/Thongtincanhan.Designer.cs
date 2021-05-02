namespace Phan_mem_ngan_hang
{
    partial class Thongtincanhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_msNhanvien = new System.Windows.Forms.TextBox();
            this.txt_hotennv = new System.Windows.Forms.TextBox();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_chucvu);
            this.groupBox1.Controls.Add(this.txt_phongban);
            this.groupBox1.Controls.Add(this.txt_hotennv);
            this.groupBox1.Controls.Add(this.txt_msNhanvien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(307, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(371, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số nhân viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng ban:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ:";
            // 
            // txt_msNhanvien
            // 
            this.txt_msNhanvien.Location = new System.Drawing.Point(207, 42);
            this.txt_msNhanvien.Name = "txt_msNhanvien";
            this.txt_msNhanvien.ReadOnly = true;
            this.txt_msNhanvien.Size = new System.Drawing.Size(100, 21);
            this.txt_msNhanvien.TabIndex = 4;
            // 
            // txt_hotennv
            // 
            this.txt_hotennv.Location = new System.Drawing.Point(207, 65);
            this.txt_hotennv.Name = "txt_hotennv";
            this.txt_hotennv.ReadOnly = true;
            this.txt_hotennv.Size = new System.Drawing.Size(100, 21);
            this.txt_hotennv.TabIndex = 4;
            // 
            // txt_phongban
            // 
            this.txt_phongban.Location = new System.Drawing.Point(207, 108);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.ReadOnly = true;
            this.txt_phongban.Size = new System.Drawing.Size(100, 21);
            this.txt_phongban.TabIndex = 4;
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Location = new System.Drawing.Point(207, 145);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.ReadOnly = true;
            this.txt_chucvu.Size = new System.Drawing.Size(100, 21);
            this.txt_chucvu.TabIndex = 4;
            // 
            // Thongtincanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thongtincanhan";
            this.Size = new System.Drawing.Size(1459, 641);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.TextBox txt_phongban;
        private System.Windows.Forms.TextBox txt_hotennv;
        private System.Windows.Forms.TextBox txt_msNhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
