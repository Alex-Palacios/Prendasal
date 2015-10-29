using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class CorteDiario
    {
        public string COD_SUC;
        public DateTime FECHA;
        public string COD_EMPLEADO;
        public decimal SALDO_INICIAL;
        public decimal SALDO_FINAL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;

        //VARIABLES
        public string RESPONSABLE;
        public DataTable MOVIMIENTOS;
        public DataTable KPM;

        public CorteDiario()
        {

        }


        public static CorteDiario ConvertToCorteDiario(DataRow dr)
        {
            CorteDiario corte = null;
            if (dr != null)
            {
                corte = new CorteDiario();
                if (dr.Table.Columns.Contains("COD_SUC")) { corte.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("FECHA")) { corte.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("COD_EMPLEADO")) { corte.COD_EMPLEADO = dr.Field<string>("COD_EMPLEADO"); }
                if (dr.Table.Columns.Contains("SALDO_INICIAL")) { corte.SALDO_INICIAL = dr.Field<decimal>("SALDO_INICIAL"); }
                if (dr.Table.Columns.Contains("SALDO_FINAL")) { corte.SALDO_FINAL = dr.Field<decimal>("SALDO_FINAL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { corte.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { corte.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { corte.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }

            }
            return corte;
        }

        public CorteDiario Copy()
        {
            CorteDiario copy = (CorteDiario)this.MemberwiseClone();
            copy.MOVIMIENTOS = this.MOVIMIENTOS.Copy();
            return copy;
        }
    }
}
