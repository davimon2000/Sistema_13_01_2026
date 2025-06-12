using System.Windows.Forms;
using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GestionInventario
{
    public partial class FormMDI : MaterialForm
    {
        public FormMDI()
        {
            InitializeComponent();


            //Configuración de material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            FormEstado frm = FormEstado.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            FormRegistro frm = FormRegistro.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        { 
            this.WindowState = FormWindowState.Minimized;
        
    }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        
    }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

    }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
    }

        private void btnIngresomtto_Click_1(object sender, EventArgs e)
        {
            FormIngresomtto frm = FormIngresomtto.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
    }

        private void btnSalida_Click_1(object sender, EventArgs e)
        {
            FormSalida frm = FormSalida.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
    
    }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            FormConsulta frm = FormConsulta.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
    }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            FormAnalisis frm = FormAnalisis.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }

}
