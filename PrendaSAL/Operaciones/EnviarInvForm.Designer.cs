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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabDETALLE = new System.Windows.Forms.TabControl();
            this.pagCUSTODIA = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCUSTODIA = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnOK_RM = new System.Windows.Forms.Button();
            this.tabDETALLE.SuspendLayout();
            this.pagCUSTODIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA)).BeginInit();
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
            this.pagCUSTODIA.Controls.Add(this.dataGridView1);
            this.pagCUSTODIA.Controls.Add(this.tblCUSTODIA);
            this.pagCUSTODIA.Location = new System.Drawing.Point(4, 22);
            this.pagCUSTODIA.Name = "pagCUSTODIA";
            this.pagCUSTODIA.Padding = new System.Windows.Forms.Padding(3);
            this.pagCUSTODIA.Size = new System.Drawing.Size(886, 373);
            this.pagCUSTODIA.TabIndex = 0;
            this.pagCUSTODIA.Text = "CUSTODIA DE VALORES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.CATEGORIA_COMPRA,
            this.NIVEL});
            this.dataGridView1.Location = new System.Drawing.Point(6, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(736, 164);
            this.dataGridView1.TabIndex = 123;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUMC";
            this.dataGridViewTextBoxColumn2.HeaderText = "#";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CONTRATO_COMPRA";
            this.dataGridViewTextBoxColumn4.HeaderText = "COMPRA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // CATEGORIA_COMPRA
            // 
            this.CATEGORIA_COMPRA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_COMPRA.HeaderText = "CATEGORIA";
            this.CATEGORIA_COMPRA.Name = "CATEGORIA_COMPRA";
            this.CATEGORIA_COMPRA.ReadOnly = true;
            // 
            // NIVEL
            // 
            this.NIVEL.DataPropertyName = "NIVEL";
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.ReadOnly = true;
            // 
            // tblCUSTODIA
            // 
            this.tblCUSTODIA.AllowUserToAddRows = false;
            this.tblCUSTODIA.AllowUserToDeleteRows = false;
            this.tblCUSTODIA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCUSTODIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUSTODIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CONTRATO_PRESTAMO,
            this.CATEGORIA_PRESTAMO});
            this.tblCUSTODIA.Location = new System.Drawing.Point(3, 3);
            this.tblCUSTODIA.Name = "tblCUSTODIA";
            this.tblCUSTODIA.ReadOnly = true;
            this.tblCUSTODIA.RowHeadersVisible = false;
            this.tblCUSTODIA.Size = new System.Drawing.Size(739, 171);
            this.tblCUSTODIA.TabIndex = 122;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUMC";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // CONTRATO_PRESTAMO
            // 
            this.CONTRATO_PRESTAMO.DataPropertyName = "DOCUMENTO";
            this.CONTRATO_PRESTAMO.HeaderText = "CONTRATO";
            this.CONTRATO_PRESTAMO.Name = "CONTRATO_PRESTAMO";
            this.CONTRATO_PRESTAMO.ReadOnly = true;
            // 
            // CATEGORIA_PRESTAMO
            // 
            this.CATEGORIA_PRESTAMO.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.HeaderText = "CATEGORIA";
            this.CATEGORIA_PRESTAMO.Name = "CATEGORIA_PRESTAMO";
            this.CATEGORIA_PRESTAMO.ReadOnly = true;
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
            this.ckALLRM.CheckedChanged += new System.EventHandler(this.ckALL_CheckedChanged);
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
            this.tblREMISION.Name = "tblREMISION";
            this.tblREMISION.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.tblREMISION.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle5.Format = "C2";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle5;
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
            // btnOK_RM
            // 
            this.btnOK_RM.Location = new System.Drawing.Point(762, 420);
            this.btnOK_RM.Name = "btnOK_RM";
            this.btnOK_RM.Size = new System.Drawing.Size(115, 23);
            this.btnOK_RM.TabIndex = 146;
            this.btnOK_RM.Text = "OK";
            this.btnOK_RM.UseVisualStyleBackColor = true;
            this.btnOK_RM.Click += new System.EventHandler(this.btnOK_RM_Click);
            // 
            // EnviarInvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 460);
            this.Controls.Add(this.btnOK_RM);
            this.Controls.Add(this.lbTOTAL_RM);
            this.Controls.Add(this.tabDETALLE);
            this.MaximizeBox = false;
            this.Name = "EnviarInvForm";
            this.Text = "ENVIO DE ARTICULOS/PRENDAS";
            this.Load += new System.EventHandler(this.EnviarInvForm_Load);
            this.tabDETALLE.ResumeLayout(false);
            this.pagCUSTODIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUSTODIA)).EndInit();
            this.pagREMISION.ResumeLayout(false);
            this.pagREMISION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblREMISION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDETALLE;
        private System.Windows.Forms.TabPage pagCUSTODIA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.DataGridView tblCUSTODIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_PRESTAMO;
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
        private System.Windows.Forms.Button btnOK_RM;
    }
}