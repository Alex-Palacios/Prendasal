namespace PrendaSAL.Configuracion
{
    partial class MiCuentaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCambiarPassword = new System.Windows.Forms.Button();
            this.picEMPLEADO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEMPLEADO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO EMPLEADO";
            // 
            // txtCodEmpleado
            // 
            this.txtCodEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEmpleado.Location = new System.Drawing.Point(12, 47);
            this.txtCodEmpleado.Name = "txtCodEmpleado";
            this.txtCodEmpleado.ReadOnly = true;
            this.txtCodEmpleado.Size = new System.Drawing.Size(155, 26);
            this.txtCodEmpleado.TabIndex = 7;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(219, 92);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(389, 23);
            this.txtNombreEmpleado.TabIndex = 8;
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoUsuario.Enabled = false;
            this.cbxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Location = new System.Drawing.Point(340, 146);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(177, 24);
            this.cbxTipoUsuario.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "TIPO USUARIO";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::PrendaSAL.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(507, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 62);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCambiarPassword
            // 
            this.btnCambiarPassword.Image = global::PrendaSAL.Properties.Resources.password;
            this.btnCambiarPassword.Location = new System.Drawing.Point(38, 305);
            this.btnCambiarPassword.Name = "btnCambiarPassword";
            this.btnCambiarPassword.Size = new System.Drawing.Size(101, 62);
            this.btnCambiarPassword.TabIndex = 14;
            this.btnCambiarPassword.UseVisualStyleBackColor = true;
            this.btnCambiarPassword.Click += new System.EventHandler(this.btnCambiarPassword_Click);
            // 
            // picEMPLEADO
            // 
            this.picEMPLEADO.BackgroundImage = global::PrendaSAL.Properties.Resources.usuario;
            this.picEMPLEADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEMPLEADO.Location = new System.Drawing.Point(12, 103);
            this.picEMPLEADO.Name = "picEMPLEADO";
            this.picEMPLEADO.Size = new System.Drawing.Size(160, 177);
            this.picEMPLEADO.TabIndex = 0;
            this.picEMPLEADO.TabStop = false;
            // 
            // MiCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 378);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCambiarPassword);
            this.Controls.Add(this.cbxTipoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtCodEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picEMPLEADO);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MiCuentaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MI CUENTA DE USUARIO";
            this.Load += new System.EventHandler(this.MiCuentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEMPLEADO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEMPLEADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCambiarPassword;
        private System.Windows.Forms.Button btnExit;
    }
}