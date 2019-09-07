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
    public partial class preferencias : Form
    {
        SqlConnection conn;
        private string ruta="";
        public preferencias()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
            CargarDatosPaciente();
        }

        private void Preferencias_Load(object sender, EventArgs e)
        {

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

        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
            }
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            if (!ruta.Equals(""))
            {
                string cadena = "insert into Preferencia(nombre_pre,rutaVideo_pre,codigo_pac) values('" + nombre_txt.Text + "','" + ruta + "'," + paciente_cmb.SelectedValue.ToString() + ")";
                MessageBox.Show(cadena);
                SqlCommand sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado Correctamente");
                this.Close();
                registroTerapeutico registroTerapeutico = new registroTerapeutico();
                registroTerapeutico.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna archivo");
            }
            
        }
    }
}
