namespace Registro_Terapeutico
{
    partial class ReporteMensual
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
            this.Registro_TerapeuticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegistroTerapias = new Registro_Terapeutico.RegistroTerapias();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Registro_TerapeuticoTableAdapter = new Registro_Terapeutico.RegistroTerapiasTableAdapters.Registro_TerapeuticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroTerapias)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro_TerapeuticoBindingSource
            // 
            this.Registro_TerapeuticoBindingSource.DataMember = "Registro_Terapeutico";
            this.Registro_TerapeuticoBindingSource.DataSource = this.RegistroTerapias;
            // 
            // RegistroTerapias
            // 
            this.RegistroTerapias.DataSetName = "RegistroTerapias";
            this.RegistroTerapias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.nuevo_btn.Location = new System.Drawing.Point(546, 12);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(88, 33);
            this.nuevo_btn.TabIndex = 28;
            this.nuevo_btn.Text = "Generar";
            this.nuevo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // fecha_fin
            // 
            this.fecha_fin.Location = new System.Drawing.Point(310, 48);
            this.fecha_fin.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(205, 20);
            this.fecha_fin.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fin:";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Location = new System.Drawing.Point(310, 12);
            this.fecha_inicio.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(205, 20);
            this.fecha_inicio.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Inicio:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RegistroTerapeuticoPorFechas";
            reportDataSource1.Value = this.Registro_TerapeuticoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.terapiasPorFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(742, 349);
            this.reportViewer1.TabIndex = 33;
            // 
            // Registro_TerapeuticoTableAdapter
            // 
            this.Registro_TerapeuticoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nuevo_btn);
            this.Name = "ReporteMensual";
            this.Text = "ReporteMensual";
            this.Load += new System.EventHandler(this.ReporteMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroTerapias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevo_btn;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Registro_TerapeuticoBindingSource;
        private RegistroTerapias RegistroTerapias;
        private RegistroTerapiasTableAdapters.Registro_TerapeuticoTableAdapter Registro_TerapeuticoTableAdapter;
    }
}