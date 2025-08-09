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
    public partial class FormActivos : Form
    {


        private static FormActivos instancia = null;

        public FormRegistro FormRegistroReferencia { get; set; }
        public static FormActivos ventana_unica(FormRegistro referenciaRegistro)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormActivos();
                instancia.FormRegistroReferencia = referenciaRegistro;
            }
            return instancia;
        }

        public FormActivos()
        {
            InitializeComponent();
        }

    

        private void activosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosDS);

            FormRegistroReferencia?.RecargarDatos();
        }

        private void FormActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'activosDS.Activos' Puede moverla o quitarla según sea necesario.
            this.activosTableAdapter.Fill(this.activosDS.Activos);

        }
    }
}
