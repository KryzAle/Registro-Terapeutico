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
    public partial class Registro_Usuario : Form
    {
        SqlConnection conn;
        public Registro_Usuario()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
        }

        private void Registro_btn_Click(object sender, EventArgs e)
        {
            string cadena = "insert into Usuario(nombre_usu, apellido_usu, user_usu, password_usu) values('" + nombre_txt.Text + "', '" + apellido_txt.Text + "', '" + usuario_txt.Text + "', '" + pass_txt.Text + "')";
            SqlCommand sql = new SqlCommand(cadena, conn);
            sql.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Correctamente");
            this.Close();
            Registro_Usuario registro_Usuario = new Registro_Usuario();
            registro_Usuario.Show();
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
