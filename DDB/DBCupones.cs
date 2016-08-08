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

    public class DBCupones
    {
        private DBConexion conn;

        public DBCupones()
        {
            conn = DBConexion.Instance();
        }


        // FUNCIONES CRUD


        public bool insert(Cupon cupon, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_CUPONES_DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter fechaexp_cupon = cmd.Parameters.Add("fechaexp_cupon", MySqlDbType.Date);
                fechaexp_cupon.Direction = ParameterDirection.Input;
                MySqlParameter tipo_cupon = cmd.Parameters.Add("tipo_cupon", MySqlDbType.Int32);
                tipo_cupon.Direction = ParameterDirection.Input;
                MySqlParameter desde_cupon = cmd.Parameters.Add("desde_cupon", MySqlDbType.Int32);
                desde_cupon.Direction = ParameterDirection.Input;
                MySqlParameter hasta_cupon = cmd.Parameters.Add("hasta_cupon", MySqlDbType.Int32);
                hasta_cupon.Direction = ParameterDirection.Input;
                MySqlParameter fechavenc_cupon = cmd.Parameters.Add("fechavenc_cupon", MySqlDbType.Date);
                fechavenc_cupon.Direction = ParameterDirection.Input;
                MySqlParameter descinteres_cupon = cmd.Parameters.Add("descinteres_cupon", MySqlDbType.Decimal);
                descinteres_cupon.Direction = ParameterDirection.Input;
                MySqlParameter descventa_cupon = cmd.Parameters.Add("descventa_cupon", MySqlDbType.Decimal);
                descventa_cupon.Direction = ParameterDirection.Input;
                MySqlParameter estado_cupon = cmd.Parameters.Add("estado_cupon", MySqlDbType.Bit);
                estado_cupon.Direction = ParameterDirection.Input;
                                

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                fechaexp_cupon.Value = cupon.FECHA_EXP.Date;
                tipo_cupon.Value = (int)cupon.TIPO;
                desde_cupon.Value = cupon.DESDE;
                hasta_cupon.Value = cupon.HASTA;
                fechavenc_cupon.Value = cupon.FECHA_VENC.Date;
                descinteres_cupon.Value = cupon.DESC_INTERES;
                descventa_cupon.Value = cupon.DESC_VENTA;
                estado_cupon.Value = cupon.ACTIVA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TIRAJE DE CUPONES O BILLETES REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR TIRAJE DE CUPONES O BILLETES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(Cupon cupon, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_CUPONES_DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idcupon = cmd.Parameters.Add("idcupon", MySqlDbType.Int32);
                idcupon.Direction = ParameterDirection.Input;
                MySqlParameter fechaexp_cupon = cmd.Parameters.Add("fechaexp_cupon", MySqlDbType.Date);
                fechaexp_cupon.Direction = ParameterDirection.Input;
                MySqlParameter tipo_cupon = cmd.Parameters.Add("tipo_cupon", MySqlDbType.Int32);
                tipo_cupon.Direction = ParameterDirection.Input;
                MySqlParameter desde_cupon = cmd.Parameters.Add("desde_cupon", MySqlDbType.Int32);
                desde_cupon.Direction = ParameterDirection.Input;
                MySqlParameter hasta_cupon = cmd.Parameters.Add("hasta_cupon", MySqlDbType.Int32);
                hasta_cupon.Direction = ParameterDirection.Input;
                MySqlParameter fechavenc_cupon = cmd.Parameters.Add("fechavenc_cupon", MySqlDbType.Date);
                fechavenc_cupon.Direction = ParameterDirection.Input;
                MySqlParameter descinteres_cupon = cmd.Parameters.Add("descinteres_cupon", MySqlDbType.Decimal);
                descinteres_cupon.Direction = ParameterDirection.Input;
                MySqlParameter descventa_cupon = cmd.Parameters.Add("descventa_cupon", MySqlDbType.Decimal);
                descventa_cupon.Direction = ParameterDirection.Input;
                MySqlParameter estado_cupon = cmd.Parameters.Add("estado_cupon", MySqlDbType.Bit);
                estado_cupon.Direction = ParameterDirection.Input;


                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idcupon.Value = cupon.ID_CUPON;
                fechaexp_cupon.Value = cupon.FECHA_EXP.Date;
                tipo_cupon.Value = (int)cupon.TIPO;
                desde_cupon.Value = cupon.DESDE;
                hasta_cupon.Value = cupon.HASTA;
                fechavenc_cupon.Value = cupon.FECHA_VENC.Date;
                descinteres_cupon.Value = cupon.DESC_INTERES;
                descventa_cupon.Value = cupon.DESC_VENTA;
                estado_cupon.Value = cupon.ACTIVA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TIRAJE DE CUPONES O BILLETES ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR TIRAJE DE CUPONES O BILLETES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        public bool delete(Cupon cupon, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_CUPONES_DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idcupon = cmd.Parameters.Add("idcupon", MySqlDbType.Int32);
                idcupon.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idcupon.Value = cupon.ID_CUPON;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TIRAJE DE CUPONES O BILLETES ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR TIRAJE DE CUPONES O BILLETES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        public DataTable showCuponesDesc()
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.cupones_desc ORDER BY FECHA_EXP DESC;";
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
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR TIRAJE DE CUPONES DE DESCUENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataRow searchCuponDesc(eTipoCupon tipo, int numero)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "prendasal.SP_GET_TIRAJE_CUPON_DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter tipoC = cmd.Parameters.Add("tipoC", MySqlDbType.Int32);
                tipoC.Direction = ParameterDirection.Input;
                MySqlParameter numeroC = cmd.Parameters.Add("numeroC", MySqlDbType.Int32);
                numeroC.Direction = ParameterDirection.Input;

                tipoC.Value = (int)tipo;
                numeroC.Value = numero;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL OBTENER CUPON", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }



        public bool isCuponDisponible(Cupon cupon)
        {
            bool ok = true;
            Int32 result = 0;
            try
            {
                string sql = "SELECT COUNT(*) FROM prendasal.canjeos WHERE ID_CUPON = @idcupon AND NUMERO = @numcupon;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter idcupon = cmd.Parameters.Add("idcupon", MySqlDbType.Int32);
                idcupon.Direction = ParameterDirection.Input;
                MySqlParameter numcupon = cmd.Parameters.Add("numcupon", MySqlDbType.Int32);
                numcupon.Direction = ParameterDirection.Input;

                idcupon.Value = cupon.ID_CUPON;
                numcupon.Value = cupon.NUMCUPON;

                result = Int32.Parse(cmd.ExecuteScalar().ToString());

                if (result > 0)
                {
                    ok = false;
                }
            }
            catch (Exception e)
            {
                ok = false;
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR DISPONIBILIDAD DEL CUPON ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ok;
        }







        public DataTable getCanjeos(Cupon cuponX)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SP_GET_TIRAJE_CANJEOS;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idcupon = cmd.Parameters.Add("idcupon", MySqlDbType.Int32);
                idcupon.Direction = ParameterDirection.Input;

                idcupon.Value = cuponX.ID_CUPON;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR CANJEOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




    }
}
