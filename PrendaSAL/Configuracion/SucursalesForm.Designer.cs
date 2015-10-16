namespace PrendaSAL.Configuracion
{
    partial class SucursalesForm
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
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.tblSUCURSALES = new System.Windows.Forms.DataGridView();
            this.COD_SUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_SISTEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUCURSALES)).BeginInit();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(1060, 25);
            this.opciones.TabIndex = 3;
            this.opciones.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::PrendaSAL.Properties.Resources.agreagarSucursal;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.ToolTipText = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.AGREGAR);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.editarSuc;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::PrendaSAL.Properties.Resources.eliminarSucursal;
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
            // btnAyuda
            // 
            this.btnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAyuda.Image = global::PrendaSAL.Properties.Resources.help;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(23, 22);
            this.btnAyuda.ToolTipText = "Ayuda";
            // 
            // tblSUCURSALES
            // 
            this.tblSUCURSALES.AllowUserToAddRows = false;
            this.tblSUCURSALES.AllowUserToDeleteRows = false;
            this.tblSUCURSALES.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblSUCURSALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSUCURSALES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_SUC,
            this.SUCURSAL,
            this.TEL,
            this.MUNICIPIO,
            this.DIRECCION,
            this.ACTIVA,
            this.IP,
            this.HOSTNAME,
            this.FECHA_SISTEMA});
            this.tblSUCURSALES.Location = new System.Drawing.Point(0, 28);
            this.tblSUCURSALES.Name = "tblSUCURSALES";
            this.tblSUCURSALES.ReadOnly = true;
            this.tblSUCURSALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSUCURSALES.Size = new System.Drawing.Size(1032, 340);
            this.tblSUCURSALES.TabIndex = 4;
            this.tblSUCURSALES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSUCURSALES_CellClick);
            this.tblSUCURSALES.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblSUCURSALES_CellFormatting);
            // 
            // COD_SUC
            // 
            this.COD_SUC.DataPropertyName = "COD_SUC";
            this.COD_SUC.HeaderText = "CODIGO";
            this.COD_SUC.Name = "COD_SUC";
            this.COD_SUC.ReadOnly = true;
            this.COD_SUC.Width = 60;
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.DataPropertyName = "SUCURSAL";
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.ReadOnly = true;
            this.SUCURSAL.Width = 250;
            // 
            // TEL
            // 
            this.TEL.DataPropertyName = "TEL";
            this.TEL.HeaderText = "TELEFONO";
            this.TEL.Name = "TEL";
            this.TEL.ReadOnly = true;
            this.TEL.Width = 80;
            // 
            // MUNICIPIO
            // 
            this.MUNICIPIO.DataPropertyName = "MUNICIPIO";
            this.MUNICIPIO.HeaderText = "MUNICIPIO";
            this.MUNICIPIO.Name = "MUNICIPIO";
            this.MUNICIPIO.ReadOnly = true;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "DIRECCION";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Width = 150;
            // 
            // ACTIVA
            // 
            this.ACTIVA.DataPropertyName = "ACTIVA";
            this.ACTIVA.HeaderText = "A";
            this.ACTIVA.Name = "ACTIVA";
            this.ACTIVA.ReadOnly = true;
            this.ACTIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTIVA.Width = 35;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // HOSTNAME
            // 
            this.HOSTNAME.DataPropertyName = "HOSTNAME";
            this.HOSTNAME.HeaderText = "HOSTNAME";
            this.HOSTNAME.Name = "HOSTNAME";
            this.HOSTNAME.ReadOnly = true;
            // 
            // FECHA_SISTEMA
            // 
            this.FECHA_SISTEMA.DataPropertyName = "FECHA_SISTEMA";
            this.FECHA_SISTEMA.HeaderText = "FECHA SISTEMA";
            this.FECHA_SISTEMA.Name = "FECHA_SISTEMA";
            this.FECHA_SISTEMA.ReadOnly = true;
            // 
            // SucursalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 381);
            this.Controls.Add(this.tblSUCURSALES);
            this.Controls.Add(this.opciones);
            this.MaximizeBox = false;
            this.Name = "SucursalesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SUCURSALES PRENDASAL";
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUCURSALES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.DataGridView tblSUCURSALES;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACTIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SISTEMA;
    }
}