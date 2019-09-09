namespace Registro_Terapeutico
{
    partial class Terapias_por_Fecha
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
            this.fechaInicio_txt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaFin_Txt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteTratamiento = new Registro_Terapeutico.ReporteTratamiento();
            this.Registro_TerapeuticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Registro_TerapeuticoTableAdapter = new Registro_Terapeutico.ReporteTratamientoTableAdapters.Registro_TerapeuticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaInicio_txt
            // 
            this.fechaInicio_txt.Location = new System.Drawing.Point(451, 15);
            this.fechaInicio_txt.Margin = new System.Windows.Forms.Padding(4);
            this.fechaInicio_txt.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fechaInicio_txt.Name = "fechaInicio_txt";
            this.fechaInicio_txt.Size = new System.Drawing.Size(272, 22);
            this.fechaInicio_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio:";
            // 
            // fechaFin_Txt
            // 
            this.fechaFin_Txt.Location = new System.Drawing.Point(451, 59);
            this.fechaFin_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.fechaFin_Txt.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fechaFin_Txt.Name = "fechaFin_Txt";
            this.fechaFin_Txt.Size = new System.Drawing.Size(272, 22);
            this.fechaFin_Txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fin:";
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
            this.nuevo_btn.Location = new System.Drawing.Point(808, 43);
            this.nuevo_btn.Margin = new System.Windows.Forms.Padding(4);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(117, 41);
            this.nuevo_btn.TabIndex = 19;
            this.nuevo_btn.Text = "Generar";
            this.nuevo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Registro_TerapeuticoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.ReporteTerapiaPorFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1161, 532);
            this.reportViewer1.TabIndex = 20;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // ReporteTratamiento
            // 
            this.ReporteTratamiento.DataSetName = "ReporteTratamiento";
            this.ReporteTratamiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registro_TerapeuticoBindingSource
            // 
            this.Registro_TerapeuticoBindingSource.DataMember = "Registro_Terapeutico";
            this.Registro_TerapeuticoBindingSource.DataSource = this.ReporteTratamiento;
            // 
            // Registro_TerapeuticoTableAdapter
            // 
            this.Registro_TerapeuticoTableAdapter.ClearBeforeFill = true;
            // 
            // Terapias_por_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 671);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nuevo_btn);
            this.Controls.Add(this.fechaFin_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaInicio_txt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Terapias_por_Fecha";
            this.Text = "Terapias_por_Fecha";
            this.Load += new System.EventHandler(this.Terapias_por_Fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicio_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaFin_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nuevo_btn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Registro_TerapeuticoBindingSource;
        private ReporteTratamiento ReporteTratamiento;
        private ReporteTratamientoTableAdapters.Registro_TerapeuticoTableAdapter Registro_TerapeuticoTableAdapter;
    }
}