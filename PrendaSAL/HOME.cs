using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Media;
using System.IO;
using Microsoft.Win32;

namespace PrendaSAL
{
    using DDB;
    using MODELO;

    public partial class HOME : Office2007Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static HOME frmInstance = null;
        
        public static HOME Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new HOME();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBSucursal dbSucursal;
        private DBCatalogo dbCatalogo;
        private DBUsuario dbUser;
        private DBPRENDASAL dbPrendaSAL;
        private DBMovCash dbMovCash;

        public DateTime FECHA_SISTEMA;
        public Sucursal SUCURSAL;
        public Usuario USUARIO;
        public string SISTEMA;
        public string TIPO_SESION;

        public int FINANCIAMIENTOS_PENDIENTES;

        public ToolStripProgressBar progress {
            get
            {
                return this.progressBarStatus;
            }
       }

        public DataTable datSUCURSALES;
        public DataTable datCATEGORIAS;

        public HOME()
        {
            InitializeComponent();
            this.Font = SystemFonts.IconTitleFont;
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            this.PerformAutoScale();
            dbPrendaSAL = new DBPRENDASAL();
            dbCatalogo = new DBCatalogo();
            dbSucursal = new DBSucursal();
            dbUser = new DBUsuario();
            dbMovCash = new DBMovCash();
            SISTEMA = Properties.Settings.Default.SISTEMA;

            Control.CheckForIllegalCrossThreadCalls = false;
            timer.Enabled = true;

        }


