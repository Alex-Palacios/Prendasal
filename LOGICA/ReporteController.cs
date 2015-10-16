using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    using MODELO;
    using DDB;
    using System.Data;

    public class ReporteController
    {
        private DBReporte db;

        public ReporteController()
        {
            db = new DBReporte();
        }


        public bool CERRAR_DIA_PRENDASAL(string sucCorte, DateTime fecha, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.CERRAR_DIA_PRENDASAL(sucCorte,fecha,sucursal,empleado,sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable LIBRO_DIARIO(int periodo)
        {
            return db.LIBRO_DIARIO(periodo);
        }


        public DataTable DIAS_ABIERTOS_PRENDASAL(string sucursal)
        {
            return db.DIAS_ABIERTOS_PRENDASAL(sucursal);
        }


        public DataTable REPORTE_DIARIO_PRENDASAL(string sucursal,DateTime fechaInicio, DateTime FechaFin)
        {
            return db.REPORTE_DIARIO_PRENDASAL(sucursal,fechaInicio,FechaFin);
        }


        public DataTable COMPRAS_KIL_DIARIO(string sucursal, DateTime fechaInicio, DateTime FechaFin)
        {
            return db.COMPRAS_KIL_DIARIO(sucursal, fechaInicio, FechaFin);
        }


        public decimal FN_CALCULAR_APERTURA_PRENDASAL(string sucursal, DateTime fecha)
        {
            return db.FN_CALCULAR_APERTURA_PRENDASAL(sucursal, fecha);
        }



        public DataTable CONTRATOS_CANCELADOS_PRENDASAL(string sucursal, DateTime fechaInicio, DateTime FechaFin)
        {
            return db.CONTRATOS_CANCELADOS_PRENDASAL(sucursal, fechaInicio, FechaFin);
        }


        public DataTable COMPRAS_KILMES(string sucursal, string mes, string anio)
        {
            return db.COMPRAS_KILMES(sucursal, mes, anio);
        }

    }
}
