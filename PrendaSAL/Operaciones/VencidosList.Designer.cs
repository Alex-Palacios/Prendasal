namespace PrendaSAL.Operaciones
{
    partial class VencidosList
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
            this.tblLISTAS = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.lbNUM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_APERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONSABLE_APERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENCIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REACTIVADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONSABLE_CIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_LISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblLISTAS)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLISTAS
            // 
            this.tblLISTAS.AllowUserToAddRows = false;
            this.tblLISTAS.AllowUserToDeleteRows = false;
            this.tblLISTAS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblLISTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLISTAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUCURSAL,
            this.FECHA_APERTURA,
            this.DOCUMENTO,
            this.RESPONSABLE_APERTURA,
            this.VENCIDOS,
            this.REACTIVADOS,
            this.FECHA_CIERRE,
            this.RESPONSABLE_CIERRE,
            this.ESTADO_LISTA});
            this.tblLISTAS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblLISTAS.Location = new System.Drawing.Point(0, 28);
            this.tblLISTAS.MultiSelect = false;
            this.tblLISTAS.Name = "tblLISTAS";
            this.tblLISTAS.ReadOnly = true;
            this.tblLISTAS.RowHeadersVisible = false;
            this.tblLISTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLISTAS.Size = new System.Drawing.Size(791, 270);
            this.tblLISTAS.TabIndex = 0;
            this.tblLISTAS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCLIENTES_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnLog,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::PrendaSAL.Properties.Resources.buscar_icon2;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.ToolTipText = "Buscar o Filtrar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLog
            // 
            this.btnLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLog.Image = global::PrendaSAL.Properties.Resources.log;
            this.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(23, 22);
            this.btnLog.ToolTipText = "Ver Log de Transacciones";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::PrendaSAL.Properties.Resources.help;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.ToolTipText = "Mostrar Ayuda";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbNUM
            // 
            this.lbNUM.AutoSize = true;
            this.lbNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNUM.Location = new System.Drawing.Point(711, 307);
            this.lbNUM.Name = "lbNUM";
            this.lbNUM.Size = new System.Drawing.Size(14, 13);
            this.lbNUM.TabIndex = 7;
            this.lbNUM.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "COINCIDENCIAS";
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.DataPropertyName = "COD_SUC";
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.ReadOnly = true;
            this.SUCURSAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SUCURSAL.Width = 80;
            // 
            // FECHA_APERTURA
            // 
            this.FECHA_APERTURA.DataPropertyName = "FECHA_APERTURA";
            this.FECHA_APERTURA.HeaderText = "APERTURA";
            this.FECHA_APERTURA.Name = "FECHA_APERTURA";
            this.FECHA_APERTURA.ReadOnly = true;
            this.FECHA_APERTURA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_APERTURA.Width = 80;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            dataGridViewCellStyle2.NullValue = "N/E";
            this.DOCUMENTO.DefaultCellStyle = dataGridViewCellStyle2;
            this.DOCUMENTO.HeaderText = "DOCUMENTO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DOCUMENTO.Width = 80;
            // 
            // RESPONSABLE_APERTURA
            // 
            this.RESPONSABLE_APERTURA.DataPropertyName = "RESPONSABLE_APERTURA";
            this.RESPONSABLE_APERTURA.HeaderText = "RESPONSABLE";
            this.RESPONSABLE_APERTURA.Name = "RESPONSABLE_APERTURA";
            this.RESPONSABLE_APERTURA.ReadOnly = true;
            this.RESPONSABLE_APERTURA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VENCIDOS
            // 
            this.VENCIDOS.DataPropertyName = "VENCIDOS";
            this.VENCIDOS.HeaderText = "VENCIDOS";
            this.VENCIDOS.Name = "VENCIDOS";
            this.VENCIDOS.ReadOnly = true;
            this.VENCIDOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VENCIDOS.Width = 80;
            // 
            // REACTIVADOS
            // 
            this.REACTIVADOS.DataPropertyName = "REACTIVADOS";
            this.REACTIVADOS.HeaderText = "REACTIVADOS";
            this.REACTIVADOS.Name = "REACTIVADOS";
            this.REACTIVADOS.ReadOnly = true;
            this.REACTIVADOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.REACTIVADOS.Width = 85;
            // 
            // FECHA_CIERRE
            // 
            this.FECHA_CIERRE.DataPropertyName = "FECHA_CIERRE";
            this.FECHA_CIERRE.HeaderText = "CIERRE";
            this.FECHA_CIERRE.Name = "FECHA_CIERRE";
            this.FECHA_CIERRE.ReadOnly = true;
            this.FECHA_CIERRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_CIERRE.Width = 80;
            // 
            // RESPONSABLE_CIERRE
            // 
            this.RESPONSABLE_CIERRE.DataPropertyName = "RESPONSABLE_CIERRE";
            this.RESPONSABLE_CIERRE.HeaderText = "RESPONSABLE";
            this.RESPONSABLE_CIERRE.Name = "RESPONSABLE_CIERRE";
            this.RESPONSABLE_CIERRE.ReadOnly = true;
            this.RESPONSABLE_CIERRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ESTADO_LISTA
            // 
            this.ESTADO_LISTA.DataPropertyName = "ESTADO_LISTA";
            this.ESTADO_LISTA.HeaderText = "ESTADO";
            this.ESTADO_LISTA.Name = "ESTADO_LISTA";
            this.ESTADO_LISTA.ReadOnly = true;
            this.ESTADO_LISTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VencidosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNUM);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tblLISTAS);
            this.MaximizeBox = false;
            this.Name = "VencidosList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LISTAS DE VENCIDOS";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLISTAS)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblLISTAS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Label lbNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_APERTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE_APERTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENCIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REACTIVADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CIERRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE_CIERRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_LISTA;
    }
}