using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDB
{
    using MODELO;
    using System.Data;
    using MySql.Data.MySqlClient;




    public class DBCatalogo
    {
        private DBConexion conn;

        public DBCatalogo()
        {
            conn = DBConexion.Instance();
        }



        // FUNCIONES CRUD
        public bool insert(Catalogo item)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_CATALOGO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 20);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter categoria = cmd.Parameters.Add("cat", MySqlDbType.VarChar,50);
                categoria.Direction = ParameterDirection.Input;
                MySqlParameter unidad = cmd.Parameters.Add("unidad", MySqlDbType.VarChar, 15);
                unidad.Direction = ParameterDirection.Input;

                codigo.Value = item.COD_ITEM;
                categoria.Value = item.CATEGORIA.ToString();
                unidad.Value = item.UNIDAD_MEDIDA.ToString();

                cmd.ExecuteNonQuery();
                MessageBox.Show("ITEM CATALOGO REGISTRADO ", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(null, e.Message, "ERROR AL REGISTRAR PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }







        public bool changeID(string oldCodigo, string newCodigo)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_CHANGE_CODIGO_CATALOGO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigoOld = cmd.Parameters.Add("OLDCODIGO", MySqlDbType.VarChar, 20);
                codigoOld.Direction = ParameterDirection.Input;
                MySqlParameter codigoNew = cmd.Parameters.Add("NEWCODIGO", MySqlDbType.VarChar, 20);
                codigoNew.Direction = ParameterDirection.Input;
                
               
                codigoOld.Value = oldCodigo;
                codigoNew.Value = newCodigo;
                cmd.ExecuteNonQuery();
                MessageBox.Show("ITEM CATALOGO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL CAMBIAR EL CODIGO DEL PRODUCTO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool delete(Catalogo item)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_CATALOGO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 20);
                codigo.Direction = ParameterDirection.Input;

                codigo.Value = item.COD_ITEM;
                cmd.ExecuteNonQuery();
                MessageBox.Show("ITEM CATALOGO ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }








        public DataTable showCatalogo(eCategoria categoria)
        {
            // Bien... Tenemos que crear un adaptador para volcar los datos de la BD en un objeto DataSet
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_SHOW_CATALOGO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                cat.Value = categoria.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL CONSULTAR CATALOGO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }







    }
}
