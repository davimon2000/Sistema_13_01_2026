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
        private static FormTecnicos instancia = null;
        public static FormTecnicos ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormTecnicos();
                return instancia;
            }
            return instancia;
        }


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

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void tecnicosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
