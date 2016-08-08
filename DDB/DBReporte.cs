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



        public DataTable RptContratosVigentesDias(string sucursal,int desde, int hasta)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_CONTRATOS_VIGENTES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 2);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter desde_rpt = cmd.Parameters.Add("desde_rpt", MySqlDbType.Int32);
                desde_rpt.Direction = ParameterDirection.Input;
                MySqlParameter hasta_rpt = cmd.Parameters.Add("hasta_rpt", MySqlDbType.Int32);
                hasta_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursal;
                desde_rpt.Value = desde;
                hasta_rpt.Value = hasta;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR EN CONSULTAR CONTRATOS VIGENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
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








        public DataTable RptConsolidado(string anio,string meses,string sucursales,bool prestamos,bool compras,bool ventas,bool intereses,bool abonos)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_CONSOLIDADO_TRANS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter anio_rpt = cmd.Parameters.Add("anio_rpt", MySqlDbType.VarChar, 4);
                anio_rpt.Direction = ParameterDirection.Input;
                MySqlParameter meses_rpt = cmd.Parameters.Add("meses_rpt", MySqlDbType.VarChar, 100);
                meses_rpt.Direction = ParameterDirection.Input;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar,100);
                suc_rpt.Direction = ParameterDirection.Input;
                MySqlParameter prestamo_rpt = cmd.Parameters.Add("prestamo_rpt", MySqlDbType.Bit);
                prestamo_rpt.Direction = ParameterDirection.Input;
                MySqlParameter compra_rpt = cmd.Parameters.Add("compra_rpt", MySqlDbType.Bit);
                compra_rpt.Direction = ParameterDirection.Input;
                MySqlParameter venta_rpt = cmd.Parameters.Add("venta_rpt", MySqlDbType.Bit);
                venta_rpt.Direction = ParameterDirection.Input;
                MySqlParameter interes_rpt = cmd.Parameters.Add("interes_rpt", MySqlDbType.Bit);
                interes_rpt.Direction = ParameterDirection.Input;
                MySqlParameter abono_rpt = cmd.Parameters.Add("abono_rpt", MySqlDbType.Bit);
                abono_rpt.Direction = ParameterDirection.Input;

                anio_rpt.Value = anio;
                meses_rpt.Value = meses;
                suc_rpt.Value = sucursales;
                prestamo_rpt.Value = prestamos;
                compra_rpt.Value = compras;
                venta_rpt.Value = ventas;
                interes_rpt.Value = intereses;
                abono_rpt.Value = abonos;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR REPORTE CONSOLIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }








        public DataTable RptKARDEX(string anio,string mes,string item)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_KARDEX";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter anio_rpt = cmd.Parameters.Add("anio_rpt", MySqlDbType.VarChar, 4);
                anio_rpt.Direction = ParameterDirection.Input;
                MySqlParameter mes_rpt = cmd.Parameters.Add("mes_rpt", MySqlDbType.VarChar, 2);
                mes_rpt.Direction = ParameterDirection.Input;
                MySqlParameter item_rpt = cmd.Parameters.Add("item_rpt", MySqlDbType.VarChar, 20);
                item_rpt.Direction = ParameterDirection.Input;

                anio_rpt.Value = anio;
                mes_rpt.Value = mes;
                item_rpt.Value = item;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR KARDEX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






        public DataTable RptCarteraVigente(string sucursales)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_CARTERA_VIGENTE";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_rpt = cmd.Parameters.Add("suc_rpt", MySqlDbType.VarChar, 100);
                suc_rpt.Direction = ParameterDirection.Input;

                suc_rpt.Value = sucursales;
                
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR REPORTE DE CARTERA VIGENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }











    }
}
