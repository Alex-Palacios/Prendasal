using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;

    public class Existencia
    {
        public eCategoria CATEGORIA;
        public string CODIGO;
        public string COD_ITEM;
        public string DESCRIPCION;
        public decimal CANTIDAD;
        public decimal PRECIO;
        public string COD_SUC;


        public Existencia()
        {
            
        }

        public static Existencia ConvertToExistencia(DataRow dr)
        {
            Existencia exist = null;
            if (dr != null)
            {
                exist = new Existencia();
                if (dr.Table.Columns.Contains("CATEGORIA")) { exist.CATEGORIA = (eCategoria)Enum.Parse(typeof(eCategoria), dr.Field<string>("CATEGORIA")); }
                if (dr.Table.Columns.Contains("CODIGO")) { exist.CODIGO = dr.Field<string>("CODIGO"); }
                if (dr.Table.Columns.Contains("COD_ITEM")) { exist.COD_ITEM = dr.Field<string>("COD_ITEM"); }
                if (dr.Table.Columns.Contains("DESCRIPCION")) { exist.DESCRIPCION = dr.Field<string>("DESCRIPCION"); }
                if (dr.Table.Columns.Contains("CANTIDAD")) { exist.CANTIDAD = dr.Field<decimal>("CANTIDAD"); }
                if (dr.Table.Columns.Contains("PRECIO")) { exist.PRECIO = dr.Field<decimal>("PRECIO"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { exist.COD_SUC = dr.Field<string>("COD_SUC"); }
                
            }
            return exist;

        }




        public Existencia Copy()
        {
            Existencia copy = (Existencia)this.MemberwiseClone();
            return copy;
        }
    }
}
