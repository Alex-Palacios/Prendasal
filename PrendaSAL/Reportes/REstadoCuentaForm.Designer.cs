namespace PrendaSAL.Reportes
{
    partial class REstadoCuentaForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewerREPORTE = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbTEL = new System.Windows.Forms.Label();
            this.lbDIRECCION = new System.Windows.Forms.Label();
            this.lbDOMICILIO = new System.Windows.Forms.Label();
            this.lbEDAD = new System.Windows.Forms.Label();
            this.lbCLIENTE = new System.Windows.Forms.Label();
            this.lbCODIGO = new System.Windows.Forms.Label();
            this.lbNIT = new System.Windows.Forms.Label();
            this.lbDUI = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbEXT = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDocCLI = new System.Windows.Forms.TextBox();
            this.cbxBuscarPorCLI = new System.Windows.Forms.ComboBox();
            this.btnBuscarCLI = new System.Windows.Forms.Button();
            this.tblMOVIMIENTOS = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESTAMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_TRANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckVIGENTES = new System.Windows.Forms.CheckBox();
            this.ckVENCIDOS = new System.Windows.Forms.CheckBox();
            this.ckCANCELADOS = new System.Windows.Forms.CheckBox();
            this.lbCANCELADOS = new System.Windows.Forms.Label();
            this.lbVENCIDOS = new System.Windows.Forms.Label();
            this.lbSALDOS = new System.Windows.Forms.Label();
            this.lbABONOS = new System.Windows.Forms.Label();
            this.lbPRESTAMOS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVIGENTES = new System.Windows.Forms.Label();
            this.btnIMPRIMIR = new System.Windows.Forms.Button();
            this.bsEstadoCuenta = new System.Windows.Forms.BindingSource(this.components);
            this.dSEstadoCuenta = new PrendaSAL.Informes.DSEstadoCuenta();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMOVIMIENTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadoCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewerREPORTE);
            this.groupBox1.Controls.Add(this.lbTEL);
            this.groupBox1.Controls.Add(this.lbDIRECCION);
            this.groupBox1.Controls.Add(this.lbDOMICILIO);
            this.groupBox1.Controls.Add(this.lbEDAD);
            this.groupBox1.Controls.Add(this.lbCLIENTE);
            this.groupBox1.Controls.Add(this.lbCODIGO);
            this.groupBox1.Controls.Add(this.lbNIT);
            this.groupBox1.Controls.Add(this.lbDUI);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbEXT);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtDocCLI);
            this.groupBox1.Controls.Add(this.cbxBuscarPorCLI);
            this.groupBox1.Controls.Add(this.btnBuscarCLI);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS CLIENTE";
            // 
            // viewerREPORTE
            // 
            reportDataSource2.Name = "DSI";
            reportDataSource2.Value = null;
            this.viewerREPORTE.LocalReport.DataSources.Add(reportDataSource2);
            this.viewerREPORTE.LocalReport.ReportEmbeddedResource = "";
            this.viewerREPORTE.Location = new System.Drawing.Point(705, 14);
            this.viewerREPORTE.Name = "viewerREPORTE";
            this.viewerREPORTE.Size = new System.Drawing.Size(170, 25);
            this.viewerREPORTE.TabIndex = 107;
            this.viewerREPORTE.Visible = false;
            this.viewerREPORTE.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.ShowPrintDialog);
            // 
            // lbTEL
            // 
            this.lbTEL.AutoSize = true;
            this.lbTEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTEL.Location = new System.Drawing.Point(589, 56);
            this.lbTEL.Name = "lbTEL";
            this.lbTEL.Size = new System.Drawing.Size(64, 13);
            this.lbTEL.TabIndex = 60;
            this.lbTEL.Text = "TELEFONO";
            // 
            // lbDIRECCION
            // 
            this.lbDIRECCION.AutoSize = true;
            this.lbDIRECCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDIRECCION.Location = new System.Drawing.Point(406, 96);
            this.lbDIRECCION.Name = "lbDIRECCION";
            this.lbDIRECCION.Size = new System.Drawing.Size(66, 13);
            this.lbDIRECCION.TabIndex = 59;
            this.lbDIRECCION.Text = "DIRECCION";
            // 
            // lbDOMICILIO
            // 
            this.lbDOMICILIO.AutoSize = true;
            this.lbDOMICILIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOMICILIO.Location = new System.Drawing.Point(406, 75);
            this.lbDOMICILIO.Name = "lbDOMICILIO";
            this.lbDOMICILIO.Size = new System.Drawing.Size(63, 13);
            this.lbDOMICILIO.TabIndex = 58;
            this.lbDOMICILIO.Text = "MUNICIPIO";
            // 
            // lbEDAD
            // 
            this.lbEDAD.AutoSize = true;
            this.lbEDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDAD.Location = new System.Drawing.Point(406, 56);
            this.lbEDAD.Name = "lbEDAD";
            this.lbEDAD.Size = new System.Drawing.Size(70, 13);
            this.lbEDAD.TabIndex = 57;
            this.lbEDAD.Text = "EDAD AÑOS";
            // 
            // lbCLIENTE
            // 
            this.lbCLIENTE.AutoSize = true;
            this.lbCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCLIENTE.Location = new System.Drawing.Point(406, 36);
            this.lbCLIENTE.Name = "lbCLIENTE";
            this.lbCLIENTE.Size = new System.Drawing.Size(54, 13);
            this.lbCLIENTE.TabIndex = 56;
            this.lbCLIENTE.Text = "NOMBRE";
            // 
            // lbCODIGO
            // 
            this.lbCODIGO.AutoSize = true;
            this.lbCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCODIGO.Location = new System.Drawing.Point(406, 16);
            this.lbCODIGO.Name = "lbCODIGO";
            this.lbCODIGO.Size = new System.Drawing.Size(49, 13);
            this.lbCODIGO.TabIndex = 55;
            this.lbCODIGO.Text = "CODIGO";
            // 
            // lbNIT
            // 
            this.lbNIT.AutoSize = true;
            this.lbNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNIT.Location = new System.Drawing.Point(117, 103);
            this.lbNIT.Name = "lbNIT";
            this.lbNIT.Size = new System.Drawing.Size(100, 13);
            this.lbNIT.TabIndex = 54;
            this.lbNIT.Text = "0000-000000-000-0";
            // 
            // lbDUI
            // 
            this.lbDUI.AutoSize = true;
            this.lbDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDUI.Location = new System.Drawing.Point(117, 82);
            this.lbDUI.Name = "lbDUI";
            this.lbDUI.Size = new System.Drawing.Size(64, 13);
            this.lbDUI.TabIndex = 53;
            this.lbDUI.Text = "00000000-0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(82, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "DUI";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(83, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "NIT";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(321, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "CODIGO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(321, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "DIRECCION";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(321, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "DOMICILIO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(553, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "TEL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(321, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "EDAD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(321, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "CLIENTE";
            // 
            // lbEXT
            // 
            this.lbEXT.AutoSize = true;
            this.lbEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEXT.Location = new System.Drawing.Point(117, 56);
            this.lbEXT.Name = "lbEXT";
            this.lbEXT.Size = new System.Drawing.Size(63, 13);
            this.lbEXT.TabIndex = 44;
            this.lbEXT.Text = "MUNICIPIO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(80, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "EXT";
            // 
            // txtDocCLI
            // 
            this.txtDocCLI.Location = new System.Drawing.Point(120, 19);
            this.txtDocCLI.Name = "txtDocCLI";
            this.txtDocCLI.Size = new System.Drawing.Size(122, 20);
            this.txtDocCLI.TabIndex = 40;
            this.txtDocCLI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocCLI_KeyPress);
            // 
            // cbxBuscarPorCLI
            // 
            this.cbxBuscarPorCLI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscarPorCLI.FormattingEnabled = true;
            this.cbxBuscarPorCLI.Location = new System.Drawing.Point(6, 19);
            this.cbxBuscarPorCLI.Name = "cbxBuscarPorCLI";
            this.cbxBuscarPorCLI.Size = new System.Drawing.Size(105, 21);
            this.cbxBuscarPorCLI.TabIndex = 42;
            // 
            // btnBuscarCLI
            // 
            this.btnBuscarCLI.Image = global::PrendaSAL.Properties.Resources.cliente;
            this.btnBuscarCLI.Location = new System.Drawing.Point(248, 16);
            this.btnBuscarCLI.Name = "btnBuscarCLI";
            this.btnBuscarCLI.Size = new System.Drawing.Size(67, 53);
            this.btnBuscarCLI.TabIndex = 41;
            this.btnBuscarCLI.UseVisualStyleBackColor = true;
            this.btnBuscarCLI.Click += new System.EventHandler(this.btnCLI_Click);
            // 
            // tblMOVIMIENTOS
            // 
            this.tblMOVIMIENTOS.AllowUserToAddRows = false;
            this.tblMOVIMIENTOS.AllowUserToDeleteRows = false;
            this.tblMOVIMIENTOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblMOVIMIENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMOVIMIENTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.CONTRATO,
            this.ARTICULO,
            this.PRESTAMO,
            this.ABONO,
            this.SALDO,
            this.INTERES,
            this.DIAS_TRANS,
            this.ESTADO});
            this.tblMOVIMIENTOS.Location = new System.Drawing.Point(12, 238);
            this.tblMOVIMIENTOS.MultiSelect = false;
            this.tblMOVIMIENTOS.Name = "tblMOVIMIENTOS";
            this.tblMOVIMIENTOS.ReadOnly = true;
            this.tblMOVIMIENTOS.RowHeadersVisible = false;
            this.tblMOVIMIENTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblMOVIMIENTOS.Size = new System.Drawing.Size(881, 211);
            this.tblMOVIMIENTOS.TabIndex = 2;
            this.tblMOVIMIENTOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMOVIMIENTOS_CellDoubleClick);
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle7;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 80;
            // 
            // CONTRATO
            // 
            this.CONTRATO.DataPropertyName = "CONTRATO";
            this.CONTRATO.HeaderText = "CONTRATO";
            this.CONTRATO.Name = "CONTRATO";
            this.CONTRATO.ReadOnly = true;
            this.CONTRATO.Width = 80;
            // 
            // ARTICULO
            // 
            this.ARTICULO.DataPropertyName = "ARTICULO";
            this.ARTICULO.HeaderText = "ARTICULO/PRENDA";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.ReadOnly = true;
            this.ARTICULO.Width = 250;
            // 
            // PRESTAMO
            // 
            this.PRESTAMO.DataPropertyName = "PRESTAMO";
            dataGridViewCellStyle8.Format = "C2";
            this.PRESTAMO.DefaultCellStyle = dataGridViewCellStyle8;
            this.PRESTAMO.HeaderText = "PRESTAMO";
            this.PRESTAMO.Name = "PRESTAMO";
            this.PRESTAMO.ReadOnly = true;
            this.PRESTAMO.Width = 80;
            // 
            // ABONO
            // 
            this.ABONO.DataPropertyName = "ABONO";
            dataGridViewCellStyle9.Format = "C2";
            this.ABONO.DefaultCellStyle = dataGridViewCellStyle9;
            this.ABONO.HeaderText = "ABONO";
            this.ABONO.Name = "ABONO";
            this.ABONO.ReadOnly = true;
            this.ABONO.Width = 80;
            // 
            // SALDO
            // 
            this.SALDO.DataPropertyName = "SALDO";
            dataGridViewCellStyle10.Format = "C2";
            this.SALDO.DefaultCellStyle = dataGridViewCellStyle10;
            this.SALDO.HeaderText = "SALDO";
            this.SALDO.Name = "SALDO";
            this.SALDO.ReadOnly = true;
            this.SALDO.Width = 80;
            // 
            // INTERES
            // 
            this.INTERES.DataPropertyName = "INTERES";
            dataGridViewCellStyle11.Format = "C2";
            this.INTERES.DefaultCellStyle = dataGridViewCellStyle11;
            this.INTERES.HeaderText = "INTERES";
            this.INTERES.Name = "INTERES";
            this.INTERES.ReadOnly = true;
            this.INTERES.Width = 80;
            // 
            // DIAS_TRANS
            // 
            this.DIAS_TRANS.DataPropertyName = "DIAS_TRANS";
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.DIAS_TRANS.DefaultCellStyle = dataGridViewCellStyle12;
            this.DIAS_TRANS.HeaderText = "DIAS";
            this.DIAS_TRANS.Name = "DIAS_TRANS";
            this.DIAS_TRANS.ReadOnly = true;
            this.DIAS_TRANS.Width = 50;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO_CONTRATO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 90;
            // 
            // ckVIGENTES
            // 
            this.ckVIGENTES.AutoSize = true;
            this.ckVIGENTES.Checked = true;
            this.ckVIGENTES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckVIGENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckVIGENTES.ForeColor = System.Drawing.Color.DarkGreen;
            this.ckVIGENTES.Location = new System.Drawing.Point(507, 142);
            this.ckVIGENTES.Name = "ckVIGENTES";
            this.ckVIGENTES.Size = new System.Drawing.Size(88, 17);
            this.ckVIGENTES.TabIndex = 3;
            this.ckVIGENTES.Text = "VIGENTES";
            this.ckVIGENTES.UseVisualStyleBackColor = true;
            this.ckVIGENTES.CheckedChanged += new System.EventHandler(this.ckVIGENTES_CheckedChanged);
            // 
            // ckVENCIDOS
            // 
            this.ckVENCIDOS.AutoSize = true;
            this.ckVENCIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckVENCIDOS.ForeColor = System.Drawing.Color.Crimson;
            this.ckVENCIDOS.Location = new System.Drawing.Point(507, 204);
            this.ckVENCIDOS.Name = "ckVENCIDOS";
            this.ckVENCIDOS.Size = new System.Drawing.Size(89, 17);
            this.ckVENCIDOS.TabIndex = 5;
            this.ckVENCIDOS.Text = "VENCIDOS";
            this.ckVENCIDOS.UseVisualStyleBackColor = true;
            this.ckVENCIDOS.CheckedChanged += new System.EventHandler(this.ckVENCIDOS_CheckedChanged);
            // 
            // ckCANCELADOS
            // 
            this.ckCANCELADOS.AutoSize = true;
            this.ckCANCELADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCANCELADOS.ForeColor = System.Drawing.Color.Blue;
            this.ckCANCELADOS.Location = new System.Drawing.Point(507, 172);
            this.ckCANCELADOS.Name = "ckCANCELADOS";
            this.ckCANCELADOS.Size = new System.Drawing.Size(108, 17);
            this.ckCANCELADOS.TabIndex = 6;
            this.ckCANCELADOS.Text = "CANCELADOS";
            this.ckCANCELADOS.UseVisualStyleBackColor = true;
            this.ckCANCELADOS.CheckedChanged += new System.EventHandler(this.ckCANCELADOS_CheckedChanged);
            // 
            // lbCANCELADOS
            // 
            this.lbCANCELADOS.AutoSize = true;
            this.lbCANCELADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCANCELADOS.Location = new System.Drawing.Point(142, 204);
            this.lbCANCELADOS.Name = "lbCANCELADOS";
            this.lbCANCELADOS.Size = new System.Drawing.Size(17, 17);
            this.lbCANCELADOS.TabIndex = 23;
            this.lbCANCELADOS.Text = "0";
            // 
            // lbVENCIDOS
            // 
            this.lbVENCIDOS.AutoSize = true;
            this.lbVENCIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVENCIDOS.Location = new System.Drawing.Point(142, 173);
            this.lbVENCIDOS.Name = "lbVENCIDOS";
            this.lbVENCIDOS.Size = new System.Drawing.Size(17, 17);
            this.lbVENCIDOS.TabIndex = 22;
            this.lbVENCIDOS.Text = "0";
            // 
            // lbSALDOS
            // 
            this.lbSALDOS.AutoSize = true;
            this.lbSALDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSALDOS.Location = new System.Drawing.Point(332, 204);
            this.lbSALDOS.Name = "lbSALDOS";
            this.lbSALDOS.Size = new System.Drawing.Size(49, 17);
            this.lbSALDOS.TabIndex = 21;
            this.lbSALDOS.Text = "$0.00";
            // 
            // lbABONOS
            // 
            this.lbABONOS.AutoSize = true;
            this.lbABONOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbABONOS.Location = new System.Drawing.Point(332, 173);
            this.lbABONOS.Name = "lbABONOS";
            this.lbABONOS.Size = new System.Drawing.Size(49, 17);
            this.lbABONOS.TabIndex = 20;
            this.lbABONOS.Text = "$0.00";
            // 
            // lbPRESTAMOS
            // 
            this.lbPRESTAMOS.AutoSize = true;
            this.lbPRESTAMOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPRESTAMOS.Location = new System.Drawing.Point(332, 141);
            this.lbPRESTAMOS.Name = "lbPRESTAMOS";
            this.lbPRESTAMOS.Size = new System.Drawing.Size(49, 17);
            this.lbPRESTAMOS.TabIndex = 19;
            this.lbPRESTAMOS.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "ABONOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "SALDOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "PRESTAMOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "CANCELADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "VENCIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "VIGENTES";
            // 
            // lbVIGENTES
            // 
            this.lbVIGENTES.AutoSize = true;
            this.lbVIGENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVIGENTES.Location = new System.Drawing.Point(142, 141);
            this.lbVIGENTES.Name = "lbVIGENTES";
            this.lbVIGENTES.Size = new System.Drawing.Size(17, 17);
            this.lbVIGENTES.TabIndex = 12;
            this.lbVIGENTES.Text = "0";
            // 
            // btnIMPRIMIR
            // 
            this.btnIMPRIMIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMPRIMIR.Image = global::PrendaSAL.Properties.Resources.print;
            this.btnIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIMPRIMIR.Location = new System.Drawing.Point(759, 183);
            this.btnIMPRIMIR.Name = "btnIMPRIMIR";
            this.btnIMPRIMIR.Size = new System.Drawing.Size(134, 38);
            this.btnIMPRIMIR.TabIndex = 25;
            this.btnIMPRIMIR.Text = "IMPRIMIR";
            this.btnIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIMPRIMIR.UseVisualStyleBackColor = true;
            this.btnIMPRIMIR.Click += new System.EventHandler(this.btnIMPRIMIR_Click);
            // 
            // bsEstadoCuenta
            // 
            this.bsEstadoCuenta.DataMember = "ESTADO_CUENTA";
            this.bsEstadoCuenta.DataSource = this.dSEstadoCuenta;
            // 
            // dSEstadoCuenta
            // 
            this.dSEstadoCuenta.DataSetName = "DSEstadoCuenta";
            this.dSEstadoCuenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REstadoCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 461);
            this.Controls.Add(this.btnIMPRIMIR);
            this.Controls.Add(this.lbCANCELADOS);
            this.Controls.Add(this.lbVENCIDOS);
            this.Controls.Add(this.lbSALDOS);
            this.Controls.Add(this.lbABONOS);
            this.Controls.Add(this.lbPRESTAMOS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbVIGENTES);
            this.Controls.Add(this.ckCANCELADOS);
            this.Controls.Add(this.ckVENCIDOS);
            this.Controls.Add(this.ckVIGENTES);
            this.Controls.Add(this.tblMOVIMIENTOS);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "REstadoCuentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ESTADO DE CUENTA";
            this.Load += new System.EventHandler(this.REstadoCuentaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMOVIMIENTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstadoCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblMOVIMIENTOS;
        private System.Windows.Forms.CheckBox ckVIGENTES;
        private System.Windows.Forms.CheckBox ckVENCIDOS;
        private System.Windows.Forms.CheckBox ckCANCELADOS;
        private System.Windows.Forms.Label lbCANCELADOS;
        private System.Windows.Forms.Label lbVENCIDOS;
        private System.Windows.Forms.Label lbSALDOS;
        private System.Windows.Forms.Label lbABONOS;
        private System.Windows.Forms.Label lbPRESTAMOS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVIGENTES;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDocCLI;
        private System.Windows.Forms.ComboBox cbxBuscarPorCLI;
        private System.Windows.Forms.Button btnBuscarCLI;
        private System.Windows.Forms.Label lbEXT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnIMPRIMIR;
        private System.Windows.Forms.Label lbTEL;
        private System.Windows.Forms.Label lbDIRECCION;
        private System.Windows.Forms.Label lbDOMICILIO;
        private System.Windows.Forms.Label lbEDAD;
        private System.Windows.Forms.Label lbCLIENTE;
        private System.Windows.Forms.Label lbCODIGO;
        private System.Windows.Forms.Label lbNIT;
        private System.Windows.Forms.Label lbDUI;
        private Microsoft.Reporting.WinForms.ReportViewer viewerREPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESTAMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTERES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_TRANS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.BindingSource bsEstadoCuenta;
        private Informes.DSEstadoCuenta dSEstadoCuenta;
    }
}