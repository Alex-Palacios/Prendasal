namespace PrendaSAL.Reportes
{
    partial class ArticuloForm
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
            this.label19 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtPRECIO = new System.Windows.Forms.TextBox();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSCAN = new System.Windows.Forms.Button();
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.cbxARTICULO = new System.Windows.Forms.ComboBox();
            this.txtCATEGORIA = new System.Windows.Forms.TextBox();
            this.txtNOTA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(61, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 105;
            this.label19.Text = "UBICACION";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::PrendaSAL.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(385, 366);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(128, 40);
            this.btnCANCELAR.TabIndex = 104;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.CANCELAR);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::PrendaSAL.Properties.Resources.Save_32x32;
            this.btnGUARDAR.Location = new System.Drawing.Point(64, 366);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(128, 40);
            this.btnGUARDAR.TabIndex = 103;
            this.btnGUARDAR.Text = "GUARDAR";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.GUARDAR);
            // 
            // txtPRECIO
            // 
            this.txtPRECIO.Location = new System.Drawing.Point(172, 260);
            this.txtPRECIO.Name = "txtPRECIO";
            this.txtPRECIO.Size = new System.Drawing.Size(77, 20);
            this.txtPRECIO.TabIndex = 102;
            this.txtPRECIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRECIO_KeyPress);
            this.txtPRECIO.Leave += new System.EventHandler(this.txtPRECIO_Leave);
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDESCRIPCION.Location = new System.Drawing.Point(171, 179);
            this.txtDESCRIPCION.MaxLength = 100;
            this.txtDESCRIPCION.Multiline = true;
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(342, 62);
            this.txtDESCRIPCION.TabIndex = 100;
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(172, 153);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.ReadOnly = true;
            this.txtCANTIDAD.Size = new System.Drawing.Size(77, 20);
            this.txtCANTIDAD.TabIndex = 99;
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(171, 51);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.ReadOnly = true;
            this.txtCODIGO.Size = new System.Drawing.Size(211, 20);
            this.txtCODIGO.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "PRECIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "DESCRIPCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "PESO/CANT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "KIL/ART";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 88;
            // 
            // btnSCAN
            // 
            this.btnSCAN.BackgroundImage = global::PrendaSAL.Properties.Resources.fotos;
            this.btnSCAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSCAN.Location = new System.Drawing.Point(440, 20);
            this.btnSCAN.Name = "btnSCAN";
            this.btnSCAN.Size = new System.Drawing.Size(122, 109);
            this.btnSCAN.TabIndex = 109;
            this.btnSCAN.UseVisualStyleBackColor = true;
            this.btnSCAN.Click += new System.EventHandler(this.btnSCAN_Click);
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(171, 17);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(211, 21);
            this.cbxSUCURSAL.TabIndex = 111;
            // 
            // cbxARTICULO
            // 
            this.cbxARTICULO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxARTICULO.FormattingEnabled = true;
            this.cbxARTICULO.Location = new System.Drawing.Point(171, 124);
            this.cbxARTICULO.Name = "cbxARTICULO";
            this.cbxARTICULO.Size = new System.Drawing.Size(122, 21);
            this.cbxARTICULO.TabIndex = 113;
            // 
            // txtCATEGORIA
            // 
            this.txtCATEGORIA.Location = new System.Drawing.Point(171, 88);
            this.txtCATEGORIA.Name = "txtCATEGORIA";
            this.txtCATEGORIA.ReadOnly = true;
            this.txtCATEGORIA.Size = new System.Drawing.Size(122, 20);
            this.txtCATEGORIA.TabIndex = 114;
            // 
            // txtNOTA
            // 
            this.txtNOTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNOTA.Location = new System.Drawing.Point(173, 291);
            this.txtNOTA.MaxLength = 100;
            this.txtNOTA.Multiline = true;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(342, 48);
            this.txtNOTA.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "NOTA";
            // 
            // ArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 418);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCATEGORIA);
            this.Controls.Add(this.cbxARTICULO);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.btnSCAN);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.txtPRECIO);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.txtCANTIDAD);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticuloForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTICULO EN EXISTENCIA";
            this.Load += new System.EventHandler(this.ArticuloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtPRECIO;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSCAN;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.ComboBox cbxARTICULO;
        private System.Windows.Forms.TextBox txtCATEGORIA;
        private System.Windows.Forms.TextBox txtNOTA;
        private System.Windows.Forms.Label label7;
    }
}