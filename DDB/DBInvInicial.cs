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

    public class DBInvInicial
    {
        private DBConexion conn;

        public DBInvInicial()
        {
            conn = DBConexion.Instance();
        }


        public DataTable getInventarioInicialPeriodo(int periodo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddsic.SP_SHOW_II";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter p = cmd.Parameters.Add("periodo", MySqlDbType.Int32);
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
                MessageBox.Show("NO SE PUDO CONSULTAR EL INVENTARIO INICIAL\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public void updateItemII(int pr, int mov, string cod, double cantidad, decimal costo_unit, string suc, string emp, string sys)
        {
            try
            {
                string sql = "ddsic.SP_UPDATE_II_ITEM";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter periodo = cmd.Parameters.Add("periodo", MySqlDbType.Int32);
                periodo.Direction = ParameterDirection.Input;
                MySqlParameter id = cmd.Parameters.Add("id", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 20);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter unidades = cmd.Parameters.Add("cantidad", MySqlDbType.Double);
                unidades.Direction = ParameterDirection.Input;
                MySqlParameter costo = cmd.Parameters.Add("costo", MySqlDbType.Decimal);
                costo.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                periodo.Value = pr;
                id.Value = mov;
                codigo.Value = cod;
                unidades.Value = cantidad;
                costo.Value = costo_unit;
                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR INVENTARIO INICIAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public void cargarProductosII(int periodo, string sucursal, string empleado, string sys)
        {
            try
            {
                string sql = "ddsic.SP_CARGAR_INVENTARIO_INICIAL";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter p = cmd.Parameters.Add("periodo", MySqlDbType.Int32);
                p.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                p.Value = periodo;
                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sys;
                cmd.ExecuteNonQuery();
                MessageBox.Show("INVENTARIO INICIAL CARGADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CARGAR INVENTARIO INICIAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }


    }
}
