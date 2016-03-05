using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ControlesPersonalizados;

namespace PrendaSAL.Movimientos
{
    using MODELO;
    using DDB;

    public partial class ContratosForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ContratosForm frmInstance = null;

        public static ContratosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ContratosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private DBCliente dbCliente;
        private DBPrestamo dbPrestamo;
        private DBCatalogo dbCatalogo;

        private eOperacion ACCION;

        private Prestamo PRESTAMO;
        private Prestamo SELECTED;
        private DataTable PRECIOS;

        

        public ContratosForm()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbCliente = new DBCliente();
            dbPrestamo = new DBPrestamo ();
            dbCatalogo = new DBCatalogo();
            PRESTAMO = new Prestamo();
        }




        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnAnular.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnLog.Visible = false;
            btnReimprimir.Visible = false;
            btnPrintKITCO.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P5")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnGuardar.Visible = p.Field<bool>("REGISTRAR") || p.Field<bool>("ACTUALIZAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscar.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                    btnPrintKITCO.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }

            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
            {
                cbxTIPOPRESTAMO.Enabled = false;
                cbxSUCURSAL.Enabled = false;
                numTASA.Enabled = false;
                numPLAZO.Enabled = false;
                numVENC.Enabled = false;
            }
            else
            {
                cbxTIPOPRESTAMO.Enabled = true;
                cbxSUCURSAL.Enabled = true;
                numTASA.Enabled = true;
                numPLAZO.Enabled = true;
                numVENC.Enabled = true;
            }
        }



        private void ContratosForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblITEMS.AutoGenerateColumns = false;
            cbxBuscarPorCLI.DataSource = Enum.GetValues(new eTipoDocCliente().GetType());
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            cbxTIPOPRESTAMO.DataSource = Enum.GetValues(new eTipoPrestamo().GetType());
            cbxTIPOPRESTAMO.SelectedItem = eTipoPrestamo.PRENDARIO;

            cbxCategorias.DataSource = HOME.Instance().datCATEGORIAS.Copy();
            if (HOME.Instance().datCATEGORIAS.Rows.Count > 0)
            {
                cbxCategorias.DisplayMember = "CATEGORIA";
                cbxCategorias.ValueMember = "CATEGORIA";
                cbxCategorias.SelectedIndex = -1;
                cbxCategorias.SelectedIndex = 0;
            }

            bloquear();
            NUEVO(null, null);
        }




        private void bloquear()
        {
            grbCLIENTE.Enabled = false;
            grbCONTRATO.Enabled = false;
            grbREGLAS.Enabled = false;
            grbDETALLE.Enabled = false;
            txtNOTA.ReadOnly = true;
        }


        private void desbloquear()
        {
            grbCLIENTE.Enabled = true;
            grbCONTRATO.Enabled = true;
            grbREGLAS.Enabled = true;
            grbDETALLE.Enabled = true;
            txtNOTA.ReadOnly = false;
        }



        private void limpiarDatosCliente()
        {
            txtCodigoCLI.Text = string.Empty;
            txtDocCLI.Text = string.Empty;
            txtExtCLI.Text = string.Empty;
            txtNombreCLI.Text = string.Empty;
            txtEdadCLI.Text = string.Empty;
            txtTelCLI.Text = string.Empty;
            txtDomicilioCLI.Text = string.Empty;
            txtDireccionCLI.Text = string.Empty;
        }

        private void limpiarDatosPrestamo()
        {
            txtDOCUMENTO.Text = string.Empty;
            tblITEMS.DataSource = null;
            lbNIVEL.Text = string.Empty;
            txtTOTAL.Text = string.Empty;
            txtNOTA.Text = string.Empty;
            numTASA.Value = Decimal.Zero;
            numPLAZO.Value = Decimal.Zero;
            numVENC.Value = Decimal.Zero;
        }


        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            PRESTAMO = new Prestamo();
            PRESTAMO.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            PRESTAMO.DOCUMENTO = dbPrestamo.nextContratoPrestamo(PRESTAMO.COD_SUC);
            PRESTAMO.FECHA = HOME.Instance().FECHA_SISTEMA;
            PRESTAMO.NIVEL = eNIVEL.PRENDASAL;
            PRESTAMO.TIPO = eTipoPrestamo.PRENDARIO;
            PRESTAMO.TIPO_PAGO = eTipoPago.EFECTIVO;
            PRESTAMO.CATEGORIA = (string)cbxCategorias.SelectedValue;
            PRESTAMO.ESTADO_CONTRATO = eEstadoContrato.ACTIVO;
            
            cargarTarjeta(new Tarjeta());

            cargarDatosCliente(null);
            cargarDatosPrestamo();
            desbloquear();
            txtDocCLI.Focus();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;
            btnPrintKITCO.Enabled = false;

            txtDocCLI.Focus();
        }



        public void cargarDatosCliente(Cliente CLIENTE)
        {
            if (CLIENTE != null && CLIENTE.COD_CLIENTE != null && CLIENTE.COD_CLIENTE != string.Empty)
            {
                PRESTAMO.COD_CLIENTE = CLIENTE.COD_CLIENTE;
                PRESTAMO.CLIENTE = CLIENTE.CLIENTE;
                PRESTAMO.EDAD = CLIENTE.EDAD;
                PRESTAMO.DUI = CLIENTE.DUI;
                PRESTAMO.LICENCIA = CLIENTE.LICENCIA;
                PRESTAMO.PASAPORTE = CLIENTE.PASAPORTE;
                PRESTAMO.CARNET = CLIENTE.CARNET;
                PRESTAMO.EXTENDIDO = CLIENTE.EXTENDIDO;
                PRESTAMO.TEL_CLI = CLIENTE.TEL;
                PRESTAMO.DOMICILIO_CLI = CLIENTE.DOMICILIO;
                PRESTAMO.DIRECCION_CLI = CLIENTE.DIRECCION;
            }
            txtCodigoCLI.Text = PRESTAMO.COD_CLIENTE;
            txtNombreCLI.Text = PRESTAMO.CLIENTE;
            if (PRESTAMO.DUI != null && PRESTAMO.DUI != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.DUI;
                txtDocCLI.Text = PRESTAMO.DUI;
            }
            else if (PRESTAMO.LICENCIA != null && PRESTAMO.LICENCIA != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.LICENCIA;
                txtDocCLI.Text = PRESTAMO.LICENCIA;
            }
            else if (PRESTAMO.PASAPORTE != null && PRESTAMO.PASAPORTE != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.PASAPORTE;
                txtDocCLI.Text = PRESTAMO.PASAPORTE;
            }
            else if (PRESTAMO.CARNET != null && PRESTAMO.CARNET != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.CARNET;
                txtDocCLI.Text = PRESTAMO.CARNET;
            }
            else
            {
                txtDocCLI.Text = string.Empty;
            }
            txtEdadCLI.Text = PRESTAMO.EDAD + "";
            txtExtCLI.Text = PRESTAMO.EXTENDIDO;
            txtTelCLI.Text = PRESTAMO.TEL_CLI;
            txtDomicilioCLI.Text = PRESTAMO.DOMICILIO_CLI;
            txtDireccionCLI.Text = PRESTAMO.DIRECCION_CLI;
        }





        private void cargarDatosPrestamo()
        {
            if (PRESTAMO != null)
            {
                cbxSUCURSAL.SelectedValue = PRESTAMO.COD_SUC;
                cbxTIPOPRESTAMO.SelectedItem = PRESTAMO.TIPO;
                txtDOCUMENTO.Text = PRESTAMO.DOCUMENTO;
                dateCONTRATO.Value = PRESTAMO.FECHA;
                lbNIVEL.Text = PRESTAMO.NIVEL.ToString();
                numTASA.Value = PRESTAMO.TASA_MENSUAL;
                numPLAZO.Value = PRESTAMO.PLAZO_CONTRATO;
                numVENC.Value = PRESTAMO.PLAZO_VENC;
                tblITEMS.DataSource = null;
                cbxCategorias.SelectedValue = PRESTAMO.CATEGORIA;
                tblITEMS.DataSource = PRESTAMO.ITEMS_PRESTAMO;
                txtINTERES_MENSUAL.Text = PRESTAMO.INTERES_MENSUAL_INIT.ToString("C2");
                txtINTERES_DIARIO.Text = PRESTAMO.INTERES_DIARIO_INIT.ToString("C4");
                txtTOTAL.Text = PRESTAMO.TOTAL.ToString("C2");
                txtNOTA.Text = PRESTAMO.NOTA;

                switch (PRESTAMO.ESTADO_CONTRATO)
                {
                    case eEstadoContrato.ACTIVO:
                        lbESTADO_CONTRATO.ForeColor = Color.Green;
                        break;
                    case eEstadoContrato.PRORROGADO:
                        lbESTADO_CONTRATO.ForeColor = Color.Blue;
                        break;
                    case eEstadoContrato.REACTIVADO:
                        lbESTADO_CONTRATO.ForeColor = Color.Orange;
                        break;
                    case eEstadoContrato.CANCELADO:
                        lbESTADO_CONTRATO.ForeColor = Color.Crimson;
                        break;
                    case eEstadoContrato.VENCIDO:
                        lbESTADO_CONTRATO.ForeColor = Color.Red;
                        break;
                    case eEstadoContrato.ANULADO:
                        lbESTADO_CONTRATO.ForeColor = Color.DarkRed;
                        break;
                }
                lbESTADO_CONTRATO.Text = PRESTAMO.ESTADO_CONTRATO.ToString();


                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
                btnPrintKITCO.Enabled = true;

            }
            else
            {
                limpiarDatosPrestamo();
            }
        }





        private void txtDocCLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtDocCLI.Text.Trim() != string.Empty)
            {
                Cliente CLIENTE = new Cliente();
                switch (cbxBuscarPorCLI.SelectedIndex)
                {
                    case 0: //DUI
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByDui(txtDocCLI.Text.Trim()));
                        break;
                    case 1: //LICENCIA
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByLicencia(txtDocCLI.Text.Trim()));
                        break;
                    case 2://PASAPORTE
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByPasaporte(txtDocCLI.Text.Trim()));
                        break;
                    case 3://CARNET
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByCarnet(txtDocCLI.Text.Trim()));
                        break;
                    case 4: //CODIGO
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByCodigo(txtDocCLI.Text.Trim()));
                        break;
                }
                if (CLIENTE.COD_CLIENTE != null && CLIENTE.COD_CLIENTE != string.Empty)
                {
                    cargarDatosCliente(CLIENTE);
                }
                else
                {
                    MessageBox.Show("CLIENTE NO ENCONTRADO", "BUSCAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarDatosCliente();
                }
                e.Handled = true;
            }
        }




        private void btnCLI_Click(object sender, EventArgs e)
        {
            Catalogos.ClientesForm cartera;
            cartera = Catalogos.ClientesForm.Instance(this.Name);
            cartera.StartPosition = FormStartPosition.CenterParent;
            cartera.ShowDialog(this);
            if (cartera.WindowState == FormWindowState.Minimized)
            {
                cartera.WindowState = FormWindowState.Normal;
            }
        }




        private void btnTARJETA_Click(object sender, EventArgs e)
        {
            Catalogos.BuscarTarjetaForm tarjeta = new Catalogos.BuscarTarjetaForm(this.Name);
            tarjeta.ShowDialog();
        }




        public void cargarTarjeta(Tarjeta TARJETA)
        {
            switch (TARJETA.TIPO)
            {
                case eNIVEL.PRENDASAL:
                    Reglas reglas = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.PRENDASAL));
                    lbNUMTARJETA.ForeColor = Color.Black;
                    TARJETA.TASA_MENSUAL = reglas.TASA_MENSUAL;
                    TARJETA.PLAZO_CONTRATO = reglas.PLAZO_CONTRATO;
                    TARJETA.PLAZO_VENCIDO = reglas.PLAZO_VENCIDO;
                    break;
                case eNIVEL.AMIGO:
                    lbNUMTARJETA.ForeColor = Color.DarkGreen;
                    break;
                case eNIVEL.VIP:
                    lbNUMTARJETA.ForeColor = Color.DarkBlue;
                    break;
                case eNIVEL.MAYOREO:
                    lbNUMTARJETA.ForeColor = Color.DarkGoldenrod;
                    break;

            }
            lbNUMTARJETA.Text = TARJETA.NUMTARJETA;
            PRESTAMO.TASA_MENSUAL = TARJETA.TASA_MENSUAL;
            PRESTAMO.PLAZO_CONTRATO = TARJETA.PLAZO_CONTRATO;
            PRESTAMO.PLAZO_VENC = TARJETA.PLAZO_VENCIDO;
            PRESTAMO.NIVEL = TARJETA.TIPO;

            lbNIVEL.Text = PRESTAMO.NIVEL.ToString();
            numTASA.Value = PRESTAMO.TASA_MENSUAL;
            numPLAZO.Value = PRESTAMO.PLAZO_CONTRATO;
            numVENC.Value = PRESTAMO.PLAZO_VENC;

            actualizarPrecios();
        }




        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != "" && cbxSUCURSAL.SelectedIndex >= 0)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        PRESTAMO.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
                        PRESTAMO.DOCUMENTO = dbPrestamo.nextContratoPrestamo(PRESTAMO.COD_SUC);
                        txtDOCUMENTO.Text = PRESTAMO.DOCUMENTO;
                        break;
                }
            }
        }



        private void cbxTIPOPRESTAMO_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTOTAL.ReadOnly = false;
            PRESTAMO.TIPO = (eTipoPrestamo)cbxTIPOPRESTAMO.SelectedItem;
            if (ACCION == eOperacion.INSERT || ACCION == eOperacion.UPDATE)
            {
                PRESTAMO.ITEMS_PRESTAMO.Clear();
                if (PRESTAMO.TIPO == eTipoPrestamo.PRENDARIO)
                {
                    txtTOTAL.ReadOnly = true;
                }
            }
            if (PRESTAMO.TIPO == eTipoPrestamo.PRENDARIO)
            {
                btnADD.Enabled = true;
            }
            else
            {
                btnADD.Enabled = false;
            }
            
            calcularTotales();
        }


        private void actualizarPrecios()
        {
            switch (PRESTAMO.NIVEL)
            {
                case eNIVEL.PRENDASAL:
                    PRECIOS = dbPrendasal.getPrecios(eNIVEL.PRENDASAL);
                    lbNIVEL.ForeColor = Color.Black;
                    break;
                case eNIVEL.AMIGO:
                    PRECIOS = dbPrendasal.getPrecios(eNIVEL.AMIGO);
                    lbNIVEL.ForeColor = Color.DarkGreen;
                    break;
                case eNIVEL.VIP:
                    PRECIOS = dbPrendasal.getPrecios(eNIVEL.VIP);
                    lbNIVEL.ForeColor = Color.DarkBlue;
                    break;
                case eNIVEL.MAYOREO:
                    PRECIOS = dbPrendasal.getPrecios(eNIVEL.MAYOREO);
                    lbNIVEL.ForeColor = Color.DarkGoldenrod;
                    break;
            }
            lbNIVEL.Text = PRESTAMO.NIVEL.ToString();

            if (tblITEMS.Rows.Count > 0 && (string)cbxCategorias.SelectedValue == "ORO" && ACCION != eOperacion.SEARCH)
            {
                actualizarNivelPreciosItems();
            }
            
        }



        private void actualizarNivelPreciosItems()
        {
            foreach (DataGridViewRow row in tblITEMS.Rows)
            {
                string item = row.Cells["COD_ITEM"].FormattedValue.ToString();
                decimal cantidad = Decimal.Parse(row.Cells["CANTIDAD"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);
                decimal monto = Decimal.Round((decimal)cantidad * getPrecioKIL(item), 2, MidpointRounding.AwayFromZero);
                row.Cells["MONTO"].Value = monto;
            }
            calcularTotales();
        }





        private void btnPrecios_Click(object sender, EventArgs e)
        {
            Configuracion.PreciosForm precios;
            precios = Configuracion.PreciosForm.Instance();
            precios.StartPosition = FormStartPosition.CenterParent;
            precios.ShowDialog(this);
            if (precios.WindowState == FormWindowState.Minimized)
            {
                precios.WindowState = FormWindowState.Normal;
            }
        }




        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategorias.SelectedIndex >= 0 && cbxCategorias.ValueMember != string.Empty)
            {
                PRESTAMO.CATEGORIA = (string)cbxCategorias.SelectedValue;
                switch (PRESTAMO.CATEGORIA)
                {
                    case "ORO":
                        tblITEMS.Columns["COD_ITEM"].Visible = true;
                        tblITEMS.Columns["TIPO"].Visible = false;
                        tblITEMS.Columns["CANTIDAD"].HeaderText = "PESO";
                        break;
                    case "ARTICULO":
                        tblITEMS.Columns["COD_ITEM"].Visible = false;
                        tblITEMS.Columns["TIPO"].Visible = true;
                        tblITEMS.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
                        break;
                }

                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        PRESTAMO.ITEMS_PRESTAMO.Rows.Clear();
                        break;
                    case eOperacion.UPDATE:
                        PRESTAMO.ITEMS_PRESTAMO.Rows.Clear();
                        break;
                    case eOperacion.SEARCH:
                        tblITEMS.Rows.Clear();
                        break;

                }


            }
        }



        private void addItemPrestamo(object sender, EventArgs e)
        {
            AddInvItemForm insertItemForm = new AddInvItemForm();
            //Construir
            var txtCategoria = insertItemForm.Controls["txtCATEGORIA"];
            var txtCodigo = insertItemForm.Controls["txtCODIGO"];
            var lbCodItem = insertItemForm.Controls["lbCODITEM"];
            var cbxCodItem = (ComboBox)insertItemForm.Controls["cbxCODITEM"];
            var cbxTipo = (ComboBox)insertItemForm.Controls["cbxTIPO"];
            var lbMarca = insertItemForm.Controls["lbMARCA"];
            var cbxMarca = (ComboBox)insertItemForm.Controls["cbxMARCA"];
            var txtDescripcion = insertItemForm.Controls["txtDESCRIPCION"];
            var txtCantidad = insertItemForm.Controls["txtCANTIDAD"];
            var txtMonto = insertItemForm.Controls["txtMONTO"];

            insertItemForm.Text = "AGREGAR " + PRESTAMO.CATEGORIA;
            insertItemForm.PRECIOS = PRECIOS;
            insertItemForm.UNICO = HOME.Instance().datCATEGORIAS.Rows[cbxCategorias.SelectedIndex].Field<bool>("UNICO");

            if (insertItemForm.UNICO)
            {
                lbCodItem.Visible = false;
                cbxCodItem.Visible = false;
                lbMarca.Visible = true;
                cbxMarca.Visible = true;
            }
            else
            {
                cbxCodItem.DataSource = dbCatalogo.showCatalogo(PRESTAMO.CATEGORIA);
                if (((DataTable)cbxCodItem.DataSource).Rows.Count > 0)
                {
                    cbxCodItem.DisplayMember = "COD_ITEM";
                    cbxCodItem.ValueMember = "COD_ITEM";
                }
                lbCodItem.Visible = true;
                cbxCodItem.Visible = true;
                lbMarca.Visible = false;
                cbxMarca.Visible = false;
            }

            cbxTipo.DataSource = dbCatalogo.getTipoInv(PRESTAMO.CATEGORIA);
            if (((DataTable)cbxTipo.DataSource).Rows.Count > 0)
            {
                cbxTipo.DisplayMember = "TIPO";
                cbxTipo.ValueMember = "TIPO";
            }

            cbxMarca.DataSource = dbCatalogo.getMarcaInv(PRESTAMO.CATEGORIA);
            if (((DataTable)cbxMarca.DataSource).Rows.Count > 0)
            {
                cbxMarca.DisplayMember = "MARCA";
                cbxMarca.ValueMember = "MARCA";
            }

            txtCategoria.Text = PRESTAMO.CATEGORIA;
            txtCodigo.Text = PRESTAMO.DOCUMENTO + "-" + PRESTAMO.FECHA.ToString("ddMMyy");
            txtCantidad.Text = "0.0";
            txtMonto.Text = "0.00";

            

            if (insertItemForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (insertItemForm.UNICO)
                {
                    PRESTAMO.ITEMS_PRESTAMO.Rows.Add(txtCategoria.Text, txtCodigo.Text, txtCodigo.Text, cbxTipo.Text.ToUpper(), cbxMarca.Text.ToUpper(), txtDescripcion.Text, txtCantidad.Text, txtMonto.Text);
                }
                else
                {
                    PRESTAMO.ITEMS_PRESTAMO.Rows.Add(txtCategoria.Text, txtCodigo.Text, (string)cbxCodItem.SelectedValue, cbxTipo.Text.ToUpper(), cbxMarca.Text.ToUpper(), txtDescripcion.Text, txtCantidad.Text, txtMonto.Text);
                }

                calcularTotales();
            }

        }









        private void tblITEMS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                string columnName = this.tblITEMS.Columns[e.ColumnIndex].Name;
                switch (columnName)
                {
                    case "btnEditarItem":
                        Image icoEdit = Properties.Resources.edit_16;
                        e.Graphics.DrawImage(icoEdit, e.CellBounds.Left + 2, e.CellBounds.Top + 2);

                        tblITEMS.Rows[e.RowIndex].Height = icoEdit.Height + 5;
                        tblITEMS.Columns[e.ColumnIndex].Width = icoEdit.Width + 5;

                        break;
                    case "btnEliminarItem":
                        Image icoEliminar = Properties.Resources.menos;
                        e.Graphics.DrawImage(icoEliminar, e.CellBounds.Left + 2, e.CellBounds.Top + 2);

                        tblITEMS.Rows[e.RowIndex].Height = icoEliminar.Height + 5;
                        tblITEMS.Columns[e.ColumnIndex].Width = icoEliminar.Width + 5;

                        break;
                }
                e.Handled = true;
            }
        }

        private void tblITEMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = this.tblITEMS.Columns[e.ColumnIndex].Name;
                var row = PRESTAMO.ITEMS_PRESTAMO.Rows[tblITEMS.CurrentCell.RowIndex];
                switch (columnName)
                {
                    case "btnEditarItem":
                        AddInvItemForm editItemForm = new AddInvItemForm();
                        //Construir
                        var txtCategoria = editItemForm.Controls["txtCATEGORIA"];
                        var txtCodigo = editItemForm.Controls["txtCODIGO"];
                        var lbCodItem = editItemForm.Controls["lbCODITEM"];
                        var cbxCodItem = (ComboBox)editItemForm.Controls["cbxCODITEM"];
                        var cbxTipo = (ComboBox)editItemForm.Controls["cbxTIPO"];
                        var lbMarca = editItemForm.Controls["lbMARCA"];
                        var cbxMarca = (ComboBox)editItemForm.Controls["cbxMARCA"];
                        var txtDescripcion = editItemForm.Controls["txtDESCRIPCION"];
                        var txtCantidad = editItemForm.Controls["txtCANTIDAD"];
                        var txtMonto = editItemForm.Controls["txtMONTO"];

                        editItemForm.Text = "EDITAR " + row.Field<string>("CATEGORIA");
                        editItemForm.PRECIOS = PRECIOS;
                        editItemForm.UNICO = HOME.Instance().datCATEGORIAS.Rows[cbxCategorias.SelectedIndex].Field<bool>("UNICO");

                        if (editItemForm.UNICO)
                        {
                            lbCodItem.Visible = false;
                            cbxCodItem.Visible = false;
                            lbMarca.Visible = true;
                            cbxMarca.Visible = true;
                        }
                        else
                        {
                            cbxCodItem.DataSource = dbCatalogo.showCatalogo(PRESTAMO.CATEGORIA);
                            if (((DataTable)cbxCodItem.DataSource).Rows.Count > 0)
                            {
                                cbxCodItem.DisplayMember = "COD_ITEM";
                                cbxCodItem.ValueMember = "COD_ITEM";
                                cbxCodItem.SelectedValue = row.Field<string>("COD_ITEM");
                            }
                            lbCodItem.Visible = true;
                            cbxCodItem.Visible = true;
                            lbMarca.Visible = false;
                            cbxMarca.Visible = false;
                        }

                        cbxTipo.DataSource = dbCatalogo.getTipoInv(PRESTAMO.CATEGORIA);
                        if (((DataTable)cbxTipo.DataSource).Rows.Count > 0)
                        {
                            cbxTipo.DisplayMember = "TIPO";
                            cbxTipo.ValueMember = "TIPO";
                            cbxTipo.Text = row.Field<string>("TIPO");
                        }

                        cbxMarca.DataSource = dbCatalogo.getMarcaInv(PRESTAMO.CATEGORIA);
                        if (((DataTable)cbxMarca.DataSource).Rows.Count > 0)
                        {
                            cbxMarca.DisplayMember = "MARCA";
                            cbxMarca.ValueMember = "MARCA";
                            cbxMarca.Text = row.Field<string>("MARCA");
                        }

                        txtCategoria.Text = row.Field<string>("CATEGORIA");
                        txtCodigo.Text = PRESTAMO.DOCUMENTO + "-" + PRESTAMO.FECHA.ToString("ddMMyy");
                        txtDescripcion.Text = row.Field<string>("DESCRIPCION");
                        txtCantidad.Text = row.Field<decimal>("CANTIDAD").ToString();
                        txtMonto.Text = row.Field<decimal>("MONTO").ToString();

                        editItemForm.LIMITE = row.Field<decimal>("CANTIDAD") * getPrecioKIL(row.Field<string>("COD_ITEM"));

                        if (editItemForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (editItemForm.UNICO)
                            {
                                row.SetField<string>("CATEGORIA", txtCategoria.Text);
                                row.SetField<string>("CODIGO", txtCodigo.Text);
                                row.SetField<string>("COD_ITEM", txtCodigo.Text);
                                row.SetField<string>("TIPO", cbxTipo.Text.ToUpper());
                                row.SetField<string>("MARCA", cbxMarca.Text.ToUpper());
                                row.SetField<string>("DESCRIPCION", txtDescripcion.Text);
                                row.SetField<decimal>("CANTIDAD", Decimal.Parse(txtCantidad.Text));
                                row.SetField<decimal>("MONTO", Decimal.Parse(txtMonto.Text));
                            }
                            else
                            {
                                row.SetField<string>("CATEGORIA", txtCategoria.Text);
                                row.SetField<string>("CODIGO", txtCodigo.Text);
                                row.SetField<string>("COD_ITEM", cbxCodItem.Text);
                                row.SetField<string>("TIPO", cbxTipo.Text.ToUpper());
                                row.SetField<string>("MARCA", cbxMarca.Text.ToUpper());
                                row.SetField<string>("DESCRIPCION", txtDescripcion.Text);
                                row.SetField<decimal>("CANTIDAD", Decimal.Parse(txtCantidad.Text));
                                row.SetField<decimal>("MONTO", Decimal.Parse(txtMonto.Text));
                            }


                            calcularTotales();
                        }
                        break;
                    case "btnEliminarItem":
                        DialogResult eliminar = MessageBox.Show("¿Eliminar Item de la lista?", "ELIMINAR ITEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (eliminar == DialogResult.Yes)
                        {
                            PRESTAMO.ITEMS_PRESTAMO.Rows.RemoveAt(tblITEMS.CurrentCell.RowIndex);
                            calcularTotales();
                        }
                        break;
                }
            }
        }




        private Decimal getPrecioKIL(string item)
        {
            decimal costo = (decimal)0.00;
            foreach (DataRow row in PRECIOS.Rows)
            {
                if (row.Field<string>("KILATAJE") == item)
                {
                    costo = row.Field<decimal>("PRECIO");
                    break;
                }
            }
            return costo;
        }

        private void numTASA_ValueChanged(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    PRESTAMO.TASA_MENSUAL = Decimal.Round(numTASA.Value, 4, MidpointRounding.AwayFromZero);
                    calcularTotales();
                    break;
                case eOperacion.UPDATE:
                    PRESTAMO.TASA_MENSUAL = Decimal.Round(numTASA.Value, 4, MidpointRounding.AwayFromZero);
                    calcularTotales();
                    break;
            }
        }


        private void numPLAZO_ValueChanged(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    PRESTAMO.PLAZO_CONTRATO = (int)numPLAZO.Value;
                    break;
                case eOperacion.UPDATE:
                    PRESTAMO.PLAZO_CONTRATO = (int)numPLAZO.Value;
                    break;
            }
        }


        private void txtTOTAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto

            if (e.KeyChar == 46 && txtTOTAL.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTOTAL_Leave(object sender, EventArgs e)
        {
            PRESTAMO.TOTAL = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtTOTAL.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                PRESTAMO.TOTAL = Decimal.Round(valor, 2,MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTOTAL.Text = PRESTAMO.TOTAL.ToString("C2");
        }


        private void txtTOTAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtINTERES_MENSUAL.Text = PRESTAMO.INTERES_MENSUAL_INIT.ToString("C2");
                txtINTERES_DIARIO.Text = PRESTAMO.INTERES_DIARIO_INIT.ToString("C4");
                txtNOTA.Focus();
            }
        }




        private void calcularTotales()
        {
            if (PRESTAMO.TIPO != eTipoPrestamo.MUTUO)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        PRESTAMO.TOTAL = PRESTAMO.ITEMS_PRESTAMO.AsEnumerable().Select(r => r.Field<decimal>("MONTO")).Sum();
                        break;
                    case eOperacion.UPDATE:
                        PRESTAMO.TOTAL = PRESTAMO.ITEMS_PRESTAMO.AsEnumerable().Select(r => r.Field<decimal>("MONTO")).Sum();
                        break;
                }
            }
            txtTOTAL.Text = PRESTAMO.TOTAL.ToString("C2");
            txtINTERES_MENSUAL.Text = PRESTAMO.INTERES_MENSUAL_INIT.ToString("C2");
            txtINTERES_DIARIO.Text = PRESTAMO.INTERES_DIARIO_INIT.ToString("C4");
        }





       

        private bool validarPrestamo()
        {
            bool OK = true;
            try
            {
                if (PRESTAMO.COD_CLIENTE == null || PRESTAMO.COD_CLIENTE == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Seleccione Cliente para la transaccion", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (PRESTAMO.COD_SUC == null || PRESTAMO.COD_SUC == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("ELIJA SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (PRESTAMO.DOCUMENTO == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("NUMERO CONTRATO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (PRESTAMO.ITEMS_PRESTAMO.Rows.Count <= 0 && PRESTAMO.TIPO != eTipoPrestamo.MUTUO)
                {
                    OK = false;
                    MessageBox.Show("INGRESE DETALLE DE PRESTAMO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (PRESTAMO.TOTAL <= 0)
                {
                    OK = false;
                    MessageBox.Show("TOTAL DE PRESTAMO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR CONTRATO", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }







        private void GUARDAR(object sender, EventArgs e)
        {
            txtTOTAL.Focus();
            if (validarPrestamo())
            {
                PRESTAMO.NOTA = txtNOTA.Text;
                ConfirmarContrato confirmar = new ConfirmarContrato(PRESTAMO, ACCION);
                confirmar.ShowDialog();
            }
        }






        private void CANCELAR(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    NUEVO(null, null);
                    break;
                case eOperacion.UPDATE:
                    ACCION = eOperacion.SEARCH;
                    PRESTAMO = SELECTED.Copy();
                    cargarDatosCliente(null);
                    cargarDatosPrestamo();
                    bloquear();
                    
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnLog.Enabled = true;
                    btnReimprimir.Enabled = true;
                    btnPrintKITCO.Enabled = true;
                    break;
            }
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (PRESTAMO != null)
            {
                ACCION = eOperacion.UPDATE;
                desbloquear();

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnLog.Enabled = false;
                btnReimprimir.Enabled = false;
                btnPrintKITCO.Enabled = false;
            }
            else
            {
                MessageBox.Show("CONTRATO NO CARGADO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void ELIMINAR(object sender, EventArgs e)
        {
            if (PRESTAMO != null)
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el CONTRATO " + PRESTAMO.DOCUMENTO + " con FECHA:" + PRESTAMO.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR PRESTAMO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        ACCION = eOperacion.DELETE;
                        if (dbPrestamo.delete(PRESTAMO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            NUEVO(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("CONTRATO NO CARGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }




        private void BUSCAR(object sender, EventArgs e)
        {
            string numCONT = Controles.InputBox("CONTRATO #: ","AUTORIZACION");
            if (numCONT != "")
            {
                if (buscarContrato(numCONT))
                {
                    MessageBox.Show("CONTRATO # " + PRESTAMO.DOCUMENTO + " CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CONTRATO NO ENCONTRADO", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }




        public void buscarCargarContrato(string contrato)
        {
            if (buscarContrato(contrato))
            {
                MessageBox.Show("CONTRATO # " + PRESTAMO.DOCUMENTO + " CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CONTRATO NO ENCONTRADO", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public bool buscarContrato(string documento)
        {
            bool OK = false;
            SELECTED = Prestamo.ConvertToPrestamo(dbPrestamo.getContratoByDoc(documento));
            if (SELECTED != null)
            {
                ACCION = eOperacion.SEARCH;
                SELECTED.ITEMS_PRESTAMO = dbPrestamo.getItemsPrestamo(SELECTED);
                if (SELECTED.ITEMS_PRESTAMO == null || SELECTED.ITEMS_PRESTAMO.Rows.Count == 0)
                {
                    SELECTED.ITEMS_PRESTAMO = new Prestamo().ITEMS_PRESTAMO.Copy();
                }
                
                PRESTAMO = SELECTED.Copy();
                cargarDatosCliente(null);
                cargarDatosPrestamo();
                bloquear();
                actualizarPrecios();
                OK = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
                btnPrintKITCO.Enabled = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }



        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            Reportes.REstadoCuentaForm EC;
            EC = Reportes.REstadoCuentaForm.Instance(this.Name);
            EC.StartPosition = FormStartPosition.CenterParent;
            EC.ShowDialog(this);
            if (EC.WindowState == FormWindowState.Minimized)
            {
                EC.WindowState = FormWindowState.Normal;
            }
        }


        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (PRESTAMO != null)
            {
                ImprimirContratoPrestamo_Plantilla_2();
            }
        }


        public void ImprimirContratoPrestamo_Plantilla_2()
        {
            viewerCONTRATO.Clear();
            if (PRESTAMO != null)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(PRESTAMO.COD_SUC).Copy();

                    ReportParameter[] parameters = new ReportParameter[18];
                    parameters[0] = new ReportParameter("SUCURSAL", SUC.SUCURSAL);
                    parameters[1] = new ReportParameter("DireccionSUC", SUC.DIRECCION + " ," + SUC.DEPTO);
                    parameters[2] = new ReportParameter("CONTRATO", PRESTAMO.DOCUMENTO);
                    parameters[3] = new ReportParameter("CLIENTE", PRESTAMO.CLIENTE);
                    parameters[4] = new ReportParameter("EdadCLI", PRESTAMO.EDAD + "");
                    parameters[5] = new ReportParameter("DocCLI", ((eTipoDocCliente)cbxBuscarPorCLI.SelectedItem).ToString() + ": " + txtDocCLI.Text);
                    parameters[6] = new ReportParameter("NitCLI", PRESTAMO.NIT);
                    parameters[7] = new ReportParameter("DireccionCLI", PRESTAMO.DIRECCION_CLI + ", " + PRESTAMO.DOMICILIO_CLI + ", " + PRESTAMO.DEPTO_CLI);
                    parameters[8] = new ReportParameter("TOTAL", PRESTAMO.TOTAL.ToString("C2"));
                    parameters[9] = new ReportParameter("TASA", PRESTAMO.TASA_MENSUAL + "");
                    parameters[10] = new ReportParameter("INTERES", PRESTAMO.INTERES_MENSUAL_INIT.ToString("C2"));
                    parameters[11] = new ReportParameter("GARANTIA", PRESTAMO.ARTICULO);
                    parameters[12] = new ReportParameter("DIAS", PRESTAMO.FECHA.Date.ToString("dd"));
                    parameters[13] = new ReportParameter("MES", PRESTAMO.FECHA.Date.ToString("MMMM").ToUpper());
                    parameters[14] = new ReportParameter("ANIO", PRESTAMO.FECHA.Date.ToString("yyyy"));
                    parameters[15] = new ReportParameter("PLAZO", HOME.Instance().convertirNumeroLetra(PRESTAMO.PLAZO_VENC).ToLower());
                    parameters[16] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));
                    parameters[17] = new ReportParameter("FechaPrimerPago", PRESTAMO.FECHA_VENC_INIT.ToShortDateString() + "");

                    viewerCONTRATO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ContratoPrestamo2.rdlc";
                    viewerCONTRATO.LocalReport.SetParameters(parameters);
                    viewerCONTRATO.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR CONTRATO DE PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
        }


        public void ImprimirContratoPrestamo_Plantilla_1()
        {
            viewerCONTRATO.Clear();
            if (PRESTAMO != null)
            {
                Sucursal SUC = HOME.Instance().getSucursal(PRESTAMO.COD_SUC).Copy();

                ReportParameter[] parameters = new ReportParameter[23];
                parameters[0] = new ReportParameter("Sucursal", SUC.SUCURSAL);
                parameters[1] = new ReportParameter("DireccionSUC", SUC.DIRECCION);
                parameters[2] = new ReportParameter("TelSUC", "TEL: " + SUC.TEL);
                parameters[3] = new ReportParameter("NumCONTRATO", PRESTAMO.DOCUMENTO);
                parameters[4] = new ReportParameter("CLIENTE", PRESTAMO.CLIENTE);
                parameters[5] = new ReportParameter("EdadCLI", PRESTAMO.EDAD + "");
                parameters[6] = new ReportParameter("DomicilioCLI", PRESTAMO.DOMICILIO_CLI);
                parameters[7] = new ReportParameter("DocCLI", ((eTipoDocCliente)cbxBuscarPorCLI.SelectedItem).ToString() + ": " + txtDocCLI.Text);
                parameters[8] = new ReportParameter("ExpCLI", PRESTAMO.EXTENDIDO);
                parameters[9] = new ReportParameter("DireccionCLI", PRESTAMO.DIRECCION_CLI);
                parameters[10] = new ReportParameter("TelCLI", PRESTAMO.TEL_CLI);
                parameters[11] = new ReportParameter("TOTAL", PRESTAMO.TOTAL.ToString("C2"));
                parameters[12] = new ReportParameter("INTERES", PRESTAMO.INTERES_MENSUAL_INIT.ToString("C2"));
                parameters[13] = new ReportParameter("PLAZO", PRESTAMO.PLAZO_CONTRATO+"");
                parameters[14] = new ReportParameter("PlazoVenc", PRESTAMO.PLAZO_VENC + "");
                parameters[15] = new ReportParameter("FechaVenc",PRESTAMO.FECHA_VENC_INIT.ToString("dd/MM/yyyy"));
                parameters[16] = new ReportParameter("ARTICULO", PRESTAMO.ARTICULO);
                parameters[17] = new ReportParameter("MUNICIPIO", SUC.MUNICIPIO);
                parameters[18] = new ReportParameter("DIAS", PRESTAMO.FECHA.Date.ToString("dd"));
                parameters[19] = new ReportParameter("MES", PRESTAMO.FECHA.Date.ToString("MMMM").ToUpper());
                parameters[20] = new ReportParameter("ANIO", PRESTAMO.FECHA.Date.ToString("yyyy"));
                parameters[21] = new ReportParameter("EMPLEADO", PRESTAMO.RESPONSABLE);
                parameters[22] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));
                    
                viewerCONTRATO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ContratoPrestamo1.rdlc";
                viewerCONTRATO.LocalReport.SetParameters(parameters);
                viewerCONTRATO.RefreshReport();
            }
        }


        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerCONTRATO.PrintDialog();
            }
        }





        private void btnPrintKITCO_Click(object sender, EventArgs e)
        {
            if (PRESTAMO != null)
            {
                try
                {
                    DataTable KITCO = dbPrestamo.getKITCO(PRESTAMO);
                    dSKITCO.Clear();

                    foreach (DataRow row in KITCO.Rows)
                    {
                        dSKITCO.KITCO.AddKITCORow(row.Field<string>("KILATAJE"), row.Field<decimal>("PESO"), row.Field<decimal>("PRECIO"), row.Field<decimal>("MONTO"));
                    }
                    bindingKITCO.DataSource = dSKITCO.KITCO;
                    if (dSKITCO.KITCO.Count > 0)
                    {
                        viewerCONTRATO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.KITCO.rdlc";
                        viewerCONTRATO.LocalReport.DataSources.Clear();
                        viewerCONTRATO.LocalReport.DataSources.Add(new ReportDataSource("KITCO", bindingKITCO));
                        viewerCONTRATO.RefreshReport();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR al imprimir Detalle KITCO .... ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }





        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }

        

        



        



    }
}
