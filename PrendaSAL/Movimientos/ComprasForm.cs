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

    public partial class ComprasForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ComprasForm frmInstance = null;

        public static ComprasForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ComprasForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private DBCliente dbCliente;
        private DBCompra dbCompra;
        private DBCatalogo dbCatalogo;

        private eOperacion ACCION;

        private Compra COMPRA;
        private Compra SELECTED;
        public  Tarjeta TARJETA;
        private DataTable PRECIOS;


        public ComprasForm()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbCliente = new DBCliente();
            dbCompra= new DBCompra();
            dbCatalogo = new DBCatalogo();
            COMPRA = new Compra();
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
                if (p.Field<string>("CODIGO") == "P7")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
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
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.Enabled = true;
            }
        }





        private void ComprasForm_Load(object sender, EventArgs e)
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

            cbxCategorias.DataSource = Enum.GetValues(new eCategoria().GetType());
            cbxCategorias.SelectedItem = eCategoria.ORO;

            bloquear();
            NUEVO(null, null);
        }




        private void bloquear()
        {
            grbCLIENTE.Enabled = false;
            grbCOMPRA.Enabled = false;
            grbDETALLE.Enabled = false;
            tblITEMS.ReadOnly = true;
            txtNOTA.ReadOnly = true;
        }


        private void desbloquear()
        {
            grbCLIENTE.Enabled = true;
            grbCOMPRA.Enabled = true;
            grbDETALLE.Enabled = true;
            tblITEMS.ReadOnly = false;
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

        private void limpiarDatosCompra()
        {
            txtDOCUMENTO.Text = string.Empty;
            tblITEMS.DataSource = null;
            lbNIVEL.Text = string.Empty;
            txtTOTAL.Text = string.Empty;
            txtNOTA.Text = string.Empty;
        }



        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            COMPRA = new Compra();
            COMPRA.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            COMPRA.DOCUMENTO = dbCompra.nextContratoCompra(COMPRA.COD_SUC);
            COMPRA.FECHA = HOME.Instance().FECHA_SISTEMA;
            COMPRA.NIVEL = eNIVEL.PRENDASAL;
            COMPRA.TIPO = eTipoCompra.CONTADO;
            COMPRA.TIPO_PAGO = eTipoPago.EFECTIVO;
            cargarDatosCliente(null);
            cargarDatosCompra();
            desbloquear();
            txtDocCLI.Focus();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;
            btnPrintKITCO.Enabled = false;

        }


        



        public void cargarDatosCliente(Cliente CLIENTE)
        {
            if (CLIENTE != null && CLIENTE.COD_CLIENTE != null && CLIENTE.COD_CLIENTE != string.Empty)
            {
                COMPRA.COD_CLIENTE = CLIENTE.COD_CLIENTE;
                COMPRA.CLIENTE = CLIENTE.CLIENTE;
                COMPRA.EDAD = CLIENTE.EDAD;
                COMPRA.DUI = CLIENTE.DUI;
                COMPRA.LICENCIA = CLIENTE.LICENCIA;
                COMPRA.PASAPORTE = CLIENTE.PASAPORTE;
                COMPRA.CARNET = CLIENTE.CARNET;
                COMPRA.EXTENDIDO = CLIENTE.EXTENDIDO;
                COMPRA.TEL_CLI = CLIENTE.TEL;
                COMPRA.DOMICILIO_CLI = CLIENTE.DOMICILIO;
                COMPRA.DIRECCION_CLI = CLIENTE.DIRECCION;
            }
            txtCodigoCLI.Text = COMPRA.COD_CLIENTE;
            txtNombreCLI.Text = COMPRA.CLIENTE;
            if (COMPRA.DUI != null && COMPRA.DUI != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.DUI;
                txtDocCLI.Text = COMPRA.DUI;
            }
            else if (COMPRA.LICENCIA != null && COMPRA.LICENCIA != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.LICENCIA;
                txtDocCLI.Text = COMPRA.LICENCIA;
            }
            else if (COMPRA.PASAPORTE != null && COMPRA.PASAPORTE != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.PASAPORTE;
                txtDocCLI.Text = COMPRA.PASAPORTE;
            }
            else if (COMPRA.CARNET != null && COMPRA.CARNET != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.CARNET;
                txtDocCLI.Text = COMPRA.CARNET;
            }
            else
            {
                txtDocCLI.Text = string.Empty;
            }
            txtEdadCLI.Text = COMPRA.EDAD + "";
            txtExtCLI.Text = COMPRA.EXTENDIDO;
            txtTelCLI.Text = COMPRA.TEL_CLI;
            txtDomicilioCLI.Text = COMPRA.DOMICILIO_CLI;
            txtDireccionCLI.Text = COMPRA.DIRECCION_CLI;
        }




        private void cargarDatosCompra()
        {
            if (COMPRA != null)
            {
                cbxSUCURSAL.SelectedValue = COMPRA.COD_SUC;
                txtDOCUMENTO.Text = COMPRA.DOCUMENTO;
                dateCompra.Value = COMPRA.FECHA;
                switch (COMPRA.NIVEL)
                {
                    case eNIVEL.PRENDASAL:
                        rdbSUCURSAL.Checked = true;
                        break;
                    case eNIVEL.MAYOREO:
                        rdbMAYOREO.Checked = true;
                        break;
                }
                lbNIVEL.Text = COMPRA.NIVEL.ToString();
                tblITEMS.DataSource = null;
                cbxCategorias.SelectedItem = COMPRA.CATEGORIA;
                tblITEMS.DataSource = COMPRA.ITEMS_COMPRA;
                txtTOTAL.Text = COMPRA.TOTAL.ToString("C2");
                txtNOTA.Text = COMPRA.NOTA;
            }else{
                limpiarDatosCompra();
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
                        COMPRA.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
                        COMPRA.DOCUMENTO = dbCompra.nextContratoCompra(COMPRA.COD_SUC);
                        txtDOCUMENTO.Text = COMPRA.DOCUMENTO;
                        break;

                }
            }
        }




        private void rdbSUCURSAL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSUCURSAL.Checked)
            {
                COMPRA.NIVEL = eNIVEL.PRENDASAL;
                actualizarPrecios();
            }
        }

        private void rdbMAYOREO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMAYOREO.Checked)
            {
                COMPRA.NIVEL = eNIVEL.MAYOREO;
                actualizarPrecios();
            }

        }


        private void actualizarPrecios()
        {
            switch (COMPRA.NIVEL)
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
            lbNIVEL.Text = COMPRA.NIVEL.ToString();
            if(tblITEMS.Rows.Count > 0 && (eCategoria) cbxCategorias.SelectedItem == eCategoria.ORO && ACCION != eOperacion.SEARCH)
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
                decimal monto = Decimal.Round((decimal)cantidad * getPrecioKIL(item), 2,MidpointRounding.AwayFromZero);
                row.Cells["MONTO"].Value = monto;
            }
            calcularTotales();
        }

        


        private void btnPrecios_Click(object sender, EventArgs e)
        {
            Configuracion.PreciosForm costos;
            costos = Configuracion.PreciosForm.Instance();
            costos.StartPosition = FormStartPosition.CenterParent;
            costos.ShowDialog(this);
            if (costos.WindowState == FormWindowState.Minimized)
            {
                costos.WindowState = FormWindowState.Normal;
            }
        }


        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategorias.SelectedIndex >= 0)
            {
                COMPRA.CATEGORIA = (eCategoria) cbxCategorias.SelectedItem;
                DataTable CATALOGO = dbCatalogo.showCatalogo(COMPRA.CATEGORIA);
                if (CATALOGO.Rows.Count == 0)
                {
                    CATALOGO.Columns.Add("CATEGORIA");
                    CATALOGO.Columns.Add("COD_ITEM");
                    CATALOGO.Columns.Add("UNIDAD_MEDIDA");
                }
                DataRow R = CATALOGO.NewRow();
                R.SetField<string>("CATEGORIA", "-----");
                R.SetField<string>("COD_ITEM", "-----");
                R.SetField<string>("UNIDAD_MEDIDA", "-----");
                CATALOGO.Rows.InsertAt(R, 0);

                switch (COMPRA.CATEGORIA)
                {
                    case eCategoria.ORO:
                        tblITEMS.Columns["COD_ITEM"].HeaderText = "KILATAJE";
                        tblITEMS.Columns["CANTIDAD"].HeaderText = "PESO";
                        break;
                    case eCategoria.ARTICULO:
                        tblITEMS.Columns["COD_ITEM"].HeaderText = "ARTICULO";
                        tblITEMS.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
                        break;
                }
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        COMPRA.ITEMS_COMPRA.Rows.Clear();
                        break;
                    case eOperacion.UPDATE:
                        COMPRA.ITEMS_COMPRA.Rows.Clear();
                        break;
                    case eOperacion.SEARCH:
                        tblITEMS.Rows.Clear();
                        break;

                }
                ((DataGridViewComboBoxColumn)tblITEMS.Columns["COD_ITEM"]).DataSource = CATALOGO;
                ((DataGridViewComboBoxColumn)tblITEMS.Columns["COD_ITEM"]).DisplayMember = "COD_ITEM";
                ((DataGridViewComboBoxColumn)tblITEMS.Columns["COD_ITEM"]).ValueMember = "COD_ITEM";

            }
        }



        private void addItemCompra(object sender, EventArgs e)
        {
            COMPRA.ITEMS_COMPRA.Rows.Add(cbxCategorias.SelectedItem.ToString(),"-----", 0.0, "", 0.00);
        }




        private void removeItemCompra(object sender, EventArgs e)
        {
            if (COMPRA.ITEMS_COMPRA.Rows.Count > 0)
            {
                COMPRA.ITEMS_COMPRA.Rows.RemoveAt(tblITEMS.CurrentCell.RowIndex);
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
                case "COD_ITEM":
                    if (cbxCategorias.SelectedIndex < 0)
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
                case "CANTIDAD":
                    if (tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString() == string.Empty || tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString() == "-----")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
                case "DESCRIPCION":
                    if (tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString() == string.Empty || tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString() == "-----")
                    {
                        System.Media.SystemSounds.Beep.Play();
                        e.Cancel = true;
                    }
                    break;
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
                        else if ((eCategoria)cbxCategorias.SelectedItem == eCategoria.ORO)
                        {
                            decimal precioR = getPrecioKIL(tblITEMS.Rows[e.RowIndex].Cells["COD_ITEM"].FormattedValue.ToString());
                            decimal cantidad = Decimal.Parse(tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency);
                            decimal costoTope = Decimal.Round(precioR * cantidad, 0, MidpointRounding.AwayFromZero);

                            if (costoTope > 0 && valor > costoTope)
                            {
                                tblITEMS.Rows[e.RowIndex].ErrorText = "MONTO SUPERA EL APROBADO";
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
                    case "COD_ITEM":
                        if (item == string.Empty || item == "-----")
                        {
                            tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].Value = 0.0;
                            tblITEMS.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = "";
                            tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = 0.00;
                        }
                        else if ((eCategoria)cbxCategorias.SelectedItem == eCategoria.ORO)
                        {
                            monto = Decimal.Round((decimal)cantidad * getPrecioKIL(item), 2, MidpointRounding.AwayFromZero);
                            tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = monto;
                        }
                        calcularTotales();
                        break;
                    case "CANTIDAD":
                        switch((eCategoria) cbxCategorias.SelectedItem)
                        {
                            case eCategoria.ARTICULO:
                                cantidad = Decimal.Round(cantidad, 0);
                                tblITEMS.Rows[e.RowIndex].Cells["CANTIDAD"].Value = cantidad;
                                break;
                            case eCategoria.ORO:
                                monto = Decimal.Round((decimal)cantidad * getPrecioKIL(item), 2, MidpointRounding.AwayFromZero);
                                tblITEMS.Rows[e.RowIndex].Cells["MONTO"].Value = monto;
                                break;
                        }
                        calcularTotales();
                        break;
                    case "DESCRIPCION":
                        tblITEMS.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = descripcion.ToString().ToUpper().Replace('>', ' ').Replace('&', ' ');
                        break;
                    case "MONTO":
                        calcularTotales();
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
        


        private void calcularTotales()
        {
            COMPRA.TOTAL = COMPRA.ITEMS_COMPRA.AsEnumerable().Select(r => r.Field<decimal>("MONTO")).Sum();
            txtTOTAL.Text = COMPRA.TOTAL.ToString("C2");
        }





        private bool validarCompra()
        {
            bool OK = true;
            try
            {
                if (COMPRA.COD_CLIENTE == null || COMPRA.COD_CLIENTE == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Seleccione Cliente para la transaccion", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (COMPRA.COD_SUC == null || COMPRA.COD_SUC == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("ELIJA SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (COMPRA.DOCUMENTO == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("NUMERO CONTRATO DE COMPRA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (COMPRA.TOTAL <= 0)
                {
                    OK = false;
                    MessageBox.Show("TOTAL DE COMPRA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                OK = validarItemsCompra();
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR COMPRA", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }




        private bool validarItemsCompra()
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
                        MessageBox.Show("CANTIDAD INVALIDA EN DETALLE DE COMPRA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["COD_ITEM"].Value == null || row.Cells["COD_ITEM"].Value == "-----")
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("PRODUCTO NO ESPECIFICADO EN DETALLE DE COMPRA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["DESCRIPCION"].Value == null || row.Cells["DESCRIPCION"].Value.ToString().Trim() == string.Empty)
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("DESCRIPCION VACIA EN DETALLE DE COMPRA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (row.Cells["MONTO"].Value == null || Decimal.Parse(row.Cells["MONTO"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) <= 0)
                    {
                        OK = false;
                        tblITEMS.CurrentRow.Selected = false;
                        tblITEMS.Rows[row.Index].Selected = true;
                        MessageBox.Show("MONTO INVALIDO EN DETALLE DE COMPRA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
            else
            {
                OK = false;
                MessageBox.Show("DETALLE DE COMPRA VACIO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }







        private void GUARDAR(object sender, EventArgs e)
        {
            txtTOTAL.Focus();
            if (validarCompra())
            {
                COMPRA.NOTA = txtNOTA.Text;
                ConfirmarCompra confirmar = new ConfirmarCompra(COMPRA, ACCION);
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
                    COMPRA = SELECTED.Copy();
                    cargarDatosCliente(null);
                    cargarDatosCompra();
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
            if (COMPRA != null)
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
                MessageBox.Show("COMPRA NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void ELIMINAR(object sender, EventArgs e)
        {
            if (COMPRA != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la COMPRA " +  COMPRA.DOCUMENTO + " con FECHA:" + COMPRA.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR COMPRA REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbCompra.delete(COMPRA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
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
                MessageBox.Show("COMPRA NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }






        private void BUSCAR(object sender, EventArgs e)
        {
            string numCONT = Controles.InputBox("COMPRA #: ", "BUSCAR");
            if (numCONT != "")
            {
                if (buscarCompra(numCONT))
                {
                    MessageBox.Show("COMPRA # " + COMPRA.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("COMPRA NO ENCONTRADA", "NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }



        public bool buscarCompra(string documento)
        {
            bool OK = false;
            SELECTED = Compra.ConvertToCompra(dbCompra.getCompraByDoc(documento));
            if (SELECTED != null)
            {
                SELECTED.ITEMS_COMPRA = dbCompra.getItemsCompra(SELECTED);
                COMPRA = SELECTED.Copy();
                cargarDatosCliente(null);
                cargarDatosCompra();
                bloquear();
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



        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (COMPRA != null)
            {
                ImprimirContratoCompra_Plantilla_2();
            }
        }





        public void ImprimirContratoCompra_Plantilla_2()
        {
            viewerCONTRATO.Clear();
            if (COMPRA != null)
            {
                Sucursal SUC = HOME.Instance().getSucursal(COMPRA.COD_SUC).Copy();

                ReportParameter[] parameters = new ReportParameter[17];
                parameters[0] = new ReportParameter("SUCURSAL", SUC.SUCURSAL);
                parameters[1] = new ReportParameter("DireccionSUC", SUC.DIRECCION + " ," + SUC.DEPTO);
                parameters[2] = new ReportParameter("CONTRATO", COMPRA.DOCUMENTO);
                parameters[3] = new ReportParameter("CLIENTE", COMPRA.CLIENTE);
                parameters[4] = new ReportParameter("EdadCLI", COMPRA.EDAD + "");
                parameters[5] = new ReportParameter("DocCLI", ((eTipoDocCliente)cbxBuscarPorCLI.SelectedItem).ToString() + ": " + txtDocCLI.Text);
                parameters[6] = new ReportParameter("NitCLI", COMPRA.NIT);
                parameters[7] = new ReportParameter("DireccionCLI", COMPRA.DIRECCION_CLI + " " + COMPRA.DOMICILIO_CLI + " ," + COMPRA.DEPTO_CLI);
                parameters[8] = new ReportParameter("TOTAL", COMPRA.TOTAL.ToString("C2"));
                parameters[9] = new ReportParameter("TASA", 15 + "");
                parameters[10] = new ReportParameter("INTERES", (COMPRA.TOTAL*(decimal)0.15).ToString("C2"));
                parameters[11] = new ReportParameter("GARANTIA", COMPRA.ARTICULO);
                parameters[12] = new ReportParameter("DIAS", COMPRA.FECHA.Date.ToString("dd"));
                parameters[13] = new ReportParameter("MES", COMPRA.FECHA.Date.ToString("MMMM").ToUpper());
                parameters[14] = new ReportParameter("ANIO", COMPRA.FECHA.Date.ToString("yyyy"));
                parameters[15] = new ReportParameter("PLAZO", HOME.Instance().convertirNumeroLetra(3).ToLower());
                parameters[16] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                viewerCONTRATO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ContratoCompra2.rdlc";
                viewerCONTRATO.LocalReport.SetParameters(parameters);
                viewerCONTRATO.RefreshReport();
            }
        }






        public void ImprimirContratoCompra_Plantilla_1()
        {
            viewerCONTRATO.Clear();
            if (COMPRA != null)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(COMPRA.COD_SUC).Copy();

                    ReportParameter[] parameters = new ReportParameter[18];
                    parameters[0] = new ReportParameter("Sucursal", SUC.SUCURSAL);
                    parameters[1] = new ReportParameter("DireccionSUC", SUC.DIRECCION);
                    parameters[2] = new ReportParameter("TelSUC", "TEL: " + SUC.TEL);
                    parameters[3] = new ReportParameter("NumCOMPRA", COMPRA.DOCUMENTO);
                    parameters[4] = new ReportParameter("CLIENTE", COMPRA.CLIENTE);
                    parameters[5] = new ReportParameter("DomicilioCLI", COMPRA.DOMICILIO_CLI);
                    parameters[6] = new ReportParameter("DocCLI", ((eTipoDocCliente)cbxBuscarPorCLI.SelectedItem).ToString() + ": " + txtDocCLI.Text);
                    parameters[7] = new ReportParameter("ExpCLI", COMPRA.EXTENDIDO);
                    parameters[8] = new ReportParameter("DireccionCLI", COMPRA.DIRECCION_CLI);
                    parameters[9] = new ReportParameter("TelCLI", COMPRA.TEL_CLI);
                    parameters[10] = new ReportParameter("TOTAL", COMPRA.TOTAL.ToString("C2"));
                    parameters[11] = new ReportParameter("ARTICULO", COMPRA.ARTICULO);
                    parameters[12] = new ReportParameter("MUNICIPIO", SUC.MUNICIPIO);
                    parameters[13] = new ReportParameter("DIAS", COMPRA.FECHA.Date.ToString("dd"));
                    parameters[14] = new ReportParameter("MES", COMPRA.FECHA.Date.ToString("MMMM").ToUpper());
                    parameters[15] = new ReportParameter("ANIO", COMPRA.FECHA.Date.ToString("yyyy"));
                    parameters[16] = new ReportParameter("EMPLEADO", COMPRA.RESPONSABLE);
                    parameters[17] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));
                    viewerCONTRATO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ContratoCompra1.rdlc";
                    viewerCONTRATO.LocalReport.SetParameters(parameters);
                    viewerCONTRATO.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n"+ex.Message , "ERROR AL IMPRIMIR CONTRATO DE COMPRA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
            if (COMPRA != null)
            {
                try
                {
                    DataTable KITCO = dbCompra.getKITCO(COMPRA);
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
                }catch (Exception ex)
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
