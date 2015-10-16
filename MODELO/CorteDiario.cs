using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class CorteDiario
    {
        public int ID;
        public string COD_SUC;
        public DateTime FECHA;
        public string TRANS_APERTURA;
        public decimal APERTURA;
        public string TRANS_CIERRE;
        public decimal CIERRE;
        public bool ABIERTO;


        //variables aux
        public string SUCURSAL;

        public CorteDiario()
        {
        }
    }
}
