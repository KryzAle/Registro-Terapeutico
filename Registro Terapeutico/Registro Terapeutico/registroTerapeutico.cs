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
    public partial class registroTerapeutico : Form
    {
        SqlConnection conn;
        //constructor inicial del Formulario
        public registroTerapeutico()
        {
            //se instancia la variable conn con la conexion a la base de datos local HogarAncianos.mdf  la cadena de conexion esta en properties
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            //se abre la conexion
            conn.Open();
            //llamamos a la funcion para cargar datos de Paciente y Tipo de Terapia
            CargarDatosPaciente();
            cargarDatosTipoTerapia();
            
        }

        private void RegistroTerapeutico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hogarAncianosDataSet2.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter1.Fill(this.hogarAncianosDataSet2.Paciente);
            // TODO: esta línea de código carga datos en la tabla 'hogarAncianosDataSet1.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.hogarAncianosDataSet1.Paciente);

        }
        //funcion llamada al momento de cerrar el formulario
        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //funcion llamada al momento de dar click en Registrar
        private void Registro_btn_Click(object sender, EventArgs e)
        {
            validaryGuardar();            
        }
        //funcion para validar y guardar los datos de registro terapeutico
        private bool validaryGuardar()
        {
            //valida que se haya seleccionado un paciente, tipo de terapia, terapia ademas de que el numero de repeticiones sea diferente de vacio
            if (paciente_cmb.SelectedIndex != 0)
            {
                if (tipo_cmb.SelectedIndex != 0)
                {
                    if (terapia_cmb.SelectedIndex != 0)
                    {
                        if (!numero_repeticion_txt.Text.Equals(""))
                        {
                            //crea una variable string para declarar la funcion de Insertar SQL dentro de la tabla de Registro_Terapeutico
                            string cadena = "insert into Registro_Terapeutico(fecha_reg,repeticiones_reg,diagnostico_reg,observaciones_reg,codigo_pac,codigo_usu,codigo_ter) values('" + fecha_txt.Value.Date.ToString("yyyy-MM-dd") + "'," + numero_repeticion_txt.Text + ", '" + Diagnostico_txt.Text + "','" + Observaciones_txt.Text + "'," + paciente_cmb.SelectedValue.ToString() + "," + FormLogin.usuarioId + "," + terapia_cmb.SelectedValue.ToString() + ")";
                            //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
                            SqlCommand sql = new SqlCommand(cadena, conn);
                            //ejecuta la consulta de Insert
                            sql.ExecuteNonQuery();
                            //cierra la conexion,muestra un mensaje y vuelve a lanzar el formulario de registro terapeutico
                            MessageBox.Show("Registro Guardado Correctamente");
                            conn.Close();
                            this.Close();
                            registroTerapeutico registroTerapeutico = new registroTerapeutico();
                            registroTerapeutico.Show();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese repeticiones");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tratamiento");
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un tratamiento");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Paciente");
            }
            return false;

        }
        //funcion para cargar datos de Paciente
        private void CargarDatosPaciente()
        {
            //declara una varible llamada cadena de tipo string para crear la consulta SQL Select
            string cadena = "Select codigo_pac,apellido_pac+SPACE(1)+ nombre_pac as NombreCompleto from Paciente ORDER BY apellido_pac ASC";
            //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
            SqlCommand sql = new SqlCommand(cadena, conn);
            // SqlDataAdapter obtiene los datos de la consulta SQL SqlCommand como un DataSet para colocarlos dentro de una tabla o comboBox
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            //DataTable representa una tabla de datos
            DataTable dt = new DataTable();
            //actualiza el dataTable con el SqlDataAdapter
            adapter.Fill(dt);
            //creamos una fila de datos
            DataRow fila = dt.NewRow();
            //instanciamos en la fila de datos en nombreCompleto = seleccione
            fila["NombreCompleto"] = "Seleccione";
            //agregamos la fina en la Tabla de Datos dt en primer lugar
            dt.Rows.InsertAt(fila, 0);
            //declaramos al combobox de pacientes que el valor para el combo es codigo_pac y el display o label que va a mostrar es el NombreCompleto
            paciente_cmb.ValueMember = "codigo_pac";
            paciente_cmb.DisplayMember = "NombreCompleto";
            //declaramos que el origen de datos del combobox de pacientes va a ser la tabla de datos dt
            paciente_cmb.DataSource = dt;
        }
        //funcion para cargar datos de Tipo de Terapia

        private void cargarDatosTipoTerapia()
        {
            //declara una varible llamada cadena de tipo string para crear la consulta SQL Select
            string cadena = "Select codigo_tip,nombre_tip from Tipo_Terapia";
            //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
            SqlCommand sql = new SqlCommand(cadena, conn);
            // SqlDataAdapter obtiene los datos de la consulta SQL SqlCommand como un DataSet para colocarlos dentro de una tabla o comboBox
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            //DataTable representa una tabla de datos
            DataTable dt = new DataTable();
            //actualiza el dataTable con el SqlDataAdapter
            adapter.Fill(dt);
            //declaramos al combobox de tipo de terapia que el valor para el combo es codigo_tip y el display o label que va a mostrar es el nombre_tip
            tipo_cmb.ValueMember = "codigo_tip";
            tipo_cmb.DisplayMember = "nombre_tip";
            //declaramos que el origen de datos del combobox de tipo de terapia va a ser la tabla de datos dt
            tipo_cmb.DataSource = dt;
        }
        //funcion para cargar datos de Terapia
        private void cargarDatosTerapia(string codigo_tip)
        {
            //declara una varible llamada cadena de tipo string para crear la consulta SQL Select
            string cadena = "Select codigo_ter,nombre_ter from Terapia Where codigo_tip="+codigo_tip;
            //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
            SqlCommand sql = new SqlCommand(cadena, conn);
            // SqlDataAdapter obtiene los datos de la consulta SQL SqlCommand como un DataSet para colocarlos dentro de una tabla o comboBox
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            //DataTable representa una tabla de datos
            DataTable dt = new DataTable();
            //actualiza el dataTable con el SqlDataAdapter
            adapter.Fill(dt);
            //creamos una fila de datos
            DataRow fila = dt.NewRow();
            //instanciamos en la fila de datos en nombre_ter = Seleccione
            fila["nombre_ter"] = "Seleccione";
            //agregamos la fina en la Tabla de Datos dt en primer lugar
            dt.Rows.InsertAt(fila, 0);
            //declaramos al combobox de  terapia que el valor para el combo es codigo_tip y el display o label que va a mostrar es el nombre_tip
            terapia_cmb.ValueMember = "codigo_ter";
            terapia_cmb.DisplayMember = "nombre_ter";
            //declaramos que el origen de datos del combobox de terapia va a ser la tabla de datos dt
            terapia_cmb.DataSource = dt;
        }


        private void Paciente_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //funcion llamada al seleccionar un tipo de terapia del combobox
        private void Tipo_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //almacenamos el valor del objeto seleccionado en el combo como un string
          string valor = tipo_cmb.SelectedValue.ToString();
            //validamos que el valor no sea vacio
            if (!valor.Equals(""))
            {
                //cargamos los datos de terapia para ese tipo de terapia
                cargarDatosTerapia(valor);
            }
            
        }
        //funcion llamada al momento de dar click en cancelar
        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //funcion llamada al momento de dar click en el boton empezar terapia
        private void Empezar_btn_Click(object sender, EventArgs e)
        {
            if (validaryGuardar())
            {
                //Se carga Preferencias del paciente
                string cadena = "Select nombre_pre,rutaVideo_pre from Preferencia Where codigo_pac=" + paciente_cmb.SelectedValue.ToString();
                //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
                SqlCommand sql = new SqlCommand(cadena, conn);
                // SqlDataAdapter obtiene los datos de la consulta SQL SqlCommand como un DataSet para colocarlos dentro de una tabla o comboBox
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
            //DataTable representa una tabla de datos
                DataTable dt = new DataTable();
            //actualiza el dataTable con el SqlDataAdapter
                adapter.Fill(dt);
                //si existe preferencias manda a seleccionar o manda un video randomico
                if (dt.Rows.Count != 0)
                {
                    //crea una instancia de seleccionar preferencia y mandamos como parametro las preferencias y la terapia seleccionada
                    seleccionarPreferencia seleccionar = new seleccionarPreferencia(dt,terapia_cmb.SelectedValue.ToString());
                    seleccionar.Show();
                }
                else
                {
                    //busca todas las preferencias almacenadas
                    cadena = "Select nombre_pre,rutaVideo_pre from Preferencia";
                //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
                    sql = new SqlCommand(cadena, conn);
                // SqlDataAdapter obtiene los datos de la consulta SQL SqlCommand como un DataSet para colocarlos dentro de una tabla o comboBox
                    adapter = new SqlDataAdapter(sql);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    //creamos un numero randomico
                    Random random = new Random();
                    int rnd = random.Next(dt.Rows.Count);
                    //obtiene la fila randomica 
                    DataRow dr = dt.Rows[rnd];
                    //guarda la ruta del video dentro de una variable ruta
                    string ruta = dr["rutaVideo_pre"].ToString();
                    //lanza el formulario de video mandando como parametros la ruta del video, la terapia seleccionada
                    Video video = new Video(ruta, terapia_cmb.SelectedValue.ToString());
                    video.Show();
                }


            }


        }
        //funcion llamada al seleccionar una terapia del combobox
        private void Terapia_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validamos que se haya seleccionado un valor
            if (terapia_cmb.SelectedIndex!=0)
            {
                //creamos la cadena de consulta SQl
                string cadena = "Select sensor from Terapia where codigo_ter="+terapia_cmb.SelectedValue.ToString();
                //SQLCommand (consulta sql, conexion bd) crea una nueva instacion de consulta SQL
                SqlCommand sql = new SqlCommand(cadena, conn);
                // SqlDataAdapter obtiene los datos de la consulta SQL SqlCommand como un DataSet para colocarlos dentro de una tabla o comboBox
                SqlDataReader reader = sql.ExecuteReader();
                //valida que existan datos
                if (reader.Read())
                {
                    //valida que la terapia necesite un sensor si es asi activa el boton empezar terapia
                    if (reader["sensor"].ToString().Equals("1"))
                    {
                        empezar_btn.Enabled = true;
                    }
                    else
                    {
                        empezar_btn.Enabled = false;
                    }
                }
                reader.Close();

            }
        }
    }
}
