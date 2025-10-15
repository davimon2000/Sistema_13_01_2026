using System.Drawing;
using System.Windows.Forms;

namespace GestionInventario
{
    partial class FormIngresomtto
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
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.txtNumMtto = new System.Windows.Forms.TextBox();
            this.lblNumeroMtto = new System.Windows.Forms.Label();
            this.dtpFechaMtto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaMtto = new System.Windows.Forms.Label();
            this.btnIngresoMtto = new System.Windows.Forms.Button();
            this.lblTipoFallaMtto = new System.Windows.Forms.Label();
            this.cmbTipoFalla = new System.Windows.Forms.ComboBox();
            this.LabelConceptomtto = new System.Windows.Forms.Label();
            this.cmbConcepto = new System.Windows.Forms.ComboBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblEstadoMtto = new System.Windows.Forms.Label();
            this.cmbEstadoMtto = new System.Windows.Forms.ComboBox();
            this.btnSalidaMtto = new System.Windows.Forms.Button();
            this.txtObservacionSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.Location = new System.Drawing.Point(156, 26);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(171, 25);
            this.lblMantenimiento.TabIndex = 4;
            this.lblMantenimiento.Text = "MANTENIMIENTO";
            this.lblMantenimiento.Click += new System.EventHandler(this.lblMantenimiento_Click);
            // 
            // txtNumMtto
            // 
            this.txtNumMtto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumMtto.Location = new System.Drawing.Point(197, 118);
            this.txtNumMtto.Name = "txtNumMtto";
            this.txtNumMtto.Size = new System.Drawing.Size(195, 29);
            this.txtNumMtto.TabIndex = 6;
            // 
            // lblNumeroMtto
            // 
            this.lblNumeroMtto.AutoSize = true;
            this.lblNumeroMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMtto.Location = new System.Drawing.Point(65, 121);
            this.lblNumeroMtto.Name = "lblNumeroMtto";
            this.lblNumeroMtto.Size = new System.Drawing.Size(74, 21);
            this.lblNumeroMtto.TabIndex = 5;
            this.lblNumeroMtto.Text = "Número:";
            // 
            // dtpFechaMtto
            // 
            this.dtpFechaMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMtto.Location = new System.Drawing.Point(197, 161);
            this.dtpFechaMtto.Name = "dtpFechaMtto";
            this.dtpFechaMtto.Size = new System.Drawing.Size(195, 25);
            this.dtpFechaMtto.TabIndex = 16;
            // 
            // lblFechaMtto
            // 
            this.lblFechaMtto.AutoSize = true;
            this.lblFechaMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMtto.Location = new System.Drawing.Point(66, 161);
            this.lblFechaMtto.Name = "lblFechaMtto";
            this.lblFechaMtto.Size = new System.Drawing.Size(56, 21);
            this.lblFechaMtto.TabIndex = 15;
            this.lblFechaMtto.Text = "Fecha:";
            // 
            // btnIngresoMtto
            // 
            this.btnIngresoMtto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIngresoMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoMtto.Location = new System.Drawing.Point(197, 291);
            this.btnIngresoMtto.Name = "btnIngresoMtto";
            this.btnIngresoMtto.Size = new System.Drawing.Size(98, 32);
            this.btnIngresoMtto.TabIndex = 20;
            this.btnIngresoMtto.Text = "INGRESO";
            this.btnIngresoMtto.UseVisualStyleBackColor = false;
            this.btnIngresoMtto.Click += new System.EventHandler(this.btnIngresoMtto_Click);
            // 
            // lblTipoFallaMtto
            // 
            this.lblTipoFallaMtto.AutoSize = true;
            this.lblTipoFallaMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFallaMtto.Location = new System.Drawing.Point(66, 202);
            this.lblTipoFallaMtto.Name = "lblTipoFallaMtto";
            this.lblTipoFallaMtto.Size = new System.Drawing.Size(104, 21);
            this.lblTipoFallaMtto.TabIndex = 18;
            this.lblTipoFallaMtto.Text = "Tipo de falla:";
            this.lblTipoFallaMtto.Click += new System.EventHandler(this.lblTipoFallaMtto_Click);
            // 
            // cmbTipoFalla
            // 
            this.cmbTipoFalla.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFalla.FormattingEnabled = true;
            this.cmbTipoFalla.Items.AddRange(new object[] {
            "Cable",
            "Microfono",
            "Balaca",
            "Boton",
            "Base",
            "Pitillo",
            "Tarjeta"});
            this.cmbTipoFalla.Location = new System.Drawing.Point(197, 202);
            this.cmbTipoFalla.Name = "cmbTipoFalla";
            this.cmbTipoFalla.Size = new System.Drawing.Size(195, 25);
            this.cmbTipoFalla.TabIndex = 19;
            this.cmbTipoFalla.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFalla_SelectedIndexChanged);
            // 
            // LabelConceptomtto
            // 
            this.LabelConceptomtto.AutoSize = true;
            this.LabelConceptomtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConceptomtto.Location = new System.Drawing.Point(66, 82);
            this.LabelConceptomtto.Name = "LabelConceptomtto";
            this.LabelConceptomtto.Size = new System.Drawing.Size(86, 21);
            this.LabelConceptomtto.TabIndex = 21;
            this.LabelConceptomtto.Text = "Concepto:";
            // 
            // cmbConcepto
            // 
            this.cmbConcepto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConcepto.FormattingEnabled = true;
            this.cmbConcepto.Items.AddRange(new object[] {
            "INGRESO",
            "SALIDA"});
            this.cmbConcepto.Location = new System.Drawing.Point(197, 78);
            this.cmbConcepto.Name = "cmbConcepto";
            this.cmbConcepto.Size = new System.Drawing.Size(195, 25);
            this.cmbConcepto.TabIndex = 22;
            this.cmbConcepto.SelectedIndexChanged += new System.EventHandler(this.cmbConcepto_SelectedIndexChanged);
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(64, 242);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(106, 21);
            this.lblObservacion.TabIndex = 25;
            this.lblObservacion.Text = "Observación:";
            this.lblObservacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(197, 245);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(195, 20);
            this.txtObservacion.TabIndex = 26;
            // 
            // lblEstadoMtto
            // 
            this.lblEstadoMtto.AutoSize = true;
            this.lblEstadoMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMtto.Location = new System.Drawing.Point(66, 202);
            this.lblEstadoMtto.Name = "lblEstadoMtto";
            this.lblEstadoMtto.Size = new System.Drawing.Size(63, 21);
            this.lblEstadoMtto.TabIndex = 27;
            this.lblEstadoMtto.Text = "Estado:";
            // 
            // cmbEstadoMtto
            // 
            this.cmbEstadoMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoMtto.FormattingEnabled = true;
            this.cmbEstadoMtto.Items.AddRange(new object[] {
            "Disponible",
            "Baja"});
            this.cmbEstadoMtto.Location = new System.Drawing.Point(197, 202);
            this.cmbEstadoMtto.Name = "cmbEstadoMtto";
            this.cmbEstadoMtto.Size = new System.Drawing.Size(195, 25);
            this.cmbEstadoMtto.TabIndex = 28;
            this.cmbEstadoMtto.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoMtto_SelectedIndexChanged);
            // 
            // btnSalidaMtto
            // 
            this.btnSalidaMtto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalidaMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaMtto.Location = new System.Drawing.Point(197, 317);
            this.btnSalidaMtto.Name = "btnSalidaMtto";
            this.btnSalidaMtto.Size = new System.Drawing.Size(98, 32);
            this.btnSalidaMtto.TabIndex = 29;
            this.btnSalidaMtto.Text = "SALIDA";
            this.btnSalidaMtto.UseVisualStyleBackColor = false;
            this.btnSalidaMtto.Click += new System.EventHandler(this.btnSalidaMtto_Click);
            // 
            // txtObservacionSalida
            // 
            this.txtObservacionSalida.Location = new System.Drawing.Point(197, 245);
            this.txtObservacionSalida.Name = "txtObservacionSalida";
            this.txtObservacionSalida.Size = new System.Drawing.Size(195, 20);
            this.txtObservacionSalida.TabIndex = 31;
            this.txtObservacionSalida.TextChanged += new System.EventHandler(this.txtObservacionSalida_TextChanged);
            // 
            // FormIngresomtto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 396);
            this.Controls.Add(this.txtObservacionSalida);
            this.Controls.Add(this.btnSalidaMtto);
            this.Controls.Add(this.cmbEstadoMtto);
            this.Controls.Add(this.lblEstadoMtto);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.cmbConcepto);
            this.Controls.Add(this.LabelConceptomtto);
            this.Controls.Add(this.btnIngresoMtto);
            this.Controls.Add(this.cmbTipoFalla);
            this.Controls.Add(this.lblTipoFallaMtto);
            this.Controls.Add(this.dtpFechaMtto);
            this.Controls.Add(this.lblFechaMtto);
            this.Controls.Add(this.txtNumMtto);
            this.Controls.Add(this.lblNumeroMtto);
            this.Controls.Add(this.lblMantenimiento);
            this.Name = "FormIngresomtto";
            this.Text = "FormIngresomtto";
            this.Load += new System.EventHandler(this.FormIngresomtto_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMantenimiento;
        private TextBox txtNumMtto;
        private Label lblNumeroMtto;
        private DateTimePicker dtpFechaMtto;
        private Label lblFechaMtto;
        private Button btnIngresoMtto;
        private Label lblTipoFallaMtto;
        private ComboBox cmbTipoFalla;
        private Label LabelConceptomtto;
        private ComboBox cmbConcepto;
        private Label lblObservacion;
        private TextBox txtObservacion;
        private Label lblEstadoMtto;
        private ComboBox cmbEstadoMtto;
        private Button btnSalidaMtto;
        private TextBox txtObservacionSalida;
    }
}