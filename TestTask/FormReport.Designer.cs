namespace TestTask
{
    partial class FormReport
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
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataSet = new TestTask.employeesDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new TestTask.employeesDataSetTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TestTask.ReportAvgReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(294, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "employees";
            this.bindingSource2.DataSource = this.employeesDataSet;
            // 
            // employeesDataSet
            // 
            this.employeesDataSet.DataSetName = "employeesDataSet";
            this.employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.employeesDataSet;
            this.bindingSource1.Position = 0;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 579);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private DataSet dataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        //private DataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.BindingSource employeesDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.BindingSource employeesDataSetBindingSource1;
        private System.Windows.Forms.BindingSource employeesDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource employeesDataSet1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private employeesDataSet employeesDataSet;
        private System.Windows.Forms.BindingSource bindingSource2;
        private employeesDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
    }
}