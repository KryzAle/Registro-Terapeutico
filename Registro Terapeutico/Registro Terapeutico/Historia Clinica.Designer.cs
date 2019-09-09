﻿namespace Registro_Terapeutico
{
    partial class Historia_Clinica
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
            this.paciente_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PacientesRegistrados = new Registro_Terapeutico.PacientesRegistrados();
            this.PacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacienteTableAdapter = new Registro_Terapeutico.PacientesRegistradosTableAdapters.PacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paciente_cmb
            // 
            this.paciente_cmb.FormattingEnabled = true;
            this.paciente_cmb.Location = new System.Drawing.Point(383, 15);
            this.paciente_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paciente_cmb.Name = "paciente_cmb";
            this.paciente_cmb.Size = new System.Drawing.Size(272, 24);
            this.paciente_cmb.TabIndex = 28;
            this.paciente_cmb.SelectedIndexChanged += new System.EventHandler(this.Tipo_cmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Paciente:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // nuevo_btn
            // 
            this.nuevo_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nuevo_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.nuevo_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_btn.Image = global::Registro_Terapeutico.Properties.Resources.agregar_boton_dentro_del_circulo_negro__1_;
            this.nuevo_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo_btn.Location = new System.Drawing.Point(747, 15);
            this.nuevo_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(117, 41);
            this.nuevo_btn.TabIndex = 29;
            this.nuevo_btn.Text = "Generar";
            this.nuevo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.ReporteHistoriaClinicaPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(49, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1231, 592);
            this.reportViewer1.TabIndex = 30;
            // 
            // PacientesRegistrados
            // 
            this.PacientesRegistrados.DataSetName = "PacientesRegistrados";
            this.PacientesRegistrados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PacienteBindingSource
            // 
            this.PacienteBindingSource.DataMember = "Paciente";
            this.PacienteBindingSource.DataSource = this.PacientesRegistrados;
            // 
            // PacienteTableAdapter
            // 
            this.PacienteTableAdapter.ClearBeforeFill = true;
            // 
            // Historia_Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 727);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nuevo_btn);
            this.Controls.Add(this.paciente_cmb);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Historia_Clinica";
            this.Text = "Historia_Clinica";
            this.Load += new System.EventHandler(this.Historia_Clinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacientesRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paciente_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nuevo_btn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PacienteBindingSource;
        private PacientesRegistrados PacientesRegistrados;
        private PacientesRegistradosTableAdapters.PacienteTableAdapter PacienteTableAdapter;
    }
}