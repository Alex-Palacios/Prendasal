namespace PrendaSAL.Reportes
{
    partial class RCarteraVigenteForm
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
            this.tblSUCURSALES = new System.Windows.Forms.DataGridView();
            this.CKSUC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COD_SUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckAllSucursales = new System.Windows.Forms.CheckBox();
            this.ckMostrarGraficos = new System.Windows.Forms.CheckBox();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsCarteraVigente = new System.Windows.Forms.BindingSource(this.components);
            this.dSCarteraVigente = new PrendaSAL.Informes.DSCarteraVigente();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUCURSALES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarteraVigente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarteraVigente)).BeginInit();
            this.SuspendLayout();
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
            this.tblSUCURSALES.Location = new System.Drawing.Point(12, 12);
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
            this.tblSUCURSALES.TabIndex = 125;
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
            // ckAllSucursales
            // 
            this.ckAllSucursales.AutoSize = true;
            this.ckAllSucursales.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ckAllSucursales.Location = new System.Drawing.Point(16, 16);
            this.ckAllSucursales.Name = "ckAllSucursales";
            this.ckAllSucursales.Size = new System.Drawing.Size(15, 14);
            this.ckAllSucursales.TabIndex = 133;
            this.ckAllSucursales.UseVisualStyleBackColor = false;
            this.ckAllSucursales.CheckedChanged += new System.EventHandler(this.ckAllSucursales_CheckedChanged);
            // 
            // ckMostrarGraficos
            // 
            this.ckMostrarGraficos.AutoSize = true;
            this.ckMostrarGraficos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMostrarGraficos.Location = new System.Drawing.Point(61, 275);
            this.ckMostrarGraficos.Name = "ckMostrarGraficos";
            this.ckMostrarGraficos.Size = new System.Drawing.Size(153, 17);
            this.ckMostrarGraficos.TabIndex = 135;
            this.ckMostrarGraficos.Text = "MOSTRAR GRAFICOS";
            this.ckMostrarGraficos.UseVisualStyleBackColor = true;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Image = global::PrendaSAL.Properties.Resources.chart2;
            this.btnGENERAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGENERAR.Location = new System.Drawing.Point(76, 298);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(114, 44);
            this.btnGENERAR.TabIndex = 134;
            this.btnGENERAR.Text = "GENERAR";
            this.btnGENERAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGENERAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // viewerREPORTE
            // 
            this.viewerREPORTE.Location = new System.Drawing.Point(263, 12);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.Size = new System.Drawing.Size(735, 322);
            this.viewerREPORTE.TabIndex = 136;
            // 
            // bsCarteraVigente
            // 
            this.bsCarteraVigente.DataMember = "RESUMEN";
            this.bsCarteraVigente.DataSource = this.dSCarteraVigente;
            // 
            // dSCarteraVigente
            // 
            this.dSCarteraVigente.DataSetName = "DSCarteraVigente";
            this.dSCarteraVigente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RCarteraVigenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 346);
            this.Controls.Add(this.viewerREPORTE);
            this.Controls.Add(this.ckMostrarGraficos);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.ckAllSucursales);
            this.Controls.Add(this.tblSUCURSALES);
            this.MaximizeBox = false;
            this.Name = "RCarteraVigenteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CARTERA VIGENTE";
            this.Load += new System.EventHandler(this.RCarteraVigenteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSUCURSALES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCarteraVigente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarteraVigente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblSUCURSALES;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CKSUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.CheckBox ckAllSucursales;
        private System.Windows.Forms.CheckBox ckMostrarGraficos;
        private System.Windows.Forms.Button btnGENERAR;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.BindingSource bsCarteraVigente;
        private Informes.DSCarteraVigente dSCarteraVigente;
    }
}