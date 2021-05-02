namespace QuanLyCafe
{
    partial class frmWorkSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkSchedule));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNotify = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDayWorksList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUntick = new System.Windows.Forms.Button();
            this.btnTick = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayWorksList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblNotify);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 36);
            this.panel2.TabIndex = 8;
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(9, 10);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(320, 18);
            this.lblNotify.TabIndex = 0;
            this.lblNotify.Text = "Chọn ngày để đánh dấu ngày làm của nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgvDayWorksList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(328, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 298);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Những ngày nhân viên đi làm";
            // 
            // dgvDayWorksList
            // 
            this.dgvDayWorksList.AllowUserToAddRows = false;
            this.dgvDayWorksList.AllowUserToDeleteRows = false;
            this.dgvDayWorksList.AllowUserToOrderColumns = true;
            this.dgvDayWorksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayWorksList.Location = new System.Drawing.Point(6, 18);
            this.dgvDayWorksList.MultiSelect = false;
            this.dgvDayWorksList.Name = "dgvDayWorksList";
            this.dgvDayWorksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDayWorksList.Size = new System.Drawing.Size(489, 273);
            this.dgvDayWorksList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnUntick);
            this.groupBox2.Controls.Add(this.btnTick);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 298);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn nhân viên";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(4, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 2);
            this.label3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 109);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày đang chọn:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboStaff);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(6, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 35);
            this.panel4.TabIndex = 0;
            // 
            // cboStaff
            // 
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(134, 6);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(161, 26);
            this.cboStaff.TabIndex = 1;
            this.cboStaff.SelectedIndexChanged += new System.EventHandler(this.cboStaff_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ tên nhân viên:";
            // 
            // btnUntick
            // 
            this.btnUntick.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUntick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUntick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUntick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUntick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUntick.ForeColor = System.Drawing.Color.Black;
            this.btnUntick.Image = global::QuanLyCafe.Properties.Resources.icon_delete;
            this.btnUntick.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUntick.Location = new System.Drawing.Point(4, 183);
            this.btnUntick.Name = "btnUntick";
            this.btnUntick.Size = new System.Drawing.Size(144, 109);
            this.btnUntick.TabIndex = 1;
            this.btnUntick.Text = "Xóa ngày làm";
            this.btnUntick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUntick.UseVisualStyleBackColor = true;
            this.btnUntick.Click += new System.EventHandler(this.btnUntick_Click_1);
            // 
            // btnTick
            // 
            this.btnTick.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnTick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTick.ForeColor = System.Drawing.Color.Black;
            this.btnTick.Image = global::QuanLyCafe.Properties.Resources.icon_tick1;
            this.btnTick.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTick.Location = new System.Drawing.Point(160, 183);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(141, 109);
            this.btnTick.TabIndex = 1;
            this.btnTick.Text = "Thêm ngày làm";
            this.btnTick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // frmWorkSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 387);
            this.MinimumSize = new System.Drawing.Size(850, 387);
            this.Name = "frmWorkSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công nhân viên";
            this.Load += new System.EventHandler(this.frmWorkSchedule_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayWorksList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDayWorksList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUntick;
        private System.Windows.Forms.Button btnTick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Label label6;

    }
}