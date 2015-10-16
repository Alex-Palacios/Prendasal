using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;

    public enum eTipoDocTraslado
    {
        ENVIO = 1,
        REMISION,
    }

    public enum eTipoTraslado
    {
        MOV_CUSTODIA = 1,
        MOV_INVENTARIO
    }

    public class Traslado
    {
        public int ID_TRASLADO;
        public eTipoDocTraslado TIPO_DOC;
        public string DOCUMENTO;
        public eTipoTraslado TIPO;
        public DateTime FECHA;
        public string SUC_ORG;
        public string SUC_DEST;
        public string ENVIA;
        public string TRASLADA;
        public string RECIBE;
        public bool RECIBIDO;
        public string NOTA;

        //VARIABLES AUX
        public DataRowCollection ARTICULOS;
        public string NOTA_CAMBIO;

        public Traslado()
        {

        }
    }
}
