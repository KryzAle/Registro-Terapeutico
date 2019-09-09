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
    public partial class Terapias_por_Fecha : Form
    {
        public Terapias_por_Fecha()
        {
            InitializeComponent();
        }

        private void Nuevo_btn_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteTratamiento.Registro_Terapeutico' Puede moverla o quitarla según sea necesario.
            this.Registro_TerapeuticoTableAdapter.terapiaPorFechas(this.ReporteTratamiento.Registro_Terapeutico,fechaInicio_txt.Value.ToString(), fechaFin_Txt.Value.ToString());

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void Terapias_por_Fecha_Load(object sender, EventArgs e)
        {
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
