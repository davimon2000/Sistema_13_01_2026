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
    public partial class FormEstado : Form
    {
        private static FormEstado instancia = null;
        public static FormEstado ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormEstado();
                return instancia;
            }
            return instancia;
        }
        public FormEstado()
        {
            InitializeComponent();
        }
    }
}
