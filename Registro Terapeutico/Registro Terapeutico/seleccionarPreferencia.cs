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
    public partial class seleccionarPreferencia : Form
    {
        SqlConnection conn;
        string terapia;
        public seleccionarPreferencia()
        {
            InitializeComponent();
        }
        public seleccionarPreferencia(DataTable data)
        {
            InitializeComponent();
            cargarVideo(data);
        }
        public seleccionarPreferencia(DataTable data,string sensor)
        {
            InitializeComponent();
            cargarVideo(data);
            terapia = sensor;
        }
        private void cargarVideo(DataTable paciente)
        {
            DataRow fila = paciente.NewRow();
            fila["nombre_pre"] = "Seleccione";
            paciente.Rows.InsertAt(fila, 0);
            preferencia_cmb.ValueMember = "rutaVideo_pre";
            preferencia_cmb.DisplayMember = "nombre_pre";
            preferencia_cmb.DataSource = paciente;
        }
        private void Cancion_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Video video = new Video(preferencia_cmb.SelectedValue.ToString(),terapia);
            video.Show();
        }
    }
}
