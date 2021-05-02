namespace Phan_mem_ngan_hang
{
    partial class frmThemtkn
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
            this.txtTknhan = new System.Windows.Forms.TextBox();
            this.labtkn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTknhan
            // 
            this.txtTknhan.Location = new System.Drawing.Point(237, 26);
            this.txtTknhan.Name = "txtTknhan";
            this.txtTknhan.Size = new System.Drawing.Size(137, 20);
            this.txtTknhan.TabIndex = 40;
            // 
            // labtkn
            // 
            this.labtkn.AutoSize = true;
            this.labtkn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtkn.Location = new System.Drawing.Point(117, 30);
            this.labtkn.Name = "labtkn";
            this.labtkn.Size = new System.Drawing.Size(105, 16);
            this.labtkn.TabIndex = 39;
            this.labtkn.Text = "Tài khoản nhận";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThemtkn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTknhan);
            this.Controls.Add(this.labtkn);
            this.Name = "frmThemtkn";
            this.Text = "Nhập số tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTknhan;
        private System.Windows.Forms.Label labtkn;
        private System.Windows.Forms.Button button1;
    }
}