namespace PrendaSAL.Operaciones
{
    partial class RecibirInvForm
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
            this.tabControlEnvio = new System.Windows.Forms.TabControl();
            this.pagCustodia = new System.Windows.Forms.TabPage();
            this.txtESTADO_Custodia = new System.Windows.Forms.TextBox();
            this.txtRecibe_Custodia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbARTICULOS_CUSTODIA = new System.Windows.Forms.Label();
            this.txtTraslada_Custodia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSUC_ORG_Custodia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSUC_DEST_Custodia = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxTIPODOC_Custodia = new System.Windows.Forms.ComboBox();
            this.lbTOTAL_CUSTODIA = new System.Windows.Forms.Label();
            this.tblCustodia = new System.Windows.Forms.DataGridView();
            this.ID_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnvia_Custodia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNOTA_Custodia = new System.Windows.Forms.RichTextBox();
            this.dateTraslado_Custodia = new System.Windows.Forms.DateTimePicker();
            this.txtNUMERO_Custodia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRECIBIR_CUSTODIA = new System.Windows.Forms.Button();
            this.pagRemision = new System.Windows.Forms.TabPage();
            this.txtESTADO_Remision = new System.Windows.Forms.TextBox();
            this.txtRecibe_Remision = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbARTICULOS_REMISION = new System.Windows.Forms.Label();
            this.txtTraslada_Remision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxSUC_ORG_Remision = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxSUC_DEST_Remision = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTIPODOC_Remision = new System.Windows.Forms.ComboBox();
            this.lbTOTAL_REMISION = new System.Windows.Forms.Label();
            this.tblInventario = new System.Windows.Forms.DataGridView();
            this.ID_MOV_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnvia_Remision = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNOTA_Remision = new System.Windows.Forms.RichTextBox();
            this.dateTraslado_Remision = new System.Windows.Forms.DateTimePicker();
            this.txtNUMERO_Remision = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRECIBIR_REMISION = new System.Windows.Forms.Button();
            this.tabControlEnvio.SuspendLayout();
            this.pagCustodia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustodia)).BeginInit();
            this.pagRemision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEnvio
            // 
            this.tabControlEnvio.Controls.Add(this.pagCustodia);
            this.tabControlEnvio.Controls.Add(this.pagRemision);
            this.tabControlEnvio.Location = new System.Drawing.Point(3, 12);
            this.tabControlEnvio.Name = "tabControlEnvio";
            this.tabControlEnvio.SelectedIndex = 0;
            this.tabControlEnvio.Size = new System.Drawing.Size(894, 534);
            this.tabControlEnvio.TabIndex = 1;
            this.tabControlEnvio.SelectedIndexChanged += new System.EventHandler(this.tabControlEnvio_SelectedIndexChanged);
            // 
            // pagCustodia
            // 
            this.pagCustodia.Controls.Add(this.txtESTADO_Custodia);
            this.pagCustodia.Controls.Add(this.txtRecibe_Custodia);
            this.pagCustodia.Controls.Add(this.label8);
            this.pagCustodia.Controls.Add(this.label6);
            this.pagCustodia.Controls.Add(this.lbARTICULOS_CUSTODIA);
            this.pagCustodia.Controls.Add(this.txtTraslada_Custodia);
            this.pagCustodia.Controls.Add(this.label4);
            this.pagCustodia.Controls.Add(this.cbxSUC_ORG_Custodia);
            this.pagCustodia.Controls.Add(this.label3);
            this.pagCustodia.Controls.Add(this.cbxSUC_DEST_Custodia);
            this.pagCustodia.Controls.Add(this.label19);
            this.pagCustodia.Controls.Add(this.cbxTIPODOC_Custodia);
            this.pagCustodia.Controls.Add(this.lbTOTAL_CUSTODIA);
            this.pagCustodia.Controls.Add(this.tblCustodia);
            this.pagCustodia.Controls.Add(this.txtEnvia_Custodia);
            this.pagCustodia.Controls.Add(this.label2);
            this.pagCustodia.Controls.Add(this.label10);
            this.pagCustodia.Controls.Add(this.txtNOTA_Custodia);
            this.pagCustodia.Controls.Add(this.dateTraslado_Custodia);
            this.pagCustodia.Controls.Add(this.txtNUMERO_Custodia);
            this.pagCustodia.Controls.Add(this.label5);
            this.pagCustodia.Controls.Add(this.label1);
            this.pagCustodia.Controls.Add(this.btnRECIBIR_CUSTODIA);
            this.pagCustodia.Location = new System.Drawing.Point(4, 22);
            this.pagCustodia.Name = "pagCustodia";
            this.pagCustodia.Padding = new System.Windows.Forms.Padding(3);
            this.pagCustodia.Size = new System.Drawing.Size(886, 508);
            this.pagCustodia.TabIndex = 0;
            this.pagCustodia.Text = "CUSTODIA DE VALORES";
            this.pagCustodia.UseVisualStyleBackColor = true;
            // 
            // txtESTADO_Custodia
            // 
            this.txtESTADO_Custodia.BackColor = System.Drawing.SystemColors.Control;
            this.txtESTADO_Custodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESTADO_Custodia.ForeColor = System.Drawing.Color.Black;
            this.txtESTADO_Custodia.Location = new System.Drawing.Point(80, 476);
            this.txtESTADO_Custodia.Name = "txtESTADO_Custodia";
            this.txtESTADO_Custodia.ReadOnly = true;
            this.txtESTADO_Custodia.Size = new System.Drawing.Size(129, 23);
            this.txtESTADO_Custodia.TabIndex = 159;
            this.txtESTADO_Custodia.Text = "PENDIENTE";
            // 
            // txtRecibe_Custodia
            // 
            this.txtRecibe_Custodia.Location = new System.Drawing.Point(162, 121);
            this.txtRecibe_Custodia.Name = "txtRecibe_Custodia";
            this.txtRecibe_Custodia.ReadOnly = true;
            this.txtRecibe_Custodia.Size = new System.Drawing.Size(233, 20);
            this.txtRecibe_Custodia.TabIndex = 158;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(5, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 157;
            this.label8.Text = "RESPONSABLE RECIBIR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(17, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 155;
            this.label6.Text = "ESTADO";
            // 
            // lbARTICULOS_CUSTODIA
            // 
            this.lbARTICULOS_CUSTODIA.AutoSize = true;
            this.lbARTICULOS_CUSTODIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbARTICULOS_CUSTODIA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbARTICULOS_CUSTODIA.Location = new System.Drawing.Point(485, 476);
            this.lbARTICULOS_CUSTODIA.Name = "lbARTICULOS_CUSTODIA";
            this.lbARTICULOS_CUSTODIA.Size = new System.Drawing.Size(109, 17);
            this.lbARTICULOS_CUSTODIA.TabIndex = 154;
            this.lbARTICULOS_CUSTODIA.Text = "0 ARTICULOS";
            // 
            // txtTraslada_Custodia
            // 
            this.txtTraslada_Custodia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTraslada_Custodia.Location = new System.Drawing.Point(539, 43);
            this.txtTraslada_Custodia.Name = "txtTraslada_Custodia";
            this.txtTraslada_Custodia.ReadOnly = true;
            this.txtTraslada_Custodia.Size = new System.Drawing.Size(217, 20);
            this.txtTraslada_Custodia.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(357, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 152;
            this.label4.Text = "RESPONSABLE TRASLADO";
            // 
            // cbxSUC_ORG_Custodia
            // 
            this.cbxSUC_ORG_Custodia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUC_ORG_Custodia.Enabled = false;
            this.cbxSUC_ORG_Custodia.FormattingEnabled = true;
            this.cbxSUC_ORG_Custodia.Location = new System.Drawing.Point(539, 16);
            this.cbxSUC_ORG_Custodia.Name = "cbxSUC_ORG_Custodia";
            this.cbxSUC_ORG_Custodia.Size = new System.Drawing.Size(217, 21);
            this.cbxSUC_ORG_Custodia.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "REMITE";
            // 
            // cbxSUC_DEST_Custodia
            // 
            this.cbxSUC_DEST_Custodia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUC_DEST_Custodia.Enabled = false;
            this.cbxSUC_DEST_Custodia.FormattingEnabled = true;
            this.cbxSUC_DEST_Custodia.Location = new System.Drawing.Point(539, 69);
            this.cbxSUC_DEST_Custodia.Name = "cbxSUC_DEST_Custodia";
            this.cbxSUC_DEST_Custodia.Size = new System.Drawing.Size(217, 21);
            this.cbxSUC_DEST_Custodia.TabIndex = 149;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(462, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 148;
            this.label19.Text = "DESTINO";
            // 
            // cbxTIPODOC_Custodia
            // 
            this.cbxTIPODOC_Custodia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPODOC_Custodia.Enabled = false;
            this.cbxTIPODOC_Custodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTIPODOC_Custodia.FormattingEnabled = true;
            this.cbxTIPODOC_Custodia.Location = new System.Drawing.Point(28, 28);
            this.cbxTIPODOC_Custodia.Name = "cbxTIPODOC_Custodia";
            this.cbxTIPODOC_Custodia.Size = new System.Drawing.Size(128, 21);
            this.cbxTIPODOC_Custodia.TabIndex = 147;
            // 
            // lbTOTAL_CUSTODIA
            // 
            this.lbTOTAL_CUSTODIA.AutoSize = true;
            this.lbTOTAL_CUSTODIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL_CUSTODIA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTOTAL_CUSTODIA.Location = new System.Drawing.Point(777, 476);
            this.lbTOTAL_CUSTODIA.Name = "lbTOTAL_CUSTODIA";
            this.lbTOTAL_CUSTODIA.Size = new System.Drawing.Size(40, 17);
            this.lbTOTAL_CUSTODIA.TabIndex = 146;
            this.lbTOTAL_CUSTODIA.Text = "0.00";
            // 
            // tblCustodia
            // 
            this.tblCustodia.AllowUserToAddRows = false;
            this.tblCustodia.AllowUserToDeleteRows = false;
            this.tblCustodia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCustodia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCustodia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MOV,
            this.CODIGO,
            this.CANTIDAD,
            this.ARTICULO,
            this.DESCRIPCION,
            this.VALOR});
            this.tblCustodia.Location = new System.Drawing.Point(10, 157);
            this.tblCustodia.Name = "tblCustodia";
            this.tblCustodia.ReadOnly = true;
            this.tblCustodia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCustodia.Size = new System.Drawing.Size(857, 306);
            this.tblCustodia.TabIndex = 145;
            this.tblCustodia.DataSourceChanged += new System.EventHandler(this.tblCustodia_DataSourceChanged);
            // 
            // ID_MOV
            // 
            this.ID_MOV.DataPropertyName = "ID_MOV";
            dataGridViewCellStyle1.Format = "N0";
            this.ID_MOV.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_MOV.HeaderText = "ID_MOV";
            this.ID_MOV.Name = "ID_MOV";
            this.ID_MOV.ReadOnly = true;
            this.ID_MOV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_MOV.Visible = false;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANT/PESO";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD.Width = 75;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            this.ARTICULO.HeaderText = "ART/KIL";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 400;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle2.Format = "C2";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // txtEnvia_Custodia
            // 
            this.txtEnvia_Custodia.Location = new System.Drawing.Point(162, 93);
            this.txtEnvia_Custodia.Name = "txtEnvia_Custodia";
            this.txtEnvia_Custodia.ReadOnly = true;
            this.txtEnvia_Custodia.Size = new System.Drawing.Size(233, 20);
            this.txtEnvia_Custodia.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "RESPONSABLE ENVIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(423, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 142;
            this.label10.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA_Custodia
            // 
            this.txtNOTA_Custodia.Location = new System.Drawing.Point(540, 96);
            this.txtNOTA_Custodia.Name = "txtNOTA_Custodia";
            this.txtNOTA_Custodia.ReadOnly = true;
            this.txtNOTA_Custodia.Size = new System.Drawing.Size(314, 53);
            this.txtNOTA_Custodia.TabIndex = 141;
            this.txtNOTA_Custodia.Text = "";
            // 
            // dateTraslado_Custodia
            // 
            this.dateTraslado_Custodia.Enabled = false;
            this.dateTraslado_Custodia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTraslado_Custodia.Location = new System.Drawing.Point(162, 66);
            this.dateTraslado_Custodia.Name = "dateTraslado_Custodia";
            this.dateTraslado_Custodia.Size = new System.Drawing.Size(129, 20);
            this.dateTraslado_Custodia.TabIndex = 140;
            // 
            // txtNUMERO_Custodia
            // 
            this.txtNUMERO_Custodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMERO_Custodia.Location = new System.Drawing.Point(162, 28);
            this.txtNUMERO_Custodia.Name = "txtNUMERO_Custodia";
            this.txtNUMERO_Custodia.Size = new System.Drawing.Size(129, 30);
            this.txtNUMERO_Custodia.TabIndex = 139;
            this.txtNUMERO_Custodia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNUMERO_Custodia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNUMERO_Custodia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(109, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 138;
            this.label5.Text = "FECHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(193, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "NUMERO";
            // 
            // btnRECIBIR_CUSTODIA
            // 
            this.btnRECIBIR_CUSTODIA.Enabled = false;
            this.btnRECIBIR_CUSTODIA.Image = global::PrendaSAL.Properties.Resources.recibir;
            this.btnRECIBIR_CUSTODIA.Location = new System.Drawing.Point(794, 16);
            this.btnRECIBIR_CUSTODIA.Name = "btnRECIBIR_CUSTODIA";
            this.btnRECIBIR_CUSTODIA.Size = new System.Drawing.Size(73, 63);
            this.btnRECIBIR_CUSTODIA.TabIndex = 101;
            this.btnRECIBIR_CUSTODIA.Text = "Recibir";
            this.btnRECIBIR_CUSTODIA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRECIBIR_CUSTODIA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRECIBIR_CUSTODIA.UseVisualStyleBackColor = true;
            this.btnRECIBIR_CUSTODIA.Click += new System.EventHandler(this.RECIBIR_CUSTODIA);
            // 
            // pagRemision
            // 
            this.pagRemision.Controls.Add(this.txtESTADO_Remision);
            this.pagRemision.Controls.Add(this.txtRecibe_Remision);
            this.pagRemision.Controls.Add(this.label13);
            this.pagRemision.Controls.Add(this.label7);
            this.pagRemision.Controls.Add(this.lbARTICULOS_REMISION);
            this.pagRemision.Controls.Add(this.txtTraslada_Remision);
            this.pagRemision.Controls.Add(this.label9);
            this.pagRemision.Controls.Add(this.cbxSUC_ORG_Remision);
            this.pagRemision.Controls.Add(this.label11);
            this.pagRemision.Controls.Add(this.cbxSUC_DEST_Remision);
            this.pagRemision.Controls.Add(this.label12);
            this.pagRemision.Controls.Add(this.cbxTIPODOC_Remision);
            this.pagRemision.Controls.Add(this.lbTOTAL_REMISION);
            this.pagRemision.Controls.Add(this.tblInventario);
            this.pagRemision.Controls.Add(this.txtEnvia_Remision);
            this.pagRemision.Controls.Add(this.label14);
            this.pagRemision.Controls.Add(this.label15);
            this.pagRemision.Controls.Add(this.txtNOTA_Remision);
            this.pagRemision.Controls.Add(this.dateTraslado_Remision);
            this.pagRemision.Controls.Add(this.txtNUMERO_Remision);
            this.pagRemision.Controls.Add(this.label16);
            this.pagRemision.Controls.Add(this.label17);
            this.pagRemision.Controls.Add(this.btnRECIBIR_REMISION);
            this.pagRemision.Location = new System.Drawing.Point(4, 22);
            this.pagRemision.Name = "pagRemision";
            this.pagRemision.Padding = new System.Windows.Forms.Padding(3);
            this.pagRemision.Size = new System.Drawing.Size(886, 508);
            this.pagRemision.TabIndex = 1;
            this.pagRemision.Text = "REMISION DE INVENTARIO";
            this.pagRemision.UseVisualStyleBackColor = true;
            // 
            // txtESTADO_Remision
            // 
            this.txtESTADO_Remision.BackColor = System.Drawing.SystemColors.Control;
            this.txtESTADO_Remision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESTADO_Remision.ForeColor = System.Drawing.Color.Black;
            this.txtESTADO_Remision.Location = new System.Drawing.Point(86, 473);
            this.txtESTADO_Remision.Name = "txtESTADO_Remision";
            this.txtESTADO_Remision.ReadOnly = true;
            this.txtESTADO_Remision.Size = new System.Drawing.Size(129, 23);
            this.txtESTADO_Remision.TabIndex = 180;
            this.txtESTADO_Remision.Text = "PENDIENTE";
            // 
            // txtRecibe_Remision
            // 
            this.txtRecibe_Remision.Location = new System.Drawing.Point(168, 125);
            this.txtRecibe_Remision.Name = "txtRecibe_Remision";
            this.txtRecibe_Remision.ReadOnly = true;
            this.txtRecibe_Remision.Size = new System.Drawing.Size(233, 20);
            this.txtRecibe_Remision.TabIndex = 179;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(11, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 13);
            this.label13.TabIndex = 178;
            this.label13.Text = "RESPONSABLE RECIBIR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 176;
            this.label7.Text = "ESTADO";
            // 
            // lbARTICULOS_REMISION
            // 
            this.lbARTICULOS_REMISION.AutoSize = true;
            this.lbARTICULOS_REMISION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbARTICULOS_REMISION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbARTICULOS_REMISION.Location = new System.Drawing.Point(542, 476);
            this.lbARTICULOS_REMISION.Name = "lbARTICULOS_REMISION";
            this.lbARTICULOS_REMISION.Size = new System.Drawing.Size(109, 17);
            this.lbARTICULOS_REMISION.TabIndex = 175;
            this.lbARTICULOS_REMISION.Text = "0 ARTICULOS";
            // 
            // txtTraslada_Remision
            // 
            this.txtTraslada_Remision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTraslada_Remision.Location = new System.Drawing.Point(545, 43);
            this.txtTraslada_Remision.Name = "txtTraslada_Remision";
            this.txtTraslada_Remision.ReadOnly = true;
            this.txtTraslada_Remision.Size = new System.Drawing.Size(217, 20);
            this.txtTraslada_Remision.TabIndex = 174;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(363, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 173;
            this.label9.Text = "RESPONSABLE TRASLADO";
            // 
            // cbxSUC_ORG_Remision
            // 
            this.cbxSUC_ORG_Remision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUC_ORG_Remision.Enabled = false;
            this.cbxSUC_ORG_Remision.FormattingEnabled = true;
            this.cbxSUC_ORG_Remision.Location = new System.Drawing.Point(545, 16);
            this.cbxSUC_ORG_Remision.Name = "cbxSUC_ORG_Remision";
            this.cbxSUC_ORG_Remision.Size = new System.Drawing.Size(217, 21);
            this.cbxSUC_ORG_Remision.TabIndex = 172;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(476, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 171;
            this.label11.Text = "REMITE";
            // 
            // cbxSUC_DEST_Remision
            // 
            this.cbxSUC_DEST_Remision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUC_DEST_Remision.Enabled = false;
            this.cbxSUC_DEST_Remision.FormattingEnabled = true;
            this.cbxSUC_DEST_Remision.Location = new System.Drawing.Point(545, 69);
            this.cbxSUC_DEST_Remision.Name = "cbxSUC_DEST_Remision";
            this.cbxSUC_DEST_Remision.Size = new System.Drawing.Size(217, 21);
            this.cbxSUC_DEST_Remision.TabIndex = 170;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(468, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 169;
            this.label12.Text = "DESTINO";
            // 
            // cbxTIPODOC_Remision
            // 
            this.cbxTIPODOC_Remision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPODOC_Remision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTIPODOC_Remision.FormattingEnabled = true;
            this.cbxTIPODOC_Remision.Location = new System.Drawing.Point(34, 28);
            this.cbxTIPODOC_Remision.Name = "cbxTIPODOC_Remision";
            this.cbxTIPODOC_Remision.Size = new System.Drawing.Size(128, 21);
            this.cbxTIPODOC_Remision.TabIndex = 168;
            // 
            // lbTOTAL_REMISION
            // 
            this.lbTOTAL_REMISION.AutoSize = true;
            this.lbTOTAL_REMISION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL_REMISION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTOTAL_REMISION.Location = new System.Drawing.Point(783, 476);
            this.lbTOTAL_REMISION.Name = "lbTOTAL_REMISION";
            this.lbTOTAL_REMISION.Size = new System.Drawing.Size(40, 17);
            this.lbTOTAL_REMISION.TabIndex = 167;
            this.lbTOTAL_REMISION.Text = "0.00";
            // 
            // tblInventario
            // 
            this.tblInventario.AllowUserToAddRows = false;
            this.tblInventario.AllowUserToDeleteRows = false;
            this.tblInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MOV_RM,
            this.CODIGO_RM,
            this.CANTIDAD_RM,
            this.ARTICULO_RM,
            this.DESCRIPCION_RM,
            this.PRECIO});
            this.tblInventario.Location = new System.Drawing.Point(16, 157);
            this.tblInventario.Name = "tblInventario";
            this.tblInventario.ReadOnly = true;
            this.tblInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblInventario.Size = new System.Drawing.Size(857, 306);
            this.tblInventario.TabIndex = 166;
            this.tblInventario.DataSourceChanged += new System.EventHandler(this.tblInventario_DataSourceChanged);
            // 
            // ID_MOV_RM
            // 
            this.ID_MOV_RM.DataPropertyName = "ID_MOV";
            dataGridViewCellStyle3.Format = "N0";
            this.ID_MOV_RM.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_MOV_RM.HeaderText = "ID_MOV";
            this.ID_MOV_RM.Name = "ID_MOV_RM";
            this.ID_MOV_RM.ReadOnly = true;
            this.ID_MOV_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_MOV_RM.Visible = false;
            // 
            // CODIGO_RM
            // 
            this.CODIGO_RM.DataPropertyName = "CODIGO";
            this.CODIGO_RM.HeaderText = "CODIGO";
            this.CODIGO_RM.Name = "CODIGO_RM";
            this.CODIGO_RM.ReadOnly = true;
            this.CODIGO_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD_RM
            // 
            this.CANTIDAD_RM.DataPropertyName = "CANTIDAD";
            this.CANTIDAD_RM.HeaderText = "CANT/PESO";
            this.CANTIDAD_RM.Name = "CANTIDAD_RM";
            this.CANTIDAD_RM.ReadOnly = true;
            this.CANTIDAD_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD_RM.Width = 75;
            // 
            // ARTICULO_RM
            // 
            this.ARTICULO_RM.DataPropertyName = "ARTICULO";
            this.ARTICULO_RM.HeaderText = "ART/KIL";
            this.ARTICULO_RM.Name = "ARTICULO_RM";
            this.ARTICULO_RM.ReadOnly = true;
            this.ARTICULO_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION_RM
            // 
            this.DESCRIPCION_RM.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION_RM.HeaderText = "DESCRIPCION";
            this.DESCRIPCION_RM.Name = "DESCRIPCION_RM";
            this.DESCRIPCION_RM.ReadOnly = true;
            this.DESCRIPCION_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION_RM.Width = 400;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            dataGridViewCellStyle4.Format = "C2";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle4;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtEnvia_Remision
            // 
            this.txtEnvia_Remision.Location = new System.Drawing.Point(168, 93);
            this.txtEnvia_Remision.Name = "txtEnvia_Remision";
            this.txtEnvia_Remision.ReadOnly = true;
            this.txtEnvia_Remision.Size = new System.Drawing.Size(233, 20);
            this.txtEnvia_Remision.TabIndex = 165;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(23, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 164;
            this.label14.Text = "RESPONSABLE ENVIO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(429, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 163;
            this.label15.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA_Remision
            // 
            this.txtNOTA_Remision.Location = new System.Drawing.Point(546, 96);
            this.txtNOTA_Remision.Name = "txtNOTA_Remision";
            this.txtNOTA_Remision.ReadOnly = true;
            this.txtNOTA_Remision.Size = new System.Drawing.Size(314, 53);
            this.txtNOTA_Remision.TabIndex = 162;
            this.txtNOTA_Remision.Text = "";
            // 
            // dateTraslado_Remision
            // 
            this.dateTraslado_Remision.Enabled = false;
            this.dateTraslado_Remision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTraslado_Remision.Location = new System.Drawing.Point(168, 66);
            this.dateTraslado_Remision.Name = "dateTraslado_Remision";
            this.dateTraslado_Remision.Size = new System.Drawing.Size(129, 20);
            this.dateTraslado_Remision.TabIndex = 161;
            // 
            // txtNUMERO_Remision
            // 
            this.txtNUMERO_Remision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMERO_Remision.Location = new System.Drawing.Point(168, 28);
            this.txtNUMERO_Remision.Name = "txtNUMERO_Remision";
            this.txtNUMERO_Remision.Size = new System.Drawing.Size(129, 30);
            this.txtNUMERO_Remision.TabIndex = 160;
            this.txtNUMERO_Remision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNUMERO_Remision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNUMERO_Remision_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(115, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 159;
            this.label16.Text = "FECHA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(199, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 158;
            this.label17.Text = "NUMERO";
            // 
            // btnRECIBIR_REMISION
            // 
            this.btnRECIBIR_REMISION.Enabled = false;
            this.btnRECIBIR_REMISION.Image = global::PrendaSAL.Properties.Resources.recibir;
            this.btnRECIBIR_REMISION.Location = new System.Drawing.Point(800, 16);
            this.btnRECIBIR_REMISION.Name = "btnRECIBIR_REMISION";
            this.btnRECIBIR_REMISION.Size = new System.Drawing.Size(73, 63);
            this.btnRECIBIR_REMISION.TabIndex = 157;
            this.btnRECIBIR_REMISION.Text = "Recibir";
            this.btnRECIBIR_REMISION.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRECIBIR_REMISION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRECIBIR_REMISION.UseVisualStyleBackColor = true;
            this.btnRECIBIR_REMISION.Click += new System.EventHandler(this.RECIBIR_REMISION);
            // 
            // RecibirInvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 549);
            this.Controls.Add(this.tabControlEnvio);
            this.MaximizeBox = false;
            this.Name = "RecibirInvForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RECEPCION DE ARTICULOS";
            this.Load += new System.EventHandler(this.RecibirInvForm_Load);
            this.tabControlEnvio.ResumeLayout(false);
            this.pagCustodia.ResumeLayout(false);
            this.pagCustodia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustodia)).EndInit();
            this.pagRemision.ResumeLayout(false);
            this.pagRemision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEnvio;
        private System.Windows.Forms.TabPage pagCustodia;
        private System.Windows.Forms.Button btnRECIBIR_CUSTODIA;
        private System.Windows.Forms.TabPage pagRemision;
        private System.Windows.Forms.TextBox txtTraslada_Custodia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSUC_ORG_Custodia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSUC_DEST_Custodia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxTIPODOC_Custodia;
        private System.Windows.Forms.Label lbTOTAL_CUSTODIA;
        private System.Windows.Forms.DataGridView tblCustodia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.TextBox txtEnvia_Custodia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtNOTA_Custodia;
        private System.Windows.Forms.DateTimePicker dateTraslado_Custodia;
        private System.Windows.Forms.TextBox txtNUMERO_Custodia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbARTICULOS_CUSTODIA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbARTICULOS_REMISION;
        private System.Windows.Forms.TextBox txtTraslada_Remision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxSUC_ORG_Remision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSUC_DEST_Remision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxTIPODOC_Remision;
        private System.Windows.Forms.Label lbTOTAL_REMISION;
        private System.Windows.Forms.DataGridView tblInventario;
        private System.Windows.Forms.TextBox txtEnvia_Remision;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox txtNOTA_Remision;
        private System.Windows.Forms.DateTimePicker dateTraslado_Remision;
        private System.Windows.Forms.TextBox txtNUMERO_Remision;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRECIBIR_REMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOV_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.TextBox txtRecibe_Custodia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecibe_Remision;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtESTADO_Custodia;
        private System.Windows.Forms.TextBox txtESTADO_Remision;
    }
}