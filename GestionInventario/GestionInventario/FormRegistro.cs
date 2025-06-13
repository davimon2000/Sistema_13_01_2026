using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionInventario
{
    public partial class FormRegistro : Form
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["GestionInventario.Properties.Settings.InventarioActivosConnectionString"].ConnectionString;
        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormRegistro instancia = null;
        public static FormRegistro ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormRegistro();
                return instancia;
            }
            return instancia;
        }
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumeroRegistro_Click(object sender, EventArgs e)
        {

        }

        

        private void picEliminarMarca_Click(object sender, EventArgs e)
        {
            string marcaAEliminar = cmbMarcaRegistro.Text.Trim();

            if (cmbMarcaRegistro.Items.Contains(marcaAEliminar))
            {
                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas eliminar la marca '{marcaAEliminar}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    cmbMarcaRegistro.Items.Remove(marcaAEliminar);
                    cmbMarcaRegistro.Text = "";
                    MessageBox.Show("Marca eliminada correctamente.");
                }
            }
            else
            {
                MessageBox.Show($"La marca '{marcaAEliminar}' no existe en la lista. ");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void FormRegistro_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet1.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter1.Fill(this.inventarioActivosDataSet1.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.inventarioActivosDataSet.Marcas);

        }
        
        private void picAgregar_Click_1(object sender, EventArgs e)
        {
            String Nuevamarca = cmbMarcaRegistro.Text;

            if (MarcaExiste(Nuevamarca))
            {
                MessageBox.Show("La marca ya existe.");
            }
            else
            {

                string query = "INSERT INTO Marcas (Marca) VALUES (@Marca)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        //Añadir los parámetros a la consulta
                        command.Parameters.AddWithValue("@Marca", Nuevamarca);

                        try
                        {
                            connection.Open(); // Abrir la conexión
                            int rowsAffected = command.ExecuteNonQuery(); // Ejecutar la consulta

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Marca añadida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Opcional: Limpiar los campos después de insertar
                                cmbMarcaRegistro.SelectedItem = -1;

                            }
                            else
                            {
                                MessageBox.Show("No se pudo añadir el dato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
        private bool MarcaExiste(string nombreMarca)
        {
            String Nuevamarca = cmbMarcaRegistro.Text.Trim();
            string query = "SELECT COUNT(*) FROM Marcas WHERE Marca = @Marca";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Marca", Nuevamarca);
                connection.Open();

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void EliminarDeBaseDeDatos(string EliminarMarca)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "DELETE FROM Marcas WHERE Marca = @Marca";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Marca", EliminarMarca);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show("No se encontró el elemento en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar de la base de datos: " + ex.Message);
                    }
                }
            }
        }

        private void picEliminarMarca_Click_1(object sender, EventArgs e)
        {
            string marcaAEliminar = cmbMarcaRegistro.Text.Trim();

                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas eliminar la marca '{marcaAEliminar}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    EliminarDeBaseDeDatos(marcaAEliminar);

                    // Eliminar del ComboBox
                    cmbMarcaRegistro.Items.Remove(marcaAEliminar);
                    cmbMarcaRegistro.Items.Remove(marcaAEliminar);
                    cmbMarcaRegistro.Text = "";
                    MessageBox.Show("Marca eliminada correctamente.");
                }
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Valores del formulario
            string codInterno = txtNumReg.Text;
            string serial = txtSerialRegistro.Text;
            string marca1 = cmbMarcaRegistro.SelectedItem?.ToString(); // Asegúrate que tenga algo seleccionado
            string marca = cmbMarcaRegistro.ValueMember;
            int idMarca = Convert.ToInt32(cmbMarcaRegistro.SelectedValue);
            DateTime fechaReg = dtpFechaReg.Value;
            DateTime? fechaCompra = checkBoxFechaCompra.Checked ? dtpFechaCompra.Value : (DateTime?)null;



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryExistencia = "SELECT COUNT(*) FROM RegistroActivos WHERE codInterno = @codInterno";
                using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                {
                    cmdExist.Parameters.AddWithValue("@codInterno", codInterno);
                    int count = (int)cmdExist.ExecuteScalar();

                    if (count > 0)
                    {
                        // Paso 2: Preguntar si desea actualizar
                        DialogResult resultado = MessageBox.Show(
                            "Ya existe un activo con ese número. ¿Desea actualizar los datos?",
                            "Confirmar actualización",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (resultado == DialogResult.Yes)
                        {
                            // Paso 3: Actualizar
                            string updateQuery = @"
                        UPDATE RegistroActivos
                        SET Serial = @serial,
                            Marca = @marca,
                            FechaCompra = @fechaCompra,
                            FechaRegistro = @fechaRegistro
                            
                        WHERE CodInterno = @codInterno";

                            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@codInterno", codInterno);
                                cmdUpdate.Parameters.AddWithValue("@serial", serial);
                                cmdUpdate.Parameters.AddWithValue("@marca", idMarca);
                                cmdUpdate.Parameters.AddWithValue("@fechaRegistro", fechaReg);

                                // Manejo de parámetro nulo
                                if (fechaCompra.HasValue)
                                    cmdUpdate.Parameters.AddWithValue("@fechaCompra", fechaCompra.Value);
                                else
                                    cmdUpdate.Parameters.AddWithValue("@fechaCompra", DBNull.Value);
                                cmdUpdate.ExecuteNonQuery();
                                MessageBox.Show("Registro actualizado correctamente.");
                                txtNumReg.Text = "";
                                txtSerialRegistro.Text = "";
                                checkBoxFechaCompra.Checked = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Operación cancelada.");
                        }
                    }
                    else
                    {

                        // 3. Insertar en la base de datos
                        using (SqlConnection conexion = new SqlConnection(connectionString))
                        {
                            string query = @"INSERT INTO RegistroActivos (CodInterno, Serial, Marca, FechaCompra, FechaRegistro)
                         VALUES (@CodInterno, @Serial, @IdMarca, @FechaCompra, @FechaRegistro)";

                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@CodInterno", codInterno);
                                cmd.Parameters.AddWithValue("@Serial", serial);
                                cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                                cmd.Parameters.AddWithValue("@FechaRegistro", fechaReg);

                                // Manejo de parámetro nulo
                                if (fechaCompra.HasValue)
                                    cmd.Parameters.AddWithValue("@FechaCompra", fechaCompra.Value);
                                else
                                    cmd.Parameters.AddWithValue("@FechaCompra", DBNull.Value);

                                try
                                {
                                    conexion.Open();
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registro guardado con éxito.");
                                    txtNumReg.Text = "";
                                    txtSerialRegistro.Text = "";
                                    checkBoxFechaCompra.Checked = false;
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
        }

        private void checkBoxFechaCompra_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpFechaCompra.Enabled = checkBoxFechaCompra.Checked;
        }

        private void dtpFechaCompra_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbMarcaRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}