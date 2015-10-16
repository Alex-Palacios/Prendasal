using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    using System.Data;
    using System.Windows.Forms;

    public enum eTipoDocVenta
    {
        FCF = 1,
        CCF = 2,
        OTRO = 5
    }

    public enum eTipoVenta
    {
        CREDITO = 1,
        CONTADO
    }

    public enum eNaturalezaVenta
    {
        VENTA = 1,
        SERVICIO
    }

    public enum eEstadoVenta
    {
        HISTORICO = -2,
        PREINGRESADA = -1,
        ANULADA = 0,
        REGISTRADA = 1
    }

    public class Venta
    {
        public int ID_VENTA;
        public string COD_CLIENTE;
        public string TRANSACCION;
        public DateTime FECHA;
        public eTipoDocVenta TIPO_DOC;
        public string DOCUMENTO;
        public eTipoVenta TIPO_VENTA;
        public decimal SUMAS;
        public decimal TOTAL_IMP;
        public decimal TOTAL;
        public decimal SALDO;
        public eEstadoVenta ESTADO;
        public eNIVEL NIVEL;
        public string CTA_VENTA;
        public string CTA_IMP;
        public eNaturalezaVenta NAT_VENTA;
        public bool INIT_BALANCE;
        public string COD_SUC;
        public string NOTA;


        //VARIABLES AUX
        public string NUMTARJETA;
        public DataGridViewRowCollection ITEMS_VENTA;
        public string IMPUESTO;
        public string NOTA_CAMBIO;
        //DATOS CLIENTE
        public Cliente CLIENTE;
        //DATOS CALCULADOS
        public decimal DESCUENTO;

        public Venta()
        {
            
        }
    }
}
