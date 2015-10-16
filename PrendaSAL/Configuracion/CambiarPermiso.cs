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

namespace PrendaSAL.Configuracion
{
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class CambiarPermiso : Form
    {
        //VARIABLES
        private DBUsuario dbUser;
        private Permiso PERMISO;


        public CambiarPermiso(Permiso p)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            PERMISO = p;
            cbxTIPOUSER.DataSource = Enum.GetValues(new eTipoUsuario().GetType());
            cargarPermiso();
        }

        private void ocultar()
        {
            ckACCESO.Checked = false;
            ckREGISTRAR.Checked = false;
            ckACTUALIZAR.Checked = false;
            ckKEY.Checked = false;
            ckANULAR.Checked = false;
            ckELIMINAR.Checked = false;
            ckLOG.Checked = false;
            ckBUSCAR.Checked = false;
            ckREIMPRIMIR.Checked = false;
            ckCONFIG.Checked = false;
            
            ckACCESO.Visible = false;
            ckREGISTRAR.Visible = false;
            ckACTUALIZAR.Visible = false;
            ckKEY.Visible = false;
            ckANULAR.Visible = false;
            ckELIMINAR.Visible = false;
            ckLOG.Visible = false;
            ckBUSCAR.Visible = false;
            ckREIMPRIMIR.Visible = false;
            ckCONFIG.Visible = false;
        }


        private void cargarPermiso()
        {
            ocultar();
            if (PERMISO != null)
            {
                cbxTIPOUSER.SelectedItem = PERMISO.TIPO_USER;
                txtCODIGO.Text = PERMISO.CODIGO;
                txtMODULO.Text = PERMISO.MODULO;
                txtMENU.Text = PERMISO.MENU;
                ckACCESO.Checked = PERMISO.ACCESO;
                ckREGISTRAR.Checked = PERMISO.REGISTRAR;
                ckACTUALIZAR.Checked = PERMISO.ACTUALIZAR;
                ckKEY.Checked = PERMISO.CLAVE;
                ckANULAR.Checked = PERMISO.ANULAR;
                ckELIMINAR.Checked = PERMISO.ELIMINAR;
                ckBUSCAR.Checked = PERMISO.BUSCAR;
                ckLOG.Checked = PERMISO.LOG;
                ckREIMPRIMIR.Checked = PERMISO.REIMPRIMIR;
                ckCONFIG.Checked = PERMISO.CONFIG;
                mostrar();
               
            }
        }

