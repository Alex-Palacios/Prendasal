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
        BALANCE_INICIAL =1,
        INVENTARIO_INICIAL =2,
        CxC_INICIAL =3,
        PARTIDA_DIARIA =4,
        COMPRA = 5,
        PAGO =6,
        DEVOLUCION_COMPRA =7,
        VENTA =8,
        COBRO = 9,
        DEVOLUCION_VENTA = 10,
        PRESTAMO =11,
        PAC =12,
        MOV_CASH =13,
        IMPORTACION =14,
        ENVIO =15,
        CIERRE =16,
        APERTURA_CAJA =17,
        CORTE_DIARIO =18,
        REACTIVACION =19,
        GASTO = 20,
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



    public enum eTipoVenta
    {
        CREDITO = 1,
        CONTADO
    }




    public enum eTipoTraslado
    {
        CUSTODIA_VALORES = 1,
        NOTA_REMISION,
    }

    public enum eTipoDetalleTraslado
    {
        ARTICULO = 1,
        COMPRA,
        PRESTAMO
    }

    

    public enum eEstadoTraslado
    {
        PENDIENTE = 1,
        RECIBIDO,
    }



    public enum eMESES
    {
        ENERO = 1,
        FEBRERO,
        MARZO,
        ABRIL,
        MAYO,
        JUNIO,
        JULIO,
        AGOSTO,
        SEPTIEMBRE,
        OCTUBRE,
        NOVIEMBRE,
        DICIEMBRE
    }



    public class Transaccion
    {
        public Transaccion()
        {

        }
    }
}
