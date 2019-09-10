namespace Registro_Terapeutico
{
    partial class ReportePacientesGlobales
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
            this.PacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacientesGlobales = new Registro_Terapeutico.PacientesGlobales();
            this.TratamientoPorPaciente = new Registro_Terapeutico.TratamientoPorPaciente();
            this.Registro_TerapeuticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Registro_TerapeuticoTableAdapter = new Registro_Terapeutico.TratamientoPorPacienteTableAdapters.Registro_TerapeuticoTableAdapter();
            this.PacienteTableAdapter = new Registro_Terapeutico.PacientesGlobalesTableAdapters.Paciente1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesGlobales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TratamientoPorPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PacienteBindingSource
            // 
            this.PacienteBindingSource.DataMember = "Paciente";
            this.PacienteBindingSource.DataSource = this.PacientesGlobales;
            // 
            // PacientesGlobales
            // 
            this.PacientesGlobales.DataSetName = "PacientesGlobales";
            this.PacientesGlobales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TratamientoPorPaciente
            // 
            this.TratamientoPorPaciente.DataSetName = "TratamientoPorPaciente";
            this.TratamientoPorPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registro_TerapeuticoBindingSource
            // 
            this.Registro_TerapeuticoBindingSource.DataMember = "Registro_Terapeutico";
            this.Registro_TerapeuticoBindingSource.DataSource = this.TratamientoPorPaciente;
            // 
            // Registro_TerapeuticoTableAdapter
            // 
            this.Registro_TerapeuticoTableAdapter.ClearBeforeFill = true;
            // 
            // PacienteTableAdapter
            // 
            this.PacienteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PacientesGlobales";
            reportDataSource1.Value = this.PacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.ReportePacientesGlobales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportePacientesGlobales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePacientesGlobales";
            this.Text = "ReportePacientesGlobales";
            this.Load += new System.EventHandler(this.ReportePacientesGlobales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesGlobales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TratamientoPorPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Registro_TerapeuticoBindingSource;
        private TratamientoPorPaciente TratamientoPorPaciente;
        private TratamientoPorPacienteTableAdapters.Registro_TerapeuticoTableAdapter Registro_TerapeuticoTableAdapter;
        private System.Windows.Forms.BindingSource PacienteBindingSource;
        private PacientesGlobales PacientesGlobales;
        private PacientesGlobalesTableAdapters.Paciente1TableAdapter PacienteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}