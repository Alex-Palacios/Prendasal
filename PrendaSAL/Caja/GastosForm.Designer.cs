namespace PrendaSAL.Caja
{
    partial class GastosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.tblGASTOS = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGASTOS)).BeginInit();
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
            this.btnLog,
            this.btnAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 4;
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
            // tblGASTOS
            // 
            this.tblGASTOS.AllowUserToAddRows = false;
            this.tblGASTOS.AllowUserToDeleteRows = false;
            this.tblGASTOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblGASTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGASTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.RESPONSABLE,
            this.DOCUMENTO,
            this.DESCRIPCION,
            this.TOTAL,
            this.NOTA});
            this.tblGASTOS.Location = new System.Drawing.Point(0, 28);
            this.tblGASTOS.Name = "tblGASTOS";
            this.tblGASTOS.ReadOnly = true;
            this.tblGASTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblGASTOS.Size = new System.Drawing.Size(872, 357);
            this.tblGASTOS.TabIndex = 5;
            this.tblGASTOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblGASTOS_CellFormatting);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(648, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 112;
            this.label4.Text = "T O T A L";
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTOTAL.Location = new System.Drawing.Point(795, 391);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(77, 23);
            this.lbTOTAL.TabIndex = 113;
            this.lbTOTAL.Text = "$0.00";
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
            // RESPONSABLE
            // 
            this.RESPONSABLE.DataPropertyName = "RESPONSABLE";
            this.RESPONSABLE.HeaderText = "RESPONSABLE";
            this.RESPONSABLE.Name = "RESPONSABLE";
            this.RESPONSABLE.ReadOnly = true;
            this.RESPONSABLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RESPONSABLE.Width = 125;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO.HeaderText = "DOCUMENTO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            dataGridViewCellStyle4.Format = "c2";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NOTA
            // 
            this.NOTA.DataPropertyName = "NOTA";
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.ReadOnly = true;
            this.NOTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GastosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 423);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblGASTOS);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "GastosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "G A S T O S";
            this.Load += new System.EventHandler(this.GastosForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGASTOS)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.DataGridView tblGASTOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
    }
}