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
    public partial class FormIngresomtto : Form
    {
        private static FormIngresomtto instancia = null;
        public static FormIngresomtto ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormIngresomtto();
                return instancia;
            }
            return instancia;
        }
        public FormIngresomtto()
        {
            InitializeComponent();
        }

        private void lblFechaRegistro_Click(object sender, EventArgs e)
        {

        }

        private void FormIngresomtto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
