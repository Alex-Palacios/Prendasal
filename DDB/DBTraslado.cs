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

    public class DBTraslado
    {
        private DBConexion conn;

        public DBTraslado()
        {
            conn = DBConexion.Instance();
        }


        //FUNCIONES CRUD 
        private string buildItemsTraslado(Traslado traslado)
        {
            string items = "";
            foreach (DataRow row in traslado.DETALLE_TRASLADO.Rows)
            {
                items = items + row.Field<int>("TIPO") + ">"
                            + row.Field<string>("CODIGO") + ">"
                            + row.Field<decimal>("CANTIDAD") + ">"
                            + row.Field<string>("COD_ITEM") + ">"
                            + row.Field<string>("DESCRIPCION") + ">"
                            + row.Field<decimal>("PRECIO") + ">"
                            + row.Field<bool>("RECIBIDO") + "&";
            }
            return items;
        }








        public bool insert(Traslado traslado, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter fecha_traslado = cmd.Parameters.Add("fecha_traslado", MySqlDbType.Date);
                fecha_traslado.Direction = ParameterDirection.Input;
                MySqlParameter tipo_traslado = cmd.Parameters.Add("tipo_traslado", MySqlDbType.Int32);
                tipo_traslado.Direction = ParameterDirection.Input;
                MySqlParameter doc_traslado = cmd.Parameters.Add("doc_traslado", MySqlDbType.VarChar, 20);
                doc_traslado.Direction = ParameterDirection.Input;
                MySqlParameter envia_traslado = cmd.Parameters.Add("envia_traslado", MySqlDbType.VarChar, 2);
                envia_traslado.Direction = ParameterDirection.Input;
                MySqlParameter dest_traslado = cmd.Parameters.Add("dest_traslado", MySqlDbType.VarChar, 2);
                dest_traslado.Direction = ParameterDirection.Input;
                MySqlParameter responsable_envio = cmd.Parameters.Add("responsable_envio", MySqlDbType.VarChar, 100);
                responsable_envio.Direction = ParameterDirection.Input;
                MySqlParameter responsable_traslado = cmd.Parameters.Add("responsable_traslado", MySqlDbType.VarChar, 100);
                responsable_traslado.Direction = ParameterDirection.Input;
                MySqlParameter nota_traslado = cmd.Parameters.Add("nota_traslado", MySqlDbType.VarChar, 100);
                nota_traslado.Direction = ParameterDirection.Input;
                MySqlParameter items_traslado = cmd.Parameters.Add("items_traslado", MySqlDbType.LongText);
                items_traslado.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;


                fecha_traslado.Value = traslado.FECHA.Date;
                tipo_traslado.Value = (int)traslado.TIPO;
                doc_traslado.Value = traslado.DOCUMENTO;
                envia_traslado.Value = traslado.SUC_ENVIA;
                dest_traslado.Value = traslado.SUC_DEST;
                responsable_envio.Value = traslado.ENVIA;
                responsable_traslado.Value = traslado.TRASLADA;
                nota_traslado.Value = traslado.NOTA;

                items_traslado.Value = buildItemsTraslado(traslado);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TRASLADO REGISTRADO CORRECTAMENTE" , "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        public bool update(Traslado traslado, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;
                MySqlParameter fecha_traslado = cmd.Parameters.Add("fecha_traslado", MySqlDbType.Date);
                fecha_traslado.Direction = ParameterDirection.Input;
                MySqlParameter tipo_traslado = cmd.Parameters.Add("tipo_traslado", MySqlDbType.Int32);
                tipo_traslado.Direction = ParameterDirection.Input;
                MySqlParameter doc_traslado = cmd.Parameters.Add("doc_traslado", MySqlDbType.VarChar, 20);
                doc_traslado.Direction = ParameterDirection.Input;
                MySqlParameter envia_traslado = cmd.Parameters.Add("envia_traslado", MySqlDbType.VarChar, 2);
                envia_traslado.Direction = ParameterDirection.Input;
                MySqlParameter dest_traslado = cmd.Parameters.Add("dest_traslado", MySqlDbType.VarChar, 2);
                dest_traslado.Direction = ParameterDirection.Input;
                MySqlParameter responsable_envio = cmd.Parameters.Add("responsable_envio", MySqlDbType.VarChar, 100);
                responsable_envio.Direction = ParameterDirection.Input;
                MySqlParameter responsable_traslado = cmd.Parameters.Add("responsable_traslado", MySqlDbType.VarChar, 100);
                responsable_traslado.Direction = ParameterDirection.Input;
                MySqlParameter nota_traslado = cmd.Parameters.Add("nota_traslado", MySqlDbType.VarChar, 100);
                nota_traslado.Direction = ParameterDirection.Input;
                MySqlParameter items_traslado = cmd.Parameters.Add("items_traslado", MySqlDbType.LongText);
                items_traslado.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idtraslado.Value = traslado.ID_TRASLADO;
                fecha_traslado.Value = traslado.FECHA.Date;
                tipo_traslado.Value = (int)traslado.TIPO;
                doc_traslado.Value = traslado.DOCUMENTO;
                envia_traslado.Value = traslado.SUC_ENVIA;
                dest_traslado.Value = traslado.SUC_DEST;
                responsable_envio.Value = traslado.ENVIA;
                responsable_traslado.Value = traslado.TRASLADA;
                nota_traslado.Value = traslado.NOTA;

                items_traslado.Value = buildItemsTraslado(traslado);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TRASLADO ACTUALIZADO CORRECTAMENTE", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        public bool delete(Traslado traslado, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;
               
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idtraslado.Value = traslado.ID_TRASLADO;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TRASLADO ELIMINADO CORRECTAMENTE", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool recibir(Traslado traslado, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_RECIBIR_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;
                MySqlParameter responsable_recibe = cmd.Parameters.Add("responsable_recibe", MySqlDbType.VarChar, 100);
                responsable_recibe.Direction = ParameterDirection.Input;
                MySqlParameter nota_traslado = cmd.Parameters.Add("nota_traslado", MySqlDbType.VarChar, 100);
                nota_traslado.Direction = ParameterDirection.Input;
                MySqlParameter items_traslado = cmd.Parameters.Add("items_traslado", MySqlDbType.LongText);
                items_traslado.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;


                idtraslado.Value = traslado.ID_TRASLADO;
                responsable_recibe.Value = traslado.RECIBE;
                nota_traslado.Value = traslado.NOTA;

                items_traslado.Value = buildItemsTraslado(traslado);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TRASLADO RECIBIDO CORRECTAMENTE", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL RECIBIR TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public DataRow getTrasladoByDocTipoSucDEST(eTipoTraslado tipo,string documento, string destino)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_traslados WHERE DOCUMENTO = @doc AND TIPO = @tipodoc AND SUC_DEST = @dest;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter dest = cmd.Parameters.Add("dest", MySqlDbType.VarChar, 2);
                dest.Direction = ParameterDirection.Input;

                doc.Value = documento;
                tipodoc.Value = (int)tipo;
                dest.Value = destino;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL OBTENER TRASLADO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }





        public DataRow getTrasladoByDocTipoSucENVIA(eTipoTraslado tipo, string documento, string envia)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_traslados WHERE DOCUMENTO = @doc AND TIPO = @tipodoc AND SUC_ENVIA = @env;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter env = cmd.Parameters.Add("env", MySqlDbType.VarChar, 2);
                env.Direction = ParameterDirection.Input;

                doc.Value = documento;
                tipodoc.Value = (int)tipo;
                env.Value = envia;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL OBTENER TRASLADO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }








        public string nextNotaTraslado(eTipoTraslado tipoTraslado, string codsuc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_NOTA_TRASLADO(@tipo,@sucursal)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                tipo.Value = (int)tipoTraslado;
                sucursal.Value = codsuc;

                reader = (string)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = null; }
            return reader;
        }





        public DataTable getItemsTraslado(Traslado traslado)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql =  "prendasal.SP_GET_ITEMS_TRASLADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idtraslado = cmd.Parameters.Add("idtraslado", MySqlDbType.Int32);
                idtraslado.Direction = ParameterDirection.Input;

                idtraslado.Value = traslado.ID_TRASLADO;

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








        public DataTable getExistenciasTrasladoARTICULOS(string sucursal)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_EXISTENCIAS_CATEGORIA;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter suc_exis = cmd.Parameters.Add("suc_exis", MySqlDbType.VarChar, 2);
                suc_exis.Direction = ParameterDirection.Input;
                MySqlParameter cat_exis = cmd.Parameters.Add("cat_exis", MySqlDbType.VarChar, 50);
                cat_exis.Direction = ParameterDirection.Input;

                suc_exis.Value = sucursal;
                cat_exis.Value = "ARTICULO";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS DE ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getCustodiaBySuc(eTipoDetalleTraslado tipoT, string codsuc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_TRASLADO_CUSTODIA_VALORES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                tipo.Value = (int)tipoT;
                sucursal.Value = codsuc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR VALORES EN CUSTODIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datos;
        }




    }

}
