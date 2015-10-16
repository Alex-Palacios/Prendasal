﻿namespace PrendaSAL.Operaciones
{
    partial class RemisionForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.opciones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnReimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.viewerREMISION = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTraslada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSUC_ORG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSUC_DEST = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxTIPODOC = new System.Windows.Forms.ComboBox();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.tblRemision = new System.Windows.Forms.DataGridView();
            this.ID_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnvia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNOTA = new System.Windows.Forms.RichTextBox();
            this.dateTraslado = new System.Windows.Forms.DateTimePicker();
            this.txtNUMERO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNotaRemision = new System.Windows.Forms.BindingSource(this.components);
            this.articuloMov = new PrendaSAL.Informes.ArticuloMov();
            this.opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRemision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNotaRemision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloMov)).BeginInit();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.btnBuscar,
            this.btnReimprimir,
            this.btnLog,
            this.btnAyuda});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(873, 25);
            this.opciones.TabIndex = 4;
            this.opciones.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PrendaSAL.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.ToolTipText = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.NUEVO);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::PrendaSAL.Properties.Resources.icon_save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.ToolTipText = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.GUARDAR);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::PrendaSAL.Properties.Resources.cancel_16;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.ToolTipText = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.CANCELAR);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::PrendaSAL.Properties.Resources.buscar_icon2;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.ToolTipText = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.BUSCAR);
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
            // viewerREMISION
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerREMISION.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerREMISION.LocalReport.ReportEmbeddedResource = "";
            this.viewerREMISION.Location = new System.Drawing.Point(691, 0);
            this.viewerREMISION.Name = "viewerREMISION";
            this.viewerREMISION.Size = new System.Drawing.Size(170, 25);
            this.viewerREMISION.TabIndex = 119;
            this.viewerREMISION.Visible = false;
            this.viewerREMISION.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.ShowPrintDialog);
            // 
            // txtTraslada
            // 
            this.txtTraslada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTraslada.Location = new System.Drawing.Point(537, 61);
            this.txtTraslada.Name = "txtTraslada";
            this.txtTraslada.Size = new System.Drawing.Size(217, 20);
            this.txtTraslada.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(355, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 152;
            this.label4.Text = "RESPONSABLE TRASLADO";
            // 
            // cbxSUC_ORG
            // 
            this.cbxSUC_ORG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUC_ORG.Enabled = false;
            this.cbxSUC_ORG.FormattingEnabled = true;
            this.cbxSUC_ORG.Location = new System.Drawing.Point(537, 34);
            this.cbxSUC_ORG.Name = "cbxSUC_ORG";
            this.cbxSUC_ORG.Size = new System.Drawing.Size(217, 21);
            this.cbxSUC_ORG.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "REMITE";
            // 
            // cbxSUC_DEST
            // 
            this.cbxSUC_DEST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUC_DEST.FormattingEnabled = true;
            this.cbxSUC_DEST.Location = new System.Drawing.Point(537, 87);
            this.cbxSUC_DEST.Name = "cbxSUC_DEST";
            this.cbxSUC_DEST.Size = new System.Drawing.Size(217, 21);
            this.cbxSUC_DEST.TabIndex = 149;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(460, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 148;
            this.label19.Text = "DESTINO";
            // 
            // cbxTIPODOC
            // 
            this.cbxTIPODOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPODOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTIPODOC.FormattingEnabled = true;
            this.cbxTIPODOC.Location = new System.Drawing.Point(26, 62);
            this.cbxTIPODOC.Name = "cbxTIPODOC";
            this.cbxTIPODOC.Size = new System.Drawing.Size(128, 24);
            this.cbxTIPODOC.TabIndex = 147;
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTOTAL.Location = new System.Drawing.Point(775, 494);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(40, 17);
            this.lbTOTAL.TabIndex = 146;
            this.lbTOTAL.Text = "0.00";
            // 
            // tblRemision
            // 
            this.tblRemision.AllowUserToAddRows = false;
            this.tblRemision.AllowUserToDeleteRows = false;
            this.tblRemision.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRemision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MOV,
            this.CATEGORIA,
            this.CODIGO,
            this.CANTIDAD,
            this.ARTICULO,
            this.DESCRIPCION,
            this.PRECIO});
            this.tblRemision.Location = new System.Drawing.Point(8, 175);
            this.tblRemision.Name = "tblRemision";
            this.tblRemision.ReadOnly = true;
            this.tblRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRemision.Size = new System.Drawing.Size(857, 306);
            this.tblRemision.TabIndex = 145;
            this.tblRemision.DataSourceChanged += new System.EventHandler(this.tblRemision_DataSourceChanged);
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
            this.CATEGORIA.Width = 75;
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
            this.DESCRIPCION.Width = 375;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            dataGridViewCellStyle2.Format = "C2";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 80;
            // 
            // txtEnvia
            // 
            this.txtEnvia.Location = new System.Drawing.Point(160, 132);
            this.txtEnvia.Name = "txtEnvia";
            this.txtEnvia.ReadOnly = true;
            this.txtEnvia.Size = new System.Drawing.Size(233, 20);
            this.txtEnvia.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "RESPONSABLE ENVIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(421, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 142;
            this.label10.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA
            // 
            this.txtNOTA.Location = new System.Drawing.Point(538, 114);
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(314, 53);
            this.txtNOTA.TabIndex = 141;
            this.txtNOTA.Text = "";
            // 
            // dateTraslado
            // 
            this.dateTraslado.Enabled = false;
            this.dateTraslado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTraslado.Location = new System.Drawing.Point(160, 98);
            this.dateTraslado.Name = "dateTraslado";
            this.dateTraslado.Size = new System.Drawing.Size(129, 20);
            this.dateTraslado.TabIndex = 140;
            // 
            // txtNUMERO
            // 
            this.txtNUMERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMERO.Location = new System.Drawing.Point(160, 62);
            this.txtNUMERO.Name = "txtNUMERO";
            this.txtNUMERO.ReadOnly = true;
            this.txtNUMERO.Size = new System.Drawing.Size(129, 30);
            this.txtNUMERO.TabIndex = 139;
            this.txtNUMERO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(107, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 138;
            this.label5.Text = "FECHA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(190, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "NUMERO";
            // 
            // bindingNotaRemision
            // 
            this.bindingNotaRemision.DataMember = "ARTICULO_MOV";
            this.bindingNotaRemision.DataSource = this.articuloMov;
            // 
            // articuloMov
            // 
            this.articuloMov.DataSetName = "ArticuloMov";
            this.articuloMov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RemisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 523);
            this.Controls.Add(this.txtTraslada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSUC_ORG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSUC_DEST);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbxTIPODOC);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.tblRemision);
            this.Controls.Add(this.txtEnvia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.dateTraslado);
            this.Controls.Add(this.txtNUMERO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewerREMISION);
            this.Controls.Add(this.opciones);
            this.MaximizeBox = false;
            this.Name = "RemisionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "REMISION DE ARTICULOS";
            this.Load += new System.EventHandler(this.RemisionForm_Load);
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRemision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNotaRemision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip opciones;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnReimprimir;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripButton btnAyuda;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREMISION;
        private System.Windows.Forms.TextBox txtTraslada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSUC_ORG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSUC_DEST;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxTIPODOC;
        private System.Windows.Forms.Label lbTOTAL;
        private System.Windows.Forms.DataGridView tblRemision;
        private System.Windows.Forms.TextBox txtEnvia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtNOTA;
        private System.Windows.Forms.DateTimePicker dateTraslado;
        private System.Windows.Forms.TextBox txtNUMERO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.BindingSource bindingNotaRemision;
        private Informes.ArticuloMov articuloMov;
    }
}