namespace PrendaSAL.Reportes
{
    partial class VencidosDiaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblVENCIDOS = new System.Windows.Forms.DataGridView();
            this.btnLISTAR = new System.Windows.Forms.Button();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAZO_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_TRANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblVENCIDOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblVENCIDOS
            // 
            this.tblVENCIDOS.AllowUserToAddRows = false;
            this.tblVENCIDOS.AllowUserToDeleteRows = false;
            this.tblVENCIDOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblVENCIDOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblVENCIDOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCUMENTO,
            this.FECHA,
            this.CLIENTE,
            this.TELEFONO,
            this.ARTICULO,
            this.TOTAL,
            this.FECHA_VENC,
            this.PLAZO_CONTRATO,
            this.DIAS_TRANS});
            this.tblVENCIDOS.Location = new System.Drawing.Point(12, 65);
            this.tblVENCIDOS.Name = "tblVENCIDOS";
            this.tblVENCIDOS.ReadOnly = true;
            this.tblVENCIDOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVENCIDOS.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblVENCIDOS.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.tblVENCIDOS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tblVENCIDOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblVENCIDOS.Size = new System.Drawing.Size(946, 290);
            this.tblVENCIDOS.TabIndex = 110;
            this.tblVENCIDOS.DataSourceChanged += new System.EventHandler(this.tblVENCIDOS_DataSourceChanged);
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Image = global::PrendaSAL.Properties.Resources.listar;
            this.btnLISTAR.Location = new System.Drawing.Point(255, 9);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(94, 50);
            this.btnLISTAR.TabIndex = 109;
            this.btnLISTAR.Text = "LISTAR";
            this.btnLISTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(12, 25);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 108;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 107;
            this.label19.Text = "SUCURSAL";
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.Location = new System.Drawing.Point(840, 358);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(118, 17);
            this.lbTOTAL.TabIndex = 111;
            this.lbTOTAL.Text = "# CONTRATOS";
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DOCUMENTO.DefaultCellStyle = dataGridViewCellStyle1;
            this.DOCUMENTO.HeaderText = "CONTRATO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DOCUMENTO.Width = 75;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA.Width = 75;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle3;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CLIENTE.Width = 200;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TEL_CLI";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TELEFONO.DefaultCellStyle = dataGridViewCellStyle4;
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TELEFONO.Width = 75;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ARTICULO.DefaultCellStyle = dataGridViewCellStyle5;
            this.ARTICULO.HeaderText = "ARTICULOS";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ARTICULO.Width = 200;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle6;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TOTAL.Width = 70;
            // 
            // FECHA_VENC
            // 
            this.FECHA_VENC.DataPropertyName = "FECHA_VENC";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FECHA_VENC.DefaultCellStyle = dataGridViewCellStyle7;
            this.FECHA_VENC.HeaderText = "F. VTO";
            this.FECHA_VENC.Name = "FECHA_VENC";
            this.FECHA_VENC.ReadOnly = true;
            this.FECHA_VENC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_VENC.Width = 70;
            // 
            // PLAZO_CONTRATO
            // 
            this.PLAZO_CONTRATO.DataPropertyName = "PLAZO_CONTRATO";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.PLAZO_CONTRATO.DefaultCellStyle = dataGridViewCellStyle8;
            this.PLAZO_CONTRATO.HeaderText = "PLAZO CTO";
            this.PLAZO_CONTRATO.Name = "PLAZO_CONTRATO";
            this.PLAZO_CONTRATO.ReadOnly = true;
            this.PLAZO_CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PLAZO_CONTRATO.Width = 60;
            // 
            // DIAS_TRANS
            // 
            this.DIAS_TRANS.DataPropertyName = "DIAS_TRANS";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DIAS_TRANS.DefaultCellStyle = dataGridViewCellStyle9;
            this.DIAS_TRANS.HeaderText = "DIAS TRANS.";
            this.DIAS_TRANS.Name = "DIAS_TRANS";
            this.DIAS_TRANS.ReadOnly = true;
            this.DIAS_TRANS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIAS_TRANS.Width = 60;
            // 
            // VencidosDiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(969, 403);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.tblVENCIDOS);
            this.Controls.Add(this.btnLISTAR);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Name = "VencidosDiaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vencidos del Dia";
            this.Load += new System.EventHandler(this.VencidosDiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblVENCIDOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblVENCIDOS;
        private System.Windows.Forms.Button btnLISTAR;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAZO_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_TRANS;
        private System.Windows.Forms.Label lbTOTAL;
    }
}