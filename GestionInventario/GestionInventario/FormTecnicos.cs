using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class FormTecnicos : Form
    {
        public FormTecnicos()
        {
            InitializeComponent();
        }

        private void tecnicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tecnicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tecnicosDS);

        }

        private void FormTecnicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tecnicosDS.Tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter.Fill(this.tecnicosDS.Tecnicos);

        }
    }
}
