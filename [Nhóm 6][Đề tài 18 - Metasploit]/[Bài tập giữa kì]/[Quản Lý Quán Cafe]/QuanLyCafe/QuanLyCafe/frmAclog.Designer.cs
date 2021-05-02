namespace QuanLyCafe
{
    partial class frmAclog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAclog));
            this.dgvActivitylist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitylist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivitylist
            // 
            this.dgvActivitylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivitylist.Location = new System.Drawing.Point(1, 1);
            this.dgvActivitylist.Name = "dgvActivitylist";
            this.dgvActivitylist.Size = new System.Drawing.Size(557, 326);
            this.dgvActivitylist.TabIndex = 0;
            // 
            // frmAclog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyCafe.Properties.Resources.song_don_gian_1110x600;
            this.ClientSize = new System.Drawing.Size(595, 355);
            this.Controls.Add(this.dgvActivitylist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(611, 394);
            this.MinimumSize = new System.Drawing.Size(611, 394);
            this.Name = "frmAclog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity Log";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivitylist;
    }
}