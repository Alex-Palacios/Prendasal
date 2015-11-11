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
            switch (traslado.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:
                    foreach (DataRow row in traslado.CUSTODIA.Rows)
                    {
                        items = items + row.Field<Int32>("ID_DET_PRESTAMO") + ">"
                                    + row.Field<string>("CODIGO") + "&";
                    }
                    break;
                case eTipoTraslado.NOTA_REMISION:
                    foreach (DataRow row in traslado.REMISION.Rows)
                    {
                        items = items + null + ">"
                                    + row.Field<string>("CODIGO") + "&";
                    }
                    break;
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




        public DataRow getTrasladoByDocTipo(string documento,eTipoTraslado tipo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_traslados WHERE DOCUMENTO = @doc AND TIPO = @tipodoc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;

                doc.Value = documento;
                tipodoc.Value = (int)tipo;

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
                string sql = string.Empty;
                switch (traslado.TIPO)
                {
                    case eTipoTraslado.CUSTODIA_VALORES:
                        sql = "prendasal.SP_GET_ITEMS_CUSTODIA";
                        break;
                    case eTipoTraslado.NOTA_REMISION:
                        sql = "prendasal.SP_GET_ITEMS_REMISION";
                        break;
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

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





    }

}
