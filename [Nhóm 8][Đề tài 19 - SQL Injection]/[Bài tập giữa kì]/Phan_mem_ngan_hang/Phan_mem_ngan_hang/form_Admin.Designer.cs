namespace Phan_mem_ngan_hang
{
    partial class form_Admin
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
            this.btn_giamsat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giamsat
            // 
            this.btn_giamsat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giamsat.Location = new System.Drawing.Point(78, 259);
            this.btn_giamsat.Name = "btn_giamsat";
            this.btn_giamsat.Size = new System.Drawing.Size(227, 48);
            this.btn_giamsat.TabIndex = 0;
            this.btn_giamsat.Text = "Giám sát hoạt động user";
            this.btn_giamsat.UseVisualStyleBackColor = true;
            this.btn_giamsat.Click += new System.EventHandler(this.btn_giamsat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "GIAO DIỆN CHỨC NĂNG ADMIN";
            // 
            // form_Admin
            // 
            this.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Phan_mem_ngan_hang.Properties.Resources._202005081841474476_53b69c422220bc2bf60d1eb70fd98f41;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giamsat);
            this.Name = "form_Admin";
            this.Size = new System.Drawing.Size(1175, 509);
            this.Load += new System.EventHandler(this.form_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giamsat;
        private System.Windows.Forms.Label label1;
    }
}
