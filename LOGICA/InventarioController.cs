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

    public class InventarioController
    {
        private DBInventario db;

        public InventarioController()
        {
            db = new DBInventario();
        }


        public DataTable EXISTENCIAS_PRENDASAL(string sucursal,string categoria,string articulo)
        {
            return db.getExistenciasPRENDASAL(sucursal,categoria,articulo);
        }

        public DataTable EXISTENCIAS_BY_CODIGO_PRENDASAL(string codigo)
        {
            return db.getExistenciasByCodigoPRENDASAL(codigo);
        }

        public DataTable EXISTENCIAS_BY_SUCURSAL_PRENDASAL(string sucursal)
        {
            return db.getExistenciasBySucPRENDASAL(sucursal);
        }

        public DataTable EXISTENCIAS_BY_VENTA_PRENDASAL(string sucursal)
        {
            return db.getExistenciasByVentaPRENDASAL(sucursal);
        }





        public DataTable CUSTODIA_PRENDASAL(string sucursal, string categoria, string articulo)
        {
            return db.getArticulosCustodiaPRENDASAL(sucursal, categoria, articulo);
        }


        public DataTable CUSTODIA_BY_CODIGO_PRENDASAL(string codigo)
        {
            return db.getArticulosCustodiaByCodigoPRENDASAL(codigo);
        }


        public DataTable CUSTODIA_BY_SUCURSAL_PRENDASAL(string sucursal)
        {
            return db.getArticulosCustodiaBySucPRENDASAL(sucursal);
        }






        public DataTable GET_ITEMS_TRASLADO(Traslado traslado)
        {
            return db.getItemsTraslado(traslado);
        }


        public Traslado findCustodiaValoresByDocPRENDASAL(string documento)
        {
            Traslado t = null;
            DataTable dt = db.findTrasladoByDocPRENDASAL(eTipoTraslado.MOV_CUSTODIA,eTipoDocTraslado.ENVIO,documento);
            if (dt.Rows.Count > 0)
            {
                t = new Traslado();
                t.ID_TRASLADO = dt.Rows[0].Field<int>("ID_TRASLADO");
                t.FECHA = dt.Rows[0].Field<DateTime>("FECHA_TRASLADO");
                t.TIPO_DOC = (eTipoDocTraslado)dt.Rows[0].Field<int>("TIPO_DOC");
                t.DOCUMENTO = dt.Rows[0].Field<string>("DOCUMENTO");
                t.TIPO = (eTipoTraslado)dt.Rows[0].Field<int>("TIPO_TRASLADO");
                t.SUC_ORG = dt.Rows[0].Field<string>("SUC_ORG");
                t.SUC_DEST = dt.Rows[0].Field<string>("SUC_DEST");
                t.ENVIA = dt.Rows[0].Field<string>("ENVIA");
                t.TRASLADA = dt.Rows[0].Field<string>("TRASLADA");
                t.RECIBE = dt.Rows[0].Field<string>("RECIBE");
                t.RECIBIDO = dt.Rows[0].Field<bool>("RECIBIDO");
                t.NOTA = dt.Rows[0].Field<string>("NOTA");
            }
            return t;
        }

        public string NEXT_CUSTODIA_VALORES(string sucursal)
        {
            return db.nextCustodiaValoresPRENDASAL(sucursal);
        }



        public bool REGISTRAR_CUSTODIA_PRENDASAL(Traslado custodia, string sucursal, string empleado, string sistema)
        {
            try
            {
                custodia.RECIBIDO = false;
                custodia.RECIBE = null;
                custodia.TIPO = eTipoTraslado.MOV_CUSTODIA;
                db.registrarTrasladoPRENDASAL(custodia, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ELIMINAR_CUSTODIA_PRENDASAL(Traslado custodia, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.eliminarTrasladoPRENDASAL(custodia, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }







        public Traslado findRemisionByDocPRENDASAL(string documento)
        {
            Traslado t = null;
            DataTable dt = db.findTrasladoByDocPRENDASAL(eTipoTraslado.MOV_INVENTARIO, eTipoDocTraslado.REMISION, documento);
            if (dt.Rows.Count > 0)
            {
                t = new Traslado();
                t.ID_TRASLADO = dt.Rows[0].Field<int>("ID_TRASLADO");
                t.FECHA = dt.Rows[0].Field<DateTime>("FECHA_TRASLADO");
                t.TIPO_DOC = (eTipoDocTraslado)dt.Rows[0].Field<int>("TIPO_DOC");
                t.DOCUMENTO = dt.Rows[0].Field<string>("DOCUMENTO");
                t.TIPO = (eTipoTraslado)dt.Rows[0].Field<int>("TIPO_TRASLADO");
                t.SUC_ORG = dt.Rows[0].Field<string>("SUC_ORG");
                t.SUC_DEST = dt.Rows[0].Field<string>("SUC_DEST");
                t.ENVIA = dt.Rows[0].Field<string>("ENVIA");
                t.TRASLADA = dt.Rows[0].Field<string>("TRASLADA");
                t.RECIBE = dt.Rows[0].Field<string>("RECIBE");
                t.RECIBIDO = dt.Rows[0].Field<bool>("RECIBIDO");
                t.NOTA = dt.Rows[0].Field<string>("NOTA");
            }
            return t;
        }

        public string NEXT_NOTA_REMISION(string sucursal)
        {
            return db.nextNotaRemisionPRENDASAL(sucursal);
        }



        public bool REGISTRAR_REMISION_PRENDASAL(Traslado custodia, string sucursal, string empleado, string sistema)
        {
            try
            {
                custodia.RECIBIDO = false;
                custodia.RECIBE = null;
                custodia.TIPO = eTipoTraslado.MOV_INVENTARIO;
                db.registrarTrasladoPRENDASAL(custodia, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool ELIMINAR_REMISION_PRENDASAL(Traslado custodia, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.eliminarTrasladoPRENDASAL(custodia, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }






        public Traslado findRecibirTrasladoByDocPRENDASAL(eTipoTraslado tipo,eTipoDocTraslado tipodoc, string documento,string sucursal)
        {
            Traslado t = null;
            DataTable dt = db.findRecibirTrasladoByDocPRENDASAL(tipo,tipodoc,documento,sucursal);
            if (dt.Rows.Count > 0)
            {
                t = new Traslado();
                t.ID_TRASLADO = dt.Rows[0].Field<int>("ID_TRASLADO");
                t.FECHA = dt.Rows[0].Field<DateTime>("FECHA_TRASLADO");
                t.TIPO_DOC = (eTipoDocTraslado)dt.Rows[0].Field<int>("TIPO_DOC");
                t.DOCUMENTO = dt.Rows[0].Field<string>("DOCUMENTO");
                t.TIPO = (eTipoTraslado)dt.Rows[0].Field<int>("TIPO_TRASLADO");
                t.SUC_ORG = dt.Rows[0].Field<string>("SUC_ORG");
                t.SUC_DEST = dt.Rows[0].Field<string>("SUC_DEST");
                t.ENVIA = dt.Rows[0].Field<string>("ENVIA");
                t.TRASLADA = dt.Rows[0].Field<string>("TRASLADA");
                t.RECIBE = dt.Rows[0].Field<string>("RECIBE");
                t.RECIBIDO = dt.Rows[0].Field<bool>("RECIBIDO");
                t.NOTA = dt.Rows[0].Field<string>("NOTA");
            }
            return t;
        }




        public bool RECIBIR_TRASLADO_PRENDASAL(Traslado traslado, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.recibirTrasladoPRENDASAL(traslado, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }














        public DataTable INVENTARIO_INICIAL_PRENDASAL()
        {
            return db.getInventarioInicialPRENDASAL();
        }




        public bool registrarInvInicialPRENDASAL(Inventario inv, string sucursal, string empleado, string sistema)
        {
            try
            {
                inv.DISPONIBLE = true;
                inv.INIT_BALANCE = true;
                db.insertInvInicialPRENDASAL(inv, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool editarInvInicialPRENDASAL(Inventario inv, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.updateInvInicialPRENDASAL(inv, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }




        public bool eliminarInvInicialPrestamoPRENDASAL(Inventario inv, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.deleteInvInicialPRENDASAL(inv, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }




        public bool editarArticuloVentaPRENDASAL(Inventario inv, string sucursal, string empleado, string sistema)
        {
            try
            {
                db.updateArticuloVentaPRENDASAL(inv, sucursal, empleado, sistema);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
