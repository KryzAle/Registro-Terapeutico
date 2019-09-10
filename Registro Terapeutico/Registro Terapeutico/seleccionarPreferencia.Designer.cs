namespace Registro_Terapeutico
{
    partial class seleccionarPreferencia
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
            this.preferencia_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registro_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preferencia_cmb
            // 
            this.preferencia_cmb.FormattingEnabled = true;
            this.preferencia_cmb.Location = new System.Drawing.Point(133, 8);
            this.preferencia_cmb.Name = "preferencia_cmb";
            this.preferencia_cmb.Size = new System.Drawing.Size(437, 21);
            this.preferencia_cmb.TabIndex = 5;
            this.preferencia_cmb.SelectedIndexChanged += new System.EventHandler(this.Cancion_cmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preferencia";
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
            this.registro_btn.Location = new System.Drawing.Point(241, 50);
            this.registro_btn.Name = "registro_btn";
            this.registro_btn.Size = new System.Drawing.Size(102, 33);
            this.registro_btn.TabIndex = 17;
            this.registro_btn.Text = "Siguiente";
            this.registro_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registro_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registro_btn.UseVisualStyleBackColor = true;
            this.registro_btn.Click += new System.EventHandler(this.Registro_btn_Click);
            // 
            // seleccionarPreferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 113);
            this.Controls.Add(this.registro_btn);
            this.Controls.Add(this.preferencia_cmb);
            this.Controls.Add(this.label2);
            this.Name = "seleccionarPreferencia";
            this.Text = "seleccionarPreferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox preferencia_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registro_btn;
    }
}