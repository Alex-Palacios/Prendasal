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
            foreach (DataRow row in venta.ITEMS_VENTA.Rows)
            {
                items = items + row.Field<string>("CODIGO") + ">"
                    + row.Field<string>("COD_ITEM") + ">"
                    + row.Field<decimal>("CANTIDAD") + ">"
                    + row.Field<string>("DESCRIPCION") + ">"
                    + row.Field<decimal>("MONTO") + ">"
                    + row.Field<decimal>("PRECIO") + "&";
            }
            return items;
        }


        // FUNCIONES CRUD
       

        public bool insert(Venta venta, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_venta = cmd.Parameters.Add("suc_venta", MySqlDbType.VarChar, 2);
                suc_venta.Direction = ParameterDirection.Input;
                MySqlParameter cli_venta = cmd.Parameters.Add("cli_venta", MySqlDbType.VarChar, 15);
                cli_venta.Direction = ParameterDirection.Input;
                MySqlParameter fecha_venta = cmd.Parameters.Add("fecha_venta", MySqlDbType.Date);
                fecha_venta.Direction = ParameterDirection.Input;
                MySqlParameter tipo_venta = cmd.Parameters.Add("tipo_venta", MySqlDbType.Int32);
                tipo_venta.Direction = ParameterDirection.Input;
                MySqlParameter num_venta = cmd.Parameters.Add("num_venta", MySqlDbType.VarChar, 20);
                num_venta.Direction = ParameterDirection.Input;
                MySqlParameter doc_venta = cmd.Parameters.Add("doc_venta", MySqlDbType.VarChar, 20);
                doc_venta.Direction = ParameterDirection.Input;
                MySqlParameter pago_venta = cmd.Parameters.Add("pago_venta", MySqlDbType.Int32);
                pago_venta.Direction = ParameterDirection.Input;
                MySqlParameter desc_venta = cmd.Parameters.Add("desc_venta", MySqlDbType.Decimal);
                desc_venta.Direction = ParameterDirection.Input;
                MySqlParameter subtotal_venta = cmd.Parameters.Add("subtotal_venta", MySqlDbType.Decimal);
                subtotal_venta.Direction = ParameterDirection.Input;
                MySqlParameter cesc_venta = cmd.Parameters.Add("cesc_venta", MySqlDbType.Decimal);
                cesc_venta.Direction = ParameterDirection.Input;
                MySqlParameter total_venta = cmd.Parameters.Add("total_venta", MySqlDbType.Decimal);
                total_venta.Direction = ParameterDirection.Input;
                MySqlParameter iva_venta = cmd.Parameters.Add("iva_venta", MySqlDbType.Decimal);
                iva_venta.Direction = ParameterDirection.Input;
                MySqlParameter iva_desc = cmd.Parameters.Add("iva_desc", MySqlDbType.Decimal);
                iva_desc.Direction = ParameterDirection.Input;
                MySqlParameter cat_venta = cmd.Parameters.Add("cat_venta", MySqlDbType.VarChar, 50);
                cat_venta.Direction = ParameterDirection.Input;
                MySqlParameter nivel_venta = cmd.Parameters.Add("nivel_venta", MySqlDbType.Int32);
                nivel_venta.Direction = ParameterDirection.Input;
                MySqlParameter nota_venta = cmd.Parameters.Add("nota_venta", MySqlDbType.VarChar, 100);
                nota_venta.Direction = ParameterDirection.Input;
                MySqlParameter items_venta = cmd.Parameters.Add("items_venta", MySqlDbType.LongText);
                items_venta.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_venta.Value = venta.COD_SUC;
                cli_venta.Value = venta.COD_CLIENTE;
                fecha_venta.Value = venta.FECHA.Date;
                tipo_venta.Value = (int)venta.TIPO;
                num_venta.Value = venta.NUMVENTA;
                doc_venta.Value = venta.DOCUMENTO;
                pago_venta.Value = (int)venta.TIPO_PAGO;
                desc_venta.Value = venta.DESCUENTO;
                subtotal_venta.Value = venta.SUBTOTAL;
                cesc_venta.Value = venta.CESC;
                total_venta.Value = venta.TOTAL;
                iva_venta.Value = venta.IVA;
                iva_desc.Value = venta.IVA_DESC;
                cat_venta.Value = venta.CATEGORIA.ToString();
                nivel_venta.Value = (int)venta.NIVEL;
                nota_venta.Value = venta.NOTA;

                items_venta.Value = buildItemsVenta(venta);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA REGISTRADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(Venta venta, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idventa = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                idventa.Direction = ParameterDirection.Input;
                MySqlParameter suc_venta = cmd.Parameters.Add("suc_venta", MySqlDbType.VarChar, 2);
                suc_venta.Direction = ParameterDirection.Input;
                MySqlParameter cli_venta = cmd.Parameters.Add("cli_venta", MySqlDbType.VarChar, 15);
                cli_venta.Direction = ParameterDirection.Input;
                MySqlParameter fecha_venta = cmd.Parameters.Add("fecha_venta", MySqlDbType.Date);
                fecha_venta.Direction = ParameterDirection.Input;
                MySqlParameter tipo_venta = cmd.Parameters.Add("tipo_venta", MySqlDbType.Int32);
                tipo_venta.Direction = ParameterDirection.Input;
                MySqlParameter num_venta = cmd.Parameters.Add("num_venta", MySqlDbType.VarChar, 20);
                num_venta.Direction = ParameterDirection.Input;
                MySqlParameter doc_venta = cmd.Parameters.Add("doc_venta", MySqlDbType.VarChar, 20);
                doc_venta.Direction = ParameterDirection.Input;
                MySqlParameter pago_venta = cmd.Parameters.Add("pago_venta", MySqlDbType.Int32);
                pago_venta.Direction = ParameterDirection.Input;
                MySqlParameter desc_venta = cmd.Parameters.Add("desc_venta", MySqlDbType.Decimal);
                desc_venta.Direction = ParameterDirection.Input;
                MySqlParameter subtotal_venta = cmd.Parameters.Add("subtotal_venta", MySqlDbType.Decimal);
                subtotal_venta.Direction = ParameterDirection.Input;
                MySqlParameter cesc_venta = cmd.Parameters.Add("cesc_venta", MySqlDbType.Decimal);
                cesc_venta.Direction = ParameterDirection.Input;
                MySqlParameter total_venta = cmd.Parameters.Add("total_venta", MySqlDbType.Decimal);
                total_venta.Direction = ParameterDirection.Input;
                MySqlParameter iva_venta = cmd.Parameters.Add("iva_venta", MySqlDbType.Decimal);
                iva_venta.Direction = ParameterDirection.Input;
                MySqlParameter iva_desc = cmd.Parameters.Add("iva_desc", MySqlDbType.Decimal);
                iva_desc.Direction = ParameterDirection.Input;
                MySqlParameter cat_venta = cmd.Parameters.Add("cat_venta", MySqlDbType.VarChar, 50);
                cat_venta.Direction = ParameterDirection.Input;
                MySqlParameter nivel_venta = cmd.Parameters.Add("nivel_venta", MySqlDbType.Int32);
                nivel_venta.Direction = ParameterDirection.Input;
                MySqlParameter nota_venta = cmd.Parameters.Add("nota_venta", MySqlDbType.VarChar, 100);
                nota_venta.Direction = ParameterDirection.Input;
                MySqlParameter items_venta = cmd.Parameters.Add("items_venta", MySqlDbType.LongText);
                items_venta.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idventa.Value = venta.ID_VENTA;
                suc_venta.Value = venta.COD_SUC;
                cli_venta.Value = venta.COD_CLIENTE;
                fecha_venta.Value = venta.FECHA.Date;
                tipo_venta.Value = (int)venta.TIPO;
                num_venta.Value = venta.NUMVENTA;
                doc_venta.Value = venta.DOCUMENTO;
                pago_venta.Value = (int)venta.TIPO_PAGO;
                desc_venta.Value = venta.DESCUENTO;
                subtotal_venta.Value = venta.SUBTOTAL;
                cesc_venta.Value = venta.CESC;
                total_venta.Value = venta.TOTAL;
                iva_venta.Value = venta.IVA;
                iva_desc.Value = venta.IVA_DESC;
                cat_venta.Value = venta.CATEGORIA.ToString();
                nivel_venta.Value = (int)venta.NIVEL;
                nota_venta.Value = venta.NOTA;

                items_venta.Value = buildItemsVenta(venta);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("VENTA ACTUALIZADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public void changeFCF(int venta, string fcf)
        {
            try
            {
                string sql = "prendasal.SP_CHANGE_FCF_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idventa = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                idventa.Direction = ParameterDirection.Input;
                MySqlParameter factura = cmd.Parameters.Add("fcf", MySqlDbType.VarChar, 20);
                factura.Direction = ParameterDirection.Input;

                idventa.Value = venta;
                factura.Value = fcf;

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR FACTURA P.A.C", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public bool delete(Venta venta, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idventa = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                idventa.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idventa.Value = venta.ID_VENTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE VENTA ELIMINADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR VENTA ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public string nextNumVenta(string codsuc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_NUMVENTA(@sucursal)";
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



        public DataTable getItemsVenta(Venta venta)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_ITEMS_VENTA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idventa = cmd.Parameters.Add("idventa", MySqlDbType.Int32);
                idventa.Direction = ParameterDirection.Input;

                idventa.Value = venta.ID_VENTA;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL CONSULTAR DETALLE DE VENTA", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        

        public DataRow getVentaByNumVenta(string documento)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_ventas WHERE NUMVENTA = @doc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter doc = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                doc.Direction = ParameterDirection.Input;

                doc.Value = documento;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL OBTENER VENTA", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }


    }
}
