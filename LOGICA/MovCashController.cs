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

    public class MovCashController
    {
        private DBMovCash db;

        public MovCashController()
        {
            db = new DBMovCash();
        }


       
        public DataTable FINANC_PRENDASAL(string sucursal,DateTime fecha)
        {
            return db.FinancBySucPRENDASAL(sucursal,fecha);
        }


        public DataTable REMESA_PRENDASAL(string sucursal, DateTime fecha)
        {
            return db.RemesaBySucPRENDASAL(sucursal,fecha);
        }


        public bool registrarMovCashPRENDASAL(MovCash mov, string sucursal, string empleado, string sistema)
        {
            try
            {
                mov.ESTADO = eEstadoMovCash.PREINGRESADO;
                db.insertPRENDASAL(mov, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool editarMovCashPRENDASAL(MovCash mov, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.updatePRENDASAL(mov, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool eliminarMovCashPRENDASAL(MovCash mov,string sucursal, string empleado, string sistema)
        {
            try
            {
                db.deletePRENDASAL(mov, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }





        public string NEXT_COMPROBANTE_FINANC(string sucursal)
        {
            return db.nextComprobantePRENDASAL(sucursal,eTipoMovCash.FINANCIAMIENTO);
        }



        public string NEXT_COMPROBANTE_REMESA(string sucursal)
        {
            return db.nextComprobantePRENDASAL(sucursal, eTipoMovCash.REMESA);
        }



    }
}
