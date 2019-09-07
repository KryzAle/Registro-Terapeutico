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
        public registroTerapeutico()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
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

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Registro_btn_Click(object sender, EventArgs e)
        {
            string cadena = "insert into Registro_Terapeutico(fecha_reg,repeticiones_reg,observaciones_reg,codigo_pac,codigo_usu,codigo_ter) values('" + fecha_txt.Value + "'," +numero_repeticion_txt.Text + ", '" + Observaciones_txt.Text + "'," + paciente_cmb.SelectedValue.ToString() + "," + FormLogin.usuarioId + "," + terapia_cmb.SelectedValue.ToString() +")";
           
            SqlCommand sql = new SqlCommand(cadena, conn);
            sql.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Correctamente");
            conn.Close();
            this.Close();
            registroTerapeutico registroTerapeutico = new registroTerapeutico();
            registroTerapeutico.Show();
            
        }
        private void CargarDatosPaciente()
        {
            string cadena = "Select codigo_pac,apellido_pac+nombre_pac as NombreCompleto from Paciente";
            SqlCommand sql = new SqlCommand(cadena, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow fila = dt.NewRow();
            fila["NombreCompleto"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            paciente_cmb.ValueMember = "codigo_pac";
            paciente_cmb.DisplayMember = "NombreCompleto";
            paciente_cmb.DataSource = dt;
        }
        private void cargarDatosTipoTerapia()
        {
            string cadena = "Select codigo_tip,nombre_tip from Tipo_Terapia";
            SqlCommand sql = new SqlCommand(cadena, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow fila = dt.NewRow();
            fila["nombre_tip"] = "Seleccione";
            
            dt.Rows.InsertAt(fila, 0);
            tipo_cmb.ValueMember = "codigo_tip";
            tipo_cmb.DisplayMember = "nombre_tip";
            tipo_cmb.DataSource = dt;
        }
        private void cargarDatosTerapia(string codigo_tip)
        {
            string cadena = "Select codigo_ter,nombre_ter from Terapia Where codigo_tip="+codigo_tip;
            SqlCommand sql = new SqlCommand(cadena, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow fila = dt.NewRow();
            fila["nombre_ter"] = "Seleccione";
            dt.Rows.InsertAt(fila, 0);
            terapia_cmb.ValueMember = "codigo_ter";
            terapia_cmb.DisplayMember = "nombre_ter";
            terapia_cmb.DataSource = dt;
        }


        private void Paciente_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Tipo_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
          string valor = tipo_cmb.SelectedValue.ToString();
            if (!valor.Equals(""))
            {
                cargarDatosTerapia(valor);
            }
            
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empezar_btn_Click(object sender, EventArgs e)
        {
            string cadena = "Select nombre_pre,rutaVideo_pre from Preferencia Where codigo_pac=" + paciente_cmb.SelectedValue.ToString();
            SqlCommand sql = new SqlCommand(cadena, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                seleccionarPreferencia seleccionar = new seleccionarPreferencia(dt);
                seleccionar.Show();
            }
            else
            {
                cadena = "Select nombre_pre,rutaVideo_pre from Preferencia";
                sql = new SqlCommand(cadena, conn);
                adapter = new SqlDataAdapter(sql);
                dt = new DataTable();
                adapter.Fill(dt);
                Random random = new Random();
                int rnd = random.Next(dt.Rows.Count);
                DataRow dr = dt.Rows[rnd];
                string ruta = dr["rutaVideo_pre"].ToString();
                Video video = new Video(ruta);
                
                video.Show();
            }

            
        }
    }
}
