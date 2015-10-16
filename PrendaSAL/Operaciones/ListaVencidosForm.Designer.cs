namespace PrendaSAL.Operaciones
{
    partial class ListaVencidosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnReimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.tblCONTRATOS = new System.Windows.Forms.DataGridView();
            this.dateVencidos = new System.Windows.Forms.DateTimePicker();
            this.txtDOCUMENTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lbCONTRATOS = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            this.btnLISTAR = new System.Windows.Forms.Button();
            this.txtNOTA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bsListaCierre = new System.Windows.Forms.BindingSource(this.components);
            this.dSCierre = new PrendaSAL.Informes.DSCierre();
            this.lbREACTIVADOS = new System.Windows.Forms.Label();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.tblKPM = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.ID_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REACTIVADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCONTRATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKPM)).BeginInit();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnEditar,
            this.btnBuscar,
            this.btnReimprimir,
            this.btnLog,
            this.btnEliminar,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(1102, 25);
            this.opciones.TabIndex = 2;
            this.opciones.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.ToolTipText = "Nuevo";
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
            this.btnReimprimir.Text = "toolStripButton1";
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
            this.btnLog.Click += new System.EventHandler(this.LOG);
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
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = global::PrendaSAL.Properties.Resources.help;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(23, 22);
            this.btnAyuda.ToolTipText = "Ayuda";
            this.btnAyuda.Click += new System.EventHandler(this.AYUDA);
            // 
            // tblCONTRATOS
            // 
            this.tblCONTRATOS.AllowUserToAddRows = false;
            this.tblCONTRATOS.AllowUserToDeleteRows = false;
            this.tblCONTRATOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCONTRATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCONTRATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRESTAMO,
            this.REACTIVADO,
            this.CONTRATO,
            this.FECHA_CONTRATO,
            this.CLIENTE,
            this.CATEGORIA,
            this.ARTICULO,
            this.PRESTAMO,
            this.SALDO,
            this.ESTADO_CONTRATO,
            this.DIAS_VENC});
            this.tblCONTRATOS.Location = new System.Drawing.Point(12, 152);
            this.tblCONTRATOS.Name = "tblCONTRATOS";
            this.tblCONTRATOS.ReadOnly = true;
            this.tblCONTRATOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCONTRATOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblCONTRATOS.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tblCONTRATOS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblCONTRATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCONTRATOS.Size = new System.Drawing.Size(1052, 296);
            this.tblCONTRATOS.TabIndex = 107;
            // 
            // dateVencidos
            // 
            this.dateVencidos.Enabled = false;
            this.dateVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVencidos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVencidos.Location = new System.Drawing.Point(321, 63);
            this.dateVencidos.Name = "dateVencidos";
            this.dateVencidos.Size = new System.Drawing.Size(103, 26);
            this.dateVencidos.TabIndex = 111;
            // 
            // txtDOCUMENTO
            // 
            this.txtDOCUMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO.Location = new System.Drawing.Point(88, 59);
            this.txtDOCUMENTO.Name = "txtDOCUMENTO";
            this.txtDOCUMENTO.ReadOnly = true;
            this.txtDOCUMENTO.Size = new System.Drawing.Size(129, 30);
            this.txtDOCUMENTO.TabIndex = 110;
            this.txtDOCUMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(257, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "FECHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "LISTA #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "AUTORIZADO POR";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(157, 98);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(267, 20);
            this.txtResponsable.TabIndex = 115;
            // 
            // lbCONTRATOS
            // 
            this.lbCONTRATOS.AutoSize = true;
            this.lbCONTRATOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCONTRATOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCONTRATOS.Location = new System.Drawing.Point(947, 479);
            this.lbCONTRATOS.Name = "lbCONTRATOS";
            this.lbCONTRATOS.Size = new System.Drawing.Size(94, 13);
            this.lbCONTRATOS.TabIndex = 116;
            this.lbCONTRATOS.Text = "0 CONTRATOS";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.Enabled = false;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(88, 34);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(235, 21);
            this.cbxSUCURSAL.TabIndex = 119;
            this.cbxSUCURSAL.SelectedIndexChanged += new System.EventHandler(this.cbxSUCURSAL_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 118;
            this.label19.Text = "SUCURSAL";
            // 
            // bsKPM
            // 
            this.bsKPM.DataMember = "KPM";
            this.bsKPM.DataSource = this.dSKPM;
            // 
            // dSKPM
            // 
            this.dSKPM.DataSetName = "DSKPM";
            this.dSKPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Image = global::PrendaSAL.Properties.Resources.lista1;
            this.btnLISTAR.Location = new System.Drawing.Point(504, 83);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(122, 48);
            this.btnLISTAR.TabIndex = 121;
            this.btnLISTAR.Text = "CONTRATOS VENCIDOS";
            this.btnLISTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
            // 
            // txtNOTA
            // 
            // 
            // 
            // 
            this.txtNOTA.Border.Class = "TextBoxBorder";
            this.txtNOTA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNOTA.Location = new System.Drawing.Point(693, 34);
            this.txtNOTA.Multiline = true;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(358, 62);
            this.txtNOTA.TabIndex = 122;
            this.txtNOTA.WatermarkText = "Nota Adicional";
            // 
            // bsListaCierre
            // 
            this.bsListaCierre.DataMember = "LISTA_CIERRE";
            this.bsListaCierre.DataSource = this.dSCierre;
            // 
            // dSCierre
            // 
            this.dSCierre.DataSetName = "DSCierre";
            this.dSCierre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbREACTIVADOS
            // 
            this.lbREACTIVADOS.AutoSize = true;
            this.lbREACTIVADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREACTIVADOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbREACTIVADOS.Location = new System.Drawing.Point(947, 506);
            this.lbREACTIVADOS.Name = "lbREACTIVADOS";
            this.lbREACTIVADOS.Size = new System.Drawing.Size(94, 13);
            this.lbREACTIVADOS.TabIndex = 123;
            this.lbREACTIVADOS.Text = "0 CONTRATOS";
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTOTAL.Location = new System.Drawing.Point(947, 539);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(94, 13);
            this.lbTOTAL.TabIndex = 124;
            this.lbTOTAL.Text = "0 CONTRATOS";
            // 
            // tblKPM
            // 
            this.tblKPM.AllowUserToAddRows = false;
            this.tblKPM.AllowUserToDeleteRows = false;
            this.tblKPM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblKPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKPM.Location = new System.Drawing.Point(12, 462);
            this.tblKPM.Name = "tblKPM";
            this.tblKPM.ReadOnly = true;
            this.tblKPM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKPM.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblKPM.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.tblKPM.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblKPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblKPM.Size = new System.Drawing.Size(550, 70);
            this.tblKPM.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(925, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "_________________";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.ToolTipText = "Editar";
            // 
            // ID_PRESTAMO
            // 
            this.ID_PRESTAMO.DataPropertyName = "ID_PRESTAMO";
            this.ID_PRESTAMO.HeaderText = "ID_PRESTAMO";
            this.ID_PRESTAMO.Name = "ID_PRESTAMO";
            this.ID_PRESTAMO.ReadOnly = true;
            this.ID_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_PRESTAMO.Visible = false;
            // 
            // REACTIVADO
            // 
            this.REACTIVADO.DataPropertyName = "REACTIVADO";
            this.REACTIVADO.HeaderText = "R";
            this.REACTIVADO.Name = "REACTIVADO";
            this.REACTIVADO.ReadOnly = true;
            this.REACTIVADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REACTIVADO.Width = 20;
            // 
            // CONTRATO
            // 
            this.CONTRATO.DataPropertyName = "CONTRATO";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CONTRATO.DefaultCellStyle = dataGridViewCellStyle1;
            this.CONTRATO.HeaderText = "CONTRATO";
            this.CONTRATO.Name = "CONTRATO";
            this.CONTRATO.ReadOnly = true;
            this.CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CONTRATO.Width = 70;
            // 
            // FECHA_CONTRATO
            // 
            this.FECHA_CONTRATO.DataPropertyName = "FECHA_CONTRATO";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FECHA_CONTRATO.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA_CONTRATO.HeaderText = "FECHA";
            this.FECHA_CONTRATO.Name = "FECHA_CONTRATO";
            this.FECHA_CONTRATO.ReadOnly = true;
            this.FECHA_CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_CONTRATO.Width = 70;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle3;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CLIENTE.Width = 220;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CATEGORIA.DefaultCellStyle = dataGridViewCellStyle4;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ARTICULO.DefaultCellStyle = dataGridViewCellStyle5;
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.Width = 200;
            // 
            // PRESTAMO
            // 
            this.PRESTAMO.DataPropertyName = "PRESTAMO";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.Format = "C2";
            this.PRESTAMO.DefaultCellStyle = dataGridViewCellStyle6;
            this.PRESTAMO.HeaderText = "PRESTAMO";
            this.PRESTAMO.Name = "PRESTAMO";
            this.PRESTAMO.ReadOnly = true;
            this.PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRESTAMO.Width = 70;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            dataGridViewCellStyle7.Format = "C2";
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle7;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SALDO.Width = 70;
            // 
            // ESTADO_CONTRATO
            // 
            this.ESTADO_CONTRATO.DataPropertyName = "ESTADO_CONTRATO";
            this.ESTADO_CONTRATO.HeaderText = "ESTADO";
            this.ESTADO_CONTRATO.Name = "ESTADO_CONTRATO";
            this.ESTADO_CONTRATO.ReadOnly = true;
            this.ESTADO_CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DIAS_VENC
            // 
            this.DIAS_VENC.DataPropertyName = "DIAS_VENC";
            this.DIAS_VENC.HeaderText = "DIAS VENC";
            this.DIAS_VENC.Name = "DIAS_VENC";
            this.DIAS_VENC.ReadOnly = true;
            this.DIAS_VENC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIAS_VENC.Width = 50;
            // 
            // ListaVencidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblKPM);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.lbREACTIVADOS);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.btnLISTAR);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbCONTRATOS);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateVencidos);
            this.Controls.Add(this.txtDOCUMENTO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblCONTRATOS);
            this.Controls.Add(this.opciones);
            this.MaximizeBox = false;
            this.Name = "ListaVencidosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LISTA DE VENCIDOS";
            this.Load += new System.EventHandler(this.ListaVencidosForm_Load);
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCONTRATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.DataGridView tblCONTRATOS;
        private System.Windows.Forms.DateTimePicker dateVencidos;
        private System.Windows.Forms.TextBox txtDOCUMENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lbCONTRATOS;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.BindingSource bsListaCierre;
        private Informes.DSCierre dSCierre;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.Button btnLISTAR;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNOTA;
        private System.Windows.Forms.Label lbREACTIVADOS;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.DataGridView tblKPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRESTAMO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REACTIVADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_VENC;
    }
}