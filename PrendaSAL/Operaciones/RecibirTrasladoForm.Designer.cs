namespace PrendaSAL.Operaciones
{
    partial class RecibirTrasladoForm
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
            this.tabDETALLE = new System.Windows.Forms.TabControl();
            this.pagREMISION = new System.Windows.Forms.TabPage();
            this.ckALLRM = new System.Windows.Forms.CheckBox();
            this.btnRECIBIR_REMISION = new System.Windows.Forms.Button();
            this.lbESTADO_RM = new System.Windows.Forms.Label();
            this.txtTOTAL_RM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNOTA_RM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grbTrasladoRM = new System.Windows.Forms.GroupBox();
            this.cbxDESTINO_RM = new System.Windows.Forms.ComboBox();
            this.cbxENVIA_RM = new System.Windows.Forms.ComboBox();
            this.txtRECIBE_RM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTRASLADA_RM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDOC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDOCUMENTO_RM = new System.Windows.Forms.TextBox();
            this.dateEnvio_RM = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtASESOR_RM = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tblREMISION = new System.Windows.Forms.DataGridView();
            this.OK_RM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagCUSTODIA = new System.Windows.Forms.TabPage();
            this.ckALLCVC = new System.Windows.Forms.CheckBox();
            this.ckALLCVP = new System.Windows.Forms.CheckBox();
            this.btnRECIBIR_CUSTODIA = new System.Windows.Forms.Button();
            this.lbESTADO_CV = new System.Windows.Forms.Label();
            this.txtNOTA_CV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grbTrasladoCV = new System.Windows.Forms.GroupBox();
            this.cbxDESTINO_CV = new System.Windows.Forms.ComboBox();
            this.cbxENVIA_CV = new System.Windows.Forms.ComboBox();
            this.txtRECIBE_CV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTRASLADA_CV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDOCUMENTO_CV = new System.Windows.Forms.TextBox();
            this.dateEnvio_CV = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtASESOR_CV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tblCUSTODIA_COMPRAS = new System.Windows.Forms.DataGridView();
            this.OK_CVC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCUSTODIA_PRESTAMOS = new System.Windows.Forms.DataGridView();
            this.OK_CVP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDETALLE.SuspendLayout();
            this.pagREMISION.SuspendLayout();
            this.grbTrasladoRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).BeginInit();
            this.pagCUSTODIA.SuspendLayout();
            this.grbTrasladoCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDETALLE
            // 
            this.tabDETALLE.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabDETALLE.Controls.Add(this.pagREMISION);
            this.tabDETALLE.Controls.Add(this.pagCUSTODIA);
            this.tabDETALLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDETALLE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabDETALLE.Location = new System.Drawing.Point(0, 0);
            this.tabDETALLE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tabDETALLE.Multiline = true;
            this.tabDETALLE.Name = "tabDETALLE";
            this.tabDETALLE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabDETALLE.SelectedIndex = 0;
            this.tabDETALLE.Size = new System.Drawing.Size(869, 504);
            this.tabDETALLE.TabIndex = 144;
            this.tabDETALLE.SelectedIndexChanged += new System.EventHandler(this.tabDETALLE_SelectedIndexChanged);
            // 
            // pagREMISION
            // 
            this.pagREMISION.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pagREMISION.Controls.Add(this.ckALLRM);
            this.pagREMISION.Controls.Add(this.btnRECIBIR_REMISION);
            this.pagREMISION.Controls.Add(this.lbESTADO_RM);
            this.pagREMISION.Controls.Add(this.txtTOTAL_RM);
            this.pagREMISION.Controls.Add(this.label6);
            this.pagREMISION.Controls.Add(this.txtNOTA_RM);
            this.pagREMISION.Controls.Add(this.grbTrasladoRM);
            this.pagREMISION.Controls.Add(this.tblREMISION);
            this.pagREMISION.Location = new System.Drawing.Point(23, 4);
            this.pagREMISION.Name = "pagREMISION";
            this.pagREMISION.Padding = new System.Windows.Forms.Padding(3);
            this.pagREMISION.Size = new System.Drawing.Size(842, 496);
            this.pagREMISION.TabIndex = 1;
            this.pagREMISION.Text = "NOTA DE REMISION";
            // 
            // ckALLRM
            // 
            this.ckALLRM.AutoSize = true;
            this.ckALLRM.Location = new System.Drawing.Point(20, 195);
            this.ckALLRM.Name = "ckALLRM";
            this.ckALLRM.Size = new System.Drawing.Size(15, 14);
            this.ckALLRM.TabIndex = 153;
            this.ckALLRM.UseVisualStyleBackColor = true;
            this.ckALLRM.CheckedChanged += new System.EventHandler(this.ckALLRM_CheckedChanged);
            // 
            // btnRECIBIR_REMISION
            // 
            this.btnRECIBIR_REMISION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRECIBIR_REMISION.Image = global::PrendaSAL.Properties.Resources.recibir;
            this.btnRECIBIR_REMISION.Location = new System.Drawing.Point(18, 411);
            this.btnRECIBIR_REMISION.Name = "btnRECIBIR_REMISION";
            this.btnRECIBIR_REMISION.Size = new System.Drawing.Size(93, 62);
            this.btnRECIBIR_REMISION.TabIndex = 152;
            this.btnRECIBIR_REMISION.Text = "RECIBIR";
            this.btnRECIBIR_REMISION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRECIBIR_REMISION.UseVisualStyleBackColor = true;
            this.btnRECIBIR_REMISION.Click += new System.EventHandler(this.btnRECIBIR_REMISION_Click);
            // 
            // lbESTADO_RM
            // 
            this.lbESTADO_RM.AutoSize = true;
            this.lbESTADO_RM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESTADO_RM.Location = new System.Drawing.Point(619, 448);
            this.lbESTADO_RM.Name = "lbESTADO_RM";
            this.lbESTADO_RM.Size = new System.Drawing.Size(102, 25);
            this.lbESTADO_RM.TabIndex = 151;
            this.lbESTADO_RM.Text = "ESTADO";
            // 
            // txtTOTAL_RM
            // 
            this.txtTOTAL_RM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL_RM.Location = new System.Drawing.Point(698, 392);
            this.txtTOTAL_RM.Name = "txtTOTAL_RM";
            this.txtTOTAL_RM.ReadOnly = true;
            this.txtTOTAL_RM.Size = new System.Drawing.Size(115, 23);
            this.txtTOTAL_RM.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 149;
            this.label6.Text = "TOTAL";
            // 
            // txtNOTA_RM
            // 
            // 
            // 
            // 
            this.txtNOTA_RM.Border.Class = "TextBoxBorder";
            this.txtNOTA_RM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNOTA_RM.Location = new System.Drawing.Point(186, 411);
            this.txtNOTA_RM.Multiline = true;
            this.txtNOTA_RM.Name = "txtNOTA_RM";
            this.txtNOTA_RM.Size = new System.Drawing.Size(379, 62);
            this.txtNOTA_RM.TabIndex = 148;
            this.txtNOTA_RM.WatermarkText = "Nota Adicional";
            // 
            // grbTrasladoRM
            // 
            this.grbTrasladoRM.Controls.Add(this.cbxDESTINO_RM);
            this.grbTrasladoRM.Controls.Add(this.cbxENVIA_RM);
            this.grbTrasladoRM.Controls.Add(this.txtRECIBE_RM);
            this.grbTrasladoRM.Controls.Add(this.label8);
            this.grbTrasladoRM.Controls.Add(this.txtTRASLADA_RM);
            this.grbTrasladoRM.Controls.Add(this.label7);
            this.grbTrasladoRM.Controls.Add(this.lbDOC);
            this.grbTrasladoRM.Controls.Add(this.label4);
            this.grbTrasladoRM.Controls.Add(this.label5);
            this.grbTrasladoRM.Controls.Add(this.txtDOCUMENTO_RM);
            this.grbTrasladoRM.Controls.Add(this.dateEnvio_RM);
            this.grbTrasladoRM.Controls.Add(this.label2);
            this.grbTrasladoRM.Controls.Add(this.label3);
            this.grbTrasladoRM.Controls.Add(this.txtASESOR_RM);
            this.grbTrasladoRM.Controls.Add(this.label19);
            this.grbTrasladoRM.Location = new System.Drawing.Point(12, 8);
            this.grbTrasladoRM.Name = "grbTrasladoRM";
            this.grbTrasladoRM.Size = new System.Drawing.Size(801, 177);
            this.grbTrasladoRM.TabIndex = 143;
            this.grbTrasladoRM.TabStop = false;
            // 
            // cbxDESTINO_RM
            // 
            this.cbxDESTINO_RM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDESTINO_RM.Enabled = false;
            this.cbxDESTINO_RM.FormattingEnabled = true;
            this.cbxDESTINO_RM.Location = new System.Drawing.Point(311, 124);
            this.cbxDESTINO_RM.Name = "cbxDESTINO_RM";
            this.cbxDESTINO_RM.Size = new System.Drawing.Size(228, 21);
            this.cbxDESTINO_RM.TabIndex = 150;
            // 
            // cbxENVIA_RM
            // 
            this.cbxENVIA_RM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxENVIA_RM.Enabled = false;
            this.cbxENVIA_RM.FormattingEnabled = true;
            this.cbxENVIA_RM.Location = new System.Drawing.Point(13, 124);
            this.cbxENVIA_RM.Name = "cbxENVIA_RM";
            this.cbxENVIA_RM.Size = new System.Drawing.Size(228, 21);
            this.cbxENVIA_RM.TabIndex = 149;
            // 
            // txtRECIBE_RM
            // 
            this.txtRECIBE_RM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRECIBE_RM.Location = new System.Drawing.Point(582, 124);
            this.txtRECIBE_RM.Name = "txtRECIBE_RM";
            this.txtRECIBE_RM.ReadOnly = true;
            this.txtRECIBE_RM.Size = new System.Drawing.Size(206, 20);
            this.txtRECIBE_RM.TabIndex = 145;
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
            // txtTRASLADA_RM
            // 
            this.txtTRASLADA_RM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTRASLADA_RM.Location = new System.Drawing.Point(582, 76);
            this.txtTRASLADA_RM.Name = "txtTRASLADA_RM";
            this.txtTRASLADA_RM.ReadOnly = true;
            this.txtTRASLADA_RM.Size = new System.Drawing.Size(206, 20);
            this.txtTRASLADA_RM.TabIndex = 143;
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
            // lbDOC
            // 
            this.lbDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDOC.Location = new System.Drawing.Point(10, 19);
            this.lbDOC.Name = "lbDOC";
            this.lbDOC.Size = new System.Drawing.Size(105, 30);
            this.lbDOC.TabIndex = 124;
            this.lbDOC.Text = "REMISION #";
            this.lbDOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtDOCUMENTO_RM
            // 
            this.txtDOCUMENTO_RM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO_RM.Location = new System.Drawing.Point(121, 19);
            this.txtDOCUMENTO_RM.Name = "txtDOCUMENTO_RM";
            this.txtDOCUMENTO_RM.Size = new System.Drawing.Size(129, 30);
            this.txtDOCUMENTO_RM.TabIndex = 126;
            this.txtDOCUMENTO_RM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDOCUMENTO_RM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOCUMENTO_RM_KeyPress);
            // 
            // dateEnvio_RM
            // 
            this.dateEnvio_RM.Enabled = false;
            this.dateEnvio_RM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnvio_RM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnvio_RM.Location = new System.Drawing.Point(121, 66);
            this.dateEnvio_RM.Name = "dateEnvio_RM";
            this.dateEnvio_RM.Size = new System.Drawing.Size(129, 26);
            this.dateEnvio_RM.TabIndex = 127;
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
            // txtASESOR_RM
            // 
            this.txtASESOR_RM.Location = new System.Drawing.Point(582, 28);
            this.txtASESOR_RM.Name = "txtASESOR_RM";
            this.txtASESOR_RM.ReadOnly = true;
            this.txtASESOR_RM.Size = new System.Drawing.Size(205, 20);
            this.txtASESOR_RM.TabIndex = 129;
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
            // tblREMISION
            // 
            this.tblREMISION.AllowUserToAddRows = false;
            this.tblREMISION.AllowUserToDeleteRows = false;
            this.tblREMISION.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblREMISION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblREMISION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK_RM,
            this.CODIGO,
            this.CANTIDAD,
            this.COD_ITEM,
            this.DESCRIPCION,
            this.PRECIO});
            this.tblREMISION.Location = new System.Drawing.Point(12, 191);
            this.tblREMISION.MultiSelect = false;
            this.tblREMISION.Name = "tblREMISION";
            this.tblREMISION.RowHeadersVisible = false;
            this.tblREMISION.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblREMISION.Size = new System.Drawing.Size(801, 189);
            this.tblREMISION.TabIndex = 121;
            // 
            // OK_RM
            // 
            this.OK_RM.DataPropertyName = "RECIBIDO";
            this.OK_RM.HeaderText = "R";
            this.OK_RM.Name = "OK_RM";
            this.OK_RM.Width = 30;
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
            // pagCUSTODIA
            // 
            this.pagCUSTODIA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pagCUSTODIA.Controls.Add(this.ckALLCVC);
            this.pagCUSTODIA.Controls.Add(this.ckALLCVP);
            this.pagCUSTODIA.Controls.Add(this.btnRECIBIR_CUSTODIA);
            this.pagCUSTODIA.Controls.Add(this.lbESTADO_CV);
            this.pagCUSTODIA.Controls.Add(this.txtNOTA_CV);
            this.pagCUSTODIA.Controls.Add(this.grbTrasladoCV);
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA_COMPRAS);
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA_PRESTAMOS);
            this.pagCUSTODIA.Location = new System.Drawing.Point(23, 4);
            this.pagCUSTODIA.Name = "pagCUSTODIA";
            this.pagCUSTODIA.Padding = new System.Windows.Forms.Padding(3);
            this.pagCUSTODIA.Size = new System.Drawing.Size(842, 496);
            this.pagCUSTODIA.TabIndex = 0;
            this.pagCUSTODIA.Text = "CUSTODIA DE VALORES";
            // 
            // ckALLCVC
            // 
            this.ckALLCVC.AutoSize = true;
            this.ckALLCVC.Location = new System.Drawing.Point(405, 208);
            this.ckALLCVC.Name = "ckALLCVC";
            this.ckALLCVC.Size = new System.Drawing.Size(15, 14);
            this.ckALLCVC.TabIndex = 156;
            this.ckALLCVC.UseVisualStyleBackColor = true;
            this.ckALLCVC.CheckedChanged += new System.EventHandler(this.ckALLCVC_CheckedChanged);
            // 
            // ckALLCVP
            // 
            this.ckALLCVP.AutoSize = true;
            this.ckALLCVP.Location = new System.Drawing.Point(13, 208);
            this.ckALLCVP.Name = "ckALLCVP";
            this.ckALLCVP.Size = new System.Drawing.Size(15, 14);
            this.ckALLCVP.TabIndex = 155;
            this.ckALLCVP.UseVisualStyleBackColor = true;
            this.ckALLCVP.CheckedChanged += new System.EventHandler(this.ckALLCVP_CheckedChanged);
            // 
            // btnRECIBIR_CUSTODIA
            // 
            this.btnRECIBIR_CUSTODIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRECIBIR_CUSTODIA.Image = global::PrendaSAL.Properties.Resources.recibir;
            this.btnRECIBIR_CUSTODIA.Location = new System.Drawing.Point(12, 428);
            this.btnRECIBIR_CUSTODIA.Name = "btnRECIBIR_CUSTODIA";
            this.btnRECIBIR_CUSTODIA.Size = new System.Drawing.Size(93, 62);
            this.btnRECIBIR_CUSTODIA.TabIndex = 154;
            this.btnRECIBIR_CUSTODIA.Text = "RECIBIR";
            this.btnRECIBIR_CUSTODIA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRECIBIR_CUSTODIA.UseVisualStyleBackColor = true;
            this.btnRECIBIR_CUSTODIA.Click += new System.EventHandler(this.btnRECIBIR_CUSTODIA_Click);
            // 
            // lbESTADO_CV
            // 
            this.lbESTADO_CV.AutoSize = true;
            this.lbESTADO_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESTADO_CV.Location = new System.Drawing.Point(648, 444);
            this.lbESTADO_CV.Name = "lbESTADO_CV";
            this.lbESTADO_CV.Size = new System.Drawing.Size(102, 25);
            this.lbESTADO_CV.TabIndex = 153;
            this.lbESTADO_CV.Text = "ESTADO";
            // 
            // txtNOTA_CV
            // 
            // 
            // 
            // 
            this.txtNOTA_CV.Border.Class = "TextBoxBorder";
            this.txtNOTA_CV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNOTA_CV.Location = new System.Drawing.Point(166, 430);
            this.txtNOTA_CV.Multiline = true;
            this.txtNOTA_CV.Name = "txtNOTA_CV";
            this.txtNOTA_CV.Size = new System.Drawing.Size(397, 58);
            this.txtNOTA_CV.TabIndex = 152;
            this.txtNOTA_CV.WatermarkText = "Nota Adicional";
            // 
            // grbTrasladoCV
            // 
            this.grbTrasladoCV.Controls.Add(this.cbxDESTINO_CV);
            this.grbTrasladoCV.Controls.Add(this.cbxENVIA_CV);
            this.grbTrasladoCV.Controls.Add(this.txtRECIBE_CV);
            this.grbTrasladoCV.Controls.Add(this.label1);
            this.grbTrasladoCV.Controls.Add(this.txtTRASLADA_CV);
            this.grbTrasladoCV.Controls.Add(this.label9);
            this.grbTrasladoCV.Controls.Add(this.label10);
            this.grbTrasladoCV.Controls.Add(this.label11);
            this.grbTrasladoCV.Controls.Add(this.label12);
            this.grbTrasladoCV.Controls.Add(this.txtDOCUMENTO_CV);
            this.grbTrasladoCV.Controls.Add(this.dateEnvio_CV);
            this.grbTrasladoCV.Controls.Add(this.label13);
            this.grbTrasladoCV.Controls.Add(this.label14);
            this.grbTrasladoCV.Controls.Add(this.txtASESOR_CV);
            this.grbTrasladoCV.Controls.Add(this.label15);
            this.grbTrasladoCV.Location = new System.Drawing.Point(6, 20);
            this.grbTrasladoCV.Name = "grbTrasladoCV";
            this.grbTrasladoCV.Size = new System.Drawing.Size(784, 166);
            this.grbTrasladoCV.TabIndex = 144;
            this.grbTrasladoCV.TabStop = false;
            // 
            // cbxDESTINO_CV
            // 
            this.cbxDESTINO_CV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDESTINO_CV.Enabled = false;
            this.cbxDESTINO_CV.FormattingEnabled = true;
            this.cbxDESTINO_CV.Location = new System.Drawing.Point(288, 124);
            this.cbxDESTINO_CV.Name = "cbxDESTINO_CV";
            this.cbxDESTINO_CV.Size = new System.Drawing.Size(228, 21);
            this.cbxDESTINO_CV.TabIndex = 151;
            // 
            // cbxENVIA_CV
            // 
            this.cbxENVIA_CV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxENVIA_CV.Enabled = false;
            this.cbxENVIA_CV.FormattingEnabled = true;
            this.cbxENVIA_CV.Location = new System.Drawing.Point(13, 124);
            this.cbxENVIA_CV.Name = "cbxENVIA_CV";
            this.cbxENVIA_CV.Size = new System.Drawing.Size(228, 21);
            this.cbxENVIA_CV.TabIndex = 150;
            // 
            // txtRECIBE_CV
            // 
            this.txtRECIBE_CV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRECIBE_CV.Location = new System.Drawing.Point(558, 124);
            this.txtRECIBE_CV.Name = "txtRECIBE_CV";
            this.txtRECIBE_CV.ReadOnly = true;
            this.txtRECIBE_CV.Size = new System.Drawing.Size(206, 20);
            this.txtRECIBE_CV.TabIndex = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "RECIBE";
            // 
            // txtTRASLADA_CV
            // 
            this.txtTRASLADA_CV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTRASLADA_CV.Location = new System.Drawing.Point(558, 76);
            this.txtTRASLADA_CV.Name = "txtTRASLADA_CV";
            this.txtTRASLADA_CV.ReadOnly = true;
            this.txtTRASLADA_CV.Size = new System.Drawing.Size(206, 20);
            this.txtTRASLADA_CV.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(624, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 144;
            this.label9.Text = "TRASLADA";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 30);
            this.label10.TabIndex = 124;
            this.label10.Text = "CUSTODIA #";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::PrendaSAL.Properties.Resources.fechas21;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label11.Location = new System.Drawing.Point(225, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 47);
            this.label11.TabIndex = 135;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(10, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 125;
            this.label12.Text = "FECHA ENVIO";
            // 
            // txtDOCUMENTO_CV
            // 
            this.txtDOCUMENTO_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO_CV.Location = new System.Drawing.Point(121, 19);
            this.txtDOCUMENTO_CV.Name = "txtDOCUMENTO_CV";
            this.txtDOCUMENTO_CV.Size = new System.Drawing.Size(129, 30);
            this.txtDOCUMENTO_CV.TabIndex = 126;
            this.txtDOCUMENTO_CV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDOCUMENTO_CV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOCUMENTO_CV_KeyPress);
            // 
            // dateEnvio_CV
            // 
            this.dateEnvio_CV.Enabled = false;
            this.dateEnvio_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnvio_CV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnvio_CV.Location = new System.Drawing.Point(121, 66);
            this.dateEnvio_CV.Name = "dateEnvio_CV";
            this.dateEnvio_CV.Size = new System.Drawing.Size(129, 26);
            this.dateEnvio_CV.TabIndex = 127;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(624, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "ASESOR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(358, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 133;
            this.label14.Text = "DESTINO";
            // 
            // txtASESOR_CV
            // 
            this.txtASESOR_CV.Location = new System.Drawing.Point(558, 28);
            this.txtASESOR_CV.Name = "txtASESOR_CV";
            this.txtASESOR_CV.ReadOnly = true;
            this.txtASESOR_CV.Size = new System.Drawing.Size(205, 20);
            this.txtASESOR_CV.TabIndex = 129;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(83, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 130;
            this.label15.Text = "ENVIA";
            // 
            // tblCUSTODIA_COMPRAS
            // 
            this.tblCUSTODIA_COMPRAS.AllowUserToAddRows = false;
            this.tblCUSTODIA_COMPRAS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_COMPRAS.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.tblCUSTODIA_COMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_COMPRAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK_CVC,
            this.CODIGO_COMPRA,
            this.CATEGORIA_COMPRA,
            this.NIVEL_COMPRA});
            this.tblCUSTODIA_COMPRAS.Location = new System.Drawing.Point(396, 203);
            this.tblCUSTODIA_COMPRAS.Name = "tblCUSTODIA_COMPRAS";
            this.tblCUSTODIA_COMPRAS.RowHeadersVisible = false;
            this.tblCUSTODIA_COMPRAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCUSTODIA_COMPRAS.Size = new System.Drawing.Size(394, 214);
            this.tblCUSTODIA_COMPRAS.TabIndex = 123;
            // 
            // OK_CVC
            // 
            this.OK_CVC.DataPropertyName = "RECIBIDO";
            this.OK_CVC.HeaderText = "R";
            this.OK_CVC.Name = "OK_CVC";
            this.OK_CVC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OK_CVC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OK_CVC.Width = 30;
            // 
            // CODIGO_COMPRA
            // 
            this.CODIGO_COMPRA.DataPropertyName = "CODIGO";
            this.CODIGO_COMPRA.HeaderText = "COMPRA";
            this.CODIGO_COMPRA.Name = "CODIGO_COMPRA";
            this.CODIGO_COMPRA.ReadOnly = true;
            this.CODIGO_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO_COMPRA.Width = 80;
            // 
            // CATEGORIA_COMPRA
            // 
            this.CATEGORIA_COMPRA.DataPropertyName = "COD_ITEM";
            this.CATEGORIA_COMPRA.HeaderText = "CATEGORIA";
            this.CATEGORIA_COMPRA.Name = "CATEGORIA_COMPRA";
            this.CATEGORIA_COMPRA.ReadOnly = true;
            this.CATEGORIA_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CATEGORIA_COMPRA.Width = 80;
            // 
            // NIVEL_COMPRA
            // 
            this.NIVEL_COMPRA.DataPropertyName = "CANTIDAD";
            this.NIVEL_COMPRA.HeaderText = "MAYOREO";
            this.NIVEL_COMPRA.Name = "NIVEL_COMPRA";
            this.NIVEL_COMPRA.ReadOnly = true;
            this.NIVEL_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NIVEL_COMPRA.Width = 80;
            // 
            // tblCUSTODIA_PRESTAMOS
            // 
            this.tblCUSTODIA_PRESTAMOS.AllowUserToAddRows = false;
            this.tblCUSTODIA_PRESTAMOS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_PRESTAMOS.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.tblCUSTODIA_PRESTAMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_PRESTAMOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OK_CVP,
            this.CODIGO_PRESTAMO,
            this.CATEGORIA_PRESTAMO});
            this.tblCUSTODIA_PRESTAMOS.Location = new System.Drawing.Point(6, 203);
            this.tblCUSTODIA_PRESTAMOS.Name = "tblCUSTODIA_PRESTAMOS";
            this.tblCUSTODIA_PRESTAMOS.RowHeadersVisible = false;
            this.tblCUSTODIA_PRESTAMOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCUSTODIA_PRESTAMOS.Size = new System.Drawing.Size(291, 214);
            this.tblCUSTODIA_PRESTAMOS.TabIndex = 122;
            // 
            // OK_CVP
            // 
            this.OK_CVP.DataPropertyName = "RECIBIDO";
            this.OK_CVP.HeaderText = "R";
            this.OK_CVP.Name = "OK_CVP";
            this.OK_CVP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OK_CVP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OK_CVP.Width = 30;
            // 
            // CODIGO_PRESTAMO
            // 
            this.CODIGO_PRESTAMO.DataPropertyName = "CODIGO";
            this.CODIGO_PRESTAMO.HeaderText = "CONTRATO";
            this.CODIGO_PRESTAMO.Name = "CODIGO_PRESTAMO";
            this.CODIGO_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO_PRESTAMO.Width = 80;
            // 
            // CATEGORIA_PRESTAMO
            // 
            this.CATEGORIA_PRESTAMO.DataPropertyName = "COD_ITEM";
            this.CATEGORIA_PRESTAMO.HeaderText = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.Name = "CATEGORIA_PRESTAMO";
            this.CATEGORIA_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CATEGORIA_PRESTAMO.Width = 80;
            // 
            // RecibirTrasladoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 504);
            this.Controls.Add(this.tabDETALLE);
            this.MaximizeBox = false;
            this.Name = "RecibirTrasladoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RECEPCION DE ARTICULOS";
            this.Load += new System.EventHandler(this.RecibirInvForm_Load);
            this.tabDETALLE.ResumeLayout(false);
            this.pagREMISION.ResumeLayout(false);
            this.pagREMISION.PerformLayout();
            this.grbTrasladoRM.ResumeLayout(false);
            this.grbTrasladoRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).EndInit();
            this.pagCUSTODIA.ResumeLayout(false);
            this.pagCUSTODIA.PerformLayout();
            this.grbTrasladoCV.ResumeLayout(false);
            this.grbTrasladoCV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDETALLE;
        private System.Windows.Forms.TabPage pagREMISION;
        private System.Windows.Forms.Label lbESTADO_RM;
        private System.Windows.Forms.TextBox txtTOTAL_RM;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNOTA_RM;
        private System.Windows.Forms.GroupBox grbTrasladoRM;
        private System.Windows.Forms.TextBox txtRECIBE_RM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTRASLADA_RM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDOC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDOCUMENTO_RM;
        private System.Windows.Forms.DateTimePicker dateEnvio_RM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtASESOR_RM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView tblREMISION;
        private System.Windows.Forms.TabPage pagCUSTODIA;
        private System.Windows.Forms.Label lbESTADO_CV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNOTA_CV;
        private System.Windows.Forms.GroupBox grbTrasladoCV;
        private System.Windows.Forms.TextBox txtRECIBE_CV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTRASLADA_CV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDOCUMENTO_CV;
        private System.Windows.Forms.DateTimePicker dateEnvio_CV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtASESOR_CV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tblCUSTODIA_COMPRAS;
        private System.Windows.Forms.DataGridView tblCUSTODIA_PRESTAMOS;
        private System.Windows.Forms.Button btnRECIBIR_REMISION;
        private System.Windows.Forms.Button btnRECIBIR_CUSTODIA;
        private System.Windows.Forms.ComboBox cbxDESTINO_RM;
        private System.Windows.Forms.ComboBox cbxENVIA_RM;
        private System.Windows.Forms.ComboBox cbxDESTINO_CV;
        private System.Windows.Forms.ComboBox cbxENVIA_CV;
        private System.Windows.Forms.CheckBox ckALLRM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.CheckBox ckALLCVC;
        private System.Windows.Forms.CheckBox ckALLCVP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK_CVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_COMPRA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK_CVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_PRESTAMO;


    }
}