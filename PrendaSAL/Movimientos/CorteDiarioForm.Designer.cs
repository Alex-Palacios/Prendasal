namespace PrendaSAL.Movimientos
{
    partial class CorteDiarioForm
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
            this.cbxCORTE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCORTE_DIARIO = new System.Windows.Forms.Button();
            this.btnCARGAR = new System.Windows.Forms.Button();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbFECHA_CORTE = new System.Windows.Forms.Label();
            this.bsReporteDiario = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteDiario = new PrendaSAL.Informes.DSReporteDiario();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            ((System.ComponentModel.ISupportInitialize)(this.bsReporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCORTE
            // 
            this.cbxCORTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCORTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCORTE.FormattingEnabled = true;
            this.cbxCORTE.Location = new System.Drawing.Point(839, 54);
            this.cbxCORTE.Name = "cbxCORTE";
            this.cbxCORTE.Size = new System.Drawing.Size(130, 24);
            this.cbxCORTE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA";
            // 
            // btnCORTE_DIARIO
            // 
            this.btnCORTE_DIARIO.BackgroundImage = global::PrendaSAL.Properties.Resources.lock_key;
            this.btnCORTE_DIARIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCORTE_DIARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCORTE_DIARIO.Location = new System.Drawing.Point(882, 358);
            this.btnCORTE_DIARIO.Name = "btnCORTE_DIARIO";
            this.btnCORTE_DIARIO.Size = new System.Drawing.Size(130, 119);
            this.btnCORTE_DIARIO.TabIndex = 4;
            this.btnCORTE_DIARIO.Text = "REALIZAR CORTE";
            this.btnCORTE_DIARIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCORTE_DIARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCORTE_DIARIO.UseVisualStyleBackColor = true;
            this.btnCORTE_DIARIO.Click += new System.EventHandler(this.btnCORTE_DIARIO_Click);
            // 
            // btnCARGAR
            // 
            this.btnCARGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCARGAR.Image = global::PrendaSAL.Properties.Resources.informe;
            this.btnCARGAR.Location = new System.Drawing.Point(892, 99);
            this.btnCARGAR.Name = "btnCARGAR";
            this.btnCARGAR.Size = new System.Drawing.Size(94, 72);
            this.btnCARGAR.TabIndex = 2;
            this.btnCARGAR.Text = "CARGAR";
            this.btnCARGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCARGAR.UseVisualStyleBackColor = true;
            this.btnCARGAR.Click += new System.EventHandler(this.btnCARGAR_Click);
            // 
            // viewerREPORTE
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerREPORTE.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerREPORTE.LocalReport.ReportEmbeddedResource = "";
            this.viewerREPORTE.Location = new System.Drawing.Point(0, 2);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.Size = new System.Drawing.Size(833, 541);
            this.viewerREPORTE.TabIndex = 20;
            // 
            // lbFECHA_CORTE
            // 
            this.lbFECHA_CORTE.AutoSize = true;
            this.lbFECHA_CORTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFECHA_CORTE.Location = new System.Drawing.Point(909, 480);
            this.lbFECHA_CORTE.Name = "lbFECHA_CORTE";
            this.lbFECHA_CORTE.Size = new System.Drawing.Size(58, 17);
            this.lbFECHA_CORTE.TabIndex = 21;
            this.lbFECHA_CORTE.Text = "FECHA";
            // 
            // bsReporteDiario
            // 
            this.bsReporteDiario.DataSource = this.dSReporteDiario;
            this.bsReporteDiario.Position = 0;
            // 
            // dSReporteDiario
            // 
            this.dSReporteDiario.DataSetName = "DSReporteDiario";
            this.dSReporteDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsKPM
            // 
            this.bsKPM.DataMember = "KPM";
            this.bsKPM.DataSource = this.dSKPM;
            // 
            // dSKPM
            // 
            this.dSKPM.DataSetName = "DSKPM";
            this.dSKPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CorteDiarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 545);
            this.Controls.Add(this.lbFECHA_CORTE);
            this.Controls.Add(this.viewerREPORTE);
            this.Controls.Add(this.btnCORTE_DIARIO);
            this.Controls.Add(this.btnCARGAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCORTE);
            this.MaximizeBox = false;
            this.Name = "CorteDiarioForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CORTE DIARIO";
            this.Load += new System.EventHandler(this.CorteDiarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsReporteDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCARGAR;
        private System.Windows.Forms.ComboBox cbxCORTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCORTE_DIARIO;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.Label lbFECHA_CORTE;
        private System.Windows.Forms.BindingSource bsReporteDiario;
        private Informes.DSReporteDiario dSReporteDiario;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;

    }
}