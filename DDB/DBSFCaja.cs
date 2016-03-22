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

    public class DBSFCaja
    {
        private DBConexion conn;

        public DBSFCaja()
        {
            conn = DBConexion.Instance();
        }

        //FUNCIONES CRUD

        public bool insert(SFCaja sfc, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_SFC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_sfc = cmd.Parameters.Add("suc_sfc", MySqlDbType.VarChar, 2);
                suc_sfc.Direction = ParameterDirection.Input;
                MySqlParameter fecha_sfc = cmd.Parameters.Add("fecha_sfc", MySqlDbType.Date);
                fecha_sfc.Direction = ParameterDirection.Input;
                MySqlParameter tipo_sfc = cmd.Parameters.Add("tipo_sfc", MySqlDbType.Int32);
                tipo_sfc.Direction = ParameterDirection.Input;
                MySqlParameter doc_sfc = cmd.Parameters.Add("doc_sfc", MySqlDbType.VarChar, 20);
                doc_sfc.Direction = ParameterDirection.Input;
                MySqlParameter descrip_sfc = cmd.Parameters.Add("descrip_sfc", MySqlDbType.VarChar, 255);
                descrip_sfc.Direction = ParameterDirection.Input;
                MySqlParameter total_sfc = cmd.Parameters.Add("total_sfc", MySqlDbType.Decimal);
                total_sfc.Direction = ParameterDirection.Input;
                MySqlParameter nota_sfc = cmd.Parameters.Add("nota_sfc", MySqlDbType.VarChar, 100);
                nota_sfc.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_sfc.Value = sfc.COD_SUC;
                fecha_sfc.Value = sfc.FECHA.Date;
                tipo_sfc.Value = (int)sfc.TIPO;
                doc_sfc.Value = sfc.DOCUMENTO;
                descrip_sfc.Value = sfc.DESCRIPCION;
                total_sfc.Value = sfc.TOTAL;
                nota_sfc.Value = sfc.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show(sfc.TIPO.ToString() +" DE CAJA REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR " + sfc.TIPO.ToString() + " DE CAJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(SFCaja sfc, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_SFC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idsfc = cmd.Parameters.Add("idsfc", MySqlDbType.Int32);
                idsfc.Direction = ParameterDirection.Input;
                MySqlParameter suc_sfc = cmd.Parameters.Add("suc_sfc", MySqlDbType.VarChar, 2);
                suc_sfc.Direction = ParameterDirection.Input;
                MySqlParameter fecha_sfc = cmd.Parameters.Add("fecha_sfc", MySqlDbType.Date);
                fecha_sfc.Direction = ParameterDirection.Input;
                MySqlParameter tipo_sfc = cmd.Parameters.Add("tipo_sfc", MySqlDbType.Int32);
                tipo_sfc.Direction = ParameterDirection.Input;
                MySqlParameter doc_sfc = cmd.Parameters.Add("doc_sfc", MySqlDbType.VarChar, 20);
                doc_sfc.Direction = ParameterDirection.Input;
                MySqlParameter descrip_sfc = cmd.Parameters.Add("descrip_sfc", MySqlDbType.VarChar, 255);
                descrip_sfc.Direction = ParameterDirection.Input;
                MySqlParameter total_sfc = cmd.Parameters.Add("total_sfc", MySqlDbType.Decimal);
                total_sfc.Direction = ParameterDirection.Input;
                MySqlParameter nota_sfc = cmd.Parameters.Add("nota_sfc", MySqlDbType.VarChar, 100);
                nota_sfc.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idsfc.Value = sfc.ID_SFC;
                suc_sfc.Value = sfc.COD_SUC;
                fecha_sfc.Value = sfc.FECHA.Date;
                tipo_sfc.Value = (int)sfc.TIPO;
                doc_sfc.Value = sfc.DOCUMENTO;
                descrip_sfc.Value = sfc.DESCRIPCION;
                total_sfc.Value = sfc.TOTAL;
                nota_sfc.Value = sfc.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show(sfc.TIPO.ToString()+" DE CAJA ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR "+sfc.TIPO.ToString()+" DE CAJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool delete(SFCaja sfc, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_SFC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idsfc = cmd.Parameters.Add("idsfc", MySqlDbType.Int32);
                idsfc.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idsfc.Value = sfc.ID_SFC;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show(sfc.TIPO.ToString()+" DE CAJA ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR "+sfc.TIPO.ToString()+" DE CAJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public DataTable getSFCByAnio(int anioSF)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_sfc WHERE YEAR(FECHA) = @anio ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.Int32);
                anio.Direction = ParameterDirection.Input;

                anio.Value = anioSF;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR SOBRANTES o FALTANTES DE CAJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }
    }
}
