using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesPersonalizados;
using Microsoft.Reporting.WinForms;

namespace PrendaSAL.Movimientos
{

    using MODELO;
    using DDB;
    using ControlesPersonalizados;

    public partial class PACForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static PACForm frmInstance = null;

        public static PACForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new PACForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBPrestamo dbPrestamo;
        private DBUsuario dbUser;
        private DBVencidos dbVencidos;
        private DBPac dbPAC;
        private DBCupones dbCupon;

        private eOperacion ACCION;
        private Pac PAC;
        private Pac SELECTED;
        private Reglas REGLAS;
        private Tarjeta TARJETA;
        private Cupon CuponX;

        
        public PACForm()
        {
            InitializeComponent();
            this.PerformAutoScale();
            dbUser = new DBUsuario();
            dbPrendasal = new DBPRENDASAL();
            dbPrestamo = new DBPrestamo();
            dbPAC = new DBPac();
            dbVencidos = new DBVencidos();
            PAC = new Pac();
            dbCupon = new DBCupones();
        }





        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnAnular.Visible = false;
            btnEliminar.Visible = false;
            btnLog.Visible = false;
            btnReimprimir.Visible = false;
            btnReactivar.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P6")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                    btnHistorialPAC.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }

            if (HOME.Instance().USUARIO.TIPO != eTipoUsuario.ASESOR)
            {
                btnReactivar.Visible = true;
                cbxSUCURSAL.Enabled = true;
            }
        }






        private void PACForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblHistorialPAC.AutoGenerateColumns = false;
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
            grbABONO.Enabled = false;
        }




        private void desbloquear()
        {
            grbABONO.Enabled = true;
        }



        private void limpiarDatosContrato()
        {
            txtNUM_CONTRATO.Text = string.Empty;
            dateFechaCONT.Value = HOME.Instance().FECHA_SISTEMA;
            dateVencCONT.Value = HOME.Instance().FECHA_SISTEMA;
            txtEstadoCONT.Text = string.Empty;
            txtCodigoCLI.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtTelCLI.Text = string.Empty;
            lbARTICULO.Text = string.Empty;
            lbTOTAL_CTO.Text = string.Empty;
            lbSALDO.Text = string.Empty;
            txtDIAS_TRANS.Text = string.Empty;
            txtINT_MENSUAL.Text = string.Empty;
            txtINT_DIARIO.Text = string.Empty;
            tblHistorialPAC.DataSource = null;
            lbCAPITAL.Text = string.Empty;
            lbVENCIDO.Text = string.Empty;
            

            btnHistorialPAC.Enabled = false;
            
        }


        private void limpiarDatosPAC()
        {
            rdbPRORROGA.Checked = true;
            datePago.Value = HOME.Instance().FECHA_SISTEMA;
            cbxSUCURSAL.SelectedValue = (string) HOME.Instance().SUCURSAL.COD_SUC;
            txtRECIBO.Text = string.Empty;
            numMESES.Value = 0;
            numDIAS.Value = 0;

            txtINTERESES.Text = string.Empty;
            txtDESCUENTO.Text = string.Empty;
            txtABONO.Text = string.Empty;
            txtTOTAL.Text = string.Empty;
            txtNOTA.Text = string.Empty;

        }




        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            CuponX = null;
            Prestamo contrato = null;
            if (PAC != null)
            {
                contrato = PAC.CONTRATO;
            }
            PAC = new Pac();
            PAC.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            PAC.CONTRATO = contrato;
            PAC.RECIBO = dbPAC.nextReciboPAC(PAC.COD_SUC);
            PAC.FECHA = HOME.Instance().FECHA_SISTEMA;
            PAC.NIVEL = eNIVEL.PRENDASAL;
            PAC.TIPO = eTipoMovPac.PRORROGA;
            PAC.TIPO_PAGO = eTipoPago.EFECTIVO;
            PAC.ESTADO = eEstado.PREINGRESADO;

            actualizarParametros();
            cargarDatosContrato();
            cargarDatosPAC();
            desbloquear();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;
            btnHistorialPAC.Enabled = false;

            txtNUM_CONTRATO.SelectAll();

            SELECTED = null;
        }




        private void cargarDatosContrato()
        {
            ACCION = eOperacion.INSERT;
            limpiarDatosContrato();
            if (PAC.CONTRATO != null)
            {
                txtNUM_CONTRATO.Text = PAC.CONTRATO.DOCUMENTO;
                dateFechaCONT.Value = PAC.CONTRATO.FECHA;
                dateVencCONT.Value = PAC.CONTRATO.FECHA_VENC;
                switch (PAC.CONTRATO.ESTADO_CONTRATO)
                {
                    case eEstadoContrato.ACTIVO:
                        txtEstadoCONT.ForeColor = Color.Green;
                        grbABONO.Enabled = true;
                        if (PAC.CONTRATO.DIAS_TRANS == 0)
                        {
                            PAC.CONTRATO.DIAS_TRANS = 1;
                        }
                        btnReactivar.Enabled = false;
                        break;
                    case eEstadoContrato.PRORROGADO:
                        txtEstadoCONT.ForeColor = Color.Blue;
                        grbABONO.Enabled = true;
                        btnReactivar.Enabled = false;
                        break;
                    case eEstadoContrato.REACTIVADO:
                        txtEstadoCONT.ForeColor = Color.Orange;
                        grbABONO.Enabled = true;
                        btnReactivar.Enabled = false;
                        break;
                    case eEstadoContrato.CANCELADO:
                        txtEstadoCONT.ForeColor = Color.Crimson;
                        grbABONO.Enabled = false;
                        btnReactivar.Enabled = false;
                        break;
                    case eEstadoContrato.VENCIDO:
                        txtEstadoCONT.ForeColor = Color.Red;
                        grbABONO.Enabled = false;
                        btnReactivar.Enabled = true;
                        lbVENCIDO.ForeColor = Color.DarkRed;
                        lbVENCIDO.Text = PAC.CONTRATO.VENCIDO;
                        break;
                    default:
                        txtEstadoCONT.ForeColor = Color.DarkRed;
                        grbABONO.Enabled = false;
                        btnReactivar.Enabled = false;
                        break;
                }
                txtEstadoCONT.Text = PAC.CONTRATO.ESTADO_CONTRATO.ToString();
                lbARTICULO.Text = PAC.CONTRATO.ARTICULO;
                
                lbTOTAL_CTO.Text = PAC.CONTRATO.TOTAL.ToString("C2");
                lbSALDO.Text = PAC.CONTRATO.SALDO.ToString("C2");
                txtCodigoCLI.Text = PAC.CONTRATO.COD_CLIENTE;
                txtCliente.Text = PAC.CONTRATO.CLIENTE;
                txtTelCLI.Text = PAC.CONTRATO.TEL_CLI;
                PAC.CONTRATO.HISTORIAL_PAC = dbPAC.getHistorialPAC(PAC.CONTRATO);
                tblHistorialPAC.DataSource = PAC.CONTRATO.HISTORIAL_PAC;
                txtBitacora.Text = PAC.CONTRATO.getNotasHistorialPAC();

                txtDIAS_TRANS.Text = PAC.CONTRATO.DIAS_TRANS +"";
                txtINT_MENSUAL.Text = PAC.CONTRATO.INTERES_MENSUAL.ToString("C2");
                txtINT_DIARIO.Text = PAC.CONTRATO.INTERES_DIARIO.ToString("C4");
                
                lbCAPITAL.Text = PAC.CONTRATO.HISTORIAL_PAC.AsEnumerable().Select(r => r.Field<decimal>("ABONO")).Sum().ToString("C2");

                calcularTotales();

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnLog.Enabled = false;
                btnReimprimir.Enabled = false;
                btnHistorialPAC.Enabled = true;
            }
        }


      


        private void cargarDatosPAC()
        {
            limpiarDatosPAC();
            if (PAC != null)
            {
                switch (PAC.TIPO)
                {
                    case eTipoMovPac.PRORROGA:
                        rdbPRORROGA.Checked = true;
                        break;
                    case eTipoMovPac.ABONO:
                        rdbABONO.Checked = true;
                        break;
                    case eTipoMovPac.CANCELACION:
                        rdbCANCELACION.Checked = true;
                        break;
                }
                cbxSUCURSAL.SelectedValue = PAC.COD_SUC;
                txtRECIBO.Text = PAC.RECIBO;
                datePago.Value = PAC.FECHA;
                numMESES.Value = PAC.MESES;
                numDIAS.Value = PAC.DIAS;
                txtINTERESES.Text = PAC.INTERES.ToString("C2");
                txtDESCUENTO.Text = PAC.DESCUENTO.ToString("C2");
                txtABONO.Text = PAC.ABONO.ToString("C2");
                txtTOTAL.Text = PAC.TOTAL.ToString("C2");
                txtNOTA.Text = PAC.NOTA;

            }
        }



        private void txtNUM_CONTRATO_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter && txtNUM_CONTRATO.Text.Trim() != string.Empty)
            {
                if (buscarContrato(txtNUM_CONTRATO.Text.Trim()))
                {
                    cargarDatosContrato(); 
                    MessageBox.Show("CONTRATO # " + PAC.CONTRATO.DOCUMENTO + " CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CONTRATO NO EXISTE", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNUM_CONTRATO.SelectAll();
                e.Handled = true;
            }
        }



        public void buscarCargarContrato(string contrato)
        {
            if (buscarContrato(contrato))
            {
                cargarDatosContrato();
                MessageBox.Show("CONTRATO # " + PAC.CONTRATO.DOCUMENTO + " CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CONTRATO NO EXISTE", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool buscarContrato(string numcontrato)
        {
            NUEVO(null, null);
            bool OK = false;
            PAC.CONTRATO = Prestamo.ConvertToPrestamo(dbPrestamo.getContratoByDoc(numcontrato));
            if (PAC.CONTRATO != null)
            {
                PAC.ID_PRESTAMO = PAC.CONTRATO.ID_PRESTAMO;
                PAC.CONTRATO.HISTORIAL_PAC = dbPAC.getHistorialPAC(PAC.CONTRATO);
                OK = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }




        private void btnTARJETA_Click(object sender, EventArgs e)
        {
            if (PAC.CONTRATO != null)
            {
                Catalogos.BuscarTarjetaForm tarjeta = new Catalogos.BuscarTarjetaForm(this.Name);
                tarjeta.ShowDialog();
            }
            else
            {
                MessageBox.Show("PRIMERO CARGUE EL CONTRATO", "DATOS INVALIDOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void actualizarParametros()
        {
            switch (PAC.NIVEL)
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
            lbNIVEL.Text = PAC.NIVEL.ToString();
        }



        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != "" && cbxSUCURSAL.SelectedIndex >= 0)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        PAC.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
                        PAC.RECIBO = dbPAC.nextReciboPAC(PAC.COD_SUC);
                        txtRECIBO.Text = PAC.RECIBO;
                        break;
                }
            }
        }





        private void rdbPRORROGA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPRORROGA.Checked && PAC.CONTRATO != null)
            {
                PAC.TIPO = eTipoMovPac.PRORROGA;
                CuponX = null;
                PAC.MESES = 0;
                PAC.DIAS = 0;
                PAC.ABONO = 0;

                numMESES.Value = PAC.MESES;
                numDIAS.Value = PAC.DIAS;
                txtABONO.Text = PAC.ABONO.ToString("C2");
                calcularTotales();

                numMESES.Enabled = true;
                numDIAS.Enabled = false;
                txtABONO.ReadOnly = false;

            }

        }


        private void btnABONO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbABONO.Checked && PAC.CONTRATO != null)
            {
                PAC.TIPO = eTipoMovPac.ABONO;
                CuponX = null;
                if (PAC.CONTRATO.DIAS_TRANS <= 0)
                {
                    PAC.MESES = 0;
                    PAC.DIAS = 0;
                }
                else
                {
                    switch (Properties.Settings.Default.PERIODO_INTERES)
                    {
                        case GlobalPeriodoInteres.MENSUAL:
                                PAC.MESES = (int)Math.Ceiling((decimal)PAC.CONTRATO.DIAS_TRANS/30);
                                PAC.DIAS = 0;
                            break;
                        case GlobalPeriodoInteres.DIARIO:
                            PAC.MESES = (int)PAC.CONTRATO.DIAS_TRANS / 30;
                            PAC.DIAS = (int)PAC.CONTRATO.DIAS_TRANS - PAC.MESES*30;
                            break;
                    }
                }
                PAC.ABONO = 0;

                numMESES.Value = PAC.MESES;
                numDIAS.Value = PAC.DIAS;
                txtABONO.Text = PAC.ABONO.ToString("C2");
                calcularTotales();

                numMESES.Enabled = false;
                numDIAS.Enabled = false;
                txtABONO.ReadOnly = false;
            }

        }


        private void rdbCANCELACION_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCANCELACION.Checked && PAC.CONTRATO != null)
            {
                PAC.TIPO = eTipoMovPac.CANCELACION;
                CuponX = null;
                if (PAC.CONTRATO.DIAS_TRANS <= 0)
                {
                    PAC.MESES = 0;
                    PAC.DIAS = 0;
                }
                else
                {
                    switch (Properties.Settings.Default.PERIODO_INTERES)
                    {
                        case GlobalPeriodoInteres.MENSUAL:
                            int dias = (int)PAC.CONTRATO.DIAS_TRANS - (int)Math.Floor((decimal)PAC.CONTRATO.DIAS_TRANS / 30) *30;
                            if (dias > 15)
                            {
                                PAC.MESES = (int)Math.Ceiling((decimal)PAC.CONTRATO.DIAS_TRANS/30);
                                PAC.DIAS = 0;
                            }
                            else
                            {
                                PAC.MESES = (int)Math.Floor((decimal)PAC.CONTRATO.DIAS_TRANS/30);
                                PAC.DIAS = dias;
                            }
                            break;
                        case GlobalPeriodoInteres.DIARIO:
                            PAC.MESES = (int)PAC.CONTRATO.DIAS_TRANS/30;
                            PAC.DIAS = (int)PAC.CONTRATO.DIAS_TRANS - PAC.MESES*30;
                            break;
                    }
                }
                PAC.ABONO = PAC.CONTRATO.SALDO;

                numMESES.Value = PAC.MESES;
                numDIAS.Value = PAC.DIAS;
                txtABONO.Text = PAC.ABONO.ToString("C2");
                calcularTotales();

                numMESES.Enabled = false;
                numDIAS.Enabled = false;
                txtABONO.ReadOnly = true;
            }

        }




        private void numMESES_ValueChanged(object sender, EventArgs e)
        {
            if (ACCION == eOperacion.INSERT)
            {
                PAC.MESES = (int)numMESES.Value;
                CuponX = null;
                calcularTotales();
            }
        }

        


        private void txtABONO_Validated(object sender, EventArgs e)
        {
            if (ACCION == eOperacion.INSERT)
            {
               PAC.ABONO = Decimal.Round(Decimal.Parse(txtABONO.Text, System.Globalization.NumberStyles.Currency), 2);
               txtABONO.Text = PAC.ABONO.ToString("C2");
               calcularTotales();
            }
        }



        private void txtABONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtTOTAL.Focus();
            }
            if (e.KeyChar == 46 && txtABONO.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 36 && txtABONO.Text.IndexOf('$') != -1)
            {
                e.Handled = true;
                return;
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && !(e.KeyChar == 36 && txtABONO.Text == string.Empty))
            {
                e.Handled = true;
                return;
            }
        }




        private void calcularTotales()
        {
            if (PAC != null && PAC.CONTRATO != null)
            {
                if (PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.ACTIVO && PAC.CONTRATO.DIAS_TRANS < 30 && PAC.TIPO != eTipoMovPac.PRORROGA) // PRIMEROS 30 DIAS INTERES DIVIDIDO
                {
                    PAC.INTERES = PAC.CONTRATO.INTERES_15;
                }
                else // DESPUES DE 30 DIAS INTERES NORMAL
                {
                    PAC.INTERES = Decimal.Round(PAC.MESES * PAC.CONTRATO.INTERES_MENSUAL + PAC.DIAS * PAC.CONTRATO.INTERES_DIARIO, 2, MidpointRounding.AwayFromZero);
                    
                }

                if (CuponX != null)
                {
                    PAC.DESCUENTO = Decimal.Round(PAC.MESES * PAC.CONTRATO.INTERES_MENSUAL * CuponX.DESC_INTERES / 100, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    PAC.DESCUENTO = Decimal.Round(PAC.INTERES * REGLAS.DESC_INTERES / 100, 2, MidpointRounding.AwayFromZero);                    
                }

                PAC.TOTAL = PAC.INTERES - PAC.DESCUENTO + PAC.ABONO;
                txtINTERESES.Text = PAC.INTERES.ToString("C2");
                txtDESCUENTO.Text = PAC.DESCUENTO.ToString("C2");
                txtTOTAL.Text = PAC.TOTAL.ToString("C2");
                    
            }
        }


        //private void calcularTotales()
        //{
        //    if (PAC != null && PAC.CONTRATO != null)
        //    {
        //        PAC.INTERES = Decimal.Round(PAC.MESES * PAC.CONTRATO.INTERES_MENSUAL + PAC.DIAS * PAC.CONTRATO.INTERES_DIARIO, 2, MidpointRounding.AwayFromZero);
        //        if (PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.ACTIVO && PAC.INTERES < 1 && PAC.TIPO == eTipoMovPac.CANCELACION)
        //        {
        //            PAC.INTERES = 1;
        //        }
        //        PAC.DESCUENTO = Decimal.Round(PAC.INTERES * REGLAS.DESC_INTERES / 100, 2, MidpointRounding.AwayFromZero);
        //        PAC.TOTAL = PAC.INTERES - PAC.DESCUENTO + PAC.ABONO;

        //        txtINTERESES.Text = PAC.INTERES.ToString("C2");
        //        txtDESCUENTO.Text = PAC.DESCUENTO.ToString("C2");
        //        txtTOTAL.Text = PAC.TOTAL.ToString("C2");

        //    }
        //}



        private bool validarAbono()
        {
            bool OK = true;
            try
            {
                if (PAC.CONTRATO == null)
                {
                    OK = false;
                    MessageBox.Show("Indique el Contrato para la transaccion", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (cbxSUCURSAL.SelectedIndex < 0)
                {
                    OK = false;
                    MessageBox.Show("ELIJA SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                } 
                else if (txtRECIBO.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("NUMERO RECIBO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                if (PAC.TOTAL <= 0)
                {
                    OK = false;
                    MessageBox.Show("TOTAL A PAGAR INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }else if (PAC.ABONO > 0 && PAC.CONTRATO.DIAS_TRANS > (PAC.MESES * 30 + PAC.DIAS))
                {
                    OK = false;
                    MessageBox.Show("DEBE PONERSE AL DIA CON LOS INTERESES PARA PODER ABONAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.REACTIVADO && (PAC.CONTRATO.DIAS_TRANS - PAC.MESES * 30 - PAC.DIAS) > PAC.CONTRATO.PLAZO_CONTRATO)
                {
                    OK = false;
                    MessageBox.Show("PARA REACTIVAR EL CONTRATO DEBE PONERSE AL DIA CON LOS INTERES AL MENOS HASTA UN PERIODO DEL PLAZO DEL CONTRATO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (rdbABONO.Checked && PAC.ABONO <= 0)
                {
                    OK = false;
                    MessageBox.Show("INGRESE EL ABONO A CAPITAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (rdbABONO.Checked && PAC.ABONO >= PAC.CONTRATO.SALDO)
                {
                    OK = false;
                    MessageBox.Show("NUEVO SALDO : $0.00 - Cambie Tipo de Movimiento a CANCELACION", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (rdbPRORROGA.Checked && PAC.ABONO >= PAC.CONTRATO.SALDO)
                {
                    OK = false;
                    MessageBox.Show("NUEVO SALDO : $0.00 - Cambie Tipo de Movimiento a CANCELACION", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR PAC", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }





        private void GUARDAR(object sender, EventArgs e)
        {
            Pac a = new Pac();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    txtTOTAL.Focus();
                    if (PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.ACTIVO || PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.PRORROGADO || PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.REACTIVADO)
                    {
                        if (validarAbono())
                        {
                            PAC.CUPON_CANJE = CuponX;
                            ConfirmarPAC confirmar = new ConfirmarPAC(PAC, ACCION);
                            confirmar.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CONTRATO #" + PAC.CONTRATO.DOCUMENTO + " " + PAC.CONTRATO.ESTADO_CONTRATO, "Error al cargar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    break;
            }
        }




        private void CANCELAR(object sender, EventArgs e)
        {
            NUEVO(sender, e);
        }



        private void tblHistorialA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblHistorialPAC.Columns[e.ColumnIndex].Name)
                {
                    case "CORRELATIVO":
                        e.Value = e.RowIndex + 1;
                        break;
                    case "MOVIMIENTO":
                        eTipoMovPac t = (eTipoMovPac)e.Value;
                        e.Value = t.ToString();
                        break;
                }
            }

        }


        private void tblHistorialA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblHistorialPAC.CurrentCell != null && tblHistorialPAC.SelectedRows.Count == 1 && PAC.CONTRATO != null)
            {
                SELECTED = Pac.ConvertToPAC(PAC.CONTRATO.HISTORIAL_PAC.Rows[tblHistorialPAC.CurrentCell.RowIndex]);
                if (SELECTED != null)
                {
                    SELECTED.CONTRATO = PAC.CONTRATO;

                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnLog.Enabled = true;
                    btnReimprimir.Enabled = true;
                }
            }
        }







        private void EDITAR(object sender, EventArgs e)
        {
            if (tblHistorialPAC.CurrentCell != null && tblHistorialPAC.SelectedRows.Count == 1)
            {
                if (SELECTED != null)
                {
                    ACCION = eOperacion.UPDATE;
                    SELECTED = Pac.ConvertToPAC(PAC.CONTRATO.HISTORIAL_PAC.Rows[tblHistorialPAC.CurrentCell.RowIndex]);
                    if (SELECTED != null)
                    {
                        SELECTED.CONTRATO = PAC.CONTRATO;
                        EditarPACForm editPAC = new EditarPACForm(SELECTED);
                        editPAC.Show();

                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE UN P.A.C", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblHistorialPAC.CurrentCell != null && tblHistorialPAC.SelectedRows.Count == 1)
            {
                if (SELECTED != null)
                {
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el RECIBO No " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR P.A.C REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            ACCION = eOperacion.DELETE;
                            if (dbPAC.delete(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                if (buscarContrato(SELECTED.CONTRATO.DOCUMENTO))
                                {
                                    cargarDatosContrato();
                                }
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
                    MessageBox.Show("SELECCIONE UN P.A.C", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (PAC.CONTRATO != null && PAC.CONTRATO.ESTADO_CONTRATO == eEstadoContrato.VENCIDO)
            {
                DialogResult reactivar = MessageBox.Show("¿Está seguro que desea REACTIVAR EL CONTRATO # " + PAC.CONTRATO.DOCUMENTO + " ?", "REACTIVAR CONTRATO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reactivar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbVencidos.reactivar(PAC.CONTRATO.ID_PRESTAMO, HOME.Instance().FECHA_SISTEMA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            if (buscarContrato(PAC.CONTRATO.DOCUMENTO))
                            {
                                cargarDatosContrato(); 
                            }
                        }
                    }else{
                         MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
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



        

        public void IMPRIMIR(Pac RECIBO)
        {
            SELECTED = null;
            if (RECIBO != null && RECIBO.CONTRATO != null)
            {
                if (buscarContrato(RECIBO.CONTRATO.DOCUMENTO))
                {
                    cargarDatosContrato();
                    tblHistorialPAC.CurrentCell = this.tblHistorialPAC[0, PAC.CONTRATO.HISTORIAL_PAC.Rows.Count - 1];
                    tblHistorialA_CellClick(null, null);
                    if (SELECTED != null)
                    {
                        if (SELECTED.INTERES <= 0)
                        {
                            ImprimirReciboPAC();
                        }
                        else
                        {
                            string numFactura = string.Empty;
                            while (numFactura.Trim() == string.Empty)
                            {
                                numFactura = Controles.InputBox("Se imprimirá la FCF N° : ", "FACTURA CONSUMIDOR FINAL");
                            }
                            dbPAC.changeFCF(SELECTED.ID_PAC, numFactura);
                            ImprimirFactura();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL IMPRIMIR RECIBO PAC", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR AL IMPRIMIR RECIBO PAC", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }







        private void REIMPRIMIR(object sender, EventArgs e)
        {
            if (tblHistorialPAC.CurrentCell != null && tblHistorialPAC.SelectedRows.Count == 1)
            {
                if (SELECTED != null)
                {
                    if (SELECTED.INTERES <= 0)
                    {
                        DialogResult printer = MessageBox.Show("REIMPRIMIR RECIBO P.A.C?", "REIMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (printer == DialogResult.Yes)
                        {
                            ImprimirReciboPAC();
                        }
                    }
                    else
                    {
                        DialogResult fcf = MessageBox.Show("REIMPRIMIR FACTURA?", "REIMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (fcf == DialogResult.Yes)
                        {
                            DialogResult cambiar = MessageBox.Show(" Cambiar numero de FACTURA # " + SELECTED.DOCUMENTO + "?", "REIMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (cambiar == DialogResult.Yes)
                            {
                                string numFactura = string.Empty;
                                while (numFactura.Trim() == string.Empty)
                                {
                                    numFactura = Controles.InputBox("Se imprimirá la FCF N° : ", "FACTURA CONSUMIDOR FINAL");
                                }
                                dbPAC.changeFCF(SELECTED.ID_PAC, numFactura);
                            }
                            ImprimirFactura();
                        }
                    }
                }
            }
        }


        private void ImprimirFactura()
        {
            switch (Properties.Settings.Default.FCF_FORMAT)
            {
                case eFormatFCF.FORMATO_1:
                    ImprimirFCF_FORMATO_1();
                    break;
                case eFormatFCF.FORMATO_2:
                    ImprimirFCF_FORMATO_2();
                    break;
            }
        }


        private void ImprimirReciboPAC()
        {
            viewerRECIBO.Clear();
            if (SELECTED != null && SELECTED.INTERES <= 0)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(SELECTED.COD_SUC).Copy();
                    //IMPRIMIR RECIBO
                    ReportParameter[] parameters = new ReportParameter[19];
                    parameters[0] = new ReportParameter("Sucursal", SUC.SUCURSAL);
                    parameters[1] = new ReportParameter("DireccionSUC", SUC.DIRECCION);
                    parameters[2] = new ReportParameter("TelSUC", "TEL: " + SUC.TEL);
                    parameters[3] = new ReportParameter("NumRECIBO", SELECTED.RECIBO);
                    parameters[4] = new ReportParameter("CLIENTE", SELECTED.CONTRATO.CLIENTE);
                    parameters[5] = new ReportParameter("ARTICULO", SELECTED.CONTRATO.ARTICULO);
                    parameters[6] = new ReportParameter("SaldoActual", SELECTED.SALDO_ANTERIOR.ToString("C2"));
                    parameters[7] = new ReportParameter("Interes", SELECTED.INTERES.ToString("C2"));
                    parameters[8] = new ReportParameter("Descuento", SELECTED.DESCUENTO.ToString("C2"));
                    parameters[9] = new ReportParameter("Abono", SELECTED.ABONO.ToString("C2"));
                    parameters[10] = new ReportParameter("Total", SELECTED.TOTAL.ToString("C2"));
                    parameters[11] = new ReportParameter("NuevoSaldo", SELECTED.NUEVO_SALDO.ToString("C2"));
                    parameters[12] = new ReportParameter("NuevoInteres", SELECTED.NUEVO_INTERES.ToString("C2"));
                    parameters[13] = new ReportParameter("EMPLEADO", SELECTED.RESPONSABLE);
                    parameters[14] = new ReportParameter("FechaPago", SELECTED.FECHA.Date.ToString("dd/MM/yyyy"));
                    parameters[15] = new ReportParameter("NumCONTRATO", SELECTED.CONTRATO.DOCUMENTO);
                    parameters[16] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));
                    if ((SELECTED.MESES + SELECTED.DIAS) > 0)
                    {
                        parameters[17] = new ReportParameter("PeriodoPagado", "Prorroga:(" + SELECTED.MESES + " Meses - " + SELECTED.DIAS + " Dias) Del " + SELECTED.DESDE.Date.ToString("dd/MM/yyyy") + " al " + SELECTED.HASTA.Date.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        parameters[17] = new ReportParameter("PeriodoPagado", "------------");
                    }
                    if (SELECTED.TIPO == eTipoMovPac.CANCELACION)
                    {
                        parameters[18] = new ReportParameter("ProximoPago", SELECTED.TIPO.ToString());
                    }
                    else
                    {
                        parameters[18] = new ReportParameter("ProximoPago", SELECTED.PROXIMO_PAGO.Date.ToString("dd/MM/yyyy"));
                    }
                    viewerRECIBO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReciboPAC.rdlc";
                    viewerRECIBO.LocalReport.SetParameters(parameters);
                    viewerRECIBO.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR RECIBO PAC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }





        private void ImprimirFCF_FORMATO_1()
        {
            viewerRECIBO.Clear();
            if (SELECTED != null && SELECTED.INTERES > 0)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(SELECTED.COD_SUC).Copy();
                    dSItemFCF.Clear();
                    dSItemFCF.ITEM.AddITEMRow("", SELECTED.MESES + " Meses " + SELECTED.DIAS + " Dias " + " INTERES Cto #" + SELECTED.CONTRATO.DOCUMENTO, SELECTED.INTERES);
                    if (SELECTED.DESCUENTO > 0)
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "DESCUENTO APLICADO S/INTERES ", -SELECTED.DESCUENTO);
                    }
                    else
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                    }
                    if (SELECTED.ABONO > 0)
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "ABONO A CAPITAL:  " + SELECTED.ABONO, Decimal.Zero);
                    }
                    else
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                    }
                    switch (SELECTED.TIPO)
                    {
                        case eTipoMovPac.CANCELACION:
                            dSItemFCF.ITEM.AddITEMRow("", eTipoMovPac.CANCELACION.ToString(), Decimal.Zero);
                            dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                            break;
                        case eTipoMovPac.ABONO:
                            dSItemFCF.ITEM.AddITEMRow("", "Proximo Pago: " + SELECTED.PROXIMO_PAGO.Date.ToString("dd/MM/yyyy"), Decimal.Zero);
                            dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                            break;
                        case eTipoMovPac.PRORROGA:
                            dSItemFCF.ITEM.AddITEMRow("", "Proximo Pago: " + SELECTED.PROXIMO_PAGO.Date.ToString("dd/MM/yyyy"), Decimal.Zero);
                            dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                            break;
                    }
                    bindingFCF.DataSource = dSItemFCF.ITEM;

                    ReportParameter[] parameters = new ReportParameter[10];
                    parameters[0] = new ReportParameter("DOCUMENTO", SELECTED.RECIBO);
                    parameters[1] = new ReportParameter("SUCURSAL", SUC.SUCURSAL);
                    parameters[2] = new ReportParameter("CLIENTE", SELECTED.CONTRATO.CLIENTE);
                    parameters[3] = new ReportParameter("DIA", SELECTED.FECHA.Date.ToString("dd"));
                    parameters[4] = new ReportParameter("MES", SELECTED.FECHA.Date.ToString("MMM").ToUpper());
                    parameters[5] = new ReportParameter("ANIO", SELECTED.FECHA.Date.ToString("yyyy"));
                    parameters[6] = new ReportParameter("SUMAS", (SELECTED.INTERES - SELECTED.DESCUENTO).ToString("C2"));
                    parameters[7] = new ReportParameter("CESC", "");
                    parameters[8] = new ReportParameter("TOTAL", (SELECTED.INTERES - SELECTED.DESCUENTO).ToString("C2"));
                    parameters[9] = new ReportParameter("LETRAS", HOME.Instance().convertirCantidadEnLetras((SELECTED.INTERES - SELECTED.DESCUENTO)));

                    viewerRECIBO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.FCF_Formato1.rdlc";
                    viewerRECIBO.LocalReport.DataSources.Clear();
                    viewerRECIBO.LocalReport.DataSources.Add(new ReportDataSource("ITEM", bindingFCF));
                    viewerRECIBO.LocalReport.SetParameters(parameters);
                    viewerRECIBO.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult detalle = MessageBox.Show("IMPRIMIR DETALLE AL REVERSO DE LA FACTURA?", "IMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (detalle == DialogResult.Yes)
                {
                    ImprimirReversoFactura();
                }
                
            }
        }



        private void ImprimirFCF_FORMATO_2()
        {
            viewerRECIBO.Clear();
            if (SELECTED != null && SELECTED.INTERES > 0)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(SELECTED.COD_SUC).Copy();
                    dSItemFCF.Clear();
                    dSItemFCF.ITEM.AddITEMRow("", SELECTED.MESES + " Meses " + SELECTED.DIAS + " Dias " + " INTERES Cto #" + SELECTED.CONTRATO.DOCUMENTO, SELECTED.INTERES);
                    if (SELECTED.DESCUENTO > 0)
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "DESCUENTO APLICADO S/INTERES ", -SELECTED.DESCUENTO);
                    }
                    else
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                    }
                    if (SELECTED.ABONO > 0)
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "ABONO A CAPITAL:  " + SELECTED.ABONO, Decimal.Zero);
                    }
                    else
                    {
                        dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                    }
                    switch (SELECTED.TIPO)
                    {
                        case eTipoMovPac.CANCELACION:
                            dSItemFCF.ITEM.AddITEMRow("", eTipoMovPac.CANCELACION.ToString(), Decimal.Zero);
                            //dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                            break;
                        case eTipoMovPac.ABONO:
                            dSItemFCF.ITEM.AddITEMRow("", "Proximo Pago: " + SELECTED.PROXIMO_PAGO.Date.ToString("dd/MM/yyyy"), Decimal.Zero);
                            //dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                            break;
                        case eTipoMovPac.PRORROGA:
                            dSItemFCF.ITEM.AddITEMRow("", "Proximo Pago: " + SELECTED.PROXIMO_PAGO.Date.ToString("dd/MM/yyyy"), Decimal.Zero);
                            //dSItemFCF.ITEM.AddITEMRow("", "", Decimal.Zero);
                            break;
                    }
                    bindingFCF.DataSource = dSItemFCF.ITEM;

                    ReportParameter[] parameters = new ReportParameter[10];
                    parameters[0] = new ReportParameter("DOCUMENTO", SELECTED.RECIBO);
                    parameters[1] = new ReportParameter("SUCURSAL", SUC.SUCURSAL);
                    parameters[2] = new ReportParameter("CLIENTE", SELECTED.CONTRATO.CLIENTE);
                    parameters[3] = new ReportParameter("DIA", SELECTED.FECHA.Date.ToString("dd"));
                    parameters[4] = new ReportParameter("MES", SELECTED.FECHA.Date.ToString("MMM").ToUpper());
                    parameters[5] = new ReportParameter("ANIO", SELECTED.FECHA.Date.ToString("yyyy"));
                    parameters[6] = new ReportParameter("SUMAS", (SELECTED.INTERES - SELECTED.DESCUENTO).ToString("C2"));
                    parameters[7] = new ReportParameter("CESC", "");
                    parameters[8] = new ReportParameter("TOTAL", (SELECTED.INTERES - SELECTED.DESCUENTO).ToString("C2"));
                    parameters[9] = new ReportParameter("LETRAS", HOME.Instance().convertirCantidadEnLetras((SELECTED.INTERES - SELECTED.DESCUENTO)));

                    viewerRECIBO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.FCF_Formato2.rdlc";
                    viewerRECIBO.LocalReport.DataSources.Clear();
                    viewerRECIBO.LocalReport.DataSources.Add(new ReportDataSource("ITEM", bindingFCF));
                    viewerRECIBO.LocalReport.SetParameters(parameters);
                    viewerRECIBO.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult detalle = MessageBox.Show("IMPRIMIR DETALLE AL REVERSO DE LA FACTURA?", "IMPRIMIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (detalle == DialogResult.Yes)
                {
                    ImprimirReversoFactura();
                }

            }
        }



        private void ImprimirReversoFactura()
        {
            //IMPRIMIR DETALLE AL REVERSO DE LA FACTURA
            viewerRECIBO.Clear();
            try
            {
                ReportParameter[] parameters = new ReportParameter[13];
                parameters[0] = new ReportParameter("numRECIBO", SELECTED.RECIBO);
                parameters[1] = new ReportParameter("CONTRATO", SELECTED.CONTRATO.DOCUMENTO);
                parameters[2] = new ReportParameter("CLIENTE", SELECTED.CONTRATO.CLIENTE);
                parameters[3] = new ReportParameter("ARTICULO", SELECTED.CONTRATO.ARTICULO);
                parameters[4] = new ReportParameter("SaldoActual", SELECTED.SALDO_ANTERIOR.ToString("C2"));
                parameters[5] = new ReportParameter("Interes", SELECTED.INTERES.ToString("C2"));
                parameters[6] = new ReportParameter("Descuento", SELECTED.DESCUENTO.ToString("C2"));
                parameters[7] = new ReportParameter("Abono", SELECTED.ABONO.ToString("C2"));
                parameters[8] = new ReportParameter("Total", SELECTED.TOTAL.ToString("C2"));
                parameters[9] = new ReportParameter("NuevoSaldo", SELECTED.NUEVO_SALDO.ToString("C2"));
                parameters[10] = new ReportParameter("NuevoInteres", SELECTED.NUEVO_INTERES.ToString("C2"));
                if ((SELECTED.MESES + SELECTED.DIAS) > 0)
                {
                    parameters[11] = new ReportParameter("PeriodoPagado", "Prorroga:(" + SELECTED.MESES + " Meses - " + SELECTED.DIAS + " Dias) Del " + SELECTED.DESDE.Date.ToString("dd/MM/yyyy") + " al " + SELECTED.HASTA.Date.ToString("dd/MM/yyyy"));
                }
                else
                {
                    parameters[11] = new ReportParameter("PeriodoPagado", "------------");
                }
                if (SELECTED.TIPO == eTipoMovPac.CANCELACION)
                {
                    parameters[12] = new ReportParameter("ProximoPago", SELECTED.TIPO.ToString());
                }
                else
                {
                    parameters[12] = new ReportParameter("ProximoPago", SELECTED.PROXIMO_PAGO.Date.ToString("dd/MM/yyyy"));
                }


                viewerRECIBO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.FCF_Reverse.rdlc";
                viewerRECIBO.LocalReport.SetParameters(parameters);
                viewerRECIBO.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR DETALLE LA REVERSO DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }




        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerRECIBO.PrintDialog();
            }
        }



        private void btnHistorialPAC_Click(object sender, EventArgs e)
        {
            if (PAC != null && PAC.CONTRATO != null)
            {
               //IMPRIMIR HISTORIAL CONTRATO
                viewerRECIBO.Clear();
                dSHistorialPAC.Clear();
                try
                {
                    int id = 0;
                    foreach (DataRow row in PAC.CONTRATO.HISTORIAL_PAC.Rows)
                    {
                        id++;
                        Pac actual = Pac.ConvertToPAC(row);
                        actual.CONTRATO = PAC.CONTRATO.Copy();
                        dSHistorialPAC.HISTORIAL.AddHISTORIALRow(id, actual.FECHA, actual.DOCUMENTO, actual.TIPO.ToString(), actual.MESES, actual.DIAS, actual.INTERES,actual.DESCUENTO, actual.ABONO, actual.TOTAL, actual.DESDE, actual.HASTA, actual.PROXIMO_PAGO);
                    }
                    bsHistorialPAC.DataSource = dSHistorialPAC.HISTORIAL;

                    ReportParameter[] parameters = new ReportParameter[12];
                    parameters[0] = new ReportParameter("CONTRATO", PAC.CONTRATO.DOCUMENTO);
                    parameters[1] = new ReportParameter("FECHA", PAC.CONTRATO.FECHA.ToShortDateString());
                    parameters[2] = new ReportParameter("CLIENTE", PAC.CONTRATO.CLIENTE);
                    parameters[3] = new ReportParameter("DUI", PAC.CONTRATO.DUI);
                    parameters[4] = new ReportParameter("ARTICULO", PAC.CONTRATO.ARTICULO);
                    parameters[5] = new ReportParameter("PRESTAMO", PAC.CONTRATO.TOTAL.ToString("C2"));
                    parameters[6] = new ReportParameter("ESTADO", PAC.CONTRATO.ESTADO_CONTRATO.ToString());
                    parameters[7] = new ReportParameter("SALDO", PAC.CONTRATO.SALDO.ToString("C2"));
                    parameters[8] = new ReportParameter("INTERES", PAC.CONTRATO.INTERES_MENSUAL.ToString("C2"));
                    parameters[9] = new ReportParameter("DIARIO", PAC.CONTRATO.INTERES_DIARIO.ToString("C2"));
                    parameters[10] = new ReportParameter("VENCIMIENTO", PAC.CONTRATO.FECHA_VENC.ToShortDateString());
                    parameters[11] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToShortDateString());


                    viewerRECIBO.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.RptHistorialPAC.rdlc";
                    viewerRECIBO.LocalReport.DataSources.Add(new ReportDataSource("HISTORIAL", bsHistorialPAC));
                    viewerRECIBO.LocalReport.SetParameters(parameters);
                    viewerRECIBO.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR AL GENERAR HISTORIAL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
               
            }
            else
            {
                MessageBox.Show("NO HA CARGADO CONTRATO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void LOG(object sender, EventArgs e)
        {

        }





        private void AYUDA(object sender, EventArgs e)
        {

        }





        private void CAJEAR_CUPON(object sender, EventArgs e)
        {
            //VERIFICAR REGLAS DE CANJE
            if (verificarReglasCanje())
            {
                //INTRODUCIR NUMERO DE CUPON
                ComboBox cbxCupon = Controles.ComboInputBox("Ingrese el numero de billete o cupon:", "CANJEAR CUPON", Enum.GetValues(new eTipoCupon().GetType()));
                //BUSCAR CUPON
                if (cbxCupon != null && cbxCupon.Tag != null && cbxCupon.Tag.ToString() != string.Empty)
                {
                    try
                    {
                        int numeroCupon = Int32.Parse(cbxCupon.Tag.ToString());
                        if (numeroCupon > 0)
                        {
                            CuponX = Cupon.ConvertToCupon(dbCupon.searchCuponDesc((eTipoCupon)cbxCupon.SelectedItem, numeroCupon));
                            if (CuponX != null)
                            {
                                // DISPONIBILIDAD DEL CUPON
                                CuponX.NUMCUPON = numeroCupon;
                                if (dbCupon.isCuponDisponible(CuponX))
                                {
                                    if (CuponX.FECHA_EXP <= PAC.FECHA && CuponX.FECHA_VENC >= PAC.FECHA)
                                    {
                                        DialogResult canjear = MessageBox.Show(CuponX.TIPO.ToString() + " localizado con el " + CuponX.DESC_INTERES + " % de descuento sobre interes mensual ... Desea Aplicarlo ?", "REALIZAR CANJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (canjear == DialogResult.Yes)
                                        {
                                            MessageBox.Show("DESCUENTO sobre interes por canje de " + CuponX.TIPO.ToString() + " # " + CuponX.NUMCUPON + " APLICADO", "DESCUENTO APLICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            CuponX = null;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cupon o billete a expirado ... Verifique el numero del " + CuponX.TIPO.ToString(), "ERROR BUSCAR CUPON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Este cupon ya ha sido conjeado ... Verifique el numero del " + CuponX.TIPO.ToString(), "ERROR BUSCAR CUPON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    CuponX = null;
                                }
                            }
                            else
                            {
                                CuponX = null;
                                MessageBox.Show("CUPON o BILLETE NO EXISTE O TIRAJE DESACTIVADO", "ERROR BUSCAR CUPON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        CuponX = null;
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    CuponX = null;
                }
            }
            calcularTotales();
        }

            



        public bool verificarReglasCanje()
        {
            bool OK = true;
            if (PAC != null && PAC.CONTRATO != null)
            {
                //CONTRATO CON MENOS DE 60 DIAS
                if (PAC.CONTRATO.DIAS_TRANS > 60)
                {
                    OK = false;
                    MessageBox.Show( "DESCUENTO POR CUPON NO APLICA .... Contrato Excede los 60 dias","VALIDACION DE CUPON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //AL MENOS UN MES PARA APLICAR
                if (PAC.MESES <= 0)
                {
                    OK = false;
                    MessageBox.Show("DESCUENTO POR CUPON NO APLICA .... Solo se aplican a meses completos", "VALIDACION DE CUPON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                OK = false;
                MessageBox.Show("NO HA CARGADO NINGUN CONTRATO","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }

            








    }
}
