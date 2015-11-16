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

    public class DBReporte
    {
        private DBConexion conn;

        public DBReporte()
        {
            conn = DBConexion.Instance();
        }



        public DataTable RptContratosByEstado(string sucursal, eEstadoContrato estado)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_CONTRATOS_ESTADO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 2);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter estado_rpt = cmd.Parameters.Add("estado_rpt", MySqlDbType.VarChar, 20);
                estado_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursal;
                estado_rpt.Value = estado.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR EN CONSULTAR CONTRATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable RptContratosCancelados(string sucursal, DateTime FechaInicio, DateTime FechaFin)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_CONTRATOS_CANCELADOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 2);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter fi_rpt = cmd.Parameters.Add("fi_rpt", MySqlDbType.Date);
                fi_rpt.Direction = ParameterDirection.Input;
                MySqlParameter ff_rpt = cmd.Parameters.Add("ff_rpt", MySqlDbType.Date);
                ff_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursal;
                fi_rpt.Value = FechaInicio.Date;
                ff_rpt.Value = FechaFin.Date;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR EN CONSULTAR CONTRATOS CANCELADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






        public DataTable RptTransDiarias(string sucursal,DateTime FechaInicio, DateTime FechaFin)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_TRANS_DIARIAS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 2);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter fi_rpt = cmd.Parameters.Add("fi_rpt", MySqlDbType.Date);
                fi_rpt.Direction = ParameterDirection.Input;
                MySqlParameter ff_rpt = cmd.Parameters.Add("ff_rpt", MySqlDbType.Date);
                ff_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursal;
                fi_rpt.Value = FechaInicio.Date;
                ff_rpt.Value = FechaFin.Date;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR EN CONSULTAR TRANSACCIONES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getKPMTransDiarias(string sucursal, DateTime FechaInicio, DateTime FechaFin)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_KPM_TRANS_DIARIAS;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 2);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter fi_rpt = cmd.Parameters.Add("fi_rpt", MySqlDbType.Date);
                fi_rpt.Direction = ParameterDirection.Input;
                MySqlParameter ff_rpt = cmd.Parameters.Add("ff_rpt", MySqlDbType.Date);
                ff_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursal;
                fi_rpt.Value = FechaInicio.Date;
                ff_rpt.Value = FechaFin.Date;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL OBTENER DETALLE KMP DE TRANSACCIONES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }







        public DataTable RptComprasOroByMes(string sucursal, string anio,string mes)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_COMPRAS_ORO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 2);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter anio_rpt = cmd.Parameters.Add("anio_rpt", MySqlDbType.Int32);
                anio_rpt.Direction = ParameterDirection.Input;
                MySqlParameter mes_rpt = cmd.Parameters.Add("mes_rpt", MySqlDbType.Int32);
                mes_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursal;
                anio_rpt.Value = anio;
                mes_rpt.Value = mes;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR COMPRAS DE ORO Y PLATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }







        public DataTable RptVencidosOroByList(DateTime fecha, string lista)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_VENCIDOS_ORO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter fecha_venc = cmd.Parameters.Add("fecha_venc", MySqlDbType.Date);
                fecha_venc.Direction = ParameterDirection.Input;
                MySqlParameter doc_venc = cmd.Parameters.Add("doc_venc", MySqlDbType.VarChar,20);
                doc_venc.Direction = ParameterDirection.Input;

                fecha_venc.Value = fecha.Date;
                doc_venc.Value = lista;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR VENCIDOS DE ORO Y PLATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable RptEstadoCuenta(string cliente)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_ESTADO_CUENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cli_rpt = cmd.Parameters.Add("cli_rpt", MySqlDbType.VarChar, 15);
                cli_rpt.Direction = ParameterDirection.Input;

                cli_rpt.Value = cliente;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR ESTADO DE CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


    }
}
