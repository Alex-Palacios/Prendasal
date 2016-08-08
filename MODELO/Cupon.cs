using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;


    public class Cupon
    {
        public int ID_CUPON;
        public DateTime FECHA_EXP;
        public eTipoCupon TIPO;
        public int DESDE;
        public int HASTA;
        public DateTime FECHA_VENC;
        public decimal DESC_VENTA;
        public decimal DESC_INTERES;
        public bool ACTIVA;

        //EXTRAS
        public int NUMCUPON;

        public Cupon()
        {
            
        }


        public static Cupon ConvertToCupon(DataRow dr)
        {
            Cupon cupon = null;
            if (dr != null)
            {
                cupon = new Cupon();
                if (dr.Table.Columns.Contains("ID_CUPON")) { cupon.ID_CUPON = dr.Field<int>("ID_CUPON"); }
                if (dr.Table.Columns.Contains("FECHA_EXP")) { cupon.FECHA_EXP = dr.Field<DateTime>("FECHA_EXP"); }
                if (dr.Table.Columns.Contains("TIPO")) { cupon.TIPO = (eTipoCupon)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("DESDE")) { cupon.DESDE = dr.Field<int>("DESDE"); }
                if (dr.Table.Columns.Contains("HASTA")) { cupon.HASTA = dr.Field<int>("HASTA"); }
                if (dr.Table.Columns.Contains("FECHA_VENC")) { cupon.FECHA_VENC = dr.Field<DateTime>("FECHA_VENC"); }
                if (dr.Table.Columns.Contains("DESC_VENTA")) { cupon.DESC_VENTA = dr.Field<decimal>("DESC_VENTA"); }
                if (dr.Table.Columns.Contains("DESC_INTERES")) { cupon.DESC_INTERES = dr.Field<decimal>("DESC_INTERES"); }
                if (dr.Table.Columns.Contains("ACTIVA")) { cupon.ACTIVA = dr.Field<bool>("ACTIVA"); }

            }
            return cupon;

        }




        public Cupon Copy()
        {
            Cupon copy = (Cupon)this.MemberwiseClone();
            return copy;
        }
    }

}
