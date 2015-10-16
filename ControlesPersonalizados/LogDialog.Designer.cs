namespace ControlesPersonalizados
{
    partial class LogDialog
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
            this.tblLOG = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANTERIOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSTERIOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblLOG)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLOG
            // 
            this.tblLOG.AllowUserToAddRows = false;
            this.tblLOG.AllowUserToDeleteRows = false;
            this.tblLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLOG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.HOST,
            this.USER,
            this.RESPONSABLE,
            this.OPERACION,
            this.ANTERIOR,
            this.POSTERIOR,
            this.NOTA});
            this.tblLOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLOG.Location = new System.Drawing.Point(0, 0);
            this.tblLOG.Name = "tblLOG";
            this.tblLOG.ReadOnly = true;
            this.tblLOG.Size = new System.Drawing.Size(511, 354);
            this.tblLOG.TabIndex = 0;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // HOST
            // 
            this.HOST.DataPropertyName = "HOSTNAME";
            this.HOST.HeaderText = "HOST";
            this.HOST.Name = "HOST";
            this.HOST.ReadOnly = true;
            this.HOST.Width = 80;
            // 
            // USER
            // 
            this.USER.DataPropertyName = "USER_DB";
            this.USER.HeaderText = "USER";
            this.USER.Name = "USER";
            this.USER.ReadOnly = true;
            this.USER.Width = 80;
            // 
            // RESPONSABLE
            // 
            this.RESPONSABLE.DataPropertyName = "EMPLEADO";
            this.RESPONSABLE.HeaderText = "RESPONSABLE";
            this.RESPONSABLE.Name = "RESPONSABLE";
            this.RESPONSABLE.ReadOnly = true;
            // 
            // OPERACION
            // 
            this.OPERACION.DataPropertyName = "OPERACION";
            this.OPERACION.HeaderText = "OPERACION";
            this.OPERACION.Name = "OPERACION";
            this.OPERACION.ReadOnly = true;
            // 
            // ANTERIOR
            // 
            this.ANTERIOR.DataPropertyName = "DATOS_ANT";
            this.ANTERIOR.HeaderText = "ANTERIOR";
            this.ANTERIOR.Name = "ANTERIOR";
            this.ANTERIOR.ReadOnly = true;
            // 
            // POSTERIOR
            // 
            this.POSTERIOR.DataPropertyName = "DATOS_POS";
            this.POSTERIOR.HeaderText = "POSTERIOR";
            this.POSTERIOR.Name = "POSTERIOR";
            this.POSTERIOR.ReadOnly = true;
            // 
            // NOTA
            // 
            this.NOTA.DataPropertyName = "NOTA";
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.ReadOnly = true;
            // 
            // LogDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.tblLOG);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LOG DE TRANSACCIONES";
            ((System.ComponentModel.ISupportInitialize)(this.tblLOG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblLOG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANTERIOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSTERIOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
    }
}