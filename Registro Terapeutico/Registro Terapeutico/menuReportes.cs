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
    public partial class menuReportes : Form
    {
        public menuReportes()
        {
            InitializeComponent();
        }

        private void Terapia_realizada_btn_Click(object sender, EventArgs e)
        {
            Terapias_por_Fecha terapias_Por_Fecha = new Terapias_por_Fecha();
            terapias_Por_Fecha.Show();
        }

        private void Terapia_paciente_btn_Click(object sender, EventArgs e)
        {
            Reporte_Diagnostico_Paciente reporte_Diagnostico_Paciente = new Reporte_Diagnostico_Paciente();
            reporte_Diagnostico_Paciente.Show();
        }

        private void Historia_clinica_btn_Click(object sender, EventArgs e)
        {
            Historia_Clinica historia_Clinica = new Historia_Clinica();
            historia_Clinica.Show();
        }

        private void Preferencia_paciente_btn_Click(object sender, EventArgs e)
        {
            Reporte_Preferencias reporte_Preferencias = new Reporte_Preferencias();
            reporte_Preferencias.Show();

        }
    }
}
