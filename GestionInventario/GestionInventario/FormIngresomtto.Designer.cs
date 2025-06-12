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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTipoFallaMtto = new System.Windows.Forms.Label();
            this.cmbTipoFalla = new System.Windows.Forms.ComboBox();
            this.LabelConceptomtto = new System.Windows.Forms.Label();
            this.cmbConcepto = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblEstadoMtto = new System.Windows.Forms.Label();
            this.cmbEstadoMtto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.Location = new System.Drawing.Point(140, 30);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(171, 25);
            this.lblMantenimiento.TabIndex = 4;
            this.lblMantenimiento.Text = "MANTENIMIENTO";
            // 
            // txtNumMtto
            // 
            this.txtNumMtto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumMtto.Location = new System.Drawing.Point(197, 118);
            this.txtNumMtto.Name = "txtNumMtto";
            this.txtNumMtto.Size = new System.Drawing.Size(169, 29);
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
            this.dtpFechaMtto.Size = new System.Drawing.Size(169, 25);
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(100, 342);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 32);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "INGRESO";
            this.btnRegistrar.UseVisualStyleBackColor = false;
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
            // 
            // cmbTipoFalla
            // 
            this.cmbTipoFalla.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFalla.FormattingEnabled = true;
            this.cmbTipoFalla.Items.AddRange(new object[] {
            "Daño físico",
            "Cableado",
            "Otra"});
            this.cmbTipoFalla.Location = new System.Drawing.Point(197, 202);
            this.cmbTipoFalla.Name = "cmbTipoFalla";
            this.cmbTipoFalla.Size = new System.Drawing.Size(169, 25);
            this.cmbTipoFalla.TabIndex = 19;
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
            this.cmbConcepto.Size = new System.Drawing.Size(169, 25);
            this.cmbConcepto.TabIndex = 22;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.Location = new System.Drawing.Point(66, 280);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(127, 21);
            this.lblTecnico.TabIndex = 23;
            this.lblTecnico.Text = "Técnico a cargo:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Martin Ramirez Pascuas"});
            this.comboBox2.Location = new System.Drawing.Point(197, 280);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 25);
            this.comboBox2.TabIndex = 24;
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
            this.txtObservacion.Size = new System.Drawing.Size(169, 20);
            this.txtObservacion.TabIndex = 26;
            // 
            // lblEstadoMtto
            // 
            this.lblEstadoMtto.AutoSize = true;
            this.lblEstadoMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMtto.Location = new System.Drawing.Point(384, 202);
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
            "Buena",
            "Restaurado",
            "Recuperado",
            "Baja"});
            this.cmbEstadoMtto.Location = new System.Drawing.Point(453, 202);
            this.cmbEstadoMtto.Name = "cmbEstadoMtto";
            this.cmbEstadoMtto.Size = new System.Drawing.Size(169, 25);
            this.cmbEstadoMtto.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "SALIDA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormIngresomtto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbEstadoMtto);
            this.Controls.Add(this.lblEstadoMtto);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.cmbConcepto);
            this.Controls.Add(this.LabelConceptomtto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbTipoFalla);
            this.Controls.Add(this.lblTipoFallaMtto);
            this.Controls.Add(this.dtpFechaMtto);
            this.Controls.Add(this.lblFechaMtto);
            this.Controls.Add(this.txtNumMtto);
            this.Controls.Add(this.lblNumeroMtto);
            this.Controls.Add(this.lblMantenimiento);
            this.Name = "FormIngresomtto";
            this.Text = "FormIngresomtto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMantenimiento;
        private TextBox txtNumMtto;
        private Label lblNumeroMtto;
        private DateTimePicker dtpFechaMtto;
        private Label lblFechaMtto;
        private Button btnRegistrar;
        private Label lblTipoFallaMtto;
        private ComboBox cmbTipoFalla;
        private Label LabelConceptomtto;
        private ComboBox cmbConcepto;
        private Label lblTecnico;
        private ComboBox comboBox2;
        private Label lblObservacion;
        private TextBox txtObservacion;
        private Label lblEstadoMtto;
        private ComboBox cmbEstadoMtto;
        private Button button1;
    }
}