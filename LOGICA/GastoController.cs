using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGICA
{
    using MODELO;
    using DDB;
    using System.Data;

    public class GastoController
    {
        private DBGasto db;

        public GastoController()
        {
            db = new DBGasto();
        }






        public DataTable GASTOS_PRENDASAL(string sucursal, DateTime fecha)
        {
            return db.selectGastosBySucPRENDASAL(sucursal, fecha);
        }


        public DataTable GET_ITEMS_GASTO(Gasto gasto)
        {
            return db.getItemsGasto(gasto.ID_GASTO);
        }



        public bool isCancelado(Gasto gasto)
        {
            try
            {
                return db.isCancelado(gasto.ID_GASTO);
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool registrarGastoPRENDASAL(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            try
            {
                gasto.ESTADO = eEstadoGasto.PREINGRESADA;
                gasto.INIT_BALANCE = false;
                db.insertPRENDASAL(gasto, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool editarGastoPRENDASAL(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.updatePRENDASAL(gasto, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool eliminarGastoPRENDASAL(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.deletePRENDASAL(gasto, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Gasto findByGastoPRENDASAL(string doc)
        {
            Gasto g = null;
            DataTable dt = db.findByGastoPRENDASAL(doc);
            if (dt.Rows.Count > 0)
            {
                g = new Gasto();
                g.ID_GASTO = dt.Rows[0].Field<int>("ID_GASTO");
                g.TRANSACCION = dt.Rows[0].Field<string>("COD_TRANS");
                g.RESPONSABLE = dt.Rows[0].Field<string>("RESPONSABLE");
                g.COD_SUC = dt.Rows[0].Field<string>("COD_SUC");
                g.SUCURSAL = dt.Rows[0].Field<string>("SUCURSAL");
                g.FECHA = dt.Rows[0].Field<DateTime>("FECHA");
                g.TIPO_DOC = (eTipoDocGasto)dt.Rows[0].Field<int>("TIPO_DOC");
                g.DOCUMENTO = dt.Rows[0].Field<string>("DOCUMENTO");
                g.DESCRIPCION = dt.Rows[0].Field<string>("DESCRIPCION");
                g.SUMAS = dt.Rows[0].Field<decimal>("SUMAS");
                g.TOTAL = dt.Rows[0].Field<decimal>("TOTAL");
                g.NOTA = dt.Rows[0].Field<string>("NOTA");
                g.ESTADO = (eEstadoGasto)dt.Rows[0].Field<int>("ESTADO");
                g.INIT_BALANCE = dt.Rows[0].Field<bool>("INIT_BALANCE");
            }
            return g;
        }




    }
}
