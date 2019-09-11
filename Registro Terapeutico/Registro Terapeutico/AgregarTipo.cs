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
    public partial class AgregarTipo : Form
    {
        public AgregarTipo()
        {
            InitializeComponent();
        }

        private void Tipo_TerapiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipo_TerapiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tipoTerapias);

        }

        private void AgregarTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tipoTerapias.Tipo_Terapia' Puede moverla o quitarla según sea necesario.
            this.tipo_TerapiaTableAdapter.Fill(this.tipoTerapias.Tipo_Terapia);

        }

        private void Nombre_tipLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_tipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarTipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Registro_Terapia registroTer = new Registro_Terapia();
            registroTer.Show();
        }
    }
}
