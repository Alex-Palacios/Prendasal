using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Reportes
{
    using DDB;
    using MODELO;
    using Microsoft.Reporting.WinForms;

    public partial class REstadoCuentaForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static REstadoCuentaForm frmInstance = null;
        private string formName;

        public static REstadoCuentaForm Instance(string form)
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new REstadoCuentaForm();
            }
            frmInstance.formName = form;
            frmInstance.BringToFront();
            return frmInstance;
        }


        public static REstadoCuentaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new REstadoCuentaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBCliente dbCliente;
        private DBReporte dbReporte;

        private EstadoCuenta ESTADO_CUENTA;
        private DataTable MOVIMIENTOS;

        public REstadoCuentaForm()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbCliente = new DBCliente();
            dbReporte = new DBReporte();
        }


        private void permisos()
        {

        }

        private void REstadoCuentaForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblMOVIMIENTOS.AutoGenerateColumns = false;
            cbxBuscarPorCLI.DataSource = Enum.GetValues(new eTipoDocCliente().GetType());
            limpiarDatosCliente();
            cargarDatosCliente(new Cliente());
            txtDocCLI.Focus();
        }


        private void limpiarDatosCliente()
        {
            lbCODIGO.Text = string.Empty;
            txtDocCLI.Text = string.Empty;
            lbEXT.Text = string.Empty;
            lbDUI.Text = string.Empty;
            lbNIT.Text = string.Empty;
            lbCLIENTE.Text = string.Empty;
            lbEDAD.Text = string.Empty;
            lbTEL.Text = string.Empty;
            lbDOMICILIO.Text = string.Empty;
            lbDIRECCION.Text = string.Empty;
        }






        public void cargarDatosCliente(Cliente CLIENTE)
        {
            ESTADO_CUENTA = new EstadoCuenta();
            ckVIGENTES.Checked = false;
            ckVENCIDOS.Checked = false;
            ckCANCELADOS.Checked = false;

            //DATOS CLIENTE
            ESTADO_CUENTA.CLIENTE = CLIENTE;
            lbCODIGO.Text = ESTADO_CUENTA.CLIENTE.COD_CLIENTE;
            lbCLIENTE.Text = ESTADO_CUENTA.CLIENTE.CLIENTE;
            lbDUI.Text = ESTADO_CUENTA.CLIENTE.DUI;
            lbNIT.Text = ESTADO_CUENTA.CLIENTE.NIT;
            if (ESTADO_CUENTA.CLIENTE.DUI != null && ESTADO_CUENTA.CLIENTE.DUI != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.DUI;
                txtDocCLI.Text = ESTADO_CUENTA.CLIENTE.DUI;
            }
            else if (ESTADO_CUENTA.CLIENTE.LICENCIA != null && ESTADO_CUENTA.CLIENTE.LICENCIA != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.LICENCIA;
                txtDocCLI.Text = ESTADO_CUENTA.CLIENTE.LICENCIA;
            }
            else if (ESTADO_CUENTA.CLIENTE.PASAPORTE != null && ESTADO_CUENTA.CLIENTE.PASAPORTE != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.PASAPORTE;
                txtDocCLI.Text = ESTADO_CUENTA.CLIENTE.PASAPORTE;
            }
            else if (ESTADO_CUENTA.CLIENTE.CARNET != null && ESTADO_CUENTA.CLIENTE.CARNET != string.Empty)
            {
                cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.CARNET;
                txtDocCLI.Text = ESTADO_CUENTA.CLIENTE.CARNET;
            }
            else
            {
                txtDocCLI.Text = string.Empty;
            }
            lbEDAD.Text = ESTADO_CUENTA.CLIENTE.EDAD + " AÑOS";
            lbEXT.Text = ESTADO_CUENTA.CLIENTE.EXTENDIDO;
            lbTEL.Text = ESTADO_CUENTA.CLIENTE.TEL;
            lbDOMICILIO.Text = ESTADO_CUENTA.CLIENTE.DOMICILIO;
            lbDIRECCION.Text = ESTADO_CUENTA.CLIENTE.DIRECCION;

            //HISTORIAL
            ESTADO_CUENTA.MOVIMIENTOS = dbReporte.RptEstadoCuenta(ESTADO_CUENTA.CLIENTE.COD_CLIENTE);
            ckVIGENTES.Checked = true;
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


        private void ckVIGENTES_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotales();
        }

        private void ckCANCELADOS_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotales();
        }

        private void ckVENCIDOS_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotales();
        }



        private void calcularTotales()
        {
            
            ESTADO_CUENTA.VIGENTES = 0;
            ESTADO_CUENTA.VENCIDOS = 0;
            ESTADO_CUENTA.CANCELADOS = 0;
            ESTADO_CUENTA.PRESTAMOS = 0;
            ESTADO_CUENTA.ABONOS = 0;
            ESTADO_CUENTA.SALDOS = 0;

            if (ESTADO_CUENTA != null && ESTADO_CUENTA.MOVIMIENTOS != null && ESTADO_CUENTA.MOVIMIENTOS.Columns.Count > 0)
            {
                string filtro = " 1=2 ";
                if (ckVIGENTES.Checked)
                {
                    filtro = filtro + " OR ESTADO_CONTRATO LIKE '" + eEstadoContrato.ACTIVO.ToString() + "' OR ESTADO_CONTRATO LIKE '" + eEstadoContrato.PRORROGADO.ToString() + "' ";
                }
                if (ckVENCIDOS.Checked)
                {
                    filtro = filtro + " OR ESTADO_CONTRATO LIKE '" + eEstadoContrato.VENCIDO.ToString() + "' ";
                }
                if (ckCANCELADOS.Checked)
                {
                    filtro = filtro + " OR ESTADO_CONTRATO LIKE '" + eEstadoContrato.CANCELADO.ToString() + "' ";
                }
                ESTADO_CUENTA.MOVIMIENTOS.DefaultView.RowFilter = filtro;
                MOVIMIENTOS = ESTADO_CUENTA.MOVIMIENTOS.DefaultView.ToTable().Copy();
                foreach (DataRow row in MOVIMIENTOS.Rows)
                {
                    switch ((eEstadoContrato)Enum.Parse(typeof(eEstadoContrato), row.Field<string>("ESTADO_CONTRATO")))
                    {
                        case eEstadoContrato.ACTIVO:
                            ESTADO_CUENTA.VIGENTES++;
                            ESTADO_CUENTA.PRESTAMOS = ESTADO_CUENTA.PRESTAMOS + row.Field<decimal>("PRESTAMO");
                            ESTADO_CUENTA.ABONOS = ESTADO_CUENTA.ABONOS + row.Field<decimal>("ABONO");
                            ESTADO_CUENTA.SALDOS = ESTADO_CUENTA.SALDOS + row.Field<decimal>("SALDO");
                            break;
                        case eEstadoContrato.PRORROGADO:
                            ESTADO_CUENTA.VIGENTES++;
                            ESTADO_CUENTA.PRESTAMOS = ESTADO_CUENTA.PRESTAMOS + row.Field<decimal>("PRESTAMO");
                            ESTADO_CUENTA.ABONOS = ESTADO_CUENTA.ABONOS + row.Field<decimal>("ABONO");
                            ESTADO_CUENTA.SALDOS = ESTADO_CUENTA.SALDOS + row.Field<decimal>("SALDO");
                            break;
                        case eEstadoContrato.CANCELADO:
                            ESTADO_CUENTA.CANCELADOS++;
                            ESTADO_CUENTA.PRESTAMOS = ESTADO_CUENTA.PRESTAMOS + row.Field<decimal>("PRESTAMO");
                            ESTADO_CUENTA.ABONOS = ESTADO_CUENTA.ABONOS + row.Field<decimal>("ABONO");
                            break;
                        case eEstadoContrato.VENCIDO:
                            ESTADO_CUENTA.VENCIDOS++;
                            break;
                    }
                }
                lbVIGENTES.Text = ""+ESTADO_CUENTA.VIGENTES;
                lbVENCIDOS.Text = "" + ESTADO_CUENTA.VENCIDOS;
                lbCANCELADOS.Text = "" + ESTADO_CUENTA.CANCELADOS;
                lbPRESTAMOS.Text = ESTADO_CUENTA.PRESTAMOS.ToString("C2");
                lbABONOS.Text = ESTADO_CUENTA.ABONOS.ToString("C2");
                lbSALDOS.Text = ESTADO_CUENTA.SALDOS.ToString("C2");
                tblMOVIMIENTOS.DataSource = MOVIMIENTOS;
            }
        }




        private void btnIMPRIMIR_Click(object sender, EventArgs e)
        {
            if (ESTADO_CUENTA != null && ESTADO_CUENTA.CLIENTE.COD_CLIENTE  != null && ESTADO_CUENTA.CLIENTE.COD_CLIENTE != string.Empty)
            {
                viewerREPORTE.Clear();
                dSEstadoCuenta.Clear();
                try
                {
                    foreach (DataRow row in ESTADO_CUENTA.MOVIMIENTOS.Rows)
                    {
                        dSEstadoCuenta.ESTADO_CUENTA.AddESTADO_CUENTARow(row.Field<string>("COD_TRANS"), row.Field<DateTime>("FECHA"), row.Field<string>("CONTRATO"), row.Field<string>("ARTICULO"), row.Field<decimal>("PRESTAMO"), row.Field<decimal>("ABONO"), row.Field<decimal>("SALDO"), row.Field<decimal>("INTERES"), row.Field<int>("DIAS_TRANS"),row.Field<string>("ESTADO_CONTRATO"));
                    }
                    bsEstadoCuenta.DataSource = dSEstadoCuenta.ESTADO_CUENTA;
                    //PARAMETROS
                    ReportParameter[] parameters = new ReportParameter[16];
                    parameters[0] = new ReportParameter("CODIGO",ESTADO_CUENTA.CLIENTE.COD_CLIENTE);
                    parameters[1] = new ReportParameter("CLIENTE", ESTADO_CUENTA.CLIENTE.CLIENTE);
                    parameters[2] = new ReportParameter("EDAD", ESTADO_CUENTA.CLIENTE.EDAD + " AÑOS");
                    parameters[3] = new ReportParameter("TEL", ESTADO_CUENTA.CLIENTE.TEL);
                    parameters[4] = new ReportParameter("DUI", ESTADO_CUENTA.CLIENTE.DUI);
                    parameters[5] = new ReportParameter("NIT", ESTADO_CUENTA.CLIENTE.NIT);
                    parameters[6] = new ReportParameter("EXTENDIDO", ESTADO_CUENTA.CLIENTE.EXTENDIDO);
                    parameters[7] = new ReportParameter("DOMICILIO", ESTADO_CUENTA.CLIENTE.DOMICILIO);
                    parameters[8] = new ReportParameter("DIRECCION", ESTADO_CUENTA.CLIENTE.DIRECCION);
                    parameters[9] = new ReportParameter("VIGENTES", ESTADO_CUENTA.VIGENTES + "");
                    parameters[10] = new ReportParameter("VENCIDOS", ESTADO_CUENTA.VENCIDOS + "");
                    parameters[11] = new ReportParameter("CANCELADOS", ESTADO_CUENTA.CANCELADOS + "");
                    parameters[12] = new ReportParameter("PRESTAMOS", ESTADO_CUENTA.PRESTAMOS.ToString("C2"));
                    parameters[13] = new ReportParameter("ABONOS", ESTADO_CUENTA.ABONOS.ToString("C2"));
                    parameters[14] = new ReportParameter("SALDOS", ESTADO_CUENTA.SALDOS.ToString("C2"));
                    parameters[15] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.RptEstadoCuenta.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("CONTRATOS", bsEstadoCuenta));
                    viewerREPORTE.LocalReport.SetParameters(parameters);
                    viewerREPORTE.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR AL GENERAR REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("CARGUE ESTADO DE CUENTA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerREPORTE.PrintDialog();
            }
        }




        private void tblMOVIMIENTOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblMOVIMIENTOS.CurrentCell != null && tblMOVIMIENTOS.CurrentCell.RowIndex >= 0 && tblMOVIMIENTOS.SelectedRows.Count == 1)
            {
                string contrato = (string) tblMOVIMIENTOS.Rows[tblMOVIMIENTOS.CurrentCell.RowIndex].Cells["CONTRATO"].Value;
                switch (formName)
                {
                    case "ContratosForm":
                        Movimientos.ContratosForm.Instance().buscarCargarContrato(contrato);
                        this.Close();
                        break;
                    case "PACForm":
                        Movimientos.PACForm.Instance().buscarCargarContrato(contrato);
                        this.Close();
                        break;
                }
            }
        }











    }
}
