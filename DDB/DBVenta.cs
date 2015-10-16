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


    public class DBVenta
    {
        private DBConexion conn;

        public DBVenta()
        {
            conn = DBConexion.Instance();
        }


        private string buildItemsVenta(Venta venta)
        {
            string items = "";
            foreach (DataGridViewRow row in venta.ITEMS_VENTA)
            {
                string inv = row.Cells["ITEM"].Value.ToString();
                if (inv == "N/A" || inv == "-----")
                {
                    inv = null;
                }
                string descripcion = row.Cells["DESCRIPCION"].Value.ToString().ToUpper();
                descripcion = descripcion.Replace(',',' ');
                descripcion = descripcion.Replace(';',' ');

                items = items + Double.Parse(row.Cells["CANTIDAD"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                    + inv + "," + descripcion + ","
                    + Decimal.Parse(row.Cells["PRECIO_UNIT"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                    + Decimal.Parse(row.Cells["MONTO"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                    + Int32.Parse(row.Cells["TAX"].FormattedValue.ToString()) + ","
                    + Decimal.Parse(row.Cells["PRECIO_IMP"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                    + Decimal.Parse(row.Cells["MONTO_IMP"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency) + ","
                    + row.Cells["CUENTA"].Value + ","
                    + Int32.Parse(row.Cells["INV"].FormattedValue.ToString()) + ";";
            }
            return items;
        }


        // FUNCIONES CRUD
       
        public DataTable getItemsVenta(int venta)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "ddicark.SP_SHOW_DETALLE_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter c = cmd.Parameters.Add("venta", MySqlDbType.Int32);
                c.Direction = ParameterDirection.Input;
                c.Value = venta;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR DETALLE DE VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        


        public bool isCancelada(int venta)
        {
            bool reader = false;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT ddicark.FN_VENTA_isCANCELADA(@idventa)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter idventa = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                idventa.Direction = ParameterDirection.Input;
                idventa.Value = venta;
                reader = (bool)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = false; }
            return reader;
        }







        public DataTable findByVentaPRENDASAL(DateTime? fecha, eTipoDocVenta tipo, string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_ventas WHERE TIPO_DOC = @tipo AND DOCUMENTO = @doc ";
                if (fecha != null)
                {
                    sql = sql + "AND FECHA = @f";
                }
                sql = sql + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                if (fecha != null)
                {
                    MySqlParameter f = cmd.Parameters.Add("f", MySqlDbType.Date);
                    f.Direction = ParameterDirection.Input;
                    f.Value = fecha.Value.Date.ToString("yyyy-MM-yyyy");
                }
                MySqlParameter t = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                t.Direction = ParameterDirection.Input;
                MySqlParameter d = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                d.Direction = ParameterDirection.Input;

                
                t.Value = (int)tipo;
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
                MessageBox.Show("ERROR AL BUSCAR VENTA # " + doc + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public void insertPRENDASAL(Venta venta, string sucursal, string empleado, string sistema)
        {
            string items = "";
            try
            {
                items = buildItemsVenta(venta);

                string sql = "prendasal.SP_REGISTRAR_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter cliente = cmd.Parameters.Add("cliente", MySqlDbType.VarChar, 15);
                cliente.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter documento = cmd.Parameters.Add("documento", MySqlDbType.VarChar, 20);
                documento.Direction = ParameterDirection.Input;
                MySqlParameter tipoventa = cmd.Parameters.Add("tipoventa", MySqlDbType.Int32);
                tipoventa.Direction = ParameterDirection.Input;
                MySqlParameter sumas = cmd.Parameters.Add("total_sumas", MySqlDbType.Decimal);
                sumas.Direction = ParameterDirection.Input;
                MySqlParameter total = cmd.Parameters.Add("total_venta", MySqlDbType.Decimal);
                total.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado_venta", MySqlDbType.Int32);
                estado.Direction = ParameterDirection.Input;
                MySqlParameter nivel_venta = cmd.Parameters.Add("nivel_venta", MySqlDbType.Int32);
                nivel_venta.Direction = ParameterDirection.Input;
                MySqlParameter ventaNat = cmd.Parameters.Add("ventaNat", MySqlDbType.Int32);
                ventaNat.Direction = ParameterDirection.Input;
                MySqlParameter observacion = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                observacion.Direction = ParameterDirection.Input;
                MySqlParameter init = cmd.Parameters.Add("init", MySqlDbType.Bit);
                init.Direction = ParameterDirection.Input;
                MySqlParameter codSUC = cmd.Parameters.Add("suc_venta", MySqlDbType.VarChar, 2);
                codSUC.Direction = ParameterDirection.Input;
                MySqlParameter itemsV = cmd.Parameters.Add("items", MySqlDbType.LongText);
                itemsV.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;


                cliente.Value = venta.COD_CLIENTE;
                fecha.Value = venta.FECHA.Date.ToString("yyyy-MM-dd");
                tipodoc.Value = (int)venta.TIPO_DOC;
                documento.Value = venta.DOCUMENTO;
                tipoventa.Value = (int)venta.TIPO_VENTA;
                sumas.Value = venta.SUMAS;
                total.Value = venta.TOTAL;
                estado.Value = (int)venta.ESTADO;
                nivel_venta.Value = (int)venta.NIVEL;
                ventaNat.Value = (int)venta.NAT_VENTA;
                init.Value = venta.INIT_BALANCE;
                codSUC.Value = venta.COD_SUC;
                observacion.Value = venta.NOTA;

                itemsV.Value = items;
                
                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA REGISTRADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL REGISTRAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




        public void updatePRENDASAL(Venta venta, string sucursal, string empleado, string sistema)
        {
            string items = "";
            try
            {
                items = buildItemsVenta(venta);

                string sql = "prendasal.SP_EDITAR_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idventa = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                idventa.Direction = ParameterDirection.Input;
                MySqlParameter cliente = cmd.Parameters.Add("cliente", MySqlDbType.VarChar, 15);
                cliente.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter documento = cmd.Parameters.Add("documento", MySqlDbType.VarChar, 20);
                documento.Direction = ParameterDirection.Input;
                MySqlParameter tipoventa = cmd.Parameters.Add("tipoventa", MySqlDbType.Int32);
                tipoventa.Direction = ParameterDirection.Input;
                MySqlParameter sumas = cmd.Parameters.Add("total_sumas", MySqlDbType.Decimal);
                sumas.Direction = ParameterDirection.Input;
                MySqlParameter total = cmd.Parameters.Add("total_venta", MySqlDbType.Decimal);
                total.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado_venta", MySqlDbType.Int32);
                estado.Direction = ParameterDirection.Input;
                MySqlParameter nivel_venta = cmd.Parameters.Add("nivel_venta", MySqlDbType.Int32);
                nivel_venta.Direction = ParameterDirection.Input;
                MySqlParameter ventaNat = cmd.Parameters.Add("ventaNat", MySqlDbType.Int32);
                ventaNat.Direction = ParameterDirection.Input;
                MySqlParameter observacion = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                observacion.Direction = ParameterDirection.Input;
                MySqlParameter init = cmd.Parameters.Add("init", MySqlDbType.Bit);
                init.Direction = ParameterDirection.Input;
                MySqlParameter codSUC = cmd.Parameters.Add("suc_venta", MySqlDbType.VarChar, 2);
                codSUC.Direction = ParameterDirection.Input;
                MySqlParameter itemsV = cmd.Parameters.Add("items", MySqlDbType.LongText);
                itemsV.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                idventa.Value = venta.ID_VENTA;
                cliente.Value = venta.COD_CLIENTE;
                fecha.Value = venta.FECHA.Date.ToString("yyyy-MM-dd");
                tipodoc.Value = (int)venta.TIPO_DOC;
                documento.Value = venta.DOCUMENTO;
                tipoventa.Value = (int)venta.TIPO_VENTA;
                sumas.Value = venta.SUMAS;
                total.Value = venta.TOTAL;
                estado.Value = (int)venta.ESTADO;
                nivel_venta.Value = (int)venta.NIVEL;
                ventaNat.Value = (int)venta.NAT_VENTA;
                init.Value = venta.INIT_BALANCE;
                codSUC.Value = venta.COD_SUC;
                observacion.Value = venta.NOTA;

                itemsV.Value = items;

                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;


                notaCambio.Value = venta.NOTA_CAMBIO;

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA ACTUALIZADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public void deletePRENDASAL(Venta venta, string suc, string emp, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_ELIMINAR_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter v = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                v.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                v.Value = venta.ID_VENTA;
                notaCambio.Value = venta.NOTA_CAMBIO;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE VENTA ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR VENTA ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }


    }
}
