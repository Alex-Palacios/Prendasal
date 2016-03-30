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


    public class DBMovCash
    {
        private DBConexion conn;

        public DBMovCash()
        {
            conn = DBConexion.Instance();
        }



        // FUNCIONES CRUD
        

        public bool insert(MovCash mov, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter fecha_mov = cmd.Parameters.Add("fecha_mov", MySqlDbType.Date);
                fecha_mov.Direction = ParameterDirection.Input;
                MySqlParameter doc_mov = cmd.Parameters.Add("doc_mov", MySqlDbType.VarChar, 20);
                doc_mov.Direction = ParameterDirection.Input;
                MySqlParameter envia_mov = cmd.Parameters.Add("envia_mov", MySqlDbType.VarChar, 2);
                envia_mov.Direction = ParameterDirection.Input;
                MySqlParameter dest_mov = cmd.Parameters.Add("dest_mov", MySqlDbType.VarChar, 2);
                dest_mov.Direction = ParameterDirection.Input;
                MySqlParameter traslada_mov = cmd.Parameters.Add("traslada_mov", MySqlDbType.VarChar, 50);
                traslada_mov.Direction = ParameterDirection.Input;
                MySqlParameter total_mov = cmd.Parameters.Add("total_mov", MySqlDbType.Decimal);
                total_mov.Direction = ParameterDirection.Input;
                MySqlParameter nota_mov = cmd.Parameters.Add("nota_mov", MySqlDbType.VarChar, 100);
                nota_mov.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                fecha_mov.Value = mov.FECHA.Date;
                doc_mov.Value = mov.DOCUMENTO;
                envia_mov.Value = mov.SUC_ENVIA;
                dest_mov.Value = mov.SUC_DEST;
                traslada_mov.Value = mov.TRASLADA;
                total_mov.Value = mov.TOTAL;
                nota_mov.Value = mov.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("MOVIMIENTO DE CAPITAL REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR MOVIMIENTO DE CAPITAL" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(MovCash mov, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idmov = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                idmov.Direction = ParameterDirection.Input;
                MySqlParameter fecha_mov = cmd.Parameters.Add("fecha_mov", MySqlDbType.Date);
                fecha_mov.Direction = ParameterDirection.Input;
                MySqlParameter doc_mov = cmd.Parameters.Add("doc_mov", MySqlDbType.VarChar, 20);
                doc_mov.Direction = ParameterDirection.Input;
                MySqlParameter envia_mov = cmd.Parameters.Add("envia_mov", MySqlDbType.VarChar, 2);
                envia_mov.Direction = ParameterDirection.Input;
                MySqlParameter dest_mov = cmd.Parameters.Add("dest_mov", MySqlDbType.VarChar, 2);
                dest_mov.Direction = ParameterDirection.Input;
                MySqlParameter traslada_mov = cmd.Parameters.Add("traslada_mov", MySqlDbType.VarChar, 50);
                traslada_mov.Direction = ParameterDirection.Input;
                MySqlParameter total_mov = cmd.Parameters.Add("total_mov", MySqlDbType.Decimal);
                total_mov.Direction = ParameterDirection.Input;
                MySqlParameter nota_mov = cmd.Parameters.Add("nota_mov", MySqlDbType.VarChar, 100);
                nota_mov.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idmov.Value = mov.ID_MOV;
                fecha_mov.Value = mov.FECHA.Date;
                doc_mov.Value = mov.DOCUMENTO;
                envia_mov.Value = mov.SUC_ENVIA;
                dest_mov.Value = mov.SUC_DEST;
                traslada_mov.Value = mov.TRASLADA;
                total_mov.Value = mov.TOTAL;
                nota_mov.Value = mov.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("MOVIMIENTO DE CAPITAL ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR MOVIMIENTO DE CAPITAL ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool delete(MovCash mov, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                id.Value = mov.ID_MOV;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("MOVIMIENTO DE CAPITAL ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR MOVIMIENTO DE CAPITAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }






        public bool recibirFinanc(MovCash mov, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_RECIBIR_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                MySqlParameter recibe_mov = cmd.Parameters.Add("recibe_mov", MySqlDbType.VarChar, 50);
                recibe_mov.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                id.Value = mov.ID_MOV;
                recibe_mov.Value = mov.RECIBE;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("FINANCIAMIENTO MARCADO COMO RECIBIDO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL RECIBIR FINANCIAMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }


        public string nextComprobanteMovCash(string codsuc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_COMPROBANTE_MOVCASH(@sucursal)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                sucursal.Value = codsuc;

                reader = (string)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = null; }
            return reader;
        }




        public DataRow findByComprobante(string comprobante)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_mov_cash WHERE DOCUMENTO = @doc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;

                doc.Value = comprobante;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL OBTENER COMPROBANTE DE MOVIMIENTO DE CAPITAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }







        public DataTable getRemesasBySucAnio(string sucursal, int anioRemesa)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_ENVIA = @suc AND YEAR(FECHA) = @anio ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.Int32);
                anio.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                anio.Value = anioRemesa;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR REMESAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataTable getRemesasBySucAnioMes(string sucursalENV, string anioRemesa,string mesRemesa,string sucursalDEST)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = string.Empty;
                if (sucursalDEST != "00")
                {
                    sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_ENVIA = @sucenvia AND YEAR(FECHA) = @anio AND MONTH(FECHA) = @mes AND SUC_DEST= @sucdestino  ORDER BY SUC_ENVIA,FECHA DESC;";
                }
                else
                {
                    sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_ENVIA = @sucenvia AND YEAR(FECHA) = @anio AND MONTH(FECHA) = @mes AND SUC_DEST != @sucdestino ORDER BY SUC_ENVIA,FECHA DESC;";
                }
               
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sucdestino = cmd.Parameters.Add("sucdestino", MySqlDbType.VarChar, 2);
                sucdestino.Direction = ParameterDirection.Input;
                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.VarChar,4);
                anio.Direction = ParameterDirection.Input;
                MySqlParameter mes = cmd.Parameters.Add("mes", MySqlDbType.VarChar,2);
                mes.Direction = ParameterDirection.Input;
                MySqlParameter sucenvia = cmd.Parameters.Add("sucenvia", MySqlDbType.VarChar, 2);
                sucenvia.Direction = ParameterDirection.Input;
                
                sucenvia.Value = sucursalENV;
                anio.Value = anioRemesa;
                mes.Value = mesRemesa;
                sucdestino.Value = sucursalDEST;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR REMESAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataTable getFinancBySucAnio(string sucursal, int aniofinanc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_DEST = @suc AND YEAR(FECHA) = @anio  ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.Int32);
                anio.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                anio.Value = aniofinanc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR FINANCIAMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getFinancBySucAnioMes(string sucursalDEST, string aniofinanc,string mesfinanc,string sucursalENV)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = string.Empty;
                if (sucursalENV != "00")
                {
                    sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_DEST = @sucdestino AND YEAR(FECHA) = @anio AND MONTH(FECHA) = @mes AND SUC_ENVIA = @sucenvia  ORDER BY SUC_ENVIA,FECHA DESC;";
                }
                else
                {
                    sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_DEST = @sucdestino AND YEAR(FECHA) = @anio AND MONTH(FECHA) = @mes AND SUC_ENVIA != @sucenvia ORDER BY SUC_ENVIA,FECHA DESC;";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sucdestino = cmd.Parameters.Add("sucdestino", MySqlDbType.VarChar, 2);
                sucdestino.Direction = ParameterDirection.Input;
                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.VarChar,4);
                anio.Direction = ParameterDirection.Input;
                MySqlParameter mes = cmd.Parameters.Add("mes", MySqlDbType.VarChar,2);
                mes.Direction = ParameterDirection.Input;
                MySqlParameter sucenvia = cmd.Parameters.Add("sucenvia", MySqlDbType.VarChar, 2);
                sucenvia.Direction = ParameterDirection.Input;

                sucdestino.Value = sucursalDEST;
                anio.Value = aniofinanc;
                mes.Value = mesfinanc;
                sucenvia.Value = sucursalENV;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR FINANCIAMIENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable getFinancByRecibir(string sucursalDEST)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_mov_cash WHERE SUC_DEST = @sucdestino AND RECIBIDO = false;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter sucdestino = cmd.Parameters.Add("sucdestino", MySqlDbType.VarChar, 2);
                sucdestino.Direction = ParameterDirection.Input;
                MySqlParameter hoy = cmd.Parameters.Add("hoy", MySqlDbType.Date);
                hoy.Direction = ParameterDirection.Input;

                sucdestino.Value = sucursalDEST;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR FINANCIAMIENTOS POR RECIBIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        
        public int getCountFinancByRecibir(string sucursalDEST, DateTime fecha)
        {
            int reader = 0;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT COUNT(*) FROM prendasal.view_mov_cash WHERE SUC_DEST = @sucdestino AND RECIBIDO = false AND FECHA < @hoy;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter sucdestino = cmd.Parameters.Add("sucdestino", MySqlDbType.VarChar, 2);
                sucdestino.Direction = ParameterDirection.Input;
                MySqlParameter hoy = cmd.Parameters.Add("hoy", MySqlDbType.Date);
                hoy.Direction = ParameterDirection.Input;

                sucdestino.Value = sucursalDEST;
                hoy.Value = fecha.Date;

                reader = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            { 
                reader = 0; 
            }
            return reader;
        }




    }

}
