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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblKARDEX = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTRADAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALIDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.grConsulta = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbFILTROS = new System.Windows.Forms.RadioButton();
            this.rdbCODIGO = new System.Windows.Forms.RadioButton();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.lbCONSOLIDADO = new System.Windows.Forms.Label();
            this.lbENTRADAS = new System.Windows.Forms.Label();
            this.lbSALIDAS = new System.Windows.Forms.Label();
            this.lbINGRESOS = new System.Windows.Forms.Label();
            this.lbEGRESOS = new System.Windows.Forms.Label();
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
            this.CODIGO,
            this.CATEGORIA,
            this.COD_ITEM,
            this.DESCRIPCION,
            this.ENTRADAS,
            this.SALIDAS,
            this.INGRESOS,
            this.EGRESOS});
            this.tblKARDEX.Location = new System.Drawing.Point(12, 145);
            this.tblKARDEX.MultiSelect = false;
            this.tblKARDEX.Name = "tblKARDEX";
            this.tblKARDEX.ReadOnly = true;
            this.tblKARDEX.RowHeadersVisible = false;
            this.tblKARDEX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblKARDEX.Size = new System.Drawing.Size(1078, 292);
            this.tblKARDEX.TabIndex = 0;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle1;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA.Width = 80;
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
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 300;
            // 
            // ENTRADAS
            // 
            this.ENTRADAS.DataPropertyName = "ENTRADAS";
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.ENTRADAS.DefaultCellStyle = dataGridViewCellStyle2;
            this.ENTRADAS.HeaderText = "ENTRADAS";
            this.ENTRADAS.Name = "ENTRADAS";
            this.ENTRADAS.ReadOnly = true;
            this.ENTRADAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ENTRADAS.Width = 80;
            // 
            // SALIDAS
            // 
            this.SALIDAS.DataPropertyName = "SALIDAS";
            dataGridViewCellStyle3.Format = "N1";
            this.SALIDAS.DefaultCellStyle = dataGridViewCellStyle3;
            this.SALIDAS.HeaderText = "SALIDAS";
            this.SALIDAS.Name = "SALIDAS";
            this.SALIDAS.ReadOnly = true;
            this.SALIDAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SALIDAS.Width = 80;
            // 
            // INGRESOS
            // 
            this.INGRESOS.DataPropertyName = "INGRESOS";
            dataGridViewCellStyle4.Format = "C2";
            this.INGRESOS.DefaultCellStyle = dataGridViewCellStyle4;
            this.INGRESOS.HeaderText = "INGRESOS";
            this.INGRESOS.Name = "INGRESOS";
            this.INGRESOS.ReadOnly = true;
            this.INGRESOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.INGRESOS.Width = 80;
            // 
            // EGRESOS
            // 
            this.EGRESOS.DataPropertyName = "EGRESOS";
            dataGridViewCellStyle5.Format = "C2";
            this.EGRESOS.DefaultCellStyle = dataGridViewCellStyle5;
            this.EGRESOS.HeaderText = "EGRESOS";
            this.EGRESOS.Name = "EGRESOS";
            this.EGRESOS.ReadOnly = true;
            this.EGRESOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EGRESOS.Width = 80;
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaInicio.Location = new System.Drawing.Point(139, 60);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.dateFechaInicio.TabIndex = 1;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaFin.Location = new System.Drawing.Point(319, 62);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(98, 20);
            this.dateFechaFin.TabIndex = 2;
            // 
            // grConsulta
            // 
            this.grConsulta.Controls.Add(this.btnBUSCAR);
            this.grConsulta.Controls.Add(this.label4);
            this.grConsulta.Controls.Add(this.label3);
            this.grConsulta.Controls.Add(this.rdbFILTROS);
            this.grConsulta.Controls.Add(this.rdbCODIGO);
            this.grConsulta.Controls.Add(this.cbxItem);
            this.grConsulta.Controls.Add(this.label2);
            this.grConsulta.Controls.Add(this.txtCODIGO);
            this.grConsulta.Controls.Add(this.label1);
            this.grConsulta.Controls.Add(this.cbxCategorias);
            this.grConsulta.Controls.Add(this.label9);
            this.grConsulta.Controls.Add(this.dateFechaInicio);
            this.grConsulta.Controls.Add(this.dateFechaFin);
            this.grConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grConsulta.Location = new System.Drawing.Point(12, 39);
            this.grConsulta.Name = "grConsulta";
            this.grConsulta.Size = new System.Drawing.Size(1078, 100);
            this.grConsulta.TabIndex = 3;
            this.grConsulta.TabStop = false;
            this.grConsulta.Text = "CONSULTAR";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::PrendaSAL.Properties.Resources.search;
            this.btnBUSCAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBUSCAR.Location = new System.Drawing.Point(938, 24);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(88, 64);
            this.btnBUSCAR.TabIndex = 115;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "DESDE";
            // 
            // rdbFILTROS
            // 
            this.rdbFILTROS.AutoSize = true;
            this.rdbFILTROS.Location = new System.Drawing.Point(44, 62);
            this.rdbFILTROS.Name = "rdbFILTROS";
            this.rdbFILTROS.Size = new System.Drawing.Size(14, 13);
            this.rdbFILTROS.TabIndex = 112;
            this.rdbFILTROS.UseVisualStyleBackColor = true;
            this.rdbFILTROS.CheckedChanged += new System.EventHandler(this.rdbFILTROS_CheckedChanged);
            // 
            // rdbCODIGO
            // 
            this.rdbCODIGO.AutoSize = true;
            this.rdbCODIGO.Location = new System.Drawing.Point(44, 26);
            this.rdbCODIGO.Name = "rdbCODIGO";
            this.rdbCODIGO.Size = new System.Drawing.Size(14, 13);
            this.rdbCODIGO.TabIndex = 111;
            this.rdbCODIGO.TabStop = true;
            this.rdbCODIGO.UseVisualStyleBackColor = true;
            this.rdbCODIGO.CheckedChanged += new System.EventHandler(this.rdbCODIGO_CheckedChanged);
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(655, 63);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(130, 21);
            this.cbxItem.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "ITEM";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(139, 21);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(184, 23);
            this.txtCODIGO.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "CODIGO";
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(492, 63);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(130, 21);
            this.cbxCategorias.TabIndex = 89;
            this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxCategorias_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(517, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "CATEGORIA";
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportExcel,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(1090, 25);
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
            // lbCONSOLIDADO
            // 
            this.lbCONSOLIDADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCONSOLIDADO.Location = new System.Drawing.Point(933, 466);
            this.lbCONSOLIDADO.Name = "lbCONSOLIDADO";
            this.lbCONSOLIDADO.Size = new System.Drawing.Size(151, 23);
            this.lbCONSOLIDADO.TabIndex = 157;
            this.lbCONSOLIDADO.Text = "$0.00";
            this.lbCONSOLIDADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbENTRADAS
            // 
            this.lbENTRADAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbENTRADAS.Location = new System.Drawing.Point(758, 440);
            this.lbENTRADAS.Name = "lbENTRADAS";
            this.lbENTRADAS.Size = new System.Drawing.Size(81, 23);
            this.lbENTRADAS.TabIndex = 158;
            this.lbENTRADAS.Text = "$0.00";
            this.lbENTRADAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSALIDAS
            // 
            this.lbSALIDAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSALIDAS.Location = new System.Drawing.Point(845, 440);
            this.lbSALIDAS.Name = "lbSALIDAS";
            this.lbSALIDAS.Size = new System.Drawing.Size(81, 23);
            this.lbSALIDAS.TabIndex = 159;
            this.lbSALIDAS.Text = "$0.00";
            this.lbSALIDAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbINGRESOS
            // 
            this.lbINGRESOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINGRESOS.Location = new System.Drawing.Point(932, 440);
            this.lbINGRESOS.Name = "lbINGRESOS";
            this.lbINGRESOS.Size = new System.Drawing.Size(81, 23);
            this.lbINGRESOS.TabIndex = 160;
            this.lbINGRESOS.Text = "$0.00";
            this.lbINGRESOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEGRESOS
            // 
            this.lbEGRESOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEGRESOS.Location = new System.Drawing.Point(1011, 440);
            this.lbEGRESOS.Name = "lbEGRESOS";
            this.lbEGRESOS.Size = new System.Drawing.Size(81, 23);
            this.lbEGRESOS.TabIndex = 161;
            this.lbEGRESOS.Text = "$0.00";
            this.lbEGRESOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RKardexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 491);
            this.Controls.Add(this.lbEGRESOS);
            this.Controls.Add(this.lbINGRESOS);
            this.Controls.Add(this.lbSALIDAS);
            this.Controls.Add(this.lbENTRADAS);
            this.Controls.Add(this.lbCONSOLIDADO);
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
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.GroupBox grConsulta;
        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbFILTROS;
        private System.Windows.Forms.RadioButton rdbCODIGO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCONSOLIDADO;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label lbENTRADAS;
        private System.Windows.Forms.Label lbSALIDAS;
        private System.Windows.Forms.Label lbINGRESOS;
        private System.Windows.Forms.Label lbEGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTRADAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALIDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGRESOS;
    }
}