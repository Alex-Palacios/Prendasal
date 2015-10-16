namespace PrendaSAL.Catalogos
{
    partial class ClientesForm
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
            this.tblCLIENTES = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.lbNUM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COD_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LICENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASAPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARNET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOMICILIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblCLIENTES)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCLIENTES
            // 
            this.tblCLIENTES.AllowUserToAddRows = false;
            this.tblCLIENTES.AllowUserToDeleteRows = false;
            this.tblCLIENTES.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCLIENTES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CLIENTE,
            this.CLIENTE,
            this.EDAD,
            this.DUI,
            this.LICENCIA,
            this.PASAPORTE,
            this.CARNET,
            this.TEL,
            this.DOMICILIO});
            this.tblCLIENTES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblCLIENTES.Location = new System.Drawing.Point(0, 28);
            this.tblCLIENTES.Name = "tblCLIENTES";
            this.tblCLIENTES.ReadOnly = true;
            this.tblCLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCLIENTES.Size = new System.Drawing.Size(988, 270);
            this.tblCLIENTES.TabIndex = 0;
            this.tblCLIENTES.DataSourceChanged += new System.EventHandler(this.tblCLIENTES_DataSourceChanged);
            this.tblCLIENTES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCLIENTES_CellClick);
            this.tblCLIENTES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCLIENTES_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripSeparator1,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnSearch,
            this.btnLog,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1103, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.ToolTipText = "Nuevo Cliente";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::PrendaSAL.Properties.Resources.editar;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.ToolTipText = "Editar Informacion Cliente";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::PrendaSAL.Properties.Resources.eliminar;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.ToolTipText = "Eliminar Cliente";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.lbNUM.Location = new System.Drawing.Point(945, 301);
            this.lbNUM.Name = "lbNUM";
            this.lbNUM.Size = new System.Drawing.Size(14, 13);
            this.lbNUM.TabIndex = 7;
            this.lbNUM.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(836, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "COINCIDENCIAS";
            // 
            // COD_CLIENTE
            // 
            this.COD_CLIENTE.DataPropertyName = "COD_CLIENTE";
            this.COD_CLIENTE.HeaderText = "CODIGO";
            this.COD_CLIENTE.Name = "COD_CLIENTE";
            this.COD_CLIENTE.ReadOnly = true;
            this.COD_CLIENTE.Width = 80;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Width = 250;
            // 
            // EDAD
            // 
            this.EDAD.DataPropertyName = "EDAD";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "N/E";
            this.EDAD.DefaultCellStyle = dataGridViewCellStyle1;
            this.EDAD.HeaderText = "EDAD";
            this.EDAD.Name = "EDAD";
            this.EDAD.ReadOnly = true;
            this.EDAD.Width = 50;
            // 
            // DUI
            // 
            this.DUI.DataPropertyName = "DUI";
            this.DUI.HeaderText = "DUI";
            this.DUI.Name = "DUI";
            this.DUI.ReadOnly = true;
            // 
            // LICENCIA
            // 
            this.LICENCIA.DataPropertyName = "LICENCIA";
            this.LICENCIA.HeaderText = "LICENCIA";
            this.LICENCIA.Name = "LICENCIA";
            this.LICENCIA.ReadOnly = true;
            // 
            // PASAPORTE
            // 
            this.PASAPORTE.DataPropertyName = "PASAPORTE";
            this.PASAPORTE.HeaderText = "PASAPORTE";
            this.PASAPORTE.Name = "PASAPORTE";
            this.PASAPORTE.ReadOnly = true;
            this.PASAPORTE.Width = 80;
            // 
            // CARNET
            // 
            this.CARNET.DataPropertyName = "CARNET";
            this.CARNET.HeaderText = "CARNET";
            this.CARNET.Name = "CARNET";
            this.CARNET.ReadOnly = true;
            this.CARNET.Width = 80;
            // 
            // TEL
            // 
            this.TEL.DataPropertyName = "TEL";
            this.TEL.HeaderText = "TEL";
            this.TEL.Name = "TEL";
            this.TEL.ReadOnly = true;
            this.TEL.Width = 80;
            // 
            // DOMICILIO
            // 
            this.DOMICILIO.DataPropertyName = "DOMICILIO";
            this.DOMICILIO.HeaderText = "DOMICILIO";
            this.DOMICILIO.Name = "DOMICILIO";
            this.DOMICILIO.ReadOnly = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNUM);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tblCLIENTES);
            this.MaximizeBox = false;
            this.Name = "ClientesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CARTERA DE CLIENTES";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCLIENTES)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCLIENTES;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Label lbNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LICENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASAPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARNET;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOMICILIO;
    }
}