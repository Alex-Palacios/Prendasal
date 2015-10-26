using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;

   

    public class Vencidos
    {
        public int ID_VENC;
        public string COD_SUC;
        public string COD_TRANS;
        public DateTime FECHA;
        public string DOCUMENTO;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;

        //VARIABLES AUX
        public DataTable CONTRATOS_VENCIDOS;
        public DataTable KPM;

        public string RESPONSABLE;

        //calculados
        public Int64 VENCIDOS;
        public Int64 REACTIVADOS;

        public Vencidos()
        {

        }

       


        public static Vencidos ConvertToVencidos(DataRow dr)
        {
            Vencidos venc = null;
            if (dr != null)
            {
                venc = new Vencidos();
                if (dr.Table.Columns.Contains("ID_VENC")) { venc.ID_VENC = dr.Field<int>("ID_VENC"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { venc.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { venc.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { venc.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { venc.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("ESTADO")) { venc.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { venc.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { venc.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { venc.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("VENCIDOS")) { venc.VENCIDOS = dr.Field<Int64>("VENCIDOS"); }
                if (dr.Table.Columns.Contains("REACTIVADOS")) { venc.REACTIVADOS = dr.Field<Int64>("REACTIVADOS"); }
                

            }
            return venc;

        }

        public Vencidos Copy()
        {
            Vencidos copy = (Vencidos)this.MemberwiseClone();
            copy.CONTRATOS_VENCIDOS = this.CONTRATOS_VENCIDOS.Copy();
            copy.KPM = this.KPM.Copy();
            return copy;
        }


        public Int64 TOTAL
        {
            get
            {
                return (this.VENCIDOS + this.REACTIVADOS);
            }
        }

    }
}
