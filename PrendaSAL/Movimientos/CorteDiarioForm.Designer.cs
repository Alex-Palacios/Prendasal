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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnCORTE_DIARIO = new System.Windows.Forms.Button();
            this.btnCARGAR = new System.Windows.Forms.Button();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbFECHA_CORTE = new System.Windows.Forms.Label();
            this.bsReporteDiario = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteDiario = new PrendaSAL.Informes.DSReporteDiario();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            this.calendarCIERRE = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.bsReporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCORTE_DIARIO
            // 
            this.btnCORTE_DIARIO.BackgroundImage = global::PrendaSAL.Properties.Resources.lock_key;
            this.btnCORTE_DIARIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCORTE_DIARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCORTE_DIARIO.Location = new System.Drawing.Point(894, 345);
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
            this.btnCARGAR.Location = new System.Drawing.Point(887, 203);
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
            reportDataSource2.Name = "DSI";
            reportDataSource2.Value = null;
            this.viewerREPORTE.LocalReport.DataSources.Add(reportDataSource2);
            this.viewerREPORTE.LocalReport.ReportEmbeddedResource = "";
            this.viewerREPORTE.Location = new System.Drawing.Point(0, 2);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.ShowToolBar = false;
            this.viewerREPORTE.Size = new System.Drawing.Size(833, 541);
            this.viewerREPORTE.TabIndex = 20;
            // 
            // lbFECHA_CORTE
            // 
            this.lbFECHA_CORTE.AutoSize = true;
            this.lbFECHA_CORTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFECHA_CORTE.Location = new System.Drawing.Point(923, 467);
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
            // calendarCIERRE
            // 
            this.calendarCIERRE.AnnuallyMarkedDates = new System.DateTime[0];
            this.calendarCIERRE.AutoSize = true;
            // 
            // 
            // 
            this.calendarCIERRE.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calendarCIERRE.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCIERRE.BackgroundStyle.BorderBottomWidth = 1;
            this.calendarCIERRE.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.calendarCIERRE.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCIERRE.BackgroundStyle.BorderLeftWidth = 1;
            this.calendarCIERRE.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCIERRE.BackgroundStyle.BorderRightWidth = 1;
            this.calendarCIERRE.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCIERRE.BackgroundStyle.BorderTopWidth = 1;
            this.calendarCIERRE.BackgroundStyle.Class = "";
            this.calendarCIERRE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.calendarCIERRE.CommandsBackgroundStyle.Class = "";
            this.calendarCIERRE.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarCIERRE.ContainerControlProcessDialogKey = true;
            this.calendarCIERRE.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.calendarCIERRE.Location = new System.Drawing.Point(872, 26);
            this.calendarCIERRE.MarkedDates = new System.DateTime[0];
            this.calendarCIERRE.MaxSelectionCount = 1;
            this.calendarCIERRE.MonthlyMarkedDates = new System.DateTime[0];
            this.calendarCIERRE.Name = "calendarCIERRE";
            // 
            // 
            // 
            this.calendarCIERRE.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calendarCIERRE.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calendarCIERRE.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calendarCIERRE.NavigationBackgroundStyle.Class = "";
            this.calendarCIERRE.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarCIERRE.Size = new System.Drawing.Size(170, 128);
            this.calendarCIERRE.TabIndex = 27;
            this.calendarCIERRE.Text = "monthCalendarAdv1";
            this.calendarCIERRE.TodayButtonVisible = true;
            this.calendarCIERRE.WeekendDaysSelectable = false;
            this.calendarCIERRE.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calendarCIERRE.MonthChanged += new System.EventHandler(this.calendarCIERRE_MonthChanged);
            // 
            // CorteDiarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 545);
            this.Controls.Add(this.calendarCIERRE);
            this.Controls.Add(this.lbFECHA_CORTE);
            this.Controls.Add(this.viewerREPORTE);
            this.Controls.Add(this.btnCORTE_DIARIO);
            this.Controls.Add(this.btnCARGAR);
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
        private System.Windows.Forms.Button btnCORTE_DIARIO;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.Label lbFECHA_CORTE;
        private System.Windows.Forms.BindingSource bsReporteDiario;
        private Informes.DSReporteDiario dSReporteDiario;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv calendarCIERRE;

    }
}