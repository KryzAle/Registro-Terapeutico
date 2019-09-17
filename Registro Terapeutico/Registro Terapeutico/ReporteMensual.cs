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
    public partial class ReporteMensual : Form
    {
        public ReporteMensual()
        {
            InitializeComponent();
        }

        private void ReporteMensual_Load(object sender, EventArgs e)
        {
            
        }

        private void Nuevo_btn_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'RegistroTerapias.Registro_Terapeutico' Puede moverla o quitarla según sea necesario.
            this.Registro_TerapeuticoTableAdapter.terapiasPorFechas(this.RegistroTerapias.Registro_Terapeutico,fecha_inicio.Value.Date.ToString("yyyy-MM-dd"), fecha_fin.Value.Date.ToString("yyyy-MM-dd"),Int32.Parse( FormLogin.usuarioId));
            
            this.reportViewer1.RefreshReport();
        }
    }
}
