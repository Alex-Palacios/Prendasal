using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class Kardex
    {
        public string COD_SUC;
        public string COD_TRANS;
        public DateTime FECHA;
        public string CODIGO;
        public string COD_ITEM;
        public string DESCRIPCION;
        public decimal ENTRADA;
        public decimal SALIDA;
        public decimal PRECIO;


        public eCategoria CATEGORIA;
        public string RESPONSABLE;


        public Kardex()
        {
            
        }

        public static Kardex ConvertToInventario(DataRow dr)
        {
            Kardex inv = null;
            if (dr != null)
            {
                inv = new Kardex();
                if (dr.Table.Columns.Contains("COD_TRANS")) { inv.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { inv.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("CATEGORIA")) { inv.CATEGORIA = (eCategoria)Enum.Parse(typeof(eCategoria), dr.Field<string>("CATEGORIA")); }
                if (dr.Table.Columns.Contains("CODIGO")) { inv.CODIGO = dr.Field<string>("CODIGO"); }
                if (dr.Table.Columns.Contains("COD_ITEM")) { inv.COD_ITEM = dr.Field<string>("COD_ITEM"); }
                if (dr.Table.Columns.Contains("DESCRIPCION")) { inv.DESCRIPCION = dr.Field<string>("DESCRIPCION"); }
                if (dr.Table.Columns.Contains("PRECIO")) { inv.PRECIO = dr.Field<decimal>("PRECIO"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { inv.COD_SUC = dr.Field<string>("COD_SUC"); }

                
            }
            return inv;

        }




        public Kardex Copy()
        {
            Kardex copy = (Kardex)this.MemberwiseClone();
            return copy;
        }

    }
}
