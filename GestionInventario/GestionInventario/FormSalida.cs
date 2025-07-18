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
            // Valores del formulario
            string numeroActivo = txtNumAsig.Text;
            DateTime fechaAsign = dtpFechaAsig.Value;
            String Sede = cmbSedeAsig.SelectedItem.ToString();
            //String Area = cmbAreaAsig.SelectedItem.ToString();
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
                        string queryExistencia = "SELECT COUNT(*) FROM Asignacion WHERE IdActivo = @IdActivo";
                        using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                        {
                            cmdExist.Parameters.AddWithValue("@IdActivo", InventarioId);
                            int count = (int)cmdExist.ExecuteScalar();

                            if (count > 0)
                            {
                                // Si ya existe, actualizar
                                string updateQuery = @"UPDATE Asignacion 
                                               SET Sede = @Sede, Area = @Area, FechaAsignacion = @Fecha
                                               WHERE IdActivo = @IdActivo";

                                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Sede", Sede);
                                    //cmdUpdate.Parameters.AddWithValue("@Area", Area);
                                    cmdUpdate.Parameters.AddWithValue("@Fecha", fechaAsign);
                                    cmdUpdate.Parameters.AddWithValue("@IdActivo", InventarioId);

                                    cmdUpdate.ExecuteNonQuery();
                                    MessageBox.Show("Asignación actualizada correctamente.");
                                }
                            }
                            else
                            {
                                // Si no existe, insertar
                                string insertQuery = @"INSERT INTO Asignacion (Sede, Area, FechaAsignacion, IdActivo) 
                                               VALUES (@Sede, @Area, @Fecha, @idActivo)";

                                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                                {
                                    cmdInsert.Parameters.AddWithValue("@Sede", Sede);
                                   // cmdInsert.Parameters.AddWithValue("@Area", Area);
                                    cmdInsert.Parameters.AddWithValue("@Fecha", fechaAsign);
                                    cmdInsert.Parameters.AddWithValue("@idActivo", InventarioId);

                                    cmdInsert.ExecuteNonQuery();
                                    MessageBox.Show("Asignación registrada correctamente.");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El activo no se encuentra registrado.");
                    }
                    }
                }
            }
    }
}
