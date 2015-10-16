namespace PrendaSAL
{
    partial class ScannerPrueba
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
            this.Devices = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // Devices
            // 
            this.Devices.FormattingEnabled = true;
            this.Devices.Location = new System.Drawing.Point(52, 38);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(120, 134);
            this.Devices.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Snner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(327, 118);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(215, 148);
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // ScannerPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 393);
            this.Controls.Add(this.img);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Devices);
            this.Name = "ScannerPrueba";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Devices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img;
    }
}