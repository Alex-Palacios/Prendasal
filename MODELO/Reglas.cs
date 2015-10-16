using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    
    using System.Data;

    public class Reglas
    {
        public eNIVEL NIVEL;
        public DateTime FECHA;
        public string COD_EMPLEADO;
        public decimal TASA_MENSUAL;
        public int PLAZO_CONTRATO;
        public int PLAZO_VENCIDO;
        public decimal DESC_COMPRA;
        public decimal DESC_INTERES;
        public int PUNTOS_DOLAR;
        public decimal PUNTOS_VALOR;

        public string AUTORIZO;

        public Reglas()
        {
            
        }

        public static Reglas ConvertToReglas(DataRow dr)
        {
            Reglas regla = new Reglas();
            if (dr != null)
            {
                if (dr.Table.Columns.Contains("NIVEL")) { regla.NIVEL = (eNIVEL) dr.Field<int>("NIVEL"); }
                if (dr.Table.Columns.Contains("FECHA_ACT")) { regla.FECHA = dr.Field<DateTime>("FECHA_ACT"); }
                if (dr.Table.Columns.Contains("COD_EMPLEADO")) { regla.COD_EMPLEADO = dr.Field<string>("COD_EMPLEADO"); }
                if (dr.Table.Columns.Contains("AUTORIZO")) { regla.AUTORIZO = dr.Field<string>("AUTORIZO"); }
                if (dr.Table.Columns.Contains("TASA_MENSUAL")) { regla.TASA_MENSUAL = dr.Field<decimal>("TASA_MENSUAL"); }
                if (dr.Table.Columns.Contains("PLAZO_CONTRATO")) { regla.PLAZO_CONTRATO = dr.Field<int>("PLAZO_CONTRATO"); }
                if (dr.Table.Columns.Contains("PLAZO_VENCIDO")) { regla.PLAZO_VENCIDO = dr.Field<int>("PLAZO_VENCIDO"); }
                if (dr.Table.Columns.Contains("DESC_COMPRA")) { regla.DESC_COMPRA = dr.Field<decimal>("DESC_COMPRA"); }
                if (dr.Table.Columns.Contains("DESC_INTERES")) { regla.DESC_INTERES = dr.Field<decimal>("DESC_INTERES"); }
                if (dr.Table.Columns.Contains("PUNTOS_DOLAR")) { regla.PUNTOS_DOLAR = dr.Field<int>("PUNTOS_DOLAR"); }
                if (dr.Table.Columns.Contains("PUNTOS_VALOR")) { regla.PUNTOS_VALOR = dr.Field<decimal>("PUNTOS_VALOR"); }
                
            }
            return regla;
        }

        

    }
}
