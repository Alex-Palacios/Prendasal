using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DDB
{
    using MODELO;

    public class DBPRENDASAL
    {
        private DBConexion conn;

        public DBPRENDASAL()
        {
            conn = DBConexion.Instance();
        }


        //PROCEDIMIENTOS

        public DataTable getDeptos()
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_GET_DEPTOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e) { }
            return datos;
        }



        public DataTable getMunicipios(string d)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_GET_MUNICIPIOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter depto = cmd.Parameters.Add("departamento", MySqlDbType.VarChar, 30);
                depto.Direction = ParameterDirection.Input;
                depto.Value = d;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e) { }
            return datos;
        }




        public DataTable getLOG(string sistema, string tabla, string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_GET_LOG;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;
                MySqlParameter tbl = cmd.Parameters.Add("tbl", MySqlDbType.VarChar, 50);
                tbl.Direction = ParameterDirection.Input;
                MySqlParameter cod = cmd.Parameters.Add("cod", MySqlDbType.VarChar, 50);
                cod.Direction = ParameterDirection.Input;

                sys.Value = sistema;
                tbl.Value = tabla;
                cod.Value = codigo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR EL LOG DE TRANSACCIONES \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        //FUNCIONES
        public DateTime date_system()
        {
            DateTime fecha = new DateTime();
            try
            {
                string sql = "SELECT ddicark.FN_GET_DATE_SYSTEM();";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                fecha = (DateTime)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            { MessageBox.Show("NO SE PUDO OBTENER FECHA DE SERVIDOR", "ERROR SERVER", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            return fecha;
        }



        public bool LOGIN(string sistema,string usuario, string password)
        {
            bool reader = false;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT ddicark.FN_LOGIN(@sys,@user,@pass)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;
                MySqlParameter user = cmd.Parameters.Add("user", MySqlDbType.VarChar, 15);
                user.Direction = ParameterDirection.Input;
                MySqlParameter pass = cmd.Parameters.Add("pass", MySqlDbType.VarChar, 32);
                pass.Direction = ParameterDirection.Input;

                user.Value = usuario;
                pass.Value = md5(password);
                sys.Value = sistema;

                reader = (bool)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                reader = false;
                MessageBox.Show(e.Message, "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return reader;
        }



        public static string md5(string password)
        {
            //Declaraciones
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //Conversion
            Byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));  //genero el hash a partir de la password original

            //return BitConverter.ToString(encodedBytes);      //esto, devuelve el hash con "-" cada 2 char
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), @"-", "");     //devuelve el hash continuo y en minuscula. (igual que en php)
        }




        //CONTROL DE PRECIOS

        public bool actualizarPrecios(eNIVEL nivel, DataGridViewRowCollection PRECIOS, DateTime fecha, string autorizo)
        {
            bool OK = true;
            string datos = "";
            try
            {
                foreach (DataGridViewRow row in PRECIOS)
                {
                    switch (nivel)
                    {
                        case eNIVEL.PRENDASAL:
                            datos = datos + row.Cells["KilatajeN"].Value.ToString() + ">" + Decimal.Parse(row.Cells["PrecioN"].Value.ToString()) +  "&";
                            break;
                        case eNIVEL.AMIGO:
                            datos = datos + row.Cells["KilatajeA"].Value.ToString() + ">" + Decimal.Parse(row.Cells["PrecioA"].Value.ToString()) + "&";
                            break;
                        case eNIVEL.VIP:
                            datos = datos + row.Cells["KilatajeV"].Value.ToString() + ">" + Decimal.Parse(row.Cells["PrecioV"].Value.ToString()) + "&";
                            break;
                        case eNIVEL.MAYOREO:
                            datos = datos + row.Cells["KilatajeM"].Value.ToString() + ">" + Decimal.Parse(row.Cells["PrecioM"].Value.ToString()) + "&";
                            break;
                    }

                }
                string sql = "prendasal.SP_SET_PRECIOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter n = cmd.Parameters.Add("nivelP", MySqlDbType.Int32);
                n.Direction = ParameterDirection.Input;
                MySqlParameter f = cmd.Parameters.Add("fechaP", MySqlDbType.Date);
                f.Direction = ParameterDirection.Input;
                MySqlParameter auto = cmd.Parameters.Add("autorizoP", MySqlDbType.VarChar, 15);
                auto.Direction = ParameterDirection.Input;
                MySqlParameter items = cmd.Parameters.Add("items", MySqlDbType.LongText);
                items.Direction = ParameterDirection.Input;

                n.Value = (int)nivel;
                f.Value = fecha.Date.ToString("yyyy-MM-dd"); ;
                auto.Value = autorizo.ToUpper();
                items.Value = datos;

                cmd.ExecuteNonQuery();
                MessageBox.Show("PRECIOS " + nivel.ToString() + " ACTUALIZADOS", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR PRECIOS " + nivel.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public DataTable getPrecios(eNIVEL nivel)
        {
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_PRECIOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter n = cmd.Parameters.Add("nivelP", MySqlDbType.Int32);
                n.Direction = ParameterDirection.Input;

                n.Value = (int)nivel;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LOS PRECIOS " + nivel.ToString(), "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        //CONTROL DE REGLAS DEL NEGOCIO

        public bool actualizarReglas(Reglas regla)
        {
            bool OK = true;
            try
            {

                string sql = "prendasal.SP_SET_REGLAS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter nivel = cmd.Parameters.Add("nivelR", MySqlDbType.Int32);
                nivel.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fechaR", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter auto = cmd.Parameters.Add("autorizoR", MySqlDbType.VarChar, 15);
                auto.Direction = ParameterDirection.Input;
                MySqlParameter t_mensual = cmd.Parameters.Add("t_mensual", MySqlDbType.Decimal);
                t_mensual.Direction = ParameterDirection.Input;
                MySqlParameter t_15 = cmd.Parameters.Add("t_15", MySqlDbType.Decimal);
                t_15.Direction = ParameterDirection.Input;
                MySqlParameter p_contrato = cmd.Parameters.Add("p_contrato", MySqlDbType.Int32);
                p_contrato.Direction = ParameterDirection.Input;
                MySqlParameter p_vencido = cmd.Parameters.Add("p_vencido", MySqlDbType.Int32);
                p_vencido.Direction = ParameterDirection.Input;
                MySqlParameter descuento_c = cmd.Parameters.Add("descuento_c", MySqlDbType.Decimal);
                descuento_c.Direction = ParameterDirection.Input;
                MySqlParameter descuento_i = cmd.Parameters.Add("descuento_i", MySqlDbType.Decimal);
                descuento_i.Direction = ParameterDirection.Input;
                MySqlParameter puntos_d = cmd.Parameters.Add("puntos_d", MySqlDbType.Int32);
                puntos_d.Direction = ParameterDirection.Input;
                MySqlParameter puntos_v = cmd.Parameters.Add("puntos_v", MySqlDbType.Decimal);
                puntos_v.Direction = ParameterDirection.Input;

                nivel.Value = (int)regla.NIVEL;
                fecha.Value = regla.FECHA.Date.ToString("yyyy-MM-dd"); ;
                auto.Value = regla.COD_EMPLEADO.ToUpper();
                t_mensual.Value = regla.TASA_MENSUAL;
                p_contrato.Value = regla.PLAZO_CONTRATO;
                p_vencido.Value = regla.PLAZO_VENCIDO;
                descuento_c.Value = regla.DESC_COMPRA;
                descuento_i.Value = regla.DESC_INTERES;
                puntos_d.Value = regla.PUNTOS_DOLAR;
                puntos_v.Value = regla.PUNTOS_VALOR;

                cmd.ExecuteNonQuery();
                MessageBox.Show("PARAMETROS DE NEGOCIO ACTUALIZADOS", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR PARAMETROS DE NEGOCIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public DataRow getReglas(eNIVEL nivel)
        {
            MySqlDataReader reader;
            // Creamos nuestro queridisimo DataSet
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "prendasal.SP_GET_REGLAS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter n = cmd.Parameters.Add("nivelR", MySqlDbType.Int32);
                n.Direction = ParameterDirection.Input;

                n.Value = (int)nivel;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LOS PARAMETROS PARA CLIENTE: " + nivel.ToString(), "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }


    }
}
