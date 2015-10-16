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

    public class VentaController
    {
        private DBVenta db;

        public VentaController()
        {
            db = new DBVenta();
        }




        public DataTable GET_ITEMS_VENTA(Venta venta)
        {
            return db.getItemsVenta(venta.ID_VENTA);
        }




        public bool isCancelada(Venta venta)
        {
            try
            {
                return db.isCancelada(venta.ID_VENTA); ;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool registrarVentaPRENDASAL(Venta venta, string sucursal, string empleado, string sistema)
        {
            try
            {
                venta.ESTADO = eEstadoVenta.PREINGRESADA;
                venta.INIT_BALANCE = false;
                db.insertPRENDASAL(venta, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool editarVentaPRENDASAL(Venta venta, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.updatePRENDASAL(venta, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool eliminarVentaPRENDASAL(Venta venta, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.deletePRENDASAL(venta, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        

        public Venta findByVentaPRENDASAL(DateTime? fecha,eTipoDocVenta tipo, string documento)
        {
            Venta v = null;
            DataTable dt = db.findByVentaPRENDASAL(fecha,tipo,documento);
            if (dt.Rows.Count > 0)
            {
                v = new Venta();
                v.ID_VENTA = dt.Rows[0].Field<int>("ID_VENTA");
                v.TRANSACCION = dt.Rows[0].Field<string>("COD_TRANS");
                v.COD_SUC = dt.Rows[0].Field<string>("COD_SUC");
                v.FECHA = dt.Rows[0].Field<DateTime>("FECHA");
                v.TIPO_DOC = (eTipoDocVenta)dt.Rows[0].Field<int>("TIPO_DOC");
                v.DOCUMENTO = dt.Rows[0].Field<string>("DOCUMENTO");
                v.COD_CLIENTE = dt.Rows[0].Field<string>("COD_CLIENTE");
                v.CLIENTE = new Cliente();
                v.CLIENTE.COD_CLIENTE = v.COD_CLIENTE;
                v.CLIENTE.CLIENTE = dt.Rows[0].Field<string>("CLIENTE");
                v.CLIENTE.DUI = dt.Rows[0].Field<string>("DUI");
                v.CLIENTE.LICENCIA = dt.Rows[0].Field<string>("LICENCIA");
                v.CLIENTE.PASAPORTE = dt.Rows[0].Field<string>("PASAPORTE");
                v.CLIENTE.CARNET = dt.Rows[0].Field<string>("CARNET");
                v.CLIENTE.EXT = dt.Rows[0].Field<string>("EXP");
                v.CLIENTE.TEL = dt.Rows[0].Field<string>("TEL");
                v.CLIENTE.EDAD = dt.Rows[0].Field<Int64?>("EDAD");
                v.CLIENTE.DOMICILIO = dt.Rows[0].Field<string>("DOMICILIO");
                v.CLIENTE.DIRECCION = dt.Rows[0].Field<string>("DIRECCION_CLI");
                v.SUMAS = dt.Rows[0].Field<decimal>("SUMAS");
                v.DESCUENTO = dt.Rows[0].Field<decimal>("DESCUENTO");
                v.TOTAL = dt.Rows[0].Field<decimal>("TOTAL");
                v.NAT_VENTA = (eNaturalezaVenta)dt.Rows[0].Field<int>("NAT_VENTA");
                v.NOTA = dt.Rows[0].Field<string>("NOTA");
                v.ESTADO = (eEstadoVenta)dt.Rows[0].Field<int>("ESTADO");
                v.NIVEL = (eNIVEL)dt.Rows[0].Field<int>("NIVEL");
                v.INIT_BALANCE = dt.Rows[0].Field<bool>("INIT_BALANCE");

            }
            return v;
        }


    }
    
}
