using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB
{

    using MODELO;
    using System.Data;
    using MySql.Data.MySqlClient;
    using System.Windows.Forms;

    public class DBInventario
    {
        private DBConexion conn;

        public DBInventario()
        {
            conn = DBConexion.Instance();
        }



        public DataTable getExistenciasPRENDASAL(string sucursal,string categoria,string articulo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_existencias WHERE CATEGORIA != 'X' ";
                if (sucursal != "00")
                {
                    sql = sql + "AND COD_SUC = @suc ";
                }
                if (categoria != "TODAS")
                {
                    sql = sql + "AND CATEGORIA = @cat ";
                }
                if (articulo != "TODAS")
                {
                    sql = sql + "AND ARTICULO = @item ";
                }
                sql = sql + "ORDER BY CODIGO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;
                MySqlParameter item = cmd.Parameters.Add("item", MySqlDbType.VarChar, 100);
                item.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                cat.Value = categoria;
                item.Value = articulo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getExistenciasByCodigoPRENDASAL(string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_existencias WHERE CATEGORIA != 'X' AND CODIGO LIKE @contrato ORDER BY CODIGO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter contrato = cmd.Parameters.Add("contrato", MySqlDbType.VarChar,25);
                contrato.Direction = ParameterDirection.Input;
                
                contrato.Value = codigo + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






        public DataTable getExistenciasBySucPRENDASAL(string suc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_existencias WHERE CATEGORIA != 'X' AND COD_SUC = @sucursal ORDER BY CODIGO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                sucursal.Value = suc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataTable getExistenciasByVentaPRENDASAL(string suc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_existencias WHERE CATEGORIA != 'ORO' AND COD_SUC = @sucursal ORDER BY CODIGO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                sucursal.Value = suc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }









        public DataTable getArticulosCustodiaPRENDASAL(string sucursal, string categoria, string articulo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_resguardo WHERE 1=1 ";
                if (sucursal != "00")
                {
                    sql = sql + "AND COD_SUC = @suc ";
                }
                if (categoria != "TODAS")
                {
                    sql = sql + "AND CATEGORIA = @cat ";
                }
                if (articulo != "TODAS")
                {
                    sql = sql + "AND ARTICULO = @item ";
                }
                sql = sql + "ORDER BY CATEGORIA,CODIGO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 2);
                cat.Direction = ParameterDirection.Input;
                MySqlParameter item = cmd.Parameters.Add("item", MySqlDbType.VarChar, 2);
                item.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                cat.Value = categoria;
                item.Value = articulo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable getArticulosCustodiaByCodigoPRENDASAL(string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_resguardo WHERE CONTRATO LIKE @contrato ORDER BY CONTRATO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter contrato = cmd.Parameters.Add("contrato", MySqlDbType.VarChar, 25);
                contrato.Direction = ParameterDirection.Input;

                contrato.Value = codigo + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }







        public DataTable getArticulosCustodiaBySucPRENDASAL(string suc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_resguardo WHERE COD_SUC = @sucursal ORDER BY CONTRATO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                sucursal.Value = suc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable getItemsTraslado(Traslado traslado)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_SHOW_DETALLE_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;
                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;

                idtraslado.Value = traslado.ID_TRASLADO;
                tipo.Value = (int) traslado.TIPO;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR DETALLE DE TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public string nextCustodiaValoresPRENDASAL(string suc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_CUSTODIA_VALORES(@tipodoc,@sucursal)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar,2);
                sucursal.Direction = ParameterDirection.Input;

                tipodoc.Value = eTipoDocTraslado.ENVIO;
                sucursal.Value = suc;
                reader = (string)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = null; }
            return reader;
        }




        public DataTable findTrasladoByDocPRENDASAL(eTipoTraslado tipoTraslado, eTipoDocTraslado tipodocumento, string documento)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddicark.traslado WHERE TIPO_TRASLADO = @tipo AND TIPO_DOC = @tipodoc AND DOCUMENTO = @doc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar,20);
                doc.Direction = ParameterDirection.Input;


                tipo.Value = (int) tipoTraslado;
                tipodoc.Value = (int)tipodocumento;
                doc.Value = documento;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL BUSCAR TRASLADO # " + documento + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public void registrarTrasladoPRENDASAL(Traslado traslado, string suc, string emp, string sistema)
        {
            try
            {
                string items = "";
                foreach (DataRow row in traslado.ARTICULOS)
                {
                    items = items + row.Field<int>("ID_MOV") + "," + row.Field<string>("CODIGO") + ";";
                }
                string sql = "prendasal.SP_REGISTRAR_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;
                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter r_envio = cmd.Parameters.Add("r_envio", MySqlDbType.VarChar, 50);
                r_envio.Direction = ParameterDirection.Input;
                MySqlParameter r_traslada = cmd.Parameters.Add("r_traslada", MySqlDbType.VarChar, 50);
                r_traslada.Direction = ParameterDirection.Input;
                MySqlParameter suc_destino = cmd.Parameters.Add("suc_destino", MySqlDbType.VarChar, 2);
                suc_destino.Direction = ParameterDirection.Input;
                MySqlParameter ok = cmd.Parameters.Add("ok", MySqlDbType.Bit);
                ok.Direction = ParameterDirection.Input;
                MySqlParameter observacion = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                observacion.Direction = ParameterDirection.Input;
                MySqlParameter itemsC = cmd.Parameters.Add("items", MySqlDbType.LongText);
                itemsC.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                tipodoc.Value =(int) traslado.TIPO_DOC;
                doc.Value = traslado.DOCUMENTO;
                tipo.Value = (int)traslado.TIPO;
                fecha.Value = traslado.FECHA.Date.ToString("yyyy-MM-dd");
                r_envio.Value = traslado.ENVIA;
                r_traslada.Value = traslado.TRASLADA;
                suc_destino.Value = traslado.SUC_DEST;
                ok.Value = traslado.RECIBIDO;
                observacion.Value = traslado.NOTA;
                itemsC.Value = items;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CUSTODIA DE VALORES REGISTRADO CORRECTAMENTE" , "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR TRASLADO DE BIENES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




        public void eliminarTrasladoPRENDASAL(Traslado traslado, string suc, string emp, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_ELIMINAR_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                idtraslado.Value = traslado.ID_TRASLADO;
                notaCambio.Value = traslado.NOTA_CAMBIO;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TRASLADO DE " + traslado.TIPO_DOC.ToString().Replace('_', ' ') + " #" + traslado.DOCUMENTO + " ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR TRASLADO \n" + e.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public string nextNotaRemisionPRENDASAL(string suc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_NOTA_REMISION(@tipodoc,@sucursal)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                tipodoc.Value = eTipoDocTraslado.REMISION;
                sucursal.Value = suc;
                reader = (string)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = null; }
            return reader;
        }





        public DataTable findRecibirTrasladoByDocPRENDASAL(eTipoTraslado tipoTraslado, eTipoDocTraslado tipodocumento, string documento , string sucursal)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddicark.traslado WHERE TIPO_TRASLADO = @tipo AND TIPO_DOC = @tipodoc AND DOCUMENTO = @doc AND SUC_DEST = @suc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;


                tipo.Value = (int)tipoTraslado;
                tipodoc.Value = (int)tipodocumento;
                doc.Value = documento;
                suc.Value = sucursal;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL BUSCAR TRASLADO # " + documento + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public void recibirTrasladoPRENDASAL(Traslado traslado, string suc, string emp, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_RECIBIR_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;
                MySqlParameter r_recibe = cmd.Parameters.Add("r_recibe", MySqlDbType.VarChar, 50);
                r_recibe.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                idtraslado.Value = traslado.ID_TRASLADO;
                r_recibe.Value = traslado.RECIBE;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TRASLADO DE " + traslado.TIPO_DOC.ToString().Replace('_', ' ') + " #" + traslado.DOCUMENTO + " RECIBIDO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL RECIBIR TRASLADO \n" + e.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




















        public DataTable getInventarioInicialPRENDASAL()
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_inv_inicial;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR INVENTARIO INICIAL PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        // FUNCIONES CRUD
        public void insertInvInicialPRENDASAL(Inventario item, string suc, string emp ,string sys)
        {
            try
            {
                string sql = "prendasal.SP_REGISTRAR_INVENTARIO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter linea = cmd.Parameters.Add("linea", MySqlDbType.Int32);
                linea.Direction = ParameterDirection.Input;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 25);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter producto = cmd.Parameters.Add("articulo", MySqlDbType.VarChar, 15);
                producto.Direction = ParameterDirection.Input;
                MySqlParameter descripcion = cmd.Parameters.Add("detalle", MySqlDbType.VarChar, 100);
                descripcion.Direction = ParameterDirection.Input;
                MySqlParameter cantidad = cmd.Parameters.Add("cantidad", MySqlDbType.Double);
                cantidad.Direction = ParameterDirection.Input;
                MySqlParameter costo = cmd.Parameters.Add("costo", MySqlDbType.Decimal);
                costo.Direction = ParameterDirection.Input;
                MySqlParameter precio = cmd.Parameters.Add("precio", MySqlDbType.Decimal);
                precio.Direction = ParameterDirection.Input;
                MySqlParameter init = cmd.Parameters.Add("init", MySqlDbType.Bit);
                init.Direction = ParameterDirection.Input;
                MySqlParameter disponible = cmd.Parameters.Add("ok", MySqlDbType.Bit);
                disponible.Direction = ParameterDirection.Input;
                MySqlParameter bodega = cmd.Parameters.Add("suc_bodega", MySqlDbType.VarChar, 2);
                bodega.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                
                codigo.Value = item.CODIGO;
                fecha.Value = item.FECHA;
                linea.Value = item.LINEA;
                producto.Value = item.ARTICULO;
                descripcion.Value = item.DESCRIPCION;
                cantidad.Value = item.CANTIDAD;
                costo.Value = item.COSTO;
                precio.Value = item.PRECIO;
                init.Value = item.INIT_BALANCE;
                disponible.Value = item.DISPONIBLE;
                bodega.Value = item.COD_SUC;


                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("ARTICULO LISTADO A INVENTARIO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL REGISTRAR PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




        public void updateInvInicialPRENDASAL(Inventario item, string suc, string emp ,string sys)
        {
            try
            {
                string sql = "prendasal.SP_EDITAR_INVENTARIO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("id", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter linea = cmd.Parameters.Add("linea", MySqlDbType.Int32);
                linea.Direction = ParameterDirection.Input;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 25);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter producto = cmd.Parameters.Add("articulo", MySqlDbType.VarChar, 15);
                producto.Direction = ParameterDirection.Input;
                MySqlParameter descripcion = cmd.Parameters.Add("detalle", MySqlDbType.VarChar, 100);
                descripcion.Direction = ParameterDirection.Input;
                MySqlParameter cantidad = cmd.Parameters.Add("cantidad", MySqlDbType.Double);
                cantidad.Direction = ParameterDirection.Input;
                MySqlParameter costo = cmd.Parameters.Add("costo", MySqlDbType.Decimal);
                costo.Direction = ParameterDirection.Input;
                MySqlParameter precio = cmd.Parameters.Add("precio", MySqlDbType.Decimal);
                precio.Direction = ParameterDirection.Input;
                MySqlParameter init = cmd.Parameters.Add("init", MySqlDbType.Bit);
                init.Direction = ParameterDirection.Input;
                MySqlParameter disponible = cmd.Parameters.Add("ok", MySqlDbType.Bit);
                disponible.Direction = ParameterDirection.Input;
                MySqlParameter bodega = cmd.Parameters.Add("suc_bodega", MySqlDbType.VarChar, 2);
                bodega.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                id.Value = item.ID_MOV;
                codigo.Value = item.CODIGO;
                fecha.Value = item.FECHA;
                linea.Value = item.LINEA;
                producto.Value = item.ARTICULO;
                descripcion.Value = item.DESCRIPCION;
                cantidad.Value = item.CANTIDAD;
                costo.Value = item.COSTO;
                precio.Value = item.PRECIO;
                init.Value = item.INIT_BALANCE;
                disponible.Value = item.DISPONIBLE;
                bodega.Value = item.COD_SUC;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ARTICULO DE INVENTARIO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }





        public void deleteInvInicialPRENDASAL(Inventario item, string suc, string emp,string sys)
        {
            try
            {
                string sql = "prendasal.SP_ELIMINAR_INVENTARIO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("id", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                id.Value = item.ID_MOV;
                
                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ARTICULO ELIMINADO DE INVENTARIO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }





        public void updateArticuloVentaPRENDASAL(Inventario item, string suc, string emp, string sys)
        {
            try
            {
                string sql = "prendasal.SP_EDITAR_ARTICULO_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("id", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                MySqlParameter descripcion = cmd.Parameters.Add("detalle", MySqlDbType.VarChar, 100);
                descripcion.Direction = ParameterDirection.Input;
                MySqlParameter precio = cmd.Parameters.Add("precioInv", MySqlDbType.Decimal);
                precio.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                id.Value = item.ID_MOV;
                descripcion.Value = item.DESCRIPCION;
                precio.Value = item.PRECIO;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ARTICULO EN EXISTENCIA ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



    }

}
