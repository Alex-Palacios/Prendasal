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

    public class DBImages
    {
        private DBConexion conn;

        public DBImages()
        {
            conn = DBConexion.Instance();
        }


        // FUNCIONES CRUD
        public void insertImages(Images img,string empleado)
        {
            try
            {
                string sql = "prendasal.SP_INSERT_IMAGES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection); 
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter tipo = cmd.Parameters.Add("tipoImg", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter codigo = cmd.Parameters.Add("codImg", MySqlDbType.VarChar, 20);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter imagen = cmd.Parameters.Add("img", MySqlDbType.LongBlob);
                imagen.Direction = ParameterDirection.Input;

                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;

                tipo.Value = (int)img.TIPO;
                codigo.Value = img.CODIGO;
                imagen.Value = img.IMAGEN;

                emp.Value = empleado;

                cmd.ExecuteNonQuery();
                MessageBox.Show("IMAGEN GUARDADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL GUARDAR IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public void deleteImages(Images img,string empleado)
        {
            try
            {
                string sql = "prendasal.SP_DELETE_IMAGES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("idImg", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;

                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;


                id.Value = img.ID;

                emp.Value = empleado;

                cmd.ExecuteNonQuery();
                MessageBox.Show("IMAGEN ELIMINADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public DataTable getDocCliente(string cliente)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_SHOW_IMAGES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter tipo = cmd.Parameters.Add("tipoImg", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter codigo = cmd.Parameters.Add("codImg", MySqlDbType.VarChar, 20);
                codigo.Direction = ParameterDirection.Input;

                tipo.Value = eTipoImages.DOCUMENTO;
                codigo.Value = cliente;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR IMAGENES \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataTable getFotosArticulo(string inventario)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_SHOW_IMAGES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter tipo = cmd.Parameters.Add("tipoImg", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter codigo = cmd.Parameters.Add("codImg", MySqlDbType.VarChar, 20);
                codigo.Direction = ParameterDirection.Input;

                tipo.Value = eTipoImages.ARTICULO;
                codigo.Value = inventario;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR IMAGENES \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }

    }
}
