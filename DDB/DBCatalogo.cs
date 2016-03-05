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

        public DataTable showCategorias()
        {
            // Bien... Tenemos que crear un adaptador para volcar los datos de la BD en un objeto DataSet
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_categorias;";
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
                MessageBox.Show("ERROR AL CONSULTAR CATALOGO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }








        public DataTable showCatalogo(string categoria)
        {
            // Bien... Tenemos que crear un adaptador para volcar los datos de la BD en un objeto DataSet
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_catalogo WHERE CATEGORIA = @cat";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                cat.Value = categoria;

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





        public DataTable getTipoInv(string categoria)
        {
            // Bien... Tenemos que crear un adaptador para volcar los datos de la BD en un objeto DataSet
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_TIPO_INV";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                cat.Value = categoria;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show("ERROR AL CONSULTAR TIPOS DE INVENTARIOS", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getMarcaInv(string categoria)
        {
            // Bien... Tenemos que crear un adaptador para volcar los datos de la BD en un objeto DataSet
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_MARCA_INV";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                cat.Value = categoria;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show("ERROR AL CONSULTAR TIPOS DE INVENTARIOS", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





    }
}
