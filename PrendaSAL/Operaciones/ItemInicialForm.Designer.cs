namespace PrendaSAL.Operaciones
{
    partial class ItemInicialForm
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
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.cbxBODEGA = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPERIODO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxMARCA = new System.Windows.Forms.ComboBox();
            this.lbMARCA = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.txtMONTO = new System.Windows.Forms.TextBox();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCODITEM = new System.Windows.Forms.ComboBox();
            this.lbCODITEM = new System.Windows.Forms.Label();
            this.txtCATEGORIA = new System.Windows.Forms.TextBox();
            this.cbxTIPO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::PrendaSAL.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(301, 403);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(128, 40);
            this.btnCANCELAR.TabIndex = 51;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.CANCELAR);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::PrendaSAL.Properties.Resources.Save_32x32;
            this.btnGUARDAR.Location = new System.Drawing.Point(80, 403);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(128, 40);
            this.btnGUARDAR.TabIndex = 50;
            this.btnGUARDAR.Text = "GUARDAR";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.GUARDAR);
            // 
            // cbxBODEGA
            // 
            this.cbxBODEGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBODEGA.FormattingEnabled = true;
            this.cbxBODEGA.Location = new System.Drawing.Point(121, 22);
            this.cbxBODEGA.Name = "cbxBODEGA";
            this.cbxBODEGA.Size = new System.Drawing.Size(211, 21);
            this.cbxBODEGA.TabIndex = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "UBICACION";
            // 
            // txtPERIODO
            // 
            this.txtPERIODO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPERIODO.Location = new System.Drawing.Point(338, 23);
            this.txtPERIODO.MaxLength = 25;
            this.txtPERIODO.Name = "txtPERIODO";
            this.txtPERIODO.ReadOnly = true;
            this.txtPERIODO.Size = new System.Drawing.Size(91, 20);
            this.txtPERIODO.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(357, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 119;
            this.label10.Text = "PERIODO";
            // 
            // cbxMARCA
            // 
            this.cbxMARCA.FormattingEnabled = true;
            this.cbxMARCA.Location = new System.Drawing.Point(121, 176);
            this.cbxMARCA.Name = "cbxMARCA";
            this.cbxMARCA.Size = new System.Drawing.Size(122, 21);
            this.cbxMARCA.TabIndex = 136;
            // 
            // lbMARCA
            // 
            this.lbMARCA.AutoSize = true;
            this.lbMARCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMARCA.Location = new System.Drawing.Point(50, 179);
            this.lbMARCA.Name = "lbMARCA";
            this.lbMARCA.Size = new System.Drawing.Size(50, 13);
            this.lbMARCA.TabIndex = 135;
            this.lbMARCA.Text = "MARCA";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(122, 85);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(210, 20);
            this.txtCODIGO.TabIndex = 123;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 134;
            this.label7.Text = "CODIGO";
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(122, 281);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(75, 20);
            this.txtCANTIDAD.TabIndex = 129;
            this.txtCANTIDAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCANTIDAD_KeyDown);
            this.txtCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCANTIDAD_KeyPress);
            this.txtCANTIDAD.Leave += new System.EventHandler(this.txtCANTIDAD_Leave);
            // 
            // txtMONTO
            // 
            this.txtMONTO.Location = new System.Drawing.Point(122, 311);
            this.txtMONTO.Name = "txtMONTO";
            this.txtMONTO.Size = new System.Drawing.Size(75, 20);
            this.txtMONTO.TabIndex = 130;
            this.txtMONTO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMONTO_KeyDown);
            this.txtMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMONTO_KeyPress);
            this.txtMONTO.Leave += new System.EventHandler(this.txtMONTO_Leave);
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDESCRIPCION.Location = new System.Drawing.Point(122, 203);
            this.txtDESCRIPCION.MaxLength = 255;
            this.txtDESCRIPCION.Multiline = true;
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(287, 72);
            this.txtDESCRIPCION.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "MONTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "DESCRIPCION";
            // 
            // cbxCODITEM
            // 
            this.cbxCODITEM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCODITEM.FormattingEnabled = true;
            this.cbxCODITEM.Location = new System.Drawing.Point(122, 115);
            this.cbxCODITEM.Name = "cbxCODITEM";
            this.cbxCODITEM.Size = new System.Drawing.Size(121, 21);
            this.cbxCODITEM.TabIndex = 125;
            // 
            // lbCODITEM
            // 
            this.lbCODITEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCODITEM.Location = new System.Drawing.Point(34, 118);
            this.lbCODITEM.Name = "lbCODITEM";
            this.lbCODITEM.Size = new System.Drawing.Size(66, 18);
            this.lbCODITEM.TabIndex = 128;
            this.lbCODITEM.Text = "KILATAJE";
            this.lbCODITEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCATEGORIA
            // 
            this.txtCATEGORIA.Location = new System.Drawing.Point(122, 51);
            this.txtCATEGORIA.Name = "txtCATEGORIA";
            this.txtCATEGORIA.ReadOnly = true;
            this.txtCATEGORIA.Size = new System.Drawing.Size(121, 20);
            this.txtCATEGORIA.TabIndex = 122;
            // 
            // cbxTIPO
            // 
            this.cbxTIPO.FormattingEnabled = true;
            this.cbxTIPO.Location = new System.Drawing.Point(122, 142);
            this.cbxTIPO.Name = "cbxTIPO";
            this.cbxTIPO.Size = new System.Drawing.Size(210, 21);
            this.cbxTIPO.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "CATEGORIA";
            // 
            // txtNOTA
            // 
            this.txtNOTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNOTA.Location = new System.Drawing.Point(122, 337);
            this.txtNOTA.MaxLength = 255;
            this.txtNOTA.Multiline = true;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(287, 42);
            this.txtNOTA.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 138;
            this.label3.Text = "DESCRIPCION";
            // 
            // ItemInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 455);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMARCA);
            this.Controls.Add(this.lbMARCA);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCANTIDAD);
            this.Controls.Add(this.txtMONTO);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCODITEM);
            this.Controls.Add(this.lbCODITEM);
            this.Controls.Add(this.txtCATEGORIA);
            this.Controls.Add(this.cbxTIPO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPERIODO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxBODEGA);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ItemInicialForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTICULO";
            this.Load += new System.EventHandler(this.ItemInv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.ComboBox cbxBODEGA;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPERIODO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxMARCA;
        private System.Windows.Forms.Label lbMARCA;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.TextBox txtMONTO;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCODITEM;
        private System.Windows.Forms.Label lbCODITEM;
        private System.Windows.Forms.TextBox txtCATEGORIA;
        private System.Windows.Forms.ComboBox cbxTIPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOTA;
        private System.Windows.Forms.Label label3;
    }
}