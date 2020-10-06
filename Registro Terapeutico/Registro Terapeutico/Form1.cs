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
            //Conexion con la base de datos local HogarAncianos.mdf  la cadena de conexion esta en properties
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //funcion que valida el login dentro de la aplicacion
        private bool Validar_Usuario(string user, string pass)
        {
            //abre conexion con la base de datos local
            conn.Open();
            //se declara un string con la consulta sql
            string cadena = "select * from Usuario Where user_usu = '" + user + "' and password_usu = '" + pass + "'";
            //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
            SqlCommand sql = new SqlCommand(cadena, conn);
            //SqlDataReader almacena los datos obtenidos al ejecutar la consulta SQLCommand con .ExecuteReader()
            SqlDataReader reader = sql.ExecuteReader();
            bool validar = false;
            //reader.Read() valida si existe registros. Si existen datos = true, caso contrario false
            if (reader.Read())
            {
                //cambiamos a true la variable validar que indica que el usuario se a logeado
                validar = true;
                //almacenamos en la variable usuarioId el codigo de usuario de manera global para poder obtener desde cualquier otro Formulario
                usuarioId = reader["codigo_usu"].ToString();
            }
            //cerramos la conexion con la base de datos y retornamos la variable validar que indica si se logeo o no el usuario
            conn.Close();
            return validar;
        }
        //funcion que se ejecuta al dar click en la imagen de salida
        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //funcion que se ejecuta al momento de dar click en Ingresar
        private void Button1_Click(object sender, EventArgs e)
        {
            //crea una variable booleana llamada valida para controlar el login
            bool valida;
            //llama a la funcion Validar_Usuario mandando los datos de usuario y contraseña. Almacena el retorno en la variable valida
            valida=Validar_Usuario(user_txt.Text,pass_txt.Text);
            if (valida)
            {
                //si la valida es verdadero llama al formulario menu y esconde el Form1
                MessageBox.Show("Ingreso Correcto");
                menu menu = new menu(this);
                menu.Show();
                this.Hide();
                
            }
            else
            {
                //si la valida es falso borrar de la caja de texto el usuario y contraseña
                MessageBox.Show("Datos Incorrectos");
                BorrarDatos();
            }
        }
        //funcion cuando el formulario se cierra
        private void form_Closing()
        {
            //cierra el programa
            this.Close();

        }
        //funcion para establecer el valor de las cajas de texto como vacias.
        private void BorrarDatos()
        {
            user_txt.Text="";
            pass_txt.Text = "";
        }
    }
}
