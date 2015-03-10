namespace Hostel
{
    partial class ReportViewer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HostelDataSet = new Hostel.HostelDataSet();
            this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentsTableAdapter = new Hostel.HostelDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hostel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // HostelDataSet
            // 
            this.HostelDataSet.DataSetName = "HostelDataSet";
            this.HostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentsBindingSource
            // 
            this.StudentsBindingSource.DataMember = "Students";
            this.StudentsBindingSource.DataSource = this.HostelDataSet;
            // 
            // StudentsTableAdapter
            // 
            this.StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 418);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentsBindingSource;
        private HostelDataSet HostelDataSet;
        private HostelDataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
    }
}