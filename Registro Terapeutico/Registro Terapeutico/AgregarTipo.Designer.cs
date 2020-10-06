namespace Registro_Terapeutico
{
    partial class AgregarTipo
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
            System.Windows.Forms.Label nombre_tipLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTipo));
            this.tipoTerapias = new Registro_Terapeutico.TipoTerapias();
            this.tipo_TerapiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_TerapiaTableAdapter = new Registro_Terapeutico.TipoTerapiasTableAdapters.Tipo_TerapiaTableAdapter();
            this.tableAdapterManager = new Registro_Terapeutico.TipoTerapiasTableAdapters.TableAdapterManager();
            this.tipo_TerapiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tipo_TerapiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombre_tipTextBox = new System.Windows.Forms.TextBox();
            this.tipo_TerapiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_tipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTerapias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TerapiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TerapiaBindingNavigator)).BeginInit();
            this.tipo_TerapiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TerapiaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_tipLabel
            // 
            nombre_tipLabel.AutoSize = true;
            nombre_tipLabel.Location = new System.Drawing.Point(44, 49);
            nombre_tipLabel.Name = "nombre_tipLabel";
            nombre_tipLabel.Size = new System.Drawing.Size(31, 13);
            nombre_tipLabel.TabIndex = 1;
            nombre_tipLabel.Text = "Tipo:";
            nombre_tipLabel.Click += new System.EventHandler(this.Nombre_tipLabel_Click);
            // 
            // tipoTerapias
            // 
            this.tipoTerapias.DataSetName = "TipoTerapias";
            this.tipoTerapias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_TerapiaBindingSource
            // 
            this.tipo_TerapiaBindingSource.DataMember = "Tipo_Terapia";
            this.tipo_TerapiaBindingSource.DataSource = this.tipoTerapias;
            // 
            // tipo_TerapiaTableAdapter
            // 
            this.tipo_TerapiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tipo_TerapiaTableAdapter = this.tipo_TerapiaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Registro_Terapeutico.TipoTerapiasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tipo_TerapiaBindingNavigator
            // 
            this.tipo_TerapiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipo_TerapiaBindingNavigator.BindingSource = this.tipo_TerapiaBindingSource;
            this.tipo_TerapiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipo_TerapiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipo_TerapiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipo_TerapiaBindingNavigatorSaveItem});
            this.tipo_TerapiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipo_TerapiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipo_TerapiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipo_TerapiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipo_TerapiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipo_TerapiaBindingNavigator.Name = "tipo_TerapiaBindingNavigator";
            this.tipo_TerapiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipo_TerapiaBindingNavigator.Size = new System.Drawing.Size(309, 25);
            this.tipo_TerapiaBindingNavigator.TabIndex = 0;
            this.tipo_TerapiaBindingNavigator.Text = "bindingNavigator1";
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
            // tipo_TerapiaBindingNavigatorSaveItem
            // 
            this.tipo_TerapiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipo_TerapiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipo_TerapiaBindingNavigatorSaveItem.Image")));
            this.tipo_TerapiaBindingNavigatorSaveItem.Name = "tipo_TerapiaBindingNavigatorSaveItem";
            this.tipo_TerapiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tipo_TerapiaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tipo_TerapiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.Tipo_TerapiaBindingNavigatorSaveItem_Click);
            // 
            // nombre_tipTextBox
            // 
            this.nombre_tipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipo_TerapiaBindingSource, "nombre_tip", true));
            this.nombre_tipTextBox.Location = new System.Drawing.Point(109, 46);
            this.nombre_tipTextBox.Name = "nombre_tipTextBox";
            this.nombre_tipTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_tipTextBox.TabIndex = 2;
            this.nombre_tipTextBox.TextChanged += new System.EventHandler(this.Nombre_tipTextBox_TextChanged);
            // 
            // tipo_TerapiaDataGridView
            // 
            this.tipo_TerapiaDataGridView.AutoGenerateColumns = false;
            this.tipo_TerapiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipo_TerapiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tipo_TerapiaDataGridView.DataSource = this.tipo_TerapiaBindingSource;
            this.tipo_TerapiaDataGridView.Location = new System.Drawing.Point(21, 89);
            this.tipo_TerapiaDataGridView.Name = "tipo_TerapiaDataGridView";
            this.tipo_TerapiaDataGridView.Size = new System.Drawing.Size(264, 61);
            this.tipo_TerapiaDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo_tip";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo_tip";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_tip";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_tip";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // AgregarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 210);
            this.Controls.Add(this.tipo_TerapiaDataGridView);
            this.Controls.Add(nombre_tipLabel);
            this.Controls.Add(this.nombre_tipTextBox);
            this.Controls.Add(this.tipo_TerapiaBindingNavigator);
            this.Name = "AgregarTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarTipo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarTipo_FormClosing);
            this.Load += new System.EventHandler(this.AgregarTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoTerapias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TerapiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TerapiaBindingNavigator)).EndInit();
            this.tipo_TerapiaBindingNavigator.ResumeLayout(false);
            this.tipo_TerapiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TerapiaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TipoTerapias tipoTerapias;
        private System.Windows.Forms.BindingSource tipo_TerapiaBindingSource;
        private TipoTerapiasTableAdapters.Tipo_TerapiaTableAdapter tipo_TerapiaTableAdapter;
        private TipoTerapiasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipo_TerapiaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipo_TerapiaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombre_tipTextBox;
        private System.Windows.Forms.DataGridView tipo_TerapiaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}