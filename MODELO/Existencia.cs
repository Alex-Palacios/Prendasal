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
        public string CATEGORIA;
        public string CODIGO;
        public string COD_ITEM;
        public string TIPO;
        public string MARCA;
        public string DESCRIPCION;
        public decimal CANTIDAD;
        public decimal PRECIO;
        public string BODEGA;
        public string NOTA;

        public string UBICACION;
        public DateTime FECHA;
        public decimal COSTO;


        public Existencia()
        {
            
        }

        public static Existencia ConvertToExistencia(DataRow dr)
        {
            Existencia exist = null;
            if (dr != null)
            {
                exist = new Existencia();
                if (dr.Table.Columns.Contains("CATEGORIA")) { exist.CATEGORIA =  dr.Field<string>("CATEGORIA"); }
                if (dr.Table.Columns.Contains("CODIGO")) { exist.CODIGO = dr.Field<string>("CODIGO"); }
                if (dr.Table.Columns.Contains("COD_ITEM")) { exist.COD_ITEM = dr.Field<string>("COD_ITEM"); }
                if (dr.Table.Columns.Contains("TIPO")) { exist.TIPO = dr.Field<string>("TIPO"); }
                if (dr.Table.Columns.Contains("MARCA")) { exist.MARCA = dr.Field<string>("MARCA"); }
                if (dr.Table.Columns.Contains("DESCRIPCION")) { exist.DESCRIPCION = dr.Field<string>("DESCRIPCION"); }
                if (dr.Table.Columns.Contains("CANTIDAD")) { exist.CANTIDAD = dr.Field<decimal>("CANTIDAD"); }
                if (dr.Table.Columns.Contains("PRECIO")) { exist.PRECIO = dr.Field<decimal>("PRECIO"); }
                if (dr.Table.Columns.Contains("BODEGA")) { exist.BODEGA = dr.Field<string>("BODEGA"); }
                if (dr.Table.Columns.Contains("NOTA")) { exist.NOTA = dr.Field<string>("NOTA"); }

                
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
