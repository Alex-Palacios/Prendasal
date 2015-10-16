namespace PrendaSAL
{
    partial class LoginForm
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
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateFECHASYSTEM = new System.Windows.Forms.DateTimePicker();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtUSER = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPASSWORD = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(268, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(268, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.White;
            this.btnLOGIN.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.Navy;
            this.btnLOGIN.Image = global::PrendaSAL.Properties.Resources.login;
            this.btnLOGIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLOGIN.Location = new System.Drawing.Point(433, 206);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(189, 45);
            this.btnLOGIN.TabIndex = 3;
            this.btnLOGIN.Text = "ENTRAR";
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::PrendaSAL.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PrendaSAL.Properties.Resources.password_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::PrendaSAL.Properties.Resources.permisos11;
            this.pictureBox2.Location = new System.Drawing.Point(475, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // dateFECHASYSTEM
            // 
            this.dateFECHASYSTEM.Enabled = false;
            this.dateFECHASYSTEM.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFECHASYSTEM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFECHASYSTEM.Location = new System.Drawing.Point(40, 12);
            this.dateFECHASYSTEM.Name = "dateFECHASYSTEM";
            this.dateFECHASYSTEM.Size = new System.Drawing.Size(170, 34);
            this.dateFECHASYSTEM.TabIndex = 8;
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.White;
            this.btnSALIR.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.ForeColor = System.Drawing.Color.Crimson;
            this.btnSALIR.Image = global::PrendaSAL.Properties.Resources.exit;
            this.btnSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSALIR.Location = new System.Drawing.Point(40, 235);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(189, 45);
            this.btnSALIR.TabIndex = 4;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtUSER
            // 
            // 
            // 
            // 
            this.txtUSER.Border.Class = "TextBoxBorder";
            this.txtUSER.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSER.Location = new System.Drawing.Point(433, 112);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(189, 29);
            this.txtUSER.TabIndex = 1;
            this.txtUSER.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSER.WatermarkText = "Codigo Empleado";
            this.txtUSER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUSER_KeyDown);
            // 
            // txtPASSWORD
            // 
            // 
            // 
            // 
            this.txtPASSWORD.Border.Class = "TextBoxBorder";
            this.txtPASSWORD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Location = new System.Drawing.Point(433, 149);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(189, 31);
            this.txtPASSWORD.TabIndex = 2;
            this.txtPASSWORD.WatermarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.WatermarkText = "Contraseña";
            this.txtPASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPASSWORD_KeyDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PrendaSAL.Properties.Resources.textura2;
            this.ClientSize = new System.Drawing.Size(676, 289);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtUSER);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.dateFECHASYSTEM);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateFECHASYSTEM;
        private System.Windows.Forms.Button btnSALIR;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUSER;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPASSWORD;
    }
}