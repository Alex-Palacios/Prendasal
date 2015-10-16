namespace PrendaSAL.Operaciones
{
    partial class ListaVencPDF
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
            this.viewerCIERRE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsListaCierre = new System.Windows.Forms.BindingSource(this.components);
            this.dSCierre = new PrendaSAL.Informes.DSCierre();
            this.bsKPM = new System.Windows.Forms.BindingSource(this.components);
            this.dSKPM = new PrendaSAL.Informes.DSKPM();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerCIERRE
            // 
            this.viewerCIERRE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerCIERRE.Location = new System.Drawing.Point(0, 0);
            this.viewerCIERRE.Name = "viewerCIERRE";
            this.viewerCIERRE.Size = new System.Drawing.Size(1000, 487);
            this.viewerCIERRE.TabIndex = 122;
            // 
            // bsListaCierre
            // 
            this.bsListaCierre.DataMember = "LISTA_CIERRE";
            this.bsListaCierre.DataSource = this.dSCierre;
            // 
            // dSCierre
            // 
            this.dSCierre.DataSetName = "DSCierre";
            this.dSCierre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ListaCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 487);
            this.Controls.Add(this.viewerCIERRE);
            this.MaximizeBox = false;
            this.Name = "ListaCierre";
            this.Text = "LISTA DE CIERRE";
            this.Load += new System.EventHandler(this.ListaCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsListaCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer viewerCIERRE;
        private System.Windows.Forms.BindingSource bsListaCierre;
        private Informes.DSCierre dSCierre;
        private System.Windows.Forms.BindingSource bsKPM;
        private Informes.DSKPM dSKPM;
    }
}