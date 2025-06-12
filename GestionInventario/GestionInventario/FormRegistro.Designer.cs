using System.Drawing;
using System.Windows.Forms;

namespace GestionInventario
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.lblNumeroRegistro = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtNumReg = new System.Windows.Forms.TextBox();
            this.lblSerialRegistro = new System.Windows.Forms.Label();
            this.txtSerialRegistro = new System.Windows.Forms.TextBox();
            this.lblMarcaRegistro = new System.Windows.Forms.Label();
            this.cmbMarcaRegistro = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioActivosDataSet = new GestionInventario.InventarioActivosDataSet();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.picEliminarMarca = new System.Windows.Forms.PictureBox();
            this.checkBoxFechaCompra = new System.Windows.Forms.CheckBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaReg = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.marcasTableAdapter = new GestionInventario.InventarioActivosDataSetTableAdapters.MarcasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroRegistro
            // 
            this.lblNumeroRegistro.AutoSize = true;
            this.lblNumeroRegistro.Location = new System.Drawing.Point(27, 71);
            this.lblNumeroRegistro.Name = "lblNumeroRegistro";
            this.lblNumeroRegistro.Size = new System.Drawing.Size(74, 21);
            this.lblNumeroRegistro.TabIndex = 2;
            this.lblNumeroRegistro.Text = "Número:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(193, 25);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(99, 25);
            this.lblRegistro.TabIndex = 3;
            this.lblRegistro.Text = "REGISTRO";
            // 
            // txtNumReg
            // 
            this.txtNumReg.Location = new System.Drawing.Point(179, 68);
            this.txtNumReg.Name = "txtNumReg";
            this.txtNumReg.Size = new System.Drawing.Size(202, 29);
            this.txtNumReg.TabIndex = 4;
            // 
            // lblSerialRegistro
            // 
            this.lblSerialRegistro.AutoSize = true;
            this.lblSerialRegistro.Location = new System.Drawing.Point(27, 116);
            this.lblSerialRegistro.Name = "lblSerialRegistro";
            this.lblSerialRegistro.Size = new System.Drawing.Size(54, 21);
            this.lblSerialRegistro.TabIndex = 5;
            this.lblSerialRegistro.Text = "Serial:";
            // 
            // txtSerialRegistro
            // 
            this.txtSerialRegistro.Location = new System.Drawing.Point(179, 113);
            this.txtSerialRegistro.Name = "txtSerialRegistro";
            this.txtSerialRegistro.Size = new System.Drawing.Size(202, 29);
            this.txtSerialRegistro.TabIndex = 6;
            // 
            // lblMarcaRegistro
            // 
            this.lblMarcaRegistro.AutoSize = true;
            this.lblMarcaRegistro.Location = new System.Drawing.Point(27, 160);
            this.lblMarcaRegistro.Name = "lblMarcaRegistro";
            this.lblMarcaRegistro.Size = new System.Drawing.Size(59, 21);
            this.lblMarcaRegistro.TabIndex = 7;
            this.lblMarcaRegistro.Text = "Marca:";
            // 
            // cmbMarcaRegistro
            // 
            this.cmbMarcaRegistro.DataSource = this.marcasBindingSource;
            this.cmbMarcaRegistro.DisplayMember = "Marca";
            this.cmbMarcaRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcaRegistro.FormattingEnabled = true;
            this.cmbMarcaRegistro.Location = new System.Drawing.Point(179, 160);
            this.cmbMarcaRegistro.Name = "cmbMarcaRegistro";
            this.cmbMarcaRegistro.Size = new System.Drawing.Size(202, 25);
            this.cmbMarcaRegistro.TabIndex = 8;
            this.cmbMarcaRegistro.ValueMember = "Id";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.inventarioActivosDataSet;
            // 
            // inventarioActivosDataSet
            // 
            this.inventarioActivosDataSet.DataSetName = "InventarioActivosDataSet";
            this.inventarioActivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picAgregar
            // 
            this.picAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(390, 156);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(26, 25);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregar.TabIndex = 9;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click_1);
            // 
            // picEliminarMarca
            // 
            this.picEliminarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEliminarMarca.Image = ((System.Drawing.Image)(resources.GetObject("picEliminarMarca.Image")));
            this.picEliminarMarca.Location = new System.Drawing.Point(422, 156);
            this.picEliminarMarca.Name = "picEliminarMarca";
            this.picEliminarMarca.Size = new System.Drawing.Size(26, 25);
            this.picEliminarMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEliminarMarca.TabIndex = 10;
            this.picEliminarMarca.TabStop = false;
            this.picEliminarMarca.Click += new System.EventHandler(this.picEliminarMarca_Click_1);
            // 
            // checkBoxFechaCompra
            // 
            this.checkBoxFechaCompra.AutoSize = true;
            this.checkBoxFechaCompra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFechaCompra.Location = new System.Drawing.Point(27, 201);
            this.checkBoxFechaCompra.Name = "checkBoxFechaCompra";
            this.checkBoxFechaCompra.Size = new System.Drawing.Size(220, 25);
            this.checkBoxFechaCompra.TabIndex = 11;
            this.checkBoxFechaCompra.Text = "Agregar fecha de compra ";
            this.checkBoxFechaCompra.UseVisualStyleBackColor = true;
            this.checkBoxFechaCompra.CheckedChanged += new System.EventHandler(this.checkBoxFechaCompra_CheckedChanged_1);
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Enabled = false;
            this.dtpFechaCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(179, 232);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(202, 25);
            this.dtpFechaCompra.TabIndex = 12;
            this.dtpFechaCompra.ValueChanged += new System.EventHandler(this.dtpFechaCompra_ValueChanged_1);
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(27, 274);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(141, 21);
            this.lblFechaRegistro.TabIndex = 13;
            this.lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReg.Location = new System.Drawing.Point(179, 274);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaReg.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Location = new System.Drawing.Point(193, 342);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 29);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 426);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaReg);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.checkBoxFechaCompra);
            this.Controls.Add(this.picEliminarMarca);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.cmbMarcaRegistro);
            this.Controls.Add(this.lblMarcaRegistro);
            this.Controls.Add(this.txtSerialRegistro);
            this.Controls.Add(this.lblSerialRegistro);
            this.Controls.Add(this.txtNumReg);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblNumeroRegistro);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.FormRegistro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTituloRegistro;
        private TextBox txtNumeroRegistro;
        private Label lblNumeroRegistro;
        private Label lblRegistro;
        private TextBox txtNumReg;
        private Label lblSerialRegistro;
        private TextBox txtSerialRegistro;
        private Label lblMarcaRegistro;
        private ComboBox cmbMarcaRegistro;
        private PictureBox picAgregar;
        private PictureBox picEliminarMarca;
        private CheckBox checkBoxFechaCompra;
        private DateTimePicker dtpFechaCompra;
        private Label lblFechaRegistro;
        private DateTimePicker dtpFechaReg;
        private Button btnRegistrar;
        private InventarioActivosDataSet inventarioActivosDataSet;
        private BindingSource marcasBindingSource;
        private InventarioActivosDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
    }
}