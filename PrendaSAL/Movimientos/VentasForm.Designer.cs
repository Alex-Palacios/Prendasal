namespace PrendaSAL.Movimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.lbDOCUMENTO = new System.Windows.Forms.Label();
            this.lbNIVEL = new System.Windows.Forms.Label();
            this.dateVenta = new System.Windows.Forms.DateTimePicker();
            this.txtNUMVENTA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.grbCLIENTE = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.lbSUMAS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDETALLE = new System.Windows.Forms.GroupBox();
            this.tblITEMS = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewerFACTURA = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingFCF = new System.Windows.Forms.BindingSource(this.components);
            this.dSItemFCF = new PrendaSAL.Informes.DSItemFCF();
            this.ckCESC = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDESCUENTO = new System.Windows.Forms.Label();
            this.lbSUBTOTAL = new System.Windows.Forms.Label();
            this.lbCESC = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(1010, 25);
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
            this.btnReimprimir.Click += new System.EventHandler(this.REIMPRIMIR);
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
            this.picLOGO.Location = new System.Drawing.Point(795, 48);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(210, 215);
            this.picLOGO.TabIndex = 89;
            this.picLOGO.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA
            // 
            this.txtNOTA.Location = new System.Drawing.Point(130, 466);
            this.txtNOTA.MaxLength = 100;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(389, 103);
            this.txtNOTA.TabIndex = 92;
            this.txtNOTA.Text = "";
            // 
            // grbVENTA
            // 
            this.grbVENTA.Controls.Add(this.cbxCategorias);
            this.grbVENTA.Controls.Add(this.lbDOCUMENTO);
            this.grbVENTA.Controls.Add(this.label8);
            this.grbVENTA.Controls.Add(this.lbNIVEL);
            this.grbVENTA.Controls.Add(this.dateVenta);
            this.grbVENTA.Controls.Add(this.txtNUMVENTA);
            this.grbVENTA.Controls.Add(this.label5);
            this.grbVENTA.Controls.Add(this.label1);
            this.grbVENTA.Controls.Add(this.label19);
            this.grbVENTA.Controls.Add(this.cbxSUCURSAL);
            this.grbVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVENTA.Location = new System.Drawing.Point(494, 40);
            this.grbVENTA.Name = "grbVENTA";
            this.grbVENTA.Size = new System.Drawing.Size(295, 223);
            this.grbVENTA.TabIndex = 87;
            this.grbVENTA.TabStop = false;
            this.grbVENTA.Text = "VENTA";
            // 
            // lbDOCUMENTO
            // 
            this.lbDOCUMENTO.AutoSize = true;
            this.lbDOCUMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOCUMENTO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDOCUMENTO.Location = new System.Drawing.Point(102, 109);
            this.lbDOCUMENTO.Name = "lbDOCUMENTO";
            this.lbDOCUMENTO.Size = new System.Drawing.Size(86, 13);
            this.lbDOCUMENTO.TabIndex = 100;
            this.lbDOCUMENTO.Text = "DOCUMENTO";
            // 
            // lbNIVEL
            // 
            this.lbNIVEL.AutoSize = true;
            this.lbNIVEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNIVEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNIVEL.Location = new System.Drawing.Point(107, 159);
            this.lbNIVEL.Name = "lbNIVEL";
            this.lbNIVEL.Size = new System.Drawing.Size(74, 25);
            this.lbNIVEL.TabIndex = 99;
            this.lbNIVEL.Text = "NIVEL";
            // 
            // dateVenta
            // 
            this.dateVenta.Enabled = false;
            this.dateVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenta.Location = new System.Drawing.Point(105, 128);
            this.dateVenta.Name = "dateVenta";
            this.dateVenta.Size = new System.Drawing.Size(129, 20);
            this.dateVenta.TabIndex = 9;
            // 
            // txtNUMVENTA
            // 
            this.txtNUMVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMVENTA.Location = new System.Drawing.Point(105, 76);
            this.txtNUMVENTA.Name = "txtNUMVENTA";
            this.txtNUMVENTA.ReadOnly = true;
            this.txtNUMVENTA.Size = new System.Drawing.Size(129, 30);
            this.txtNUMVENTA.TabIndex = 4;
            this.txtNUMVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(31, 128);
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
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# VENTA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 32);
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
            this.cbxSUCURSAL.Location = new System.Drawing.Point(21, 49);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(213, 21);
            this.cbxSUCURSAL.TabIndex = 97;
            this.cbxSUCURSAL.SelectedIndexChanged += new System.EventHandler(this.cbxSUCURSAL_SelectedIndexChanged);
            // 
            // btnDEL
            // 
            this.btnDEL.Image = global::PrendaSAL.Properties.Resources.menos;
            this.btnDEL.Location = new System.Drawing.Point(942, 70);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(37, 25);
            this.btnDEL.TabIndex = 95;
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.removeItemVenta);
            // 
            // btnADD
            // 
            this.btnADD.Image = global::PrendaSAL.Properties.Resources.buscar;
            this.btnADD.Location = new System.Drawing.Point(942, 39);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(37, 25);
            this.btnADD.TabIndex = 94;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.getExistencias);
            // 
            // grbCLIENTE
            // 
            this.grbCLIENTE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCLIENTE.Controls.Add(this.label7);
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
            this.grbCLIENTE.Location = new System.Drawing.Point(12, 38);
            this.grbCLIENTE.Name = "grbCLIENTE";
            this.grbCLIENTE.Size = new System.Drawing.Size(476, 225);
            this.grbCLIENTE.TabIndex = 86;
            this.grbCLIENTE.TabStop = false;
            this.grbCLIENTE.Text = "DATOS DEL CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "AÑOS";
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
            this.txtEdadCLI.Size = new System.Drawing.Size(60, 20);
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
            // txtNombreCLI
            // 
            this.txtNombreCLI.Location = new System.Drawing.Point(97, 68);
            this.txtNombreCLI.Name = "txtNombreCLI";
            this.txtNombreCLI.ReadOnly = true;
            this.txtNombreCLI.Size = new System.Drawing.Size(375, 20);
            this.txtNombreCLI.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 124);
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
            // txtExtCLI
            // 
            this.txtExtCLI.Location = new System.Drawing.Point(206, 45);
            this.txtExtCLI.Name = "txtExtCLI";
            this.txtExtCLI.ReadOnly = true;
            this.txtExtCLI.Size = new System.Drawing.Size(193, 20);
            this.txtExtCLI.TabIndex = 90;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(156, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "EXT";
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
            // lbSUMAS
            // 
            this.lbSUMAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSUMAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSUMAS.Location = new System.Drawing.Point(804, 465);
            this.lbSUMAS.Name = "lbSUMAS";
            this.lbSUMAS.Size = new System.Drawing.Size(135, 17);
            this.lbSUMAS.TabIndex = 104;
            this.lbSUMAS.Text = "$0.00";
            this.lbSUMAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(757, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "SUMAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(724, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "DESCUENTO";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTOTAL.Location = new System.Drawing.Point(816, 551);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(135, 32);
            this.txtTOTAL.TabIndex = 5;
            this.txtTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(698, 556);
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
            this.grbDETALLE.Location = new System.Drawing.Point(12, 266);
            this.grbDETALLE.Name = "grbDETALLE";
            this.grbDETALLE.Size = new System.Drawing.Size(993, 194);
            this.grbDETALLE.TabIndex = 105;
            this.grbDETALLE.TabStop = false;
            // 
            // tblITEMS
            // 
            this.tblITEMS.AllowUserToAddRows = false;
            this.tblITEMS.AllowUserToDeleteRows = false;
            this.tblITEMS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblITEMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.COD_ITEM,
            this.CANTIDAD,
            this.DESCRIPCION,
            this.MONTO,
            this.PRECIO});
            this.tblITEMS.Location = new System.Drawing.Point(6, 9);
            this.tblITEMS.MultiSelect = false;
            this.tblITEMS.Name = "tblITEMS";
            this.tblITEMS.RowHeadersWidth = 40;
            this.tblITEMS.Size = new System.Drawing.Size(930, 179);
            this.tblITEMS.TabIndex = 96;
            this.tblITEMS.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tblITEMS_CellBeginEdit);
            this.tblITEMS.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblITEMS_CellEndEdit);
            this.tblITEMS.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblITEMS_CellPainting);
            this.tblITEMS.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.tblITEMS_CellValidating);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.Frozen = true;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO.Width = 150;
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.DataPropertyName = "COD_ITEM";
            dataGridViewCellStyle5.NullValue = "-----";
            this.COD_ITEM.DefaultCellStyle = dataGridViewCellStyle5;
            this.COD_ITEM.Frozen = true;
            this.COD_ITEM.HeaderText = "ARTICULO";
            this.COD_ITEM.Name = "COD_ITEM";
            this.COD_ITEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_ITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_ITEM.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle6.Format = "N1";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle6;
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
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
            dataGridViewCellStyle7.Format = "C2";
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle7;
            this.MONTO.Frozen = true;
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle8;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO.Visible = false;
            // 
            // viewerFACTURA
            // 
            reportDataSource2.Name = "DSI";
            reportDataSource2.Value = null;
            this.viewerFACTURA.LocalReport.DataSources.Add(reportDataSource2);
            this.viewerFACTURA.LocalReport.ReportEmbeddedResource = "";
            this.viewerFACTURA.Location = new System.Drawing.Point(821, 0);
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
            // ckCESC
            // 
            this.ckCESC.AutoSize = true;
            this.ckCESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCESC.Location = new System.Drawing.Point(707, 522);
            this.ckCESC.Name = "ckCESC";
            this.ckCESC.Size = new System.Drawing.Size(103, 17);
            this.ckCESC.TabIndex = 107;
            this.ckCESC.Text = "Incluye CESC";
            this.ckCESC.UseVisualStyleBackColor = true;
            this.ckCESC.CheckedChanged += new System.EventHandler(this.ckCESC_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(735, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "SUBTOTAL";
            // 
            // lbDESCUENTO
            // 
            this.lbDESCUENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDESCUENTO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDESCUENTO.Location = new System.Drawing.Point(804, 482);
            this.lbDESCUENTO.Name = "lbDESCUENTO";
            this.lbDESCUENTO.Size = new System.Drawing.Size(135, 17);
            this.lbDESCUENTO.TabIndex = 111;
            this.lbDESCUENTO.Text = "$0.00";
            this.lbDESCUENTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSUBTOTAL
            // 
            this.lbSUBTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSUBTOTAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSUBTOTAL.Location = new System.Drawing.Point(804, 504);
            this.lbSUBTOTAL.Name = "lbSUBTOTAL";
            this.lbSUBTOTAL.Size = new System.Drawing.Size(135, 17);
            this.lbSUBTOTAL.TabIndex = 112;
            this.lbSUBTOTAL.Text = "$0.00";
            this.lbSUBTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCESC
            // 
            this.lbCESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCESC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCESC.Location = new System.Drawing.Point(804, 521);
            this.lbCESC.Name = "lbCESC";
            this.lbCESC.Size = new System.Drawing.Size(135, 17);
            this.lbCESC.TabIndex = 113;
            this.lbCESC.Text = "$0.00";
            this.lbCESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(813, 494);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 10);
            this.label20.TabIndex = 114;
            this.label20.Text = "--------------------";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(813, 533);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 10);
            this.label21.TabIndex = 115;
            this.label21.Text = "--------------------";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(105, 195);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(130, 21);
            this.cbxCategorias.TabIndex = 116;
            this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxCategorias_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "CATEGORIA";
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 592);
            this.Controls.Add(this.lbCESC);
            this.Controls.Add(this.lbSUBTOTAL);
            this.Controls.Add(this.lbDESCUENTO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckCESC);
            this.Controls.Add(this.viewerFACTURA);
            this.Controls.Add(this.grbDETALLE);
            this.Controls.Add(this.lbSUMAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picLOGO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.grbVENTA);
            this.Controls.Add(this.grbCLIENTE);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
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
        private System.Windows.Forms.TextBox txtNUMVENTA;
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
        private System.Windows.Forms.TextBox txtNombreCLI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoCLI;
        private System.Windows.Forms.TextBox txtExtCLI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDocCLI;
        private System.Windows.Forms.ComboBox cbxBuscarPorCLI;
        private System.Windows.Forms.Button btnCLI;
        private System.Windows.Forms.Label lbSUMAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDETALLE;
        private Microsoft.Reporting.WinForms.ReportViewer viewerFACTURA;
        private System.Windows.Forms.BindingSource bindingFCF;
        private Informes.DSItemFCF dSItemFCF;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.DataGridView tblITEMS;
        private System.Windows.Forms.Label lbNIVEL;
        private System.Windows.Forms.Label lbDOCUMENTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.CheckBox ckCESC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDESCUENTO;
        private System.Windows.Forms.Label lbSUBTOTAL;
        private System.Windows.Forms.Label lbCESC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label8;
    }
}