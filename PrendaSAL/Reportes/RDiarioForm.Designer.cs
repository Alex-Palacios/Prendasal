namespace PrendaSAL.Reportes
{
    partial class RDiarioForm
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
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFIN = new System.Windows.Forms.DateTimePicker();
            this.dateINICIO = new System.Windows.Forms.DateTimePicker();
            this.lb4 = new System.Windows.Forms.Label();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.bsTransacciones = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteDiario = new PrendaSAL.Informes.DSReporteDiario();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerREPORTE
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerREPORTE.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerREPORTE.LocalReport.ReportEmbeddedResource = "";
            this.viewerREPORTE.Location = new System.Drawing.Point(0, -1);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.PromptAreaCollapsed = true;
            this.viewerREPORTE.Size = new System.Drawing.Size(845, 550);
            this.viewerREPORTE.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(865, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "SUCURSAL";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.ItemHeight = 13;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(868, 45);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(201, 21);
            this.cbxSUCURSAL.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(886, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "GENERAR REPORTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(949, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "AL";
            // 
            // dateFIN
            // 
            this.dateFIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFIN.Location = new System.Drawing.Point(905, 219);
            this.dateFIN.Name = "dateFIN";
            this.dateFIN.Size = new System.Drawing.Size(125, 20);
            this.dateFIN.TabIndex = 73;
            // 
            // dateINICIO
            // 
            this.dateINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateINICIO.Location = new System.Drawing.Point(905, 176);
            this.dateINICIO.Name = "dateINICIO";
            this.dateINICIO.Size = new System.Drawing.Size(125, 20);
            this.dateINICIO.TabIndex = 74;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(938, 156);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(38, 17);
            this.lb4.TabIndex = 75;
            this.lb4.Text = "DEL";
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Image = global::PrendaSAL.Properties.Resources.reporte;
            this.btnGENERAR.Location = new System.Drawing.Point(922, 304);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(94, 90);
            this.btnGENERAR.TabIndex = 69;
            this.btnGENERAR.Text = "GENERAR";
            this.btnGENERAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // bsTransacciones
            // 
            this.bsTransacciones.DataMember = "TRANSACCIONES";
            this.bsTransacciones.DataSource = this.dSReporteDiario;
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
            // RDiarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 561);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.dateINICIO);
            this.Controls.Add(this.dateFIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewerREPORTE);
            this.MaximizeBox = false;
            this.Name = "RDiarioForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "REPORTE DE TRANSACCIONES";
            this.Load += new System.EventHandler(this.RDiarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFIN;
        private System.Windows.Forms.DateTimePicker dateINICIO;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.BindingSource bsTransacciones;
        private Informes.DSReporteDiario dSReporteDiario;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;
    }
}