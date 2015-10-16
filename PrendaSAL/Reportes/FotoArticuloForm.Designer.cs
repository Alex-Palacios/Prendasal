namespace PrendaSAL.Reportes
{
    partial class FotoArticuloForm
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
            this.components = new System.ComponentModel.Container();
            this.FOTOS = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.ARTICULOS = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // FOTOS
            // 
            this.FOTOS.FullRowSelect = true;
            this.FOTOS.GridLines = true;
            this.FOTOS.Location = new System.Drawing.Point(13, 24);
            this.FOTOS.Name = "FOTOS";
            this.FOTOS.Size = new System.Drawing.Size(185, 339);
            this.FOTOS.TabIndex = 25;
            this.FOTOS.UseCompatibleStateImageBehavior = false;
            this.FOTOS.View = System.Windows.Forms.View.List;
            this.FOTOS.DoubleClick += new System.EventHandler(this.FOTOS_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PrendaSAL.Properties.Resources.eliminar;
            this.btnDelete.Location = new System.Drawing.Point(204, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 24);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PrendaSAL.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(204, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 24);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // IMAGEN
            // 
            this.IMAGEN.BackColor = System.Drawing.Color.White;
            this.IMAGEN.BackgroundImage = global::PrendaSAL.Properties.Resources.fotos;
            this.IMAGEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IMAGEN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IMAGEN.InitialImage = null;
            this.IMAGEN.Location = new System.Drawing.Point(258, 24);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(635, 339);
            this.IMAGEN.TabIndex = 24;
            this.IMAGEN.TabStop = false;
            // 
            // ARTICULOS
            // 
            this.ARTICULOS.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ARTICULOS.ImageSize = new System.Drawing.Size(16, 16);
            this.ARTICULOS.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FotoArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(906, 386);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.FOTOS);
            this.Controls.Add(this.IMAGEN);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FotoArticuloForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FOTOS DE ARTICULO";
            this.Load += new System.EventHandler(this.FotoArticuloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView FOTOS;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.ImageList ARTICULOS;
    }
}