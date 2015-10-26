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

    public class DBGasto
    {
        private DBConexion conn;

        public DBGasto()
        {
            conn = DBConexion.Instance();
        }


        
        // FUNCIONES CRUD
        public bool insert(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_GASTO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_gasto = cmd.Parameters.Add("suc_gasto", MySqlDbType.VarChar, 2);
                suc_gasto.Direction = ParameterDirection.Input;
                MySqlParameter fecha_gasto = cmd.Parameters.Add("fecha_gasto", MySqlDbType.Date);
                fecha_gasto.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc_gasto = cmd.Parameters.Add("tipodoc_gasto", MySqlDbType.VarChar, 5);
                tipodoc_gasto.Direction = ParameterDirection.Input;
                MySqlParameter doc_gasto = cmd.Parameters.Add("doc_gasto", MySqlDbType.VarChar, 20);
                doc_gasto.Direction = ParameterDirection.Input;
                MySqlParameter descrip_gasto = cmd.Parameters.Add("descrip_gasto", MySqlDbType.VarChar, 255);
                descrip_gasto.Direction = ParameterDirection.Input;
                MySqlParameter pago_gasto = cmd.Parameters.Add("pago_gasto", MySqlDbType.Int32);
                pago_gasto.Direction = ParameterDirection.Input;
                MySqlParameter total_gasto = cmd.Parameters.Add("total_gasto", MySqlDbType.Decimal);
                total_gasto.Direction = ParameterDirection.Input;
                MySqlParameter imp_gasto = cmd.Parameters.Add("imp_gasto", MySqlDbType.Decimal);
                imp_gasto.Direction = ParameterDirection.Input;
                MySqlParameter nota_gasto = cmd.Parameters.Add("nota_gasto", MySqlDbType.VarChar, 100);
                nota_gasto.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_gasto.Value = gasto.COD_SUC;
                fecha_gasto.Value = gasto.FECHA.Date;
                tipodoc_gasto.Value = gasto.TIPO_DOC.ToString();
                doc_gasto.Value = gasto.DOCUMENTO;
                descrip_gasto.Value = gasto.DESCRIPCION;
                pago_gasto.Value = (int)gasto.TIPO_PAGO;
                total_gasto.Value = gasto.TOTAL;
                imp_gasto.Value = gasto.IVA;
                nota_gasto.Value = gasto.NOTA;


                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("GASTO REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR GASTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }






        public bool update(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_GASTO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idgasto = cmd.Parameters.Add("idgasto", MySqlDbType.Int32);
                idgasto.Direction = ParameterDirection.Input;
                MySqlParameter suc_gasto = cmd.Parameters.Add("suc_gasto", MySqlDbType.VarChar, 2);
                suc_gasto.Direction = ParameterDirection.Input;
                MySqlParameter fecha_gasto = cmd.Parameters.Add("fecha_gasto", MySqlDbType.Date);
                fecha_gasto.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc_gasto = cmd.Parameters.Add("tipodoc_gasto", MySqlDbType.VarChar, 5);
                tipodoc_gasto.Direction = ParameterDirection.Input;
                MySqlParameter doc_gasto = cmd.Parameters.Add("doc_gasto", MySqlDbType.VarChar, 20);
                doc_gasto.Direction = ParameterDirection.Input;
                MySqlParameter descrip_gasto = cmd.Parameters.Add("descrip_gasto", MySqlDbType.VarChar, 255);
                descrip_gasto.Direction = ParameterDirection.Input;
                MySqlParameter pago_gasto = cmd.Parameters.Add("pago_gasto", MySqlDbType.Int32);
                pago_gasto.Direction = ParameterDirection.Input;
                MySqlParameter total_gasto = cmd.Parameters.Add("total_gasto", MySqlDbType.Decimal);
                total_gasto.Direction = ParameterDirection.Input;
                MySqlParameter imp_gasto = cmd.Parameters.Add("imp_gasto", MySqlDbType.Decimal);
                imp_gasto.Direction = ParameterDirection.Input;
                MySqlParameter nota_gasto = cmd.Parameters.Add("nota_gasto", MySqlDbType.VarChar, 100);
                nota_gasto.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idgasto.Value = gasto.ID_GASTO;
                suc_gasto.Value = gasto.COD_SUC;
                fecha_gasto.Value = gasto.FECHA.Date;
                tipodoc_gasto.Value = gasto.TIPO_DOC.ToString();
                doc_gasto.Value = gasto.DOCUMENTO;
                descrip_gasto.Value = gasto.DESCRIPCION;
                pago_gasto.Value = (int)gasto.TIPO_PAGO;
                total_gasto.Value = gasto.TOTAL;
                imp_gasto.Value = gasto.IVA;
                nota_gasto.Value = gasto.NOTA;


                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("GASTO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR GASTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }






        public bool delete(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_GASTO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idgasto = cmd.Parameters.Add("idgasto", MySqlDbType.Int32);
                idgasto.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idgasto.Value = gasto.ID_GASTO;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;


                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE GASTO ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR GASTO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public DataTable findBySucAnio(string sucursal, int anioGasto)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_gastos WHERE COD_SUC = @suc AND YEAR(FECHA) = @anio;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.Int32);
                anio.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                anio.Value = anioGasto;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR GASTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






    }
}
