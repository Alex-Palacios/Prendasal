using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    using System.Data;


    public class MovCash
    {
        public int ID_MOV;
        public string COD_TRANS;
        public DateTime FECHA;
        public string DOCUMENTO;
        public string SUC_ENVIA;
        public string SUC_DEST;
        public string TRASLADA;
        public string RECIBE;
        public decimal TOTAL;
        public bool RECIBIDO;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;

        //VARIABLES AUXILIARES
        public string RESPONSABLE;
        public string DESTINO;
        public string ENVIA;

        public MovCash()
        {

        }


        public static MovCash ConvertToMovCash(DataRow dr)
        {
            MovCash movimiento = null;
            if (dr != null)
            {
                movimiento = new MovCash();
                if (dr.Table.Columns.Contains("ID_MOV")) { movimiento.ID_MOV = dr.Field<int>("ID_MOV"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { movimiento.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("FECHA")) { movimiento.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { movimiento.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("SUC_ENVIA")) { movimiento.SUC_ENVIA = dr.Field<string>("SUC_ENVIA"); }
                if (dr.Table.Columns.Contains("SUC_DEST")) { movimiento.SUC_DEST = dr.Field<string>("SUC_DEST"); }
                if (dr.Table.Columns.Contains("TRASLADA")) { movimiento.TRASLADA = dr.Field<string>("TRASLADA"); }
                if (dr.Table.Columns.Contains("RECIBE")) { movimiento.RECIBE = dr.Field<string>("RECIBE"); }
                if (dr.Table.Columns.Contains("TOTAL")) { movimiento.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("RECIBIDO")) { movimiento.RECIBIDO = dr.Field<bool>("RECIBIDO"); }
                if (dr.Table.Columns.Contains("ESTADO")) { movimiento.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { movimiento.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { movimiento.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { movimiento.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("DESTINO")) { movimiento.DESTINO = dr.Field<string>("DESTINO"); }
                if (dr.Table.Columns.Contains("ENVIA")) { movimiento.ENVIA = dr.Field<string>("ENVIA"); }

            }
            return movimiento;

        }



        public MovCash Copy()
        {
            MovCash copy = (MovCash)this.MemberwiseClone();
            return copy;
        }

    }
}
