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
        FormLogin padre2 = new FormLogin();
        public menu()
        {
            InitializeComponent();
        }
        public menu(FormLogin padre)
        {
            InitializeComponent();
            padre2 = padre;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            registroTerapeutico registro = new registroTerapeutico();
            registro.Show();
        }

        private void Historia_btn_Click(object sender, EventArgs e)
        {
            historiaClinica historia = new historiaClinica();
            historia.Show();
        }

        private void Terapia_btn_Click(object sender, EventArgs e)
        {
            Registro_Terapia registro_Terapia = new Registro_Terapia();
            registro_Terapia.Show();
        }

        private void Usuario_btn_Click(object sender, EventArgs e)
        {
            Registro_Usuario registro_Usuario = new Registro_Usuario();
            registro_Usuario.Show();
        }

        private void Reporte_btn_Click(object sender, EventArgs e)
        {
            menuReportes menuReportes = new menuReportes();
            menuReportes.Show();
        }

        private void Preferencias_btn_Click(object sender, EventArgs e)
        {
            preferencias preferencias = new preferencias();
            preferencias.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
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
