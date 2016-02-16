namespace PrendaSAL.Reportes
{
    partial class RVencidosOroForm
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
            this.lb4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbxListas = new System.Windows.Forms.ComboBox();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.dateVenc = new System.Windows.Forms.DateTimePicker();
            this.bsVencidosOro = new System.Windows.Forms.BindingSource(this.components);
            this.dSVencidosOro = new PrendaSAL.Informes.DSVencidosOro();
            ((System.ComponentModel.ISupportInitialize)(this.bsVencidosOro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVencidosOro)).BeginInit();
            this.SuspendLayout();
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(930, 164);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(104, 17);
            this.lb4.TabIndex = 84;
            this.lb4.Text = "FECHA VENC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(930, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "LISTA VENC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(907, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "GENERAR REPORTE";
            // 
            // viewerREPORTE
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerREPORTE.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerREPORTE.LocalReport.ReportEmbeddedResource = "";
            this.viewerREPORTE.Location = new System.Drawing.Point(12, 12);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.PromptAreaCollapsed = true;
            this.viewerREPORTE.Size = new System.Drawing.Size(845, 544);
            this.viewerREPORTE.TabIndex = 76;
            // 
            // cbxListas
            // 
            this.cbxListas.FormattingEnabled = true;
            this.cbxListas.Location = new System.Drawing.Point(932, 238);
            this.cbxListas.Name = "cbxListas";
            this.cbxListas.Size = new System.Drawing.Size(121, 21);
            this.cbxListas.TabIndex = 85;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.BackgroundImage = global::PrendaSAL.Properties.Resources.reporte3;
            this.btnGENERAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(940, 285);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(94, 90);
            this.btnGENERAR.TabIndex = 78;
            this.btnGENERAR.Text = "GENERAR";
            this.btnGENERAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGENERAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // dateVenc
            // 
            this.dateVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenc.Location = new System.Drawing.Point(933, 184);
            this.dateVenc.Name = "dateVenc";
            this.dateVenc.Size = new System.Drawing.Size(120, 20);
            this.dateVenc.TabIndex = 86;
            this.dateVenc.ValueChanged += new System.EventHandler(this.dateVenc_ValueChanged);
            // 
            // bsVencidosOro
            // 
            this.bsVencidosOro.DataMember = "VENCIDOS_ORO";
            this.bsVencidosOro.DataSource = this.dSVencidosOro;
            // 
            // dSVencidosOro
            // 
            this.dSVencidosOro.DataSetName = "DSVencidosOro";
            this.dSVencidosOro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RVencidosOroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 561);
            this.Controls.Add(this.dateVenc);
            this.Controls.Add(this.cbxListas);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewerREPORTE);
            this.MaximizeBox = false;
            this.Name = "RVencidosOroForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VENCIDOS ORO Y PLATA";
            this.Load += new System.EventHandler(this.ComprasOroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVencidosOro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVencidosOro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.ComboBox cbxListas;
        private System.Windows.Forms.DateTimePicker dateVenc;
        private System.Windows.Forms.BindingSource bsVencidosOro;
        private Informes.DSVencidosOro dSVencidosOro;
    }
}