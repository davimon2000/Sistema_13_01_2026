namespace GestionInventario
{
    partial class FormVistaEjemplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaEjemplo));
            this.registroActivosDS = new GestionInventario.RegistroActivosDS();
            this.registroActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroActivosTableAdapter = new GestionInventario.RegistroActivosDSTableAdapters.RegistroActivosTableAdapter();
            this.tableAdapterManager = new GestionInventario.RegistroActivosDSTableAdapters.TableAdapterManager();
            this.registroActivosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.registroActivosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registroActivosDataGridView = new System.Windows.Forms.DataGridView();
            this.inventarioActivosDataSet = new GestionInventario.InventarioActivosDataSet();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new GestionInventario.InventarioActivosDataSetTableAdapters.MarcasTableAdapter();
            this.inventarioActivosDataSet2 = new GestionInventario.InventarioActivosDataSet2();
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter1 = new GestionInventario.InventarioActivosDataSet2TableAdapters.MarcasTableAdapter();
            this.marcasDS = new GestionInventario.MarcasDS();
            this.marcasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter2 = new GestionInventario.MarcasDSTableAdapters.MarcasTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingNavigator)).BeginInit();
            this.registroActivosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // registroActivosDS
            // 
            this.registroActivosDS.DataSetName = "RegistroActivosDS";
            this.registroActivosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroActivosBindingSource
            // 
            this.registroActivosBindingSource.DataMember = "RegistroActivos";
            this.registroActivosBindingSource.DataSource = this.registroActivosDS;
            // 
            // registroActivosTableAdapter
            // 
            this.registroActivosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RegistroActivosTableAdapter = this.registroActivosTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestionInventario.RegistroActivosDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registroActivosBindingNavigator
            // 
            this.registroActivosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registroActivosBindingNavigator.BindingSource = this.registroActivosBindingSource;
            this.registroActivosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registroActivosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registroActivosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registroActivosBindingNavigatorSaveItem});
            this.registroActivosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registroActivosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registroActivosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registroActivosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registroActivosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registroActivosBindingNavigator.Name = "registroActivosBindingNavigator";
            this.registroActivosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registroActivosBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.registroActivosBindingNavigator.TabIndex = 0;
            this.registroActivosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // registroActivosBindingNavigatorSaveItem
            // 
            this.registroActivosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registroActivosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registroActivosBindingNavigatorSaveItem.Image")));
            this.registroActivosBindingNavigatorSaveItem.Name = "registroActivosBindingNavigatorSaveItem";
            this.registroActivosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.registroActivosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.registroActivosBindingNavigatorSaveItem.Click += new System.EventHandler(this.registroActivosBindingNavigatorSaveItem_Click);
            // 
            // registroActivosDataGridView
            // 
            this.registroActivosDataGridView.AutoGenerateColumns = false;
            this.registroActivosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroActivosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.registroActivosDataGridView.DataSource = this.registroActivosBindingSource;
            this.registroActivosDataGridView.Location = new System.Drawing.Point(52, 102);
            this.registroActivosDataGridView.Name = "registroActivosDataGridView";
            this.registroActivosDataGridView.Size = new System.Drawing.Size(695, 220);
            this.registroActivosDataGridView.TabIndex = 1;
            // 
            // inventarioActivosDataSet
            // 
            this.inventarioActivosDataSet.DataSetName = "InventarioActivosDataSet";
            this.inventarioActivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.inventarioActivosDataSet;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioActivosDataSet2
            // 
            this.inventarioActivosDataSet2.DataSetName = "InventarioActivosDataSet2";
            this.inventarioActivosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "Marcas";
            this.marcasBindingSource1.DataSource = this.inventarioActivosDataSet2;
            // 
            // marcasTableAdapter1
            // 
            this.marcasTableAdapter1.ClearBeforeFill = true;
            // 
            // marcasDS
            // 
            this.marcasDS.DataSetName = "MarcasDS";
            this.marcasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource2
            // 
            this.marcasBindingSource2.DataMember = "Marcas";
            this.marcasBindingSource2.DataSource = this.marcasDS;
            // 
            // marcasTableAdapter2
            // 
            this.marcasTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodInterno";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodInterno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Serial";
            this.dataGridViewTextBoxColumn3.HeaderText = "Serial";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn4.DataSource = this.marcasBindingSource2;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Marca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaCompra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaRegistro";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaRegistro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EstadoRegistro";
            this.dataGridViewTextBoxColumn7.HeaderText = "EstadoRegistro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FormVistaEjemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registroActivosDataGridView);
            this.Controls.Add(this.registroActivosBindingNavigator);
            this.Name = "FormVistaEjemplo";
            this.Text = "FormVistaEjemplo";
            this.Load += new System.EventHandler(this.FormVistaEjemplo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingNavigator)).EndInit();
            this.registroActivosBindingNavigator.ResumeLayout(false);
            this.registroActivosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegistroActivosDS registroActivosDS;
        private System.Windows.Forms.BindingSource registroActivosBindingSource;
        private RegistroActivosDSTableAdapters.RegistroActivosTableAdapter registroActivosTableAdapter;
        private RegistroActivosDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registroActivosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton registroActivosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView registroActivosDataGridView;
        private InventarioActivosDataSet inventarioActivosDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private InventarioActivosDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private InventarioActivosDataSet2 inventarioActivosDataSet2;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private InventarioActivosDataSet2TableAdapters.MarcasTableAdapter marcasTableAdapter1;
        private MarcasDS marcasDS;
        private System.Windows.Forms.BindingSource marcasBindingSource2;
        private MarcasDSTableAdapters.MarcasTableAdapter marcasTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}