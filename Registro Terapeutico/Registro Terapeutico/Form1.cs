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
    public partial class FormLogin : Form
    {
        public static string usuarioId;
        SqlConnection conn;
        public FormLogin()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private bool Validar_Usuario(string user, string pass)
        {
            conn.Open();
            string cadena = "select * from Usuario Where user_usu = '" + user + "' and password_usu = '" + pass + "'";
            SqlCommand sql = new SqlCommand(cadena, conn);
            SqlDataReader reader = sql.ExecuteReader();
            bool validar = false;
            if (reader.Read())
            {
                validar = true;
                usuarioId = reader["codigo_usu"].ToString();
            }

            conn.Close();
            return validar;
        }
        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool valida;
            valida=Validar_Usuario(user_txt.Text,pass_txt.Text);
            if (valida)
            {
                MessageBox.Show("Ingreso Correcto Logeando........");
                menu menu = new menu();
                menu.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
                BorrarDatos();
            }
        }
        private void BorrarDatos()
        {
            user_txt.Text="";
            pass_txt.Text = "";
        }
    }
}
