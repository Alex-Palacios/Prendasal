using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    using System.Data;
    using System.Windows.Forms;

    
    public class Venta
    {
        public int ID_VENTA;
        public string COD_SUC;
        public string COD_TRANS;
        public string COD_CLIENTE;
        public DateTime FECHA;
        public eTipoVenta TIPO;
        public string NUMVENTA;
        public string DOCUMENTO;
        public eTipoPago TIPO_PAGO;
        public decimal SUMAS;
        public decimal DESCUENTO;
        public decimal SUBTOTAL;
        public decimal IVA;
        public decimal IVA_DESC;
        public decimal CESC;
        public decimal TOTAL;
        public eCategoria CATEGORIA;
        public eNIVEL NIVEL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;

        //AUXILIARES
        public bool isCESC;
        public string RESPONSABLE;
        public string ARTICULO;
        public string CLIENTE;
        public string NIT;
        public string DUI;
        public string LICENCIA;
        public string PASAPORTE;
        public string CARNET;
        public string EXTENDIDO;
        public Int64? EDAD;
        public string TEL_CLI;
        public string DEPTO_CLI;
        public string DOMICILIO_CLI;
        public string DIRECCION_CLI;

        //CALCULADOS
        
        public DataTable ITEMS_VENTA;

        public Venta()
        {
            //DATOS POR DEFECTO
            ITEMS_VENTA = new DataTable();
            ITEMS_VENTA.Columns.Add("CATEGORIA").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("CODIGO").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("COD_ITEM").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            ITEMS_VENTA.Columns.Add("MONTO").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("COSTO").DataType = System.Type.GetType("System.Decimal");
            ITEMS_VENTA.Columns.Add("PRECIO").DataType = System.Type.GetType("System.Decimal");
        }



        public static Venta ConvertToVenta(DataRow dr)
        {
            Venta venta = null;
            if (dr != null)
            {
                venta = new Venta();
                if (dr.Table.Columns.Contains("ID_VENTA")) { venta.ID_VENTA = dr.Field<int>("ID_VENTA"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { venta.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { venta.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("COD_CLIENTE")) { venta.COD_CLIENTE = dr.Field<string>("COD_CLIENTE"); }
                if (dr.Table.Columns.Contains("FECHA")) { venta.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { venta.TIPO = (eTipoVenta)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("NUMVENTA")) { venta.NUMVENTA = dr.Field<string>("NUMVENTA"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { venta.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("TIPO_PAGO")) { venta.TIPO_PAGO = (eTipoPago)dr.Field<int>("TIPO_PAGO"); }
                if (dr.Table.Columns.Contains("SUMAS")) { venta.SUMAS = dr.Field<decimal>("SUMAS"); }
                if (dr.Table.Columns.Contains("DESCUENTO")) { venta.DESCUENTO = dr.Field<decimal>("DESCUENTO"); }
                if (dr.Table.Columns.Contains("SUBTOTAL")) { venta.SUBTOTAL = dr.Field<decimal>("SUBTOTAL"); }
                if (dr.Table.Columns.Contains("CESC")) { venta.CESC = dr.Field<decimal>("CESC"); }
                if (dr.Table.Columns.Contains("TOTAL")) { venta.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("IVA")) { venta.IVA = dr.Field<decimal>("IVA"); }
                if (dr.Table.Columns.Contains("IVA_DESC")) { venta.IVA_DESC = dr.Field<decimal>("IVA_DESC"); }
                if (dr.Table.Columns.Contains("CATEGORIA")) { venta.CATEGORIA = (eCategoria)Enum.Parse(typeof(eCategoria), dr.Field<string>("CATEGORIA")); }
                if (dr.Table.Columns.Contains("NIVEL")) { venta.NIVEL = (eNIVEL)dr.Field<int>("NIVEL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { venta.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { venta.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { venta.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { venta.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("ARTICULO")) { venta.ARTICULO = dr.Field<string>("ARTICULO"); }
                if (dr.Table.Columns.Contains("CLIENTE")) { venta.CLIENTE = dr.Field<string>("CLIENTE"); }
                if (dr.Table.Columns.Contains("NIT")) { venta.NIT = dr.Field<string>("NIT"); }
                if (dr.Table.Columns.Contains("DUI")) { venta.DUI = dr.Field<string>("DUI"); }
                if (dr.Table.Columns.Contains("LICENCIA")) { venta.LICENCIA = dr.Field<string>("LICENCIA"); }
                if (dr.Table.Columns.Contains("PASAPORTE")) { venta.PASAPORTE = dr.Field<string>("PASAPORTE"); }
                if (dr.Table.Columns.Contains("CARNET")) { venta.CARNET = dr.Field<string>("CARNET"); }
                if (dr.Table.Columns.Contains("EXTENDIDO")) { venta.EXTENDIDO = dr.Field<string>("EXTENDIDO"); }
                if (dr.Table.Columns.Contains("EDAD")) { venta.EDAD = dr.Field<Int64?>("EDAD"); }
                if (dr.Table.Columns.Contains("TEL_CLI")) { venta.TEL_CLI = dr.Field<string>("TEL_CLI"); }
                if (dr.Table.Columns.Contains("DEPTO_CLI")) { venta.DEPTO_CLI = dr.Field<string>("DEPTO_CLI"); }
                if (dr.Table.Columns.Contains("DOMICILIO_CLI")) { venta.DOMICILIO_CLI = dr.Field<string>("DOMICILIO_CLI"); }
                if (dr.Table.Columns.Contains("DIRECCION_CLI")) { venta.DIRECCION_CLI = dr.Field<string>("DIRECCION_CLI"); }

                venta.isCESC = (venta.CESC > 0);
            }
            return venta;

        }




        public Venta Copy()
        {
            Venta copy = (Venta)this.MemberwiseClone();
            copy.ITEMS_VENTA = this.ITEMS_VENTA.Copy();
            return copy;
        }





        public void calcularTotales()
        {
            this.SUMAS= (decimal)0.00;
            this.SUBTOTAL = (decimal)0.00;
            this.CESC = (decimal)0.00;
            this.TOTAL = (decimal) 0.00;
            //CALCULOS
            this.SUMAS = this.ITEMS_VENTA.AsEnumerable().Select(r => r.Field<decimal>("MONTO")).Sum();
            this.SUBTOTAL = this.SUMAS - this.DESCUENTO;
            this.IVA = Decimal.Round(this.SUMAS - (this.SUMAS / (1 + Properties.Settings.Default.IVA)), 2, MidpointRounding.AwayFromZero);
            this.IVA_DESC = Decimal.Round(this.DESCUENTO - (this.DESCUENTO/ (1 + Properties.Settings.Default.IVA)), 2, MidpointRounding.AwayFromZero);
            
            if (isCESC)
            {
                this.CESC = Decimal.Round((this.SUBTOTAL - this.IVA + this.IVA_DESC) * Properties.Settings.Default.CESC, 2, MidpointRounding.AwayFromZero);
            }

            this.TOTAL = this.SUBTOTAL + this.CESC;
        }

        
    }
}
