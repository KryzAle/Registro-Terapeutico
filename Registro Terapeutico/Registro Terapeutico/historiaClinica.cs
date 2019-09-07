using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registro_Terapeutico
{
    public partial class historiaClinica : Form
    {
        SqlConnection conn;
        public historiaClinica()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Registro_btn_Click(object sender, EventArgs e)
        {
            string cadena= "insert into Paciente(nombre_pac, apellido_pac, cedula_pac, fecha_nacimiento_pac, fecha_registro_pac, antecedentes_pac, dolor_pac, marcha_pac, muscular_pac, neurologica_pac, articular_pac, discapacidad_pac, impresion_diagnostica_pac) values('"+nombre_txt.Text+"', '"+apellido_txt.Text+"', '"+cedula_txt.Text+"', '"+fecha_nacimiento.Value+"', '"+fecha_registro.Value+"', '"+antecedentes_txt.Text+"',"+getDolor()+", '"+getMarcha()+"', '"+muscular_txt.SelectedItem+"', '"+neurologicas_txt.SelectedItem+"', '"+articular_txt.Text+"', '"+discapacidad_txt.Text+"', '"+impresion_diagnostica.Text+"')";
            SqlCommand sql = new SqlCommand(cadena, conn);
            sql.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Correctamente");
            this.Close();
            historiaClinica historiaClinica = new historiaClinica();
            historiaClinica.Show();
        }
        private string getDolor()
        {
            string dolor="";
            if (rd1.Checked) dolor = "0";
            if (rd2.Checked) dolor = "25";
            if (rd3.Checked) dolor = "50";
            if (rd4.Checked) dolor = "75";
            if (rd5.Checked) dolor = "100";

            return dolor;
        }
        private string getMarcha()
        {
            string marcha = "";
            if (rm1.Checked) marcha = "No anda/No carga";
            if (rm2.Checked) marcha = "Anda con ayuda parcial";
            if (rm3.Checked) marcha = "Anda sin Ayuda";
            return marcha;
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
