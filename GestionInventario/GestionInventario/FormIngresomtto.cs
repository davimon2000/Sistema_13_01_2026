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

namespace GestionInventario
{
    public partial class FormIngresomtto : Form
    {
        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
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
                txtObservacion.Visible = true;
                txtObservacion.Enabled = true;

                cmbEstadoMtto.Visible = false;
                cmbEstadoMtto.Enabled = false;
                lblEstadoMtto.Visible = false;
                lblTecnico.Visible = false;
                cmbTecnico.Visible = false;
                cmbTecnico.Enabled = false;
                btnSalidaMtto.Enabled = false;
                btnSalidaMtto.Visible = false;
                txtObservacionSalida.Visible = false;
                txtObservacionSalida.Enabled = false;

            }
            else if (seleccion == "SALIDA")
            {
                cmbTipoFalla.Visible = false;
                cmbTipoFalla.Enabled = false;
                lblTipoFallaMtto.Visible= false;
                btnIngresoMtto.Enabled = false;
                btnIngresoMtto.Visible = false;
                txtObservacion.Visible = false;
                txtObservacion.Enabled = false;

                cmbEstadoMtto.Visible = true;
                cmbEstadoMtto.Enabled = true;
                lblEstadoMtto.Visible = true;
                lblTecnico.Visible = true;
                cmbTecnico.Enabled = true;
                cmbTecnico.Visible = true;
                btnSalidaMtto.Enabled = true;
                btnSalidaMtto.Visible = true;
                txtObservacionSalida.Visible = true;
                txtObservacionSalida.Enabled = true;
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

            cmbConcepto.SelectedIndex = 0;
            
        }

        private void lblTipoFallaMtto_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresoMtto_Click(object sender, EventArgs e)
        {
            // Valores del formulario
            string numeroActivo = txtNumMtto.Text;
            String concepto = cmbConcepto.SelectedItem.ToString();
            DateTime fechaIngresoMtto = dtpFechaMtto.Value;
            String TipoFalla = cmbTipoFalla.SelectedItem.ToString();
            String ObsIngreso = txtObservacion.Text;
            int InventarioId = 0;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryId = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                using (SqlCommand cmd = new SqlCommand(queryId, conn))
                {
                    cmd.Parameters.AddWithValue("@Numero", numeroActivo);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        InventarioId = Convert.ToInt32(result);


                        string queryExistencia = "SELECT COUNT(*) FROM Mantenimiento WHERE InventarioId = @InventarioId";
                        using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                        {
                            cmdExist.Parameters.AddWithValue("@InventarioId", InventarioId);
                            int count = (int)cmdExist.ExecuteScalar();

                            if (count > 0)
                            {
                                // Paso 2: Preguntar si desea actualizar
                                DialogResult resultado = MessageBox.Show(
                                    "Ya existe un activo ingresado a mantenimiento con ese número. ¿Desea actualizar los datos de ingreso?",
                                    "Confirmar actualización",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                );

                                if (resultado == DialogResult.Yes)
                                {
                                    // Paso 3: Actualizar
                                    string updateQuery = @"
                        UPDATE Mantenimiento
                        SET InventarioId = @InventarioId,
                            FechaIngresoMtto = @FechaIngresoMtto,
                            TipoFalla = @TipoFalla,
                            ObsIngreso = @ObsIngreso
                            
                        WHERE InventarioId = @InventarioId";

                                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                                    {
                                        cmdUpdate.Parameters.AddWithValue("@InventarioId", InventarioId);
                                        cmdUpdate.Parameters.AddWithValue("@FechaIngresoMtto", fechaIngresoMtto);
                                        cmdUpdate.Parameters.AddWithValue("@TipoFalla", TipoFalla);
                                        cmdUpdate.Parameters.AddWithValue("@ObsIngreso", ObsIngreso);

                                        // Manejo de parámetro nulo

                                        cmdUpdate.ExecuteNonQuery();
                                        MessageBox.Show("Registro actualizado correctamente.");
                                        txtNumMtto.Text = "";
                                        txtObservacion.Text = "";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Operación cancelada.");
                                    txtNumMtto.Text = "";
                                    txtObservacion.Text = "";
                                }
                            }
                        
                            else
                            {

                                // 3. Insertar en la base de datos
                                using (SqlConnection conexion = new SqlConnection(connectionString))
                                {
                                    string query = @"INSERT INTO Mantenimiento (InventarioId, FechaIngresoMtto, TipoFalla, ObsIngreso)
                         VALUES (@InventarioId, @FechaIngresoMtto, @TipoFalla, @ObsIngreso)";

                                    using (SqlCommand cmdIngreso = new SqlCommand(query, conexion))
                                    {
                                        cmdIngreso.Parameters.AddWithValue("@InventarioId", InventarioId);
                                        cmdIngreso.Parameters.AddWithValue("@FechaIngresoMtto", fechaIngresoMtto);
                                        cmdIngreso.Parameters.AddWithValue("@TipoFalla", TipoFalla);
                                        cmdIngreso.Parameters.AddWithValue("@ObsIngreso", ObsIngreso);


                                        try
                                        {
                                            conexion.Open();
                                            cmdIngreso.ExecuteNonQuery();
                                            MessageBox.Show("Activo ingresado correctamente");
                                            txtNumMtto.Text = "";
                                            txtObservacion.Text = "";
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error al registrar: " + ex.Message);
                                        }
                                    }
                                }
                            }
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("El activo no se encuentra registrado");
                    }
                }
            }


        }

