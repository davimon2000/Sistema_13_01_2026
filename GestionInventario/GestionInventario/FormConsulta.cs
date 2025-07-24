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
using System.Data.SqlClient;
using ClosedXML.Excel;

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
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.Mantenimiento' Puede moverla o quitarla según sea necesario.
            //this.mantenimientoTableAdapter.Fill(this.consultaActivosDS.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.RegistroActivos' Puede moverla o quitarla según sea necesario.
            this.registroActivosTableAdapter.Fill(this.consultaActivosDS.RegistroActivos);
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.EditarTable' Puede moverla o quitarla según sea necesario.
            //this.editarTableTableAdapter.Fill(this.consultaActivosDS.EditarTable);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet3.RegistroActivos' Puede moverla o quitarla según sea necesario.
            // this.registroActivosTableAdapter.Fill(this.inventarioActivosDataSet3.RegistroActivos);
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
            //this.registroActivosDataGridView.FillByNumero(this.consultaActivosDS.RegistroActivos, "%" + txtNumeroConsulta.Text + "%");
            //this.registroActivosTableAdapter.FillByNumero(this.consultaActivosDS.RegistroActivos, "%" + txtNumeroConsulta.Text + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarTablaAExcel();
        }
        private void ExportarTablaAExcel()
        {
            string query = "SELECT * FROM VistaActivos";  // Puedes cambiarlo por otra tabla o vista
            string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Activos");

                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Excel Workbook|*.xlsx";
                    saveFile.Title = "Guardar archivo Excel";
                    saveFile.FileName = "ReporteActivos.xlsx";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {   
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ExportarTablaAExcelMtto()
        {
            string query = "SELECT * FROM VistaMtto";  // Puedes cambiarlo por otra tabla o vista
            string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Activos");

                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Excel Workbook|*.xlsx";
                    saveFile.Title = "Guardar archivo Excel";
                    saveFile.FileName = "ReporteMtto.xlsx";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void mantenimientoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void activosViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarTablaAExcelMtto();
        }
    }
}
