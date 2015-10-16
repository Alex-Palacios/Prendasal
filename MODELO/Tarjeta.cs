using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    using System.Data;
    using System.Windows.Forms;

    public class Tarjeta
    {
        public string NUMTARJETA;
        public string COD_CLIENTE;
        public DateTime FECHA_EXP;
        public eNIVEL TIPO;
        public DateTime FECHA_RENO;
        public DateTime FECHA_VENC;
        public decimal TASA_MENSUAL;
        public int PLAZO_CONTRATO;
        public int PLAZO_VENCIDO;
        public decimal DESC_COMPRA;
        public decimal DESC_INTERES;
        public int PUNTOS_DOLAR;
        public decimal PUNTOS_VALOR;
        public bool ACTIVA;

        //VARIABLES AUX
        public DataGridViewRowCollection MOVIMIENTOS;
        //DATOS CLIENTE
        public string CLIENTE;
        public string DUI;
        public string LICENCIA;
        public string PASAPORTE;
        public string CARNET;
        public string EXTENDIDO;
        public Int64? EDAD;
        public string TEL_CLI;
        public string DOMICILIO_CLI;
        public string DIRECCION_CLI;
        //DATOS CALCULADOS
        public double PUNTOS_ACUMULADOS;
        public string ESTADO_TARJETA;

        public Tarjeta()
        {
            this.TIPO = eNIVEL.PRENDASAL;
        }


        public static Tarjeta ConvertToTarjeta(DataRow dr)
        {
            Tarjeta tarjeta = new Tarjeta();
            if (dr != null)
            {
                if (dr.Table.Columns.Contains("NUMTARJETA")) { tarjeta.NUMTARJETA = dr.Field<string>("NUMTARJETA"); }
                if (dr.Table.Columns.Contains("COD_CLIENTE")) { tarjeta.COD_CLIENTE = dr.Field<string>("COD_CLIENTE");}
                if (dr.Table.Columns.Contains("FECHA_EXP")) { tarjeta.FECHA_EXP = dr.Field<DateTime>("FECHA_EXP"); }
                if (dr.Table.Columns.Contains("TIPO")) { tarjeta.TIPO = (eNIVEL)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("FECHA_RENO")) { tarjeta.FECHA_RENO = dr.Field<DateTime>("FECHA_RENO"); }
                if (dr.Table.Columns.Contains("FECHA_VENC")) { tarjeta.FECHA_VENC = dr.Field<DateTime>("FECHA_VENC"); }
                if (dr.Table.Columns.Contains("TASA_MENSUAL")) { tarjeta.TASA_MENSUAL = dr.Field<decimal>("TASA_MENSUAL"); }
                if (dr.Table.Columns.Contains("PLAZO_CONTRATO")) { tarjeta.PLAZO_CONTRATO = dr.Field<int>("PLAZO_CONTRATO"); }
                if (dr.Table.Columns.Contains("PLAZO_VENCIDO")) { tarjeta.PLAZO_VENCIDO = dr.Field<int>("PLAZO_VENCIDO"); }
                if (dr.Table.Columns.Contains("DESC_COMPRA")) { tarjeta.DESC_COMPRA = dr.Field<decimal>("DESC_COMPRA"); }
                if (dr.Table.Columns.Contains("DESC_INTERES")) { tarjeta.DESC_INTERES = dr.Field<decimal>("DESC_INTERES"); }
                if (dr.Table.Columns.Contains("PUNTOS_DOLAR")) { tarjeta.PUNTOS_DOLAR = dr.Field<int>("PUNTOS_DOLAR"); }
                if (dr.Table.Columns.Contains("PUNTOS_VALOR")) { tarjeta.PUNTOS_VALOR = dr.Field<decimal>("PUNTOS_VALOR"); }
                if (dr.Table.Columns.Contains("ACTIVA")) { tarjeta.ACTIVA = dr.Field<bool>("ACTIVA"); }

                if (dr.Table.Columns.Contains("CLIENTE")) { tarjeta.CLIENTE = dr.Field<string>("CLIENTE"); }
                if (dr.Table.Columns.Contains("DUI")) { tarjeta.DUI = dr.Field<string>("DUI"); }
                if (dr.Table.Columns.Contains("LICENCIA")) { tarjeta.LICENCIA = dr.Field<string>("LICENCIA"); }
                if (dr.Table.Columns.Contains("PASAPORTE")) { tarjeta.PASAPORTE = dr.Field<string>("PASAPORTE"); }
                if (dr.Table.Columns.Contains("CARNET")) { tarjeta.CARNET = dr.Field<string>("CARNET"); }
                if (dr.Table.Columns.Contains("EXTENDIDO")) { tarjeta.EXTENDIDO = dr.Field<string>("EXTENDIDO"); }
                if (dr.Table.Columns.Contains("EDAD")) { tarjeta.EDAD = dr.Field<Int64?>("EDAD"); }
                if (dr.Table.Columns.Contains("TEL_CLI")) { tarjeta.TEL_CLI = dr.Field<string>("TEL_CLI"); }
                if (dr.Table.Columns.Contains("DOMICILIO_CLI")) { tarjeta.DOMICILIO_CLI = dr.Field<string>("DOMICILIO_CLI"); }
                if (dr.Table.Columns.Contains("DIRECCION_CLI")) { tarjeta.DIRECCION_CLI = dr.Field<string>("DIRECCION_CLI"); }

            }
            return tarjeta;
        }



    }
}
