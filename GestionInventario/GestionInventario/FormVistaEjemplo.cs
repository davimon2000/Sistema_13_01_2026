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
            // TODO: esta línea de código carga datos en la tabla 'activosViewDS.ActivosView' Puede moverla o quitarla según sea necesario.
            //this.activosViewTableAdapter.Fill(this.activosViewDS.ActivosView);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.activosViewTableAdapter.FillByMarca(this.activosViewDS.ActivosView, "%" + textBox1.Text + "%", "%" + textBox1.Text + "%");
        }
    }
}
