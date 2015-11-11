using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;

  

    public class Traslado
    {
        public int ID_TRASLADO;
        public DateTime FECHA;
        public eTipoTraslado TIPO;
        public string DOCUMENTO;
        public string SUC_ENVIA;
        public string SUC_DEST;
        public string ENVIA;
        public string TRASLADA;
        public string RECIBE;
        public bool RECIBIDO;
        public string NOTA;

        //VARIABLES AUX
        public string DE;
        public string HACIA;
        public DataTable REMISION;
        public DataTable CUSTODIA;

        public Traslado()
        {
            //DATOS POR DEFECTO
            REMISION = new DataTable();
            REMISION.Columns.Add("CODIGO").DataType = System.Type.GetType("System.String");
            REMISION.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Decimal");
            REMISION.Columns.Add("COD_ITEM").DataType = System.Type.GetType("System.String");
            REMISION.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            REMISION.Columns.Add("PRECIO").DataType = System.Type.GetType("System.Decimal");
            REMISION.Columns.Add("ID_DET_PRESTAMO").DataType = System.Type.GetType("System.Int32");
        }




        public static Traslado ConvertToTraslado(DataRow dr)
        {
            Traslado translado = null;
            if (dr != null)
            {
                translado = new Traslado();
                if (dr.Table.Columns.Contains("ID_TRASLADO")) { translado.ID_TRASLADO = dr.Field<int>("ID_TRASLADO"); }
                if (dr.Table.Columns.Contains("FECHA")) { translado.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { translado.TIPO = (eTipoTraslado)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { translado.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("SUC_ENVIA")) { translado.SUC_ENVIA = dr.Field<string>("SUC_ENVIA"); }
                if (dr.Table.Columns.Contains("SUC_DEST")) { translado.SUC_DEST = dr.Field<string>("SUC_DEST"); }
                if (dr.Table.Columns.Contains("ENVIA")) { translado.ENVIA = dr.Field<string>("ENVIA"); }
                if (dr.Table.Columns.Contains("TRASLADA")) { translado.TRASLADA = dr.Field<string>("TRASLADA"); }
                if (dr.Table.Columns.Contains("RECIBE")) { translado.RECIBE = dr.Field<string>("RECIBE"); }
                if (dr.Table.Columns.Contains("RECIBIDO")) { translado.RECIBIDO = dr.Field<bool>("RECIBIDO"); }
                if (dr.Table.Columns.Contains("NOTA")) { translado.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("DE")) { translado.DE = dr.Field<string>("DE"); }
                if (dr.Table.Columns.Contains("HACIA")) { translado.HACIA = dr.Field<string>("HACIA"); }

            }
            return translado;

        }



        public Traslado Copy()
        {
            Traslado copy = (Traslado)this.MemberwiseClone();
            copy.REMISION = this.REMISION.Copy();
            copy.CUSTODIA = this.CUSTODIA.Copy();
            return copy;
        }

        public eEstadoTraslado ESTADO_TRASLADO
        {
            get
            {
                if (this.RECIBIDO)
                {
                    return eEstadoTraslado.RECIBIDO;
                }
                else
                {
                    return eEstadoTraslado.PENDIENTE;
                }
            }
        }
    }
}
