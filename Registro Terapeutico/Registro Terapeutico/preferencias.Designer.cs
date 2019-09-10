namespace Registro_Terapeutico
{
    partial class preferencias
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
            this.paciente_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paciente_cmb
            // 
            this.paciente_cmb.FormattingEnabled = true;
            this.paciente_cmb.Location = new System.Drawing.Point(133, 23);
            this.paciente_cmb.Name = "paciente_cmb";
            this.paciente_cmb.Size = new System.Drawing.Size(437, 21);
            this.paciente_cmb.TabIndex = 5;
            this.paciente_cmb.SelectedIndexChanged += new System.EventHandler(this.Paciente_cmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paciente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 207);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Archivo";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(133, 77);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(437, 20);
            this.nombre_txt.TabIndex = 9;
            // 
            // buscar_btn
            // 
            this.buscar_btn.Location = new System.Drawing.Point(133, 116);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(145, 23);
            this.buscar_btn.TabIndex = 10;
            this.buscar_btn.Text = "Seleccionar ....";
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Image = global::Registro_Terapeutico.Properties.Resources.guardar__1_;
            this.guardar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar_btn.Location = new System.Drawing.Point(84, 200);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(75, 23);
            this.guardar_btn.TabIndex = 11;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.Guardar_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Image = global::Registro_Terapeutico.Properties.Resources.guardar__1_;
            this.eliminar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar_btn.Location = new System.Drawing.Point(263, 200);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(75, 23);
            this.eliminar_btn.TabIndex = 12;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::Registro_Terapeutico.Properties.Resources.flecha_hacia_atras;
            this.cancelar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar_btn.Location = new System.Drawing.Point(495, 200);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 13;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paciente_cmb);
            this.Controls.Add(this.label2);
            this.Name = "preferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferencias";
            this.Load += new System.EventHandler(this.Preferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paciente_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}