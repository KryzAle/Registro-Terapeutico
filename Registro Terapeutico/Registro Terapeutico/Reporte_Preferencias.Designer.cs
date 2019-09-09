namespace Registro_Terapeutico
{
    partial class Reporte_Preferencias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.paciente_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Preferencias = new Registro_Terapeutico.Preferencias();
            this.PreferenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PreferenciaTableAdapter = new Registro_Terapeutico.PreferenciasTableAdapters.PreferenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Preferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreferenciaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.nuevo_btn.Location = new System.Drawing.Point(721, 15);
            this.nuevo_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(117, 41);
            this.nuevo_btn.TabIndex = 32;
            this.nuevo_btn.Text = "Generar";
            this.nuevo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // paciente_cmb
            // 
            this.paciente_cmb.FormattingEnabled = true;
            this.paciente_cmb.Location = new System.Drawing.Point(357, 15);
            this.paciente_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paciente_cmb.Name = "paciente_cmb";
            this.paciente_cmb.Size = new System.Drawing.Size(272, 24);
            this.paciente_cmb.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Paciente:";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Preferencias";
            reportDataSource2.Value = this.PreferenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.ReportePreferencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(50, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(989, 445);
            this.reportViewer1.TabIndex = 33;
            // 
            // Preferencias
            // 
            this.Preferencias.DataSetName = "Preferencias";
            this.Preferencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PreferenciaBindingSource
            // 
            this.PreferenciaBindingSource.DataMember = "Preferencia";
            this.PreferenciaBindingSource.DataSource = this.Preferencias;
            // 
            // PreferenciaTableAdapter
            // 
            this.PreferenciaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nuevo_btn);
            this.Controls.Add(this.paciente_cmb);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reporte_Preferencias";
            this.Text = "Reporte_Preferencias";
            this.Load += new System.EventHandler(this.Reporte_Preferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Preferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreferenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevo_btn;
        private System.Windows.Forms.ComboBox paciente_cmb;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PreferenciaBindingSource;
        private Preferencias Preferencias;
        private PreferenciasTableAdapters.PreferenciaTableAdapter PreferenciaTableAdapter;
    }
}