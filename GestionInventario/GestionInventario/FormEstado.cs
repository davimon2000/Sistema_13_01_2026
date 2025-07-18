using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionInventario
{
    public partial class FormEstado : Form
    {

        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormEstado instancia = null;
        public static FormEstado ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormEstado();
                return instancia;
            }
            return instancia;
        }
        public FormEstado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEstado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet2.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.inventarioActivosDataSet2.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet_MarcasVisual.RegistroActivos' Puede moverla o quitarla según sea necesario.
            //  this.registroActivosTableAdapter.Fill(this.inventarioActivosDataSet_MarcasVisual.RegistroActivos);
            CargarGraficoEstadoGeneral();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void CargarGraficoEstadoGeneral()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Estado general de diademas");

            Series serie = new Series("Diademas");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true; // Mostrar valor como etiqueta
            serie.LabelForeColor = Color.Black; //  Color del número
            serie.Font = new Font("Arial", 10); //  Estilo del número

            

            int disponibles = 0;
            int enMantenimiento = 0;

            string query = @"
        SELECT EstadoDefinitivo, COUNT(*) as Total 
        FROM VistaActivos
        WHERE EstadoDefinitivo IN ('Nueva', 'Disponible', 'Restaurado', 'Baja', 'EnMtto')
        GROUP BY EstadoDefinitivo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string estado = reader["EstadoDefinitivo"].ToString();
                        int total = Convert.ToInt32(reader["Total"]);

                        if (estado == "EnMtto")
                            enMantenimiento += total;
                        else
                        {
                            if (estado != "Baja")
                            {
                                disponibles += total;
                            }
                        }   
                    }
                }
            }

            serie.Points.AddXY("Disponibles para asignar", disponibles);
            serie.Points.AddXY("En mantenimiento", enMantenimiento);

            chart1.Series.Add(serie);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void FiltrarDatos()
        {
            List<string> condiciones = new List<string>();

            if (cmbMarca.SelectedItem != null && cmbMarca.SelectedItem.ToString() != "TODOS")
                condiciones.Add("Marca = @Marca");

            if (cmbEstado.SelectedItem != null && cmbEstado.SelectedItem.ToString() != "Todos")
                condiciones.Add("EstadoDefinitivo = @Estado");

            if (cmbSede.SelectedItem != null && cmbSede.SelectedItem.ToString() != "Todos")
                condiciones.Add("Sede = @Sede");

            if (cmbFalla.SelectedItem != null && cmbFalla.SelectedItem.ToString() != "Todos")
                condiciones.Add("TipoFalla = @Falla");

            string where = condiciones.Count > 0 ? "WHERE " + string.Join(" AND ", condiciones) : "";

            string query = "SELECT * FROM VistaActivos " + where;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (query.Contains("@Marca")) cmd.Parameters.AddWithValue("@Marca", cmbMarca.SelectedItem.ToString());
                if (query.Contains("@Estado")) cmd.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString());
                if (query.Contains("@Sede")) cmd.Parameters.AddWithValue("@Sede", cmbSede.SelectedItem.ToString());
                if (query.Contains("@Falla")) cmd.Parameters.AddWithValue("@Falla", cmbFalla.SelectedItem.ToString());

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvResultados.DataSource = dt;

                    lblTotal.Text =  dt.Rows.Count.ToString();
                }
            }
        }
    }
}
