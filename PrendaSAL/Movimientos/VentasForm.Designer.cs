﻿namespace PrendaSAL.Movimientos
{
    partial class VentasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNOTA = new System.Windows.Forms.RichTextBox();
            this.grbVENTA = new System.Windows.Forms.GroupBox();
            this.cbxTIPODOC = new System.Windows.Forms.ComboBox();
            this.dateVenta = new System.Windows.Forms.DateTimePicker();
            this.txtNUM_DOC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.grbCLIENTE = new System.Windows.Forms.GroupBox();
            this.btnTARJETA = new System.Windows.Forms.Button();
            this.txtEdadCLI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccionCLI = new System.Windows.Forms.TextBox();
            this.txtDomicilioCLI = new System.Windows.Forms.TextBox();
            this.txtTelCLI = new System.Windows.Forms.TextBox();
            this.txtClienteCLI = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoCLI = new System.Windows.Forms.TextBox();
            this.txtExpCLI = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDocCLI = new System.Windows.Forms.TextBox();
            this.cbxBuscarPorCLI = new System.Windows.Forms.ComboBox();
            this.btnCLI = new System.Windows.Forms.Button();
            this.lbNIVEL = new System.Windows.Forms.Label();
            this.lbSUMAS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDESCUENTO = new System.Windows.Forms.TextBox();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDETALLE = new System.Windows.Forms.GroupBox();
            this.tblITEMS = new System.Windows.Forms.DataGridView();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_IMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO_IMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALUO_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewerFACTURA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingFCF = new System.Windows.Forms.BindingSource(this.components);
            this.dSItemFCF = new PrendaSAL.Informes.DSItemFCF();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
            this.grbVENTA.SuspendLayout();
            this.grbCLIENTE.SuspendLayout();
            this.grbDETALLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblITEMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingFCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSItemFCF)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.btnLog.Click += new System.EventHandler(this.LOG);
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
            // picLOGO
            // 
            this.picLOGO.BackgroundImage = global::PrendaSAL.Properties.Resources.logo;
            this.picLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLOGO.Location = new System.Drawing.Point(880, 50);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(175, 183);
            this.picLOGO.TabIndex = 89;
            this.picLOGO.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(902, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA
            // 
            this.txtNOTA.Location = new System.Drawing.Point(865, 288);
            this.txtNOTA.MaxLength = 100;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(190, 151);
            this.txtNOTA.TabIndex = 92;
            this.txtNOTA.Text = "";
            // 
            // grbVENTA
            // 
            this.grbVENTA.Controls.Add(this.cbxTIPODOC);
            this.grbVENTA.Controls.Add(this.dateVenta);
            this.grbVENTA.Controls.Add(this.txtNUM_DOC);
            this.grbVENTA.Controls.Add(this.label5);
            this.grbVENTA.Controls.Add(this.label1);
            this.grbVENTA.Controls.Add(this.label19);
            this.grbVENTA.Controls.Add(this.cbxSUCURSAL);
            this.grbVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVENTA.Location = new System.Drawing.Point(494, 40);
            this.grbVENTA.Name = "grbVENTA";
            this.grbVENTA.Size = new System.Drawing.Size(365, 225);
            this.grbVENTA.TabIndex = 87;
            this.grbVENTA.TabStop = false;
            this.grbVENTA.Text = "VENTA";
            // 
            // cbxTIPODOC
            // 
            this.cbxTIPODOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPODOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTIPODOC.FormattingEnabled = true;
            this.cbxTIPODOC.Location = new System.Drawing.Point(22, 69);
            this.cbxTIPODOC.Name = "cbxTIPODOC";
            this.cbxTIPODOC.Size = new System.Drawing.Size(112, 24);
            this.cbxTIPODOC.TabIndex = 98;
            // 
            // dateVenta
            // 
            this.dateVenta.Enabled = false;
            this.dateVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenta.Location = new System.Drawing.Point(140, 122);
            this.dateVenta.Name = "dateVenta";
            this.dateVenta.Size = new System.Drawing.Size(129, 20);
            this.dateVenta.TabIndex = 9;
            // 
            // txtNUM_DOC
            // 
            this.txtNUM_DOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUM_DOC.Location = new System.Drawing.Point(140, 69);
            this.txtNUM_DOC.Name = "txtNUM_DOC";
            this.txtNUM_DOC.Size = new System.Drawing.Size(129, 30);
            this.txtNUM_DOC.TabIndex = 4;
            this.txtNUM_DOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(87, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(166, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(61, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 96;
            this.label19.Text = "SUCURSAL";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.Enabled = false;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(140, 19);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(213, 21);
            this.cbxSUCURSAL.TabIndex = 97;
            // 
            // btnDEL
            // 
            this.btnDEL.Image = global::PrendaSAL.Properties.Resources.menos;
            this.btnDEL.Location = new System.Drawing.Point(798, 65);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(37, 25);
            this.btnDEL.TabIndex = 95;
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.removeItemVenta);
            // 
            // btnADD
            // 
            this.btnADD.Image = global::PrendaSAL.Properties.Resources.buscar;
            this.btnADD.Location = new System.Drawing.Point(798, 34);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(37, 25);
            this.btnADD.TabIndex = 94;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.addItemVenta);
            // 
            // grbCLIENTE
            // 
            this.grbCLIENTE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCLIENTE.Controls.Add(this.btnTARJETA);
            this.grbCLIENTE.Controls.Add(this.txtEdadCLI);
            this.grbCLIENTE.Controls.Add(this.label12);
            this.grbCLIENTE.Controls.Add(this.txtDireccionCLI);
            this.grbCLIENTE.Controls.Add(this.txtDomicilioCLI);
            this.grbCLIENTE.Controls.Add(this.txtTelCLI);
            this.grbCLIENTE.Controls.Add(this.txtClienteCLI);
            this.grbCLIENTE.Controls.Add(this.label16);
            this.grbCLIENTE.Controls.Add(this.label14);
            this.grbCLIENTE.Controls.Add(this.label13);
            this.grbCLIENTE.Controls.Add(this.label11);
            this.grbCLIENTE.Controls.Add(this.txtCodigoCLI);
            this.grbCLIENTE.Controls.Add(this.txtExpCLI);
            this.grbCLIENTE.Controls.Add(this.label17);
            this.grbCLIENTE.Controls.Add(this.txtDocCLI);
            this.grbCLIENTE.Controls.Add(this.cbxBuscarPorCLI);
            this.grbCLIENTE.Controls.Add(this.btnCLI);
            this.grbCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCLIENTE.Location = new System.Drawing.Point(12, 38);
            this.grbCLIENTE.Name = "grbCLIENTE";
            this.grbCLIENTE.Size = new System.Drawing.Size(476, 225);
            this.grbCLIENTE.TabIndex = 86;
            this.grbCLIENTE.TabStop = false;
            this.grbCLIENTE.Text = "DATOS DEL CLIENTE";
            // 
            // btnTARJETA
            // 
            this.btnTARJETA.BackgroundImage = global::PrendaSAL.Properties.Resources.documentos3;
            this.btnTARJETA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTARJETA.Location = new System.Drawing.Point(364, 94);
            this.btnTARJETA.Name = "btnTARJETA";
            this.btnTARJETA.Size = new System.Drawing.Size(91, 63);
            this.btnTARJETA.TabIndex = 3;
            this.btnTARJETA.UseVisualStyleBackColor = true;
            this.btnTARJETA.Click += new System.EventHandler(this.btnTARJETA_Click);
            // 
            // txtEdadCLI
            // 
            this.txtEdadCLI.Location = new System.Drawing.Point(97, 96);
            this.txtEdadCLI.Name = "txtEdadCLI";
            this.txtEdadCLI.ReadOnly = true;
            this.txtEdadCLI.Size = new System.Drawing.Size(90, 20);
            this.txtEdadCLI.TabIndex = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 99;
            this.label12.Text = "EDAD";
            // 
            // txtDireccionCLI
            // 
            this.txtDireccionCLI.Location = new System.Drawing.Point(97, 182);
            this.txtDireccionCLI.Multiline = true;
            this.txtDireccionCLI.Name = "txtDireccionCLI";
            this.txtDireccionCLI.ReadOnly = true;
            this.txtDireccionCLI.Size = new System.Drawing.Size(358, 36);
            this.txtDireccionCLI.TabIndex = 98;
            // 
            // txtDomicilioCLI
            // 
            this.txtDomicilioCLI.Location = new System.Drawing.Point(97, 153);
            this.txtDomicilioCLI.Name = "txtDomicilioCLI";
            this.txtDomicilioCLI.ReadOnly = true;
            this.txtDomicilioCLI.Size = new System.Drawing.Size(182, 20);
            this.txtDomicilioCLI.TabIndex = 97;
            // 
            // txtTelCLI
            // 
            this.txtTelCLI.Location = new System.Drawing.Point(97, 127);
            this.txtTelCLI.Name = "txtTelCLI";
            this.txtTelCLI.ReadOnly = true;
            this.txtTelCLI.Size = new System.Drawing.Size(124, 20);
            this.txtTelCLI.TabIndex = 96;
            // 
            // txtClienteCLI
            // 
            this.txtClienteCLI.Location = new System.Drawing.Point(97, 68);
            this.txtClienteCLI.Name = "txtClienteCLI";
            this.txtClienteCLI.ReadOnly = true;
            this.txtClienteCLI.Size = new System.Drawing.Size(375, 20);
            this.txtClienteCLI.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "TEL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 93;
            this.label14.Text = "DIRECCION";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "DOMICILIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "CLIENTE";
            // 
            // txtCodigoCLI
            // 
            this.txtCodigoCLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCLI.Location = new System.Drawing.Point(4, 18);
            this.txtCodigoCLI.Name = "txtCodigoCLI";
            this.txtCodigoCLI.ReadOnly = true;
            this.txtCodigoCLI.Size = new System.Drawing.Size(140, 26);
            this.txtCodigoCLI.TabIndex = 85;
            this.txtCodigoCLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExpCLI
            // 
            this.txtExpCLI.Location = new System.Drawing.Point(206, 45);
            this.txtExpCLI.Name = "txtExpCLI";
            this.txtExpCLI.ReadOnly = true;
            this.txtExpCLI.Size = new System.Drawing.Size(193, 20);
            this.txtExpCLI.TabIndex = 90;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(156, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "EXP";
            // 
            // txtDocCLI
            // 
            this.txtDocCLI.Location = new System.Drawing.Point(251, 18);
            this.txtDocCLI.Multiline = true;
            this.txtDocCLI.Name = "txtDocCLI";
            this.txtDocCLI.Size = new System.Drawing.Size(148, 21);
            this.txtDocCLI.TabIndex = 1;
            this.txtDocCLI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocCLI_KeyPress);
            // 
            // cbxBuscarPorCLI
            // 
            this.cbxBuscarPorCLI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscarPorCLI.FormattingEnabled = true;
            this.cbxBuscarPorCLI.Items.AddRange(new object[] {
            "DUI",
            "LICENCIA",
            "PASAPORTE",
            "CARNET"});
            this.cbxBuscarPorCLI.Location = new System.Drawing.Point(150, 18);
            this.cbxBuscarPorCLI.Name = "cbxBuscarPorCLI";
            this.cbxBuscarPorCLI.Size = new System.Drawing.Size(95, 21);
            this.cbxBuscarPorCLI.TabIndex = 87;
            // 
            // btnCLI
            // 
            this.btnCLI.Image = global::PrendaSAL.Properties.Resources.cliente;
            this.btnCLI.Location = new System.Drawing.Point(405, 12);
            this.btnCLI.Name = "btnCLI";
            this.btnCLI.Size = new System.Drawing.Size(67, 53);
            this.btnCLI.TabIndex = 2;
            this.btnCLI.UseVisualStyleBackColor = true;
            this.btnCLI.Click += new System.EventHandler(this.btnCLI_Click);
            // 
            // lbNIVEL
            // 
            this.lbNIVEL.AutoSize = true;
            this.lbNIVEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNIVEL.Location = new System.Drawing.Point(48, 482);
            this.lbNIVEL.Name = "lbNIVEL";
            this.lbNIVEL.Size = new System.Drawing.Size(74, 25);
            this.lbNIVEL.TabIndex = 98;
            this.lbNIVEL.Text = "NIVEL";
            // 
            // lbSUMAS
            // 
            this.lbSUMAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSUMAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSUMAS.Location = new System.Drawing.Point(660, 456);
            this.lbSUMAS.Name = "lbSUMAS";
            this.lbSUMAS.Size = new System.Drawing.Size(135, 17);
            this.lbSUMAS.TabIndex = 104;
            this.lbSUMAS.Text = "$0.00";
            this.lbSUMAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(537, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "SUMAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(537, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "DESCUENTO";
            // 
            // txtDESCUENTO
            // 
            this.txtDESCUENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESCUENTO.Location = new System.Drawing.Point(663, 482);
            this.txtDESCUENTO.Name = "txtDESCUENTO";
            this.txtDESCUENTO.ReadOnly = true;
            this.txtDESCUENTO.Size = new System.Drawing.Size(135, 23);
            this.txtDESCUENTO.TabIndex = 101;
            this.txtDESCUENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTOTAL.Location = new System.Drawing.Point(663, 511);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(135, 32);
            this.txtTOTAL.TabIndex = 5;
            this.txtTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(536, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 100;
            this.label4.Text = "T O T A L";
            // 
            // grbDETALLE
            // 
            this.grbDETALLE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbDETALLE.Controls.Add(this.tblITEMS);
            this.grbDETALLE.Controls.Add(this.btnADD);
            this.grbDETALLE.Controls.Add(this.btnDEL);
            this.grbDETALLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDETALLE.Location = new System.Drawing.Point(12, 271);
            this.grbDETALLE.Name = "grbDETALLE";
            this.grbDETALLE.Size = new System.Drawing.Size(847, 182);
            this.grbDETALLE.TabIndex = 105;
            this.grbDETALLE.TabStop = false;
            this.grbDETALLE.Text = "DETALLE COMPRA";
            // 
            // tblITEMS
            // 
            this.tblITEMS.AllowUserToAddRows = false;
            this.tblITEMS.AllowUserToDeleteRows = false;
            this.tblITEMS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblITEMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORIA,
            this.ITEM,
            this.CANTIDAD,
            this.DESCRIPCION,
            this.PRECIO_UNIT,
            this.MONTO,
            this.CUENTA,
            this.TAX,
            this.PRECIO_IMP,
            this.MONTO_IMP,
            this.INV,
            this.VALUO_UNIT});
            this.tblITEMS.Location = new System.Drawing.Point(6, 17);
            this.tblITEMS.Name = "tblITEMS";
            this.tblITEMS.ReadOnly = true;
            this.tblITEMS.Size = new System.Drawing.Size(786, 165);
            this.tblITEMS.TabIndex = 3;
            this.tblITEMS.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tblITEMS_CellBeginEdit);
            this.tblITEMS.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblITEMS_CellEndEdit);
            this.tblITEMS.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblITEMS_CellPainting);
            this.tblITEMS.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tblITEMS_CellValidating);
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            dataGridViewCellStyle1.NullValue = "-----";
            this.CATEGORIA.DefaultCellStyle = dataGridViewCellStyle1;
            this.CATEGORIA.Frozen = true;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ITEM
            // 
            this.ITEM.DataPropertyName = "COD_ITEM";
            dataGridViewCellStyle2.NullValue = "-----";
            this.ITEM.DefaultCellStyle = dataGridViewCellStyle2;
            this.ITEM.Frozen = true;
            this.ITEM.HeaderText = "KIL/ART";
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            this.ITEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle3.Format = "N1";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle3;
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "PESO/CANT";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.Frozen = true;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 325;
            // 
            // PRECIO_UNIT
            // 
            this.PRECIO_UNIT.DataPropertyName = "PRECIO_UNIT";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.PRECIO_UNIT.DefaultCellStyle = dataGridViewCellStyle4;
            this.PRECIO_UNIT.Frozen = true;
            this.PRECIO_UNIT.HeaderText = "PRECIO_UNIT";
            this.PRECIO_UNIT.Name = "PRECIO_UNIT";
            this.PRECIO_UNIT.ReadOnly = true;
            this.PRECIO_UNIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO_UNIT.Visible = false;
            // 
            // MONTO
            // 
            this.MONTO.DataPropertyName = "MONTO";
            dataGridViewCellStyle5.Format = "C2";
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle5;
            this.MONTO.Frozen = true;
            this.MONTO.HeaderText = "MONTO_SIMP";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            this.MONTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MONTO.Visible = false;
            // 
            // CUENTA
            // 
            this.CUENTA.DataPropertyName = "CUENTA";
            this.CUENTA.Frozen = true;
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            this.CUENTA.ReadOnly = true;
            this.CUENTA.Visible = false;
            // 
            // TAX
            // 
            this.TAX.DataPropertyName = "TAX";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.TAX.DefaultCellStyle = dataGridViewCellStyle6;
            this.TAX.Frozen = true;
            this.TAX.HeaderText = "TAX";
            this.TAX.Name = "TAX";
            this.TAX.ReadOnly = true;
            this.TAX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TAX.Visible = false;
            // 
            // PRECIO_IMP
            // 
            this.PRECIO_IMP.DataPropertyName = "PRECIO_IMP";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.PRECIO_IMP.DefaultCellStyle = dataGridViewCellStyle7;
            this.PRECIO_IMP.Frozen = true;
            this.PRECIO_IMP.HeaderText = "PRECIO_IMP";
            this.PRECIO_IMP.Name = "PRECIO_IMP";
            this.PRECIO_IMP.ReadOnly = true;
            this.PRECIO_IMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO_IMP.Visible = false;
            // 
            // MONTO_IMP
            // 
            this.MONTO_IMP.DataPropertyName = "MONTO_IMP";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.MONTO_IMP.DefaultCellStyle = dataGridViewCellStyle8;
            this.MONTO_IMP.Frozen = true;
            this.MONTO_IMP.HeaderText = "MONTO";
            this.MONTO_IMP.Name = "MONTO_IMP";
            this.MONTO_IMP.ReadOnly = true;
            this.MONTO_IMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // INV
            // 
            this.INV.DataPropertyName = "INV";
            this.INV.Frozen = true;
            this.INV.HeaderText = "INV";
            this.INV.Name = "INV";
            this.INV.ReadOnly = true;
            this.INV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.INV.Visible = false;
            // 
            // VALUO_UNIT
            // 
            this.VALUO_UNIT.DataPropertyName = "VALUO_UNIT";
            dataGridViewCellStyle9.Format = "C2";
            this.VALUO_UNIT.DefaultCellStyle = dataGridViewCellStyle9;
            this.VALUO_UNIT.HeaderText = "VALUO_UNIT";
            this.VALUO_UNIT.Name = "VALUO_UNIT";
            this.VALUO_UNIT.ReadOnly = true;
            this.VALUO_UNIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VALUO_UNIT.Visible = false;
            // 
            // viewerFACTURA
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerFACTURA.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerFACTURA.LocalReport.ReportEmbeddedResource = "";
            this.viewerFACTURA.Location = new System.Drawing.Point(865, 0);
            this.viewerFACTURA.Name = "viewerFACTURA";
            this.viewerFACTURA.Size = new System.Drawing.Size(170, 25);
            this.viewerFACTURA.TabIndex = 106;
            this.viewerFACTURA.Visible = false;
            this.viewerFACTURA.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.ShowPrintDialog);
            // 
            // bindingFCF
            // 
            this.bindingFCF.DataMember = "ITEM";
            this.bindingFCF.DataSource = this.dSItemFCF;
            // 
            // dSItemFCF
            // 
            this.dSItemFCF.DataSetName = "DSItemFCF";
            this.dSItemFCF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.viewerFACTURA);
            this.Controls.Add(this.grbDETALLE);
            this.Controls.Add(this.lbSUMAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDESCUENTO);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNIVEL);
            this.Controls.Add(this.picLOGO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.grbVENTA);
            this.Controls.Add(this.grbCLIENTE);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
            this.grbVENTA.ResumeLayout(false);
            this.grbVENTA.PerformLayout();
            this.grbCLIENTE.ResumeLayout(false);
            this.grbCLIENTE.PerformLayout();
            this.grbDETALLE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblITEMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingFCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSItemFCF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.PictureBox picLOGO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtNOTA;
        private System.Windows.Forms.GroupBox grbVENTA;
        private System.Windows.Forms.DateTimePicker dateVenta;
        private System.Windows.Forms.TextBox txtNUM_DOC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grbCLIENTE;
        private System.Windows.Forms.Button btnTARJETA;
        private System.Windows.Forms.TextBox txtEdadCLI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccionCLI;
        private System.Windows.Forms.TextBox txtDomicilioCLI;
        private System.Windows.Forms.TextBox txtTelCLI;
        private System.Windows.Forms.TextBox txtClienteCLI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoCLI;
        private System.Windows.Forms.TextBox txtExpCLI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDocCLI;
        private System.Windows.Forms.ComboBox cbxBuscarPorCLI;
        private System.Windows.Forms.Button btnCLI;
        private System.Windows.Forms.Label lbNIVEL;
        private System.Windows.Forms.ComboBox cbxTIPODOC;
        private System.Windows.Forms.Label lbSUMAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDESCUENTO;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDETALLE;
        private System.Windows.Forms.DataGridView tblITEMS;
        private Microsoft.Reporting.WinForms.ReportViewer viewerFACTURA;
        private System.Windows.Forms.BindingSource bindingFCF;
        private Informes.DSItemFCF dSItemFCF;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.DataGridViewComboBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewComboBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_IMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_IMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALUO_UNIT;
    }
}