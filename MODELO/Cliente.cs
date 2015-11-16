using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    using System.Data;

    public class Cliente
    {

        public string COD_CLIENTE;
        public string COD_SUC;
        public DateTime FECHA_INICIO;
        public string CLIENTE;
        public eSexo SEXO;
        public DateTime? FECHA_NAC;
        public string NIT;
        public string DUI;
        public string LICENCIA;
        public string PASAPORTE;
        public string CARNET;
        public string EXT;
        public DateTime? FECHA_VENC;
        public string TEL;
        public string EMAIL;
        public string COD_MUNICIPIO;
        public string DIRECCION;
        public string PROFESION;
        public string CONTACTO;
        public string TEL_CONTACTO;
        public string NOTA;

        public string EXTENDIDO;
        public Int64? EDAD;  
        public string DEPTO;
        public string DOMICILIO;


        public Cliente()
        {
            
        }


        public static Cliente ConvertToCliente(DataRow dr)
        {
            Cliente cli = new Cliente();
            if (dr != null)
            {
                if (dr.Table.Columns.Contains("COD_CLIENTE")) { cli.COD_CLIENTE = dr.Field<string>("COD_CLIENTE"); }
                if (dr.Table.Columns.Contains("COD_SUC")) { cli.COD_SUC = dr.Field<string>("COD_SUC"); }
                if (dr.Table.Columns.Contains("FECHA_INICIO")) { cli.FECHA_INICIO = dr.Field<DateTime>("FECHA_INICIO"); }
                if (dr.Table.Columns.Contains("CLIENTE")) { cli.CLIENTE = dr.Field<string>("CLIENTE"); }
                if (dr.Table.Columns.Contains("SEXO")) { cli.SEXO = (eSexo)Char.ConvertToUtf32(dr.Field<string>("SEXO"),0); }
                if (dr.Table.Columns.Contains("FECHA_NAC")) { cli.FECHA_NAC = dr.Field<DateTime?>("FECHA_NAC"); }
                if (dr.Table.Columns.Contains("NIT")) { cli.NIT = dr.Field<string>("NIT"); }
                if (dr.Table.Columns.Contains("DUI")) { cli.DUI = dr.Field<string>("DUI"); }
                if (dr.Table.Columns.Contains("LICENCIA")) { cli.LICENCIA = dr.Field<string>("LICENCIA"); }
                if (dr.Table.Columns.Contains("PASAPORTE")) { cli.PASAPORTE = dr.Field<string>("PASAPORTE"); }
                if (dr.Table.Columns.Contains("CARNET")) { cli.CARNET = dr.Field<string>("CARNET"); }
                if (dr.Table.Columns.Contains("EXT")) { cli.EXT = dr.Field<string>("EXT"); }
                if (dr.Table.Columns.Contains("FECHA_VENC")) { cli.FECHA_VENC = dr.Field<DateTime?>("FECHA_VENC"); }
                if (dr.Table.Columns.Contains("TEL")) { cli.TEL = dr.Field<string>("TEL"); }
                if (dr.Table.Columns.Contains("EMAIL")) { cli.EMAIL = dr.Field<string>("EMAIL"); }
                if (dr.Table.Columns.Contains("COD_MUNICIPIO")) { cli.COD_MUNICIPIO = dr.Field<string>("COD_MUNICIPIO"); }
                if (dr.Table.Columns.Contains("DIRECCION")) { cli.DIRECCION = dr.Field<string>("DIRECCION"); }
                if (dr.Table.Columns.Contains("PROFESION")) { cli.PROFESION = dr.Field<string>("PROFESION"); }
                if (dr.Table.Columns.Contains("CONTACTO")) { cli.CONTACTO = dr.Field<string>("CONTACTO"); }
                if (dr.Table.Columns.Contains("TEL_CONTACTO")) { cli.TEL_CONTACTO = dr.Field<string>("TEL_CONTACTO"); }
                if (dr.Table.Columns.Contains("NOTA")) { cli.NOTA = dr.Field<string>("NOTA"); }

                if (dr.Table.Columns.Contains("EXTENDIDO")) { cli.EXTENDIDO = dr.Field<string>("EXTENDIDO"); }
                if (dr.Table.Columns.Contains("EDAD")) { cli.EDAD = dr.Field<Int64?>("EDAD"); }
                if (dr.Table.Columns.Contains("DEPTO")) { cli.DEPTO = dr.Field<string>("DEPTO"); }
                if (dr.Table.Columns.Contains("DOMICILIO")) { cli.DOMICILIO = dr.Field<string>("DOMICILIO"); }
                
            }
            return cli;
        }


        public Cliente Copy()
        {
            Cliente copy = (Cliente)this.MemberwiseClone();
            return copy;
        }



    }
}
