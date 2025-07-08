using System.Windows.Forms;
using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;


namespace GestionInventario
{
    public partial class FormMDI : MaterialForm
    {
        public const int WM_NCLBUTTONDOWN = 0xA1; //Mensaje que se envía cuando se hace clic en una parte no cliente de la ventana
        public const int HTCAPTION = 0x2;         //El área que se está clicando es la barra de título

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//Libera el "capturado" actual del mouse

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);  //Se envía un mensaje para que actúe como si el usuario hubiera hecho clic en la barra de título de la ventana.

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
            frm.BringToFront();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        { 
            this.WindowState = FormWindowState.Minimized;
        
    }

       

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }

}
