namespace PrendaSAL.Operaciones
{
    partial class EnviarInvForm
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
            this.pagCUSTODIA = new System.Windows.Forms.TabPage();
            this.ckALLCVC = new System.Windows.Forms.CheckBox();
            this.ckALLCVP = new System.Windows.Forms.CheckBox();
            this.tblCUSTODIA_COMPRAS = new System.Windows.Forms.DataGridView();
            this.CKCVC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRATO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCUSTODIA_PRESTAMOS = new System.Windows.Forms.DataGridView();
            this.CKCVP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONTRATO_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagREMISION = new System.Windows.Forms.TabPage();
            this.ckALLRM = new System.Windows.Forms.CheckBox();
            this.tblREMISION = new System.Windows.Forms.DataGridView();
            this.CKRM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTOTAL_RM = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabDETALLE.SuspendLayout();
            this.pagCUSTODIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).BeginInit();
            this.pagREMISION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDETALLE
            // 
            this.tabDETALLE.Controls.Add(this.pagCUSTODIA);
            this.tabDETALLE.Controls.Add(this.pagREMISION);
            this.tabDETALLE.Location = new System.Drawing.Point(6, 4);
            this.tabDETALLE.Name = "tabDETALLE";
            this.tabDETALLE.SelectedIndex = 0;
            this.tabDETALLE.Size = new System.Drawing.Size(894, 399);
            this.tabDETALLE.TabIndex = 144;
            // 
            // pagCUSTODIA
            // 
            this.pagCUSTODIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pagCUSTODIA.Controls.Add(this.ckALLCVC);
            this.pagCUSTODIA.Controls.Add(this.ckALLCVP);
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA_COMPRAS);
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA_PRESTAMOS);
            this.pagCUSTODIA.Location = new System.Drawing.Point(4, 22);
            this.pagCUSTODIA.Name = "pagCUSTODIA";
            this.pagCUSTODIA.Padding = new System.Windows.Forms.Padding(3);
            this.pagCUSTODIA.Size = new System.Drawing.Size(886, 373);
            this.pagCUSTODIA.TabIndex = 0;
            this.pagCUSTODIA.Text = "CUSTODIA DE VALORES";
            // 
            // ckALLCVC
            // 
            this.ckALLCVC.AutoSize = true;
            this.ckALLCVC.Location = new System.Drawing.Point(319, 9);
            this.ckALLCVC.Name = "ckALLCVC";
            this.ckALLCVC.Size = new System.Drawing.Size(15, 14);
            this.ckALLCVC.TabIndex = 147;
            this.ckALLCVC.UseVisualStyleBackColor = true;
            this.ckALLCVC.CheckedChanged += new System.EventHandler(this.ckALLCVC_CheckedChanged);
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
            // tblCUSTODIA_COMPRAS
            // 
            this.tblCUSTODIA_COMPRAS.AllowUserToAddRows = false;
            this.tblCUSTODIA_COMPRAS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_COMPRAS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCUSTODIA_COMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_COMPRAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKCVC,
            this.CONTRATO_COMPRA,
            this.CATEGORIA_COMPRA,
            this.NIVEL});
            this.tblCUSTODIA_COMPRAS.Location = new System.Drawing.Point(310, 6);
            this.tblCUSTODIA_COMPRAS.Name = "tblCUSTODIA_COMPRAS";
            this.tblCUSTODIA_COMPRAS.RowHeadersVisible = false;
            this.tblCUSTODIA_COMPRAS.Size = new System.Drawing.Size(348, 361);
            this.tblCUSTODIA_COMPRAS.TabIndex = 123;
            this.tblCUSTODIA_COMPRAS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblCUSTODIA_COMPRAS_CellFormatting);
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
            this.CONTRATO_COMPRA.DataPropertyName = "CONTRATO";
            this.CONTRATO_COMPRA.HeaderText = "COMPRA";
            this.CONTRATO_COMPRA.Name = "CONTRATO_COMPRA";
            this.CONTRATO_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CATEGORIA_COMPRA
            // 
            this.CATEGORIA_COMPRA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_COMPRA.HeaderText = "CATEGORIA";
            this.CATEGORIA_COMPRA.Name = "CATEGORIA_COMPRA";
            this.CATEGORIA_COMPRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            this.NIVEL.HeaderText = "MAYOREO";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblCUSTODIA_PRESTAMOS
            // 
            this.tblCUSTODIA_PRESTAMOS.AllowUserToAddRows = false;
            this.tblCUSTODIA_PRESTAMOS.AllowUserToDeleteRows = false;
            this.tblCUSTODIA_PRESTAMOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCUSTODIA_PRESTAMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA_PRESTAMOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKCVP,
            this.CONTRATO_PRESTAMO,
            this.CATEGORIA_PRESTAMO});
            this.tblCUSTODIA_PRESTAMOS.Location = new System.Drawing.Point(2, 6);
            this.tblCUSTODIA_PRESTAMOS.MultiSelect = false;
            this.tblCUSTODIA_PRESTAMOS.Name = "tblCUSTODIA_PRESTAMOS";
            this.tblCUSTODIA_PRESTAMOS.RowHeadersVisible = false;
            this.tblCUSTODIA_PRESTAMOS.Size = new System.Drawing.Size(252, 361);
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
            this.CONTRATO_PRESTAMO.DataPropertyName = "CONTRATO";
            this.CONTRATO_PRESTAMO.HeaderText = "CONTRATO";
            this.CONTRATO_PRESTAMO.Name = "CONTRATO_PRESTAMO";
            this.CONTRATO_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CATEGORIA_PRESTAMO
            // 
            this.CATEGORIA_PRESTAMO.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.HeaderText = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.Name = "CATEGORIA_PRESTAMO";
            this.CATEGORIA_PRESTAMO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pagREMISION
            // 
            this.pagREMISION.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pagREMISION.Controls.Add(this.ckALLRM);
            this.pagREMISION.Controls.Add(this.tblREMISION);
            this.pagREMISION.Location = new System.Drawing.Point(4, 22);
            this.pagREMISION.Name = "pagREMISION";
            this.pagREMISION.Padding = new System.Windows.Forms.Padding(3);
            this.pagREMISION.Size = new System.Drawing.Size(886, 373);
            this.pagREMISION.TabIndex = 1;
            this.pagREMISION.Text = "NOTA DE REMISION";
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
            this.tblREMISION.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblREMISION.Location = new System.Drawing.Point(3, 3);
            this.tblREMISION.MultiSelect = false;
            this.tblREMISION.Name = "tblREMISION";
            this.tblREMISION.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.tblREMISION.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblREMISION.Size = new System.Drawing.Size(880, 367);
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
            // lbTOTAL_RM
            // 
            this.lbTOTAL_RM.AutoSize = true;
            this.lbTOTAL_RM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL_RM.Location = new System.Drawing.Point(15, 420);
            this.lbTOTAL_RM.Name = "lbTOTAL_RM";
            this.lbTOTAL_RM.Size = new System.Drawing.Size(52, 17);
            this.lbTOTAL_RM.TabIndex = 145;
            this.lbTOTAL_RM.Text = "label1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(762, 420);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 23);
            this.btnOK.TabIndex = 146;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EnviarInvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 460);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbTOTAL_RM);
            this.Controls.Add(this.tabDETALLE);
            this.MaximizeBox = false;
            this.Name = "EnviarInvForm";
            this.Text = "ENVIO DE ARTICULOS/PRENDAS";
            this.Load += new System.EventHandler(this.EnviarInvForm_Load);
            this.tabDETALLE.ResumeLayout(false);
            this.pagCUSTODIA.ResumeLayout(false);
            this.pagCUSTODIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_COMPRAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA_PRESTAMOS)).EndInit();
            this.pagREMISION.ResumeLayout(false);
            this.pagREMISION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDETALLE;
        private System.Windows.Forms.TabPage pagCUSTODIA;
        private System.Windows.Forms.DataGridView tblCUSTODIA_COMPRAS;
        private System.Windows.Forms.DataGridView tblCUSTODIA_PRESTAMOS;
        private System.Windows.Forms.TabPage pagREMISION;
        private System.Windows.Forms.DataGridView tblREMISION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.CheckBox ckALLRM;
        private System.Windows.Forms.Label lbTOTAL_RM;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox ckALLCVC;
        private System.Windows.Forms.CheckBox ckALLCVP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKCVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKCVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_PRESTAMO;
    }
}