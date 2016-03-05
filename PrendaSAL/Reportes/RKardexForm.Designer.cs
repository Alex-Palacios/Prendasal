namespace PrendaSAL.Reportes
{
    partial class RKardexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblKARDEX = new System.Windows.Forms.DataGridView();
            this.grConsulta = new System.Windows.Forms.GroupBox();
            this.txtANIO = new System.Windows.Forms.TextBox();
            this.cbxMESES = new System.Windows.Forms.ComboBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbKILATAJE = new System.Windows.Forms.RadioButton();
            this.rdbCODIGO = new System.Windows.Forms.RadioButton();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_TRANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTRADAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALIDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblKARDEX)).BeginInit();
            this.grConsulta.SuspendLayout();
            this.opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblKARDEX
            // 
            this.tblKARDEX.AllowUserToAddRows = false;
            this.tblKARDEX.AllowUserToDeleteRows = false;
            this.tblKARDEX.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblKARDEX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKARDEX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.COD_TRANS,
            this.COD_ITEM,
            this.TIPO,
            this.MARCA,
            this.DESCRIPCION,
            this.ENTRADAS,
            this.SALIDAS,
            this.EXISTENCIAS});
            this.tblKARDEX.Location = new System.Drawing.Point(12, 145);
            this.tblKARDEX.MultiSelect = false;
            this.tblKARDEX.Name = "tblKARDEX";
            this.tblKARDEX.ReadOnly = true;
            this.tblKARDEX.RowHeadersVisible = false;
            this.tblKARDEX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblKARDEX.Size = new System.Drawing.Size(1032, 292);
            this.tblKARDEX.TabIndex = 0;
            // 
            // grConsulta
            // 
            this.grConsulta.Controls.Add(this.txtANIO);
            this.grConsulta.Controls.Add(this.cbxMESES);
            this.grConsulta.Controls.Add(this.lb4);
            this.grConsulta.Controls.Add(this.label1);
            this.grConsulta.Controls.Add(this.btnBUSCAR);
            this.grConsulta.Controls.Add(this.label3);
            this.grConsulta.Controls.Add(this.rdbKILATAJE);
            this.grConsulta.Controls.Add(this.rdbCODIGO);
            this.grConsulta.Controls.Add(this.cbxItem);
            this.grConsulta.Controls.Add(this.label2);
            this.grConsulta.Controls.Add(this.txtCODIGO);
            this.grConsulta.Controls.Add(this.label9);
            this.grConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grConsulta.Location = new System.Drawing.Point(12, 28);
            this.grConsulta.Name = "grConsulta";
            this.grConsulta.Size = new System.Drawing.Size(1032, 111);
            this.grConsulta.TabIndex = 3;
            this.grConsulta.TabStop = false;
            this.grConsulta.Text = "CONSULTAR";
            // 
            // txtANIO
            // 
            this.txtANIO.Location = new System.Drawing.Point(139, 30);
            this.txtANIO.MaxLength = 4;
            this.txtANIO.Name = "txtANIO";
            this.txtANIO.Size = new System.Drawing.Size(120, 20);
            this.txtANIO.TabIndex = 119;
            this.txtANIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtANIO_KeyPress);
            // 
            // cbxMESES
            // 
            this.cbxMESES.FormattingEnabled = true;
            this.cbxMESES.Location = new System.Drawing.Point(138, 68);
            this.cbxMESES.Name = "cbxMESES";
            this.cbxMESES.Size = new System.Drawing.Size(121, 21);
            this.cbxMESES.TabIndex = 118;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(92, 30);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(41, 17);
            this.lb4.TabIndex = 117;
            this.lb4.Text = "AÑO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "MES";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::PrendaSAL.Properties.Resources.search;
            this.btnBUSCAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBUSCAR.Location = new System.Drawing.Point(854, 30);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(88, 64);
            this.btnBUSCAR.TabIndex = 115;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 113;
            // 
            // rdbKILATAJE
            // 
            this.rdbKILATAJE.AutoSize = true;
            this.rdbKILATAJE.Location = new System.Drawing.Point(380, 71);
            this.rdbKILATAJE.Name = "rdbKILATAJE";
            this.rdbKILATAJE.Size = new System.Drawing.Size(52, 17);
            this.rdbKILATAJE.TabIndex = 112;
            this.rdbKILATAJE.Text = "ORO";
            this.rdbKILATAJE.UseVisualStyleBackColor = true;
            this.rdbKILATAJE.CheckedChanged += new System.EventHandler(this.rdbFILTROS_CheckedChanged);
            // 
            // rdbCODIGO
            // 
            this.rdbCODIGO.AutoSize = true;
            this.rdbCODIGO.Location = new System.Drawing.Point(380, 30);
            this.rdbCODIGO.Name = "rdbCODIGO";
            this.rdbCODIGO.Size = new System.Drawing.Size(87, 17);
            this.rdbCODIGO.TabIndex = 111;
            this.rdbCODIGO.TabStop = true;
            this.rdbCODIGO.Text = "ARTICULO";
            this.rdbCODIGO.UseVisualStyleBackColor = true;
            this.rdbCODIGO.CheckedChanged += new System.EventHandler(this.rdbCODIGO_CheckedChanged);
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(473, 73);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(174, 21);
            this.cbxItem.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "KILATAJE";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(473, 30);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(174, 23);
            this.txtCODIGO.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "CODIGO";
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportExcel,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(1056, 25);
            this.opciones.TabIndex = 151;
            this.opciones.Text = "toolStrip1";
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
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle4;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA.Width = 80;
            // 
            // COD_TRANS
            // 
            this.COD_TRANS.DataPropertyName = "COD_TRANS";
            this.COD_TRANS.HeaderText = "COD TRANS";
            this.COD_TRANS.Name = "COD_TRANS";
            this.COD_TRANS.ReadOnly = true;
            this.COD_TRANS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.DataPropertyName = "COD_ITEM";
            this.COD_ITEM.HeaderText = "ART/KIL";
            this.COD_ITEM.Name = "COD_ITEM";
            this.COD_ITEM.ReadOnly = true;
            this.COD_ITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ITEM.Width = 120;
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
            this.DESCRIPCION.Width = 250;
            // 
            // ENTRADAS
            // 
            this.ENTRADAS.DataPropertyName = "ENTRADAS";
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = null;
            this.ENTRADAS.DefaultCellStyle = dataGridViewCellStyle5;
            this.ENTRADAS.HeaderText = "ENTRADAS";
            this.ENTRADAS.Name = "ENTRADAS";
            this.ENTRADAS.ReadOnly = true;
            this.ENTRADAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ENTRADAS.Width = 80;
            // 
            // SALIDAS
            // 
            this.SALIDAS.DataPropertyName = "SALIDAS";
            dataGridViewCellStyle6.Format = "N1";
            this.SALIDAS.DefaultCellStyle = dataGridViewCellStyle6;
            this.SALIDAS.HeaderText = "SALIDAS";
            this.SALIDAS.Name = "SALIDAS";
            this.SALIDAS.ReadOnly = true;
            this.SALIDAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SALIDAS.Width = 80;
            // 
            // EXISTENCIAS
            // 
            this.EXISTENCIAS.DataPropertyName = "EXISTENCIAS";
            this.EXISTENCIAS.HeaderText = "EXISTENCIAS";
            this.EXISTENCIAS.Name = "EXISTENCIAS";
            this.EXISTENCIAS.ReadOnly = true;
            this.EXISTENCIAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RKardexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 457);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.grConsulta);
            this.Controls.Add(this.tblKARDEX);
            this.MaximizeBox = false;
            this.Name = "RKardexForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KARDEX";
            this.Load += new System.EventHandler(this.RKardexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKARDEX)).EndInit();
            this.grConsulta.ResumeLayout(false);
            this.grConsulta.PerformLayout();
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblKARDEX;
        private System.Windows.Forms.GroupBox grConsulta;
        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbKILATAJE;
        private System.Windows.Forms.RadioButton rdbCODIGO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtANIO;
        private System.Windows.Forms.ComboBox cbxMESES;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_TRANS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTRADAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALIDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIAS;
    }
}