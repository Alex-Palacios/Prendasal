using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PSInventario
    {

        public int ID_MOV;
        public DateTime FECHA_INGRESO;
        public string TRANSACCION;
        public int LINEA;
        public string CODIGO;
        public string PRODUCTO;
        public string DESCRIPCION;
        public string CANTIDAD;
        public string UNIDAD;
        public string PRECIO;
        public string COD_SUC;
        public bool INIT_BALANCE;

        //VARIABLES AUXILIARES
        public string UBICACION;

        public PSInventario()
        {

        }

    }
}
