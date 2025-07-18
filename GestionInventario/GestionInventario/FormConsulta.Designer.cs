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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtNumConsulta = new System.Windows.Forms.TextBox();
            this.lblNumeroConsulta = new System.Windows.Forms.Label();
            this.activosViewDS = new GestionInventario.ActivosViewDS();
            this.activosViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosViewTableAdapter = new GestionInventario.ActivosViewDSTableAdapters.ActivosViewTableAdapter();
            this.tableAdapterManager = new GestionInventario.ActivosViewDSTableAdapters.TableAdapterManager();
            this.activosViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activosViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activosViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroConsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewBindingNavigator)).BeginInit();
            this.activosViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRegistro.Location = new System.Drawing.Point(269, 36);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(106, 25);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.Text = "CONSULTA";
            // 
            // txtNumConsulta
            // 
            this.txtNumConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNumConsulta.Location = new System.Drawing.Point(463, 76);
            this.txtNumConsulta.Name = "txtNumConsulta";
            this.txtNumConsulta.Size = new System.Drawing.Size(174, 29);
            this.txtNumConsulta.TabIndex = 26;
            this.txtNumConsulta.TextChanged += new System.EventHandler(this.txtNumConsulta_TextChanged);
            // 
            // lblNumeroConsulta
            // 
            this.lblNumeroConsulta.AutoSize = true;
            this.lblNumeroConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumeroConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumeroConsulta.Location = new System.Drawing.Point(340, 79);
            this.lblNumeroConsulta.Name = "lblNumeroConsulta";
            this.lblNumeroConsulta.Size = new System.Drawing.Size(117, 21);
            this.lblNumeroConsulta.TabIndex = 25;
            this.lblNumeroConsulta.Text = "Serial o Marca:";
            this.lblNumeroConsulta.Click += new System.EventHandler(this.lblNumeroConsulta_Click);
            // 
            // activosViewDS
            // 
            this.activosViewDS.DataSetName = "ActivosViewDS";
            this.activosViewDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activosViewBindingSource
            // 
            this.activosViewBindingSource.DataMember = "ActivosView";
            this.activosViewBindingSource.DataSource = this.activosViewDS;
            // 
            // activosViewTableAdapter
            // 
            this.activosViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = GestionInventario.ActivosViewDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // activosViewBindingNavigator
            // 
            this.activosViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activosViewBindingNavigator.BindingSource = this.activosViewBindingSource;
            this.activosViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activosViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activosViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.activosViewBindingNavigatorSaveItem});
            this.activosViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activosViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activosViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activosViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activosViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activosViewBindingNavigator.Name = "activosViewBindingNavigator";
            this.activosViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activosViewBindingNavigator.Size = new System.Drawing.Size(648, 25);
            this.activosViewBindingNavigator.TabIndex = 28;
            this.activosViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // activosViewBindingNavigatorSaveItem
            // 
            this.activosViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activosViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activosViewBindingNavigatorSaveItem.Image")));
            this.activosViewBindingNavigatorSaveItem.Name = "activosViewBindingNavigatorSaveItem";
            this.activosViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.activosViewBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activosViewDataGridView
            // 
            this.activosViewDataGridView.AutoGenerateColumns = false;
            this.activosViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activosViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.activosViewDataGridView.DataSource = this.activosViewBindingSource;
            this.activosViewDataGridView.Location = new System.Drawing.Point(49, 127);
            this.activosViewDataGridView.Name = "activosViewDataGridView";
            this.activosViewDataGridView.Size = new System.Drawing.Size(566, 102);
            this.activosViewDataGridView.TabIndex = 28;
            this.activosViewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activosViewDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodInterno";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodInterno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Serial";
            this.dataGridViewTextBoxColumn2.HeaderText = "Serial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaCompra";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaCompra";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaRegistro";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaRegistro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Número:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumeroConsulta
            // 
            this.txtNumeroConsulta.Location = new System.Drawing.Point(119, 82);
            this.txtNumeroConsulta.Name = "txtNumeroConsulta";
            this.txtNumeroConsulta.Size = new System.Drawing.Size(197, 20);
            this.txtNumeroConsulta.TabIndex = 30;
            this.txtNumeroConsulta.TextChanged += new System.EventHandler(this.txtNumeroConsulta_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "EXPORTAR EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumeroConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activosViewDataGridView);
            this.Controls.Add(this.activosViewBindingNavigator);
            this.Controls.Add(this.txtNumConsulta);
            this.Controls.Add(this.lblNumeroConsulta);
            this.Controls.Add(this.lblRegistro);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosViewDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewBindingNavigator)).EndInit();
            this.activosViewBindingNavigator.ResumeLayout(false);
            this.activosViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegistro;
        private TextBox txtNumConsulta;
        private Label lblNumeroConsulta;
        private ActivosViewDS activosViewDS;
        private BindingSource activosViewBindingSource;
        private ActivosViewDSTableAdapters.ActivosViewTableAdapter activosViewTableAdapter;
        private ActivosViewDSTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator activosViewBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton activosViewBindingNavigatorSaveItem;
        private DataGridView activosViewDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label1;
        private TextBox txtNumeroConsulta;
        private Button button1;
    }
}