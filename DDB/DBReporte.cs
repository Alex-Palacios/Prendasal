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




        public DataTable LIBRO_DIARIO(int periodo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM ddsic.VIEW_LIBRO_DIARIO WHERE PERIODO = @p";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter p = cmd.Parameters.Add("p", MySqlDbType.Int32);
                p.Direction = ParameterDirection.Input;
                p.Value = periodo;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LAS SUCURSALES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable DIAS_ABIERTOS_PRENDASAL(string suc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT COD_SUC,SUCURSAL,DIRECCION AS DIRECCION_SUC,TEL AS TEL_SUC,FECHA,APERTURA,CIERRE,ABIERTO FROM prendasal.corte_diario natural join ddicark.sucursal WHERE COD_SUC = @sucursal AND ABIERTO = TRUE ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar,2);
                sucursal.Direction = ParameterDirection.Input;

                sucursal.Value = suc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR REPORTE DIARIO\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
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





        public void CERRAR_DIA_PRENDASAL(string sucCorte, DateTime fecha, string sucursal, string empleado, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_CORTE_DIARIO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_corte = cmd.Parameters.Add("suc_corte", MySqlDbType.VarChar, 2);
                suc_corte.Direction = ParameterDirection.Input;
                MySqlParameter fechaCorte = cmd.Parameters.Add("fechaCorte", MySqlDbType.Date);
                fechaCorte.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                suc_corte.Value = sucCorte;
                fechaCorte.Value = fecha.Date.ToString("yyyy-MM-dd");
                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CORTE DIARIO DEL " + fecha.Date.ToString("dd/MM/yyyy" + " REALIZADO CORRECTAMENTE"), "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL REALIZAR CORTE DEL " + fecha.Date.ToString("dd/MM/yyyy") + "\n" +e.Message, "ERROR EN OPERACION DE CIERRE ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public decimal FN_CALCULAR_APERTURA_PRENDASAL(string sucursal, DateTime fecha)
        {
            decimal reader = (decimal) 0.00;
            DataTable datos = new DataTable();
            try
            {
                if (sucursal != "00")
                {
                    string sql = "SELECT prendasal.FN_CALCULAR_APERTURA(@dia,@suc);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                    cmd.CommandType = CommandType.Text;
                    MySqlParameter dia = cmd.Parameters.Add("dia", MySqlDbType.Date);
                    dia.Direction = ParameterDirection.Input;
                    MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                    suc.Direction = ParameterDirection.Input;

                    dia.Value = fecha.Date.ToString("yyyy-MM-dd");
                    suc.Value = sucursal;

                    reader = (decimal)cmd.ExecuteScalar();
                }
                else
                {
                    reader = (decimal)0.00;
                }
            }
            catch (Exception e)
            { reader = (decimal) 0.00; }
            return reader;
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
