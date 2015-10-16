namespace PrendaSAL.Configuracion
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.tblUSUARIOS = new System.Windows.Forms.DataGridView();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RESET = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.ACTIVE = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewButtonXColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(840, 25);
            this.opciones.TabIndex = 2;
            this.opciones.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::PrendaSAL.Properties.Resources.agregarUSER;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.ToolTipText = "Nuevo";
            this.btnAgregar.Click += new System.EventHandler(this.AGREGAR);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::PrendaSAL.Properties.Resources.eliminaruser;
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
            // tblUSUARIOS
            // 
            this.tblUSUARIOS.AllowUserToAddRows = false;
            this.tblUSUARIOS.AllowUserToDeleteRows = false;
            this.tblUSUARIOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUSUARIOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME,
            this.EMPLEADO,
            this.TIPO_USER,
            this.ACTIVO,
            this.RESET,
            this.ACTIVE});
            this.tblUSUARIOS.Location = new System.Drawing.Point(12, 41);
            this.tblUSUARIOS.Name = "tblUSUARIOS";
            this.tblUSUARIOS.ReadOnly = true;
            this.tblUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblUSUARIOS.Size = new System.Drawing.Size(812, 317);
            this.tblUSUARIOS.TabIndex = 3;
            this.tblUSUARIOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUSUARIOS_CellClick);
            this.tblUSUARIOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUSUARIOS_CellContentClick);
            this.tblUSUARIOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblUSUARIOS_CellFormatting);
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "COD_EMPLEADO";
            this.USERNAME.HeaderText = "USUARIO";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.DataPropertyName = "NOMBRE";
            this.EMPLEADO.HeaderText = "EMPLEADO";
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.ReadOnly = true;
            this.EMPLEADO.Width = 250;
            // 
            // TIPO_USER
            // 
            this.TIPO_USER.DataPropertyName = "TIPO_USER";
            this.TIPO_USER.HeaderText = "TIPO USUARIO";
            this.TIPO_USER.Name = "TIPO_USER";
            this.TIPO_USER.ReadOnly = true;
            this.TIPO_USER.Width = 150;
            // 
            // ACTIVO
            // 
            this.ACTIVO.DataPropertyName = "ACTIVO";
            this.ACTIVO.HeaderText = "ACTIVO";
            this.ACTIVO.Name = "ACTIVO";
            this.ACTIVO.ReadOnly = true;
            this.ACTIVO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTIVO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RESET
            // 
            this.RESET.HeaderText = "";
            this.RESET.Image = ((System.Drawing.Image)(resources.GetObject("RESET.Image")));
            this.RESET.Name = "RESET";
            this.RESET.ReadOnly = true;
            this.RESET.Text = null;
            this.RESET.Width = 25;
            // 
            // ACTIVE
            // 
            this.ACTIVE.HeaderText = "";
            this.ACTIVE.Image = ((System.Drawing.Image)(resources.GetObject("ACTIVE.Image")));
            this.ACTIVE.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ACTIVE.Name = "ACTIVE";
            this.ACTIVE.ReadOnly = true;
            this.ACTIVE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTIVE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTIVE.Text = null;
            this.ACTIVE.Width = 25;
            // 
            // dataGridViewButtonXColumn1
            // 
            this.dataGridViewButtonXColumn1.HeaderText = "";
            this.dataGridViewButtonXColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonXColumn1.Image")));
            this.dataGridViewButtonXColumn1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.dataGridViewButtonXColumn1.Name = "dataGridViewButtonXColumn1";
            this.dataGridViewButtonXColumn1.ReadOnly = true;
            this.dataGridViewButtonXColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonXColumn1.Text = null;
            this.dataGridViewButtonXColumn1.Width = 25;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 370);
            this.Controls.Add(this.tblUSUARIOS);
            this.Controls.Add(this.opciones);
            this.MaximizeBox = false;
            this.Name = "UsuariosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "USUARIOS";
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private System.Windows.Forms.DataGridView tblUSUARIOS;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_USER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACTIVO;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn RESET;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn ACTIVE;
    }
}