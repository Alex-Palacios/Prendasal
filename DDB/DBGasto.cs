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


        private string buildItemsGasto(Gasto gasto)
        {
            string items = "";
            if (gasto.ITEMS_GASTO != null && gasto.ITEMS_GASTO.Count > 0)
            {
                foreach (DataGridViewRow row in gasto.ITEMS_GASTO)
                {
                    items = items + "1.00," + null + "," +
                        row.Cells["DESCRIPCION"].Value + ","
                        + "0.00,"
                        + "0.00,"
                        + Decimal.Parse(row.Cells["MONTO"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                        + Int32.Parse(row.Cells["TAX"].FormattedValue.ToString()) + ","
                        + "0.00,"
                        + Decimal.Parse(row.Cells["MONTO_IMP"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                        + row.Cells["CUENTA"].Value + ";";
                }
            }
            else
            {
                int tax = 0;
                
                items = items + "1.00," + null + ","
                        + gasto.DESCRIPCION + ","
                        + "0.00,"
                        + "0.00,"
                        + gasto.TOTAL + ","
                        + tax + ","
                        + "0.00,"
                        + gasto.TOTAL_IMP + ","
                        + null + ";";
            }
            return items;
        }
        

        // FUNCIONES CRUD
        




        public DataTable selectGastosBySucPRENDASAL(string sucursal,DateTime fecha)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_gastos WHERE COD_SUC = @suc AND YEAR(FECHA) = @fechaG ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar,2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter fechaG = cmd.Parameters.Add("fechaG", MySqlDbType.Int32);
                fechaG.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                fechaG.Value = fecha.Date.ToString("yyyy");

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


        public DataTable getItemsGasto(int gasto)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddsick.SP_SHOW_DETALLE_COMPRA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter c = cmd.Parameters.Add("compra", MySqlDbType.Int32);
                c.Direction = ParameterDirection.Input;
                c.Value = gasto;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR DETALLE DE GASTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






        public bool isCancelado(int gasto)
        {
            bool reader = false;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT ddsic.FN_COMPRA_isCANCELADA(@idcompra)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter idcompra = cmd.Parameters.Add("idcompra", MySqlDbType.Int32);
                idcompra.Direction = ParameterDirection.Input;
                idcompra.Value = gasto;
                reader = (bool)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = false; }
            return reader;
        }



        public DataTable findByGastoPRENDASAL(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_gastos WHERE DOCUMENTO = @doc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter d = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                d.Direction = ParameterDirection.Input;

                d.Value = doc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL BUSCAR GASTO # " + doc + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        // FUNCIONES CRUD
        public void insertPRENDASAL(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            string items = "";
            try
            {
                items = buildItemsGasto(gasto);

                string sql = "prendasal.SP_REGISTRAR_GASTO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter documento = cmd.Parameters.Add("documento", MySqlDbType.VarChar, 20);
                documento.Direction = ParameterDirection.Input;
                MySqlParameter tipocompra = cmd.Parameters.Add("tipogasto", MySqlDbType.Int32);
                tipocompra.Direction = ParameterDirection.Input;
                MySqlParameter sumas = cmd.Parameters.Add("total_sumas", MySqlDbType.Decimal);
                sumas.Direction = ParameterDirection.Input;
                MySqlParameter total = cmd.Parameters.Add("total_gasto", MySqlDbType.Decimal);
                total.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado_gasto", MySqlDbType.Int32);
                estado.Direction = ParameterDirection.Input;
                MySqlParameter nivel_gasto = cmd.Parameters.Add("nivel_gasto", MySqlDbType.Int32);
                nivel_gasto.Direction = ParameterDirection.Input;
                MySqlParameter gastoNat = cmd.Parameters.Add("gastoNat", MySqlDbType.Int32);
                gastoNat.Direction = ParameterDirection.Input;
                MySqlParameter init = cmd.Parameters.Add("init", MySqlDbType.Bit);
                init.Direction = ParameterDirection.Input;
                MySqlParameter codSUC = cmd.Parameters.Add("suc_gasto", MySqlDbType.VarChar, 2);
                codSUC.Direction = ParameterDirection.Input;
                MySqlParameter observacion = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                observacion.Direction = ParameterDirection.Input;
                MySqlParameter itemsC = cmd.Parameters.Add("items", MySqlDbType.LongText);
                itemsC.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                fecha.Value = gasto.FECHA.Date.ToString("yyyy-MM-dd");
                tipodoc.Value = (int)gasto.TIPO_DOC;
                documento.Value = gasto.DOCUMENTO;
                tipocompra.Value = (int) eTipoCompra.CONTADO;
                sumas.Value = gasto.SUMAS;
                total.Value = gasto.TOTAL;
                estado.Value = (int)gasto.ESTADO;
                nivel_gasto.Value = (int)eNIVEL.PRENDASAL;
                init.Value = gasto.INIT_BALANCE;
                codSUC.Value = gasto.COD_SUC;
                observacion.Value = gasto.NOTA;

                itemsC.Value = items;

                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("GASTO REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL REGISTRAR GASTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }






        public void updatePRENDASAL(Gasto gasto, string sucursal, string empleado, string sistema)
        {
            string items = "";
            try
            {
                items = buildItemsGasto(gasto);

                string sql = "prendasal.SP_EDITAR_GASTO";

                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idcompra = cmd.Parameters.Add("idgasto", MySqlDbType.Int32);
                idcompra.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter documento = cmd.Parameters.Add("documento", MySqlDbType.VarChar, 20);
                documento.Direction = ParameterDirection.Input;
                MySqlParameter tipocompra = cmd.Parameters.Add("tipogasto", MySqlDbType.Int32);
                tipocompra.Direction = ParameterDirection.Input;
                MySqlParameter sumas = cmd.Parameters.Add("total_sumas", MySqlDbType.Decimal);
                sumas.Direction = ParameterDirection.Input;
                MySqlParameter total = cmd.Parameters.Add("total_gasto", MySqlDbType.Decimal);
                total.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado_gasto", MySqlDbType.Int32);
                estado.Direction = ParameterDirection.Input;
                MySqlParameter nivel_gasto = cmd.Parameters.Add("nivel_gasto", MySqlDbType.Int32);
                nivel_gasto.Direction = ParameterDirection.Input;
                MySqlParameter gastoNat = cmd.Parameters.Add("gastoNat", MySqlDbType.Int32);
                gastoNat.Direction = ParameterDirection.Input;
                MySqlParameter init = cmd.Parameters.Add("init", MySqlDbType.Bit);
                init.Direction = ParameterDirection.Input;
                MySqlParameter codSUC = cmd.Parameters.Add("suc_gasto", MySqlDbType.VarChar, 2);
                codSUC.Direction = ParameterDirection.Input;
                MySqlParameter observacion = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                observacion.Direction = ParameterDirection.Input;
                MySqlParameter itemsC = cmd.Parameters.Add("items", MySqlDbType.LongText);
                itemsC.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                idcompra.Value = gasto.ID_GASTO;
                fecha.Value = gasto.FECHA.Date.ToString("yyyy-MM-dd");
                tipodoc.Value = (int)gasto.TIPO_DOC;
                documento.Value = gasto.DOCUMENTO;
                tipocompra.Value = (int)eTipoCompra.CONTADO;
                sumas.Value = gasto.SUMAS;
                total.Value = gasto.TOTAL;
                estado.Value = (int)gasto.ESTADO;
                nivel_gasto.Value = (int)eNIVEL.PRENDASAL;
                init.Value = gasto.INIT_BALANCE;
                codSUC.Value = gasto.COD_SUC;
                observacion.Value = gasto.NOTA;

                itemsC.Value = items;

                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;

                notaCambio.Value = gasto.NOTA_CAMBIO;

                cmd.ExecuteNonQuery();
                MessageBox.Show("GASTO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR GASTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public void deletePRENDASAL(Gasto gasto, string suc, string emp, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_ELIMINAR_GASTO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter c = cmd.Parameters.Add("idgasto", MySqlDbType.Int32);
                c.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                c.Value = gasto.ID_GASTO;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sistema;

                notaCambio.Value = gasto.NOTA_CAMBIO;

                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE GASTO ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR GASTO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



    }
}
