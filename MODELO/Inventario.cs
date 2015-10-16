using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Inventario
    {
        public int ID_MOV;
        public string TRANSACCION;
        public int? LINEA;
        public DateTime FECHA;
        public string CODIGO;
        public string ARTICULO;
        public string DESCRIPCION;
        public double CANTIDAD;
        public decimal COSTO;
        public decimal PRECIO;
        public bool INIT_BALANCE;
        public string COD_SUC;
        public bool DISPONIBLE;

        //VARIABLES AUX
        public int ID_CATEGORIA;
        public string CATEGORIA;
        public string UBICACION;

        public Inventario()
        {

        }

    }
}
