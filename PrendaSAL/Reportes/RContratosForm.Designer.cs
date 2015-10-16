namespace PrendaSAL.Reportes
{
    partial class RContratosForm
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
            this.tblCONTRATOS = new System.Windows.Forms.DataGridView();
            this.cbxESTADOS = new System.Windows.Forms.ComboBox();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNUM_TOTAL = new System.Windows.Forms.Label();
            this.btnLISTAR = new System.Windows.Forms.Button();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblCONTRATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCONTRATOS
            // 
            this.tblCONTRATOS.AllowUserToAddRows = false;
            this.tblCONTRATOS.AllowUserToDeleteRows = false;
            this.tblCONTRATOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCONTRATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCONTRATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.DOCUMENTO,
            this.CLIENTE,
            this.ARTICULO,
            this.TOTAL,
            this.ESTADO_CONTRATO});
            this.tblCONTRATOS.Location = new System.Drawing.Point(12, 68);
            this.tblCONTRATOS.Name = "tblCONTRATOS";
            this.tblCONTRATOS.ReadOnly = true;
            this.tblCONTRATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCONTRATOS.Size = new System.Drawing.Size(1049, 352);
            this.tblCONTRATOS.TabIndex = 0;
            this.tblCONTRATOS.DataSourceChanged += new System.EventHandler(this.tblCONTRATOS_DataSourceChanged);
            // 
            // cbxESTADOS
            // 
            this.cbxESTADOS.FormattingEnabled = true;
            this.cbxESTADOS.Location = new System.Drawing.Point(103, 41);
            this.cbxESTADOS.Name = "cbxESTADOS";
            this.cbxESTADOS.Size = new System.Drawing.Size(121, 21);
            this.cbxESTADOS.TabIndex = 1;
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(103, 12);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "SUCURSAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "ESTADO";
            // 
            // lbNUM_TOTAL
            // 
            this.lbNUM_TOTAL.AutoSize = true;
            this.lbNUM_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNUM_TOTAL.Location = new System.Drawing.Point(654, 44);
            this.lbNUM_TOTAL.Name = "lbNUM_TOTAL";
            this.lbNUM_TOTAL.Size = new System.Drawing.Size(94, 13);
            this.lbNUM_TOTAL.TabIndex = 89;
            this.lbNUM_TOTAL.Text = "0 CONTRATOS";
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Image = global::PrendaSAL.Properties.Resources.listar;
            this.btnLISTAR.Location = new System.Drawing.Point(355, 12);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(94, 50);
            this.btnLISTAR.TabIndex = 2;
            this.btnLISTAR.Text = "LISTAR";
            this.btnLISTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO.HeaderText = "# CONTRATO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Width = 300;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            this.ARTICULO.HeaderText = "ARTICULO/PRENDA";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.Width = 300;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // ESTADO_CONTRATO
            // 
            this.ESTADO_CONTRATO.DataPropertyName = "ESTADO_CONTRATO";
            this.ESTADO_CONTRATO.HeaderText = "ESTADO";
            this.ESTADO_CONTRATO.Name = "ESTADO_CONTRATO";
            this.ESTADO_CONTRATO.ReadOnly = true;
            // 
            // RContratosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 432);
            this.Controls.Add(this.lbNUM_TOTAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnLISTAR);
            this.Controls.Add(this.cbxESTADOS);
            this.Controls.Add(this.tblCONTRATOS);
            this.MaximizeBox = false;
            this.Name = "RContratosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "REPORTE DE CONTRATOS";
            this.Load += new System.EventHandler(this.RContratosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCONTRATOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCONTRATOS;
        private System.Windows.Forms.ComboBox cbxESTADOS;
        private System.Windows.Forms.Button btnLISTAR;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNUM_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_CONTRATO;
    }
}