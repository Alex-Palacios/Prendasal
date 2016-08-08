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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVencidosForm));
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCONTRATOS = new System.Windows.Forms.DataGridView();
            this.ID_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REACTIVADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateApertura = new System.Windows.Forms.DateTimePicker();
            this.txtDOCUMENTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRespoApertura = new System.Windows.Forms.TextBox();
            this.lbCONTRATOS = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNOTA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbREACTIVADOS = new System.Windows.Forms.Label();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDIAS = new System.Windows.Forms.NumericUpDown();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblKPM = new System.Windows.Forms.DataGridView();
            this.KILATAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewerLISTAVENC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsListaVenc = new System.Windows.Forms.BindingSource(this.components);
            this.dSListaVenc = new PrendaSAL.Informes.DSListaVenc();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            this.dateCierre = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRespoCierre = new System.Windows.Forms.TextBox();
            this.lbESTADO = new System.Windows.Forms.Label();
            this.btnLISTAR = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnReimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.btnVerList = new System.Windows.Forms.ToolStripButton();
            this.opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCONTRATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDIAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaVenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListaVenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
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
            this.btnBuscar,
            this.btnVerList,
            this.btnReimprimir,
            this.btnCerrar,
            this.btnLog,
            this.btnEliminar,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(1184, 25);
            this.opciones.TabIndex = 2;
            this.opciones.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCONTRATOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.tblCONTRATOS.RowHeadersVisible = false;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblCONTRATOS.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.tblCONTRATOS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblCONTRATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCONTRATOS.Size = new System.Drawing.Size(983, 405);
            this.tblCONTRATOS.TabIndex = 107;
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
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CONTRATO.DefaultCellStyle = dataGridViewCellStyle14;
            this.CONTRATO.HeaderText = "CONTRATO";
            this.CONTRATO.Name = "CONTRATO";
            this.CONTRATO.ReadOnly = true;
            this.CONTRATO.Width = 70;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle15;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CLIENTE.Width = 220;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CATEGORIA.DefaultCellStyle = dataGridViewCellStyle16;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ARTICULO.DefaultCellStyle = dataGridViewCellStyle17;
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ARTICULO.Width = 200;
            // 
            // PRESTAMO
            // 
            this.PRESTAMO.DataPropertyName = "PRESTAMO";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle18.Format = "C2";
            this.PRESTAMO.DefaultCellStyle = dataGridViewCellStyle18;
            this.PRESTAMO.HeaderText = "PRESTAMO";
            this.PRESTAMO.Name = "PRESTAMO";
            this.PRESTAMO.ReadOnly = true;
            this.PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRESTAMO.Width = 70;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            dataGridViewCellStyle19.Format = "C2";
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle19;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SALDO.Width = 70;
            // 
            // ESTADO_CONTRATO
            // 
            this.ESTADO_CONTRATO.DataPropertyName = "ESTADO_CONTRATO";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ESTADO_CONTRATO.DefaultCellStyle = dataGridViewCellStyle20;
            this.ESTADO_CONTRATO.HeaderText = "ESTADO";
            this.ESTADO_CONTRATO.Name = "ESTADO_CONTRATO";
            this.ESTADO_CONTRATO.ReadOnly = true;
            this.ESTADO_CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DIAS_VENC
            // 
            this.DIAS_VENC.DataPropertyName = "DIAS_VENC";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DIAS_VENC.DefaultCellStyle = dataGridViewCellStyle21;
            this.DIAS_VENC.HeaderText = "DIAS VENC";
            this.DIAS_VENC.Name = "DIAS_VENC";
            this.DIAS_VENC.ReadOnly = true;
            this.DIAS_VENC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIAS_VENC.Width = 50;
            // 
            // dateApertura
            // 
            this.dateApertura.CalendarForeColor = System.Drawing.Color.Blue;
            this.dateApertura.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dateApertura.Enabled = false;
            this.dateApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateApertura.Location = new System.Drawing.Point(88, 94);
            this.dateApertura.Name = "dateApertura";
            this.dateApertura.Size = new System.Drawing.Size(117, 26);
            this.dateApertura.TabIndex = 111;
            // 
            // txtDOCUMENTO
            // 
            this.txtDOCUMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO.Location = new System.Drawing.Point(88, 59);
            this.txtDOCUMENTO.Name = "txtDOCUMENTO";
            this.txtDOCUMENTO.ReadOnly = true;
            this.txtDOCUMENTO.Size = new System.Drawing.Size(117, 30);
            this.txtDOCUMENTO.TabIndex = 110;
            this.txtDOCUMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "APERTURA";
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
            this.label2.Location = new System.Drawing.Point(250, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "AUTORIZADO POR";
            // 
            // txtRespoApertura
            // 
            this.txtRespoApertura.Location = new System.Drawing.Point(211, 98);
            this.txtRespoApertura.Name = "txtRespoApertura";
            this.txtRespoApertura.ReadOnly = true;
            this.txtRespoApertura.Size = new System.Drawing.Size(227, 20);
            this.txtRespoApertura.TabIndex = 115;
            // 
            // lbCONTRATOS
            // 
            this.lbCONTRATOS.AutoSize = true;
            this.lbCONTRATOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCONTRATOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCONTRATOS.Location = new System.Drawing.Point(1037, 465);
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
            // txtNOTA
            // 
            // 
            // 
            // 
            this.txtNOTA.Border.Class = "TextBoxBorder";
            this.txtNOTA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNOTA.Location = new System.Drawing.Point(720, 37);
            this.txtNOTA.Multiline = true;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(223, 109);
            this.txtNOTA.TabIndex = 122;
            this.txtNOTA.WatermarkText = "Nota Adicional";
            // 
            // lbREACTIVADOS
            // 
            this.lbREACTIVADOS.AutoSize = true;
            this.lbREACTIVADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREACTIVADOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbREACTIVADOS.Location = new System.Drawing.Point(1037, 489);
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
            this.lbTOTAL.Location = new System.Drawing.Point(1037, 525);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(94, 13);
            this.lbTOTAL.TabIndex = 124;
            this.lbTOTAL.Text = "0 CONTRATOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1019, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "_________________";
            // 
            // numDIAS
            // 
            this.numDIAS.Location = new System.Drawing.Point(1080, 37);
            this.numDIAS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDIAS.Name = "numDIAS";
            this.numDIAS.Size = new System.Drawing.Size(43, 20);
            this.numDIAS.TabIndex = 129;
            this.numDIAS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(1056, 62);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(105, 21);
            this.cbxCategorias.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(960, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "CATEGORIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1129, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "DIAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1053, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = ">=";
            // 
            // tblKPM
            // 
            this.tblKPM.AllowUserToAddRows = false;
            this.tblKPM.AllowUserToDeleteRows = false;
            this.tblKPM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblKPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KILATAJE,
            this.PESO,
            this.MONTO});
            this.tblKPM.Location = new System.Drawing.Point(1001, 152);
            this.tblKPM.Name = "tblKPM";
            this.tblKPM.ReadOnly = true;
            this.tblKPM.RowHeadersVisible = false;
            this.tblKPM.Size = new System.Drawing.Size(172, 296);
            this.tblKPM.TabIndex = 134;
            // 
            // KILATAJE
            // 
            this.KILATAJE.DataPropertyName = "KILATAJE";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.KILATAJE.DefaultCellStyle = dataGridViewCellStyle24;
            this.KILATAJE.HeaderText = "KIL";
            this.KILATAJE.Name = "KILATAJE";
            this.KILATAJE.ReadOnly = true;
            this.KILATAJE.Width = 50;
            // 
            // PESO
            // 
            this.PESO.DataPropertyName = "PESO";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.PESO.DefaultCellStyle = dataGridViewCellStyle25;
            this.PESO.HeaderText = "GRS";
            this.PESO.Name = "PESO";
            this.PESO.ReadOnly = true;
            this.PESO.Width = 50;
            // 
            // MONTO
            // 
            this.MONTO.DataPropertyName = "MONTO";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle26.Format = "C2";
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle26;
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            this.MONTO.Width = 60;
            // 
            // viewerLISTAVENC
            // 
            this.viewerLISTAVENC.Location = new System.Drawing.Point(993, 0);
            this.viewerLISTAVENC.Name = "viewerLISTAVENC";
            this.viewerLISTAVENC.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.viewerLISTAVENC.Size = new System.Drawing.Size(191, 25);
            this.viewerLISTAVENC.TabIndex = 135;
            this.viewerLISTAVENC.Visible = false;
            this.viewerLISTAVENC.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.ShowPrintDialog);
            // 
            // bsListaVenc
            // 
            this.bsListaVenc.DataMember = "LISTA_VENC";
            this.bsListaVenc.DataSource = this.dSListaVenc;
            // 
            // dSListaVenc
            // 
            this.dSListaVenc.DataSetName = "DSCierre";
            this.dSListaVenc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dateCierre
            // 
            this.dateCierre.CalendarForeColor = System.Drawing.Color.Crimson;
            this.dateCierre.Enabled = false;
            this.dateCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCierre.Location = new System.Drawing.Point(88, 120);
            this.dateCierre.Name = "dateCierre";
            this.dateCierre.Size = new System.Drawing.Size(117, 26);
            this.dateCierre.TabIndex = 137;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(29, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 136;
            this.label8.Text = "CIERRE";
            // 
            // txtRespoCierre
            // 
            this.txtRespoCierre.Location = new System.Drawing.Point(211, 124);
            this.txtRespoCierre.Name = "txtRespoCierre";
            this.txtRespoCierre.ReadOnly = true;
            this.txtRespoCierre.Size = new System.Drawing.Size(227, 20);
            this.txtRespoCierre.TabIndex = 138;
            // 
            // lbESTADO
            // 
            this.lbESTADO.AutoSize = true;
            this.lbESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESTADO.ForeColor = System.Drawing.Color.Blue;
            this.lbESTADO.Location = new System.Drawing.Point(490, 98);
            this.lbESTADO.Name = "lbESTADO";
            this.lbESTADO.Size = new System.Drawing.Size(170, 25);
            this.lbESTADO.TabIndex = 139;
            this.lbESTADO.Text = "ESTADO LISTA";
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Image = global::PrendaSAL.Properties.Resources.lista1;
            this.btnLISTAR.Location = new System.Drawing.Point(1043, 89);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(122, 48);
            this.btnLISTAR.TabIndex = 121;
            this.btnLISTAR.Text = "CONTRATOS VENCIDOS";
            this.btnLISTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
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
            // btnCerrar
            // 
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 22);
            this.btnCerrar.Text = "Cerrar Lista";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // btnVerList
            // 
            this.btnVerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVerList.Image = global::PrendaSAL.Properties.Resources.list_list;
            this.btnVerList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerList.Name = "btnVerList";
            this.btnVerList.Size = new System.Drawing.Size(23, 22);
            this.btnVerList.Text = "Ver Listas";
            this.btnVerList.Click += new System.EventHandler(this.btnVerList_Click);
            // 
            // ListaVencidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lbESTADO);
            this.Controls.Add(this.txtRespoCierre);
            this.Controls.Add(this.dateCierre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.viewerLISTAVENC);
            this.Controls.Add(this.tblKPM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDIAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.lbREACTIVADOS);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.btnLISTAR);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbCONTRATOS);
            this.Controls.Add(this.txtRespoApertura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateApertura);
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
            ((System.ComponentModel.ISupportInitialize)(this.numDIAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaVenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListaVenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateApertura;
        private System.Windows.Forms.TextBox txtDOCUMENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRespoApertura;
        private System.Windows.Forms.Label lbCONTRATOS;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.Button btnLISTAR;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNOTA;
        private System.Windows.Forms.Label lbREACTIVADOS;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDIAS;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tblKPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILATAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private Microsoft.Reporting.WinForms.ReportViewer viewerLISTAVENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRESTAMO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REACTIVADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_VENC;
        private System.Windows.Forms.BindingSource bsListaVenc;
        private Informes.DSListaVenc dSListaVenc;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;
        private System.Windows.Forms.DateTimePicker dateCierre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRespoCierre;
        private System.Windows.Forms.Label lbESTADO;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnVerList;
    }
}