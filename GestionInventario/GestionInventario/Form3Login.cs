using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInventario;


namespace GestionInventario
{
    public partial class Form3Login : Form
    {
        public static string UsuarioActual = "";
        public Form3Login()
        {
            InitializeComponent();
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña");
                return;
            }
            string conexion = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Contrasena=@contrasena";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                int existe = (int)cmd.ExecuteScalar();
                if (existe > 0)
                {
                    UsuarioActual = usuario; 
                    this.Hide(); // Cierra el login
                    FormMDI frm = new FormMDI();


                    int sedeId;

                    //using (SqlConnection conn = new SqlConnection(connectionString))
                    //{
                    //conn.Open();


                    if (usuario != "Administrador")
                    {
                        try
                        {
                            string querySede = @"
        SELECT SedeId
        FROM Usuarios
        WHERE Usuario = @Usuario";

                            using (SqlCommand cmdSede = new SqlCommand(querySede, cn))
                            {
                                cmdSede.Parameters.AddWithValue("@Usuario", usuario);

                                object result = cmdSede.ExecuteScalar();

                                if (result == null)
                                {
                                    MessageBox.Show("No se encontró la sede del usuario.");
                                    return;
                                }

                                sedeId = Convert.ToInt32(result);
                            }

                            MessageBox.Show("El Id de sede es: " + sedeId);
                        }
                        catch(Exception ex)
                         {
                            MessageBox.Show("No fue posible validar sede de usuario");
                        }

                    }


                    frm.Show();


                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void Form3Login_Load(object sender, EventArgs e)
        {

        }
    }
}
