using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;
    using System.Windows.Forms;

   
   
    
    
    
    public class Pac
    {
        //ATRIBUTOS BD
        public int ID_PAC;
        public string COD_SUC;
        public string COD_TRANS;
        public int ID_PRESTAMO;
        public DateTime FECHA;
        public string RECIBO;
        public eTipoPago TIPO_PAGO;
        public string DOCUMENTO;
        public eTipoMovPac TIPO;
        public int MESES;
        public int DIAS;
        public decimal INTERES;
        public decimal DESCUENTO;
        public decimal ABONO;
        public decimal TOTAL;
        public eNIVEL NIVEL;
        public eEstado ESTADO;
        public bool INIT_BALANCE;
        public string NOTA;
    
        public string RESPONSABLE;
        public Prestamo CONTRATO;
        //DATOS CALCULADOS
        public DateTime HASTA;
        public decimal NUEVO_SALDO;


        public Pac()
        {

        }


        public static Pac ConvertToPAC(DataRow dr)
        {
            Pac pac = null;
            if (dr != null)
            {
                pac = new Pac();
                if (dr.Table.Columns.Contains("ID_PAC")) { pac.ID_PAC = dr.Field<int>("ID_PAC"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { pac.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("COD_TRANS")) { pac.COD_TRANS = dr.Field<string>("COD_TRANS"); }
                if (dr.Table.Columns.Contains("ID_PRESTAMO")) { pac.ID_PRESTAMO = dr.Field<int>("ID_PRESTAMO"); }
                if (dr.Table.Columns.Contains("FECHA")) { pac.FECHA = dr.Field<DateTime>("FECHA"); }
                if (dr.Table.Columns.Contains("TIPO")) { pac.TIPO = (eTipoMovPac)dr.Field<int>("TIPO"); }
                if (dr.Table.Columns.Contains("RECIBO")) { pac.RECIBO = dr.Field<string>("RECIBO"); }
                if (dr.Table.Columns.Contains("DOCUMENTO")) { pac.DOCUMENTO = dr.Field<string>("DOCUMENTO"); }
                if (dr.Table.Columns.Contains("TIPO_PAGO")) { pac.TIPO_PAGO = (eTipoPago)dr.Field<int>("TIPO_PAGO"); }
                if (dr.Table.Columns.Contains("MESES")) { pac.MESES = dr.Field<int>("MESES"); }
                if (dr.Table.Columns.Contains("DIAS")) { pac.DIAS = dr.Field<int>("DIAS"); }
                if (dr.Table.Columns.Contains("INTERES")) { pac.INTERES = dr.Field<decimal>("INTERES"); }
                if (dr.Table.Columns.Contains("DESCUENTO")) { pac.DESCUENTO = dr.Field<decimal>("DESCUENTO"); }
                if (dr.Table.Columns.Contains("ABONO")) { pac.ABONO = dr.Field<decimal>("ABONO"); }
                if (dr.Table.Columns.Contains("TOTAL")) { pac.TOTAL = dr.Field<decimal>("TOTAL"); }
                if (dr.Table.Columns.Contains("NIVEL")) { pac.NIVEL = (eNIVEL)dr.Field<int>("NIVEL"); }
                if (dr.Table.Columns.Contains("ESTADO")) { pac.ESTADO = (eEstado)dr.Field<int>("ESTADO"); }
                if (dr.Table.Columns.Contains("INIT_BALANCE")) { pac.INIT_BALANCE = dr.Field<bool>("INIT_BALANCE"); }
                if (dr.Table.Columns.Contains("NOTA")) { pac.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("RESPONSABLE")) { pac.RESPONSABLE = dr.Field<string>("RESPONSABLE"); }
                if (dr.Table.Columns.Contains("NUEVO_SALDO")) { pac.NUEVO_SALDO = dr.Field<decimal>("NUEVO_SALDO"); }
                if (dr.Table.Columns.Contains("HASTA")) { pac.HASTA = dr.Field<DateTime>("HASTA"); }
               
            }
            return pac;

        }

        public Pac Copy()
        {
            Pac copy = (Pac)this.MemberwiseClone();
            return copy;
        }


        public DateTime DESDE
        {
            get
            {
                return HASTA.AddDays(-this.DIAS).AddMonths(-this.MESES);
            }
        }



        public DateTime PROXIMO_PAGO
        {
            get
            {
                return  HASTA.AddMonths(this.CONTRATO.PLAZO_CONTRATO/30);
            }
        }



        public decimal SALDO_ANTERIOR
        {
            get
            {
                return (this.NUEVO_SALDO + this.ABONO);
            }
        }


        public decimal NUEVO_INTERES
        {
            get
            {
                return Decimal.Round(this.NUEVO_SALDO * this.CONTRATO.TASA_MENSUAL/100,2,MidpointRounding.AwayFromZero);
            }
        }


        public decimal IVA
        {
            get
            {
                return Decimal.Round(this.INTERES - (this.INTERES*100/(100 + Properties.Settings.Default.IVA)), 2, MidpointRounding.AwayFromZero);
            }
        }

        public decimal IVA_DESC
        {
            get
            {
                return Decimal.Round(this.DESCUENTO - (this.DESCUENTO*100/(100 + Properties.Settings.Default.IVA)), 2, MidpointRounding.AwayFromZero);
            }
        }


        

    }


}
