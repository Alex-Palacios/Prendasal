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
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            this.calendarCORTE = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bsReporteDiario = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteDiario = new PrendaSAL.Informes.DSReporteDiario();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).BeginInit();
            this.SuspendLayout();
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
            // calendarCORTE
            // 
            this.calendarCORTE.AnnuallyMarkedDates = new System.DateTime[0];
            this.calendarCORTE.AutoSize = true;
            // 
            // 
            // 
            this.calendarCORTE.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calendarCORTE.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCORTE.BackgroundStyle.BorderBottomWidth = 1;
            this.calendarCORTE.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.calendarCORTE.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCORTE.BackgroundStyle.BorderLeftWidth = 1;
            this.calendarCORTE.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCORTE.BackgroundStyle.BorderRightWidth = 1;
            this.calendarCORTE.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendarCORTE.BackgroundStyle.BorderTopWidth = 1;
            this.calendarCORTE.BackgroundStyle.Class = "";
            this.calendarCORTE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.calendarCORTE.CommandsBackgroundStyle.Class = "";
            this.calendarCORTE.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarCORTE.ContainerControlProcessDialogKey = true;
            this.calendarCORTE.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.calendarCORTE.Location = new System.Drawing.Point(872, 96);
            this.calendarCORTE.MarkedDates = new System.DateTime[0];
            this.calendarCORTE.MaxSelectionCount = 1;
            this.calendarCORTE.MonthlyMarkedDates = new System.DateTime[0];
            this.calendarCORTE.Name = "calendarCORTE";
            // 
            // 
            // 
            this.calendarCORTE.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calendarCORTE.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calendarCORTE.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calendarCORTE.NavigationBackgroundStyle.Class = "";
            this.calendarCORTE.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarCORTE.Size = new System.Drawing.Size(170, 158);
            this.calendarCORTE.TabIndex = 27;
            this.calendarCORTE.Text = "monthCalendarAdv1";
            this.calendarCORTE.TodayButtonVisible = true;
            this.calendarCORTE.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calendarCORTE.MonthChanged += new System.EventHandler(this.calendarCIERRE_MonthChanged);
            this.calendarCORTE.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarCORTE_DateSelected);
            this.calendarCORTE.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.calendarCORTE_ItemDoubleClick);
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.Enabled = false;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(854, 50);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(196, 21);
            this.cbxSUCURSAL.TabIndex = 85;
            this.cbxSUCURSAL.SelectedIndexChanged += new System.EventHandler(this.cbxSUCURSAL_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(851, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "SUCURSAL";
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
            // btnELIMINAR
            // 
            this.btnELIMINAR.BackgroundImage = global::PrendaSAL.Properties.Resources.delete;
            this.btnELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELIMINAR.Location = new System.Drawing.Point(890, 478);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(130, 41);
            this.btnELIMINAR.TabIndex = 87;
            this.btnELIMINAR.Text = "DESHACER CORTE DEL FECHA";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackgroundImage = global::PrendaSAL.Properties.Resources.candado1;
            this.btnGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.Location = new System.Drawing.Point(890, 335);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(130, 137);
            this.btnGUARDAR.TabIndex = 4;
            this.btnGUARDAR.Text = "GUARDAR CORTE DEL FECHA";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // CorteDiarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 545);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.calendarCORTE);
            this.Controls.Add(this.viewerREPORTE);
            this.Controls.Add(this.btnGUARDAR);
            this.MaximizeBox = false;
            this.Name = "CorteDiarioForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "REPORTE DIARIO";
            this.Load += new System.EventHandler(this.CorteDiarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReporteDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteDiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGUARDAR;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.BindingSource bsReporteDiario;
        private Informes.DSReporteDiario dSReporteDiario;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv calendarCORTE;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnELIMINAR;

    }
}