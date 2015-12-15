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
        public DataTable DETALLE_TRASLADO;

        public Traslado()
        {
            //DATOS POR DEFECTO
            DETALLE_TRASLADO = new DataTable();
            DETALLE_TRASLADO.Columns.Add("TIPO").DataType = System.Type.GetType("System.Int32");
            DETALLE_TRASLADO.Columns.Add("CODIGO").DataType = System.Type.GetType("System.String");
            DETALLE_TRASLADO.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Decimal");
            DETALLE_TRASLADO.Columns.Add("COD_ITEM").DataType = System.Type.GetType("System.String");
            DETALLE_TRASLADO.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            DETALLE_TRASLADO.Columns.Add("PRECIO").DataType = System.Type.GetType("System.Decimal");
            DETALLE_TRASLADO.Columns.Add("RECIBIDO").DataType = System.Type.GetType("System.Boolean");


            

        }




        public static Traslado ConvertToTraslado(DataRow dr)
        {
            Traslado traslado = null;
            if (dr != null)
            {
                traslado = new Traslado();
                if (dr.Table.Columns.Contains("ID_TRASLADO")) { traslado.ID_TRASLADO = dr.Field<int>("ID_TRASLADO"); }
                if (dr.Table.Columns.Contains("FECHA")) { traslado.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { traslado.TIPO = (eTipoTraslado)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { traslado.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("SUC_ENVIA")) { traslado.SUC_ENVIA = dr.Field<string>("SUC_ENVIA"); }
                if (dr.Table.Columns.Contains("SUC_DEST")) { traslado.SUC_DEST = dr.Field<string>("SUC_DEST"); }
                if (dr.Table.Columns.Contains("ENVIA")) { traslado.ENVIA = dr.Field<string>("ENVIA"); }
                if (dr.Table.Columns.Contains("TRASLADA")) { traslado.TRASLADA = dr.Field<string>("TRASLADA"); }
                if (dr.Table.Columns.Contains("RECIBE")) { traslado.RECIBE = dr.Field<string>("RECIBE"); }
                if (dr.Table.Columns.Contains("RECIBIDO")) { traslado.RECIBIDO = dr.Field<bool>("RECIBIDO"); }
                if (dr.Table.Columns.Contains("NOTA")) { traslado.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("DE")) { traslado.DE = dr.Field<string>("DE"); }
                if (dr.Table.Columns.Contains("HACIA")) { traslado.HACIA = dr.Field<string>("HACIA"); }

            }
            return traslado;

        }



        public Traslado Copy()
        {
            Traslado copy = (Traslado)this.MemberwiseClone();
            copy.DETALLE_TRASLADO = this.DETALLE_TRASLADO.Copy();
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



        public DataTable CUSTODIA_PRESTAMOS
        {
            get
            {
                DataTable DETALLE = this.DETALLE_TRASLADO.Copy();
                DETALLE.DefaultView.RowFilter = "TIPO = "+ (int) eTipoDetalleTraslado.PRESTAMO;
                return DETALLE.DefaultView.Table;
            }
        }

        public DataTable CUSTODIA_COMPRAS
        {
            get
            {
                DataTable DETALLE = this.DETALLE_TRASLADO.Copy();
                DETALLE.DefaultView.RowFilter = "TIPO = " + (int)eTipoDetalleTraslado.COMPRA;
                return DETALLE.DefaultView.Table;
            }
        }


    }
}
