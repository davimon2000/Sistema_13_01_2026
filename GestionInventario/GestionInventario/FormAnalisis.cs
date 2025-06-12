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
    public partial class FormAnalisis : Form
    {

        private static FormAnalisis instancia = null;
        public static FormAnalisis ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormAnalisis();
                return instancia;
            }
            return instancia;
        }
        public FormAnalisis()
        {
            InitializeComponent();
        }
    }
}
