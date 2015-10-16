using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public enum eTipoMovTarjeta
    {
        ACUMULADO = 1,
        PRESTACION,
        CANJEADO,
    }

    public class Puntos
    {
        public int ID_MOV;
        public string COD_CLIENTE;
        public string NUMTARJETA;
        public eTipoMovTarjeta TIPO;
        public string TRANSACCION;
        public string DESCRIPCION;
        public string CANJEO;
        public double TOTAL_PUNTOS;


        public Puntos()
        {

        }
    }
}
