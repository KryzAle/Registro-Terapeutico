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
            //se inicia la conexion con la base de datos HogarAncianos.mdf
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
        //funcion para validar los combobox de muscular y neurologica
        private bool validar()
        {
            //valida los combobox y retorna verdadero cuando ha seleccionado datos.
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
        //funcion llamada al momento de dar click en registrar
        private void Registro_btn_Click(object sender, EventArgs e)
        {
            //valida los combobox
            if (validar())
            {
                //valida si se va a editar o guardar por primera vez
                if (!editar)
                {
                    //declara la cadena para insertar dentro de paciente
                    string cadena = "insert into Paciente(nombre_pac, apellido_pac, cedula_pac, fecha_nacimiento_pac, fecha_registro_pac, antecedentes_pac, dolor_pac, marcha_pac, muscular_pac, neurologica_pac, articular_pac, discapacidad_pac, impresion_diagnostica_pac) values('" + nombre_txt.Text + " " + "', '" + apellido_txt.Text + "', '" + cedula_txt.Text + "', '" + fecha_nacimiento.Value.Date.ToString("yyyy-MM-dd") + "', '" + fecha_registro.Value.Date.ToString("yyyy-MM-dd") + "', '" + antecedentes_txt.Text + "'," + getDolor() + ", '" + getMarcha() + "', '" + muscular_txt.SelectedItem + "', '" + neurologicas_txt.SelectedItem + "', '" + articular_txt.Text + "', '" + discapacidad_txt.Text + "', '" + impresion_diagnostica.Text + "')";
                    //declara la consulta SQL y la ejecuta
                    SqlCommand sql = new SqlCommand(cadena, conn);
                    sql.ExecuteNonQuery();

                }
                else
                {
                    //declara la cadena para actualizar el paciente
                    string cadena = "update Paciente set nombre_pac = '" + nombre_txt.Text + "', apellido_pac ='" + apellido_txt.Text + "', cedula_pac ='" + cedula_txt.Text + "', fecha_nacimiento_pac ='" + fecha_nacimiento.Value.Date.ToString("yyyy-MM-dd") + "', fecha_registro_pac ='" + fecha_registro.Value.Date.ToString("yyyy-MM-dd") + "', antecedentes_pac ='" + antecedentes_txt.Text + "', dolor_pac ='" + getDolor() + "', marcha_pac ='" + getMarcha() + "', muscular_pac ='" + muscular_txt.SelectedItem + "', neurologica_pac ='" + neurologicas_txt.SelectedItem + "', articular_pac ='" + articular_txt.Text + "', discapacidad_pac ='" + discapacidad_txt.Text + "', impresion_diagnostica_pac ='" + impresion_diagnostica.Text + "' Where codigo_pac = " + idPaciente;
                    //declara la consulta SQL y la ejecuta
                    SqlCommand sql = new SqlCommand(cadena, conn);
                    sql.ExecuteNonQuery();
                    //cambia la varible editar a falso y el id de paciente en 0;
                    editar = false;
                    idPaciente = "0";
                }
                //muestra un mensaje para agregar preferencias al paciente
                MessageBox.Show("Registro Guardado Correctamente");
                DialogResult res = MessageBox.Show("Desea Agregar las Preferencias Ahora ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //si se respondio a si agregar preferencias se lanza el formulario de preferencias caso contrario vuelve a lanzar historiaClinica
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
        //funcion que retorna el valor seleccionado en los radiobutton de dolor
        private string getDolor()
        {
            //asignar el valor del radiobutton seleccionado a una variable string y la devuelve
            string dolor="";
            if (rd1.Checked) dolor = "0";
            if (rd2.Checked) dolor = "25";
            if (rd3.Checked) dolor = "50";
            if (rd4.Checked) dolor = "75";
            if (rd5.Checked) dolor = "100";

            return dolor;
        }
        //funcion que asigna el check al dolor obtenido para editar un paciente
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
        //funciona para obtener el valor de la marcha
        private string getMarcha()
        {
            //asignar el valor del radiobutton seleccionado a una variable string y la devuelve
            string marcha = "";
            if (rm1.Checked) marcha = "No anda/No carga";
            if (rm2.Checked) marcha = "Anda con ayuda parcial";
            if (rm3.Checked) marcha = "Anda sin Ayuda";
            return marcha;
        }
        //funcion que asigna el check a la marcha obtenidoa para editar un paciente
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

        //funcion que cierra el formulario al momento de dar click en el boton cancelar
        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoriaClinica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hogarAncianosDataSet3.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.hogarAncianosDataSet3.Paciente);

        }
        //funcion llamada al dar click en el boton modificar carga todos los datos del paciente en el formulario
        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            //valida que se haya seleccionado una fila de la tabla de pacientes
            if (dataGridView1.SelectedRows.Count>0)
            {
                //cambia el valor de editar a verdadero para actualizar el registro de paciente
                editar = true;
                //asigna a los campos de textos los valores del paciente seleccionado
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

        //funcion llamada al dar click en el boton eliminar elimina el paciente
        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            //valida que se haya seleccionado una fila de la tabla de pacientes
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //obtiene el id del paciente seleccionado
                idPaciente = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                //declara una cadena de para eliminar los registros terapeuticos del paciente
                string cadena = "delete from Registro_Terapeutico Where codigo_pac = " + idPaciente;
                //ejecuta el comando Sql
                SqlCommand sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();
                //declara una cadena de para eliminar las preferencias del paciente
                cadena = "delete from Preferencia Where codigo_pac = " + idPaciente;
                //ejecuta el comando Sql
                sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();

                //declara una cadena de para eliminar los datos del paciente
                cadena = "delete from Paciente Where codigo_pac = " + idPaciente;
                //ejecuta el comando Sql
                sql = new SqlCommand(cadena, conn);
                sql.ExecuteNonQuery();
                //vuelve a lanzar el formulario de Historia Clinica
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
