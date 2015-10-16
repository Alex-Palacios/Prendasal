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

    public class IIController
    {
        private DBInvInicial db;

        public IIController()
        {
            db = new DBInvInicial();
        }

        

        public DataTable INVENTARIO_INICIAL(int periodo)
        {
            return db.getInventarioInicialPeriodo(periodo);
        }


        public bool cargarCatalogoInventarioInicial(string sucursal, string empleado,string sistema)
        {
            try
            {
                db.cargarProductosII(1,sucursal,empleado,sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool actualizarItemII(int mov, string codigo, double unidades, decimal costo, string suc, string emp, string sistema)
        {
            try
            {
                db.updateItemII(1,mov,codigo,unidades,costo,suc,emp,sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
