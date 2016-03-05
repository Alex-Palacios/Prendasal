namespace PrendaSAL.Movimientos
{
    partial class ComprasForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.opciones = new System.Windows.Forms.ToolStrip();
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
            this.btnPrintKITCO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNOTA = new System.Windows.Forms.RichTextBox();
            this.grbCOMPRA = new System.Windows.Forms.GroupBox();
            this.rdbMAYOREO = new System.Windows.Forms.RadioButton();
            this.lbNIVEL = new System.Windows.Forms.Label();
            this.rdbSUCURSAL = new System.Windows.Forms.RadioButton();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.txtDOCUMENTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbCLIENTE = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTARJETA = new System.Windows.Forms.Button();
            this.txtEdadCLI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccionCLI = new System.Windows.Forms.TextBox();
            this.txtDomicilioCLI = new System.Windows.Forms.TextBox();
            this.txtTelCLI = new System.Windows.Forms.TextBox();
            this.txtNombreCLI = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoCLI = new System.Windows.Forms.TextBox();
            this.txtExtCLI = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDocCLI = new System.Windows.Forms.TextBox();
            this.cbxBuscarPorCLI = new System.Windows.Forms.ComboBox();
            this.btnCLI = new System.Windows.Forms.Button();
            this.grbDETALLE = new System.Windows.Forms.GroupBox();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tblITEMS = new System.Windows.Forms.DataGridView();
            this.viewerCONTRATO = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.bindingKITCO = new System.Windows.Forms.BindingSource(this.components);
            this.dSKITCO = new PrendaSAL.Informes.DSKITCO();
            this.btnPrecios = new System.Windows.Forms.Button();
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.btnEditarItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminarItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones.SuspendLayout();
            this.grbCOMPRA.SuspendLayout();
            this.grbCLIENTE.SuspendLayout();
            this.grbDETALLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblITEMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingKITCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKITCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
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
            this.btnAnular,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnBuscar,
            this.btnReimprimir,
            this.btnPrintKITCO,
            this.toolStripSeparator4,
            this.btnLog,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(1067, 25);
            this.opciones.TabIndex = 1;
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
            // btnPrintKITCO
            // 
            this.btnPrintKITCO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrintKITCO.Image = global::PrendaSAL.Properties.Resources.kitcoico2;
            this.btnPrintKITCO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintKITCO.Name = "btnPrintKITCO";
            this.btnPrintKITCO.Size = new System.Drawing.Size(23, 22);
            this.btnPrintKITCO.Text = "Imprimir Detalle KITCO";
            this.btnPrintKITCO.Click += new System.EventHandler(this.btnPrintKITCO_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(916, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA
            // 
            this.txtNOTA.Location = new System.Drawing.Point(893, 353);
            this.txtNOTA.MaxLength = 100;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(162, 152);
            this.txtNOTA.TabIndex = 12;
            this.txtNOTA.Text = "";
            // 
            // grbCOMPRA
            // 
            this.grbCOMPRA.Controls.Add(this.rdbMAYOREO);
            this.grbCOMPRA.Controls.Add(this.lbNIVEL);
            this.grbCOMPRA.Controls.Add(this.rdbSUCURSAL);
            this.grbCOMPRA.Controls.Add(this.dateCompra);
            this.grbCOMPRA.Controls.Add(this.txtDOCUMENTO);
            this.grbCOMPRA.Controls.Add(this.label5);
            this.grbCOMPRA.Controls.Add(this.label1);
            this.grbCOMPRA.Controls.Add(this.cbxSUCURSAL);
            this.grbCOMPRA.Controls.Add(this.label19);
            this.grbCOMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCOMPRA.Location = new System.Drawing.Point(510, 41);
            this.grbCOMPRA.Name = "grbCOMPRA";
            this.grbCOMPRA.Size = new System.Drawing.Size(358, 241);
            this.grbCOMPRA.TabIndex = 74;
            this.grbCOMPRA.TabStop = false;
            this.grbCOMPRA.Text = "COMPRA";
            // 
            // rdbMAYOREO
            // 
            this.rdbMAYOREO.AutoSize = true;
            this.rdbMAYOREO.Location = new System.Drawing.Point(247, 197);
            this.rdbMAYOREO.Name = "rdbMAYOREO";
            this.rdbMAYOREO.Size = new System.Drawing.Size(86, 17);
            this.rdbMAYOREO.TabIndex = 8;
            this.rdbMAYOREO.Text = "MAYOREO";
            this.rdbMAYOREO.UseVisualStyleBackColor = true;
            this.rdbMAYOREO.CheckedChanged += new System.EventHandler(this.rdbMAYOREO_CheckedChanged);
            // 
            // lbNIVEL
            // 
            this.lbNIVEL.AutoSize = true;
            this.lbNIVEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNIVEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNIVEL.Location = new System.Drawing.Point(46, 172);
            this.lbNIVEL.Name = "lbNIVEL";
            this.lbNIVEL.Size = new System.Drawing.Size(74, 25);
            this.lbNIVEL.TabIndex = 85;
            this.lbNIVEL.Text = "NIVEL";
            // 
            // rdbSUCURSAL
            // 
            this.rdbSUCURSAL.AutoSize = true;
            this.rdbSUCURSAL.Location = new System.Drawing.Point(247, 163);
            this.rdbSUCURSAL.Name = "rdbSUCURSAL";
            this.rdbSUCURSAL.Size = new System.Drawing.Size(91, 17);
            this.rdbSUCURSAL.TabIndex = 7;
            this.rdbSUCURSAL.Text = "SUCURSAL";
            this.rdbSUCURSAL.UseVisualStyleBackColor = true;
            this.rdbSUCURSAL.CheckedChanged += new System.EventHandler(this.rdbSUCURSAL_CheckedChanged);
            // 
            // dateCompra
            // 
            this.dateCompra.Enabled = false;
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompra.Location = new System.Drawing.Point(142, 114);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(129, 20);
            this.dateCompra.TabIndex = 6;
            // 
            // txtDOCUMENTO
            // 
            this.txtDOCUMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO.Location = new System.Drawing.Point(142, 64);
            this.txtDOCUMENTO.Name = "txtDOCUMENTO";
            this.txtDOCUMENTO.ReadOnly = true;
            this.txtDOCUMENTO.Size = new System.Drawing.Size(129, 30);
            this.txtDOCUMENTO.TabIndex = 5;
            this.txtDOCUMENTO.TabStop = false;
            this.txtDOCUMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(53, 120);
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
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# COMPRA";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.Enabled = false;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(142, 25);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(196, 21);
            this.cbxSUCURSAL.TabIndex = 4;
            this.cbxSUCURSAL.SelectedIndexChanged += new System.EventHandler(this.cbxSUCURSAL_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(48, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 84;
            this.label19.Text = "SUCURSAL";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTOTAL.Location = new System.Drawing.Point(675, 511);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(135, 32);
            this.txtTOTAL.TabIndex = 0;
            this.txtTOTAL.TabStop = false;
            this.txtTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(557, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "T O T A L";
            // 
            // grbCLIENTE
            // 
            this.grbCLIENTE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCLIENTE.Controls.Add(this.label3);
            this.grbCLIENTE.Controls.Add(this.btnTARJETA);
            this.grbCLIENTE.Controls.Add(this.txtEdadCLI);
            this.grbCLIENTE.Controls.Add(this.label12);
            this.grbCLIENTE.Controls.Add(this.txtDireccionCLI);
            this.grbCLIENTE.Controls.Add(this.txtDomicilioCLI);
            this.grbCLIENTE.Controls.Add(this.txtTelCLI);
            this.grbCLIENTE.Controls.Add(this.txtNombreCLI);
            this.grbCLIENTE.Controls.Add(this.label16);
            this.grbCLIENTE.Controls.Add(this.label14);
            this.grbCLIENTE.Controls.Add(this.label13);
            this.grbCLIENTE.Controls.Add(this.label11);
            this.grbCLIENTE.Controls.Add(this.txtCodigoCLI);
            this.grbCLIENTE.Controls.Add(this.txtExtCLI);
            this.grbCLIENTE.Controls.Add(this.label17);
            this.grbCLIENTE.Controls.Add(this.txtDocCLI);
            this.grbCLIENTE.Controls.Add(this.cbxBuscarPorCLI);
            this.grbCLIENTE.Controls.Add(this.btnCLI);
            this.grbCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCLIENTE.Location = new System.Drawing.Point(24, 39);
            this.grbCLIENTE.Name = "grbCLIENTE";
            this.grbCLIENTE.Size = new System.Drawing.Size(480, 243);
            this.grbCLIENTE.TabIndex = 73;
            this.grbCLIENTE.TabStop = false;
            this.grbCLIENTE.Text = "DATOS DEL CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "AÑOS";
            // 
            // btnTARJETA
            // 
            this.btnTARJETA.BackgroundImage = global::PrendaSAL.Properties.Resources.documentos3;
            this.btnTARJETA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTARJETA.Location = new System.Drawing.Point(366, 94);
            this.btnTARJETA.Name = "btnTARJETA";
            this.btnTARJETA.Size = new System.Drawing.Size(91, 63);
            this.btnTARJETA.TabIndex = 3;
            this.btnTARJETA.UseVisualStyleBackColor = true;
            this.btnTARJETA.Click += new System.EventHandler(this.btnTARJETA_Click);
            // 
            // txtEdadCLI
            // 
            this.txtEdadCLI.Location = new System.Drawing.Point(99, 94);
            this.txtEdadCLI.Name = "txtEdadCLI";
            this.txtEdadCLI.ReadOnly = true;
            this.txtEdadCLI.Size = new System.Drawing.Size(56, 20);
            this.txtEdadCLI.TabIndex = 83;
            this.txtEdadCLI.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "EDAD";
            // 
            // txtDireccionCLI
            // 
            this.txtDireccionCLI.Location = new System.Drawing.Point(99, 180);
            this.txtDireccionCLI.Multiline = true;
            this.txtDireccionCLI.Name = "txtDireccionCLI";
            this.txtDireccionCLI.ReadOnly = true;
            this.txtDireccionCLI.Size = new System.Drawing.Size(358, 36);
            this.txtDireccionCLI.TabIndex = 81;
            this.txtDireccionCLI.TabStop = false;
            // 
            // txtDomicilioCLI
            // 
            this.txtDomicilioCLI.Location = new System.Drawing.Point(99, 151);
            this.txtDomicilioCLI.Name = "txtDomicilioCLI";
            this.txtDomicilioCLI.ReadOnly = true;
            this.txtDomicilioCLI.Size = new System.Drawing.Size(182, 20);
            this.txtDomicilioCLI.TabIndex = 80;
            this.txtDomicilioCLI.TabStop = false;
            // 
            // txtTelCLI
            // 
            this.txtTelCLI.Location = new System.Drawing.Point(99, 125);
            this.txtTelCLI.Name = "txtTelCLI";
            this.txtTelCLI.ReadOnly = true;
            this.txtTelCLI.Size = new System.Drawing.Size(124, 20);
            this.txtTelCLI.TabIndex = 79;
            this.txtTelCLI.TabStop = false;
            // 
            // txtNombreCLI
            // 
            this.txtNombreCLI.Location = new System.Drawing.Point(99, 66);
            this.txtNombreCLI.Name = "txtNombreCLI";
            this.txtNombreCLI.ReadOnly = true;
            this.txtNombreCLI.Size = new System.Drawing.Size(375, 20);
            this.txtNombreCLI.TabIndex = 78;
            this.txtNombreCLI.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "TEL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "DIRECCION";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "DOMICILIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "CLIENTE";
            // 
            // txtCodigoCLI
            // 
            this.txtCodigoCLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCLI.Location = new System.Drawing.Point(6, 16);
            this.txtCodigoCLI.Name = "txtCodigoCLI";
            this.txtCodigoCLI.ReadOnly = true;
            this.txtCodigoCLI.Size = new System.Drawing.Size(140, 26);
            this.txtCodigoCLI.TabIndex = 12;
            this.txtCodigoCLI.TabStop = false;
            this.txtCodigoCLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExtCLI
            // 
            this.txtExtCLI.Location = new System.Drawing.Point(208, 43);
            this.txtExtCLI.Name = "txtExtCLI";
            this.txtExtCLI.ReadOnly = true;
            this.txtExtCLI.Size = new System.Drawing.Size(193, 20);
            this.txtExtCLI.TabIndex = 39;
            this.txtExtCLI.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(171, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "EXT";
            // 
            // txtDocCLI
            // 
            this.txtDocCLI.Location = new System.Drawing.Point(253, 16);
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
            this.cbxBuscarPorCLI.Location = new System.Drawing.Point(152, 16);
            this.cbxBuscarPorCLI.Name = "cbxBuscarPorCLI";
            this.cbxBuscarPorCLI.Size = new System.Drawing.Size(95, 21);
            this.cbxBuscarPorCLI.TabIndex = 0;
            // 
            // btnCLI
            // 
            this.btnCLI.Image = global::PrendaSAL.Properties.Resources.cliente;
            this.btnCLI.Location = new System.Drawing.Point(407, 10);
            this.btnCLI.Name = "btnCLI";
            this.btnCLI.Size = new System.Drawing.Size(67, 53);
            this.btnCLI.TabIndex = 2;
            this.btnCLI.UseVisualStyleBackColor = true;
            this.btnCLI.Click += new System.EventHandler(this.btnCLI_Click);
            // 
            // grbDETALLE
            // 
            this.grbDETALLE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbDETALLE.Controls.Add(this.cbxCategorias);
            this.grbDETALLE.Controls.Add(this.label2);
            this.grbDETALLE.Controls.Add(this.button2);
            this.grbDETALLE.Controls.Add(this.tblITEMS);
            this.grbDETALLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDETALLE.Location = new System.Drawing.Point(24, 288);
            this.grbDETALLE.Name = "grbDETALLE";
            this.grbDETALLE.Size = new System.Drawing.Size(844, 217);
            this.grbDETALLE.TabIndex = 84;
            this.grbDETALLE.TabStop = false;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(93, 11);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(130, 21);
            this.cbxCategorias.TabIndex = 85;
            this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxCategorias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "CATEGORIA";
            // 
            // button2
            // 
            this.button2.Image = global::PrendaSAL.Properties.Resources.plus;
            this.button2.Location = new System.Drawing.Point(229, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 25);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addItemCompra);
            // 
            // tblITEMS
            // 
            this.tblITEMS.AllowUserToAddRows = false;
            this.tblITEMS.AllowUserToDeleteRows = false;
            this.tblITEMS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblITEMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditarItem,
            this.btnEliminarItem,
            this.COD_ITEM,
            this.TIPO,
            this.CANTIDAD,
            this.DESCRIPCION,
            this.MONTO});
            this.tblITEMS.Location = new System.Drawing.Point(6, 37);
            this.tblITEMS.MultiSelect = false;
            this.tblITEMS.Name = "tblITEMS";
            this.tblITEMS.ReadOnly = true;
            this.tblITEMS.RowHeadersVisible = false;
            this.tblITEMS.RowHeadersWidth = 40;
            this.tblITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblITEMS.Size = new System.Drawing.Size(832, 174);
            this.tblITEMS.TabIndex = 3;
            this.tblITEMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblITEMS_CellContentClick);
            this.tblITEMS.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblITEMS_CellPainting);
            // 
            // viewerCONTRATO
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerCONTRATO.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerCONTRATO.LocalReport.ReportEmbeddedResource = "";
            this.viewerCONTRATO.Location = new System.Drawing.Point(897, 0);
            this.viewerCONTRATO.Name = "viewerCONTRATO";
            this.viewerCONTRATO.Size = new System.Drawing.Size(170, 25);
            this.viewerCONTRATO.TabIndex = 89;
            this.viewerCONTRATO.Visible = false;
            this.viewerCONTRATO.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.ShowPrintDialog);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // bindingKITCO
            // 
            this.bindingKITCO.DataMember = "KITCO";
            this.bindingKITCO.DataSource = this.dSKITCO;
            // 
            // dSKITCO
            // 
            this.dSKITCO.DataSetName = "DSKITCO";
            this.dSKITCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrecios
            // 
            this.btnPrecios.BackgroundImage = global::PrendaSAL.Properties.Resources.precioORO2;
            this.btnPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrecios.Location = new System.Drawing.Point(893, 187);
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Size = new System.Drawing.Size(162, 141);
            this.btnPrecios.TabIndex = 9;
            this.btnPrecios.UseVisualStyleBackColor = true;
            this.btnPrecios.Click += new System.EventHandler(this.btnPrecios_Click);
            // 
            // picLOGO
            // 
            this.picLOGO.BackgroundImage = global::PrendaSAL.Properties.Resources.logo;
            this.picLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLOGO.Location = new System.Drawing.Point(893, 49);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(162, 132);
            this.picLOGO.TabIndex = 76;
            this.picLOGO.TabStop = false;
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Frozen = true;
            this.btnEditarItem.HeaderText = "";
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.ReadOnly = true;
            this.btnEditarItem.Width = 20;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Frozen = true;
            this.btnEliminarItem.HeaderText = "";
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.ReadOnly = true;
            this.btnEliminarItem.Width = 20;
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.DataPropertyName = "COD_ITEM";
            dataGridViewCellStyle1.NullValue = "-----";
            this.COD_ITEM.DefaultCellStyle = dataGridViewCellStyle1;
            this.COD_ITEM.Frozen = true;
            this.COD_ITEM.HeaderText = "KILATAJE";
            this.COD_ITEM.Name = "COD_ITEM";
            this.COD_ITEM.ReadOnly = true;
            this.COD_ITEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_ITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ITEM.Width = 125;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.Frozen = true;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIPO.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle2.Format = "N1";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.DESCRIPCION.ToolTipText = "Descripcion detallada del Articulo o Prenda";
            this.DESCRIPCION.Width = 400;
            // 
            // MONTO
            // 
            this.MONTO.DataPropertyName = "MONTO";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle3;
            this.MONTO.Frozen = true;
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            this.MONTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 561);
            this.Controls.Add(this.viewerCONTRATO);
            this.Controls.Add(this.grbDETALLE);
            this.Controls.Add(this.btnPrecios);
            this.Controls.Add(this.picLOGO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.grbCOMPRA);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbCLIENTE);
            this.Controls.Add(this.opciones);
            this.MaximizeBox = false;
            this.Name = "ComprasForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "C O M P R A S";
            this.Load += new System.EventHandler(this.ComprasForm_Load);
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            this.grbCOMPRA.ResumeLayout(false);
            this.grbCOMPRA.PerformLayout();
            this.grbCLIENTE.ResumeLayout(false);
            this.grbCLIENTE.PerformLayout();
            this.grbDETALLE.ResumeLayout(false);
            this.grbDETALLE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblITEMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingKITCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKITCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.Button btnPrecios;
        private System.Windows.Forms.PictureBox picLOGO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtNOTA;
        private System.Windows.Forms.GroupBox grbCOMPRA;
        private System.Windows.Forms.DateTimePicker dateCompra;
        private System.Windows.Forms.TextBox txtDOCUMENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbCLIENTE;
        private System.Windows.Forms.TextBox txtCodigoCLI;
        private System.Windows.Forms.TextBox txtExtCLI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDocCLI;
        private System.Windows.Forms.Button btnCLI;
        private System.Windows.Forms.RadioButton rdbMAYOREO;
        private System.Windows.Forms.RadioButton rdbSUCURSAL;
        private System.Windows.Forms.TextBox txtEdadCLI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccionCLI;
        private System.Windows.Forms.TextBox txtDomicilioCLI;
        private System.Windows.Forms.TextBox txtTelCLI;
        private System.Windows.Forms.TextBox txtNombreCLI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbDETALLE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tblITEMS;
        private System.Windows.Forms.PrintDialog printDialog;
        private Microsoft.Reporting.WinForms.ReportViewer viewerCONTRATO;
        private System.Windows.Forms.Button btnTARJETA;
        private System.Windows.Forms.Label lbNIVEL;
        private System.Windows.Forms.ComboBox cbxBuscarPorCLI;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnPrintKITCO;
        private System.Windows.Forms.BindingSource bindingKITCO;
        private Informes.DSKITCO dSKITCO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarItem;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
    }
}