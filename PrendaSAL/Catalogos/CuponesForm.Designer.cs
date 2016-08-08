namespace PrendaSAL.Catalogos
{
    partial class CuponesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblCUPONES = new System.Windows.Forms.DataGridView();
            this.ID_CUPON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_EXP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC_INTERES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRptCanjes = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblCUPONES)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCUPONES
            // 
            this.tblCUPONES.AllowUserToAddRows = false;
            this.tblCUPONES.AllowUserToDeleteRows = false;
            this.tblCUPONES.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCUPONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCUPONES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CUPON,
            this.FECHA_EXP,
            this.TIPO,
            this.DESDE,
            this.HASTA,
            this.FECHA_VENC,
            this.DESC_INTERES,
            this.DESC_VENTA,
            this.ACTIVA});
            this.tblCUPONES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblCUPONES.Location = new System.Drawing.Point(12, 31);
            this.tblCUPONES.Name = "tblCUPONES";
            this.tblCUPONES.ReadOnly = true;
            this.tblCUPONES.RowHeadersVisible = false;
            this.tblCUPONES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCUPONES.Size = new System.Drawing.Size(633, 251);
            this.tblCUPONES.TabIndex = 1;
            // 
            // ID_CUPON
            // 
            this.ID_CUPON.DataPropertyName = "ID_CUPON";
            this.ID_CUPON.HeaderText = "ID";
            this.ID_CUPON.Name = "ID_CUPON";
            this.ID_CUPON.ReadOnly = true;
            this.ID_CUPON.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_CUPON.Width = 30;
            // 
            // FECHA_EXP
            // 
            this.FECHA_EXP.DataPropertyName = "FECHA_EXP";
            dataGridViewCellStyle1.Format = "d";
            this.FECHA_EXP.DefaultCellStyle = dataGridViewCellStyle1;
            this.FECHA_EXP.HeaderText = "FECHA EXP";
            this.FECHA_EXP.Name = "FECHA_EXP";
            this.FECHA_EXP.ReadOnly = true;
            this.FECHA_EXP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_EXP.Width = 80;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIPO.Width = 80;
            // 
            // DESDE
            // 
            this.DESDE.DataPropertyName = "DESDE";
            this.DESDE.HeaderText = "DESDE";
            this.DESDE.Name = "DESDE";
            this.DESDE.ReadOnly = true;
            this.DESDE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESDE.Width = 60;
            // 
            // HASTA
            // 
            this.HASTA.DataPropertyName = "HASTA";
            this.HASTA.HeaderText = "HASTA";
            this.HASTA.Name = "HASTA";
            this.HASTA.ReadOnly = true;
            this.HASTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HASTA.Width = 60;
            // 
            // FECHA_VENC
            // 
            this.FECHA_VENC.DataPropertyName = "FECHA_VENC";
            dataGridViewCellStyle2.Format = "d";
            this.FECHA_VENC.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA_VENC.HeaderText = "FECHA VENC";
            this.FECHA_VENC.Name = "FECHA_VENC";
            this.FECHA_VENC.ReadOnly = true;
            this.FECHA_VENC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FECHA_VENC.Width = 80;
            // 
            // DESC_INTERES
            // 
            this.DESC_INTERES.DataPropertyName = "DESC_INTERES";
            dataGridViewCellStyle3.Format = "N2";
            this.DESC_INTERES.DefaultCellStyle = dataGridViewCellStyle3;
            this.DESC_INTERES.HeaderText = "% DESC. INTERES";
            this.DESC_INTERES.Name = "DESC_INTERES";
            this.DESC_INTERES.ReadOnly = true;
            this.DESC_INTERES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESC_INTERES.Width = 80;
            // 
            // DESC_VENTA
            // 
            this.DESC_VENTA.DataPropertyName = "DESC_VENTA";
            dataGridViewCellStyle4.Format = "N2";
            this.DESC_VENTA.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESC_VENTA.HeaderText = "% DESC. VENTA";
            this.DESC_VENTA.Name = "DESC_VENTA";
            this.DESC_VENTA.ReadOnly = true;
            this.DESC_VENTA.Width = 80;
            // 
            // ACTIVA
            // 
            this.ACTIVA.DataPropertyName = "ACTIVA";
            this.ACTIVA.HeaderText = "A";
            this.ACTIVA.Name = "ACTIVA";
            this.ACTIVA.ReadOnly = true;
            this.ACTIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTIVA.Width = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(836, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRptCanjes
            // 
            this.btnRptCanjes.Image = global::PrendaSAL.Properties.Resources.canjeo;
            this.btnRptCanjes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptCanjes.Location = new System.Drawing.Point(665, 100);
            this.btnRptCanjes.Name = "btnRptCanjes";
            this.btnRptCanjes.Size = new System.Drawing.Size(128, 41);
            this.btnRptCanjes.TabIndex = 8;
            this.btnRptCanjes.Text = "REPORTE DE CANJES";
            this.btnRptCanjes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRptCanjes.UseVisualStyleBackColor = true;
            this.btnRptCanjes.Click += new System.EventHandler(this.btnRptCanjes_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.ToolTipText = "Nuevo Cliente";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.ToolTipText = "Editar Informacion Cliente";
            this.btnEditar.Click += new System.EventHandler(this.EDITAR);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::PrendaSAL.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.ToolTipText = "Eliminar Cliente";
            this.btnEliminar.Click += new System.EventHandler(this.ELIMINAR);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::PrendaSAL.Properties.Resources.help;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.ToolTipText = "Mostrar Ayuda";
            // 
            // CuponesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 297);
            this.Controls.Add(this.btnRptCanjes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tblCUPONES);
            this.MaximizeBox = false;
            this.Name = "CuponesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cupones de Descuentos";
            this.Load += new System.EventHandler(this.CuponesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCUPONES)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCUPONES;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Button btnRptCanjes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CUPON;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_EXP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_VENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_INTERES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_VENTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACTIVA;
    }
}