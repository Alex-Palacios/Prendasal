using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;


    public class Compra
    {
        public int ID_COMPRA;
        public string COD_SUC;
        public string COD_TRANS;
        public string COD_CLIENTE;
        public DateTime FECHA;
        public eTipoCompra TIPO;
        public string DOCUMENTO;
        public eTipoPago TIPO_PAGO;
        public decimal TOTAL;
        public eCategoria CATEGORIA;
        public eNIVEL NIVEL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;

        public string RESPONSABLE;
        public string CLIENTE;
        public string NIT;
        public string DUI;
        public string LICENCIA;
        public string PASAPORTE;
        public string CARNET;
        public string EXTENDIDO;
        public Int64?  EDAD;
        public string TEL_CLI;
        public string DEPTO_CLI;
        public string DOMICILIO_CLI;
        public string DIRECCION_CLI;

        public DataTable ITEMS_COMPRA;
        

        public Compra()
        {
            //DATOS POR DEFECTO
            ITEMS_COMPRA = new DataTable();
            ITEMS_COMPRA.Columns.Add("CATEGORIA").DataType = System.Type.GetType("System.String");
            ITEMS_COMPRA.Columns.Add("COD_ITEM").DataType = System.Type.GetType("System.String");
            ITEMS_COMPRA.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Decimal");
            ITEMS_COMPRA.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            ITEMS_COMPRA.Columns.Add("MONTO").DataType = System.Type.GetType("System.Decimal");
        }




        public static Compra ConvertToCompra(DataRow dr)
        {
            Compra compra = null;
            if (dr != null)
            {
                compra = new Compra();
                if (dr.Table.Columns.Contains("ID_COMPRA")) { compra.ID_COMPRA = dr.Field<int>("ID_COMPRA"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { compra.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { compra.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("COD_CLIENTE")) { compra.COD_CLIENTE = dr.Field<string>("COD_CLIENTE"); }
                if (dr.Table.Columns.Contains("FECHA")) { compra.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { compra.TIPO = (eTipoCompra)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { compra.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("TIPO_PAGO")) { compra.TIPO_PAGO = (eTipoPago) dr.Field<int>("TIPO_PAGO"); }
                if (dr.Table.Columns.Contains("TOTAL")) { compra.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("CATEGORIA")) { compra.CATEGORIA = (eCategoria)Enum.Parse(typeof(eCategoria), dr.Field<string>("CATEGORIA")); }
                if (dr.Table.Columns.Contains("NIVEL")) { compra.NIVEL = (eNIVEL) dr.Field<int>("NIVEL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { compra.ESTADO = (eEstado) dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { compra.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { compra.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { compra.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("CLIENTE")) { compra.CLIENTE = dr.Field<string>("CLIENTE"); }
                if (dr.Table.Columns.Contains("NIT")) { compra.NIT = dr.Field<string>("NIT"); }
                if (dr.Table.Columns.Contains("DUI")) { compra.DUI = dr.Field<string>("DUI"); }
                if (dr.Table.Columns.Contains("LICENCIA")) { compra.LICENCIA = dr.Field<string>("LICENCIA"); }
                if (dr.Table.Columns.Contains("PASAPORTE")) { compra.PASAPORTE = dr.Field<string>("PASAPORTE"); }
                if (dr.Table.Columns.Contains("CARNET")) { compra.CARNET = dr.Field<string>("CARNET"); }
                if (dr.Table.Columns.Contains("EXTENDIDO")) { compra.EXTENDIDO = dr.Field<string>("EXTENDIDO"); }
                if (dr.Table.Columns.Contains("EDAD")) { compra.EDAD = dr.Field<Int64?>("EDAD"); }
                if (dr.Table.Columns.Contains("TEL_CLI")) { compra.TEL_CLI = dr.Field<string>("TEL_CLI"); }
                if (dr.Table.Columns.Contains("DEPTO_CLI")) { compra.DEPTO_CLI = dr.Field<string>("DEPTO_CLI"); }
                if (dr.Table.Columns.Contains("DOMICILIO_CLI")) { compra.DOMICILIO_CLI = dr.Field<string>("DOMICILIO_CLI"); }
                if (dr.Table.Columns.Contains("DIRECCION_CLI")) { compra.DIRECCION_CLI = dr.Field<string>("DIRECCION_CLI"); }
                
            }
            return compra;

        }

        public Compra Copy()
        {
            Compra copy = (Compra)this.MemberwiseClone();
            copy.ITEMS_COMPRA = this.ITEMS_COMPRA.Copy();
            return  copy;
        }



        public string getArticulosText()
        {
            string ARTICULOS = string.Empty;
            foreach (DataRow row in this.ITEMS_COMPRA.Rows)
            {
                switch (this.CATEGORIA)
                {
                    case eCategoria.ARTICULO:
                        ARTICULOS = ARTICULOS + row.Field<string>("CATEGORIA") + ":" + 
                                    row.Field<decimal>("CANTIDAD") + " " + 
                                    row.Field<string>("COD_ITEM")  +
                                    row.Field<string>("DESCRIPCION") + ".-";
                        break;
                    case eCategoria.ORO:
                        ARTICULOS = ARTICULOS + row.Field<string>("CATEGORIA") + ":" +
                                    row.Field<string>("DESCRIPCION") +" "+
                                    row.Field<string>("COD_ITEM") +" "+
                                    row.Field<decimal>("CANTIDAD") + " GRS" + ".-";
                        break;
                } 
            }
            return ARTICULOS;
        }



    }
}
