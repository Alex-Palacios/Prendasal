namespace PrendaSAL.Reportes
{
    partial class CanceladosForm
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
            this.dateINICIO = new System.Windows.Forms.DateTimePicker();
            this.dateFIN = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewerCANCEL = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.bindingReporte = new System.Windows.Forms.BindingSource(this.components);
            this.dSCancelados = new PrendaSAL.Informes.DSCancelados();
            ((System.ComponentModel.ISupportInitialize)(this.bindingReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCancelados)).BeginInit();
            this.SuspendLayout();
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(944, 162);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(38, 17);
            this.lb4.TabIndex = 84;
            this.lb4.Text = "DEL";
            // 
            // dateINICIO
            // 
            this.dateINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateINICIO.Location = new System.Drawing.Point(911, 182);
            this.dateINICIO.Name = "dateINICIO";
            this.dateINICIO.Size = new System.Drawing.Size(125, 20);
            this.dateINICIO.TabIndex = 83;
            // 
            // dateFIN
            // 
            this.dateFIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFIN.Location = new System.Drawing.Point(911, 225);
            this.dateFIN.Name = "dateFIN";
            this.dateFIN.Size = new System.Drawing.Size(125, 20);
            this.dateFIN.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(955, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "AL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(871, 35);
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
            this.cbxSUCURSAL.Location = new System.Drawing.Point(874, 51);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(201, 21);
            this.cbxSUCURSAL.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(871, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "OBTENER CANCELADOS";
            // 
            // viewerCANCEL
            // 
            reportDataSource1.Name = "DSI";
            reportDataSource1.Value = null;
            this.viewerCANCEL.LocalReport.DataSources.Add(reportDataSource1);
            this.viewerCANCEL.LocalReport.ReportEmbeddedResource = "";
            this.viewerCANCEL.Location = new System.Drawing.Point(1, -1);
            this.viewerCANCEL.Name = "viewerCANCEL";
            this.viewerCANCEL.PromptAreaCollapsed = true;
            this.viewerCANCEL.Size = new System.Drawing.Size(845, 561);
            this.viewerCANCEL.TabIndex = 76;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Image = global::PrendaSAL.Properties.Resources.reporte;
            this.btnGENERAR.Location = new System.Drawing.Point(928, 310);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(94, 90);
            this.btnGENERAR.TabIndex = 78;
            this.btnGENERAR.Text = "GENERAR";
            this.btnGENERAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // bindingReporte
            // 
            this.bindingReporte.DataMember = "CANCELADOS";
            this.bindingReporte.DataSource = this.dSCancelados;
            // 
            // dSCancelados
            // 
            this.dSCancelados.DataSetName = "DSCancelados";
            this.dSCancelados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CanceladosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1081, 561);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.dateINICIO);
            this.Controls.Add(this.dateFIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewerCANCEL);
            this.MaximizeBox = false;
            this.Name = "CanceladosForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONTRATOS CANCELADOS";
            this.Load += new System.EventHandler(this.CanceladosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCancelados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.DateTimePicker dateINICIO;
        private System.Windows.Forms.DateTimePicker dateFIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer viewerCANCEL;
        private System.Windows.Forms.BindingSource bindingReporte;
        private Informes.DSCancelados dSCancelados;

    }
}