using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Terapeutico
{
    public partial class menu : Form
    {
        //creamos una varible llamada padre2 donde se va a almacenar el formulario Form1 para acceder al usuarioId
        FormLogin padre2 = new FormLogin();
        public menu()
        {
            InitializeComponent();
        }
        //constructor creado para recibir la pantalla de login como parametro
        public menu(FormLogin padre)
        {
            //inicia el componente y se almacena en la varible 
            InitializeComponent();
            padre2 = padre;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        //funcion llamada al momento de dar click en Registro Terapeutico
        private void Button1_Click(object sender, EventArgs e)
        {
            // instancia al formulario de RegistroTerapeutico
            registroTerapeutico registro = new registroTerapeutico();
            registro.Show();
        }
        //funcion llamada al momento de dar click en Historia Clinica

        private void Historia_btn_Click(object sender, EventArgs e)
        {
            // instancia al formulario de HistoriaClinica
            historiaClinica historia = new historiaClinica();
            historia.Show();
        }
        //funcion llamada al momento de dar click en Terapia

        private void Terapia_btn_Click(object sender, EventArgs e)
        {
            // instancia al formulario de Registro_Terapia
            Registro_Terapia registro_Terapia = new Registro_Terapia();
            registro_Terapia.Show();
        }
        //funcion llamada al momento de dar click en Usuario

        private void Usuario_btn_Click(object sender, EventArgs e)
        {
            // instancia al formulario de Registro_Usuario
            Registro_Usuario registro_Usuario = new Registro_Usuario();
            registro_Usuario.Show();
        }
        //funcion llamada al momento de dar click en Reportes

        private void Reporte_btn_Click(object sender, EventArgs e)
        {
            // instancia al formulario de menuReportes
            menuReportes menuReportes = new menuReportes();
            menuReportes.Show();
        }
        //funcion llamada al momento de dar click en Preferencia Paciente

        private void Preferencias_btn_Click(object sender, EventArgs e)
        {
            // instancia al formulario de preferencias

            preferencias preferencias = new preferencias();
            preferencias.Show();
        }
        //funcion llamada al momento cerrar la aplicacion

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se muestra un mensaje si desea salir o no. En caso de la respuesta ser SI cierra la instancia del form1 caso contrario no hace nada.
            DialogResult res = MessageBox.Show("Desea Salir ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                padre2.Close();
            }
            else if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
