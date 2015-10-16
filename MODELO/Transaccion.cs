using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MODELO
{

    public enum eTransaccion
    {
        NON = -1,
        ABRIR_PERIODO =0,
        BALANCE_INICIAL,
        INVENTARIO_INICIAL,
        CxC_INICIAL,
        PARTIDA_DIARIA,
        COMPRA,
        PAGO,
        DEVOLUCION_COMPRA,
        VENTA,
        COBRO,
        DEVOLUCION_VENTA,
        PRESTAMO,
        PAC,
        MOV_CASH,
        IMPORTACION,
        ENVIO,
        CIERRE,
        APERTURA_CAJA,
        CORTE_DIARIO,
        REACTIVACION
    }




    public enum eNIVEL
    { 
        PRENDASAL = 1,
        AMIGO = 2,
        VIP = 3,
        MAYOREO = 4,
    }


    public enum eOperacion
    {
        INSERT,
        UPDATE,
        DELETE,
        SEARCH,
        PREVIEW
    }


    public enum eTipoUsuario
    {
        ADMIN = 1,
        GERENTE,
        CONTADOR,
        ASESOR
    }

    public enum GlobalPeriodoInteres
    {
        MENSUAL = 1,
        DIARIO
    }
    

    public enum GlobalFechaSistema
    {
        SERVIDOR = 1,
        CLIENTE
    }


    public enum eSexo
    {
        MASCULINO = 'M',
        FEMENINO = 'F',
    }

    public enum eTipoDocCliente
    {
        DUI,
        LICENCIA,
        PASAPORTE,
        CARNET,
    }




    public enum eEstado
    {
        HISTORICO = -2,
        PREINGRESADO = -1,
        ANULADO = 0,
        CONTABILIZADO = 1
    }



    public enum eTipoCompra
    {
        CREDITO = 1,
        CONTADO
    }


    public enum eTipoPago
    {
        EFECTIVO = 1,
        CHEQUE,
        REMESA
    }


    public enum eCategoria
    {
        ORO,
        ARTICULO
    }


    public enum eUnidadMedida
    {
        UDS,
        GRS
    }


    public enum eTipoPrestamo
    {
        PRENDARIO = 1,
        MUTUO
    }




    public enum eEstadoContrato
    {
        ACTIVO = 1,
        PRORROGADO,
        CANCELADO,
        VENCIDO,
        REACTIVADO,
        ANULADO,
    }

    public enum eTipoMovPac
    {
        PRORROGA = 1,
        ABONO = 2,
        CANCELACION = 3
    }



    public enum eTipoFactura
    {
        FCF,
        CCF
    }





    public enum eTipoMovInv
    {
        ENTRADA = 1,
        SALIDA = 2
    }


    public class Transaccion
    {
        public Transaccion()
        {

        }
    }
}
