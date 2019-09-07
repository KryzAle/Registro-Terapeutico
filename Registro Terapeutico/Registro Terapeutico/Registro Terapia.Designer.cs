namespace Registro_Terapeutico
{
    partial class Registro_Terapia
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
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.registro_btn = new System.Windows.Forms.Button();
            this.hogarAncianosDataSet = new Registro_Terapeutico.HogarAncianosDataSet();
            this.tipoTerapiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_TerapiaTableAdapter = new Registro_Terapeutico.HogarAncianosDataSetTableAdapters.Tipo_TerapiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTerapiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(162, 63);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(195, 20);
            this.nombre_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // tipo_cmb
            // 
            this.tipo_cmb.DataSource = this.tipoTerapiaBindingSource;
            this.tipo_cmb.DisplayMember = "nombre_tip";
            this.tipo_cmb.FormattingEnabled = true;
            this.tipo_cmb.Location = new System.Drawing.Point(162, 96);
            this.tipo_cmb.Name = "tipo_cmb";
            this.tipo_cmb.Size = new System.Drawing.Size(195, 21);
            this.tipo_cmb.TabIndex = 10;
            this.tipo_cmb.ValueMember = "codigo_tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
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
            this.cancelar_btn.Location = new System.Drawing.Point(432, 146);
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
            this.registro_btn.Location = new System.Drawing.Point(89, 146);
            this.registro_btn.Name = "registro_btn";
            this.registro_btn.Size = new System.Drawing.Size(102, 33);
            this.registro_btn.TabIndex = 19;
            this.registro_btn.Text = "Registrar";
            this.registro_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registro_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registro_btn.UseVisualStyleBackColor = true;
            this.registro_btn.Click += new System.EventHandler(this.Registro_btn_Click);
            // 
            // hogarAncianosDataSet
            // 
            this.hogarAncianosDataSet.DataSetName = "HogarAncianosDataSet";
            this.hogarAncianosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoTerapiaBindingSource
            // 
            this.tipoTerapiaBindingSource.DataMember = "Tipo_Terapia";
            this.tipoTerapiaBindingSource.DataSource = this.hogarAncianosDataSet;
            // 
            // tipo_TerapiaTableAdapter
            // 
            this.tipo_TerapiaTableAdapter.ClearBeforeFill = true;
            // 
            // Registro_Terapia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 199);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.registro_btn);
            this.Controls.Add(this.tipo_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label2);
            this.Name = "Registro_Terapia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Terapia";
            this.Load += new System.EventHandler(this.Registro_Terapia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hogarAncianosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTerapiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipo_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button registro_btn;
        private HogarAncianosDataSet hogarAncianosDataSet;
        private System.Windows.Forms.BindingSource tipoTerapiaBindingSource;
        private HogarAncianosDataSetTableAdapters.Tipo_TerapiaTableAdapter tipo_TerapiaTableAdapter;
    }
}