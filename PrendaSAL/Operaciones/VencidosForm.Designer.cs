namespace PrendaSAL.Operaciones
{
    partial class VencidosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tblVENCIDOS = new System.Windows.Forms.DataGridView();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAZO_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_TRANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.lbCheck = new System.Windows.Forms.Label();
            this.numDIAS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckALL = new System.Windows.Forms.CheckBox();
            this.btnVENCER = new System.Windows.Forms.Button();
            this.btnLISTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblVENCIDOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(101, 12);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 104;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 103;
            this.label19.Text = "SUCURSAL";
            // 
            // tblVENCIDOS
            // 
            this.tblVENCIDOS.AllowUserToAddRows = false;
            this.tblVENCIDOS.AllowUserToDeleteRows = false;
            this.tblVENCIDOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblVENCIDOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblVENCIDOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK,
            this.ID_PRESTAMO,
            this.DOCUMENTO,
            this.FECHA,
            this.CLIENTE,
            this.TELEFONO,
            this.ARTICULO,
            this.TOTAL,
            this.SALDO,
            this.ESTADO,
            this.PLAZO_VENC,
            this.DIAS_TRANS});
            this.tblVENCIDOS.Location = new System.Drawing.Point(12, 68);
            this.tblVENCIDOS.Name = "tblVENCIDOS";
            this.tblVENCIDOS.ReadOnly = true;
            this.tblVENCIDOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVENCIDOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblVENCIDOS.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.tblVENCIDOS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblVENCIDOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblVENCIDOS.Size = new System.Drawing.Size(1112, 353);
            this.tblVENCIDOS.TabIndex = 106;
            this.tblVENCIDOS.DataSourceChanged += new System.EventHandler(this.tblVENCIDOS_DataSourceChanged);
            this.tblVENCIDOS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVENCIDOS_CellValueChanged);
            this.tblVENCIDOS.CurrentCellDirtyStateChanged += new System.EventHandler(this.tblVENCIDOS_CurrentCellDirtyStateChanged);
            // 
            // CHECK
            // 
            this.CHECK.DataPropertyName = "CHECK";
            this.CHECK.HeaderText = "";
            this.CHECK.Name = "CHECK";
            this.CHECK.ReadOnly = true;
            this.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK.Width = 25;
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
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DOCUMENTO.DefaultCellStyle = dataGridViewCellStyle11;
            this.DOCUMENTO.HeaderText = "CONTRATO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DOCUMENTO.Width = 75;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle12;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA.Width = 75;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle13;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CLIENTE.Width = 200;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TEL_CLI";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TELEFONO.DefaultCellStyle = dataGridViewCellStyle14;
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TELEFONO.Width = 75;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ARTICULO.DefaultCellStyle = dataGridViewCellStyle15;
            this.ARTICULO.HeaderText = "PRENDA/ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ARTICULO.Width = 200;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle16;
            this.TOTAL.HeaderText = "PRESTAMO";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TOTAL.Width = 70;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO_CONTRATO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PLAZO_VENC
            // 
            this.PLAZO_VENC.DataPropertyName = "PLAZO_VENC";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.PLAZO_VENC.DefaultCellStyle = dataGridViewCellStyle17;
            this.PLAZO_VENC.HeaderText = "PLAZO CIERRE";
            this.PLAZO_VENC.Name = "PLAZO_VENC";
            this.PLAZO_VENC.ReadOnly = true;
            this.PLAZO_VENC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PLAZO_VENC.Width = 60;
            // 
            // DIAS_TRANS
            // 
            this.DIAS_TRANS.DataPropertyName = "DIAS_TRANS";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DIAS_TRANS.DefaultCellStyle = dataGridViewCellStyle18;
            this.DIAS_TRANS.HeaderText = "DIAS TRANS.";
            this.DIAS_TRANS.Name = "DIAS_TRANS";
            this.DIAS_TRANS.ReadOnly = true;
            this.DIAS_TRANS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIAS_TRANS.Width = 60;
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.Location = new System.Drawing.Point(1030, 52);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(94, 13);
            this.lbTOTAL.TabIndex = 107;
            this.lbTOTAL.Text = "0 CONTRATOS";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheck.Location = new System.Drawing.Point(46, 457);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(121, 13);
            this.lbCheck.TabIndex = 109;
            this.lbCheck.Text = "0 SELECCIONADOS";
            // 
            // numDIAS
            // 
            this.numDIAS.Location = new System.Drawing.Point(430, 12);
            this.numDIAS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDIAS.Name = "numDIAS";
            this.numDIAS.Size = new System.Drawing.Size(43, 20);
            this.numDIAS.TabIndex = 110;
            this.numDIAS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "CON MAS DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "DIAS";
            // 
            // ckALL
            // 
            this.ckALL.AutoSize = true;
            this.ckALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckALL.Location = new System.Drawing.Point(35, 427);
            this.ckALL.Name = "ckALL";
            this.ckALL.Size = new System.Drawing.Size(132, 17);
            this.ckALL.TabIndex = 114;
            this.ckALL.Text = "Seleccionar Todos";
            this.ckALL.UseVisualStyleBackColor = true;
            this.ckALL.CheckedChanged += new System.EventHandler(this.ckALL_CheckedChanged);
            // 
            // btnVENCER
            // 
            this.btnVENCER.Image = global::PrendaSAL.Properties.Resources.ok21;
            this.btnVENCER.Location = new System.Drawing.Point(230, 433);
            this.btnVENCER.Name = "btnVENCER";
            this.btnVENCER.Size = new System.Drawing.Size(137, 37);
            this.btnVENCER.TabIndex = 115;
            this.btnVENCER.Text = "LISTAR";
            this.btnVENCER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVENCER.UseVisualStyleBackColor = true;
            this.btnVENCER.Click += new System.EventHandler(this.CIERRE);
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Image = global::PrendaSAL.Properties.Resources.listar;
            this.btnLISTAR.Location = new System.Drawing.Point(560, 12);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(94, 50);
            this.btnLISTAR.TabIndex = 105;
            this.btnLISTAR.Text = "CONSULTAR";
            this.btnLISTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
            // 
            // VencidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 479);
            this.Controls.Add(this.btnVENCER);
            this.Controls.Add(this.ckALL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDIAS);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.tblVENCIDOS);
            this.Controls.Add(this.btnLISTAR);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.MaximizeBox = false;
            this.Name = "VencidosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VENCER CONTRATOS";
            this.Load += new System.EventHandler(this.VencidosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblVENCIDOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDIAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLISTAR;
        private System.Windows.Forms.DataGridView tblVENCIDOS;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.NumericUpDown numDIAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckALL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAZO_VENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_TRANS;
        private System.Windows.Forms.Button btnVENCER;
    }
}