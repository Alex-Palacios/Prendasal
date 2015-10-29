using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;


    



    public class Prestamo
    {
        //ATRIBUTOS BD
        public int ID_PRESTAMO;
        public string COD_SUC;
        public string COD_TRANS;
        public string COD_CLIENTE;
        public DateTime FECHA;
        public eTipoPrestamo TIPO;
        public string DOCUMENTO;
        public eTipoPago TIPO_PAGO;
        public decimal TASA_MENSUAL;
        public int PLAZO_CONTRATO;
        public int PLAZO_VENC;
        public decimal TOTAL;
        public eCategoria CATEGORIA;
        public decimal SALDO;
        public DateTime ULTIMA_PRORROGA;
        public eNIVEL NIVEL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;
        

        //VARIBLES AUXILIARES
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

        public DataTable ITEMS_PRESTAMO;
        public DataTable HISTORIAL_PAC;

        //DATOS CALCULADOS
        public Int64 DIAS_TRANS;
        public eEstadoContrato ESTADO_CONTRATO;


        public Prestamo()
        {
            //DATOS POR DEFECTO
            ITEMS_PRESTAMO = new DataTable();
            ITEMS_PRESTAMO.Columns.Add("CATEGORIA").DataType = System.Type.GetType("System.String");
            ITEMS_PRESTAMO.Columns.Add("COD_ITEM").DataType = System.Type.GetType("System.String");
            ITEMS_PRESTAMO.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Decimal");
            ITEMS_PRESTAMO.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            ITEMS_PRESTAMO.Columns.Add("MONTO").DataType = System.Type.GetType("System.Decimal");

            HISTORIAL_PAC = new DataTable();

        }


        public static Prestamo ConvertToPrestamo(DataRow dr)
        {
            Prestamo prestamo = null;
            if (dr != null)
            {
                prestamo = new Prestamo();
                if (dr.Table.Columns.Contains("ID_PRESTAMO")) { prestamo.ID_PRESTAMO = dr.Field<int>("ID_PRESTAMO"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { prestamo.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { prestamo.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("COD_CLIENTE")) { prestamo.COD_CLIENTE = dr.Field<string>("COD_CLIENTE"); }
                if (dr.Table.Columns.Contains("FECHA")) { prestamo.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { prestamo.TIPO = (eTipoPrestamo)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { prestamo.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("TIPO_PAGO")) { prestamo.TIPO_PAGO = (eTipoPago)dr.Field<int>("TIPO_PAGO"); }
                if (dr.Table.Columns.Contains("TASA_MENSUAL")) { prestamo.TASA_MENSUAL = dr.Field<decimal>("TASA_MENSUAL"); }
                if (dr.Table.Columns.Contains("PLAZO_CONTRATO")) { prestamo.PLAZO_CONTRATO = dr.Field<int>("PLAZO_CONTRATO"); }
                if (dr.Table.Columns.Contains("PLAZO_VENC")) { prestamo.PLAZO_VENC = dr.Field<int>("PLAZO_VENC"); }
                if (dr.Table.Columns.Contains("TOTAL")) { prestamo.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("CATEGORIA")) { try { prestamo.CATEGORIA = (eCategoria)Enum.Parse(typeof(eCategoria), dr.Field<string>("CATEGORIA")); } catch (Exception e) { }; }
                if (dr.Table.Columns.Contains("SALDO")) { prestamo.SALDO = dr.Field<decimal>("SALDO"); }
                if (dr.Table.Columns.Contains("ULTIMA_PRORROGA")) { prestamo.ULTIMA_PRORROGA = dr.Field<DateTime>("ULTIMA_PRORROGA"); }
                if (dr.Table.Columns.Contains("NIVEL")) { prestamo.NIVEL = (eNIVEL)dr.Field<int>("NIVEL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { prestamo.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { prestamo.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { prestamo.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { prestamo.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("ARTICULO")) { prestamo.ARTICULO = dr.Field<string>("ARTICULO"); }
                if (dr.Table.Columns.Contains("CLIENTE")) { prestamo.CLIENTE = dr.Field<string>("CLIENTE"); }
                if (dr.Table.Columns.Contains("NIT")) { prestamo.NIT = dr.Field<string>("NIT"); }
                if (dr.Table.Columns.Contains("DUI")) { prestamo.DUI = dr.Field<string>("DUI"); }
                if (dr.Table.Columns.Contains("LICENCIA")) { prestamo.LICENCIA = dr.Field<string>("LICENCIA"); }
                if (dr.Table.Columns.Contains("PASAPORTE")) { prestamo.PASAPORTE = dr.Field<string>("PASAPORTE"); }
                if (dr.Table.Columns.Contains("CARNET")) { prestamo.CARNET = dr.Field<string>("CARNET"); }
                if (dr.Table.Columns.Contains("EXTENDIDO")) { prestamo.EXTENDIDO = dr.Field<string>("EXTENDIDO"); }
                if (dr.Table.Columns.Contains("EDAD")) { prestamo.EDAD = dr.Field<Int64?>("EDAD"); }
                if (dr.Table.Columns.Contains("TEL_CLI")) { prestamo.TEL_CLI = dr.Field<string>("TEL_CLI"); }
                if (dr.Table.Columns.Contains("DEPTO_CLI")) { prestamo.DEPTO_CLI = dr.Field<string>("DEPTO_CLI"); }
                if (dr.Table.Columns.Contains("DOMICILIO_CLI")) { prestamo.DOMICILIO_CLI = dr.Field<string>("DOMICILIO_CLI"); }
                if (dr.Table.Columns.Contains("DIRECCION_CLI")) { prestamo.DIRECCION_CLI = dr.Field<string>("DIRECCION_CLI"); }

                if (dr.Table.Columns.Contains("DIAS_TRANS")) { prestamo.DIAS_TRANS = dr.Field<Int64>("DIAS_TRANS"); }
                if (dr.Table.Columns.Contains("ESTADO_CONTRATO")) { prestamo.ESTADO_CONTRATO = (eEstadoContrato)Enum.Parse(typeof(eEstadoContrato), dr.Field<string>("ESTADO_CONTRATO")); }

            }
            return prestamo;

        }



        public Prestamo Copy()
        {
            Prestamo copy = (Prestamo)this.MemberwiseClone();
            copy.ITEMS_PRESTAMO = this.ITEMS_PRESTAMO.Copy();
            return copy;
        }


        public DateTime FECHA_VENC_INIT
        {
            get
            {
                return this.FECHA.AddMonths(this.PLAZO_CONTRATO / 30); ;
            }
        }

        public DateTime FECHA_VENC
        {
            get
            {
                return this.ULTIMA_PRORROGA.AddMonths(this.PLAZO_CONTRATO / 30);
            }
        }


        public decimal INTERES_MENSUAL_INIT
        {
            get
            {
                return Decimal.Round(this.TOTAL * this.TASA_MENSUAL / 100, 2, MidpointRounding.AwayFromZero);
            }
        }


        public decimal INTERES_DIARIO_INIT
        {
            get
            {
                return Decimal.Round(this.INTERES_MENSUAL_INIT / 30, 4, MidpointRounding.AwayFromZero); // MES = 30 DIAS
            }
        }




        public decimal INTERES_MENSUAL
        {
            get{
                return Decimal.Round(this.SALDO * this.TASA_MENSUAL / 100, 2, MidpointRounding.AwayFromZero);
            }
        }


        public decimal INTERES_DIARIO
        {
            get{
                return Decimal.Round(this.INTERES_MENSUAL / 30, 4, MidpointRounding.AwayFromZero); // MES = 30 DIAS
            }
        }

        



        public string getNotasHistorialPAC()
        {
            string notas = string.Empty;
            foreach (DataRow row in this.HISTORIAL_PAC.Rows)
            {
                if (row.Field<string>("NOTA") != null && row.Field<string>("NOTA") != string.Empty)
                {
                    string notaX = notas;
                    notas = row.Field<string>("DOCUMENTO") + ":  " + row.Field<string>("NOTA") + "\n\n";
                    notas = notas + notaX;
                }
                
            }
            return notas;
        }
    }
}
