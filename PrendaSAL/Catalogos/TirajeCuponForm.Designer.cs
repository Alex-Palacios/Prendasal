namespace PrendaSAL.Catalogos
{
    partial class TirajeCuponForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTIPO = new System.Windows.Forms.ComboBox();
            this.dateEXP = new System.Windows.Forms.DateTimePicker();
            this.dateVENC = new System.Windows.Forms.DateTimePicker();
            this.numDESDE = new System.Windows.Forms.NumericUpDown();
            this.numHASTA = new System.Windows.Forms.NumericUpDown();
            this.numDescInteres = new System.Windows.Forms.NumericUpDown();
            this.numDescVenta = new System.Windows.Forms.NumericUpDown();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.ckESTADO = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDESDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHASTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA EXPEDICION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIRAJE DESDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HASTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA DE VENCIMIENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DESC/INTERES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DESC/VENTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "%";
            // 
            // cbxTIPO
            // 
            this.cbxTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTIPO.FormattingEnabled = true;
            this.cbxTIPO.Location = new System.Drawing.Point(195, 20);
            this.cbxTIPO.Name = "cbxTIPO";
            this.cbxTIPO.Size = new System.Drawing.Size(97, 21);
            this.cbxTIPO.TabIndex = 9;
            // 
            // dateEXP
            // 
            this.dateEXP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEXP.Location = new System.Drawing.Point(195, 55);
            this.dateEXP.Name = "dateEXP";
            this.dateEXP.Size = new System.Drawing.Size(97, 20);
            this.dateEXP.TabIndex = 10;
            // 
            // dateVENC
            // 
            this.dateVENC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVENC.Location = new System.Drawing.Point(195, 119);
            this.dateVENC.Name = "dateVENC";
            this.dateVENC.Size = new System.Drawing.Size(97, 20);
            this.dateVENC.TabIndex = 11;
            // 
            // numDESDE
            // 
            this.numDESDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDESDE.ForeColor = System.Drawing.Color.DarkBlue;
            this.numDESDE.Location = new System.Drawing.Point(195, 87);
            this.numDESDE.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDESDE.Name = "numDESDE";
            this.numDESDE.Size = new System.Drawing.Size(69, 23);
            this.numDESDE.TabIndex = 12;
            // 
            // numHASTA
            // 
            this.numHASTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHASTA.ForeColor = System.Drawing.Color.DarkBlue;
            this.numHASTA.Location = new System.Drawing.Point(324, 87);
            this.numHASTA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHASTA.Name = "numHASTA";
            this.numHASTA.Size = new System.Drawing.Size(65, 23);
            this.numHASTA.TabIndex = 13;
            // 
            // numDescInteres
            // 
            this.numDescInteres.DecimalPlaces = 2;
            this.numDescInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDescInteres.ForeColor = System.Drawing.Color.Red;
            this.numDescInteres.Location = new System.Drawing.Point(195, 160);
            this.numDescInteres.Name = "numDescInteres";
            this.numDescInteres.Size = new System.Drawing.Size(75, 26);
            this.numDescInteres.TabIndex = 14;
            // 
            // numDescVenta
            // 
            this.numDescVenta.DecimalPlaces = 2;
            this.numDescVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDescVenta.ForeColor = System.Drawing.Color.Red;
            this.numDescVenta.Location = new System.Drawing.Point(195, 189);
            this.numDescVenta.Name = "numDescVenta";
            this.numDescVenta.Size = new System.Drawing.Size(75, 26);
            this.numDescVenta.TabIndex = 15;
            // 
            // CANCELAR
            // 
            this.CANCELAR.Image = global::PrendaSAL.Properties.Resources.cancel;
            this.CANCELAR.Location = new System.Drawing.Point(241, 265);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(128, 40);
            this.CANCELAR.TabIndex = 72;
            this.CANCELAR.Text = "CANCELAR";
            this.CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Image = global::PrendaSAL.Properties.Resources.Save_32x32;
            this.GUARDAR.Location = new System.Drawing.Point(40, 265);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(113, 40);
            this.GUARDAR.TabIndex = 71;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // ckESTADO
            // 
            this.ckESTADO.AutoSize = true;
            this.ckESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckESTADO.Location = new System.Drawing.Point(195, 237);
            this.ckESTADO.Name = "ckESTADO";
            this.ckESTADO.Size = new System.Drawing.Size(70, 17);
            this.ckESTADO.TabIndex = 73;
            this.ckESTADO.Text = "ACTIVA";
            this.ckESTADO.UseVisualStyleBackColor = true;
            // 
            // TirajeCuponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 317);
            this.Controls.Add(this.ckESTADO);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(this.numDescVenta);
            this.Controls.Add(this.numDescInteres);
            this.Controls.Add(this.numHASTA);
            this.Controls.Add(this.numDESDE);
            this.Controls.Add(this.dateVENC);
            this.Controls.Add(this.dateEXP);
            this.Controls.Add(this.cbxTIPO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TirajeCuponForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TIRAJE BILLETES O CUPONES";
            this.Load += new System.EventHandler(this.TirajeCuponForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDESDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHASTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTIPO;
        private System.Windows.Forms.DateTimePicker dateEXP;
        private System.Windows.Forms.DateTimePicker dateVENC;
        private System.Windows.Forms.NumericUpDown numDESDE;
        private System.Windows.Forms.NumericUpDown numHASTA;
        private System.Windows.Forms.NumericUpDown numDescInteres;
        private System.Windows.Forms.NumericUpDown numDescVenta;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.CheckBox ckESTADO;
    }
}