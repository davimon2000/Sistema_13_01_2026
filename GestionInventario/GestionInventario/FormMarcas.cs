using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class FormMarcas : Form
    {
        public FormRegistro FormRegistroReferencia { get; set; }

        private static FormMarcas instancia = null;
        public static FormMarcas ventana_unica(FormRegistro referenciaRegistro)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormMarcas();
                instancia.FormRegistroReferencia = referenciaRegistro;
                //return instancia;
            }
            return instancia;
        }
        //private FormRegistro formRegistro;

        //public FormMarcas(FormRegistro formRegistro)
        //{
        //    InitializeComponent();
        //    this.formRegistro = formRegistro;
        //}


        public FormMarcas()
        {



            InitializeComponent();
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marcasDS);

            FormRegistroReferencia?.RecargarDatos();

            // Llama a la recarga de datos en el otro formulario
            //formRegistro?.RecargarDatos();

        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marcasDS.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.marcasDS.Marcas);

        }
    }
}
