﻿namespace PrendaSAL.Caja
{
    partial class ConfirmarGasto
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
            this.cbxSUCURSAL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTIPODOC = new System.Windows.Forms.ComboBox();
            this.txtDOCUMENTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateGasto = new System.Windows.Forms.DateTimePicker();
            this.txtSUBTOTAL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNOTA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lbTOTAL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 109;
            this.label19.Text = "SUCURSAL";
            // 
            // cbxSUCURSAL
            // 
            this.cbxSUCURSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSUCURSAL.Enabled = false;
            this.cbxSUCURSAL.FormattingEnabled = true;
            this.cbxSUCURSAL.Location = new System.Drawing.Point(91, 18);
            this.cbxSUCURSAL.Name = "cbxSUCURSAL";
            this.cbxSUCURSAL.Size = new System.Drawing.Size(217, 21);
            this.cbxSUCURSAL.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "FECHA";
            // 
            // cbxTIPODOC
            // 
            this.cbxTIPODOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPODOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTIPODOC.FormattingEnabled = true;
            this.cbxTIPODOC.Location = new System.Drawing.Point(218, 55);
            this.cbxTIPODOC.Name = "cbxTIPODOC";
            this.cbxTIPODOC.Size = new System.Drawing.Size(80, 24);
            this.cbxTIPODOC.TabIndex = 106;
            this.cbxTIPODOC.SelectedIndexChanged += new System.EventHandler(this.cbxTIPODOC_SelectedIndexChanged);
            // 
            // txtDOCUMENTO
            // 
            this.txtDOCUMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOCUMENTO.Location = new System.Drawing.Point(303, 55);
            this.txtDOCUMENTO.Name = "txtDOCUMENTO";
            this.txtDOCUMENTO.Size = new System.Drawing.Size(129, 30);
            this.txtDOCUMENTO.TabIndex = 105;
            this.txtDOCUMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(332, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "DOCUMENTO";
            // 
            // dateGasto
            // 
            this.dateGasto.Enabled = false;
            this.dateGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGasto.Location = new System.Drawing.Point(91, 55);
            this.dateGasto.Name = "dateGasto";
            this.dateGasto.Size = new System.Drawing.Size(101, 20);
            this.dateGasto.TabIndex = 103;
            // 
            // txtSUBTOTAL
            // 
            this.txtSUBTOTAL.BackColor = System.Drawing.SystemColors.Control;
            this.txtSUBTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUBTOTAL.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtSUBTOTAL.Location = new System.Drawing.Point(307, 215);
            this.txtSUBTOTAL.Name = "txtSUBTOTAL";
            this.txtSUBTOTAL.Size = new System.Drawing.Size(128, 23);
            this.txtSUBTOTAL.TabIndex = 110;
            this.txtSUBTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSUBTOTAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSUBTOTAL_KeyPress);
            this.txtSUBTOTAL.Leave += new System.EventHandler(this.txtSUBTOTAL_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(179, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "T O T A L ";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDESCRIPCION.Location = new System.Drawing.Point(109, 105);
            this.txtDESCRIPCION.MaxLength = 255;
            this.txtDESCRIPCION.Multiline = true;
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(326, 101);
            this.txtDESCRIPCION.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "DESCRIPCION";
            // 
            // CANCELAR
            // 
            this.CANCELAR.Image = global::PrendaSAL.Properties.Resources.cancel;
            this.CANCELAR.Location = new System.Drawing.Point(303, 394);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(128, 40);
            this.CANCELAR.TabIndex = 115;
            this.CANCELAR.Text = "CANCELAR";
            this.CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Image = global::PrendaSAL.Properties.Resources.Save_32x32;
            this.GUARDAR.Location = new System.Drawing.Point(40, 394);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(113, 40);
            this.GUARDAR.TabIndex = 114;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "NOTA ADICIONAL";
            // 
            // txtNOTA
            // 
            this.txtNOTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNOTA.Location = new System.Drawing.Point(12, 324);
            this.txtNOTA.MaxLength = 100;
            this.txtNOTA.Multiline = true;
            this.txtNOTA.Name = "txtNOTA";
            this.txtNOTA.Size = new System.Drawing.Size(326, 51);
            this.txtNOTA.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(199, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 119;
            this.label5.Text = "SUBTOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(260, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 120;
            this.label7.Text = "IVA";
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.SystemColors.Control;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtIVA.Location = new System.Drawing.Point(307, 242);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(128, 23);
            this.txtIVA.TabIndex = 121;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            this.txtIVA.Leave += new System.EventHandler(this.txtIVA_Leave);
            // 
            // lbTOTAL
            // 
            this.lbTOTAL.AutoSize = true;
            this.lbTOTAL.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTAL.ForeColor = System.Drawing.Color.Green;
            this.lbTOTAL.Location = new System.Drawing.Point(303, 276);
            this.lbTOTAL.Name = "lbTOTAL";
            this.lbTOTAL.Size = new System.Drawing.Size(86, 24);
            this.lbTOTAL.TabIndex = 122;
            this.lbTOTAL.Text = "$0.00";
            // 
            // ConfirmarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 452);
            this.Controls.Add(this.lbTOTAL);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNOTA);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.txtSUBTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbxSUCURSAL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTIPODOC);
            this.Controls.Add(this.txtDOCUMENTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateGasto);
            this.MaximizeBox = false;
            this.Name = "ConfirmarGasto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GASTO";
            this.Load += new System.EventHandler(this.ConfirmarGasto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbxSUCURSAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTIPODOC;
        private System.Windows.Forms.TextBox txtDOCUMENTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateGasto;
        private System.Windows.Forms.TextBox txtSUBTOTAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNOTA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label lbTOTAL;
    }
}