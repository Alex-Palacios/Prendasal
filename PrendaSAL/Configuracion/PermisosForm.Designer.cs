namespace PrendaSAL.Configuracion
{
    partial class PermisosForm
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
            this.cbxTIPOUSER = new System.Windows.Forms.ComboBox();
            this.tblPERMISOS = new System.Windows.Forms.DataGridView();
            this.TIPO_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCESO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.REGISTRAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ACTUALIZAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CLAVE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ANULAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BUSCAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LOG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.REIMPRIMIR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CONFIG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnObtenerPermisos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPERMISOS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTIPOUSER
            // 
            this.cbxTIPOUSER.FormattingEnabled = true;
            this.cbxTIPOUSER.Location = new System.Drawing.Point(12, 38);
            this.cbxTIPOUSER.Name = "cbxTIPOUSER";
            this.cbxTIPOUSER.Size = new System.Drawing.Size(205, 21);
            this.cbxTIPOUSER.TabIndex = 0;
            // 
            // tblPERMISOS
            // 
            this.tblPERMISOS.AllowUserToAddRows = false;
            this.tblPERMISOS.AllowUserToDeleteRows = false;
            this.tblPERMISOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblPERMISOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPERMISOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO_USER,
            this.MODULO,
            this.MENU,
            this.ACCESO,
            this.REGISTRAR,
            this.ACTUALIZAR,
            this.ELIMINAR,
            this.CLAVE,
            this.ANULAR,
            this.BUSCAR,
            this.LOG,
            this.REIMPRIMIR,
            this.CONFIG});
            this.tblPERMISOS.Location = new System.Drawing.Point(12, 75);
            this.tblPERMISOS.Name = "tblPERMISOS";
            this.tblPERMISOS.ReadOnly = true;
            this.tblPERMISOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPERMISOS.Size = new System.Drawing.Size(816, 346);
            this.tblPERMISOS.TabIndex = 1;
            this.tblPERMISOS.DataSourceChanged += new System.EventHandler(this.tblPERMISOS_DataSourceChanged);
            this.tblPERMISOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblPERMISOS_CellFormatting);
            // 
            // TIPO_USER
            // 
            this.TIPO_USER.DataPropertyName = "TIPO_USER";
            this.TIPO_USER.HeaderText = "TIPO USUARIO";
            this.TIPO_USER.Name = "TIPO_USER";
            this.TIPO_USER.ReadOnly = true;
            this.TIPO_USER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIPO_USER.Width = 150;
            // 
            // MODULO
            // 
            this.MODULO.DataPropertyName = "MODULO";
            this.MODULO.HeaderText = "MODULO";
            this.MODULO.Name = "MODULO";
            this.MODULO.ReadOnly = true;
            this.MODULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MODULO.Width = 150;
            // 
            // MENU
            // 
            this.MENU.DataPropertyName = "MENU";
            this.MENU.HeaderText = "MENU";
            this.MENU.Name = "MENU";
            this.MENU.ReadOnly = true;
            this.MENU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MENU.Width = 200;
            // 
            // ACCESO
            // 
            this.ACCESO.DataPropertyName = "ACCESO";
            this.ACCESO.HeaderText = "A";
            this.ACCESO.Name = "ACCESO";
            this.ACCESO.ReadOnly = true;
            this.ACCESO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACCESO.Width = 25;
            // 
            // REGISTRAR
            // 
            this.REGISTRAR.DataPropertyName = "REGISTRAR";
            this.REGISTRAR.HeaderText = "R";
            this.REGISTRAR.Name = "REGISTRAR";
            this.REGISTRAR.ReadOnly = true;
            this.REGISTRAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REGISTRAR.Width = 25;
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.DataPropertyName = "ACTUALIZAR";
            this.ACTUALIZAR.HeaderText = "A";
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.ReadOnly = true;
            this.ACTUALIZAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTUALIZAR.Width = 25;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.DataPropertyName = "ELIMINAR";
            this.ELIMINAR.HeaderText = "E";
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ELIMINAR.Width = 25;
            // 
            // CLAVE
            // 
            this.CLAVE.DataPropertyName = "CLAVE";
            this.CLAVE.HeaderText = "K";
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.ReadOnly = true;
            this.CLAVE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CLAVE.Width = 25;
            // 
            // ANULAR
            // 
            this.ANULAR.DataPropertyName = "ANULAR";
            this.ANULAR.HeaderText = "A";
            this.ANULAR.Name = "ANULAR";
            this.ANULAR.ReadOnly = true;
            this.ANULAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ANULAR.Width = 25;
            // 
            // BUSCAR
            // 
            this.BUSCAR.DataPropertyName = "BUSCAR";
            this.BUSCAR.HeaderText = "B";
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.ReadOnly = true;
            this.BUSCAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BUSCAR.Width = 25;
            // 
            // LOG
            // 
            this.LOG.DataPropertyName = "LOG";
            this.LOG.HeaderText = "L";
            this.LOG.Name = "LOG";
            this.LOG.ReadOnly = true;
            this.LOG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LOG.Width = 25;
            // 
            // REIMPRIMIR
            // 
            this.REIMPRIMIR.DataPropertyName = "REIMPRIMIR";
            this.REIMPRIMIR.HeaderText = "I";
            this.REIMPRIMIR.Name = "REIMPRIMIR";
            this.REIMPRIMIR.ReadOnly = true;
            this.REIMPRIMIR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REIMPRIMIR.Width = 25;
            // 
            // CONFIG
            // 
            this.CONFIG.DataPropertyName = "CONFIG";
            this.CONFIG.HeaderText = "C";
            this.CONFIG.Name = "CONFIG";
            this.CONFIG.ReadOnly = true;
            this.CONFIG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CONFIG.Width = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIPO DE USUARIO";
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::PrendaSAL.Properties.Resources.apertura;
            this.btnEditar.Location = new System.Drawing.Point(846, 75);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 42);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnObtenerPermisos
            // 
            this.btnObtenerPermisos.BackgroundImage = global::PrendaSAL.Properties.Resources.permisos1;
            this.btnObtenerPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObtenerPermisos.Location = new System.Drawing.Point(240, 12);
            this.btnObtenerPermisos.Name = "btnObtenerPermisos";
            this.btnObtenerPermisos.Size = new System.Drawing.Size(89, 55);
            this.btnObtenerPermisos.TabIndex = 24;
            this.btnObtenerPermisos.UseVisualStyleBackColor = true;
            this.btnObtenerPermisos.Click += new System.EventHandler(this.btnObtenerPermisos_Click);
            // 
            // PermisosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 433);
            this.Controls.Add(this.btnObtenerPermisos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblPERMISOS);
            this.Controls.Add(this.cbxTIPOUSER);
            this.MaximizeBox = false;
            this.Name = "PermisosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PERMISOS";
            this.Load += new System.EventHandler(this.PermisosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPERMISOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTIPOUSER;
        private System.Windows.Forms.DataGridView tblPERMISOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENU;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACCESO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REGISTRAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACTUALIZAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ELIMINAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ANULAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BUSCAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LOG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REIMPRIMIR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CONFIG;
        private System.Windows.Forms.Button btnObtenerPermisos;
    }
}