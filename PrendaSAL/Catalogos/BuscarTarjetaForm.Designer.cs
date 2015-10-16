namespace PrendaSAL.Catalogos
{
    partial class BuscarTarjetaForm
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
            this.rdbVIP = new System.Windows.Forms.RadioButton();
            this.rdbAMIGO = new System.Windows.Forms.RadioButton();
            this.txtNUMTARJETA = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbVIP
            // 
            this.rdbVIP.AutoSize = true;
            this.rdbVIP.Checked = true;
            this.rdbVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVIP.Location = new System.Drawing.Point(53, 24);
            this.rdbVIP.Name = "rdbVIP";
            this.rdbVIP.Size = new System.Drawing.Size(60, 21);
            this.rdbVIP.TabIndex = 0;
            this.rdbVIP.TabStop = true;
            this.rdbVIP.Text = "V.I.P";
            this.rdbVIP.UseVisualStyleBackColor = true;
            // 
            // rdbAMIGO
            // 
            this.rdbAMIGO.AutoSize = true;
            this.rdbAMIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAMIGO.Location = new System.Drawing.Point(53, 51);
            this.rdbAMIGO.Name = "rdbAMIGO";
            this.rdbAMIGO.Size = new System.Drawing.Size(76, 21);
            this.rdbAMIGO.TabIndex = 1;
            this.rdbAMIGO.Text = "AMIGO";
            this.rdbAMIGO.UseVisualStyleBackColor = true;
            // 
            // txtNUMTARJETA
            // 
            this.txtNUMTARJETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMTARJETA.Location = new System.Drawing.Point(88, 112);
            this.txtNUMTARJETA.Name = "txtNUMTARJETA";
            this.txtNUMTARJETA.Size = new System.Drawing.Size(263, 30);
            this.txtNUMTARJETA.TabIndex = 96;
            this.txtNUMTARJETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(139, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 15);
            this.label19.TabIndex = 95;
            this.label19.Text = "NUMERO TARJETA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::PrendaSAL.Properties.Resources.examinar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(160, 163);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 47);
            this.btnBuscar.TabIndex = 97;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscarTarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(409, 252);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNUMTARJETA);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.rdbAMIGO);
            this.Controls.Add(this.rdbVIP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarTarjetaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGAR TARJETA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbVIP;
        private System.Windows.Forms.RadioButton rdbAMIGO;
        private System.Windows.Forms.TextBox txtNUMTARJETA;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBuscar;
    }
}