
namespace pjQLLNV
{
    partial class ReportLichsu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LICHSUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sqlQLLSPDataSet1 = new pjQLLNV.sqlQLLSPDataSet1();
            this.LICHSUTableAdapter = new pjQLLNV.sqlQLLSPDataSetTableAdapters.LICHSUTableAdapter();
            this.sqlQLLSPDataSet = new pjQLLNV.sqlQLLSPDataSet();
            this.ClsDsNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbXoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LICHSUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQLLSPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQLLSPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsDsNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LICHSUBindingSource
            // 
            this.LICHSUBindingSource.DataMember = "LICHSU";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LICHSUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pjQLLNV.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sqlQLLSPDataSet1
            // 
            this.sqlQLLSPDataSet1.DataSetName = "sqlQLLSPDataSet1";
            this.sqlQLLSPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LICHSUTableAdapter
            // 
            this.LICHSUTableAdapter.ClearBeforeFill = true;
            // 
            // sqlQLLSPDataSet
            // 
            this.sqlQLLSPDataSet.DataSetName = "sqlQLLSPDataSet";
            this.sqlQLLSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClsDsNVBindingSource
            // 
            this.ClsDsNVBindingSource.DataSource = typeof(pjQLLNV.ClsDsNV);
            // 
            // lbXoa
            // 
            this.lbXoa.AutoSize = true;
            this.lbXoa.Location = new System.Drawing.Point(694, 9);
            this.lbXoa.Name = "lbXoa";
            this.lbXoa.Size = new System.Drawing.Size(59, 13);
            this.lbXoa.TabIndex = 2;
            this.lbXoa.Text = "Xóa lịch sử";
            this.lbXoa.Click += new System.EventHandler(this.lbXoa_Click);
            // 
            // ReportLichsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbXoa);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportLichsu";
            this.Text = "ReportLichsu";
            this.Load += new System.EventHandler(this.ReportLichsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LICHSUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQLLSPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQLLSPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClsDsNVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sqlQLLSPDataSet1 sqlQLLSPDataSet1;
        private System.Windows.Forms.BindingSource LICHSUBindingSource;
        private sqlQLLSPDataSetTableAdapters.LICHSUTableAdapter LICHSUTableAdapter;
        private sqlQLLSPDataSet sqlQLLSPDataSet;
        private System.Windows.Forms.BindingSource ClsDsNVBindingSource;
        private System.Windows.Forms.Label lbXoa;
    }
}