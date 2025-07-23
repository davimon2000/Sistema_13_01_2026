namespace GestionInventario
{
    partial class FormEstado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblNumeroAsig = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.registroActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegistro = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFalla = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.inventarioActivosDataSet2 = new GestionInventario.InventarioActivosDataSet2();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new GestionInventario.InventarioActivosDataSet2TableAdapters.MarcasTableAdapter();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chartMarcas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroAsig
            // 
            this.lblNumeroAsig.AutoSize = true;
            this.lblNumeroAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAsig.Location = new System.Drawing.Point(12, 337);
            this.lblNumeroAsig.Name = "lblNumeroAsig";
            this.lblNumeroAsig.Size = new System.Drawing.Size(59, 21);
            this.lblNumeroAsig.TabIndex = 8;
            this.lblNumeroAsig.Text = "Marca:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "TODOS",
            "PRACTICA",
            "XKIM",
            "LOOGITECH",
            "JABRA BI",
            "JABRA MONO"});
            this.cmbMarca.Location = new System.Drawing.Point(118, 340);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Todos",
            "Nuevo",
            "En uso",
            "Disponible(Registro)",
            "Bueno",
            "Reparado",
            "Recuperado",
            "Baja",
            "EnMtto"});
            this.cmbEstado.Location = new System.Drawing.Point(338, 340);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 11;
            // 
            // registroActivosBindingSource
            // 
            this.registroActivosBindingSource.DataMember = "RegistroActivos";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(302, 29);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(157, 25);
            this.lblRegistro.TabIndex = 12;
            this.lblRegistro.Text = "ESTADO ACTUAL";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 84);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(332, 206);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cmbSede
            // 
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Items.AddRange(new object[] {
            "Todos",
            "Campin",
            "Dorado Plaza",
            "Arboleda",
            "Panamericana",
            "Pereira"});
            this.cmbSede.Location = new System.Drawing.Point(531, 337);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(121, 21);
            this.cmbSede.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sede:";
            // 
            // cmbFalla
            // 
            this.cmbFalla.FormattingEnabled = true;
            this.cmbFalla.Items.AddRange(new object[] {
            "Todos",
            "Cable",
            "Microfono",
            "Balaca",
            "Boton",
            "Base",
            "Pitillo",
            "Tarjeta"});
            this.cmbFalla.Location = new System.Drawing.Point(118, 378);
            this.cmbFalla.Name = "cmbFalla";
            this.cmbFalla.Size = new System.Drawing.Size(121, 21);
            this.cmbFalla.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo de falla:";
            // 
            // btnFiltros
            // 
            this.btnFiltros.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFiltros.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.Location = new System.Drawing.Point(292, 374);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(143, 27);
            this.btnFiltros.TabIndex = 18;
            this.btnFiltros.Text = "APLICAR FILTROS";
            this.btnFiltros.UseVisualStyleBackColor = false;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // inventarioActivosDataSet2
            // 
            this.inventarioActivosDataSet2.DataSetName = "InventarioActivosDataSet2";
            this.inventarioActivosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.inventarioActivosDataSet2;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(16, 415);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(636, 109);
            this.dgvResultados.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 48);
            this.label4.TabIndex = 20;
            this.label4.Text = "No. de \r\nDiademas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(695, 485);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 24);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "0";
            // 
            // chartMarcas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMarcas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMarcas.Legends.Add(legend2);
            this.chartMarcas.Location = new System.Drawing.Point(387, 84);
            this.chartMarcas.Name = "chartMarcas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMarcas.Series.Add(series2);
            this.chartMarcas.Size = new System.Drawing.Size(332, 206);
            this.chartMarcas.TabIndex = 22;
            this.chartMarcas.Text = "chart2";
            this.chartMarcas.Click += new System.EventHandler(this.chartMarcas_Click);
            // 
            // FormEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 408);
            this.Controls.Add(this.chartMarcas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.cmbFalla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblNumeroAsig);
            this.Name = "FormEstado";
            this.Text = "Estado";
            this.Load += new System.EventHandler(this.FormEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroAsig;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        
        private System.Windows.Forms.BindingSource registroActivosBindingSource;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFalla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltros;
        private InventarioActivosDataSet2 inventarioActivosDataSet2;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private InventarioActivosDataSet2TableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarcas;
    }
}