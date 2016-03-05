using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    using System.Data;

   

    public class Catalogo
    {
        public string COD_ITEM;
        public string CATEGORIA;


        public Catalogo()
        {

        }

        public static Catalogo ConvertToItem(DataRow dr)
        {
            Catalogo item = null;
            if (dr != null)
            {
                item = new Catalogo();
                if (dr.Table.Columns.Contains("COD_ITEM")) { item.COD_ITEM = dr.Field<string>("COD_ITEM"); }
                if (dr.Table.Columns.Contains("CATEGORIA")) { item.CATEGORIA =  dr.Field<string>("CATEGORIA"); }
                 
            }
            return item;

        }


    }
}
