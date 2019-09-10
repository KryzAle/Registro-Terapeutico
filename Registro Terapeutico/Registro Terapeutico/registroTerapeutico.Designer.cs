namespace Registro_Terapeutico
{
    partial class registroTerapeutico
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
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_txt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.paciente_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Diagnostico_txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tipo_cmb = new System.Windows.Forms.ComboBox();
            this.terapia_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numero_repeticion_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Observaciones_txt = new System.Windows.Forms.TextBox();
            this.hogarAncianosDataSet1 = new Registro_Terapeutico.HogarAncianosDataSet1();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Registro_Terapeutico.HogarAncianosDataSet1TableAdapters.PacienteTableAdapter();
            this.hogarAncianosDataSet2 = new Registro_Terapeutico.HogarAncianosDataSet2();
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter1 = new Registro_Terapeutico.HogarAncianosDataSet2TableAdapters.PacienteTableAdapter();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.registro_btn = new System.Windows.Forms.Button();
            this.empezar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Registro";
            // 
            // fecha_txt
            // 
            this.fecha_txt.Location = new System.Drawing.Point(133, 9);
            this.fecha_txt.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fecha_txt.Name = "fecha_txt";
            this.fecha_txt.Size = new System.Drawing.Size(205, 20);
            this.fecha_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paciente";
            // 
            // paciente_cmb
            // 
            this.paciente_cmb.FormattingEnabled = true;
            this.paciente_cmb.Location = new System.Drawing.Point(133, 46);
            this.paciente_cmb.Name = "paciente_cmb";
            this.paciente_cmb.Size = new System.Drawing.Size(437, 21);
            this.paciente_cmb.TabIndex = 3;
            this.paciente_cmb.SelectedIndexChanged += new System.EventHandler(this.Paciente_cmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diagnostico";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Diagnostico_txt
            // 
            this.Diagnostico_txt.Location = new System.Drawing.Point(133, 89);
            this.Diagnostico_txt.Multiline = true;
            this.Diagnostico_txt.Name = "Diagnostico_txt";
            this.Diagnostico_txt.Size = new System.Drawing.Size(437, 55);
            this.Diagnostico_txt.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tratamiento";
            // 
            // tipo_cmb
            // 
            this.tipo_cmb.FormattingEnabled = true;
            this.tipo_cmb.Location = new System.Drawing.Point(133, 170);
            this.tipo_cmb.Name = "tipo_cmb";
            this.tipo_cmb.Size = new System.Drawing.Size(205, 21);
            this.tipo_cmb.TabIndex = 8;
            this.tipo_cmb.SelectedIndexChanged += new System.EventHandler(this.Tipo_cmb_SelectedIndexChanged);
            // 
            // terapia_cmb
            // 
            this.terapia_cmb.FormattingEnabled = true;
            this.terapia_cmb.Location = new System.Drawing.Point(365, 170);
            this.terapia_cmb.Name = "terapia_cmb";
            this.terapia_cmb.Size = new System.Drawing.Size(205, 21);
            this.terapia_cmb.TabIndex = 9;
            this.terapia_cmb.SelectedIndexChanged += new System.EventHandler(this.Terapia_cmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de Repeticiones";
            // 
            // numero_repeticion_txt
            // 
            this.numero_repeticion_txt.Location = new System.Drawing.Point(195, 216);
            this.numero_repeticion_txt.Name = "numero_repeticion_txt";
            this.numero_repeticion_txt.Size = new System.Drawing.Size(76, 20);
            this.numero_repeticion_txt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observaciones";
            // 
            // Observaciones_txt
            // 
            this.Observaciones_txt.Location = new System.Drawing.Point(133, 275);
            this.Observaciones_txt.Multiline = true;
            this.Observaciones_txt.Name = "Observaciones_txt";
            this.Observaciones_txt.Size = new System.Drawing.Size(437, 55);
            this.Observaciones_txt.TabIndex = 14;
            // 
            // hogarAncianosDataSet1
            // 
            this.hogarAncianosDataSet1.DataSetName = "HogarAncianosDataSet1";
            this.hogarAncianosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.hogarAncianosDataSet1;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // hogarAncianosDataSet2
            // 
            this.hogarAncianosDataSet2.DataSetName = "HogarAncianosDataSet2";
            this.hogarAncianosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataMember = "Paciente";
            this.pacienteBindingSource1.DataSource = this.hogarAncianosDataSet2;
            // 
            // pacienteTableAdapter1
            // 
            this.pacienteTableAdapter1.ClearBeforeFill = true;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancelar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.Image = global::Registro_Terapeutico.Properties.Resources.flecha_hacia_atras;
            this.cancelar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar_btn.Location = new System.Drawing.Point(475, 361);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(95, 33);
            this.cancelar_btn.TabIndex = 17;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // registro_btn
            // 
            this.registro_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registro_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.registro_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.registro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registro_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_btn.Image = global::Registro_Terapeutico.Properties.Resources.guardar__1_;
            this.registro_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registro_btn.Location = new System.Drawing.Point(38, 361);
            this.registro_btn.Name = "registro_btn";
            this.registro_btn.Size = new System.Drawing.Size(102, 33);
            this.registro_btn.TabIndex = 16;
            this.registro_btn.Text = "Registrar";
            this.registro_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registro_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registro_btn.UseVisualStyleBackColor = true;
            this.registro_btn.Click += new System.EventHandler(this.Registro_btn_Click);
            // 
            // empezar_btn
            // 
            this.empezar_btn.Enabled = false;
            this.empezar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.empezar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.empezar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.empezar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empezar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empezar_btn.Image = global::Registro_Terapeutico.Properties.Resources.barra_con_pesas;
            this.empezar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empezar_btn.Location = new System.Drawing.Point(600, 47);
            this.empezar_btn.Name = "empezar_btn";
            this.empezar_btn.Size = new System.Drawing.Size(212, 149);
            this.empezar_btn.TabIndex = 12;
            this.empezar_btn.Text = "Empezar Terapia";
            this.empezar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.empezar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.empezar_btn.UseVisualStyleBackColor = true;
            this.empezar_btn.Click += new System.EventHandler(this.Empezar_btn_Click);
            // 
            // registroTerapeutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 434);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.registro_btn);
            this.Controls.Add(this.Observaciones_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.empezar_btn);
            this.Controls.Add(this.numero_repeticion_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.terapia_cmb);
            this.Controls.Add(this.tipo_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Diagnostico_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paciente_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_txt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "registroTerapeutico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Terapeutico";
            this.Load += new System.EventHandler(this.RegistroTerapeutico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox paciente_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Diagnostico_txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipo_cmb;
        private System.Windows.Forms.ComboBox terapia_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numero_repeticion_txt;
        private System.Windows.Forms.Button empezar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Observaciones_txt;
        private System.Windows.Forms.Button registro_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private HogarAncianosDataSet1 hogarAncianosDataSet1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private HogarAncianosDataSet1TableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private HogarAncianosDataSet2 hogarAncianosDataSet2;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private HogarAncianosDataSet2TableAdapters.PacienteTableAdapter pacienteTableAdapter1;
    }
}