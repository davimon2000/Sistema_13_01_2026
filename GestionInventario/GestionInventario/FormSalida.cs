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
    public partial class FormSalida : Form
    {

        private static FormSalida instancia = null;
        public static FormSalida ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormSalida();
                return instancia;
            }
            return instancia;
        }
        public FormSalida()
        {
            InitializeComponent();
        }

        private void cmbAreaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
