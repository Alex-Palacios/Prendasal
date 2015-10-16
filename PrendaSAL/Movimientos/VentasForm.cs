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
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class VentasForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static VentasForm frmInstance = null;

        public static VentasForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new VentasForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private VentaController dbVenta;
        private DBCliente dbCliente;
        private DBCatalogo dbCatalogo;

        private eOperacion ACCION;
        public Cliente CLIENTE;
        public Venta SELECTED;

        public DataTable ITEMS_VENTA;

        public eNIVEL NIVEL;
        public Reglas REGLAS;
        public Tarjeta TARJETA;

        private decimal SUMAS;
        private decimal DESCUENTO;
        private decimal TOTAL;


        public VentasForm()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbCliente = new DBCliente();
            dbVenta= new VentaController();
            dbCatalogo = new DBCatalogo();

            ITEMS_VENTA = new DataTable();
            ITEMS_VENTA.Columns.Add("CATEGORIA").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("COD_ITEM").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Double");
            ITEMS_VENTA.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("PRECIO_UNIT").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("MONTO").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("CUENTA").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("TAX").DataType = System.Type.GetType("System.Int32");
            ITEMS_VENTA.Columns.Add("PRECIO_IMP").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("MONTO_IMP").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("INV").DataType = System.Type.GetType("System.Int32"); 
            ITEMS_VENTA.Columns.Add("VALUO_UNIT").DataType = System.Type.GetType("System.Decimal");
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

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P8")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscar.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }
        }


        private void VentasForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblITEMS.AutoGenerateColumns = false;
            cbxBuscarPorCLI.DataSource = Enum.GetValues(new eTipoDocCliente().GetType());

            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "CODIGO";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            List<eTipoDocVenta> doc = new List<eTipoDocVenta>();
            doc.Add(eTipoDocVenta.FCF);
            cbxTIPODOC.DataSource = doc;



            ((DataGridViewComboBoxColumn)tblITEMS.Columns["CATEGORIA"]).DataSource = Enum.GetValues(new eCategoria().GetType());

           

            NUEVO(null, null);
            txtDocCLI.Focus();
        }



        private void bloquear()
        {
            grbCLIENTE.Enabled = false;
            grbVENTA.Enabled = false;
            grbDETALLE.Enabled = false;
        }


        private void desbloquear()
        {
            grbCLIENTE.Enabled = true;
            grbVENTA.Enabled = true;
            grbDETALLE.Enabled = true;
            tblITEMS.ReadOnly = false;
            tblITEMS.Columns["CATEGORIA"].ReadOnly = true;
            tblITEMS.Columns["ITEM"].ReadOnly = true;
            tblITEMS.Columns["CANTIDAD"].ReadOnly = true;
            tblITEMS.Columns["DESCRIPCION"].ReadOnly = true;
            tblITEMS.Columns["PRECIO_UNIT"].ReadOnly = true;
            tblITEMS.Columns["MONTO"].ReadOnly = true;
            tblITEMS.Columns["CUENTA"].ReadOnly = true;
            tblITEMS.Columns["TAX"].ReadOnly = true;
            tblITEMS.Columns["PRECIO_IMP"].ReadOnly = true;
            tblITEMS.Columns["INV"].ReadOnly = true;
        }



        private void limpiarCliente()
        {
            txtCodigoCLI.Text = "";
            txtDocCLI.Text = "";
            txtExpCLI.Text = "";
            txtClienteCLI.Text = "";
            txtEdadCLI.Text = "";
            txtTelCLI.Text = "";
            txtDomicilioCLI.Text = "";
            txtDireccionCLI.Text = "";
        }


        private void limpiarVenta()
        {
            txtNUM_DOC.Text = "";
            dateVenta.Value = HOME.Instance().FECHA_SISTEMA;
            SUMAS = (decimal)0.00;
            DESCUENTO = (decimal)0.00;
            TOTAL = (decimal)0.00;
            lbSUMAS.Text = SUMAS.ToString("C2");
            txtDESCUENTO.Text = DESCUENTO.ToString("C2");
            txtTOTAL.Text = TOTAL.ToString("C2");
            ITEMS_VENTA.Rows.Clear();
            tblITEMS.DataSource = ITEMS_VENTA;
        }


        public void cargarItems()
        {
            tblITEMS.DataSource = ITEMS_VENTA;
            calcularTotales();
        }


        public void cargarCliente()
        {
            if (CLIENTE != null)
            {
                txtCodigoCLI.Text = CLIENTE.COD_CLIENTE;
                txtClienteCLI.Text = CLIENTE.CLIENTE;
                if (CLIENTE.EDAD != null)
                {
                    txtEdadCLI.Text = CLIENTE.EDAD + " AÑOS";
                }
                else
                {
                    txtEdadCLI.Text = "N/A";
                }
                if (CLIENTE.DUI != null && CLIENTE.DUI != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.DUI;
                    txtDocCLI.Text = CLIENTE.DUI;
                }
                else if (CLIENTE.LICENCIA != null && CLIENTE.LICENCIA != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.LICENCIA;
                    txtDocCLI.Text = CLIENTE.LICENCIA;
                }
                else if (CLIENTE.PASAPORTE != null && CLIENTE.PASAPORTE != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.PASAPORTE;
                    txtDocCLI.Text = CLIENTE.PASAPORTE;
                }
                else if (CLIENTE.CARNET != null && CLIENTE.CARNET != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.CARNET;
                    txtDocCLI.Text = CLIENTE.CARNET;
                }
                if (CLIENTE.EXT != null)
                {
                    txtExpCLI.Text = CLIENTE.EXT;
                }
                else
                {
                    txtExpCLI.Text = "N/A";
                }
                txtTelCLI.Text = CLIENTE.TEL;
                if (CLIENTE.COD_MUNICIPIO != null)
                {
                    txtDomicilioCLI.Text = CLIENTE.DOMICILIO;
                }
                else
                {
                    txtDomicilioCLI.Text = "N/A";
                }
                txtDireccionCLI.Text = CLIENTE.DIRECCION;
                actualizarParametros();
            }
            else
            {
                limpiarCliente();
                MessageBox.Show("CLIENTE NO ENCONTRADO", "Error al cargar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        public void actualizarParametros()
        {
            switch (NIVEL)
            {
                case eNIVEL.PRENDASAL:
                    REGLAS = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.PRENDASAL));
                    lbNIVEL.ForeColor = Color.Black;
                    break;
                case eNIVEL.AMIGO:
                    REGLAS = new Reglas();
                    REGLAS.NIVEL = TARJETA.TIPO;
                    REGLAS.TASA_MENSUAL = TARJETA.TASA_MENSUAL;
                    REGLAS.PLAZO_CONTRATO = TARJETA.PLAZO_CONTRATO;
                    REGLAS.PLAZO_VENCIDO = TARJETA.PLAZO_VENCIDO;
                    REGLAS.DESC_COMPRA = TARJETA.DESC_COMPRA;
                    REGLAS.DESC_INTERES = TARJETA.DESC_INTERES;
                    lbNIVEL.ForeColor = Color.DarkGreen;
                    break;
                case eNIVEL.VIP:
                    REGLAS = new Reglas();
                    REGLAS.NIVEL = TARJETA.TIPO;
                    REGLAS.TASA_MENSUAL = TARJETA.TASA_MENSUAL;
                    REGLAS.PLAZO_CONTRATO = TARJETA.PLAZO_CONTRATO;
                    REGLAS.PLAZO_VENCIDO = TARJETA.PLAZO_VENCIDO;
                    REGLAS.DESC_COMPRA = TARJETA.DESC_COMPRA;
                    REGLAS.DESC_INTERES = TARJETA.DESC_INTERES;
                    lbNIVEL.ForeColor = Color.DarkBlue;
                    break;
            }
            lbNIVEL.Text = NIVEL.ToString();
            calcularTotales();
            
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




        private void txtDocCLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtDocCLI.Text.Trim() != string.Empty)
            {
                CLIENTE = null;
                switch (cbxBuscarPorCLI.SelectedIndex)
                {
                    case 0: //DUI
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByDui(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 0;
                            txtDocCLI.Text = CLIENTE.DUI;
                            NIVEL = eNIVEL.PRENDASAL;
                            actualizarParametros();
                        }
                        break;
                    case 1: //LICENCIA
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByLicencia(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 1;
                            txtDocCLI.Text = CLIENTE.LICENCIA;
                            NIVEL = eNIVEL.PRENDASAL;
                            actualizarParametros();
                        }
                        break;
                    case 2://PASAPORTE
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByPasaporte(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 2;
                            txtDocCLI.Text = CLIENTE.PASAPORTE;
                            NIVEL = eNIVEL.PRENDASAL;
                            actualizarParametros();
                        }
                        break;
                    case 3://CARNET
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByCarnet(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 3;
                            txtDocCLI.Text = CLIENTE.CARNET;
                            NIVEL = eNIVEL.PRENDASAL;
                            actualizarParametros();
                        }
                        break;
                    case 4: //CODIGO
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByCodigo(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 4;
                            txtDocCLI.Text = CLIENTE.COD_CLIENTE;
                            NIVEL = eNIVEL.PRENDASAL;
                            actualizarParametros();
                        }
                        break;
                    case 5: //TARJETA

                        break;
                }
                e.Handled = true;
            }
        }




        private void cargarVentaSelected()
        {
            if (SELECTED != null)
            {
                limpiarCliente();
                limpiarVenta();
                bloquear();
                NIVEL = SELECTED.NIVEL;
                TARJETA = new Tarjeta();
                TARJETA.TIPO = SELECTED.NIVEL;
                actualizarParametros();
                CLIENTE = SELECTED.CLIENTE;
                cargarCliente();
                cbxSUCURSAL.SelectedValue = SELECTED.COD_SUC;
                cbxTIPODOC.SelectedItem = SELECTED.TIPO_DOC;
                txtNUM_DOC.Text = SELECTED.DOCUMENTO;
                dateVenta.Value = SELECTED.FECHA;
                NIVEL = SELECTED.NIVEL;
                ITEMS_VENTA = dbVenta.GET_ITEMS_VENTA(SELECTED);
                tblITEMS.DataSource = ITEMS_VENTA;
                SUMAS = SELECTED.SUMAS;
                DESCUENTO = SELECTED.DESCUENTO;
                TOTAL = SELECTED.TOTAL;
                txtDESCUENTO.Text = SELECTED.DESCUENTO.ToString("C2");
                txtTOTAL.Text = SELECTED.TOTAL.ToString("C2");
                txtNOTA.Text = SELECTED.NOTA;
                
                
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
            }
        }


        private void calcularTotales()
        {
            SUMAS = (decimal)0.00;
            TOTAL = (decimal)0.00;
            DESCUENTO = (decimal)0.00;
            SUMAS = tblITEMS.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["MONTO_IMP"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            DESCUENTO = Decimal.Round((decimal)REGLAS.DESC_COMPRA*SUMAS/100, 2);
            TOTAL = SUMAS - DESCUENTO;
            lbSUMAS.Text = SUMAS.ToString("C2");
            txtDESCUENTO.Text = DESCUENTO.ToString("C2");
            txtTOTAL.Text = TOTAL.ToString("C2");
        }




        public void NUEVO(object sender, EventArgs e)
        {
            SELECTED = null;
            ACCION = eOperacion.INSERT;
            limpiarCliente();
            limpiarVenta();
            desbloquear();
            NIVEL = eNIVEL.PRENDASAL;
            actualizarParametros();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;

            txtDocCLI.Focus();
        }




        public bool validarVenta()
        {
            bool OK = true;
            try
            {
                if (CLIENTE == null || txtCodigoCLI.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Seleccione Cliente para la transaccion", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (cbxSUCURSAL.SelectedIndex < 0)
                {
                    OK = false;
                    MessageBox.Show("ELIJA SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (txtNUM_DOC.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("NUMERO DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (TOTAL <= 0)
                {
                    OK = false;
                    MessageBox.Show("TOTAL DE VENTA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                OK = validarItemsVenta();
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR VENTA", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }




        public bool validarItemsVenta()
        {
            bool OK = true;
            if (tblITEMS.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tblITEMS.Rows)
                {
                    if (row.Cells["CANTIDAD"].Value == null || Double.Parse(row.Cells["CANTIDAD"].Value.ToString()) < 0)
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("CANTIDAD INVALIDA EN DETALLE DE VENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["ITEM"].Value == null || (string)row.Cells["ITEM"].Value == "-----")
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("PRODUCTO NO ESPECIFICADO EN DETALLE DE VENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["DESCRIPCION"].Value == null || row.Cells["DESCRIPCION"].Value.ToString().Trim() == string.Empty)
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("DESCRIPCION VACIO EN DETALLE DE VENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["MONTO"].Value == null || Decimal.Parse(row.Cells["MONTO"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) <= 0)
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("MONTO INVALIDO EN DETALLE DE VENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
            else
            {
                OK = false;
                MessageBox.Show("DETALLE DE VENTA VACIO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }




        private Venta buildVENTA()
        {
            Venta v = new Venta();
            v.NIVEL = NIVEL;
            v.NAT_VENTA = eNaturalezaVenta.VENTA;
            v.COD_CLIENTE = CLIENTE.COD_CLIENTE;
            v.CLIENTE = CLIENTE;
            v.FECHA = dateVenta.Value;
            v.TIPO_DOC = (eTipoDocVenta) cbxTIPODOC.SelectedItem;
            v.DOCUMENTO = txtNUM_DOC.Text.Trim();
            v.TIPO_VENTA = eTipoVenta.CONTADO;
            v.SUMAS = SUMAS;
            v.TOTAL_IMP = (decimal)0.00;
            v.DESCUENTO = DESCUENTO;
            v.TOTAL = TOTAL;
            if (cbxSUCURSAL.SelectedIndex >= 0)
            {
                v.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
            }
            v.NOTA = txtNOTA.Text;
            v.ITEMS_VENTA = tblITEMS.Rows;
            return v;
        }




        private void GUARDAR(object sender, EventArgs e)
        {
            Venta v = new Venta();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    txtTOTAL.Focus();
                    if (validarVenta())
                    {
                        v = buildVENTA();
                        ConfirmarVenta confirmar = new ConfirmarVenta(v, ACCION);
                        confirmar.ShowDialog();
                    }
                    break;
                case eOperacion.UPDATE:
                    txtTOTAL.Focus();
                    if (validarVenta())
                    {
                        v = buildVENTA();
                        v.ID_VENTA = SELECTED.ID_VENTA;
                        v.ESTADO = SELECTED.ESTADO;
                        v.INIT_BALANCE = SELECTED.INIT_BALANCE;
                        ConfirmarVenta confirmar = new ConfirmarVenta(v, ACCION);
                        confirmar.ShowDialog();
                    }
                    break;
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
                    cargarVentaSelected();
                    bloquear();
                    break;
            }
        }





        private void EDITAR(object sender, EventArgs e)
        {
            if (SELECTED != null && !SELECTED.INIT_BALANCE)
            {
                ACCION = eOperacion.UPDATE;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnLog.Enabled = false;
                btnReimprimir.Enabled = false;
                desbloquear();
            }
            else
            {
                MessageBox.Show("VENTA HISTORICA O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void ELIMINAR(object sender, EventArgs e)
        {
            if (SELECTED != null && !SELECTED.INIT_BALANCE)
            {
                ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la VENTA " + SELECTED.TIPO_DOC.ToString() + " " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR VENTA REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                SELECTED.NOTA_CAMBIO = cambioNota;
                                if (dbVenta.eliminarVentaPRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    NUEVO(null, null);
                                }
                            }
                            else
                            {
                                MessageBox.Show("INGRESE UNA NOTA ACLARATORIA DE LA ELIMINACION", "REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("VENTA HISTORICA O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }






        public void buscarVenta(DateTime fecha,eTipoDocVenta tipo,string documento)
        {
            try
            {
                SELECTED = dbVenta.findByVentaPRENDASAL(fecha,tipo,documento);
                if (SELECTED != null)
                {
                    cargarVentaSelected();
                }
            }
            catch (Exception ex) { }
        }




        private void BUSCAR(object sender, EventArgs e)
        {
            string numFACTURA = Controles.InputBox("NUMERO DE DOCUMENTO :", "BUSCAR");
            if (numFACTURA != "")
            {
                SELECTED = dbVenta.findByVentaPRENDASAL(null,(eTipoDocVenta)cbxTIPODOC.SelectedItem,numFACTURA);
                if (SELECTED != null)
                {
                    cargarVentaSelected();
                    MessageBox.Show("VENTA # " + SELECTED.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("VENTA NO ENCONTRADA", "NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }



        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.PREVIEW;
                ImprimirFactura();
            }
        }

        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }





        private void addItemVenta(object sender, EventArgs e)
        {
            if (tblITEMS.Rows.Count <= 5)
            {
                ExistenciasForm carrito = ExistenciasForm.Instance();
                carrito.SUC = (string)cbxSUCURSAL.SelectedValue;
                carrito.ShowDialog();
            }
            else
            {
                MessageBox.Show("NUMERO DE ITEMS POR VENTA SUPERADO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void removeItemVenta(object sender, EventArgs e)
        {
            if (tblITEMS.DataSource != null && tblITEMS.CurrentCell != null && tblITEMS.CurrentCell.RowIndex >= 0 && tblITEMS.CurrentCell.ColumnIndex >= 0)
            {
                tblITEMS.Rows.Remove(tblITEMS.Rows[tblITEMS.CurrentCell.RowIndex]);
                calcularTotales();
            }

        }



        private void tblITEMS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tblITEMS.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
        }


        private void tblITEMS_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string columnName = tblITEMS.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {

                case "ITEM":
                    if (tblITEMS.Rows[e.RowIndex].Cells["CATEGORIA"].Value == DBNull.Value || tblITEMS.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString() == "-----")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
                case "CANTIDAD":
                    if (tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value == DBNull.Value || tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value.ToString() == "-----")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
                case "DESCRIPCION":
                    if (tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value == DBNull.Value || tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value.ToString() == "-----")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
                case "MONTO_IMP":
                    if (tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value == DBNull.Value || tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value.ToString() == "-----")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
            }
        }



        private void tblITEMS_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = tblITEMS.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "CANTIDAD":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        double valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblITEMS.Rows[e.RowIndex].ErrorText = "Columna CANTIDAD Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Double.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblITEMS.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblITEMS.Rows[e.RowIndex].ErrorText = "CANTIDAD debe ser mayor a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
                case "MONTO_IMP":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        decimal valor;
                        string categoria = tblITEMS.Rows[e.RowIndex].Cells["CATEGORIA"].FormattedValue.ToString();

                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblITEMS.Rows[e.RowIndex].ErrorText = "Columna MONTO Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblITEMS.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblITEMS.Rows[e.RowIndex].ErrorText = "MONTO debe ser mayor a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (tblITEMS.Rows[e.RowIndex].Cells["VALUO_UNIT"].FormattedValue != null && tblITEMS.Rows[e.RowIndex].Cells["VALUO_UNIT"].FormattedValue != "")
                        {
                            decimal precioAuto = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["VALUO_UNIT"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);

                            if (precioAuto > 0 && valor < precioAuto)
                            {
                                tblITEMS.Rows[e.RowIndex].ErrorText = "MONTO DEL ARTICULO NO ES EL AUTORIZADO";
                                System.Media.SystemSounds.Beep.Play();
                                e.Cancel = true;
                            }
                        }
                        
                    }
                    break;
            }
        }



        private void tblITEMS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tblITEMS.Rows[e.RowIndex].ErrorText = String.Empty;
            if (e.RowIndex >= 0)
            {
                double cantidad = Double.Parse(tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);
                decimal precio = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);
                decimal monto = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["MONTO_IMP"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);
                eCategoria categoria = (eCategoria) tblITEMS.Rows[e.RowIndex].Cells["CATEGORIA"].Value;
                string item = tblITEMS.Rows[e.RowIndex].Cells["ITEM"].FormattedValue.ToString();

                string columnName = tblITEMS.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "CATEGORIA":
                        tblITEMS.Rows[e.RowIndex].Cells["ITEM"].Value = null;
                        DataTable itemsInv = new DataTable();
                        itemsInv = dbCatalogo.showCatalogo(categoria);
                        if (itemsInv.Rows.Count == 0)
                        {
                            itemsInv.Columns.Add("COD_ITEM");
                        }
                        DataRow R = itemsInv.NewRow();
                        R.SetField<string>("COD_ITEM", "-----");
                        itemsInv.Rows.InsertAt(R, 0);

                        ((DataGridViewComboBoxCell)tblITEMS.Rows[e.RowIndex].Cells["ITEM"]).DataSource = itemsInv.Copy();
                        ((DataGridViewComboBoxCell)tblITEMS.Rows[e.RowIndex].Cells["ITEM"]).DisplayMember = "COD_ITEM";

                        tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].Value = 0.0;
                        tblITEMS.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = "";
                        tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].Value = 0.00;
                        tblITEMS.Rows[e.RowIndex].Cells["PRECIO_IMP"].Value = 0.00;
                        tblITEMS.Rows[e.RowIndex].Cells["MONTO_IMP"].Value = 0.00;
                        tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = 0.00;
                        break;
                    case "ITEM":
                        if (item == "-----")
                        {
                            tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].Value = 0.0;
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_IMP"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["MONTO_IMP"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = 0.00;
                        }
                        else
                        {
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_IMP"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["MONTO_IMP"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = 0.00;
                        }
                        break;
                    case "CANTIDAD":
                        monto =(decimal) 0.00;
                        tblITEMS.Rows[e.RowIndex].Cells["MONTO_IMP"].Value = monto;
                        tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = monto;
                        if (cantidad > 0)
                        {
                            decimal cost = Decimal.Round(monto / (decimal)cantidad, 2);
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].Value = cost;
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_IMP"].Value = cost;
                        }
                        else
                        {
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].Value = 0.00;
                            tblITEMS.Rows[e.RowIndex].Cells["PRECIO_IMP"].Value = 0.00;
                        }
                        calcularTotales();
                        break;
                    case "MONTO_IMP":
                        tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = monto;
                        if (cantidad != 0.00)
                        {
                            precio = Decimal.Round(monto / (decimal)cantidad, 2);
                        }
                        else
                        {
                            precio = Decimal.Zero;
                        }
                        tblITEMS.Rows[e.RowIndex].Cells["PRECIO_UNIT"].Value = precio;
                        tblITEMS.Rows[e.RowIndex].Cells["PRECIO_IMP"].Value = precio;
                        calcularTotales();
                        break;
                }
            }
        }



        private void btnTARJETA_Click(object sender, EventArgs e)
        {
            Catalogos.BuscarTarjetaForm tarjeta = new Catalogos.BuscarTarjetaForm(this.Name);
            tarjeta.ShowDialog();
        }



        public void ImprimirFactura()
        {
            viewerFACTURA.Clear();
            if (SELECTED != null)
            {
                dSItemFCF.Clear();
                foreach(DataRow row in ITEMS_VENTA.Rows)
                {
                   dSItemFCF.ITEM.AddITEMRow(row.Field<double>("CANTIDAD").ToString(),row.Field<string>("DESCRIPCION"), row.Field<decimal>("MONTO_IMP"));
                }
                //RELLENAR ESPACIOS SIN OCUPAR
                for(int i = 1; i <= 5 ; i++){
                    if (i > ITEMS_VENTA.Rows.Count)
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "",Decimal.Zero);
                    }
                }
                //AGREGAR LINEA DESCUENTO
                if (SELECTED.DESCUENTO > 0)
                {
                    dSItemFCF.ITEM.AddITEMRow("", "DESCUENTO S/VENTA", -SELECTED.DESCUENTO);
                }
                else
                {
                    dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                }
                bindingFCF.DataSource = dSItemFCF.ITEM;

                ReportParameter[] parameters = new ReportParameter[7];
                parameters[0] = new ReportParameter("CLIENTE", SELECTED.CLIENTE.CLIENTE);
                parameters[1] = new ReportParameter("DIA", SELECTED.FECHA.Date.ToString("dd"));
                parameters[2] = new ReportParameter("MES", SELECTED.FECHA.Date.ToString("MMM").ToUpper());
                parameters[3] = new ReportParameter("ANIO", SELECTED.FECHA.Date.ToString("yyyy"));
                parameters[4] = new ReportParameter("SUMAS", SELECTED.SUMAS.ToString("C2"));
                parameters[5] = new ReportParameter("TOTAL", SELECTED.TOTAL.ToString("C2"));
                parameters[6] = new ReportParameter("LETRAS", HOME.Instance().convertirCantidadEnLetras(SELECTED.TOTAL));

                viewerFACTURA.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.FCF.rdlc";
                viewerFACTURA.LocalReport.DataSources.Clear();
                viewerFACTURA.LocalReport.DataSources.Add(new ReportDataSource("ITEM", bindingFCF));
                viewerFACTURA.LocalReport.SetParameters(parameters);
                viewerFACTURA.RefreshReport();
            }
        }



        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerFACTURA.PrintDialog();
            }
        }


    }
}
