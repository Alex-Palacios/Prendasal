﻿using System;
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

        public DateTime FECHA_SISTEMA;
        public Sucursal SUCURSAL;
        public Usuario USUARIO;
        public string SISTEMA;
        public string TIPO_SESION;

        public DataTable datSUCURSALES;

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
            SISTEMA = Properties.Settings.Default.SISTEMA;
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
            btnMenuCatalogoProductos.Visible = false;
            //MODULO MOVIMIENTOS
            moduloMOVIMIENTOS.Visible = false;
            btnMenuContratos.Visible = false;
            btnMenuPAC.Visible = false;
            btnMenuCompras.Visible = false;
            btnMenuVentas.Visible = false;
            btnMenuFinanc.Visible = false;
            btnMenuRemesas.Visible = false;
            btnMenuGastos.Visible = false;
            btnCorteDiario.Visible = false;
            //MODULO OPERACIONES
            moduloOPERACIONES.Visible = false;
            btnMenuCierreVencidos.Visible = false;
            btnMenuRecibirInv.Visible = false;
            btnMenuEnviarInv.Visible = false;
            btnInventarioInicial.Visible = false;
            //MODULO REPORTES
            moduloREPORTES.Visible = false;
            btnReporteResguardo.Visible = false;
            btnReporteEnVenta.Visible = false;
            btnReporteTransDiarias.Visible = false;
            btnReporteContratos.Visible = false;
            btnReportesCompras.Visible = false;
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
                            case "Articulos":
                                btnMenuCatalogoProductos.Visible = p.Field<bool>("ACCESO");
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
                                btnReporteResguardo.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "En Venta":
                                btnReporteEnVenta.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Transacciones":
                                btnReporteTransDiarias.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Contratos":
                                btnReporteContratos.Visible = p.Field<bool>("ACCESO");
                                break;
                            case "Compras":
                                btnReportesCompras.Visible = p.Field<bool>("ACCESO");
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
            moduloCATALOGOS.Visible = (btnMenuClientes.Visible || btnMenuAMIGO.Visible || btnMenuVIP.Visible || btnMenuCatalogoProductos.Visible);
            grupoClientes.Visible = (btnMenuClientes.Visible || btnMenuAMIGO.Visible || btnMenuVIP.Visible);
            grupoCatalogos.Visible = (btnMenuCatalogoProductos.Visible);
            moduloMOVIMIENTOS.Visible =(btnMenuContratos.Visible || btnMenuPAC.Visible || btnMenuCompras.Visible || btnMenuVentas.Visible || btnMenuFinanc.Visible || btnMenuRemesas.Visible || btnMenuGastos.Visible || btnCorteDiario.Visible);
            grupoTransComerciales.Visible = (btnMenuContratos.Visible || btnMenuPAC.Visible || btnMenuCompras.Visible || btnMenuVentas.Visible);
            grupoCajaChica.Visible = (btnMenuFinanc.Visible || btnMenuRemesas.Visible || btnMenuGastos.Visible);
            moduloOPERACIONES.Visible = (btnMenuCierreVencidos.Visible || btnMenuRecibirInv.Visible || btnMenuEnviarInv.Visible || btnInventarioInicial.Visible);
            grupoOperacionesInventario.Visible = (btnMenuCierreVencidos.Visible || btnMenuRecibirInv.Visible || btnMenuEnviarInv.Visible || btnInventarioInicial.Visible);
            moduloREPORTES.Visible = (btnReporteResguardo.Visible  || btnReporteEnVenta.Visible || btnReporteTransDiarias.Visible || btnReporteContratos.Visible);
            grupoReportesInventario.Visible = (btnReporteResguardo.Visible || btnReporteEnVenta.Visible);
            grupoReporteVarios.Visible = btnReporteContratos.Visible;
            grupoReportesConta.Visible = btnReporteTransDiarias.Visible || btnReportesCompras.Visible;
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



        private void menuCatalogosArticulos(object sender, EventArgs e)
        {
            Catalogos.ArticulosListForm itens;
            itens = Catalogos.ArticulosListForm.Instance();
            itens.MdiParent = this;
            itens.Show();
            if (itens.WindowState == FormWindowState.Minimized)
            {
                itens.WindowState = FormWindowState.Normal;
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
            Operaciones.RecibirInvForm recepcion;
            recepcion = Operaciones.RecibirInvForm.Instance();
            recepcion.MdiParent = this;
            recepcion.Show();
            if (recepcion.WindowState == FormWindowState.Minimized)
            {
                recepcion.WindowState = FormWindowState.Normal;
            }
        }

        private void menuOperacionesEnviarInv(object sender, EventArgs e)
        {
            Operaciones.EnviarInvForm envio;
            envio = Operaciones.EnviarInvForm.Instance();
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


        private void menuReportesCancelados(object sender, EventArgs e)
        {
            Reportes.CanceladosForm cancelados;
            cancelados = Reportes.CanceladosForm.Instance();
            cancelados.MdiParent = this;
            cancelados.Show();
            if (cancelados.WindowState == FormWindowState.Minimized)
            {
                cancelados.WindowState = FormWindowState.Normal;
            }
        }

        private void menuReportesVencidosDia(object sender, EventArgs e)
        {
            Reportes.VencidosDiaForm vencidos;
            vencidos = Reportes.VencidosDiaForm.Instance();
            vencidos.MdiParent = this;
            vencidos.Show();
            if (vencidos.WindowState == FormWindowState.Minimized)
            {
                vencidos.WindowState = FormWindowState.Normal;
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


        private void menuReportesDiario(object sender, EventArgs e)
        {
            Reportes.RDiarioForm diario;
            diario = Reportes.RDiarioForm.Instance();
            diario.MdiParent = this;
            diario.Show();
            if (diario.WindowState == FormWindowState.Minimized)
            {
                diario.WindowState = FormWindowState.Normal;
            }
        }



        private void menuReporteComprasORO(object sender, EventArgs e)
        {
            Reportes.ComprasOroForm comprasOro;
            comprasOro = Reportes.ComprasOroForm.Instance();
            comprasOro.MdiParent = this;
            comprasOro.Show();
            if (comprasOro.WindowState == FormWindowState.Minimized)
            {
                comprasOro.WindowState = FormWindowState.Normal;
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




        private string convertirNumeroLetra(int Numero)
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

        

        




       



        
       




       
    }
}
