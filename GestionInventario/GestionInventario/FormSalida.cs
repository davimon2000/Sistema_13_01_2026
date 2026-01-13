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
    public partial class FormSalida : Form
    {
        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormSalida instancia = null;
        public static FormSalida ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormSalida();
                return instancia;
            }
            return instancia;
        }
        public FormSalida()
        {
            InitializeComponent();
        }

        private void cmbAreaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresoMtto_Click(object sender, EventArgs e)
        {
            try
            {
                // Valores del formulario
                string numeroActivo = txtNumAsig.Text;
                DateTime fechaAsign = dtpFechaAsig.Value;
                //String Sede = cmbSedeAsig.SelectedItem.ToString();
                int Sede = Convert.ToInt32(cmbSedeAsig.SelectedValue);
                //String Area = cmbAreaAsig.SelectedItem.ToString();
                int InventarioId = 0;
                bool Disponible = true;
                 string observacion = txtObservacion.Text;
                string usuarioAsig = txtUsuarioAsig.Text;






                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string queryId = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                    using (SqlCommand cmd = new SqlCommand(queryId, conn))
                    {
                        cmd.Parameters.AddWithValue("@Numero", numeroActivo);
                        object result = cmd.ExecuteScalar();
                        InventarioId = Convert.ToInt32(result);

                        if (result != null)
                        {//ABRE ABC



                            string queryExistenciaMtto = @"
                            SELECT TOP 1 EstadoSalida
                            FROM Mantenimiento
                            WHERE InventarioId = @InventarioId
                            ORDER BY Id DESC"; // o por FechaIngresoMtto DESC

                            using (SqlCommand cmdExistMtto = new SqlCommand(queryExistenciaMtto, conn))
                            {
                                //conn.Open();
                                cmdExistMtto.Parameters.AddWithValue("@InventarioId", InventarioId);
                                object resultEstado = cmdExistMtto.ExecuteScalar();
                                string estadoMtto = resultEstado?.ToString();
                                //conn.Close();


                            //    string queryEstadoRegistro = @"
                            //SELECT EstadoRegistro
                            //FROM RegistroActivos
                            //WHERE Id = @InventarioId";

                            //    using (SqlCommand cmdEstadoRegistro = new SqlCommand(queryEstadoRegistro, conn))
                            //    {
                            //        //conn.Open();
                            //        cmdEstadoRegistro.Parameters.AddWithValue("@InventarioId", InventarioId);
                            //        object resultEstadoRegistro = cmdEstadoRegistro.ExecuteScalar();
                            //        string estadoRegistro = resultEstadoRegistro?.ToString();
                            //        //conn.Close();


                            //        //MessageBox.Show("estadoMtto" + estadoMtto);
                            //        //MessageBox.Show("estadoRegistro" + estadoRegistro);

                            //        if (estadoMtto == "EnMtto" || estadoMtto == "Baja")
                            //        {
                            //            Disponible = false;
                            //        }
                            //        else if(estadoMtto == "Disponible")
                            //        {
                            //            Disponible=true;
                            //        }
                            //        else if (estadoRegistro == "Baja" || estadoRegistro == "Con Falla")
                            //        {
                            //            Disponible = false;
                            //        }

                                    


                            //        if (Disponible == true)
                            //        {





                            //            //InventarioId = Convert.ToInt32(result);
                            //            string queryExistencia = "SELECT COUNT(*) FROM Asignacion WHERE IdActivo = @IdActivo";
                            //            using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                            //            {
                            //                cmdExist.Parameters.AddWithValue("@IdActivo", InventarioId);
                            //                int count = (int)cmdExist.ExecuteScalar();

                            //                if (count > 0)
                            //                {
                            //                    // Si ya existe, actualizar
                            //                    string updateQuery = @"UPDATE Asignacion 
                            //                   SET Sede = @Sede, FechaAsignacion = @Fecha
                            //                   WHERE IdActivo = @IdActivo";

                            //                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            //                    {
                            //                        cmdUpdate.Parameters.AddWithValue("@Sede", Sede);
                            //                        //cmdUpdate.Parameters.AddWithValue("@Area", Area);
                            //                        cmdUpdate.Parameters.AddWithValue("@Fecha", fechaAsign);
                            //                        cmdUpdate.Parameters.AddWithValue("@IdActivo", InventarioId);

                            //                        cmdUpdate.ExecuteNonQuery();
                            //                        MessageBox.Show("Asignación actualizada correctamente.");
                            //                    }
                            //                }
                            //                else
                            //                {
                            //                    // Si no existe, insertar
                            //                    string insertQuery = @"INSERT INTO Asignacion (Sede, FechaAsignacion, IdActivo) 
                            //                   VALUES (@Sede, @Fecha, @idActivo)";

                            //                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            //                    {
                            //                        cmdInsert.Parameters.AddWithValue("@Sede", Sede);
                            //                        // cmdInsert.Parameters.AddWithValue("@Area", Area);
                            //                        cmdInsert.Parameters.AddWithValue("@Fecha", fechaAsign);
                            //                        cmdInsert.Parameters.AddWithValue("@idActivo", InventarioId);
                            //                        try
                            //                        {
                            //                            cmdInsert.ExecuteNonQuery();
                            //                            MessageBox.Show("Asignación registrada correctamente.");
                            //                        }
                            //                        catch (Exception ex)
                            //                        {
                            //                            MessageBox.Show("Error: " + ex.Message);
                            //                        }
                            //                    }
                            //                }
                            //            }

                            //        }
                            //        else
                            //        {
                            //            MessageBox.Show("El activo no se encuentra disponible para asignación.");
                            //        }


                            //    }
                            }


                        } //CIERRE ABC
                        else
                        {
                            MessageBox.Show("El activo no se encuentra registrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sedesDS.Sedes' Puede moverla o quitarla según sea necesario.
            this.sedesTableAdapter.Fill(this.sedesDS.Sedes);

            lblNumeroAsig.Visible = true;
            lblFechaAsig.Visible = true;    
            dtpFechaAsig.Visible = true;    
            lblSede.Visible = true;
            cmbSedeAsig.Visible = true;
            lblObservacion.Visible = true;
            txtObservacion.Visible = true;
            btnAsign.Visible = true;
            lblusuarioAsig.Visible = true;
            txtUsuarioAsig.Visible = true;

            lblFechaDev.Visible = false;
            dtpFechaDev.Visible = false;
            btnDevolver.Visible = false;



        }

        private void cmbConceptoAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbConceptoAsig.SelectedItem.ToString();
            if(seleccion == "Asignacion")
            {
                lblNumeroAsig.Visible = true;
                lblFechaAsig.Visible = true;
                dtpFechaAsig.Visible = true;
                lblSede.Visible = true;
                cmbSedeAsig.Visible = true;
                lblObservacion.Visible = true;
                txtObservacion.Visible = true;
                btnAsign.Visible = true;
                lblusuarioAsig.Visible = true;
                txtUsuarioAsig.Visible = true;

                lblFechaDev.Visible = false;
                dtpFechaDev.Visible = false;
                btnDevolver.Visible = false;
            }
            else
            {
                lblNumeroAsig.Visible = true;
                lblFechaAsig.Visible = false;
                dtpFechaAsig.Visible = false;
                lblSede.Visible = true;
                cmbSedeAsig.Visible = true;
                lblObservacion.Visible = true;
                txtObservacion.Visible = true;
                btnAsign.Visible = false;
                lblusuarioAsig.Visible = false;
                txtUsuarioAsig.Visible = false;

                lblFechaDev.Visible = true;
                dtpFechaDev.Visible = true;
                btnDevolver.Visible = true;
            }
        }

        private void lblAsignacion_Click(object sender, EventArgs e)
        {

        }
    }
}
