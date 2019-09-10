namespace Registro_Terapeutico
{
    partial class Reporte_Diagnostico_Paciente
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
            this.TratamientoPorPaciente = new Registro_Terapeutico.TratamientoPorPaciente();
            this.nuevo_btn = new System.Windows.Forms.Button();
            this.paciente_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Registro_TerapeuticoTableAdapter = new Registro_Terapeutico.TratamientoPorPacienteTableAdapters.Registro_TerapeuticoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TratamientoPorPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro_TerapeuticoBindingSource
            // 
            this.Registro_TerapeuticoBindingSource.DataMember = "Registro_Terapeutico";
            this.Registro_TerapeuticoBindingSource.DataSource = this.TratamientoPorPaciente;
            // 
            // TratamientoPorPaciente
            // 
            this.TratamientoPorPaciente.DataSetName = "TratamientoPorPaciente";
            this.TratamientoPorPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.nuevo_btn.Location = new System.Drawing.Point(567, 41);
            this.nuevo_btn.Name = "nuevo_btn";
            this.nuevo_btn.Size = new System.Drawing.Size(88, 33);
            this.nuevo_btn.TabIndex = 27;
            this.nuevo_btn.Text = "Generar";
            this.nuevo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevo_btn.UseVisualStyleBackColor = true;
            this.nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // paciente_cmb
            // 
            this.paciente_cmb.FormattingEnabled = true;
            this.paciente_cmb.Location = new System.Drawing.Point(330, 18);
            this.paciente_cmb.Name = "paciente_cmb";
            this.paciente_cmb.Size = new System.Drawing.Size(205, 21);
            this.paciente_cmb.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Paciente:";
            // 
            // fecha_fin
            // 
            this.fecha_fin.Location = new System.Drawing.Point(330, 90);
            this.fecha_fin.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(205, 20);
            this.fecha_fin.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fin:";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Location = new System.Drawing.Point(330, 54);
            this.fecha_inicio.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(205, 20);
            this.fecha_inicio.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inicio:";
            // 
            // Registro_TerapeuticoTableAdapter
            // 
            this.Registro_TerapeuticoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Registro_TerapeuticoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro_Terapeutico.ReportePorPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 132);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(765, 306);
            this.reportViewer1.TabIndex = 28;
            // 
            // Reporte_Diagnostico_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nuevo_btn);
            this.Controls.Add(this.paciente_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label1);
            this.Name = "Reporte_Diagnostico_Paciente";
            this.Text = "Reporte Diagnostico Paciente";
            this.Load += new System.EventHandler(this.Reporte_Diagnostico_Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registro_TerapeuticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TratamientoPorPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nuevo_btn;
        private System.Windows.Forms.ComboBox paciente_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource Registro_TerapeuticoBindingSource;
        private TratamientoPorPaciente TratamientoPorPaciente;
        private TratamientoPorPacienteTableAdapters.Registro_TerapeuticoTableAdapter Registro_TerapeuticoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}