namespace PrendaSAL.Operaciones
{
    partial class TrasladoForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewerREMISION = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblREMISION = new System.Windows.Forms.DataGridView();
            this.NUM_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNOTA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtASESOR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnvio = new System.Windows.Forms.DateTimePicker();
            this.txtDOCUMENTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDOC = new System.Windows.Forms.Label();
            this.cbxDESTINO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnReimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.grbTraslado = new System.Windows.Forms.GroupBox();
            this.lbESTADO = new System.Windows.Forms.Label();
            this.txtRECIBE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTRASLADA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabDETALLE = new System.Windows.Forms.TabControl();
            this.pagCUSTODIA = new System.Windows.Forms.TabPage();
            this.tblCUSTODIA_COMPRAS = new System.Windows.Forms.DataGridView();
            this.tblCUSTODIA_PRESTAMOS = new System.Windows.Forms.DataGridView();
            this.pagREMISION = new System.Windows.Forms.TabPage();
            this.NUMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRATO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRATO_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grbTraslado.SuspendLayout();
            this.tabDETALLE.SuspendLayout();
            this.pagCUSTODIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).BeginInit();
            this.pagREMISION.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewerREMISION
            // 
            reportDataSource3.Name = "DSI";
            reportDataSource3.Value = null;
            this.viewerREMISION.LocalReport.DataSources.Add(reportDataSource3);
            this.viewerREMISION.LocalReport.ReportEmbeddedResource = "";
            this.viewerREMISION.Location = new System.Drawing.Point(700, 0);
            this.viewerREMISION.Name = "viewerREMISION";
            this.viewerREMISION.Size = new System.Drawing.Size(170, 25);
            this.viewerREMISION.TabIndex = 120;
            this.viewerREMISION.Visible = false;
            // 
            // tblREMISION
            // 
            this.tblREMISION.AllowUserToAddRows = false;
            this.tblREMISION.AllowUserToDeleteRows = false;
            this.tblREMISION.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblREMISION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblREMISION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_RM,
            this.CODIGO,
            this.CANTIDAD,
            this.COD_ITEM,
            this.DESCRIPCION,
            this.PRECIO});
            this.tblREMISION.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblREMISION.Location = new System.Drawing.Point(3, 3);
            this.tblREMISION.MultiSelect = false;
            this.tblREMISION.Name = "tblREMISION";
            this.tblREMISION.ReadOnly = true;
            this.tblREMISION.RowHeadersVisible = false;
            this.tblREMISION.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblREMISION.Size = new System.Drawing.Size(791, 189);
            this.tblREMISION.TabIndex = 121;
            this.tblREMISION.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblREMISION_CellFormatting);
            // 
            // NUM_RM
            // 
            this.NUM_RM.HeaderText = "#";
            this.NUM_RM.Name = "NUM_RM";
            this.NUM_RM.ReadOnly = true;
            this.NUM_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NUM_RM.Width = 25;
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
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD.Width = 70;
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.DataPropertyName = "COD_ITEM";
            this.COD_ITEM.HeaderText = "ARTICULO";
            this.COD_ITEM.Name = "COD_ITEM";
            this.COD_ITEM.ReadOnly = true;
            this.COD_ITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ITEM.Width = 80;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DETALLE";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 350;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO.Width = 80;
            // 
            // txtNOTA
            // 
            // 
            // 
            // 
            this.txtNOTA.Border.Class = "TextBoxBorder";
            this.txtNOTA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNOTA.Location = new System.Drawing.Point(16, 436);
            this.txtNOTA.Multiline = true;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(379, 62);
            this.txtNOTA.TabIndex = 132;
            this.txtNOTA.WatermarkText = "Nota Adicional";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.Enabled = false;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(12, 124);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(212, 21);
            this.cbxSUCURSAL.TabIndex = 131;
            this.cbxSUCURSAL.SelectedIndexChanged += new System.EventHandler(this.cbxSUCURSAL_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(97, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 130;
            this.label19.Text = "ENVIA";
            // 
            // txtASESOR
            // 
            this.txtASESOR.Location = new System.Drawing.Point(582, 28);
            this.txtASESOR.Name = "txtASESOR";
            this.txtASESOR.ReadOnly = true;
            this.txtASESOR.Size = new System.Drawing.Size(205, 20);
            this.txtASESOR.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(648, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "ASESOR";
            // 
            // dateEnvio
            // 
            this.dateEnvio.Enabled = false;
            this.dateEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnvio.Location = new System.Drawing.Point(121, 66);
            this.dateEnvio.Name = "dateEnvio";
            this.dateEnvio.Size = new System.Drawing.Size(129, 26);
            this.dateEnvio.TabIndex = 127;
            // 
            // txtDOCUMENTO
            // 
            this.txtDOCUMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO.Location = new System.Drawing.Point(121, 19);
            this.txtDOCUMENTO.Name = "txtDOCUMENTO";
            this.txtDOCUMENTO.ReadOnly = true;
            this.txtDOCUMENTO.Size = new System.Drawing.Size(129, 30);
            this.txtDOCUMENTO.TabIndex = 126;
            this.txtDOCUMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 125;
            this.label5.Text = "FECHA ENVIO";
            // 
            // lbDOC
            // 
            this.lbDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDOC.Location = new System.Drawing.Point(10, 19);
            this.lbDOC.Name = "lbDOC";
            this.lbDOC.Size = new System.Drawing.Size(105, 30);
            this.lbDOC.TabIndex = 124;
            this.lbDOC.Text = "CUSTODIA";
            this.lbDOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDESTINO
            // 
            this.cbxDESTINO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDESTINO.FormattingEnabled = true;
            this.cbxDESTINO.Location = new System.Drawing.Point(311, 123);
            this.cbxDESTINO.Name = "cbxDESTINO";
            this.cbxDESTINO.Size = new System.Drawing.Size(228, 21);
            this.cbxDESTINO.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "DESTINO";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::PrendaSAL.Properties.Resources.fechas21;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(230, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 47);
            this.label4.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 137;
            this.label6.Text = "TOTAL";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.Location = new System.Drawing.Point(671, 440);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(115, 23);
            this.txtTOTAL.TabIndex = 138;
            // 
            // btnADD
            // 
            this.btnADD.Image = global::PrendaSAL.Properties.Resources.buscar;
            this.btnADD.Location = new System.Drawing.Point(823, 221);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(37, 25);
            this.btnADD.TabIndex = 139;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.getDetalleTraslado);
            // 
            // btnDEL
            // 
            this.btnDEL.Image = global::PrendaSAL.Properties.Resources.menos;
            this.btnDEL.Location = new System.Drawing.Point(823, 255);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(37, 25);
            this.btnDEL.TabIndex = 140;
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.removeItemTraslado);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnEditar,
            this.btnAnular,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnBuscar,
            this.btnReimprimir,
            this.btnLog,
            this.btnAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
            this.toolStrip1.TabIndex = 141;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.ToolTipText = "Nueva";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::PrendaSAL.Properties.Resources.icon_save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.ToolTipText = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.GUARDAR);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::PrendaSAL.Properties.Resources.cancel_16;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.ToolTipText = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.CANCELAR);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.EDITAR);
            // 
            // btnAnular
            // 
            this.btnAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnular.Image = global::PrendaSAL.Properties.Resources.anular2;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(23, 22);
            this.btnAnular.Text = "Anular";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::PrendaSAL.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.ELIMINAR);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::PrendaSAL.Properties.Resources.buscar_icon2;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.ToolTipText = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.BUSCAR);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReimprimir.Image = global::PrendaSAL.Properties.Resources.printer;
            this.btnReimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(23, 22);
            this.btnReimprimir.ToolTipText = "Imprimir";
            this.btnReimprimir.Click += new System.EventHandler(this.IMPRIMIR);
            // 
            // btnLog
            // 
            this.btnLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLog.Image = global::PrendaSAL.Properties.Resources.log;
            this.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(23, 22);
            this.btnLog.ToolTipText = "Log";
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
            // grbTraslado
            // 
            this.grbTraslado.Controls.Add(this.txtRECIBE);
            this.grbTraslado.Controls.Add(this.label8);
            this.grbTraslado.Controls.Add(this.txtTRASLADA);
            this.grbTraslado.Controls.Add(this.label7);
            this.grbTraslado.Controls.Add(this.lbDOC);
            this.grbTraslado.Controls.Add(this.label4);
            this.grbTraslado.Controls.Add(this.label5);
            this.grbTraslado.Controls.Add(this.txtDOCUMENTO);
            this.grbTraslado.Controls.Add(this.dateEnvio);
            this.grbTraslado.Controls.Add(this.cbxDESTINO);
            this.grbTraslado.Controls.Add(this.label2);
            this.grbTraslado.Controls.Add(this.label3);
            this.grbTraslado.Controls.Add(this.txtASESOR);
            this.grbTraslado.Controls.Add(this.label19);
            this.grbTraslado.Controls.Add(this.cbxSUCURSAL);
            this.grbTraslado.Location = new System.Drawing.Point(12, 28);
            this.grbTraslado.Name = "grbTraslado";
            this.grbTraslado.Size = new System.Drawing.Size(801, 165);
            this.grbTraslado.TabIndex = 142;
            this.grbTraslado.TabStop = false;
            // 
            // lbESTADO
            // 
            this.lbESTADO.AutoSize = true;
            this.lbESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESTADO.Location = new System.Drawing.Point(711, 486);
            this.lbESTADO.Name = "lbESTADO";
            this.lbESTADO.Size = new System.Drawing.Size(102, 25);
            this.lbESTADO.TabIndex = 147;
            this.lbESTADO.Text = "ESTADO";
            // 
            // txtRECIBE
            // 
            this.txtRECIBE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRECIBE.Location = new System.Drawing.Point(582, 124);
            this.txtRECIBE.Name = "txtRECIBE";
            this.txtRECIBE.ReadOnly = true;
            this.txtRECIBE.Size = new System.Drawing.Size(206, 20);
            this.txtRECIBE.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 146;
            this.label8.Text = "RECIBE";
            // 
            // txtTRASLADA
            // 
            this.txtTRASLADA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTRASLADA.Location = new System.Drawing.Point(582, 76);
            this.txtTRASLADA.Name = "txtTRASLADA";
            this.txtTRASLADA.Size = new System.Drawing.Size(206, 20);
            this.txtTRASLADA.TabIndex = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 144;
            this.label7.Text = "TRASLADA";
            // 
            // tabDETALLE
            // 
            this.tabDETALLE.Controls.Add(this.pagCUSTODIA);
            this.tabDETALLE.Controls.Add(this.pagREMISION);
            this.tabDETALLE.Location = new System.Drawing.Point(12, 199);
            this.tabDETALLE.Name = "tabDETALLE";
            this.tabDETALLE.SelectedIndex = 0;
            this.tabDETALLE.Size = new System.Drawing.Size(805, 221);
            this.tabDETALLE.TabIndex = 143;
            this.tabDETALLE.SelectedIndexChanged += new System.EventHandler(this.tabDETALLE_SelectedIndexChanged);
            // 
            // pagCUSTODIA
            // 
            this.pagCUSTODIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA_COMPRAS);
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA_PRESTAMOS);
            this.pagCUSTODIA.Location = new System.Drawing.Point(4, 22);
            this.pagCUSTODIA.Name = "pagCUSTODIA";
            this.pagCUSTODIA.Padding = new System.Windows.Forms.Padding(3);
            this.pagCUSTODIA.Size = new System.Drawing.Size(797, 195);
            this.pagCUSTODIA.TabIndex = 0;
            this.pagCUSTODIA.Text = "CUSTODIA DE VALORES";
            // 
            // tblCUSTODIA_COMPRAS
            // 
            this.tblCUSTODIA_COMPRAS.AllowUserToAddRows = false;
            this.tblCUSTODIA_COMPRAS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_COMPRAS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCUSTODIA_COMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_COMPRAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMC,
            this.CONTRATO_COMPRA,
            this.CATEGORIA_COMPRA,
            this.NIVEL});
            this.tblCUSTODIA_COMPRAS.Location = new System.Drawing.Point(417, 3);
            this.tblCUSTODIA_COMPRAS.Name = "tblCUSTODIA_COMPRAS";
            this.tblCUSTODIA_COMPRAS.ReadOnly = true;
            this.tblCUSTODIA_COMPRAS.RowHeadersVisible = false;
            this.tblCUSTODIA_COMPRAS.Size = new System.Drawing.Size(380, 189);
            this.tblCUSTODIA_COMPRAS.TabIndex = 123;
            // 
            // tblCUSTODIA_PRESTAMOS
            // 
            this.tblCUSTODIA_PRESTAMOS.AllowUserToAddRows = false;
            this.tblCUSTODIA_PRESTAMOS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_PRESTAMOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCUSTODIA_PRESTAMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_PRESTAMOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMP,
            this.CONTRATO_PRESTAMO,
            this.CATEGORIA_PRESTAMO});
            this.tblCUSTODIA_PRESTAMOS.Location = new System.Drawing.Point(3, 3);
            this.tblCUSTODIA_PRESTAMOS.Name = "tblCUSTODIA_PRESTAMOS";
            this.tblCUSTODIA_PRESTAMOS.ReadOnly = true;
            this.tblCUSTODIA_PRESTAMOS.RowHeadersVisible = false;
            this.tblCUSTODIA_PRESTAMOS.Size = new System.Drawing.Size(397, 189);
            this.tblCUSTODIA_PRESTAMOS.TabIndex = 122;
            // 
            // pagREMISION
            // 
            this.pagREMISION.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pagREMISION.Controls.Add(this.tblREMISION);
            this.pagREMISION.Location = new System.Drawing.Point(4, 22);
            this.pagREMISION.Name = "pagREMISION";
            this.pagREMISION.Padding = new System.Windows.Forms.Padding(3);
            this.pagREMISION.Size = new System.Drawing.Size(797, 195);
            this.pagREMISION.TabIndex = 1;
            this.pagREMISION.Text = "NOTA DE REMISION";
            // 
            // NUMC
            // 
            this.NUMC.DataPropertyName = "NUMC";
            this.NUMC.HeaderText = "#";
            this.NUMC.Name = "NUMC";
            this.NUMC.ReadOnly = true;
            this.NUMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NUMC.Width = 25;
            // 
            // CONTRATO_COMPRA
            // 
            this.CONTRATO_COMPRA.DataPropertyName = "CONTRATO_COMPRA";
            this.CONTRATO_COMPRA.HeaderText = "COMPRA";
            this.CONTRATO_COMPRA.Name = "CONTRATO_COMPRA";
            this.CONTRATO_COMPRA.ReadOnly = true;
            this.CONTRATO_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CATEGORIA_COMPRA
            // 
            this.CATEGORIA_COMPRA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_COMPRA.HeaderText = "CATEGORIA";
            this.CATEGORIA_COMPRA.Name = "CATEGORIA_COMPRA";
            this.CATEGORIA_COMPRA.ReadOnly = true;
            this.CATEGORIA_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            this.NIVEL.HeaderText = "MAYOREO";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.ReadOnly = true;
            this.NIVEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NUMP
            // 
            this.NUMP.DataPropertyName = "NUMP";
            this.NUMP.HeaderText = "#";
            this.NUMP.Name = "NUMP";
            this.NUMP.ReadOnly = true;
            this.NUMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NUMP.Width = 25;
            // 
            // CONTRATO_PRESTAMO
            // 
            this.CONTRATO_PRESTAMO.DataPropertyName = "CONTRATO";
            this.CONTRATO_PRESTAMO.HeaderText = "CONTRATO";
            this.CONTRATO_PRESTAMO.Name = "CONTRATO_PRESTAMO";
            this.CONTRATO_PRESTAMO.ReadOnly = true;
            this.CONTRATO_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CATEGORIA_PRESTAMO
            // 
            this.CATEGORIA_PRESTAMO.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.HeaderText = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.Name = "CATEGORIA_PRESTAMO";
            this.CATEGORIA_PRESTAMO.ReadOnly = true;
            this.CATEGORIA_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TrasladoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 520);
            this.Controls.Add(this.lbESTADO);
            this.Controls.Add(this.tabDETALLE);
            this.Controls.Add(this.grbTraslado);
            this.Controls.Add(this.viewerREMISION);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNOTA);
            this.MaximizeBox = false;
            this.Name = "TrasladoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ENVIOS DE ARTICULOS";
            this.Load += new System.EventHandler(this.EnviarInvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbTraslado.ResumeLayout(false);
            this.grbTraslado.PerformLayout();
            this.tabDETALLE.ResumeLayout(false);
            this.pagCUSTODIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).EndInit();
            this.pagREMISION.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer viewerREMISION;
        private System.Windows.Forms.DataGridView tblREMISION;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNOTA;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtASESOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnvio;
        private System.Windows.Forms.TextBox txtDOCUMENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDOC;
        private System.Windows.Forms.ComboBox cbxDESTINO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.GroupBox grbTraslado;
        private System.Windows.Forms.TextBox txtRECIBE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTRASLADA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabDETALLE;
        private System.Windows.Forms.TabPage pagCUSTODIA;
        private System.Windows.Forms.TabPage pagREMISION;
        private System.Windows.Forms.DataGridView tblCUSTODIA_PRESTAMOS;
        private System.Windows.Forms.Label lbESTADO;
        private System.Windows.Forms.DataGridView tblCUSTODIA_COMPRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_PRESTAMO;
    }
}