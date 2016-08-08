namespace PrendaSAL.Reportes
{
    partial class RInvVentaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbNUM_TOTAL = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.cbxTIPO = new System.Windows.Forms.ComboBox();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.tblINVENTARIO = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BODEGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.rdbARTICULO = new System.Windows.Forms.RadioButton();
            this.rdbORO = new System.Windows.Forms.RadioButton();
            this.txtCONTRATO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblINVENTARIO)).BeginInit();
            this.opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNUM_TOTAL
            // 
            this.lbNUM_TOTAL.AutoSize = true;
            this.lbNUM_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNUM_TOTAL.Location = new System.Drawing.Point(820, 459);
            this.lbNUM_TOTAL.Name = "lbNUM_TOTAL";
            this.lbNUM_TOTAL.Size = new System.Drawing.Size(88, 13);
            this.lbNUM_TOTAL.TabIndex = 106;
            this.lbNUM_TOTAL.Text = "0 ARTICULOS";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::PrendaSAL.Properties.Resources.search;
            this.btnBUSCAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBUSCAR.Location = new System.Drawing.Point(834, 28);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(94, 71);
            this.btnBUSCAR.TabIndex = 105;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // cbxTIPO
            // 
            this.cbxTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPO.FormattingEnabled = true;
            this.cbxTIPO.Location = new System.Drawing.Point(227, 78);
            this.cbxTIPO.Name = "cbxTIPO";
            this.cbxTIPO.Size = new System.Drawing.Size(122, 21);
            this.cbxTIPO.TabIndex = 104;
            this.cbxTIPO.TextChanged += new System.EventHandler(this.cbxARTICULO_TextChanged);
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(611, 33);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 102;
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(10, 78);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(152, 23);
            this.txtCODIGO.TabIndex = 100;
            this.txtCODIGO.TextChanged += new System.EventHandler(this.txtCODIGO_TextChanged);
            // 
            // tblINVENTARIO
            // 
            this.tblINVENTARIO.AllowUserToAddRows = false;
            this.tblINVENTARIO.AllowUserToDeleteRows = false;
            this.tblINVENTARIO.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblINVENTARIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.CANTIDAD,
            this.TIPO,
            this.MARCA,
            this.DESCRIPCION,
            this.PRECIO,
            this.BODEGA,
            this.NOTA});
            this.tblINVENTARIO.Location = new System.Drawing.Point(10, 105);
            this.tblINVENTARIO.MultiSelect = false;
            this.tblINVENTARIO.Name = "tblINVENTARIO";
            this.tblINVENTARIO.ReadOnly = true;
            this.tblINVENTARIO.RowHeadersVisible = false;
            this.tblINVENTARIO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblINVENTARIO.Size = new System.Drawing.Size(918, 329);
            this.tblINVENTARIO.TabIndex = 98;
            this.tblINVENTARIO.DataSourceChanged += new System.EventHandler(this.tblINVENTARIO_DataSourceChanged);
            this.tblINVENTARIO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblINVENTARIO_CellClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO.Width = 150;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle9.Format = "N1";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle9;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD.Width = 70;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            this.MARCA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 200;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            dataGridViewCellStyle10.Format = "C2";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle10;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO.Width = 80;
            // 
            // BODEGA
            // 
            this.BODEGA.DataPropertyName = "BODEGA";
            this.BODEGA.HeaderText = "BODEGA";
            this.BODEGA.Name = "BODEGA";
            this.BODEGA.ReadOnly = true;
            this.BODEGA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BODEGA.Width = 60;
            // 
            // NOTA
            // 
            this.NOTA.DataPropertyName = "NOTA";
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.ReadOnly = true;
            this.NOTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnExportExcel,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(944, 25);
            this.opciones.TabIndex = 150;
            this.opciones.Text = "toolStrip1";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.EDITAR_ARTICULO);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportExcel.Image = global::PrendaSAL.Properties.Resources.excel;
            this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExportExcel.Text = "Exportar";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = global::PrendaSAL.Properties.Resources.help;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(23, 22);
            this.btnAyuda.ToolTipText = "Ayuda";
            // 
            // rdbARTICULO
            // 
            this.rdbARTICULO.AutoSize = true;
            this.rdbARTICULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdbARTICULO.Location = new System.Drawing.Point(432, 33);
            this.rdbARTICULO.Name = "rdbARTICULO";
            this.rdbARTICULO.Size = new System.Drawing.Size(165, 17);
            this.rdbARTICULO.TabIndex = 151;
            this.rdbARTICULO.TabStop = true;
            this.rdbARTICULO.Text = "ARTICULO   SUCURSAL";
            this.rdbARTICULO.UseVisualStyleBackColor = true;
            this.rdbARTICULO.CheckedChanged += new System.EventHandler(this.rdbARTICULO_CheckedChanged);
            // 
            // rdbORO
            // 
            this.rdbORO.AutoSize = true;
            this.rdbORO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdbORO.Location = new System.Drawing.Point(432, 66);
            this.rdbORO.Name = "rdbORO";
            this.rdbORO.Size = new System.Drawing.Size(168, 17);
            this.rdbORO.TabIndex = 152;
            this.rdbORO.TabStop = true;
            this.rdbORO.Text = "ORO            CONTRATO";
            this.rdbORO.UseVisualStyleBackColor = true;
            this.rdbORO.CheckedChanged += new System.EventHandler(this.rdbORO_CheckedChanged);
            // 
            // txtCONTRATO
            // 
            this.txtCONTRATO.Location = new System.Drawing.Point(611, 66);
            this.txtCONTRATO.Name = "txtCONTRATO";
            this.txtCONTRATO.Size = new System.Drawing.Size(118, 20);
            this.txtCONTRATO.TabIndex = 153;
            // 
            // RInvVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.txtCONTRATO);
            this.Controls.Add(this.rdbORO);
            this.Controls.Add(this.rdbARTICULO);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.lbNUM_TOTAL);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.cbxTIPO);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.tblINVENTARIO);
            this.MaximizeBox = false;
            this.Name = "RInvVentaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ARTICULOS PARA LA VENTA";
            this.Load += new System.EventHandler(this.RInvVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblINVENTARIO)).EndInit();
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNUM_TOTAL;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.ComboBox cbxTIPO;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.DataGridView tblINVENTARIO;
        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BODEGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
        private System.Windows.Forms.RadioButton rdbARTICULO;
        private System.Windows.Forms.RadioButton rdbORO;
        private System.Windows.Forms.TextBox txtCONTRATO;

    }
}