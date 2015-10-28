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



        public DataTable REPORTE_DIARIO_PRENDASAL(string suc,DateTime FechaInicio, DateTime FechaFin)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_REPORTE_DIARIO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter fInicio = cmd.Parameters.Add("fechaInicio", MySqlDbType.Date);
                fInicio.Direction = ParameterDirection.Input;
                MySqlParameter fFin = cmd.Parameters.Add("fechaFin", MySqlDbType.Date);
                fFin.Direction = ParameterDirection.Input;

                sucursal.Value = suc;
                fInicio.Value = FechaInicio.Date.ToString("yyyy-MM-dd");
                fFin.Value = FechaFin.Date.ToString("yyyy-MM-dd");

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR REPORTE DIARIO DEL "+ FechaInicio.Date.ToString("dd/MM/yyyy") + " AL " + FechaFin.Date.ToString("dd/MM/yyyy"), "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }









        public DataTable CONTRATOS_CANCELADOS_PRENDASAL(string suc, DateTime FechaInicio, DateTime FechaFin)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_CONTRATOS_CANCELADOS";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sucursal = cmd.Parameters.Add("codsuc", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter fInicio = cmd.Parameters.Add("fechaInicio", MySqlDbType.Date);
                fInicio.Direction = ParameterDirection.Input;
                MySqlParameter fFin = cmd.Parameters.Add("fechaFin", MySqlDbType.Date);
                fFin.Direction = ParameterDirection.Input;

                sucursal.Value = suc;
                fInicio.Value = FechaInicio.Date.ToString("yyyy-MM-dd");
                fFin.Value = FechaFin.Date.ToString("yyyy-MM-dd");

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR REPORTE DE CANCELADOS DEL " + FechaInicio.Date.ToString("dd/MM/yyyy") + " AL " + FechaFin.Date.ToString("dd/MM/yyyy"), "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataTable COMPRAS_KILMES(string suc, string mes, string anio)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_REPORTE_COMPRAS_KILMES";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sucursal = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter m = cmd.Parameters.Add("mes", MySqlDbType.VarChar,2);
                m.Direction = ParameterDirection.Input;
                MySqlParameter y = cmd.Parameters.Add("anio", MySqlDbType.VarChar, 4);
                y.Direction = ParameterDirection.Input;

                sucursal.Value = suc;
                m.Value = mes;
                y.Value = anio;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR REPORTE DE COMPRAS DE ORO Y PLATA", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


    }
}
