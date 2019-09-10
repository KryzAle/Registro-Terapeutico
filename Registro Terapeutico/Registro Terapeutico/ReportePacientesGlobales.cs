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
    public partial class ReportePacientesGlobales : Form
    {
        public ReportePacientesGlobales()
        {
            InitializeComponent();
        }

        private void ReportePacientesGlobales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PacientesGlobales.Paciente' Puede moverla o quitarla según sea necesario.
            this.PacienteTableAdapter.pacientesGlobales(this.PacientesGlobales.Paciente);
            this.reportViewer1.RefreshReport();
        }
    }
}
