namespace Registro_Terapeutico
{
    partial class Registro_Usuario
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
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.registro_btn = new System.Windows.Forms.Button();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(174, 29);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(195, 20);
            this.usuario_txt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuario:";
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(174, 109);
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(195, 20);
            this.apellido_txt.TabIndex = 12;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(174, 81);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(195, 20);
            this.nombre_txt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
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
            this.cancelar_btn.Location = new System.Drawing.Point(381, 187);
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
            this.registro_btn.Location = new System.Drawing.Point(82, 187);
            this.registro_btn.Name = "registro_btn";
            this.registro_btn.Size = new System.Drawing.Size(102, 33);
            this.registro_btn.TabIndex = 19;
            this.registro_btn.Text = "Registrar";
            this.registro_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registro_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registro_btn.UseVisualStyleBackColor = true;
            this.registro_btn.Click += new System.EventHandler(this.Registro_btn_Click);
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(174, 55);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(195, 20);
            this.pass_txt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Contraseña";
            // 
            // Registro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 244);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.registro_btn);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Registro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button registro_btn;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label5;
    }
}