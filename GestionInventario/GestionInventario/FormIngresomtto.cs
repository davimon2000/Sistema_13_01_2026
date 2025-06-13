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

        private void cmbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbConcepto.SelectedItem?.ToString();

            if (seleccion == "INGRESO")
            {
                cmbTipoFalla.Visible = true;
                cmbTipoFalla.Enabled = true;
                lblTipoFallaMtto.Visible = true;
                btnIngresoMtto.Enabled = true;
                btnIngresoMtto.Visible = true;

                cmbEstadoMtto.Visible = false;
                cmbEstadoMtto.Enabled = false;
                lblEstadoMtto.Visible = false;
                lblTecnico.Visible = false;
                cmbTecnico.Visible = false;
                cmbTecnico.Enabled = false;
                btnSalidaMtto.Enabled = false;
                btnSalidaMtto.Visible = false;

            }
            else if (seleccion == "SALIDA")
            {
                cmbTipoFalla.Visible = false;
                cmbTipoFalla.Enabled = false;
                lblTipoFallaMtto.Visible= false;
                btnIngresoMtto.Enabled = false;
                btnIngresoMtto.Visible = false;
                

                cmbEstadoMtto.Visible = true;
                cmbEstadoMtto.Enabled = true;
                lblEstadoMtto.Visible = true;
                lblTecnico.Visible = true;
                cmbTecnico.Enabled = true;
                cmbTecnico.Visible = true;
                btnSalidaMtto.Enabled = true;
                btnSalidaMtto.Visible = true;
            }
            
        }

        private void FormIngresomtto_Load_1(object sender, EventArgs e)
        {
            cmbTipoFalla.Visible = true;
            cmbTipoFalla.Enabled = true;
            lblTipoFallaMtto.Visible = true;
            btnIngresoMtto.Enabled = true;
            btnIngresoMtto.Visible = true;

            cmbEstadoMtto.Visible = false;
            cmbEstadoMtto.Enabled = false;
            lblEstadoMtto.Visible = false;
            lblTecnico.Visible = false;
            cmbTecnico.Enabled = false;
            cmbTecnico.Visible = false;
            btnSalidaMtto.Enabled = false;
            btnSalidaMtto.Visible = false;
            
        }

        private void lblTipoFallaMtto_Click(object sender, EventArgs e)
        {

        }

        
    }
}
