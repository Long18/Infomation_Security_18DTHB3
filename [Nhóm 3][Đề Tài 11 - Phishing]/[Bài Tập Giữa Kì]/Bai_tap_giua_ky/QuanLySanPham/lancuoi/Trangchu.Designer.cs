
namespace lancuoi
{
    partial class Trangchu
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
            this.btnquanli = new System.Windows.Forms.Button();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.btnpb = new System.Windows.Forms.Button();
            this.lbTKn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnquanli
            // 
            this.btnquanli.BackColor = System.Drawing.Color.MediumBlue;
            this.btnquanli.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquanli.Location = new System.Drawing.Point(53, 41);
            this.btnquanli.Name = "btnquanli";
            this.btnquanli.Size = new System.Drawing.Size(144, 52);
            this.btnquanli.TabIndex = 0;
            this.btnquanli.Text = "Quản lí";
            this.btnquanli.UseVisualStyleBackColor = false;
            this.btnquanli.Click += new System.EventHandler(this.btnquanli_Click);
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.BackColor = System.Drawing.Color.MediumBlue;
            this.btndoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimatkhau.Location = new System.Drawing.Point(288, 41);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(259, 52);
            this.btndoimatkhau.TabIndex = 1;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = false;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // btnpb
            // 
            this.btnpb.BackColor = System.Drawing.Color.MediumBlue;
            this.btnpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpb.Location = new System.Drawing.Point(639, 41);
            this.btnpb.Name = "btnpb";
            this.btnpb.Size = new System.Drawing.Size(309, 52);
            this.btnpb.TabIndex = 2;
            this.btnpb.Text = "Quản lí phòng ban";
            this.btnpb.UseVisualStyleBackColor = false;
            this.btnpb.Click += new System.EventHandler(this.btnpb_Click);
            // 
            // lbTKn
            // 
            this.lbTKn.AutoSize = true;
            this.lbTKn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKn.Location = new System.Drawing.Point(13, 4);
            this.lbTKn.Name = "lbTKn";
            this.lbTKn.Size = new System.Drawing.Size(0, 20);
            this.lbTKn.TabIndex = 3;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lancuoi.Properties.Resources._3_49;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 541);
            this.Controls.Add(this.lbTKn);
            this.Controls.Add(this.btnpb);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.btnquanli);
            this.DoubleBuffered = true;
            this.Name = "Trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trangchu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquanli;
        private System.Windows.Forms.Button btndoimatkhau;
        private System.Windows.Forms.Button btnpb;
        private System.Windows.Forms.Label lbTKn;
    }
}