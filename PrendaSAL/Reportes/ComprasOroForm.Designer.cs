namespace PrendaSAL.Reportes
{
    partial class ComprasOroForm
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
            this.label18 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbxMESES = new System.Windows.Forms.ComboBox();
            this.txtANIO = new System.Windows.Forms.TextBox();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.bindingReporte = new System.Windows.Forms.BindingSource(this.components);
            this.dSComprasKilMes = new PrendaSAL.Informes.DSComprasKilMes();
            ((System.ComponentModel.ISupportInitialize)(this.bindingReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprasKilMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(886, 182);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(41, 17);
            this.lb4.TabIndex = 84;
            this.lb4.Text = "AÑO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(886, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "MES";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(877, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "SUCURSAL";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.ItemHeight = 13;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(880, 58);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(201, 21);
            this.cbxSUCURSAL.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 141);
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
            // cbxMESES
            // 
            this.cbxMESES.FormattingEnabled = true;
            this.cbxMESES.Location = new System.Drawing.Point(932, 220);
            this.cbxMESES.Name = "cbxMESES";
            this.cbxMESES.Size = new System.Drawing.Size(121, 21);
            this.cbxMESES.TabIndex = 85;
            // 
            // txtANIO
            // 
            this.txtANIO.Location = new System.Drawing.Point(933, 182);
            this.txtANIO.MaxLength = 4;
            this.txtANIO.Name = "txtANIO";
            this.txtANIO.Size = new System.Drawing.Size(120, 20);
            this.txtANIO.TabIndex = 86;
            this.txtANIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtANIO_KeyPress);
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.BackgroundImage = global::PrendaSAL.Properties.Resources.reporte3;
            this.btnGENERAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(933, 280);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(94, 90);
            this.btnGENERAR.TabIndex = 78;
            this.btnGENERAR.Text = "GENERAR";
            this.btnGENERAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGENERAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // bindingReporte
            // 
            this.bindingReporte.DataMember = "COMPRASKIL";
            this.bindingReporte.DataSource = this.dSComprasKilMes;
            // 
            // dSComprasKilMes
            // 
            this.dSComprasKilMes.DataSetName = "DSComprasKilMes";
            this.dSComprasKilMes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComprasOroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 561);
            this.Controls.Add(this.txtANIO);
            this.Controls.Add(this.cbxMESES);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewerREPORTE);
            this.MaximizeBox = false;
            this.Name = "ComprasOroForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "COMPRAS DE ORO Y PLATA";
            this.Load += new System.EventHandler(this.ComprasOroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprasKilMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.ComboBox cbxMESES;
        private System.Windows.Forms.TextBox txtANIO;
        private System.Windows.Forms.BindingSource bindingReporte;
        private Informes.DSComprasKilMes dSComprasKilMes;
    }
}