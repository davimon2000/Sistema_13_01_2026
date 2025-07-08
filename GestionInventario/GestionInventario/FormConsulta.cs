using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void txtNumConsulta_TextChanged(object sender, EventArgs e)
        {
            this.activosViewTableAdapter.FillByMarca(this.activosViewDS.ActivosView, "%" + txtNumConsulta.Text + "%", "%" + txtNumConsulta.Text + "%");
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'activosViewDS.ActivosView' Puede moverla o quitarla según sea necesario.
            this.activosViewTableAdapter.Fill(this.activosViewDS.ActivosView);

        }

        private void lblNumeroConsulta_Click(object sender, EventArgs e)
        {

        }

        private void activosViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroConsulta_TextChanged(object sender, EventArgs e)
        {
            this.activosViewTableAdapter.FillByNumero(this.activosViewDS.ActivosView, "%" + txtNumeroConsulta.Text + "%");
        }
    }
}
