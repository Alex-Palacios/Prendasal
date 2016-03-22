using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class SFCaja
    {
        public int ID_SFC;
        public string COD_SUC;
        public string COD_TRANS;
        public DateTime FECHA;
        public string DOCUMENTO;
        public eTipoSFC TIPO;
        public string DESCRIPCION;
        public decimal TOTAL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;

        //VARIABLES AUXILIARES
        public string RESPONSABLE;
        public string SUCURSAL;

        public SFCaja()
        {

        }


        public static SFCaja ConvertToSFCaja(DataRow dr)
        {
            SFCaja sfc = null;
            if (dr != null)
            {
                sfc = new SFCaja();
                if (dr.Table.Columns.Contains("ID_SFC")) { sfc.ID_SFC = dr.Field<int>("ID_SFC"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { sfc.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { sfc.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { sfc.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { sfc.TIPO = (eTipoSFC)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { sfc.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("DESCRIPCION")) { sfc.DESCRIPCION = dr.Field<string>("DESCRIPCION"); }
                if (dr.Table.Columns.Contains("TOTAL")) { sfc.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { sfc.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { sfc.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { sfc.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { sfc.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("SUCURSAL")) { sfc.SUCURSAL = dr.Field<string>("SUCURSAL"); }

            }
            return sfc;

        }



        public SFCaja Copy()
        {
            SFCaja copy = (SFCaja)this.MemberwiseClone();
            return copy;
        }
    }
}
