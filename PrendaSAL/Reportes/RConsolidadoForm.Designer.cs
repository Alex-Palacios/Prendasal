namespace PrendaSAL.Reportes
{
    partial class RConsolidadoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ckAllSucursales = new System.Windows.Forms.CheckBox();
            this.ckAllMeses = new System.Windows.Forms.CheckBox();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.ckAbonos = new System.Windows.Forms.CheckBox();
            this.ckIntereses = new System.Windows.Forms.CheckBox();
            this.ckVentas = new System.Windows.Forms.CheckBox();
            this.ckCompras = new System.Windows.Forms.CheckBox();
            this.ckPrestamos = new System.Windows.Forms.CheckBox();
            this.tblSUCURSALES = new System.Windows.Forms.DataGridView();
            this.CKSUC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COD_SUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMESES = new System.Windows.Forms.DataGridView();
            this.CKMESES = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtANIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsRptConsolidado = new System.Windows.Forms.BindingSource(this.components);
            this.dSConsolidado = new PrendaSAL.Informes.DSConsolidado();
            this.ckMostrarGraficos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUCURSALES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMESES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRptConsolidado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsolidado)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckMostrarGraficos);
            this.splitContainer1.Panel1.Controls.Add(this.ckAllSucursales);
            this.splitContainer1.Panel1.Controls.Add(this.ckAllMeses);
            this.splitContainer1.Panel1.Controls.Add(this.btnGENERAR);
            this.splitContainer1.Panel1.Controls.Add(this.ckAbonos);
            this.splitContainer1.Panel1.Controls.Add(this.ckIntereses);
            this.splitContainer1.Panel1.Controls.Add(this.ckVentas);
            this.splitContainer1.Panel1.Controls.Add(this.ckCompras);
            this.splitContainer1.Panel1.Controls.Add(this.ckPrestamos);
            this.splitContainer1.Panel1.Controls.Add(this.tblSUCURSALES);
            this.splitContainer1.Panel1.Controls.Add(this.tblMESES);
            this.splitContainer1.Panel1.Controls.Add(this.txtANIO);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.viewerREPORTE);
            this.splitContainer1.Size = new System.Drawing.Size(1260, 561);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 118;
            // 
            // ckAllSucursales
            // 
            this.ckAllSucursales.AutoSize = true;
            this.ckAllSucursales.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ckAllSucursales.Location = new System.Drawing.Point(137, 71);
            this.ckAllSucursales.Name = "ckAllSucursales";
            this.ckAllSucursales.Size = new System.Drawing.Size(15, 14);
            this.ckAllSucursales.TabIndex = 132;
            this.ckAllSucursales.UseVisualStyleBackColor = false;
            this.ckAllSucursales.CheckedChanged += new System.EventHandler(this.ckAllSucursales_CheckedChanged);
            // 
            // ckAllMeses
            // 
            this.ckAllMeses.AutoSize = true;
            this.ckAllMeses.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ckAllMeses.Location = new System.Drawing.Point(4, 70);
            this.ckAllMeses.Name = "ckAllMeses";
            this.ckAllMeses.Size = new System.Drawing.Size(15, 14);
            this.ckAllMeses.TabIndex = 131;
            this.ckAllMeses.UseVisualStyleBackColor = false;
            this.ckAllMeses.CheckedChanged += new System.EventHandler(this.ckAllMeses_CheckedChanged);
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Image = global::PrendaSAL.Properties.Resources.chart2;
            this.btnGENERAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGENERAR.Location = new System.Drawing.Point(133, 486);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(114, 44);
            this.btnGENERAR.TabIndex = 130;
            this.btnGENERAR.Text = "GENERAR";
            this.btnGENERAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGENERAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // ckAbonos
            // 
            this.ckAbonos.AutoSize = true;
            this.ckAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAbonos.Location = new System.Drawing.Point(175, 374);
            this.ckAbonos.Name = "ckAbonos";
            this.ckAbonos.Size = new System.Drawing.Size(68, 17);
            this.ckAbonos.TabIndex = 129;
            this.ckAbonos.Text = "Abonos";
            this.ckAbonos.UseVisualStyleBackColor = true;
            // 
            // ckIntereses
            // 
            this.ckIntereses.AutoSize = true;
            this.ckIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckIntereses.Location = new System.Drawing.Point(175, 337);
            this.ckIntereses.Name = "ckIntereses";
            this.ckIntereses.Size = new System.Drawing.Size(78, 17);
            this.ckIntereses.TabIndex = 128;
            this.ckIntereses.Text = "Intereses";
            this.ckIntereses.UseVisualStyleBackColor = true;
            // 
            // ckVentas
            // 
            this.ckVentas.AutoSize = true;
            this.ckVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckVentas.Location = new System.Drawing.Point(42, 414);
            this.ckVentas.Name = "ckVentas";
            this.ckVentas.Size = new System.Drawing.Size(65, 17);
            this.ckVentas.TabIndex = 127;
            this.ckVentas.Text = "Ventas";
            this.ckVentas.UseVisualStyleBackColor = true;
            // 
            // ckCompras
            // 
            this.ckCompras.AutoSize = true;
            this.ckCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCompras.Location = new System.Drawing.Point(42, 374);
            this.ckCompras.Name = "ckCompras";
            this.ckCompras.Size = new System.Drawing.Size(74, 17);
            this.ckCompras.TabIndex = 126;
            this.ckCompras.Text = "Compras";
            this.ckCompras.UseVisualStyleBackColor = true;
            // 
            // ckPrestamos
            // 
            this.ckPrestamos.AutoSize = true;
            this.ckPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPrestamos.Location = new System.Drawing.Point(42, 337);
            this.ckPrestamos.Name = "ckPrestamos";
            this.ckPrestamos.Size = new System.Drawing.Size(84, 17);
            this.ckPrestamos.TabIndex = 125;
            this.ckPrestamos.Text = "Prestamos";
            this.ckPrestamos.UseVisualStyleBackColor = true;
            // 
            // tblSUCURSALES
            // 
            this.tblSUCURSALES.AllowUserToAddRows = false;
            this.tblSUCURSALES.AllowUserToDeleteRows = false;
            this.tblSUCURSALES.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSUCURSALES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblSUCURSALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSUCURSALES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKSUC,
            this.COD_SUC,
            this.SUCURSAL});
            this.tblSUCURSALES.Location = new System.Drawing.Point(133, 67);
            this.tblSUCURSALES.Name = "tblSUCURSALES";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSUCURSALES.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblSUCURSALES.RowHeadersVisible = false;
            this.tblSUCURSALES.RowTemplate.Height = 20;
            this.tblSUCURSALES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSUCURSALES.Size = new System.Drawing.Size(232, 257);
            this.tblSUCURSALES.TabIndex = 124;
            // 
            // CKSUC
            // 
            this.CKSUC.HeaderText = "";
            this.CKSUC.Name = "CKSUC";
            this.CKSUC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CKSUC.Width = 20;
            // 
            // COD_SUC
            // 
            this.COD_SUC.DataPropertyName = "COD_SUC";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Uighur", 14F);
            this.COD_SUC.DefaultCellStyle = dataGridViewCellStyle2;
            this.COD_SUC.HeaderText = "";
            this.COD_SUC.Name = "COD_SUC";
            this.COD_SUC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_SUC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COD_SUC.Width = 30;
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.DataPropertyName = "SUCURSAL";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Uighur", 14F);
            this.SUCURSAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SUCURSAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SUCURSAL.Width = 175;
            // 
            // tblMESES
            // 
            this.tblMESES.AllowUserToAddRows = false;
            this.tblMESES.AllowUserToDeleteRows = false;
            this.tblMESES.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblMESES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMESES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKMESES,
            this.NOMBRE,
            this.MES});
            this.tblMESES.Location = new System.Drawing.Point(0, 67);
            this.tblMESES.Name = "tblMESES";
            this.tblMESES.RowHeadersVisible = false;
            this.tblMESES.RowTemplate.Height = 18;
            this.tblMESES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblMESES.Size = new System.Drawing.Size(126, 257);
            this.tblMESES.TabIndex = 123;
            // 
            // CKMESES
            // 
            this.CKMESES.HeaderText = "";
            this.CKMESES.Name = "CKMESES";
            this.CKMESES.Width = 20;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle5;
            this.NOMBRE.HeaderText = "MES";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MES
            // 
            this.MES.DataPropertyName = "MES";
            this.MES.HeaderText = "MES";
            this.MES.Name = "MES";
            this.MES.ReadOnly = true;
            this.MES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MES.Visible = false;
            // 
            // txtANIO
            // 
            this.txtANIO.Location = new System.Drawing.Point(12, 41);
            this.txtANIO.Name = "txtANIO";
            this.txtANIO.Size = new System.Drawing.Size(95, 20);
            this.txtANIO.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 118;
            this.label3.Text = "AÑO";
            // 
            // viewerREPORTE
            // 
            this.viewerREPORTE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerREPORTE.Location = new System.Drawing.Point(0, 0);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.Size = new System.Drawing.Size(889, 561);
            this.viewerREPORTE.TabIndex = 0;
            // 
            // bsRptConsolidado
            // 
            this.bsRptConsolidado.DataMember = "RESUMEN";
            this.bsRptConsolidado.DataSource = this.dSConsolidado;
            // 
            // dSConsolidado
            // 
            this.dSConsolidado.DataSetName = "DSConsolidado";
            this.dSConsolidado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ckMostrarGraficos
            // 
            this.ckMostrarGraficos.AutoSize = true;
            this.ckMostrarGraficos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMostrarGraficos.Location = new System.Drawing.Point(118, 463);
            this.ckMostrarGraficos.Name = "ckMostrarGraficos";
            this.ckMostrarGraficos.Size = new System.Drawing.Size(153, 17);
            this.ckMostrarGraficos.TabIndex = 133;
            this.ckMostrarGraficos.Text = "MOSTRAR GRAFICOS";
            this.ckMostrarGraficos.UseVisualStyleBackColor = true;
            // 
            // RConsolidadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "RConsolidadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONSOLIDADO";
            this.Load += new System.EventHandler(this.RConsolidadoForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSUCURSALES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMESES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRptConsolidado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSConsolidado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.CheckBox ckAbonos;
        private System.Windows.Forms.CheckBox ckIntereses;
        private System.Windows.Forms.CheckBox ckVentas;
        private System.Windows.Forms.CheckBox ckCompras;
        private System.Windows.Forms.CheckBox ckPrestamos;
        private System.Windows.Forms.DataGridView tblSUCURSALES;
        private System.Windows.Forms.DataGridView tblMESES;
        private System.Windows.Forms.TextBox txtANIO;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.CheckBox ckAllSucursales;
        private System.Windows.Forms.CheckBox ckAllMeses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKSUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKMESES;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MES;
        private System.Windows.Forms.BindingSource bsRptConsolidado;
        private Informes.DSConsolidado dSConsolidado;
        private System.Windows.Forms.CheckBox ckMostrarGraficos;
    }
}