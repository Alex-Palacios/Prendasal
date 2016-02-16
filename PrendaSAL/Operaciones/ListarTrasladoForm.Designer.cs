namespace PrendaSAL.Operaciones
{
    partial class ListarTrasladoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabDETALLE = new System.Windows.Forms.TabControl();
            this.pagARTICULOS = new System.Windows.Forms.TabPage();
            this.btnOK_REMISION = new System.Windows.Forms.Button();
            this.lbTOTAL_REMISION = new System.Windows.Forms.Label();
            this.ckALLRM = new System.Windows.Forms.CheckBox();
            this.tblREMISION = new System.Windows.Forms.DataGridView();
            this.CKRM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagPRESTAMOS = new System.Windows.Forms.TabPage();
            this.btnOK_CUSTODIA_PRESTAMO = new System.Windows.Forms.Button();
            this.lbTOTAL_CUSTODIA_PRESTAMO = new System.Windows.Forms.Label();
            this.ckALLCVP = new System.Windows.Forms.CheckBox();
            this.tblCUSTODIA_PRESTAMOS = new System.Windows.Forms.DataGridView();
            this.CKCVP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRATO_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagCOMPRAS = new System.Windows.Forms.TabPage();
            this.btnOK_CUSTODIA_COMPRA = new System.Windows.Forms.Button();
            this.lbTOTAL_CUSTODIA_COMPRA = new System.Windows.Forms.Label();
            this.ckALLCVC = new System.Windows.Forms.CheckBox();
            this.tblCUSTODIA_COMPRAS = new System.Windows.Forms.DataGridView();
            this.CKCVC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRATO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDETALLE.SuspendLayout();
            this.pagARTICULOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).BeginInit();
            this.pagPRESTAMOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).BeginInit();
            this.pagCOMPRAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDETALLE
            // 
            this.tabDETALLE.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabDETALLE.Controls.Add(this.pagARTICULOS);
            this.tabDETALLE.Controls.Add(this.pagPRESTAMOS);
            this.tabDETALLE.Controls.Add(this.pagCOMPRAS);
            this.tabDETALLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDETALLE.Location = new System.Drawing.Point(0, 0);
            this.tabDETALLE.Multiline = true;
            this.tabDETALLE.Name = "tabDETALLE";
            this.tabDETALLE.SelectedIndex = 0;
            this.tabDETALLE.Size = new System.Drawing.Size(870, 392);
            this.tabDETALLE.TabIndex = 144;
            // 
            // pagARTICULOS
            // 
            this.pagARTICULOS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pagARTICULOS.Controls.Add(this.btnOK_REMISION);
            this.pagARTICULOS.Controls.Add(this.lbTOTAL_REMISION);
            this.pagARTICULOS.Controls.Add(this.ckALLRM);
            this.pagARTICULOS.Controls.Add(this.tblREMISION);
            this.pagARTICULOS.Location = new System.Drawing.Point(42, 4);
            this.pagARTICULOS.Name = "pagARTICULOS";
            this.pagARTICULOS.Padding = new System.Windows.Forms.Padding(3);
            this.pagARTICULOS.Size = new System.Drawing.Size(824, 384);
            this.pagARTICULOS.TabIndex = 1;
            this.pagARTICULOS.Text = "NOTA DE REMISION";
            // 
            // btnOK_REMISION
            // 
            this.btnOK_REMISION.Location = new System.Drawing.Point(679, 353);
            this.btnOK_REMISION.Name = "btnOK_REMISION";
            this.btnOK_REMISION.Size = new System.Drawing.Size(115, 23);
            this.btnOK_REMISION.TabIndex = 151;
            this.btnOK_REMISION.Text = "OK";
            this.btnOK_REMISION.UseVisualStyleBackColor = true;
            this.btnOK_REMISION.Click += new System.EventHandler(this.btnOK_REMISION_Click);
            // 
            // lbTOTAL_REMISION
            // 
            this.lbTOTAL_REMISION.AutoSize = true;
            this.lbTOTAL_REMISION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL_REMISION.Location = new System.Drawing.Point(28, 356);
            this.lbTOTAL_REMISION.Name = "lbTOTAL_REMISION";
            this.lbTOTAL_REMISION.Size = new System.Drawing.Size(52, 17);
            this.lbTOTAL_REMISION.TabIndex = 150;
            this.lbTOTAL_REMISION.Text = "label1";
            // 
            // ckALLRM
            // 
            this.ckALLRM.AutoSize = true;
            this.ckALLRM.Location = new System.Drawing.Point(8, 6);
            this.ckALLRM.Name = "ckALLRM";
            this.ckALLRM.Size = new System.Drawing.Size(15, 14);
            this.ckALLRM.TabIndex = 145;
            this.ckALLRM.UseVisualStyleBackColor = true;
            this.ckALLRM.CheckedChanged += new System.EventHandler(this.ckALLRM_CheckedChanged);
            // 
            // tblREMISION
            // 
            this.tblREMISION.AllowUserToAddRows = false;
            this.tblREMISION.AllowUserToDeleteRows = false;
            this.tblREMISION.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblREMISION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblREMISION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKRM,
            this.CODIGO,
            this.CANTIDAD,
            this.COD_ITEM,
            this.DESCRIPCION,
            this.PRECIO});
            this.tblREMISION.Location = new System.Drawing.Point(3, 3);
            this.tblREMISION.MultiSelect = false;
            this.tblREMISION.Name = "tblREMISION";
            this.tblREMISION.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.tblREMISION.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblREMISION.Size = new System.Drawing.Size(818, 334);
            this.tblREMISION.TabIndex = 121;
            this.tblREMISION.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblREMISION_CellValueChanged);
            // 
            // CKRM
            // 
            this.CKRM.HeaderText = "";
            this.CKRM.Name = "CKRM";
            this.CKRM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CKRM.Width = 25;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO.Width = 175;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD.Width = 75;
            // 
            // COD_ITEM
            // 
            this.COD_ITEM.DataPropertyName = "COD_ITEM";
            this.COD_ITEM.HeaderText = "ARTICULO";
            this.COD_ITEM.Name = "COD_ITEM";
            this.COD_ITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION.Width = 325;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            dataGridViewCellStyle1.Format = "C2";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRECIO.Width = 80;
            // 
            // pagPRESTAMOS
            // 
            this.pagPRESTAMOS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pagPRESTAMOS.Controls.Add(this.btnOK_CUSTODIA_PRESTAMO);
            this.pagPRESTAMOS.Controls.Add(this.lbTOTAL_CUSTODIA_PRESTAMO);
            this.pagPRESTAMOS.Controls.Add(this.ckALLCVP);
            this.pagPRESTAMOS.Controls.Add(this.tblCUSTODIA_PRESTAMOS);
            this.pagPRESTAMOS.Location = new System.Drawing.Point(42, 4);
            this.pagPRESTAMOS.Name = "pagPRESTAMOS";
            this.pagPRESTAMOS.Padding = new System.Windows.Forms.Padding(3);
            this.pagPRESTAMOS.Size = new System.Drawing.Size(797, 384);
            this.pagPRESTAMOS.TabIndex = 0;
            this.pagPRESTAMOS.Text = "CUSTODIA DE VALORES";
            // 
            // btnOK_CUSTODIA_PRESTAMO
            // 
            this.btnOK_CUSTODIA_PRESTAMO.Location = new System.Drawing.Point(662, 278);
            this.btnOK_CUSTODIA_PRESTAMO.Name = "btnOK_CUSTODIA_PRESTAMO";
            this.btnOK_CUSTODIA_PRESTAMO.Size = new System.Drawing.Size(115, 23);
            this.btnOK_CUSTODIA_PRESTAMO.TabIndex = 149;
            this.btnOK_CUSTODIA_PRESTAMO.Text = "OK";
            this.btnOK_CUSTODIA_PRESTAMO.UseVisualStyleBackColor = true;
            this.btnOK_CUSTODIA_PRESTAMO.Click += new System.EventHandler(this.btnOK_CUSTODIA_PRESTAMO_Click);
            // 
            // lbTOTAL_CUSTODIA_PRESTAMO
            // 
            this.lbTOTAL_CUSTODIA_PRESTAMO.AutoSize = true;
            this.lbTOTAL_CUSTODIA_PRESTAMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL_CUSTODIA_PRESTAMO.Location = new System.Drawing.Point(659, 144);
            this.lbTOTAL_CUSTODIA_PRESTAMO.Name = "lbTOTAL_CUSTODIA_PRESTAMO";
            this.lbTOTAL_CUSTODIA_PRESTAMO.Size = new System.Drawing.Size(52, 17);
            this.lbTOTAL_CUSTODIA_PRESTAMO.TabIndex = 148;
            this.lbTOTAL_CUSTODIA_PRESTAMO.Text = "label1";
            // 
            // ckALLCVP
            // 
            this.ckALLCVP.AutoSize = true;
            this.ckALLCVP.Location = new System.Drawing.Point(8, 9);
            this.ckALLCVP.Name = "ckALLCVP";
            this.ckALLCVP.Size = new System.Drawing.Size(15, 14);
            this.ckALLCVP.TabIndex = 146;
            this.ckALLCVP.UseVisualStyleBackColor = true;
            this.ckALLCVP.CheckedChanged += new System.EventHandler(this.ckALLCVP_CheckedChanged);
            // 
            // tblCUSTODIA_PRESTAMOS
            // 
            this.tblCUSTODIA_PRESTAMOS.AllowUserToAddRows = false;
            this.tblCUSTODIA_PRESTAMOS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_PRESTAMOS.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.tblCUSTODIA_PRESTAMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_PRESTAMOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKCVP,
            this.CONTRATO_PRESTAMO,
            this.FECHA_PRESTAMO,
            this.CATEGORIA_PRESTAMO,
            this.ARTICULO_PRESTAMO});
            this.tblCUSTODIA_PRESTAMOS.Location = new System.Drawing.Point(2, 6);
            this.tblCUSTODIA_PRESTAMOS.MultiSelect = false;
            this.tblCUSTODIA_PRESTAMOS.Name = "tblCUSTODIA_PRESTAMOS";
            this.tblCUSTODIA_PRESTAMOS.RowHeadersVisible = false;
            this.tblCUSTODIA_PRESTAMOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCUSTODIA_PRESTAMOS.Size = new System.Drawing.Size(644, 361);
            this.tblCUSTODIA_PRESTAMOS.TabIndex = 122;
            this.tblCUSTODIA_PRESTAMOS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCUSTODIA_PRESTAMOS_CellValueChanged);
            // 
            // CKCVP
            // 
            this.CKCVP.DataPropertyName = "CKCVP";
            this.CKCVP.HeaderText = "";
            this.CKCVP.Name = "CKCVP";
            this.CKCVP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CKCVP.Width = 25;
            // 
            // CONTRATO_PRESTAMO
            // 
            this.CONTRATO_PRESTAMO.DataPropertyName = "DOCUMENTO";
            this.CONTRATO_PRESTAMO.HeaderText = "CONTRATO";
            this.CONTRATO_PRESTAMO.Name = "CONTRATO_PRESTAMO";
            this.CONTRATO_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CONTRATO_PRESTAMO.Width = 80;
            // 
            // FECHA_PRESTAMO
            // 
            this.FECHA_PRESTAMO.DataPropertyName = "FECHA";
            this.FECHA_PRESTAMO.HeaderText = "FECHA";
            this.FECHA_PRESTAMO.Name = "FECHA_PRESTAMO";
            this.FECHA_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_PRESTAMO.Width = 80;
            // 
            // CATEGORIA_PRESTAMO
            // 
            this.CATEGORIA_PRESTAMO.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.HeaderText = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.Name = "CATEGORIA_PRESTAMO";
            this.CATEGORIA_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CATEGORIA_PRESTAMO.Width = 80;
            // 
            // ARTICULO_PRESTAMO
            // 
            this.ARTICULO_PRESTAMO.DataPropertyName = "ARTICULO";
            this.ARTICULO_PRESTAMO.HeaderText = "ARTICULO/PRENDA";
            this.ARTICULO_PRESTAMO.Name = "ARTICULO_PRESTAMO";
            this.ARTICULO_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ARTICULO_PRESTAMO.Width = 350;
            // 
            // pagCOMPRAS
            // 
            this.pagCOMPRAS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pagCOMPRAS.Controls.Add(this.btnOK_CUSTODIA_COMPRA);
            this.pagCOMPRAS.Controls.Add(this.lbTOTAL_CUSTODIA_COMPRA);
            this.pagCOMPRAS.Controls.Add(this.ckALLCVC);
            this.pagCOMPRAS.Controls.Add(this.tblCUSTODIA_COMPRAS);
            this.pagCOMPRAS.Location = new System.Drawing.Point(42, 4);
            this.pagCOMPRAS.Name = "pagCOMPRAS";
            this.pagCOMPRAS.Padding = new System.Windows.Forms.Padding(3);
            this.pagCOMPRAS.Size = new System.Drawing.Size(797, 384);
            this.pagCOMPRAS.TabIndex = 2;
            this.pagCOMPRAS.Text = "CUSTODIA DE VALORES";
            // 
            // btnOK_CUSTODIA_COMPRA
            // 
            this.btnOK_CUSTODIA_COMPRA.Location = new System.Drawing.Point(676, 303);
            this.btnOK_CUSTODIA_COMPRA.Name = "btnOK_CUSTODIA_COMPRA";
            this.btnOK_CUSTODIA_COMPRA.Size = new System.Drawing.Size(115, 23);
            this.btnOK_CUSTODIA_COMPRA.TabIndex = 151;
            this.btnOK_CUSTODIA_COMPRA.Text = "OK";
            this.btnOK_CUSTODIA_COMPRA.UseVisualStyleBackColor = true;
            this.btnOK_CUSTODIA_COMPRA.Click += new System.EventHandler(this.btnOK_CUSTODIA_COMPRA_Click);
            // 
            // lbTOTAL_CUSTODIA_COMPRA
            // 
            this.lbTOTAL_CUSTODIA_COMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL_CUSTODIA_COMPRA.Location = new System.Drawing.Point(676, 157);
            this.lbTOTAL_CUSTODIA_COMPRA.Name = "lbTOTAL_CUSTODIA_COMPRA";
            this.lbTOTAL_CUSTODIA_COMPRA.Size = new System.Drawing.Size(115, 51);
            this.lbTOTAL_CUSTODIA_COMPRA.TabIndex = 150;
            this.lbTOTAL_CUSTODIA_COMPRA.Text = "label1";
            this.lbTOTAL_CUSTODIA_COMPRA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckALLCVC
            // 
            this.ckALLCVC.AutoSize = true;
            this.ckALLCVC.Location = new System.Drawing.Point(13, 19);
            this.ckALLCVC.Name = "ckALLCVC";
            this.ckALLCVC.Size = new System.Drawing.Size(15, 14);
            this.ckALLCVC.TabIndex = 149;
            this.ckALLCVC.UseVisualStyleBackColor = true;
            this.ckALLCVC.CheckedChanged += new System.EventHandler(this.ckALLCVC_CheckedChanged);
            // 
            // tblCUSTODIA_COMPRAS
            // 
            this.tblCUSTODIA_COMPRAS.AllowUserToAddRows = false;
            this.tblCUSTODIA_COMPRAS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_COMPRAS.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.tblCUSTODIA_COMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_COMPRAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKCVC,
            this.CONTRATO_COMPRA,
            this.FECHA_COMPRA,
            this.CATEGORIA_COMPRA,
            this.ARTICULO_COMPRA,
            this.NIVEL_COMPRA});
            this.tblCUSTODIA_COMPRAS.Location = new System.Drawing.Point(6, 15);
            this.tblCUSTODIA_COMPRAS.Name = "tblCUSTODIA_COMPRAS";
            this.tblCUSTODIA_COMPRAS.RowHeadersVisible = false;
            this.tblCUSTODIA_COMPRAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCUSTODIA_COMPRAS.Size = new System.Drawing.Size(667, 361);
            this.tblCUSTODIA_COMPRAS.TabIndex = 148;
            this.tblCUSTODIA_COMPRAS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCUSTODIA_COMPRAS_CellValueChanged);
            // 
            // CKCVC
            // 
            this.CKCVC.DataPropertyName = "CKCVC";
            this.CKCVC.HeaderText = "";
            this.CKCVC.Name = "CKCVC";
            this.CKCVC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CKCVC.Width = 25;
            // 
            // CONTRATO_COMPRA
            // 
            this.CONTRATO_COMPRA.DataPropertyName = "DOCUMENTO";
            this.CONTRATO_COMPRA.HeaderText = "COMPRA";
            this.CONTRATO_COMPRA.Name = "CONTRATO_COMPRA";
            this.CONTRATO_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CONTRATO_COMPRA.Width = 80;
            // 
            // FECHA_COMPRA
            // 
            this.FECHA_COMPRA.DataPropertyName = "FECHA";
            this.FECHA_COMPRA.HeaderText = "FECHA";
            this.FECHA_COMPRA.Name = "FECHA_COMPRA";
            this.FECHA_COMPRA.ReadOnly = true;
            this.FECHA_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_COMPRA.Width = 80;
            // 
            // CATEGORIA_COMPRA
            // 
            this.CATEGORIA_COMPRA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_COMPRA.HeaderText = "CATEGORIA";
            this.CATEGORIA_COMPRA.Name = "CATEGORIA_COMPRA";
            this.CATEGORIA_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CATEGORIA_COMPRA.Width = 80;
            // 
            // ARTICULO_COMPRA
            // 
            this.ARTICULO_COMPRA.DataPropertyName = "ARTICULO";
            this.ARTICULO_COMPRA.HeaderText = "ARTICULO/PRENDA";
            this.ARTICULO_COMPRA.Name = "ARTICULO_COMPRA";
            this.ARTICULO_COMPRA.ReadOnly = true;
            this.ARTICULO_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ARTICULO_COMPRA.Width = 300;
            // 
            // NIVEL_COMPRA
            // 
            this.NIVEL_COMPRA.DataPropertyName = "NIVEL";
            this.NIVEL_COMPRA.HeaderText = "MAYOREO";
            this.NIVEL_COMPRA.Name = "NIVEL_COMPRA";
            this.NIVEL_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NIVEL_COMPRA.Width = 80;
            // 
            // ListarTrasladoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 392);
            this.Controls.Add(this.tabDETALLE);
            this.MaximizeBox = false;
            this.Name = "ListarTrasladoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ENVIO DE ARTICULOS/PRENDAS";
            this.Load += new System.EventHandler(this.EnviarInvForm_Load);
            this.tabDETALLE.ResumeLayout(false);
            this.pagARTICULOS.ResumeLayout(false);
            this.pagARTICULOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).EndInit();
            this.pagPRESTAMOS.ResumeLayout(false);
            this.pagPRESTAMOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).EndInit();
            this.pagCOMPRAS.ResumeLayout(false);
            this.pagCOMPRAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDETALLE;
        private System.Windows.Forms.TabPage pagPRESTAMOS;
        private System.Windows.Forms.DataGridView tblCUSTODIA_PRESTAMOS;
        private System.Windows.Forms.TabPage pagARTICULOS;
        private System.Windows.Forms.DataGridView tblREMISION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.CheckBox ckALLRM;
        private System.Windows.Forms.CheckBox ckALLCVP;
        private System.Windows.Forms.Button btnOK_CUSTODIA_PRESTAMO;
        private System.Windows.Forms.Label lbTOTAL_CUSTODIA_PRESTAMO;
        private System.Windows.Forms.Button btnOK_REMISION;
        private System.Windows.Forms.Label lbTOTAL_REMISION;
        private System.Windows.Forms.TabPage pagCOMPRAS;
        private System.Windows.Forms.CheckBox ckALLCVC;
        private System.Windows.Forms.DataGridView tblCUSTODIA_COMPRAS;
        private System.Windows.Forms.Button btnOK_CUSTODIA_COMPRA;
        private System.Windows.Forms.Label lbTOTAL_CUSTODIA_COMPRA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKCVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO_PRESTAMO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKCVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_COMPRA;
    }
}