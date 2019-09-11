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
    public partial class historiaClinica : Form
    {
        private string idPaciente;
        private bool editar = false;
        SqlConnection conn;
        public historiaClinica()
        {
            InitializeComponent();
            conn = new SqlConnection(Properties.Settings.Default.Conexion);
            conn.Open();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }
        private bool validar()
        {
            if (muscular_txt.SelectedIndex != 0)
            {
                if (neurologicas_txt.SelectedIndex != 0)
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("Seleccione Neurologica");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Muscular");
            }
            return false;

        }
        private void Registro_btn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (!editar)
                {
                    string cadena = "insert into Paciente(nombre_pac, apellido_pac, cedula_pac, fecha_nacimiento_pac, fecha_registro_pac, antecedentes_pac, dolor_pac, marcha_pac, muscular_pac, neurologica_pac, articular_pac, discapacidad_pac, impresion_diagnostica_pac) values('" + nombre_txt.Text + " " + "', '" + apellido_txt.Text + "', '" + cedula_txt.Text + "', '" + fecha_nacimiento.Value + "', '" + fecha_registro.Value + "', '" + antecedentes_txt.Text + "'," + getDolor() + ", '" + getMarcha() + "', '" + muscular_txt.SelectedItem + "', '" + neurologicas_txt.SelectedItem + "', '" + articular_txt.Text + "', '" + discapacidad_txt.Text + "', '" + impresion_diagnostica.Text + "')";
                    SqlCommand sql = new SqlCommand(cadena, conn);
                    sql.ExecuteNonQuery();

                }
                else
                {
                    string cadena = "update Paciente set nombre_pac = '" + nombre_txt.Text + "', apellido_pac ='" + apellido_txt.Text + "', cedula_pac ='" + cedula_txt.Text + "', fecha_nacimiento_pac ='" + fecha_nacimiento.Value + "', fecha_registro_pac ='" + fecha_registro.Value + "', antecedentes_pac ='" + antecedentes_txt.Text + "', dolor_pac ='" + getDolor() + "', marcha_pac ='" + getMarcha() + "', muscular_pac ='" + muscular_txt.SelectedItem + "', neurologica_pac ='" + neurologicas_txt.SelectedItem + "', articular_pac ='" + articular_txt.Text + "', discapacidad_pac ='" + discapacidad_txt.Text + "', impresion_diagnostica_pac ='" + impresion_diagnostica.Text + "' Where codigo_pac = " + idPaciente;
                    SqlCommand sql = new SqlCommand(cadena, conn);
                    sql.ExecuteNonQuery();
                    editar = false;
                    idPaciente = "0";
                }
                MessageBox.Show("Registro Guardado Correctamente");
                DialogResult res = MessageBox.Show("Desea Agregar las Preferencias Ahora ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                    preferencias preferencias = new preferencias();
                    preferencias.Show();
                }
                else if (res == DialogResult.No)
                {
                    this.Close();
                    historiaClinica historiaClinica = new historiaClinica();
                    historiaClinica.Show();
                }
            }
        }
        private string getDolor()
        {
            string dolor="";
            if (rd1.Checked) dolor = "0";
            if (rd2.Checked) dolor = "25";
            if (rd3.Checked) dolor = "50";
            if (rd4.Checked) dolor = "75";
            if (rd5.Checked) dolor = "100";

            return dolor;
        }
        private void setDolor(string dolorS)
        {
            switch (dolorS)
            {
                case "0":
                    rd1.Checked = true;
                    break;
                case "25":
                    rd2.Checked = true;
                    break;
                case "50":
                    rd3.Checked = true;
                    break;
                case "75":
                    rd4.Checked = true;
                    break;
                case "100":
                    rd5.Checked = true;
                    break;
                default:
                    break;
            }
        }
        private string getMarcha()
        {
            string marcha = "";
            if (rm1.Checked) marcha = "No anda/No carga";
            if (rm2.Checked) marcha = "Anda con ayuda parcial";
            if (rm3.Checked) marcha = "Anda sin Ayuda";
            return marcha;
        }
        private void setMarcha(string marchaS)
        {
            switch (marchaS)
            {
                case "No anda/No carga":
                    rm1.Checked = true;
                    break;
                case "Anda con ayuda parcial":
                    rm2.Checked = true;
                    break;
                case "Anda sin Ayuda":
                    rm3.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoriaClinica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hogarAncianosDataSet3.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.hogarAncianosDataSet3.Paciente);

        }

        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                editar = true;
                idPaciente = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                nombre_txt.Text= dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                apellido_txt.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                cedula_txt.Text = dataGridView1.CurrentRow.Cells["cedula"].Value.ToString();
                DateTime fechaN = DateTime.Parse(dataGridView1.CurrentRow.Cells["fechanacimiento"].Value.ToString());
                fecha_nacimiento.Value = fechaN;
                DateTime fechaR = DateTime.Parse(dataGridView1.CurrentRow.Cells["fecharegistro"].Value.ToString());
                fecha_nacimiento.Value = fechaR;
                antecedentes_txt.Text = dataGridView1.CurrentRow.Cells["antecedentes"].Value.ToString();
                impresion_diagnostica.Text = dataGridView1.CurrentRow.Cells["impresiondiagnostica"].Value.ToString();
                setDolor(dataGridView1.CurrentRow.Cells["dolor"].Value.ToString());
                setMarcha(dataGridView1.CurrentRow.Cells["marcha"].Value.ToString());
                articular_txt.Text = dataGridView1.CurrentRow.Cells["articular"].Value.ToString();
                discapacidad_txt.Text = dataGridView1.CurrentRow.Cells["discapacidad"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idPaciente = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                string cadena = "delete from Registro_Terapeutico Where codigo_pac = " + idPaciente;
                SqlCommand sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();

                cadena = "delete from Preferencia Where codigo_pac = " + idPaciente;
                sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();

                cadena = "delete from Paciente Where codigo_pac = " + idPaciente;
                sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();

                MessageBox.Show("Borrado Correctamente");
                this.Close();
                historiaClinica historiaClinica = new historiaClinica();
                historiaClinica.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacienteTableAdapter.Fill(this.hogarAncianosDataSet3.Paciente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacienteTableAdapter.Fill(this.hogarAncianosDataSet3.Paciente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacienteTableAdapter.Fill(this.hogarAncianosDataSet3.Paciente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
