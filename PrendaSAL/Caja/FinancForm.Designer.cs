namespace PrendaSAL.Caja
{
    partial class FinancForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblFinanc = new System.Windows.Forms.DataGridView();
            this.btnRecibir = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENVIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRASLADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIBIDO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RECIBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFinanc)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecibir,
            this.toolStripSeparator1,
            this.btnLog,
            this.btnAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(904, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTOTAL.Location = new System.Drawing.Point(766, 328);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(77, 23);
            this.lbTOTAL.TabIndex = 120;
            this.lbTOTAL.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(633, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 119;
            this.label4.Text = "T O T A L";
            // 
            // tblFinanc
            // 
            this.tblFinanc.AllowUserToAddRows = false;
            this.tblFinanc.AllowUserToDeleteRows = false;
            this.tblFinanc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblFinanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFinanc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM,
            this.FECHA,
            this.DOCUMENTO,
            this.ENVIA,
            this.TRASLADA,
            this.TOTAL,
            this.RECIBIDO,
            this.RECIBE,
            this.NOTA});
            this.tblFinanc.Location = new System.Drawing.Point(4, 26);
            this.tblFinanc.Name = "tblFinanc";
            this.tblFinanc.ReadOnly = true;
            this.tblFinanc.RowHeadersVisible = false;
            this.tblFinanc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFinanc.Size = new System.Drawing.Size(900, 295);
            this.tblFinanc.TabIndex = 118;
            this.tblFinanc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblFinanc_CellFormatting);
            this.tblFinanc.SelectionChanged += new System.EventHandler(this.tblFinanc_SelectionChanged);
            // 
            // btnRecibir
            // 
            this.btnRecibir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRecibir.Image = global::PrendaSAL.Properties.Resources.candado;
            this.btnRecibir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(23, 22);
            this.btnRecibir.ToolTipText = "Nueva";
            this.btnRecibir.Click += new System.EventHandler(this.RECIBIR);
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
            // NUM
            // 
            this.NUM.HeaderText = "#";
            this.NUM.Name = "NUM";
            this.NUM.ReadOnly = true;
            this.NUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NUM.Width = 30;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO.HeaderText = "TICKET";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ENVIA
            // 
            this.ENVIA.DataPropertyName = "ENVIA";
            this.ENVIA.HeaderText = "ENVIA";
            this.ENVIA.Name = "ENVIA";
            this.ENVIA.ReadOnly = true;
            this.ENVIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ENVIA.Width = 150;
            // 
            // TRASLADA
            // 
            this.TRASLADA.DataPropertyName = "TRASLADA";
            this.TRASLADA.HeaderText = "TRASLADA";
            this.TRASLADA.Name = "TRASLADA";
            this.TRASLADA.ReadOnly = true;
            this.TRASLADA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TRASLADA.Width = 175;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RECIBIDO
            // 
            this.RECIBIDO.DataPropertyName = "RECIBIDO";
            this.RECIBIDO.HeaderText = "RECIBIDO";
            this.RECIBIDO.Name = "RECIBIDO";
            this.RECIBIDO.ReadOnly = true;
            // 
            // RECIBE
            // 
            this.RECIBE.DataPropertyName = "RECIBE";
            this.RECIBE.HeaderText = "RECIBIDO POR";
            this.RECIBE.Name = "RECIBE";
            this.RECIBE.ReadOnly = true;
            this.RECIBE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RECIBE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RECIBE.Width = 150;
            // 
            // NOTA
            // 
            this.NOTA.DataPropertyName = "NOTA";
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.ReadOnly = true;
            this.NOTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FinancForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 361);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblFinanc);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "FinancForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "F I N A N C I A M I E N T O S";
            this.Load += new System.EventHandler(this.FinancForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFinanc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRecibir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tblFinanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENVIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRASLADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RECIBIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
    }
}