
namespace FORMCHINH
{
    partial class frmdk
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxnmk = new System.Windows.Forms.TextBox();
            this.bthdangki = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtloaitk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tài khoản";
            // 
            // txtxnmk
            // 
            this.txtxnmk.Location = new System.Drawing.Point(373, 220);
            this.txtxnmk.Name = "txtxnmk";
            this.txtxnmk.Size = new System.Drawing.Size(207, 23);
            this.txtxnmk.TabIndex = 12;
            this.txtxnmk.UseSystemPasswordChar = true;
            // 
            // bthdangki
            // 
            this.bthdangki.Location = new System.Drawing.Point(266, 381);
            this.bthdangki.Name = "bthdangki";
            this.bthdangki.Size = new System.Drawing.Size(127, 57);
            this.bthdangki.TabIndex = 11;
            this.bthdangki.Text = "Đăng Kí";
            this.bthdangki.UseVisualStyleBackColor = true;
            this.bthdangki.Click += new System.EventHandler(this.bthdangki_Click);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(373, 177);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(207, 23);
            this.txtmk.TabIndex = 10;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(373, 130);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(207, 23);
            this.txttk.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mật khẩu mã hoá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Loại tài khoản";
            // 
            // txtloaitk
            // 
            this.txtloaitk.Location = new System.Drawing.Point(373, 264);
            this.txtloaitk.Name = "txtloaitk";
            this.txtloaitk.Size = new System.Drawing.Size(33, 23);
            this.txtloaitk.TabIndex = 19;
            this.txtloaitk.TextChanged += new System.EventHandler(this.txtloaitk_TextChanged);
            // 
            // frmdk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 497);
            this.Controls.Add(this.txtloaitk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtxnmk);
            this.Controls.Add(this.bthdangki);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Name = "frmdk";
            this.Text = "frmdk";
            this.Load += new System.EventHandler(this.frmdk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxnmk;
        private System.Windows.Forms.Button bthdangki;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtloaitk;
    }
}