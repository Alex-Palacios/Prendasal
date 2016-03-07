namespace PrendaSAL.Movimientos
{
    partial class AddInvItemForm
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
            this.cbxTIPO = new System.Windows.Forms.ComboBox();
            this.txtCATEGORIA = new System.Windows.Forms.TextBox();
            this.lbCODITEM = new System.Windows.Forms.Label();
            this.cbxCODITEM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.txtMONTO = new System.Windows.Forms.TextBox();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxMARCA = new System.Windows.Forms.ComboBox();
            this.lbMARCA = new System.Windows.Forms.Label();
            this.lbLIMITE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO";
            // 
            // cbxTIPO
            // 
            this.cbxTIPO.FormattingEnabled = true;
            this.cbxTIPO.Location = new System.Drawing.Point(142, 108);
            this.cbxTIPO.Name = "cbxTIPO";
            this.cbxTIPO.Size = new System.Drawing.Size(190, 21);
            this.cbxTIPO.TabIndex = 4;
            // 
            // txtCATEGORIA
            // 
            this.txtCATEGORIA.Location = new System.Drawing.Point(142, 17);
            this.txtCATEGORIA.Name = "txtCATEGORIA";
            this.txtCATEGORIA.ReadOnly = true;
            this.txtCATEGORIA.Size = new System.Drawing.Size(121, 20);
            this.txtCATEGORIA.TabIndex = 1;
            // 
            // lbCODITEM
            // 
            this.lbCODITEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCODITEM.Location = new System.Drawing.Point(54, 84);
            this.lbCODITEM.Name = "lbCODITEM";
            this.lbCODITEM.Size = new System.Drawing.Size(66, 18);
            this.lbCODITEM.TabIndex = 5;
            this.lbCODITEM.Text = "KILATAJE";
            this.lbCODITEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCODITEM
            // 
            this.cbxCODITEM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCODITEM.FormattingEnabled = true;
            this.cbxCODITEM.Location = new System.Drawing.Point(142, 81);
            this.cbxCODITEM.Name = "cbxCODITEM";
            this.cbxCODITEM.Size = new System.Drawing.Size(121, 21);
            this.cbxCODITEM.TabIndex = 3;
            this.cbxCODITEM.SelectedIndexChanged += new System.EventHandler(this.cbxCODITEM_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCRIPCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "PESO/CANT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "MONTO";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(45, 373);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDESCRIPCION.Location = new System.Drawing.Point(141, 169);
            this.txtDESCRIPCION.MaxLength = 255;
            this.txtDESCRIPCION.Multiline = true;
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(190, 98);
            this.txtDESCRIPCION.TabIndex = 5;
            // 
            // txtMONTO
            // 
            this.txtMONTO.Location = new System.Drawing.Point(142, 325);
            this.txtMONTO.Name = "txtMONTO";
            this.txtMONTO.Size = new System.Drawing.Size(75, 20);
            this.txtMONTO.TabIndex = 7;
            this.txtMONTO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMONTO_KeyDown);
            this.txtMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMONTO_KeyPress);
            this.txtMONTO.Leave += new System.EventHandler(this.txtMONTO_Leave);
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(142, 284);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(75, 20);
            this.txtCANTIDAD.TabIndex = 6;
            this.txtCANTIDAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCANTIDAD_KeyDown);
            this.txtCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCANTIDAD_KeyPress);
            this.txtCANTIDAD.Leave += new System.EventHandler(this.txtCANTIDAD_Leave);
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(142, 51);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.ReadOnly = true;
            this.txtCODIGO.Size = new System.Drawing.Size(121, 20);
            this.txtCODIGO.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "CODIGO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(257, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxMARCA
            // 
            this.cbxMARCA.FormattingEnabled = true;
            this.cbxMARCA.Location = new System.Drawing.Point(141, 142);
            this.cbxMARCA.Name = "cbxMARCA";
            this.cbxMARCA.Size = new System.Drawing.Size(122, 21);
            this.cbxMARCA.TabIndex = 18;
            // 
            // lbMARCA
            // 
            this.lbMARCA.AutoSize = true;
            this.lbMARCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMARCA.Location = new System.Drawing.Point(70, 145);
            this.lbMARCA.Name = "lbMARCA";
            this.lbMARCA.Size = new System.Drawing.Size(50, 13);
            this.lbMARCA.TabIndex = 17;
            this.lbMARCA.Text = "MARCA";
            // 
            // lbLIMITE
            // 
            this.lbLIMITE.AutoSize = true;
            this.lbLIMITE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLIMITE.ForeColor = System.Drawing.Color.DarkRed;
            this.lbLIMITE.Location = new System.Drawing.Point(266, 328);
            this.lbLIMITE.Name = "lbLIMITE";
            this.lbLIMITE.Size = new System.Drawing.Size(48, 13);
            this.lbLIMITE.TabIndex = 19;
            this.lbLIMITE.Text = "LIMITE";
            // 
            // AddInvItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 420);
            this.Controls.Add(this.lbLIMITE);
            this.Controls.Add(this.cbxMARCA);
            this.Controls.Add(this.lbMARCA);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCODIGO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCANTIDAD);
            this.Controls.Add(this.txtMONTO);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCODITEM);
            this.Controls.Add(this.lbCODITEM);
            this.Controls.Add(this.txtCATEGORIA);
            this.Controls.Add(this.cbxTIPO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInvItemForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AGREGAR ITEM DE INVENTARIO";
            this.Load += new System.EventHandler(this.AddInvItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTIPO;
        private System.Windows.Forms.TextBox txtCATEGORIA;
        private System.Windows.Forms.Label lbCODITEM;
        private System.Windows.Forms.ComboBox cbxCODITEM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.TextBox txtMONTO;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxMARCA;
        private System.Windows.Forms.Label lbMARCA;
        private System.Windows.Forms.Label lbLIMITE;
    }
}