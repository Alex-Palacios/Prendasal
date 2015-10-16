namespace PrendaSAL.Catalogos
{
    partial class ArticulosListForm
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
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tblArticulos = new System.Windows.Forms.DataGridView();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listCategorias = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.ToolTipText = "Nuevo Cliente";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.ToolTipText = "Editar Informacion Cliente";
            this.btnEditar.Click += new System.EventHandler(this.EDITAR);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::PrendaSAL.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.ToolTipText = "Eliminar Cliente";
            this.btnEliminar.Click += new System.EventHandler(this.ELIMINAR);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = global::PrendaSAL.Properties.Resources.help;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(23, 22);
            this.btnAyuda.ToolTipText = "Mostrar Ayuda";
            this.btnAyuda.Click += new System.EventHandler(this.AYUDA);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(494, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tblArticulos
            // 
            this.tblArticulos.AllowUserToAddRows = false;
            this.tblArticulos.AllowUserToDeleteRows = false;
            this.tblArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO});
            this.tblArticulos.Location = new System.Drawing.Point(232, 28);
            this.tblArticulos.Name = "tblArticulos";
            this.tblArticulos.ReadOnly = true;
            this.tblArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblArticulos.Size = new System.Drawing.Size(242, 329);
            this.tblArticulos.TabIndex = 10;
            this.tblArticulos.Click += new System.EventHandler(this.tblArticulos_Click);
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "COD_ITEM";
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.Width = 150;
            // 
            // listCategorias
            // 
            this.listCategorias.FormattingEnabled = true;
            this.listCategorias.Location = new System.Drawing.Point(23, 102);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(169, 95);
            this.listCategorias.TabIndex = 13;
            this.listCategorias.SelectedIndexChanged += new System.EventHandler(this.listCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CATEGORIA";
            // 
            // ArticulosListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCategorias);
            this.Controls.Add(this.tblArticulos);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "ArticulosListForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LISTA DE ARTICULOS";
            this.Load += new System.EventHandler(this.ArticulosListForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView tblArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.ListBox listCategorias;
        private System.Windows.Forms.Label label1;

    }
}