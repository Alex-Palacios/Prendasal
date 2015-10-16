namespace PrendaSAL.Caja
{
    partial class RemesasForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.tblRemesas = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETIRADO_POR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewerCOMPROBANTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRemesas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnEditar,
            this.btnAnular,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnReimprimir,
            this.btnLog,
            this.btnAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.ToolTipText = "Nueva";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.EDITAR);
            // 
            // btnAnular
            // 
            this.btnAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnular.Image = global::PrendaSAL.Properties.Resources.anular2;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(23, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::PrendaSAL.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.ELIMINAR);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReimprimir.Image = global::PrendaSAL.Properties.Resources.printer;
            this.btnReimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(23, 22);
            this.btnReimprimir.ToolTipText = "Imprimir";
            this.btnReimprimir.Click += new System.EventHandler(this.IMPRIMIR);
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
            // tblRemesas
            // 
            this.tblRemesas.AllowUserToAddRows = false;
            this.tblRemesas.AllowUserToDeleteRows = false;
            this.tblRemesas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblRemesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRemesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.TIPO_MOV,
            this.TIPO_DOC,
            this.DOCUMENTO,
            this.TOTAL,
            this.DESTINO,
            this.RESPONSABLE,
            this.RETIRADO_POR});
            this.tblRemesas.Location = new System.Drawing.Point(0, 28);
            this.tblRemesas.Name = "tblRemesas";
            this.tblRemesas.ReadOnly = true;
            this.tblRemesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRemesas.Size = new System.Drawing.Size(854, 357);
            this.tblRemesas.TabIndex = 4;
            this.tblRemesas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblRemesas_CellFormatting);
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle1;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO_MOV
            // 
            this.TIPO_MOV.DataPropertyName = "TIPO_MOV";
            this.TIPO_MOV.HeaderText = "TIPO MOV";
            this.TIPO_MOV.Name = "TIPO_MOV";
            this.TIPO_MOV.ReadOnly = true;
            this.TIPO_MOV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIPO_DOC
            // 
            this.TIPO_DOC.DataPropertyName = "TIPO_DOC";
            this.TIPO_DOC.HeaderText = "TIPO DOC";
            this.TIPO_DOC.Name = "TIPO_DOC";
            this.TIPO_DOC.ReadOnly = true;
            this.TIPO_DOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO.HeaderText = "DOCUMENTO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESTINO
            // 
            this.DESTINO.DataPropertyName = "SUCURSAL_DESTINO";
            this.DESTINO.HeaderText = "DESTINO";
            this.DESTINO.Name = "DESTINO";
            this.DESTINO.ReadOnly = true;
            this.DESTINO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RESPONSABLE
            // 
            this.RESPONSABLE.DataPropertyName = "RESPONSABLE";
            this.RESPONSABLE.HeaderText = "RESPONSABLE";
            this.RESPONSABLE.Name = "RESPONSABLE";
            this.RESPONSABLE.ReadOnly = true;
            this.RESPONSABLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RETIRADO_POR
            // 
            this.RETIRADO_POR.DataPropertyName = "RECIBE";
            this.RETIRADO_POR.HeaderText = "RETIRADO POR";
            this.RETIRADO_POR.Name = "RETIRADO_POR";
            this.RETIRADO_POR.ReadOnly = true;
            this.RETIRADO_POR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // viewerCOMPROBANTE
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerCOMPROBANTE.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerCOMPROBANTE.LocalReport.ReportEmbeddedResource = "";
            this.viewerCOMPROBANTE.Location = new System.Drawing.Point(547, 0);
            this.viewerCOMPROBANTE.Name = "viewerCOMPROBANTE";
            this.viewerCOMPROBANTE.Size = new System.Drawing.Size(170, 25);
            this.viewerCOMPROBANTE.TabIndex = 93;
            this.viewerCOMPROBANTE.Visible = false;
            this.viewerCOMPROBANTE.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.ShowPrintDialog);
            // 
            // RemesasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 386);
            this.Controls.Add(this.viewerCOMPROBANTE);
            this.Controls.Add(this.tblRemesas);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "RemesasForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "R E M E S A S";
            this.Load += new System.EventHandler(this.RemesasForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRemesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.DataGridView tblRemesas;
        private Microsoft.Reporting.WinForms.ReportViewer viewerCOMPROBANTE;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETIRADO_POR;

    }
}