using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    
    public enum eTipoMovCash
    {
        FINANCIAMIENTO = 1,
        REMESA,
    }

    public enum eTipoDocMovCash
    {
        TICKET = 1,
    }

    public enum eEstadoMovCash
    {
        HISTORICO = -2,
        PREINGRESADO = -1,
        ANULADO = 0,
        REGISTRADO = 1,
    }


    public class MovCash
    {
        public int ID_MOV;
        public string TRANSACCION;
        public DateTime FECHA;
        public eTipoMovCash TIPO_MOV;
        public eTipoDocMovCash TIPO_DOC;
        public string DOCUMENTO;
        public decimal TOTAL;
        public string SUC_ORIGEN;
        public string RESPONSABLE_ENVIO;
        public string SUC_DESTINO;
        public string RESPONSABLE_RECIBE;
        public eEstadoMovCash ESTADO;
        public string CTA_ORIGEN;
        public string CTA_DESTINO;
        public bool RECIBIDO;
        public string NOTA;

        //VARIABLES AUXILIARES
        public string SUCURSAL_ENVIO;
        public string SUCURSAL_DESTINO;
        public string RESPONSABLE;
        public string NOTA_CAMBIO;

        public MovCash()
        {

        }

    }
}