        void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
            }
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }


        private void HOME_Load(object sender, EventArgs e)
        {
            moduloMOVIMIENTOS.Select();
            MENU_PRINCIPAL.Expanded = false;
            cargarDatosIniciales();
        }







        public void LOGOUT()
        {
            USUARIO = null;
            SUCURSAL = null;
            LoginForm logear = new LoginForm();
            logear.Show();
            this.Hide();
        }






        public void OPEN_SESION(Usuario USER, Sucursal SUC, DateTime FECHA)
        {
            
            this.Show();
            USUARIO = USER;
            SUCURSAL = SUC;
            FECHA_SISTEMA = FECHA;
            MENU_PRINCIPAL.Visible = true;
            STATUS_BAR.Visible = true;// Sonido de inicio de sesion
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.Startup_Ubuntu;

            statusLabelFecha.Text = FECHA_SISTEMA.Date.ToString("dd/MM/yyyy");
            statusLabelSucursal.Text = SUCURSAL.SUCURSAL;
            statusCODEMPLEADO.Text = USUARIO.COD_EMPLEADO;
            statusEMPLEADO.Text = USUARIO.NOMBRE;
            statusTipoSesion.Text = USUARIO.TIPO.ToString();

            cargarPermisos();
            player.Play();
        }





        private void bloquearTodo()
        {
            //MODULO CATALOGOS
            moduloCATALOGOS.Visible = false;
            btnMenuClientes.Visible = false;
            btnMenuAMIGO.Visible = false;
            btnMenuVIP.Visible = false;
            btnMenuCupones.Visible = false;
            //MODULO MOVIMIENTOS
            moduloMOVIMIENTOS.Visible = false;
            btnMenuContratos.Visible = false;
            btnMenuPAC.Visible = false;
            btnMenuCompras.Visible = false;
            btnMenuVentas.Visible = false;
            btnMenuFinanc.Visible = false;
            btnMenuRemesas.Visible = false;
            btnMenuGastos.Visible = false;
            btnMenuSFC.Visible = false;
            btnCorteDiario.Visible = false;
            //MODULO OPERACIONES
            moduloOPERACIONES.Visible = false;
            btnMenuCierreVencidos.Visible = false;
            btnMenuRecibirInv.Visible = false;
            btnMenuEnviarInv.Visible = false;
            btnInventarioInicial.Visible = false;
            //MODULO REPORTES
            moduloREPORTES.Visible = false;
            btnRptInvCustodia.Visible = false;
            btnRptInvVenta.Visible = false;
            btnRptKardex.Visible = false;
            btnRptTransDiarias.Visible = false;
            btnRptCancelados.Visible = false;
            btnRptContratos.Visible = false;
            btnRptContratosVigentes.Visible = false;
            btnRptEstadoCuenta.Visible = false;
            btnRptComprasORO.Visible = false;
            btnRptVencidosORO.Visible = false;
            btnRptConsolidado.Visible = false;
            btnRptCarteraVigente.Visible = false;
            //MODULO CONFIGURACION
            moduloCONFIG.Visible = false;
            btnConfigPrecios.Visible = false;
            btnConfigReglas.Visible = false;
            btnConfigUsuarios.Visible = false;
            btnConfigPermisos.Visible = false;
            btnConfigMiCuenta.Visible = false;
            btnConfigConexionDB.Visible = false;
            btnConfigSucursales.Visible = false;
        }






        private void cargarPermisos()
        {
            bloquearTodo();
            USUARIO.PERMISOS = dbUser.getPermisos(Properties.Settings.Default.SISTEMA, USUARIO.TIPO);
            foreach(DataRow p in USUARIO.PERMISOS.Rows)
            {
                switch (p.Field<string>("MODULO"))
                {
                        //MODULO CATALOGOS
                    case "CATALOGOS":
                        switch (p.Field<string>("MENU"))
                        { 
                            case "Clientes":
                                btnMenuClientes.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "AMIGO":
                                btnMenuAMIGO.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "V.I.P":
                                btnMenuVIP.Visible = p.Field<bool>("ACCESO");
                                break;
                        }
                        break;

                        //MODULO MOVIMIENTOS
                    case "MOVIMIENTOS":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Contratos":
                                btnMenuContratos.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "P.A.C":
                                btnMenuPAC.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Compras":
                                btnMenuCompras.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Ventas":
                                btnMenuVentas.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Financiamiento":
                                btnMenuFinanc.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Remesa":
                                btnMenuRemesas.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Gastos":
                                btnMenuGastos.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "S.F.C":
                                btnMenuSFC.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Corte Diario":
                                btnCorteDiario.Visible = p.Field<bool>("ACCESO");
                                break;
                        }
                        break;

                        //MODULO OPERACIONES
                    case "OPERACIONES":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Lista Vencidos":
                                btnMenuCierreVencidos.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Recibir":
                                btnMenuRecibirInv.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Enviar":
                                btnMenuEnviarInv.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Corte Inicial":
                                btnInventarioInicial.Visible = p.Field<bool>("ACCESO");
                                break;
                        }
                        break;

                    //MODULO REPORTES
                    case "REPORTES":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Resguardo":
                                btnRptInvCustodia.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "En Venta":
                                btnRptInvVenta.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Transacciones":
                                btnRptTransDiarias.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Contratos":
                                btnRptContratos.Visible = p.Field<bool>("ACCESO");
                                btnRptContratosVigentes.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Compras":
                                btnRptComprasORO.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Vencidos":
                                btnRptVencidosORO.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Kardex":
                                btnRptKardex.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Cancelados":
                                btnRptCancelados.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Consolidado":
                                btnRptConsolidado.Visible = p.Field<bool>("ACCESO");
                                btnRptCarteraVigente.Visible = p.Field<bool>("ACCESO");
                                btnMenuCupones.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Estado Cuenta":
                                btnRptEstadoCuenta.Visible = p.Field<bool>("ACCESO");
                                break;
                        }
                        
                        break;

                    //MODULO CONFIGURACION
                    case "CONFIGURACION":
                        switch (p.Field<string>("MENU"))
                        {
                            case "Precios":
                                btnConfigPrecios.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Negocio":
                                btnConfigReglas.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Base de Datos":
                                btnConfigConexionDB.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Sucursales":
                                btnConfigSucursales.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Mi Cuenta":
                                btnConfigMiCuenta.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Usuarios":
                                btnConfigUsuarios.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Permisos":
                                btnConfigPermisos.Visible = p.Field<bool>("ACCESO");
                                
                                break;
                        }
                        break;

                }
            }


            //VISIBILIDAD DE MODULOS
            moduloCATALOGOS.Visible = (btnMenuClientes.Visible || btnMenuAMIGO.Visible || btnMenuVIP.Visible );
            grupoClientes.Visible = (btnMenuClientes.Visible || btnMenuAMIGO.Visible || btnMenuVIP.Visible);
            grupoPromociones.Visible = btnMenuCupones.Visible;
            moduloMOVIMIENTOS.Visible =(btnMenuContratos.Visible || btnMenuPAC.Visible || btnMenuCompras.Visible || btnMenuVentas.Visible || btnMenuFinanc.Visible || btnMenuRemesas.Visible || btnMenuGastos.Visible || btnMenuSFC.Visible || btnCorteDiario.Visible);
            grupoTransComerciales.Visible = (btnMenuContratos.Visible || btnMenuPAC.Visible || btnMenuCompras.Visible || btnMenuVentas.Visible);
            grupoCajaChica.Visible = (btnMenuFinanc.Visible || btnMenuRemesas.Visible || btnMenuGastos.Visible || btnMenuSFC.Visible);
            moduloOPERACIONES.Visible = (btnMenuCierreVencidos.Visible || btnMenuRecibirInv.Visible || btnMenuEnviarInv.Visible || btnInventarioInicial.Visible);
            grupoOperacionesInventario.Visible = (btnMenuCierreVencidos.Visible || btnMenuRecibirInv.Visible || btnMenuEnviarInv.Visible || btnInventarioInicial.Visible);
            moduloREPORTES.Visible = (btnRptInvCustodia.Visible  || btnRptInvVenta.Visible || btnRptTransDiarias.Visible || btnRptContratos.Visible || btnRptComprasORO.Visible || btnRptKardex.Visible || btnRptCancelados.Visible || btnRptEstadoCuenta.Visible || btnRptVencidosORO.Visible || btnRptConsolidado.Visible);
            grupoReportesInventario.Visible = (btnRptInvCustodia.Visible || btnRptInvVenta.Visible || btnRptKardex.Visible);
            grupoReporteVarios.Visible = btnRptContratos.Visible || btnRptContratosVigentes.Visible ||btnRptTransDiarias.Visible || btnRptCancelados.Visible || btnRptEstadoCuenta.Visible;
            grupoReportesConta.Visible =  btnRptComprasORO.Visible || btnRptVencidosORO.Visible;
            grupoReportesGerenciales.Visible = btnRptConsolidado.Visible || btnRptCarteraVigente.Visible;
            moduloCONFIG.Visible = (btnConfigPrecios.Visible || btnConfigReglas.Visible || btnConfigConexionDB.Visible || btnConfigSucursales.Visible || btnConfigMiCuenta.Visible || btnConfigUsuarios.Visible || btnConfigPermisos.Visible);
            grupoConfigAdmin.Visible = (btnConfigPrecios.Visible || btnConfigReglas.Visible);
            grupoConfigConexion.Visible = (btnConfigConexionDB.Visible || btnConfigSucursales.Visible || btnConfigMiCuenta.Visible || btnConfigUsuarios.Visible || btnConfigPermisos.Visible);
            
        }
                    




        private void HOME_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("CERRAR LA APLICACION?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                LOGOUT();
            }
        }



        private void CERRAR_SESION(object sender, EventArgs e)
        {
            ventanasCERRAR(null, null);
            moduloMOVIMIENTOS.Select();
            LOGOUT();
        }


        public void RESTART(object sender, EventArgs e)
        {
            DialogResult reiniciar = MessageBox.Show("DESEA REINICIAR APLICACION?", "ERROR INESPERADO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (reiniciar == DialogResult.Yes)
            {
                Application.Restart();
            }
        }



        public void EXIT(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }



        private void cargarDatosIniciales()
        {
            //SUCURSALES PRENDASAL
            datSUCURSALES = dbSucursal.showSucursales();

            datCATEGORIAS = dbCatalogo.showCategorias();
        }


        public Sucursal getSucursal(string codsuc)
        {
            Sucursal suc = null;
            if (datSUCURSALES != null)
            {
                foreach (DataRow row in datSUCURSALES.Rows)
                {
                    if (row.Field<string>("COD_SUC") == codsuc)
                    {
                        suc = Sucursal.ConverterToSucursal(row);
                        break;
                    }
                }
            }
            return suc;
        }


        public DataTable getSucursalesException(string codsuc)
        {
            DataTable SUCURSALES = datSUCURSALES.Copy();
            if (SUCURSALES != null)
            {
                foreach (DataRow row in SUCURSALES.Rows)
                {
                    if (row.Field<string>("COD_SUC") == codsuc)
                    {
                        SUCURSALES.Rows.Remove(row);
                        break;
                    }
                }
            }
            return SUCURSALES;
        }






        
        private void ventanasCASCADA(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }



        private void ventanasPARALELO(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void ventanasCERRAR(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void ventanasMinimizar(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Minimized;
            }
        }



        private void BUSCAR_TRANSACCION(object sender, EventArgs e)
        {

        }



        // MENU CATALOGOS

        private void menuCatalogosClientes(object sender, EventArgs e)
        {
            Catalogos.ClientesForm cartera;
            cartera = Catalogos.ClientesForm.Instance();
            cartera.MdiParent = this;
            cartera.Show();
            if (cartera.WindowState == FormWindowState.Minimized)
            {
                cartera.WindowState = FormWindowState.Normal;
            }
        }


        private void menuCatalogosClientesAMIGO(object sender, EventArgs e)
        {
            Catalogos.ClienteAmigoForm amigo;
            amigo = Catalogos.ClienteAmigoForm.Instance();
            amigo.MdiParent = this;
            amigo.Show();
            if (amigo.WindowState == FormWindowState.Minimized)
            {
                amigo.WindowState = FormWindowState.Normal;
            }
        }


        private void menuCatalogosClientesVIP(object sender, EventArgs e)
        {
            Catalogos.ClienteVIPForm vip;
            vip = Catalogos.ClienteVIPForm.Instance();
            vip.MdiParent = this;
            vip.Show();
            if (vip.WindowState == FormWindowState.Minimized)
            {
                vip.WindowState = FormWindowState.Normal;
            }
        }



        private void menuCatalogosPromocionesCupones(object sender, EventArgs e)
        {
            Catalogos.CuponesForm cupones;
            cupones = Catalogos.CuponesForm.Instance();
            cupones.MdiParent = this;
            cupones.Show();
            if (cupones.WindowState == FormWindowState.Minimized)
            {
                cupones.WindowState = FormWindowState.Normal;
            }
        }




        // MENU MOVIMIENTOS

        private void menuMovimientosContratos(object sender, EventArgs e)
        {
            Movimientos.ContratosForm contrato;
            contrato = Movimientos.ContratosForm.Instance();
            contrato.MdiParent = this;
            contrato.Show();
            if (contrato.WindowState == FormWindowState.Minimized)
            {
                contrato.WindowState = FormWindowState.Normal;
            }
        }


        private void menuMovimientosPAC(object sender, EventArgs e)
        {
            Movimientos.PACForm pac;
            pac = Movimientos.PACForm.Instance();
            pac.MdiParent = this;
            pac.Show();
            if (pac.WindowState == FormWindowState.Minimized)
            {
                pac.WindowState = FormWindowState.Normal;
            }
        }



        private void menuMovimientosCompras(object sender, EventArgs e)
        {
            Movimientos.ComprasForm compras;
            compras = Movimientos.ComprasForm.Instance();
            compras.MdiParent = this;
            compras.Show();
            if (compras.WindowState == FormWindowState.Minimized)
            {
                compras.WindowState = FormWindowState.Normal;
            }
        }

        private void menuMovimientosVentas(object sender, EventArgs e)
        {
            Movimientos.VentasForm ventas;
            ventas = Movimientos.VentasForm.Instance();
            ventas.MdiParent = this;
            ventas.Show();
            if (ventas.WindowState == FormWindowState.Minimized)
            {
                ventas.WindowState = FormWindowState.Normal;
            }
        }


        private void menuMovimientosCajaRemesa(object sender, EventArgs e)
        {
            Caja.RemesasForm remesas;
            remesas = Caja.RemesasForm.Instance();
            remesas.MdiParent = this;
            remesas.Show();
            if (remesas.WindowState == FormWindowState.Minimized)
            {
                remesas.WindowState = FormWindowState.Normal;
            }
        }


        private void menuMovimientosCajaFinanc(object sender, EventArgs e)
        {
            Caja.FinancForm financ;
            financ = Caja.FinancForm.Instance();
            financ.MdiParent = this;
            financ.Show();
            if (financ.WindowState == FormWindowState.Minimized)
            {
                financ.WindowState = FormWindowState.Normal;
            }
        }


        private void menuMovimientosCajaGasto(object sender, EventArgs e)
        {
            Caja.GastosForm gastos;
            gastos = Caja.GastosForm.Instance();
            gastos.MdiParent = this;
            gastos.Show();
            if (gastos.WindowState == FormWindowState.Minimized)
            {
                gastos.WindowState = FormWindowState.Normal;
            }
        }




        private void menuMovimientosSFC(object sender, EventArgs e)
        {
            Caja.SFCForm sfc;
            sfc = Caja.SFCForm.Instance();
            sfc.MdiParent = this;
            sfc.Show();
            if (sfc.WindowState == FormWindowState.Minimized)
            {
                sfc.WindowState = FormWindowState.Normal;
            }
        }




        private void menuMovimientosCorteDiario(object sender, EventArgs e)
        {
            Movimientos.CorteDiarioForm corte;
            corte = Movimientos.CorteDiarioForm.Instance();
            corte.MdiParent = this;
            corte.Show();
            if (corte.WindowState == FormWindowState.Minimized)
            {
                corte.WindowState = FormWindowState.Normal;
            }
        }



        //MENU OPERACIONES


        private void menuOperacionesListaVencidos(object sender, EventArgs e)
        {
            Operaciones.ListaVencidosForm cierre;
            cierre = Operaciones.ListaVencidosForm.Instance();
            cierre.MdiParent = this;
            cierre.Show();
            if (cierre.WindowState == FormWindowState.Minimized)
            {
                cierre.WindowState = FormWindowState.Normal;
            }
        }


        private void menuOperacionesRecibirInv(object sender, EventArgs e)
        {
            Operaciones.RecibirTrasladoForm recepcion;
            recepcion = Operaciones.RecibirTrasladoForm.Instance();
            recepcion.MdiParent = this;
            recepcion.Show();
            if (recepcion.WindowState == FormWindowState.Minimized)
            {
                recepcion.WindowState = FormWindowState.Normal;
            }
        }

        private void menuOperacionesEnviarInv(object sender, EventArgs e)
        {
            Operaciones.EnviarTrasladoForm envio;
            envio = Operaciones.EnviarTrasladoForm.Instance();
            envio.MdiParent = this;
            envio.Show();
            if (envio.WindowState == FormWindowState.Minimized)
            {
                envio.WindowState = FormWindowState.Normal;
            }
        }


        private void menuOperacionesCorteInv(object sender, EventArgs e)
        {
            Operaciones.CorteInvInicialForm corteInv;
            corteInv = Operaciones.CorteInvInicialForm.Instance();
            corteInv.MdiParent = this;
            corteInv.Show();
            if (corteInv.WindowState == FormWindowState.Minimized)
            {
                corteInv.WindowState = FormWindowState.Normal;
            }
        }


        // MENU CONFIGURACION
        private void menuConfiguracionPrecios(object sender, EventArgs e)
        {
            Configuracion.PreciosForm precios;
            precios = Configuracion.PreciosForm.Instance();
            precios.MdiParent = this;
            precios.Show();
            if (precios.WindowState == FormWindowState.Minimized)
            {
                precios.WindowState = FormWindowState.Normal;
            }
        }




        private void menuConfiguracionReglasNegocio(object sender, EventArgs e)
        {
            Configuracion.ReglasNegocioForm reglas;
            reglas = Configuracion.ReglasNegocioForm.Instance();
            reglas.MdiParent = this;
            reglas.Show();
            if (reglas.WindowState == FormWindowState.Minimized)
            {
                reglas.WindowState = FormWindowState.Normal;
            }
        }


        private void menuConfiguracionUsuarios(object sender, EventArgs e)
        {
            Configuracion.UsuariosForm usuarios;
            usuarios = Configuracion.UsuariosForm.Instance();
            usuarios.MdiParent = this;
            usuarios.Show();
            if (usuarios.WindowState == FormWindowState.Minimized)
            {
                usuarios.WindowState = FormWindowState.Normal;
            }
        }

        private void menuConfiguracionPermisos(object sender, EventArgs e)
        {
            Configuracion.PermisosForm permisos;
            permisos = Configuracion.PermisosForm.Instance();
            permisos.MdiParent = this;
            permisos.Show();
            if (permisos.WindowState == FormWindowState.Minimized)
            {
                permisos.WindowState = FormWindowState.Normal;
            }
        }



        private void menuConfiguracionesSistema(object sender, EventArgs e)
        {
            Configuracion.ConfigForm config;
            config = new Configuracion.ConfigForm(false);
            config.MdiParent = this;
            config.Show();
            if (config.WindowState == FormWindowState.Minimized)
            {
                config.WindowState = FormWindowState.Normal;
            }
        }




        private void menuConfiguracionMiCuenta(object sender, EventArgs e)
        {
            Configuracion.MiCuentaForm cuenta;
            cuenta = Configuracion.MiCuentaForm.Instance();
            cuenta.MdiParent = this;
            cuenta.Show();
            if (cuenta.WindowState == FormWindowState.Minimized)
            {
                cuenta.WindowState = FormWindowState.Normal;
            }
        }

        


        private void menuConfiguracionSucursales(object sender, EventArgs e)
        {
            Configuracion.SucursalesForm sucursales;
            sucursales = Configuracion.SucursalesForm.Instance();
            sucursales.MdiParent = this;
            sucursales.Show();
            if (sucursales.WindowState == FormWindowState.Minimized)
            {
                sucursales.WindowState = FormWindowState.Normal;
            }
        }





        // MENU REPORTES
        private void menuReportesInventarioResguardo(object sender, EventArgs e)
        {
            Reportes.RInvResguardoForm invResguardo;
            invResguardo = Reportes.RInvResguardoForm.Instance();
            invResguardo.MdiParent = this;
            invResguardo.Show();
            if (invResguardo.WindowState == FormWindowState.Minimized)
            {
                invResguardo.WindowState = FormWindowState.Normal;
            }
        }




        private void menuReportesInventarioVenta(object sender, EventArgs e)
        {
            Reportes.RInvVentaForm invVenta;
            invVenta = Reportes.RInvVentaForm.Instance();
            invVenta.MdiParent = this;
            invVenta.Show();
            if (invVenta.WindowState == FormWindowState.Minimized)
            {
                invVenta.WindowState = FormWindowState.Normal;
            }
        }


        private void menuReportesKARDEX(object sender, EventArgs e)
        {
            Reportes.RKardexForm kardex;
            kardex = Reportes.RKardexForm.Instance();
            kardex.MdiParent = this;
            kardex.Show();
            if (kardex.WindowState == FormWindowState.Minimized)
            {
                kardex.WindowState = FormWindowState.Normal;
            }
        }

        private void menuReportesContratos(object sender, EventArgs e)
        {
            Reportes.RContratosForm contratos;
            contratos = Reportes.RContratosForm.Instance();
            contratos.MdiParent = this;
            contratos.Show();
            if (contratos.WindowState == FormWindowState.Minimized)
            {
                contratos.WindowState = FormWindowState.Normal;
            }
        }



        private void menuReportesContratosVigentes(object sender, EventArgs e)
        {
            Reportes.RContratosDiaForm vigentes;
            vigentes = Reportes.RContratosDiaForm.Instance();
            vigentes.MdiParent = this;
            vigentes.Show();
            if (vigentes.WindowState == FormWindowState.Minimized)
            {
                vigentes.WindowState = FormWindowState.Normal;
            }
        }




        private void menuReportesCancelados(object sender, EventArgs e)
        {
            Reportes.RCanceladosForm cancelados;
            cancelados = Reportes.RCanceladosForm.Instance();
            cancelados.MdiParent = this;
            cancelados.Show();
            if (cancelados.WindowState == FormWindowState.Minimized)
            {
                cancelados.WindowState = FormWindowState.Normal;
            }
        }

        


        private void menuReportesDiario(object sender, EventArgs e)
        {
            Reportes.RTransDiariasForm diario;
            diario = Reportes.RTransDiariasForm.Instance();
            diario.MdiParent = this;
            diario.Show();
            if (diario.WindowState == FormWindowState.Minimized)
            {
                diario.WindowState = FormWindowState.Normal;
            }
        }

        private void menuReportesEstadoCuenta(object sender, EventArgs e)
        {
            Reportes.REstadoCuentaForm estado;
            estado = Reportes.REstadoCuentaForm.Instance();
            estado.MdiParent = this;
            estado.Show();
            if (estado.WindowState == FormWindowState.Minimized)
            {
                estado.WindowState = FormWindowState.Normal;
            }
        }



        private void menuReporteComprasORO(object sender, EventArgs e)
        {
            Reportes.RComprasOroForm comprasOro;
            comprasOro = Reportes.RComprasOroForm.Instance();
            comprasOro.MdiParent = this;
            comprasOro.Show();
            if (comprasOro.WindowState == FormWindowState.Minimized)
            {
                comprasOro.WindowState = FormWindowState.Normal;
            }
        }

        private void menuReporteVencidosORO(object sender, EventArgs e)
        {
            Reportes.RVencidosOroForm vencOro;
            vencOro = Reportes.RVencidosOroForm.Instance();
            vencOro.MdiParent = this;
            vencOro.Show();
            if (vencOro.WindowState == FormWindowState.Minimized)
            {
                vencOro.WindowState = FormWindowState.Normal;
            }
        }


        private void menuReportesConsolidado(object sender, EventArgs e)
        {
            Reportes.RConsolidadoForm consolidado;
            consolidado = Reportes.RConsolidadoForm.Instance();
            consolidado.MdiParent = this;
            consolidado.Show();
            if (consolidado.WindowState == FormWindowState.Minimized)
            {
                consolidado.WindowState = FormWindowState.Normal;
            }
        }


        private void menuReportesCarteraVigente(object sender, EventArgs e)
        {
            Reportes.RCarteraVigenteForm cartera;
            cartera = Reportes.RCarteraVigenteForm.Instance();
            cartera.MdiParent = this;
            cartera.Show();
            if (cartera.WindowState == FormWindowState.Minimized)
            {
                cartera.WindowState = FormWindowState.Normal;
            }
        }




        
        //MENU AYUDA
        private void btnMenuAcercaDe_Click(object sender, EventArgs e)
        {
            ScannerPrueba scanner = new ScannerPrueba();
            scanner.Show();
        }
        
        
        
        
        
        
        // FUNCIONES GLOBALES


        public String convertirCantidadEnLetras(Decimal monto)
        {
            //float fraccion = new funciones().redondearMas(monto.floatValue() - (int)monto.floatValue(), 2);
            decimal fraccion = monto - (int)monto;
            int parteEntera = (int)monto;
            string Moneda = "DOLAR"; //Nombre de Moneda (Singular)
            string Monedas = "DOLARES";      //Nombre de Moneda (Plural)
            string Centimos = "CTVS.";  //Nombre de Céntimos (Plural)
            string Preposicion = "CON";    //Preposición entre Moneda y Céntimos
            int NumCentimos;
            string Letra = "";
            double Maximo = 1999999999.99;
            //Validar que el Numero está dentro de los límites
            if ((double)monto >= 0 && (double)monto <= Maximo)
            {
                Letra = convertirNumeroLetra(parteEntera);              //Convertir la parte Entera en letras

                NumCentimos = (int)(fraccion * 100);   //Obtener los centimos del Numero

                //Si Numero = 1 agregar leyenda Moneda (Singular)
                if (parteEntera == 1)
                {
                    Letra = Letra + " " + Moneda;
                    //De lo contrario agregar leyenda Monedas (Plural)
                }
                else
                {
                    Letra = Letra + " " + Monedas;
                }
                //Si NumCentimos es mayor a cero inicar la conversión
                if (NumCentimos > 0)
                {
                    //Si el parámetro CentimosEnLetra es VERDADERO obtener letras para los céntimos
                    //Mostrar los céntimos como número
                    if (NumCentimos < 10)
                    {
                        Letra = Letra + " " + " " + Preposicion + " " + NumCentimos + "/100" + Centimos;
                    }
                    else
                    {
                        Letra = Letra + " " + Preposicion + " " + NumCentimos + "/100" + Centimos;
                    }
                }

                return Letra;
            }
            else
            {
                return "ERROR: El número excede los limites";
            }
        }




        public string convertirNumeroLetra(int Numero)
        {
            String resultado = "";

            //Nombre de los números
            List<string> Unidades = new List<string>();
            Unidades.Add(""); Unidades.Add("UN"); Unidades.Add("DOS"); Unidades.Add("TRES"); Unidades.Add("CUATRO"); Unidades.Add("CINCO"); Unidades.Add("SEIS"); Unidades.Add("SIETE"); Unidades.Add("OCHO"); Unidades.Add("NUEVE"); Unidades.Add("DIEZ"); Unidades.Add("ONCE"); Unidades.Add("DOCE"); Unidades.Add("TRECE"); Unidades.Add("CATARCE"); Unidades.Add("QUINCE"); Unidades.Add("DIECISEIS"); Unidades.Add("DIECISIETE"); Unidades.Add("DIECIOCHO"); Unidades.Add("DIECINUEVE"); Unidades.Add("VEINTE"); Unidades.Add("VEINTIUNO"); Unidades.Add("VEINTIDOS"); Unidades.Add("VEINTITRES"); Unidades.Add("VEINTICUATRO"); Unidades.Add("VEINTICINCO"); Unidades.Add("VEINTISEIS"); Unidades.Add("VEINTISIETE"); Unidades.Add("VEINTIOCHO"); Unidades.Add("VEINTINUEVE");
            List<string> Decenas = new List<string>();
            Decenas.Add(""); Decenas.Add("DIEZ"); Decenas.Add("VEINTE"); Decenas.Add("TREINTA"); Decenas.Add("CUARENTA"); Decenas.Add("CINCUENTA"); Decenas.Add("SESENTA"); Decenas.Add("SETENTA"); Decenas.Add("OCHENTA"); Decenas.Add("NOVENTA"); Decenas.Add("CIEN");
            List<string> Centenas = new List<string>();
            Centenas.Add(""); Centenas.Add("CIENTO"); Centenas.Add("DOSCIENTOS"); Centenas.Add("TRESCIENTOS"); Centenas.Add("CUATROCIENTOS"); Centenas.Add("QUINIENTOS"); Centenas.Add("SEISCIENTOS"); Centenas.Add("SETECIENTOS"); Centenas.Add("OCHOCIENTOS"); Centenas.Add("NOVECIENTOS");

            //Convertir a Letra
            if (Numero == 0)
            {
                resultado = "CERO";
            }
            else if (Numero >= 1 && Numero <= 29)
            {
                resultado = Unidades[Numero];
            }
            else if (Numero >= 30 && Numero <= 100)
            {
                resultado = Decenas[Numero / 10];
                if (Numero % 10 != 0)
                {
                    resultado = resultado + " Y ";
                    resultado = resultado + convertirNumeroLetra(Numero % 10);
                }
            }
            else if (Numero >= 101 && Numero <= 999)
            {
                resultado = Centenas[Numero / 100];
                if (Numero % 100 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 100);
                }
            }
            else if (Numero >= 1000 && Numero <= 1999)
            {
                resultado = "MIL";
                if (Numero % 1000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000);
                }
            }
            else if (Numero >= 2000 && Numero <= 999999)
            {
                resultado = convertirNumeroLetra(Numero % 1000);
                resultado = resultado + "MIL";
                if (Numero % 1000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000);
                }
            }
            else if (Numero >= 1000000 && Numero <= 1999999)
            {
                resultado = "UN MILLON";
                if (Numero % 1000000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000000);
                }
            }
            else if (Numero >= 2000000 && Numero <= 1999999999)
            {
                resultado = convertirNumeroLetra(Numero % 1000000);
                resultado = resultado + "MILLONES";
                if (Numero % 1000000 != 0)
                {
                    resultado = resultado + " ";
                    resultado = resultado + convertirNumeroLetra(Numero % 1000000);
                }
            }

            return resultado;
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }



        public void exportDataGridViewToExcel(string titulo, DataGridViewColumnCollection encabezados, DataTable datos,string nombreArchivo)
        {
            int columna = 1;
            int fila = 1;
            if (encabezados != null && datos != null)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Workbooks.Add(true);
                    
                    foreach (DataGridViewColumn column in encabezados)
                    {
                        excel.Cells[fila, columna] = column.HeaderText;
                        excel.ActiveCell.Font.Bold = true;
                        excel.ActiveCell.EntireColumn.NumberFormat = convertFormatExcel(column.DefaultCellStyle.Format);
                        excel.ActiveCell.get_Offset(0, 1).Activate();
                        columna++;
                    }
                    fila++;
                    foreach (DataRow row in datos.Rows)
                    {
                        columna = 1;
                        foreach (DataGridViewColumn column in encabezados)
                        {
                            if (column.Visible)
                            {
                                if (row.Table.Columns.Contains(column.Name))
                                {
                                    excel.Cells[fila, columna] = row.Field<object>(column.Name);
                                }
                                columna++;
                            }
                        }
                        fila++;
                    }
                    excel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR AL GENERAR ARCHIVO EXCEL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private string convertFormatExcel(string formatDataGrid)
        {
            string formato = string.Empty;
            switch (formatDataGrid)
            {
                case "N0":
                    formato = "#,##0";
                    break;
                case "N1":
                    formato = "#,##0.0";
                    break;
                case "C2":
                    formato = "$#,##0.00_);[Red]($#,##0.00)";
                    break;
                case "d":
                    formato = "dd/mm/yyyy";
                    break;
                default:
                    formato = "@";
                    break;
            }
            return formato;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (!back.IsBusy)
            {
                back.RunWorkerAsync();
            }
        }




        private void back_DoWork(object sender, DoWorkEventArgs e)
        {
            FINANCIAMIENTOS_PENDIENTES = dbMovCash.getCountFinancByRecibir(SUCURSAL.COD_SUC,FECHA_SISTEMA);
        }


        private void back_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                FINANCIAMIENTOS_PENDIENTES = 0;
                notify.Visible = false;
            }
            else
            {
                if (FINANCIAMIENTOS_PENDIENTES > 0)
                {
                    SoundPlayer alarma = new SoundPlayer();
                    alarma.Stream = Properties.Resources.notifyAlarm;
                    notify.Visible = true;
                    notify.BalloonTipText = "Tiene " + FINANCIAMIENTOS_PENDIENTES + " Financiamientos pendientes de recibir";
                    notify.Text = "Tiene " + FINANCIAMIENTOS_PENDIENTES + " Financiamientos pendientes de recibir";
                    notify.ShowBalloonTip(100000);
                    alarma.Play();
                }
                else
                {
                    notify.Visible = false;
                }
            }
        }





        private void notify_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Caja.FinancForm financ;
            financ = Caja.FinancForm.Instance();
            financ.MdiParent = this;
            financ.Show();
            if (financ.WindowState == FormWindowState.Minimized)
            {
                financ.WindowState = FormWindowState.Normal;
                financ.Focus();
            }
            financ.cargarHistoryFinanc();
        }






        private void notify_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            menuMovimientosCajaFinanc(sender, e);
            Caja.FinancForm financ;
            financ = Caja.FinancForm.Instance();
            financ.MdiParent = this;
            financ.Show();
            if (financ.WindowState == FormWindowState.Minimized)
            {
                financ.WindowState = FormWindowState.Normal;
                financ.Focus();
            }
            financ.cargarHistoryFinanc();
        }

        

        





        
       



        
       




       
    }
}
