namespace Registro_Terapeutico
{
    partial class historiaClinica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cedula_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha_registro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.antecedentes_txt = new System.Windows.Forms.TextBox();
            this.impresion_diagnostica = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discapacidad_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.articular_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.neurologicas_txt = new System.Windows.Forms.ComboBox();
            this.muscular_txt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.marcha_box = new System.Windows.Forms.GroupBox();
            this.rm3 = new System.Windows.Forms.RadioButton();
            this.rm2 = new System.Windows.Forms.RadioButton();
            this.rm1 = new System.Windows.Forms.RadioButton();
            this.dolor_box = new System.Windows.Forms.GroupBox();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.registro_btn = new System.Windows.Forms.Button();
            this.pacientesRegistrados = new Registro_Terapeutico.PacientesRegistrados();
            this.pacientesRegistradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hogarAncianosDataSet1 = new Registro_Terapeutico.HogarAncianosDataSet1();
            this.hogarAncianosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preferencias = new Registro_Terapeutico.Preferencias();
            this.preferenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modificar_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecedentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neurologica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impresiondiagnostica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hogarAncianosDataSet3 = new Registro_Terapeutico.HogarAncianosDataSet3();
            this.pacienteTableAdapter = new Registro_Terapeutico.HogarAncianosDataSet3TableAdapters.PacienteTableAdapter();
            this.groupBox1.SuspendLayout();
            this.marcha_box.SuspendLayout();
            this.dolor_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesRegistradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Personales del Paciente";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(128, 49);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(243, 20);
            this.nombre_txt.TabIndex = 4;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(128, 77);
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(243, 20);
            this.apellido_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de\r\nNacimiento:";
            // 
            // cedula_txt
            // 
            this.cedula_txt.Location = new System.Drawing.Point(128, 110);
            this.cedula_txt.Name = "cedula_txt";
            this.cedula_txt.Size = new System.Drawing.Size(243, 20);
            this.cedula_txt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Registro:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // fecha_registro
            // 
            this.fecha_registro.Location = new System.Drawing.Point(171, 194);
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.Size = new System.Drawing.Size(200, 20);
            this.fecha_registro.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Antecedentes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Impresión \r\nDiagnóstica:";
            // 
            // antecedentes_txt
            // 
            this.antecedentes_txt.Location = new System.Drawing.Point(142, 235);
            this.antecedentes_txt.Multiline = true;
            this.antecedentes_txt.Name = "antecedentes_txt";
            this.antecedentes_txt.Size = new System.Drawing.Size(229, 76);
            this.antecedentes_txt.TabIndex = 13;
            // 
            // impresion_diagnostica
            // 
            this.impresion_diagnostica.Location = new System.Drawing.Point(142, 337);
            this.impresion_diagnostica.Multiline = true;
            this.impresion_diagnostica.Name = "impresion_diagnostica";
            this.impresion_diagnostica.Size = new System.Drawing.Size(229, 76);
            this.impresion_diagnostica.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discapacidad_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.articular_txt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.neurologicas_txt);
            this.groupBox1.Controls.Add(this.muscular_txt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.marcha_box);
            this.groupBox1.Controls.Add(this.dolor_box);
            this.groupBox1.Location = new System.Drawing.Point(398, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 364);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valoración Física";
            // 
            // discapacidad_txt
            // 
            this.discapacidad_txt.Location = new System.Drawing.Point(148, 316);
            this.discapacidad_txt.Name = "discapacidad_txt";
            this.discapacidad_txt.Size = new System.Drawing.Size(349, 20);
            this.discapacidad_txt.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Discapacidad";
            // 
            // articular_txt
            // 
            this.articular_txt.Location = new System.Drawing.Point(117, 209);
            this.articular_txt.Multiline = true;
            this.articular_txt.Name = "articular_txt";
            this.articular_txt.Size = new System.Drawing.Size(379, 78);
            this.articular_txt.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Articular";
            // 
            // neurologicas_txt
            // 
            this.neurologicas_txt.FormattingEnabled = true;
            this.neurologicas_txt.Items.AddRange(new object[] {
            "Coordinación",
            "Propiocepción"});
            this.neurologicas_txt.Location = new System.Drawing.Point(301, 169);
            this.neurologicas_txt.Name = "neurologicas_txt";
            this.neurologicas_txt.Size = new System.Drawing.Size(195, 21);
            this.neurologicas_txt.TabIndex = 19;
            // 
            // muscular_txt
            // 
            this.muscular_txt.FormattingEnabled = true;
            this.muscular_txt.Items.AddRange(new object[] {
            "0 Ausente",
            "1 Mínima",
            "2 Escasa",
            "3 Regular",
            "4 Buena",
            "5 Normal"});
            this.muscular_txt.Location = new System.Drawing.Point(301, 130);
            this.muscular_txt.Name = "muscular_txt";
            this.muscular_txt.Size = new System.Drawing.Size(195, 21);
            this.muscular_txt.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Neurologicas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Muscular";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // marcha_box
            // 
            this.marcha_box.Controls.Add(this.rm3);
            this.marcha_box.Controls.Add(this.rm2);
            this.marcha_box.Controls.Add(this.rm1);
            this.marcha_box.Location = new System.Drawing.Point(198, 33);
            this.marcha_box.Name = "marcha_box";
            this.marcha_box.Size = new System.Drawing.Size(151, 93);
            this.marcha_box.TabIndex = 1;
            this.marcha_box.TabStop = false;
            this.marcha_box.Text = "Marcha";
            // 
            // rm3
            // 
            this.rm3.AutoSize = true;
            this.rm3.Location = new System.Drawing.Point(6, 66);
            this.rm3.Name = "rm3";
            this.rm3.Size = new System.Drawing.Size(99, 17);
            this.rm3.TabIndex = 2;
            this.rm3.TabStop = true;
            this.rm3.Text = "Anda sin Ayuda";
            this.rm3.UseVisualStyleBackColor = true;
            // 
            // rm2
            // 
            this.rm2.AutoSize = true;
            this.rm2.Location = new System.Drawing.Point(6, 43);
            this.rm2.Name = "rm2";
            this.rm2.Size = new System.Drawing.Size(137, 17);
            this.rm2.TabIndex = 1;
            this.rm2.TabStop = true;
            this.rm2.Text = "Anda con ayuda parcial";
            this.rm2.UseVisualStyleBackColor = true;
            // 
            // rm1
            // 
            this.rm1.AutoSize = true;
            this.rm1.Checked = true;
            this.rm1.Location = new System.Drawing.Point(6, 20);
            this.rm1.Name = "rm1";
            this.rm1.Size = new System.Drawing.Size(115, 17);
            this.rm1.TabIndex = 0;
            this.rm1.TabStop = true;
            this.rm1.Text = "No anda/No carga";
            this.rm1.UseVisualStyleBackColor = true;
            // 
            // dolor_box
            // 
            this.dolor_box.Controls.Add(this.rd5);
            this.dolor_box.Controls.Add(this.rd4);
            this.dolor_box.Controls.Add(this.rd3);
            this.dolor_box.Controls.Add(this.rd2);
            this.dolor_box.Controls.Add(this.rd1);
            this.dolor_box.Location = new System.Drawing.Point(24, 28);
            this.dolor_box.Name = "dolor_box";
            this.dolor_box.Size = new System.Drawing.Size(151, 155);
            this.dolor_box.TabIndex = 0;
            this.dolor_box.TabStop = false;
            this.dolor_box.Text = "Dolor";
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(16, 112);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(51, 17);
            this.rd5.TabIndex = 4;
            this.rd5.TabStop = true;
            this.rd5.Text = "100%";
            this.rd5.UseVisualStyleBackColor = true;
            this.rd5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(16, 89);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(45, 17);
            this.rd4.TabIndex = 3;
            this.rd4.TabStop = true;
            this.rd4.Text = "75%";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(16, 66);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(45, 17);
            this.rd3.TabIndex = 2;
            this.rd3.TabStop = true;
            this.rd3.Text = "50%";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(16, 43);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(45, 17);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "25%";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.Location = new System.Drawing.Point(17, 20);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(39, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "0%";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.Location = new System.Drawing.Point(128, 152);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(243, 20);
            this.fecha_nacimiento.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.apellido,
            this.nombre,
            this.cedula,
            this.fechanacimiento,
            this.fecharegistro,
            this.antecedentes,
            this.dolor,
            this.marcha,
            this.muscular,
            this.neurologica,
            this.articular,
            this.discapacidad,
            this.impresiondiagnostica});
            this.dataGridView1.DataSource = this.pacienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(901, 172);
            this.dataGridView1.TabIndex = 21;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo_pac";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
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
            this.cancelar_btn.Location = new System.Drawing.Point(644, 430);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(95, 33);
            this.cancelar_btn.TabIndex = 20;
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
            this.registro_btn.Location = new System.Drawing.Point(142, 430);
            this.registro_btn.Name = "registro_btn";
            this.registro_btn.Size = new System.Drawing.Size(102, 33);
            this.registro_btn.TabIndex = 19;
            this.registro_btn.Text = "Registrar";
            this.registro_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registro_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registro_btn.UseVisualStyleBackColor = true;
            this.registro_btn.Click += new System.EventHandler(this.Registro_btn_Click);
            // 
            // pacientesRegistrados
            // 
            this.pacientesRegistrados.DataSetName = "PacientesRegistrados";
            this.pacientesRegistrados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesRegistradosBindingSource
            // 
            this.pacientesRegistradosBindingSource.DataSource = this.pacientesRegistrados;
            this.pacientesRegistradosBindingSource.Position = 0;
            // 
            // hogarAncianosDataSet1
            // 
            this.hogarAncianosDataSet1.DataSetName = "HogarAncianosDataSet1";
            this.hogarAncianosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hogarAncianosDataSet1BindingSource
            // 
            this.hogarAncianosDataSet1BindingSource.DataSource = this.hogarAncianosDataSet1;
            this.hogarAncianosDataSet1BindingSource.Position = 0;
            // 
            // preferencias
            // 
            this.preferencias.DataSetName = "Preferencias";
            this.preferencias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preferenciasBindingSource
            // 
            this.preferenciasBindingSource.DataSource = this.preferencias;
            this.preferenciasBindingSource.Position = 0;
            // 
            // modificar_btn
            // 
            this.modificar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.modificar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.Image = global::Registro_Terapeutico.Properties.Resources.guardar__1_;
            this.modificar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificar_btn.Location = new System.Drawing.Point(312, 430);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(102, 33);
            this.modificar_btn.TabIndex = 22;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Click += new System.EventHandler(this.Modificar_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.AutoEllipsis = true;
            this.eliminar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eliminar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.eliminar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.Image = global::Registro_Terapeutico.Properties.Resources.guardar__1_;
            this.eliminar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar_btn.Location = new System.Drawing.Point(471, 430);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(102, 33);
            this.eliminar_btn.TabIndex = 23;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido_pac";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre_pac";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "cedula_pac";
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.DataPropertyName = "fecha_nacimiento_pac";
            this.fechanacimiento.HeaderText = "Fecha Nacimiento";
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.ReadOnly = true;
            // 
            // fecharegistro
            // 
            this.fecharegistro.DataPropertyName = "fecha_registro_pac";
            this.fecharegistro.HeaderText = "Fecha Registro";
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            // 
            // antecedentes
            // 
            this.antecedentes.DataPropertyName = "antecedentes_pac";
            this.antecedentes.HeaderText = "Antecedentes";
            this.antecedentes.Name = "antecedentes";
            this.antecedentes.ReadOnly = true;
            // 
            // dolor
            // 
            this.dolor.DataPropertyName = "dolor_pac";
            this.dolor.HeaderText = "% Dolor";
            this.dolor.Name = "dolor";
            this.dolor.ReadOnly = true;
            // 
            // marcha
            // 
            this.marcha.DataPropertyName = "marcha_pac";
            this.marcha.HeaderText = "Marcha";
            this.marcha.Name = "marcha";
            this.marcha.ReadOnly = true;
            // 
            // muscular
            // 
            this.muscular.DataPropertyName = "muscular_pac";
            this.muscular.HeaderText = "Muscular";
            this.muscular.Name = "muscular";
            this.muscular.ReadOnly = true;
            // 
            // neurologica
            // 
            this.neurologica.DataPropertyName = "neurologica_pac";
            this.neurologica.HeaderText = "Neurologica";
            this.neurologica.Name = "neurologica";
            this.neurologica.ReadOnly = true;
            // 
            // articular
            // 
            this.articular.DataPropertyName = "articular_pac";
            this.articular.HeaderText = "Articular";
            this.articular.Name = "articular";
            this.articular.ReadOnly = true;
            // 
            // discapacidad
            // 
            this.discapacidad.DataPropertyName = "discapacidad_pac";
            this.discapacidad.HeaderText = "Discapacidad";
            this.discapacidad.Name = "discapacidad";
            this.discapacidad.ReadOnly = true;
            // 
            // impresiondiagnostica
            // 
            this.impresiondiagnostica.DataPropertyName = "impresion_diagnostica_pac";
            this.impresiondiagnostica.HeaderText = "Impresion Diagnostica";
            this.impresiondiagnostica.Name = "impresiondiagnostica";
            this.impresiondiagnostica.ReadOnly = true;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.hogarAncianosDataSet3;
            // 
            // hogarAncianosDataSet3
            // 
            this.hogarAncianosDataSet3.DataSetName = "HogarAncianosDataSet3";
            this.hogarAncianosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // historiaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 679);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.registro_btn);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.impresion_diagnostica);
            this.Controls.Add(this.antecedentes_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fecha_registro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cedula_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "historiaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clinica";
            this.Load += new System.EventHandler(this.HistoriaClinica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.marcha_box.ResumeLayout(false);
            this.marcha_box.PerformLayout();
            this.dolor_box.ResumeLayout(false);
            this.dolor_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesRegistradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cedula_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha_registro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox antecedentes_txt;
        private System.Windows.Forms.TextBox impresion_diagnostica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox marcha_box;
        private System.Windows.Forms.RadioButton rm3;
        private System.Windows.Forms.RadioButton rm2;
        private System.Windows.Forms.RadioButton rm1;
        private System.Windows.Forms.GroupBox dolor_box;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox articular_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox neurologicas_txt;
        private System.Windows.Forms.ComboBox muscular_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button registro_btn;
        private System.Windows.Forms.TextBox discapacidad_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pacientesRegistradosBindingSource;
        private PacientesRegistrados pacientesRegistrados;
        private System.Windows.Forms.BindingSource preferenciasBindingSource;
        private Preferencias preferencias;
        private HogarAncianosDataSet1 hogarAncianosDataSet1;
        private System.Windows.Forms.BindingSource hogarAncianosDataSet1BindingSource;
        private HogarAncianosDataSet3 hogarAncianosDataSet3;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private HogarAncianosDataSet3TableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcha;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn neurologica;
        private System.Windows.Forms.DataGridViewTextBoxColumn articular;
        private System.Windows.Forms.DataGridViewTextBoxColumn discapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn impresiondiagnostica;
        private System.Windows.Forms.Button eliminar_btn;
    }
}