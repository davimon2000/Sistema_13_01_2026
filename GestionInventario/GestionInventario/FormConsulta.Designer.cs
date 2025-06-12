using System.Drawing;
using System.Windows.Forms;
namespace GestionInventario
{
    partial class FormConsulta
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
            lblRegistro = new Label();
            txtNumConsulta = new TextBox();
            lblNumeroConsulta = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblRegistro.ImeMode = ImeMode.NoControl;
            lblRegistro.Location = new Point(178, 34);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(106, 25);
            lblRegistro.TabIndex = 7;
            lblRegistro.Text = "CONSULTA";
            // 
            // txtNumConsulta
            // 
            txtNumConsulta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNumConsulta.Location = new Point(136, 79);
            txtNumConsulta.Name = "txtNumConsulta";
            txtNumConsulta.Size = new Size(202, 29);
            txtNumConsulta.TabIndex = 26;
            // 
            // lblNumeroConsulta
            // 
            lblNumeroConsulta.AutoSize = true;
            lblNumeroConsulta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNumeroConsulta.ImeMode = ImeMode.NoControl;
            lblNumeroConsulta.Location = new Point(22, 79);
            lblNumeroConsulta.Name = "lblNumeroConsulta";
            lblNumeroConsulta.Size = new Size(74, 21);
            lblNumeroConsulta.TabIndex = 25;
            lblNumeroConsulta.Text = "Número:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(360, 81);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 27);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 289);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumConsulta);
            Controls.Add(lblNumeroConsulta);
            Controls.Add(lblRegistro);
            Name = "FormConsulta";
            Text = "FormConsulta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private TextBox txtNumConsulta;
        private Label lblNumeroConsulta;
        private Button btnBuscar;
    }
}