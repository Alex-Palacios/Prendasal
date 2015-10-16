namespace PrendaSAL.Operaciones
{
    partial class EnviarInvForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlEnvio = new System.Windows.Forms.TabControl();
            this.pagCustodia = new System.Windows.Forms.TabPage();
            this.lbSeleccionadosCustodia = new System.Windows.Forms.Label();
            this.txtCodigoCustodia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviarCustodia = new System.Windows.Forms.Button();
            this.tblCustodia = new System.Windows.Forms.DataGridView();
            this.pagRemision = new System.Windows.Forms.TabPage();
            this.tblInventario = new System.Windows.Forms.DataGridView();
            this.CHECK_RM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_MOV_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSeleccionadosRemision = new System.Windows.Forms.Label();
            this.txtCodigoInv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviarRemision = new System.Windows.Forms.Button();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlEnvio.SuspendLayout();
            this.pagCustodia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustodia)).BeginInit();
            this.pagRemision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEnvio
            // 
            this.tabControlEnvio.Controls.Add(this.pagCustodia);
            this.tabControlEnvio.Controls.Add(this.pagRemision);
            this.tabControlEnvio.Location = new System.Drawing.Point(-2, 12);
            this.tabControlEnvio.Name = "tabControlEnvio";
            this.tabControlEnvio.SelectedIndex = 0;
            this.tabControlEnvio.Size = new System.Drawing.Size(994, 469);
            this.tabControlEnvio.TabIndex = 0;
            this.tabControlEnvio.SelectedIndexChanged += new System.EventHandler(this.tabControlEnvio_SelectedIndexChanged);
            // 
            // pagCustodia
            // 
            this.pagCustodia.Controls.Add(this.lbSeleccionadosCustodia);
            this.pagCustodia.Controls.Add(this.txtCodigoCustodia);
            this.pagCustodia.Controls.Add(this.label1);
            this.pagCustodia.Controls.Add(this.btnEnviarCustodia);
            this.pagCustodia.Controls.Add(this.tblCustodia);
            this.pagCustodia.Location = new System.Drawing.Point(4, 22);
            this.pagCustodia.Name = "pagCustodia";
            this.pagCustodia.Padding = new System.Windows.Forms.Padding(3);
            this.pagCustodia.Size = new System.Drawing.Size(986, 443);
            this.pagCustodia.TabIndex = 0;
            this.pagCustodia.Text = "CUSTODIA DE VALORES";
            this.pagCustodia.UseVisualStyleBackColor = true;
            // 
            // lbSeleccionadosCustodia
            // 
            this.lbSeleccionadosCustodia.AutoSize = true;
            this.lbSeleccionadosCustodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccionadosCustodia.Location = new System.Drawing.Point(618, 25);
            this.lbSeleccionadosCustodia.Name = "lbSeleccionadosCustodia";
            this.lbSeleccionadosCustodia.Size = new System.Drawing.Size(151, 17);
            this.lbSeleccionadosCustodia.TabIndex = 104;
            this.lbSeleccionadosCustodia.Text = "0 SELECCIONADOS";
            // 
            // txtCodigoCustodia
            // 
            this.txtCodigoCustodia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCustodia.Location = new System.Drawing.Point(134, 25);
            this.txtCodigoCustodia.Name = "txtCodigoCustodia";
            this.txtCodigoCustodia.Size = new System.Drawing.Size(136, 23);
            this.txtCodigoCustodia.TabIndex = 103;
            this.txtCodigoCustodia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCustodia_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "CONTRATO";
            // 
            // btnEnviarCustodia
            // 
            this.btnEnviarCustodia.Image = global::PrendaSAL.Properties.Resources.enviar;
            this.btnEnviarCustodia.Location = new System.Drawing.Point(852, 7);
            this.btnEnviarCustodia.Name = "btnEnviarCustodia";
            this.btnEnviarCustodia.Size = new System.Drawing.Size(73, 58);
            this.btnEnviarCustodia.TabIndex = 101;
            this.btnEnviarCustodia.UseVisualStyleBackColor = true;
            this.btnEnviarCustodia.Click += new System.EventHandler(this.ENVIAR_CUSTODIA);
            // 
            // tblCustodia
            // 
            this.tblCustodia.AllowUserToAddRows = false;
            this.tblCustodia.AllowUserToDeleteRows = false;
            this.tblCustodia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblCustodia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCustodia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK,
            this.ID_MOV,
            this.CATEGORIA,
            this.CONTRATO,
            this.CANTIDAD,
            this.ARTICULO,
            this.DESCRIPCION,
            this.VALOR});
            this.tblCustodia.Location = new System.Drawing.Point(6, 71);
            this.tblCustodia.Name = "tblCustodia";
            this.tblCustodia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCustodia.Size = new System.Drawing.Size(962, 366);
            this.tblCustodia.TabIndex = 100;
            this.tblCustodia.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCustodia_CellValueChanged);
            this.tblCustodia.CurrentCellDirtyStateChanged += new System.EventHandler(this.tblCustodia_CurrentCellDirtyStateChanged);
            // 
            // pagRemision
            // 
            this.pagRemision.Controls.Add(this.tblInventario);
            this.pagRemision.Controls.Add(this.lbSeleccionadosRemision);
            this.pagRemision.Controls.Add(this.txtCodigoInv);
            this.pagRemision.Controls.Add(this.label3);
            this.pagRemision.Controls.Add(this.btnEnviarRemision);
            this.pagRemision.Location = new System.Drawing.Point(4, 22);
            this.pagRemision.Name = "pagRemision";
            this.pagRemision.Padding = new System.Windows.Forms.Padding(3);
            this.pagRemision.Size = new System.Drawing.Size(986, 443);
            this.pagRemision.TabIndex = 1;
            this.pagRemision.Text = "REMISION DE INVENTARIO";
            this.pagRemision.UseVisualStyleBackColor = true;
            // 
            // tblInventario
            // 
            this.tblInventario.AllowUserToAddRows = false;
            this.tblInventario.AllowUserToDeleteRows = false;
            this.tblInventario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK_RM,
            this.ID_MOV_RM,
            this.CATEGORIA_RM,
            this.CODIGO_RM,
            this.CANTIDAD_RM,
            this.ARTICULO_RM,
            this.DESCRIPCION_RM,
            this.PRECIO_RM});
            this.tblInventario.Location = new System.Drawing.Point(6, 77);
            this.tblInventario.Name = "tblInventario";
            this.tblInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblInventario.Size = new System.Drawing.Size(962, 366);
            this.tblInventario.TabIndex = 111;
            this.tblInventario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblInventario_CellValueChanged);
            this.tblInventario.CurrentCellDirtyStateChanged += new System.EventHandler(this.tblInventario_CurrentCellDirtyStateChanged);
            // 
            // CHECK_RM
            // 
            this.CHECK_RM.DataPropertyName = "CHECK";
            this.CHECK_RM.HeaderText = "";
            this.CHECK_RM.Name = "CHECK_RM";
            this.CHECK_RM.ReadOnly = true;
            this.CHECK_RM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK_RM.Width = 25;
            // 
            // ID_MOV_RM
            // 
            this.ID_MOV_RM.DataPropertyName = "ID_MOV";
            dataGridViewCellStyle3.Format = "N0";
            this.ID_MOV_RM.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_MOV_RM.HeaderText = "ID_MOV";
            this.ID_MOV_RM.Name = "ID_MOV_RM";
            this.ID_MOV_RM.ReadOnly = true;
            this.ID_MOV_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_MOV_RM.Visible = false;
            // 
            // CATEGORIA_RM
            // 
            this.CATEGORIA_RM.DataPropertyName = "CATEGORIA";
            this.CATEGORIA_RM.HeaderText = "CATEGORIA";
            this.CATEGORIA_RM.Name = "CATEGORIA_RM";
            this.CATEGORIA_RM.ReadOnly = true;
            this.CATEGORIA_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CODIGO_RM
            // 
            this.CODIGO_RM.DataPropertyName = "CODIGO";
            this.CODIGO_RM.HeaderText = "CODIGO";
            this.CODIGO_RM.Name = "CODIGO_RM";
            this.CODIGO_RM.ReadOnly = true;
            this.CODIGO_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD_RM
            // 
            this.CANTIDAD_RM.DataPropertyName = "CANTIDAD";
            this.CANTIDAD_RM.HeaderText = "CANT/PESO";
            this.CANTIDAD_RM.Name = "CANTIDAD_RM";
            this.CANTIDAD_RM.ReadOnly = true;
            this.CANTIDAD_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD_RM.Width = 75;
            // 
            // ARTICULO_RM
            // 
            this.ARTICULO_RM.DataPropertyName = "ARTICULO";
            this.ARTICULO_RM.HeaderText = "ART/KIL";
            this.ARTICULO_RM.Name = "ARTICULO_RM";
            this.ARTICULO_RM.ReadOnly = true;
            this.ARTICULO_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DESCRIPCION_RM
            // 
            this.DESCRIPCION_RM.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION_RM.HeaderText = "DESCRIPCION";
            this.DESCRIPCION_RM.Name = "DESCRIPCION_RM";
            this.DESCRIPCION_RM.ReadOnly = true;
            this.DESCRIPCION_RM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION_RM.Width = 400;
            // 
            // PRECIO_RM
            // 
            this.PRECIO_RM.DataPropertyName = "PRECIO";
            dataGridViewCellStyle4.Format = "C2";
            this.PRECIO_RM.DefaultCellStyle = dataGridViewCellStyle4;
            this.PRECIO_RM.HeaderText = "PRECIO";
            this.PRECIO_RM.Name = "PRECIO_RM";
            this.PRECIO_RM.ReadOnly = true;
            // 
            // lbSeleccionadosRemision
            // 
            this.lbSeleccionadosRemision.AutoSize = true;
            this.lbSeleccionadosRemision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccionadosRemision.Location = new System.Drawing.Point(618, 24);
            this.lbSeleccionadosRemision.Name = "lbSeleccionadosRemision";
            this.lbSeleccionadosRemision.Size = new System.Drawing.Size(151, 17);
            this.lbSeleccionadosRemision.TabIndex = 110;
            this.lbSeleccionadosRemision.Text = "0 SELECCIONADOS";
            // 
            // txtCodigoInv
            // 
            this.txtCodigoInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInv.Location = new System.Drawing.Point(134, 24);
            this.txtCodigoInv.Name = "txtCodigoInv";
            this.txtCodigoInv.Size = new System.Drawing.Size(136, 23);
            this.txtCodigoInv.TabIndex = 109;
            this.txtCodigoInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoInv_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 108;
            this.label3.Text = "CODIGO";
            // 
            // btnEnviarRemision
            // 
            this.btnEnviarRemision.Image = global::PrendaSAL.Properties.Resources.enviar;
            this.btnEnviarRemision.Location = new System.Drawing.Point(852, 6);
            this.btnEnviarRemision.Name = "btnEnviarRemision";
            this.btnEnviarRemision.Size = new System.Drawing.Size(73, 58);
            this.btnEnviarRemision.TabIndex = 107;
            this.btnEnviarRemision.UseVisualStyleBackColor = true;
            this.btnEnviarRemision.Click += new System.EventHandler(this.ENVIAR_REMISION);
            // 
            // CHECK
            // 
            this.CHECK.DataPropertyName = "CHECK";
            this.CHECK.HeaderText = "";
            this.CHECK.Name = "CHECK";
            this.CHECK.ReadOnly = true;
            this.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK.Width = 25;
            // 
            // ID_MOV
            // 
            this.ID_MOV.DataPropertyName = "ID_MOV";
            dataGridViewCellStyle1.Format = "N0";
            this.ID_MOV.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_MOV.HeaderText = "ID_MOV";
            this.ID_MOV.Name = "ID_MOV";
            this.ID_MOV.ReadOnly = true;
            this.ID_MOV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_MOV.Visible = false;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CONTRATO
            // 
            this.CONTRATO.DataPropertyName = "CONTRATO";
            this.CONTRATO.HeaderText = "CONTRATO";
            this.CONTRATO.Name = "CONTRATO";
            this.CONTRATO.ReadOnly = true;
            this.CONTRATO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANT/PESO";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CANTIDAD.Width = 75;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            this.ARTICULO.HeaderText = "ART/KIL";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            dataGridViewCellStyle2.Format = "C2";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // EnviarInvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 493);
            this.Controls.Add(this.tabControlEnvio);
            this.MaximizeBox = false;
            this.Name = "EnviarInvForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ENVIOS DE ARTICULOS";
            this.Load += new System.EventHandler(this.EnviarInvForm_Load);
            this.tabControlEnvio.ResumeLayout(false);
            this.pagCustodia.ResumeLayout(false);
            this.pagCustodia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustodia)).EndInit();
            this.pagRemision.ResumeLayout(false);
            this.pagRemision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEnvio;
        private System.Windows.Forms.TabPage pagCustodia;
        private System.Windows.Forms.TabPage pagRemision;
        private System.Windows.Forms.DataGridView tblCustodia;
        private System.Windows.Forms.Button btnEnviarCustodia;
        private System.Windows.Forms.TextBox txtCodigoCustodia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSeleccionadosCustodia;
        private System.Windows.Forms.Label lbSeleccionadosRemision;
        private System.Windows.Forms.TextBox txtCodigoInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviarRemision;
        private System.Windows.Forms.DataGridView tblInventario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOV_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION_RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_RM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}