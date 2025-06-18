using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionInventario
{
    partial class FormMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.picIndicadores = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEstado = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnIngresomtto = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenuVertical.Controls.Add(this.picIndicadores);
            this.pnlMenuVertical.Controls.Add(this.panel7);
            this.pnlMenuVertical.Controls.Add(this.btnEstado);
            this.pnlMenuVertical.Controls.Add(this.pictureBox6);
            this.pnlMenuVertical.Controls.Add(this.panel5);
            this.pnlMenuVertical.Controls.Add(this.btnAnalisis);
            this.pnlMenuVertical.Controls.Add(this.pictureBox5);
            this.pnlMenuVertical.Controls.Add(this.panel4);
            this.pnlMenuVertical.Controls.Add(this.btnConsulta);
            this.pnlMenuVertical.Controls.Add(this.pictureBox4);
            this.pnlMenuVertical.Controls.Add(this.panel3);
            this.pnlMenuVertical.Controls.Add(this.btnSalida);
            this.pnlMenuVertical.Controls.Add(this.panel2);
            this.pnlMenuVertical.Controls.Add(this.pictureBox2);
            this.pnlMenuVertical.Controls.Add(this.panel1);
            this.pnlMenuVertical.Controls.Add(this.pictureBox1);
            this.pnlMenuVertical.Controls.Add(this.btnRegistro);
            this.pnlMenuVertical.Controls.Add(this.pictureBox3);
            this.pnlMenuVertical.Controls.Add(this.btnIngresomtto);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 26);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(189, 537);
            this.pnlMenuVertical.TabIndex = 2;
            // 
            // picIndicadores
            // 
            this.picIndicadores.Image = ((System.Drawing.Image)(resources.GetObject("picIndicadores.Image")));
            this.picIndicadores.Location = new System.Drawing.Point(11, 249);
            this.picIndicadores.Name = "picIndicadores";
            this.picIndicadores.Size = new System.Drawing.Size(24, 28);
            this.picIndicadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicadores.TabIndex = 20;
            this.picIndicadores.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(1, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 28);
            this.panel7.TabIndex = 18;
            // 
            // btnEstado
            // 
            this.btnEstado.FlatAppearance.BorderSize = 0;
            this.btnEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.Location = new System.Drawing.Point(4, 249);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(186, 28);
            this.btnEstado.TabIndex = 19;
            this.btnEstado.Text = "ESTADO";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 215);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 28);
            this.panel5.TabIndex = 12;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisis.ForeColor = System.Drawing.Color.White;
            this.btnAnalisis.Location = new System.Drawing.Point(3, 215);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(186, 28);
            this.btnAnalisis.TabIndex = 13;
            this.btnAnalisis.Text = "ANÁLISIS";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 182);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 28);
            this.panel4.TabIndex = 5;
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(3, 182);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(186, 28);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "CONSULTA";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 28);
            this.panel3.TabIndex = 4;
            // 
            // btnSalida
            // 
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(3, 149);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(186, 28);
            this.btnSalida.TabIndex = 8;
            this.btnSalida.Text = "ASIGNACIÓN";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(1, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 28);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(1, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 28);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(3, 82);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(186, 28);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnIngresomtto
            // 
            this.btnIngresomtto.FlatAppearance.BorderSize = 0;
            this.btnIngresomtto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnIngresomtto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresomtto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresomtto.ForeColor = System.Drawing.Color.White;
            this.btnIngresomtto.Location = new System.Drawing.Point(3, 115);
            this.btnIngresomtto.Name = "btnIngresomtto";
            this.btnIngresomtto.Size = new System.Drawing.Size(186, 28);
            this.btnIngresomtto.TabIndex = 6;
            this.btnIngresomtto.Text = "MANTENIMIENTO";
            this.btnIngresomtto.UseVisualStyleBackColor = true;
            this.btnIngresomtto.Click += new System.EventHandler(this.btnIngresomtto_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1057, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(21, 22);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1057, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(21, 23);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1089, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1019, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 19);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.pnlBarraTitulo.Controls.Add(this.btnRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1114, 26);
            this.pnlBarraTitulo.TabIndex = 1;
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 563);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraTitulo);
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIndicadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlMenuVertical;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button btnIngresomtto;
        private Button btnRegistro;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button btnSalida;
        private Panel panel4;
        private Button btnConsulta;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Button btnAnalisis;
        private PictureBox picIndicadores;
        private Panel panel7;
        private Button btnEstado;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel pnlBarraTitulo;
    }
}
