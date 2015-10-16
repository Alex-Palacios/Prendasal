using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;

    public enum eTipoDocGasto
    {
        FCF = 1,
        CCF = 2,
        OTRO = 5,
    }

    public enum eEstadoGasto
    {
        HISTORICO = -2,
        PREINGRESADA = -1,
        ANULADA = 0,
        REGISTRADA = 1
    }


    public class Gasto
    {
        public int ID_GASTO;
        public string TRANSACCION;
        public DateTime FECHA;
        public eTipoDocGasto TIPO_DOC;
        public string DOCUMENTO;
        public decimal SUMAS;
        public decimal TOTAL_IMP;
        public decimal TOTAL;
        public eEstadoGasto ESTADO;
        public string CTA_GASTO;
        public string CTA_IMP;
        public bool INIT_BALANCE;
        public string COD_SUC;
        public string NOTA;

        //VARIABLES AUX
        public DataGridViewRowCollection ITEMS_GASTO;
        public string NOTA_CAMBIO;
        public string DESCRIPCION;
        public string SUCURSAL;
        public string RESPONSABLE;
        //DATOS CALCULADOS


        
        public Gasto()
        {
            
        }



    }
}
