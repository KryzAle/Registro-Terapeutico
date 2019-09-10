namespace Registro_Terapeutico
{
    partial class ReporteTratamientosGrobales
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
            this.TerapiasGlobales = new Registro_Terapeutico.TerapiasGlobales();
            this.TerapiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TerapiaTableAdapter = new Registro_Terapeutico.TerapiasGlobalesTableAdapters.TerapiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TerapiasGlobales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerapiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reporteTerapiasGlobales";
            reportDataSource1.Value = this.TerapiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.reporteTerapiasGlobales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TerapiasGlobales
            // 
            this.TerapiasGlobales.DataSetName = "TerapiasGlobales";
            this.TerapiasGlobales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TerapiaBindingSource
            // 
            this.TerapiaBindingSource.DataMember = "Terapia";
            this.TerapiaBindingSource.DataSource = this.TerapiasGlobales;
            // 
            // TerapiaTableAdapter
            // 
            this.TerapiaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteTratamientosGrobales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteTratamientosGrobales";
            this.Text = "ReporteTratamientosGrobales";
            this.Load += new System.EventHandler(this.ReporteTratamientosGrobales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TerapiasGlobales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerapiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TerapiaBindingSource;
        private TerapiasGlobales TerapiasGlobales;
        private TerapiasGlobalesTableAdapters.TerapiaTableAdapter TerapiaTableAdapter;
    }
}