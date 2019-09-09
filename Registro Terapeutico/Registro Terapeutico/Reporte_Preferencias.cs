using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Terapeutico
{
    
    public partial class Reporte_Preferencias : Form
    {
        SqlConnection conn;
        public Reporte_Preferencias()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
            CargarDatosPaciente();
        }

        private void Reporte_Preferencias_Load(object sender, EventArgs e)
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

        private void Nuevo_btn_Click(object sender, EventArgs e)
        {
            this.PreferenciaTableAdapter.preferenciasPaciente(this.Preferencias.Preferencia, Int32.Parse(paciente_cmb.SelectedValue.ToString()));

            this.reportViewer1.RefreshReport();
        }
    }
}
