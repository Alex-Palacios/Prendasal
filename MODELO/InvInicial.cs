using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class InvInicial
    {
        public int ID_MOV;
        public string COD_SUC;
        public string COD_TRANS;
        public DateTime FECHA;
        public string CODIGO;
        public string COD_ITEM;
        public string DESCRIPCION;
        public decimal CANTIDAD;
        public decimal COSTO;
        public decimal PRECIO;
        public bool INIT_BALANCE;
        public string NOTA;

        public eCategoria CATEGORIA;

        public InvInicial()
        {

        }


        public static InvInicial ConvertToInvInicial(DataRow dr)
        {
            InvInicial inv = null;
            if (dr != null)
            {
                inv = new InvInicial();
                if (dr.Table.Columns.Contains("ID_MOV")) { inv.ID_MOV = dr.Field<int>("ID_MOV"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { inv.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { inv.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { inv.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("CODIGO")) { inv.CODIGO = dr.Field<string>("CODIGO"); }
                if (dr.Table.Columns.Contains("COD_ITEM")) { inv.COD_ITEM = dr.Field<string>("COD_ITEM"); }
                if (dr.Table.Columns.Contains("DESCRIPCION")) { inv.DESCRIPCION = dr.Field<string>("DESCRIPCION"); }
                if (dr.Table.Columns.Contains("CANTIDAD")) { inv.CANTIDAD = dr.Field<decimal>("CANTIDAD"); }
                if (dr.Table.Columns.Contains("COSTO")) { inv.COSTO = dr.Field<decimal>("COSTO"); }
                if (dr.Table.Columns.Contains("PRECIO")) { inv.PRECIO = dr.Field<decimal>("PRECIO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { inv.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { inv.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("CATEGORIA")) { inv.CATEGORIA = (eCategoria)Enum.Parse(typeof(eCategoria), dr.Field<string>("CATEGORIA")); }

            }
            return inv;

        }




        public InvInicial Copy()
        {
            InvInicial copy = (InvInicial)this.MemberwiseClone();
            return copy;
        }

        
    }
}
