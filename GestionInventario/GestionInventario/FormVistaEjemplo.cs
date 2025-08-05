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
    public partial class FormVistaEjemplo : Form
    {
        public FormVistaEjemplo()
        {
            InitializeComponent();
        }

        private void FormVistaEjemplo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marcasDS.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter2.Fill(this.marcasDS.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet2.Marcas' Puede moverla o quitarla según sea necesario.
            //this.marcasTableAdapter1.Fill(this.inventarioActivosDataSet2.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            //this.marcasTableAdapter.Fill(this.inventarioActivosDataSet.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'registroActivosDS.RegistroActivos' Puede moverla o quitarla según sea necesario.
            this.registroActivosTableAdapter.Fill(this.registroActivosDS.RegistroActivos);
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.RegistroActivos' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'activosViewDS.ActivosView' Puede moverla o quitarla según sea necesario.
            //this.activosViewTableAdapter.Fill(this.activosViewDS.ActivosView);

        }

        private void registroActivosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registroActivosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registroActivosDS);

        }
    }
}