        private void mostrar()
        {
            //MOSTRAR PERMISOS PERSONALIZADOS
            switch (PERMISO.CODIGO)
            {
                case "P1": //Clientes
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Cliente";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Cliente";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Cliente";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Cliente";
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P2": //Tarjeta AMIGO
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Afiliar Cliente AMIGO";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Cambiar Prestaciones Tarjeta";
                    ckKEY.Visible = true;
                    ckKEY.Text = "Cambiar Número Tarjeta";
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Tarjeta";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Tarjeta";
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P3": //Tarjeta V.I.P
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Afiliar Cliente V.I.P";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Cambiar Prestaciones Tarjeta";
                    ckKEY.Visible = true;
                    ckKEY.Text = "Cambiar Número Tarjeta";
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Tarjeta";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Tarjeta";
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P4": //Catalogo de Articulo
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Agregar Articulo";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Articulo";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Articulo";
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P5": //Contratos
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Contrato";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Contrato";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular Contrato";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Contrato";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Contrato";
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Contrato";
                    ckCONFIG.Visible = true;
                    ckCONFIG.Text = "Cambiar Tasas y Plazos";
                    break;
                case "P6": //Prorrogas, Abonos y Cancelaciones
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar P.A.C";
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular P.A.C";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar P.A.C";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Recibo/Factura";
                    ckCONFIG.Visible = false;
                    break;
                case "P7": //Compras
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Compra";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Compra";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular Compra";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Compra";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Compra";
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Contrato Compra";
                    ckCONFIG.Visible = false;
                    break;
                case "P8": //Ventas
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Venta";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Venta";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular Venta";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Venta";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Venta";
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Factura Venta";
                    ckCONFIG.Visible = false;
                    break;
                case "P9": //Financiamientos
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Financiamiento";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Financiamiento";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular Financiamiento";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Financiamiento";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Ticket";
                    ckCONFIG.Visible = false;
                    break;
                case "P10": //Remesas
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Remesa";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Remesa";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular Remesa";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Remesa";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Ticket";
                    ckCONFIG.Visible = false;
                    break;
                case "P11": //Gastos
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Gasto";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Gasto";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = true;
                    ckANULAR.Text = "Anular Gasto";
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Gasto";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P12": //Corte Diario
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Realizar Corte Diario";
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Ver Reporte Diario";
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P13": // Lista Vencidos
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P14": //Cierre Contratos
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Cerrar Contratos Vencidos";
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Cierre";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Cierre";
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Lista Cierre";
                    ckCONFIG.Visible = false;
                    break;
                case "P15": // Recibir Inventario
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Recibir Articulos";
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P16": //Enviar Inventario
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Enviar Articulos";
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Envio";
                    ckLOG.Visible = true;
                    ckLOG.Text = "Ver Log";
                    ckBUSCAR.Visible = true;
                    ckBUSCAR.Text = "Buscar Envio";
                    ckREIMPRIMIR.Visible = true;
                    ckREIMPRIMIR.Text = "Reimprimir Custodia de Valores/Nota Remision";
                    ckCONFIG.Visible = false;
                    break;
                case "P17": //Corte de Inventario Inicial
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Registrar Articulo I.I";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Articulo I.I";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Articulo I.I";
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P18": //Reporte Inventario en Resguardo
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Generar Reporte";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P19": //Reporte Inventario para la Venta
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Generar Reporte";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Detalle y definir Precio Articulo";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P20": //Reporte de Transacciones Diarias
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Generar Reporte";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P21": //Reporte de Contratos
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Generar Reporte";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P22": //Precios ORO y PLATA
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Ver Precios";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Actualizar Precios";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P23": // Reglas de Negocio
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Ver Reglas Negocio";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Actualizar Reglas Negocio";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P24": //Configuracion de Conexion BD
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Ver Configuracion";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Actualizar Configuracion";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P25": //Fecha Sistema
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Cambiar Fecha Sistema";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P26": // Sucursales PRENDASAL
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = false;
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P27": //Cuenta de Usuario
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Ver Cuenta de Usuario";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Cambiar Contraseña de Acceso";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P28": // Administracion de Usuarios
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = true;
                    ckREGISTRAR.Text = "Agregar Usuario";
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Editar Usuario";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = true;
                    ckELIMINAR.Text = "Eliminar Usuario";
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P29": //Permisos 
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Acceso a Menu";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Cambiar Permisos";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
                case "P30": // Configuracion de Cuentas Contables
                    ckACCESO.Visible = true;
                    ckACCESO.Text = "Ver Cuentas Contables";
                    ckREGISTRAR.Visible = false;
                    ckACTUALIZAR.Visible = true;
                    ckACTUALIZAR.Text = "Cambiar Configuracion Contable";
                    ckKEY.Visible = false;
                    ckANULAR.Visible = false;
                    ckELIMINAR.Visible = false;
                    ckLOG.Visible = false;
                    ckBUSCAR.Visible = false;
                    ckREIMPRIMIR.Visible = false;
                    ckCONFIG.Visible = false;
                    break;
            }
        }


        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                PERMISO.ACCESO = ckACCESO.Checked;
                PERMISO.REGISTRAR = ckREGISTRAR.Checked;
                PERMISO.ACTUALIZAR = ckACTUALIZAR.Checked;
                PERMISO.CLAVE = ckKEY.Checked;
                PERMISO.ANULAR = ckANULAR.Checked;
                PERMISO.ELIMINAR = ckELIMINAR.Checked;
                PERMISO.BUSCAR = ckBUSCAR.Checked;
                PERMISO.LOG = ckLOG.Checked;
                PERMISO.REIMPRIMIR = ckREIMPRIMIR.Checked;
                PERMISO.CONFIG = ckCONFIG.Checked;
                if (dbUser.setPermisos(HOME.Instance().SISTEMA,PERMISO))
                {
                    this.Close();
                    PermisosForm.Instance().consultarPermisos();
                }

            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            
        }




    }
}
