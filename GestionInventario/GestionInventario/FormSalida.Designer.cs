namespace GestionInventario
{
    partial class FormSalida
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
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.txtNumAsig = new System.Windows.Forms.TextBox();
            this.lblNumeroAsig = new System.Windows.Forms.Label();
            this.dtpFechaAsig = new System.Windows.Forms.DateTimePicker();
            this.lblFechaMtto = new System.Windows.Forms.Label();
            this.cmbSedeAsig = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresoMtto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacion.Location = new System.Drawing.Point(163, 34);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(129, 25);
            this.lblAsignacion.TabIndex = 5;
            this.lblAsignacion.Text = "ASIGNACIÓN";
            // 
            // txtNumAsig
            // 
            this.txtNumAsig.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumAsig.Location = new System.Drawing.Point(198, 80);
            this.txtNumAsig.Name = "txtNumAsig";
            this.txtNumAsig.Size = new System.Drawing.Size(195, 29);
            this.txtNumAsig.TabIndex = 8;
            // 
            // lblNumeroAsig
            // 
            this.lblNumeroAsig.AutoSize = true;
            this.lblNumeroAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAsig.Location = new System.Drawing.Point(66, 83);
            this.lblNumeroAsig.Name = "lblNumeroAsig";
            this.lblNumeroAsig.Size = new System.Drawing.Size(74, 21);
            this.lblNumeroAsig.TabIndex = 7;
            this.lblNumeroAsig.Text = "Número:";
            // 
            // dtpFechaAsig
            // 
            this.dtpFechaAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAsig.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAsig.Location = new System.Drawing.Point(198, 129);
            this.dtpFechaAsig.Name = "dtpFechaAsig";
            this.dtpFechaAsig.Size = new System.Drawing.Size(195, 25);
            this.dtpFechaAsig.TabIndex = 18;
            // 
            // lblFechaMtto
            // 
            this.lblFechaMtto.AutoSize = true;
            this.lblFechaMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMtto.Location = new System.Drawing.Point(67, 129);
            this.lblFechaMtto.Name = "lblFechaMtto";
            this.lblFechaMtto.Size = new System.Drawing.Size(56, 21);
            this.lblFechaMtto.TabIndex = 17;
            this.lblFechaMtto.Text = "Fecha:";
            // 
            // cmbSedeAsig
            // 
            this.cmbSedeAsig.FormattingEnabled = true;
            this.cmbSedeAsig.Items.AddRange(new object[] {
            "Campin",
            "Dorado Plaza",
            "Arboleda",
            "Panamericana",
            "Pereira"});
            this.cmbSedeAsig.Location = new System.Drawing.Point(198, 170);
            this.cmbSedeAsig.Name = "cmbSedeAsig";
            this.cmbSedeAsig.Size = new System.Drawing.Size(195, 21);
            this.cmbSedeAsig.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sede:";
            // 
            // btnIngresoMtto
            // 
            this.btnIngresoMtto.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnIngresoMtto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoMtto.Location = new System.Drawing.Point(182, 220);
            this.btnIngresoMtto.Name = "btnIngresoMtto";
            this.btnIngresoMtto.Size = new System.Drawing.Size(98, 32);
            this.btnIngresoMtto.TabIndex = 23;
            this.btnIngresoMtto.Text = "ASIGNAR";
            this.btnIngresoMtto.UseVisualStyleBackColor = false;
            this.btnIngresoMtto.Click += new System.EventHandler(this.btnIngresoMtto_Click);
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.btnIngresoMtto);
            this.Controls.Add(this.cmbSedeAsig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaAsig);
            this.Controls.Add(this.lblFechaMtto);
            this.Controls.Add(this.txtNumAsig);
            this.Controls.Add(this.lblNumeroAsig);
            this.Controls.Add(this.lblAsignacion);
            this.Name = "FormSalida";
            this.Text = "FormSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.TextBox txtNumAsig;
        private System.Windows.Forms.Label lblNumeroAsig;
        private System.Windows.Forms.DateTimePicker dtpFechaAsig;
        private System.Windows.Forms.Label lblFechaMtto;
        private System.Windows.Forms.ComboBox cmbSedeAsig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresoMtto;
    }
}