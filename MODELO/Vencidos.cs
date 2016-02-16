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
        public string TRANS_APERTURA;
        public DateTime FECHA_APERTURA;
        public string DOCUMENTO;
        public string TRANS_CIERRE;
        public DateTime? FECHA_CIERRE;
        public eEstado ESTADO;
        
        public bool INIT_BALANCE;
        public string NOTA;

        //VARIABLES AUX
        public DataTable CONTRATOS_VENCIDOS;
        public DataTable KPM;

        public eEstadoListaVenc ESTADO_LISTA;

        public string RESPONSABLE_APERTURA;
        public string RESPONSABLE_CIERRE;

        //calculados
        public int VENCIDOS;
        public int REACTIVADOS;
        public decimal TOTAL;

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
                if (dr.Table.Columns.Contains("TRANS_APERTURA")) { venc.TRANS_APERTURA = dr.Field<string>("TRANS_APERTURA"); }
                if (dr.Table.Columns.Contains("FECHA_APERTURA")) { venc.FECHA_APERTURA = dr.Field<DateTime>("FECHA_APERTURA"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { venc.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("TRANS_CIERRE")) { venc.TRANS_CIERRE = dr.Field<string>("TRANS_CIERRE"); }
                if (dr.Table.Columns.Contains("FECHA_CIERRE")) { venc.FECHA_CIERRE = dr.Field<DateTime?>("FECHA_CIERRE"); }
                if (dr.Table.Columns.Contains("ESTADO")) { venc.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { venc.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { venc.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE_APERTURA")) { venc.RESPONSABLE_APERTURA = dr.Field<string>("RESPONSABLE_APERTURA"); }
                if (dr.Table.Columns.Contains("RESPONSABLE_CIERRE")) { venc.RESPONSABLE_CIERRE = dr.Field<string>("RESPONSABLE_CIERRE"); }
                if (dr.Table.Columns.Contains("VENCIDOS")) { venc.VENCIDOS = Int32.Parse(dr.Field<object>("VENCIDOS").ToString()); }
                if (dr.Table.Columns.Contains("REACTIVADOS")) { venc.REACTIVADOS = Int32.Parse(dr.Field<object>("REACTIVADOS").ToString()); }
                if (dr.Table.Columns.Contains("TOTAL")) { venc.TOTAL = dr.Field<decimal>("TOTAL"); }

                if (dr.Table.Columns.Contains("ESTADO_LISTA")) { venc.ESTADO_LISTA = (eEstadoListaVenc)Enum.Parse(typeof(eEstadoListaVenc), dr.Field<string>("ESTADO_LISTA")); }

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


    }
}
