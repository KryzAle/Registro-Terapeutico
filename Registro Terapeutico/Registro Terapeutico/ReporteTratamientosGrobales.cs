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
    public partial class ReporteTratamientosGrobales : Form
    {
        public ReporteTratamientosGrobales()
        {
            InitializeComponent();
        }

        private void ReporteTratamientosGrobales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TerapiasGlobales.Terapia' Puede moverla o quitarla según sea necesario.
            this.TerapiaTableAdapter.terapiasGlobales(this.TerapiasGlobales.Terapia);

            this.reportViewer1.RefreshReport();
        }
    }
}
