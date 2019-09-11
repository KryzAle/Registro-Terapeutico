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
    public partial class Registro_Terapia : Form
    {
        SqlConnection conn;
        
        public Registro_Terapia()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
        }

        private void Registro_Terapia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hogarAncianosDataSet.Tipo_Terapia' Puede moverla o quitarla según sea necesario.
            this.tipo_TerapiaTableAdapter.Fill(this.hogarAncianosDataSet.Tipo_Terapia);

        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_btn_Click(object sender, EventArgs e)
        {
            if (tipo_cmb.SelectedIndex!=0)
            {
                string cadena = "insert into Terapia(nombre_ter, codigo_tip,sensor) values('" + nombre_txt.Text + "'," + tipo_cmb.SelectedValue + ","+sensor_txt.SelectedIndex.ToString()+")";
                SqlCommand sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado Correctamente");
                this.Close();
                Registro_Terapia registro_Terapia = new Registro_Terapia();
                registro_Terapia.Show();
            }
            else
            {
                MessageBox.Show("Seleccione Tipo de Terapia");
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AgregarTipo tipoter = new AgregarTipo();
            this.Close();
            tipoter.Show();
        }
    }
}
