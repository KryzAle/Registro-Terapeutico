using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Registro_Terapeutico
{
    public partial class preferencias : Form
    {
        private string idPreferencia = "";
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
            string cadena = "Select codigo_pac,apellido_pac+SPACE(1)+ nombre_pac as NombreCompleto from Paciente";
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
        private void cargarTabla(string codigo_pac)
        {
            string cadena = "Select codigo_pre as codigo,nombre_pre as Preferencia, rutaVideo_pre as Ruta from Preferencia Where codigo_pac=" + codigo_pac;
            SqlCommand sql = new SqlCommand(cadena, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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
            if (paciente_cmb.SelectedIndex != 0)
            {
                if (!ruta.Equals(""))
                            {
                                string cadena = "insert into Preferencia(nombre_pre,rutaVideo_pre,codigo_pac) values('" + nombre_txt.Text + "','" + ruta + "'," + paciente_cmb.SelectedValue.ToString() +")";
                                SqlCommand sql = new SqlCommand(cadena, conn);
                                sql.ExecuteNonQuery();
                                MessageBox.Show("Registro Guardado Correctamente");
                                nombre_txt.Text = "";
                    cargarTabla(paciente_cmb.SelectedValue.ToString());
                            }
                            else
                            {
                                MessageBox.Show("No ha seleccionado ninguna archivo");
                            }
            }
            else
            {
                MessageBox.Show("Seleccione un Paciente");
            }
            
            
        }

        private void Paciente_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = paciente_cmb.SelectedValue.ToString();
            if (paciente_cmb.SelectedIndex!=0)
            {
                cargarTabla(valor);
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                idPreferencia = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                string cadena = "delete from Preferencia Where codigo_pre = " + idPreferencia;
                SqlCommand sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Borrado Correctamente");
                this.Close();
                preferencias preferencias = new preferencias();
                preferencias.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
