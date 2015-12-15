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

        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBCliente dbCliente;
        private DBVenta dbVenta;
        private DBCatalogo dbCatalogo;

        private eOperacion ACCION;

        private Venta VENTA;
        private Venta SELECTED; 
        private Reglas REGLAS;
        public Tarjeta TARJETA;


        public VentasForm()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbCliente = new DBCliente();
            dbVenta = new DBVenta();
            dbCatalogo = new DBCatalogo();
            VENTA = new Venta();
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

            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.Enabled = true;
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
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            
            bloquear();
            NUEVO(null, null);
        }




        private void bloquear()
        {
            grbCLIENTE.Enabled = false;
            grbVENTA.Enabled = false;
            grbDETALLE.Enabled = false;
            tblITEMS.Columns["CODIGO"].ReadOnly = true;
            tblITEMS.Columns["COD_ITEM"].ReadOnly = true;
            tblITEMS.Columns["CANTIDAD"].ReadOnly = true;
            tblITEMS.Columns["DESCRIPCION"].ReadOnly = true;
            tblITEMS.Columns["MONTO"].ReadOnly = true;
            txtNOTA.ReadOnly = true;
        }


        private void desbloquear()
        {
            grbCLIENTE.Enabled = true;
            grbVENTA.Enabled = true;
            grbDETALLE.Enabled = true;
            tblITEMS.Columns["CODIGO"].ReadOnly = true;
            tblITEMS.Columns["COD_ITEM"].ReadOnly = true;
            tblITEMS.Columns["CANTIDAD"].ReadOnly = true;
            tblITEMS.Columns["DESCRIPCION"].ReadOnly = true;
            tblITEMS.Columns["MONTO"].ReadOnly = false;
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

        private void limpiarDatosVenta()
        {
            txtNUMVENTA.Text = string.Empty;
            lbDOCUMENTO.Text = string.Empty;
            tblITEMS.DataSource = null;
            lbNIVEL.Text = string.Empty;
            txtTOTAL.Text = string.Empty;
            txtNOTA.Text = string.Empty;
        }


        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            VENTA = new Venta();
            VENTA.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            VENTA.NUMVENTA = dbVenta.nextNumVenta(VENTA.COD_SUC);
            VENTA.FECHA = HOME.Instance().FECHA_SISTEMA;
            VENTA.NIVEL = eNIVEL.PRENDASAL;
            VENTA.TIPO = eTipoVenta.CONTADO;
            VENTA.TIPO_PAGO = eTipoPago.EFECTIVO;
            VENTA.CATEGORIA = eCategoria.ARTICULO;
            cargarDatosCliente(null);
            cargarDatosVenta();
            desbloquear();
            txtDocCLI.Focus();
            actualizarParametros();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;

        }






        public void cargarDatosCliente(Cliente CLIENTE)
        {
            if (CLIENTE != null && CLIENTE.COD_CLIENTE != null && CLIENTE.COD_CLIENTE != string.Empty)
            {
                VENTA.COD_CLIENTE = CLIENTE.COD_CLIENTE;
                VENTA.CLIENTE = CLIENTE.CLIENTE;
                VENTA.EDAD = CLIENTE.EDAD;
                VENTA.DUI = CLIENTE.DUI;
                VENTA.LICENCIA = CLIENTE.LICENCIA;
                VENTA.PASAPORTE = CLIENTE.PASAPORTE;
                VENTA.CARNET = CLIENTE.CARNET;
                VENTA.EXTENDIDO = CLIENTE.EXTENDIDO;
                VENTA.TEL_CLI = CLIENTE.TEL;
                VENTA.DOMICILIO_CLI = CLIENTE.DOMICILIO;
                VENTA.DIRECCION_CLI = CLIENTE.DIRECCION;
            }
            txtCodigoCLI.Text = VENTA.COD_CLIENTE;
            txtNombreCLI.Text = VENTA.CLIENTE;
            if (VENTA.DUI != null && VENTA.DUI != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.DUI;
                txtDocCLI.Text = VENTA.DUI;
            }
            else if (VENTA.LICENCIA != null && VENTA.LICENCIA != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.LICENCIA;
                txtDocCLI.Text = VENTA.LICENCIA;
            }
            else if (VENTA.PASAPORTE != null && VENTA.PASAPORTE != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.PASAPORTE;
                txtDocCLI.Text = VENTA.PASAPORTE;
            }
            else if (VENTA.CARNET != null && VENTA.CARNET != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.CARNET;
                txtDocCLI.Text = VENTA.CARNET;
            }
            else
            {
                txtDocCLI.Text = string.Empty;
            }
            txtEdadCLI.Text = VENTA.EDAD + "";
            txtExtCLI.Text = VENTA.EXTENDIDO;
            txtTelCLI.Text = VENTA.TEL_CLI;
            txtDomicilioCLI.Text = VENTA.DOMICILIO_CLI;
            txtDireccionCLI.Text = VENTA.DIRECCION_CLI;
        }




        private void cargarDatosVenta()
        {
            if (VENTA != null)
            {
                cbxSUCURSAL.SelectedValue = VENTA.COD_SUC;
                txtNUMVENTA.Text = VENTA.NUMVENTA;
                lbDOCUMENTO.Text = VENTA.DOCUMENTO;
                dateVenta.Value = VENTA.FECHA;
                lbNIVEL.Text = VENTA.NIVEL.ToString();
                tblITEMS.DataSource = null;
                tblITEMS.DataSource = VENTA.ITEMS_VENTA;
                lbSUMAS.Text = VENTA.SUMAS.ToString("C2");
                txtDESCUENTO.Text = VENTA.DESCUENTO.ToString("C2");
                txtTOTAL.Text = VENTA.TOTAL.ToString("C2");
                txtNOTA.Text = VENTA.NOTA;
            }
            else
            {
                limpiarDatosVenta();
            }
        }


        //CARGAR CLIENTE
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


        //BUSCAR CLIENTE
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


        //CARGAR TARJETA
        private void btnTARJETA_Click(object sender, EventArgs e)
        {
            Catalogos.BuscarTarjetaForm tarjeta = new Catalogos.BuscarTarjetaForm(this.Name);
            tarjeta.ShowDialog();
        }




        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != "" && cbxSUCURSAL.SelectedIndex >= 0)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        VENTA.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
                        VENTA.NUMVENTA = dbVenta.nextNumVenta(VENTA.COD_SUC);
                        txtNUMVENTA.Text = VENTA.NUMVENTA;
                        break;

                }
            }
        }




        private void actualizarParametros()
        {
            switch (VENTA.NIVEL)
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
            lbNIVEL.Text = VENTA.NIVEL.ToString();
        }




        public void getExistencias(object sender, EventArgs e)
        {
            if (tblITEMS.Rows.Count <= 5)
            {
                ExistenciasForm carrito = new ExistenciasForm();
                carrito.ShowDialog();
            }
            else
            {
                MessageBox.Show("NUMERO DE ITEMS POR VENTA SUPERADO", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void addItemVenta(Existencia exist)
        {
            VENTA.ITEMS_VENTA.Rows.Add(exist.CATEGORIA.ToString(),exist.CODIGO,exist.COD_ITEM,exist.CANTIDAD,exist.DESCRIPCION,exist.PRECIO,exist.PRECIO);
            calcularTotales();
        }



        private void removeItemVenta(object sender, EventArgs e)
        {
            if (VENTA.ITEMS_VENTA.Rows.Count > 0)
            {
                VENTA.ITEMS_VENTA.Rows.RemoveAt(tblITEMS.CurrentCell.RowIndex);
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
                case "MONTO":
                    if (tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString() == string.Empty || tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString() == "-----")
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
                case "MONTO":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        decimal valor;

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
                        else
                        {
                            decimal precioR = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["PRECIO"].FormattedValue.ToString(),System.Globalization.NumberStyles.Currency);
                            if (valor > 0 && (precioR == 0 || valor < precioR))
                            {
                                tblITEMS.Rows[e.RowIndex].ErrorText = "MONTO NO AUTORIZADO";
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
                string item = tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString();
                string descripcion = tblITEMS.Rows[e.RowIndex].Cells["DESCRIPCION"].FormattedValue.ToString();
                decimal cantidad = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);
                decimal monto = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["MONTO"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);

                string columnName = tblITEMS.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "MONTO":
                        calcularTotales();
                        break;
                }
            }
        }


        private void calcularTotales()
        {
            decimal SUMAS = VENTA.ITEMS_VENTA.AsEnumerable().Select(r => r.Field<decimal>("MONTO")).Sum();
            VENTA.DESCUENTO = Decimal.Round(SUMAS * REGLAS.DESC_COMPRA / 100,2,MidpointRounding.AwayFromZero);
            VENTA.TOTAL = SUMAS - VENTA.DESCUENTO;
            lbSUMAS.Text = VENTA.SUMAS.ToString("C2");
            txtDESCUENTO.Text = VENTA.DESCUENTO.ToString("C2");
            txtTOTAL.Text = VENTA.TOTAL.ToString("C2");
        }



        private bool validarVenta()
        {
            bool OK = true;
            try
            {
                if (VENTA.COD_CLIENTE == null || VENTA.COD_CLIENTE == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Seleccione Cliente para la transaccion", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (VENTA.COD_SUC == null || VENTA.COD_SUC == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Seleccion SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (VENTA.NUMVENTA == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("NUMERO DE VENTA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (VENTA.TOTAL <= 0)
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




        private bool validarItemsVenta()
        {
            bool OK = true;
            if (tblITEMS.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tblITEMS.Rows)
                {
                    if (row.Cells["CANTIDAD"].Value == null || (decimal)row.Cells["CANTIDAD"].Value <= 0)
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("CANTIDAD INVALIDA EN DETALLE DE VENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["COD_ITEM"].Value == null || row.Cells["COD_ITEM"].Value == "-----")
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
                        MessageBox.Show("DESCRIPCION VACIA EN DETALLE DE VENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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







        private void GUARDAR(object sender, EventArgs e)
        {
            txtTOTAL.Focus();
            if (validarVenta())
            {
                VENTA.NOTA = txtNOTA.Text;
                ConfirmarVenta confirmar = new ConfirmarVenta(VENTA, ACCION);
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
                    VENTA = SELECTED.Copy();
                    cargarDatosCliente(null);
                    cargarDatosVenta();
                    bloquear();

                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnLog.Enabled = true;
                    btnReimprimir.Enabled = true;
                    break;
            }
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (VENTA != null)
            {
                ACCION = eOperacion.UPDATE;
                desbloquear();
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnLog.Enabled = false;
                btnReimprimir.Enabled = false;
            }
            else
            {
                MessageBox.Show("VENTA NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void ELIMINAR(object sender, EventArgs e)
        {
            if (VENTA != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la VENTA " + VENTA.NUMVENTA +"-"+VENTA.DOCUMENTO+ " con FECHA:" + VENTA.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR COMPRA REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbVenta.delete(VENTA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
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
                MessageBox.Show("VENTA NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }






        private void BUSCAR(object sender, EventArgs e)
        {
            string numVENT = Controles.InputBox("VENTA #: ", "BUSCAR");
            if (numVENT != "")
            {
                if (buscarVenta(numVENT))
                {
                    MessageBox.Show("VENTA # " + VENTA.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("VENTA NO ENCONTRADA", "NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }



        public bool buscarVenta(string documento)
        {
            bool OK = false;
            SELECTED = Venta.ConvertToVenta(dbVenta.getVentaByNumVenta(documento));
            if (SELECTED != null)
            {
                ACCION = eOperacion.SEARCH;
                SELECTED.ITEMS_VENTA = dbVenta.getItemsVenta(SELECTED);
                VENTA = SELECTED.Copy();
                cargarDatosCliente(null);
                cargarDatosVenta();
                bloquear();
                OK = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }




        public void IMPRIMIR(Venta v)
        {
            SELECTED = null;
            if (v != null && v.NUMVENTA != null)
            {
                if (buscarVenta(v.NUMVENTA))
                {
                    cargarDatosVenta();
                    if (SELECTED != null)
                    {
                       string numFactura = string.Empty;
                       while (numFactura.Trim() == string.Empty)
                       {
                            numFactura = Controles.InputBox("Factura N° : ", "FACTURA CONSUMIDOR FINAL");
                       }
                       dbVenta.changeFCF(SELECTED.ID_VENTA, numFactura);
                       ImprimirFactura();
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL IMPRIMIR FACTURA DE VENTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR AL IMPRIMIR FACTURA DE VENTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        
        }



        private void REIMPRIMIR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                DialogResult cambiar = MessageBox.Show(" Cambiar numero de FACTURA # " + SELECTED.DOCUMENTO + "?", "REIMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cambiar == DialogResult.Yes)
                {
                    string numFactura = string.Empty;
                       while (numFactura.Trim() == string.Empty)
                       {
                            numFactura = Controles.InputBox("Factura N° : ", "FACTURA CONSUMIDOR FINAL");
                       }
                       dbVenta.changeFCF(SELECTED.ID_VENTA, numFactura);
                }
                ImprimirFactura();
            }
        }

        




        private void ImprimirFactura()
        {
            viewerFACTURA.Clear();
            if (SELECTED != null)
            {
                try
                {
                    dSItemFCF.Clear();
                    foreach (DataRow row in VENTA.ITEMS_VENTA.Rows)
                    {
                        dSItemFCF.ITEM.AddITEMRow(row.Field<decimal>("CANTIDAD").ToString(), row.Field<string>("DESCRIPCION"), row.Field<decimal>("MONTO"));
                    }
                    //RELLENAR ESPACIOS SIN OCUPAR
                    for (int i = 1; i <= 5; i++)
                    {
                        if (i > VENTA.ITEMS_VENTA.Rows.Count)
                        {
                            dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
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

                    ReportParameter[] parameters = new ReportParameter[8];
                    parameters[0] = new ReportParameter("DOCUMENTO", SELECTED.NUMVENTA);
                    parameters[1] = new ReportParameter("CLIENTE", SELECTED.CLIENTE);
                    parameters[2] = new ReportParameter("DIA", SELECTED.FECHA.Date.ToString("dd"));
                    parameters[3] = new ReportParameter("MES", SELECTED.FECHA.Date.ToString("MMM").ToUpper());
                    parameters[4] = new ReportParameter("ANIO", SELECTED.FECHA.Date.ToString("yyyy"));
                    parameters[5] = new ReportParameter("SUMAS", SELECTED.SUMAS.ToString("C2"));
                    parameters[6] = new ReportParameter("TOTAL", SELECTED.TOTAL.ToString("C2"));
                    parameters[7] = new ReportParameter("LETRAS", HOME.Instance().convertirCantidadEnLetras(SELECTED.TOTAL));

                    viewerFACTURA.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.FCF.rdlc";
                    viewerFACTURA.LocalReport.DataSources.Clear();
                    viewerFACTURA.LocalReport.DataSources.Add(new ReportDataSource("ITEM", bindingFCF));
                    viewerFACTURA.LocalReport.SetParameters(parameters);
                    viewerFACTURA.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR FACTURA DE VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }



        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerFACTURA.PrintDialog();
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
