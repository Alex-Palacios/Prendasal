namespace PrendaSAL.Catalogos
{
    partial class RptCuponesCanjesForm
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
            this.viewerRpt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsCANJEOS = new System.Windows.Forms.BindingSource(this.components);
            this.dSCanjeos = new PrendaSAL.Informes.DSCanjeos();
            ((System.ComponentModel.ISupportInitialize)(this.bsCANJEOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCanjeos)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerRpt
            // 
            this.viewerRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRpt.Location = new System.Drawing.Point(0, 0);
            this.viewerRpt.Name = "viewerRpt";
            this.viewerRpt.Size = new System.Drawing.Size(849, 413);
            this.viewerRpt.TabIndex = 0;
            // 
            // bsCANJEOS
            // 
            this.bsCANJEOS.DataMember = "CANJEO";
            this.bsCANJEOS.DataSource = this.dSCanjeos;
            // 
            // dSCanjeos
            // 
            this.dSCanjeos.DataSetName = "DSCanjeos";
            this.dSCanjeos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RptCuponesCanjesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(849, 413);
            this.Controls.Add(this.viewerRpt);
            this.MaximizeBox = false;
            this.Name = "RptCuponesCanjesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CUPONES Y CANJEOS";
            this.Load += new System.EventHandler(this.RptCuponesCanjesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCANJEOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCanjeos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer viewerRpt;
        private System.Windows.Forms.BindingSource bsCANJEOS;
        private Informes.DSCanjeos dSCanjeos;
    }
}