        private void lblMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstadoMtto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalidaMtto_Click(object sender, EventArgs e)
        {
            // Valores del formulario
            string numeroActivo = txtNumMtto.Text;
            DateTime fechaSalidaMtto = dtpFechaMtto.Value;
            String Estado = cmbEstadoMtto.SelectedItem.ToString();
            // string obssalida = txtobservacionsalida.text;
            string obssalida = "observacion";
            //string tecnicoid = cmbtecnico.selecteditem.tostring();
            int tecnicoid = 1;
            int inventarioid = 0;

            using (SqlConnection conn = new SqlConnection(connectionString) )
            {
                conn.Open();

                string queryid = "select id from registroactivos where codinterno = @numero";
                using (SqlCommand cmd = new SqlCommand(queryid, conn))
                {
                    cmd.Parameters.AddWithValue("@numero", numeroActivo);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        inventarioid = Convert.ToInt32(result);


                        string queryexistencia = "select count(*) from mantenimiento where inventarioid = @inventarioid";
                        using (SqlCommand cmdexist = new SqlCommand(queryexistencia, conn))
                        {
                            cmdexist.Parameters.AddWithValue("@inventarioid", inventarioid);
                            int count = (int)cmdexist.ExecuteScalar();

                            if (count > 0)
                            {
                                string updatequery = @"
                                update mantenimiento
                                set fechasalidamtto = @fechasalidamtto,
                                    estadosalida = @estadosalida,
                                    ObsSalida = ObsSalida,
                                    tecnicoid = @tecnicoid

                                where inventarioid = @inventarioid";

                                using (SqlCommand cmdupdate = new SqlCommand(updatequery, conn))
                                {
                                    cmdupdate.Parameters.AddWithValue("@inventarioid", inventarioid);
                                    cmdupdate.Parameters.AddWithValue("@fechasalidamtto", fechaSalidaMtto);
                                    cmdupdate.Parameters.AddWithValue("@estadosalida", Estado);
                                    //cmdupdate.Parameters.AddWithValue("@obssalida", obssalida);
                                    cmdupdate.Parameters.AddWithValue("@tecnicoid", tecnicoid);

                                    // manejo de parámetro nulo

                                    cmdupdate.ExecuteNonQuery();
                                    //messagebox.show("registro actualizado correctamente.");
                                    //txtnummtto.text = "";
                                    //txtobservacionsalida.text = "";
                                }



                            }

                            else
                            {
                                MessageBox.Show("el activo no ha ingresado a mantenimiento");

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("el activo no se encuentra registrado");
                    }
                }
            }
        }

        private void txtObservacionSalida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
