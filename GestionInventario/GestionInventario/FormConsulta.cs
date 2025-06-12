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
    public partial class FormConsulta : Form
    {

        private static FormConsulta instancia = null;
        public static FormConsulta ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormConsulta();
                return instancia;
            }
            return instancia;
        }
        public FormConsulta()
        {
            InitializeComponent();
        }
    }
}
