using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;


    public class Gasto
    {
        public int ID_GASTO;
        public string COD_SUC;
        public string COD_TRANS;
        public DateTime FECHA;
        public eTipoFactura TIPO_DOC;
        public string DOCUMENTO;
        public eTipoPago TIPO_PAGO;
        public string DESCRIPCION;
        public decimal SUBTOTAL;
        public decimal IVA;
        public decimal TOTAL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;

        //VARIABLES AUX
        public string RESPONSABLE;
        //DATOS CALCULADOS


        
        public Gasto()
        {
            
        }


        public static Gasto ConvertToGasto(DataRow dr)
        {
            Gasto gasto = null;
            if (dr != null)
            {
                gasto = new Gasto();
                if (dr.Table.Columns.Contains("ID_GASTO")) { gasto.ID_GASTO = dr.Field<int>("ID_GASTO"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { gasto.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { gasto.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { gasto.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO_DOC")) { gasto.TIPO_DOC = (eTipoFactura)Enum.Parse(typeof(eTipoFactura), dr.Field<string>("TIPO_DOC")); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { gasto.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("TIPO_PAGO")) { gasto.TIPO_PAGO = (eTipoPago)dr.Field<int>("TIPO_PAGO"); }
                if (dr.Table.Columns.Contains("DESCRIPCION")) { gasto.DESCRIPCION = dr.Field<string>("DESCRIPCION"); }
                if (dr.Table.Columns.Contains("SUBTOTAL")) { gasto.SUBTOTAL = dr.Field<decimal>("SUBTOTAL"); }
                if (dr.Table.Columns.Contains("IVA")) { gasto.IVA = dr.Field<decimal>("IVA"); }
                if (dr.Table.Columns.Contains("TOTAL")) { gasto.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { gasto.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { gasto.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { gasto.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { gasto.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }

            }
            return gasto;

        }



        public Gasto Copy()
        {
            Gasto copy = (Gasto)this.MemberwiseClone();
            return copy;
        }




        public void calcularTotales()
        {
            this.TOTAL = this.SUBTOTAL + this.IVA;
        }






    }
}
