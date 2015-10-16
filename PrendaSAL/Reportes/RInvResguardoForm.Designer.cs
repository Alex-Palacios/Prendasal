namespace PrendaSAL.Reportes
{
    partial class RInvResguardoForm
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
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.tblINVENTARIO = new System.Windows.Forms.DataGridView();
            this.ID_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.lbNUM_TOTAL = new System.Windows.Forms.Label();
            this.cbxCATEGORIA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rdbDETALLE = new System.Windows.Forms.RadioButton();
            this.rdbCODIGO = new System.Windows.Forms.RadioButton();
            this.cbxARTICULO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblINVENTARIO)).BeginInit();
            this.opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGO.Location = new System.Drawing.Point(181, 82);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(136, 23);
            this.txtCODIGO.TabIndex = 6;
            // 
            // tblINVENTARIO
            // 
            this.tblINVENTARIO.AllowUserToAddRows = false;
            this.tblINVENTARIO.AllowUserToDeleteRows = false;
            this.tblINVENTARIO.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblINVENTARIO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MOV,
            this.CATEGORIA,
            this.CODIGO,
            this.CANTIDAD,
            this.ARTICULO,
            this.DESCRIPCION,
            this.UBICACION});
            this.tblINVENTARIO.Location = new System.Drawing.Point(24, 132);
            this.tblINVENTARIO.Name = "tblINVENTARIO";
            this.tblINVENTARIO.ReadOnly = true;
            this.tblINVENTARIO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblINVENTARIO.Size = new System.Drawing.Size(898, 340);
            this.tblINVENTARIO.TabIndex = 4;
            this.tblINVENTARIO.DataSourceChanged += new System.EventHandler(this.tblINVENTARIO_DataSourceChanged);
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
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANTIDAD";
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
            this.DESCRIPCION.Width = 250;
            // 
            // UBICACION
            // 
            this.UBICACION.DataPropertyName = "UBICACION";
            this.UBICACION.HeaderText = "UBICACION";
            this.UBICACION.Name = "UBICACION";
            this.UBICACION.ReadOnly = true;
            this.UBICACION.Width = 200;
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(181, 38);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 89;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::PrendaSAL.Properties.Resources.search;
            this.btnBUSCAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBUSCAR.Location = new System.Drawing.Point(801, 59);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(91, 69);
            this.btnBUSCAR.TabIndex = 92;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // lbNUM_TOTAL
            // 
            this.lbNUM_TOTAL.AutoSize = true;
            this.lbNUM_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNUM_TOTAL.Location = new System.Drawing.Point(834, 475);
            this.lbNUM_TOTAL.Name = "lbNUM_TOTAL";
            this.lbNUM_TOTAL.Size = new System.Drawing.Size(88, 13);
            this.lbNUM_TOTAL.TabIndex = 93;
            this.lbNUM_TOTAL.Text = "0 ARTICULOS";
            // 
            // cbxCATEGORIA
            // 
            this.cbxCATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCATEGORIA.FormattingEnabled = true;
            this.cbxCATEGORIA.Location = new System.Drawing.Point(507, 38);
            this.cbxCATEGORIA.Name = "cbxCATEGORIA";
            this.cbxCATEGORIA.Size = new System.Drawing.Size(145, 21);
            this.cbxCATEGORIA.TabIndex = 95;
            this.cbxCATEGORIA.SelectedIndexChanged += new System.EventHandler(this.cbxCATEGORIA_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "CATEGORIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CODIGO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(106, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "SUCURSAL";
            // 
            // rdbDETALLE
            // 
            this.rdbDETALLE.AutoSize = true;
            this.rdbDETALLE.Checked = true;
            this.rdbDETALLE.Location = new System.Drawing.Point(64, 41);
            this.rdbDETALLE.Name = "rdbDETALLE";
            this.rdbDETALLE.Size = new System.Drawing.Size(14, 13);
            this.rdbDETALLE.TabIndex = 96;
            this.rdbDETALLE.TabStop = true;
            this.rdbDETALLE.UseVisualStyleBackColor = true;
            this.rdbDETALLE.CheckedChanged += new System.EventHandler(this.rdbDETALLE_CheckedChanged);
            // 
            // rdbCODIGO
            // 
            this.rdbCODIGO.AutoSize = true;
            this.rdbCODIGO.Location = new System.Drawing.Point(64, 82);
            this.rdbCODIGO.Name = "rdbCODIGO";
            this.rdbCODIGO.Size = new System.Drawing.Size(14, 13);
            this.rdbCODIGO.TabIndex = 97;
            this.rdbCODIGO.TabStop = true;
            this.rdbCODIGO.UseVisualStyleBackColor = true;
            this.rdbCODIGO.CheckedChanged += new System.EventHandler(this.rdbCODIGO_CheckedChanged);
            // 
            // cbxARTICULO
            // 
            this.cbxARTICULO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxARTICULO.FormattingEnabled = true;
            this.cbxARTICULO.Location = new System.Drawing.Point(747, 35);
            this.cbxARTICULO.Name = "cbxARTICULO";
            this.cbxARTICULO.Size = new System.Drawing.Size(145, 21);
            this.cbxARTICULO.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "ARTICULO";
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(939, 25);
            this.opciones.TabIndex = 149;
            this.opciones.Text = "toolStrip1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Image = global::PrendaSAL.Properties.Resources.printer;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnImprimir.ToolTipText = "Imprimir";
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
            // RInvResguardoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 497);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.cbxARTICULO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbCODIGO);
            this.Controls.Add(this.rdbDETALLE);
            this.Controls.Add(this.cbxCATEGORIA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNUM_TOTAL);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.tblINVENTARIO);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RInvResguardoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ARTICULOS EN CUSTODIA";
            this.Load += new System.EventHandler(this.RInvResguardoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblINVENTARIO)).EndInit();
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.DataGridView tblINVENTARIO;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label lbNUM_TOTAL;
        private System.Windows.Forms.ComboBox cbxCATEGORIA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rdbDETALLE;
        private System.Windows.Forms.RadioButton rdbCODIGO;
        private System.Windows.Forms.ComboBox cbxARTICULO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION;
        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnAyuda;

    }
}