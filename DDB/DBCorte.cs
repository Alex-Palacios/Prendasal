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

    public class DBCorte
    {
        private DBConexion conn;

        public DBCorte()
        {
            conn = DBConexion.Instance();
        }




        //FUNCIONES CRUD

        public bool insert(CorteDiario corte, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_CORTE_DIARIO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_corte = cmd.Parameters.Add("suc_corte", MySqlDbType.VarChar, 2);
                suc_corte.Direction = ParameterDirection.Input;
                MySqlParameter fecha_corte = cmd.Parameters.Add("fecha_corte", MySqlDbType.Date);
                fecha_corte.Direction = ParameterDirection.Input;
                MySqlParameter inicio_corte = cmd.Parameters.Add("inicio_corte", MySqlDbType.Decimal);
                inicio_corte.Direction = ParameterDirection.Input;
                MySqlParameter saldo_corte = cmd.Parameters.Add("saldo_corte", MySqlDbType.Decimal);
                saldo_corte.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_corte.Value = corte.COD_SUC;
                fecha_corte.Value = corte.FECHA.Date;
                inicio_corte.Value = corte.SALDO_INICIAL;
                saldo_corte.Value = corte.SALDO_FINAL;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CORTE DIARIO DEL " + corte.FECHA.Date.ToString("dd/MM/yyyy" + " REALIZADO CORRECTAMENTE"), "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REALIZAR CORTE DIARIO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }






        public decimal FN_CALCULAR_SALDO_INICIAL(string sucursal, DateTime fecha)
        {
            decimal reader = (decimal)0.00;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_CALCULAR_SALDO_INICIAL(@suc,@dia);";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter dia = cmd.Parameters.Add("dia", MySqlDbType.Date);
                dia.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                dia.Value = fecha.Date;

                reader = (decimal)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL  OBTENER SALDO INICIAL", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                reader = (decimal)0.00;
            }
            return reader;
        }






        public DataTable COMPRAS_KIL_DIARIO(string suc, DateTime FechaInicio, DateTime FechaFin)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.COMPRAS_KIL_DIARIO";
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
                MessageBox.Show("NO SE PUDO CONSULTAR REPORTE DIARIO DEL " + FechaInicio.Date.ToString("dd/MM/yyyy") + " AL " + FechaFin.Date.ToString("dd/MM/yyyy"), "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }

    }
}
