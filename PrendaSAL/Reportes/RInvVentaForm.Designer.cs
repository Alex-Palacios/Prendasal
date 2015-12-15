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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdbCODIGO = new System.Windows.Forms.RadioButton();
            this.rdbDETALLE = new System.Windows.Forms.RadioButton();
            this.lbNUM_TOTAL = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.cbxARTICULO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.tblINVENTARIO = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblINVENTARIO)).BeginInit();
            this.opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbCODIGO
            // 
            this.rdbCODIGO.AutoSize = true;
            this.rdbCODIGO.Location = new System.Drawing.Point(47, 67);
            this.rdbCODIGO.Name = "rdbCODIGO";
            this.rdbCODIGO.Size = new System.Drawing.Size(14, 13);
            this.rdbCODIGO.TabIndex = 110;
            this.rdbCODIGO.UseVisualStyleBackColor = true;
            this.rdbCODIGO.CheckedChanged += new System.EventHandler(this.rdbCODIGO_CheckedChanged);
            // 
            // rdbDETALLE
            // 
            this.rdbDETALLE.AutoSize = true;
            this.rdbDETALLE.Location = new System.Drawing.Point(47, 36);
            this.rdbDETALLE.Name = "rdbDETALLE";
            this.rdbDETALLE.Size = new System.Drawing.Size(14, 13);
            this.rdbDETALLE.TabIndex = 109;
            this.rdbDETALLE.TabStop = true;
            this.rdbDETALLE.UseVisualStyleBackColor = true;
            this.rdbDETALLE.CheckedChanged += new System.EventHandler(this.rdbDETALLE_CheckedChanged);
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
            this.btnBUSCAR.Location = new System.Drawing.Point(820, 41);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(88, 64);
            this.btnBUSCAR.TabIndex = 105;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // cbxARTICULO
            // 
            this.cbxARTICULO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxARTICULO.FormattingEnabled = true;
            this.cbxARTICULO.Location = new System.Drawing.Point(495, 33);
            this.cbxARTICULO.Name = "cbxARTICULO";
            this.cbxARTICULO.Size = new System.Drawing.Size(145, 21);
            this.cbxARTICULO.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "ARTICULO";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(164, 33);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 102;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(89, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 101;
            this.label19.Text = "SUCURSAL";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(164, 67);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(136, 23);
            this.txtCODIGO.TabIndex = 100;
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
            this.CATEGORIA,
            this.COD_ITEM,
            this.DESCRIPCION,
            this.PRECIO,
            this.UBICACION});
            this.tblINVENTARIO.Location = new System.Drawing.Point(10, 115);
            this.tblINVENTARIO.MultiSelect = false;
            this.tblINVENTARIO.Name = "tblINVENTARIO";
            this.tblINVENTARIO.ReadOnly = true;
            this.tblINVENTARIO.RowHeadersVisible = false;
            this.tblINVENTARIO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblINVENTARIO.Size = new System.Drawing.Size(927, 329);
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
            dataGridViewCellStyle1.Format = "N1";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle1;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD.Width = 70;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CATEGORIA.Width = 80;
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.DataPropertyName = "COD_ITEM";
            this.COD_ITEM.HeaderText = "ARTICULO";
            this.COD_ITEM.Name = "COD_ITEM";
            this.COD_ITEM.ReadOnly = true;
            this.COD_ITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            dataGridViewCellStyle2.Format = "C2";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO.Width = 80;
            // 
            // UBICACION
            // 
            this.UBICACION.DataPropertyName = "UBICACION";
            this.UBICACION.HeaderText = "UBICACION";
            this.UBICACION.Name = "UBICACION";
            this.UBICACION.ReadOnly = true;
            this.UBICACION.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "CODIGO";
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
            this.opciones.Size = new System.Drawing.Size(964, 25);
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
            this.btnEditar.ToolTipText = "Guardar";
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
            this.btnExportExcel.Text = "toolStripButton1";
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
            // RInvVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 477);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.rdbCODIGO);
            this.Controls.Add(this.rdbDETALLE);
            this.Controls.Add(this.lbNUM_TOTAL);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.cbxARTICULO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.tblINVENTARIO);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.RadioButton rdbCODIGO;
        private System.Windows.Forms.RadioButton rdbDETALLE;
        private System.Windows.Forms.Label lbNUM_TOTAL;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.ComboBox cbxARTICULO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.DataGridView tblINVENTARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION;

    }
}