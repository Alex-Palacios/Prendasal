
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

    public class DBPrestamo
    {
        private DBConexion conn;

        public DBPrestamo()
        {
            conn = DBConexion.Instance();
        }




        private string buildItemsPrestamo(Prestamo prestamo)
        {
            string items = "";
            foreach (DataRow row in prestamo.ITEMS_PRESTAMO.Rows)
            {
                items = items + row.Field<string>("CATEGORIA") + ">"
                    + row.Field<string>("CODIGO") + ">"
                    + row.Field<string>("COD_ITEM") + ">"
                    + row.Field<string>("TIPO") + ">"
                    + row.Field<string>("MARCA") + ">"
                    + row.Field<string>("DESCRIPCION") + ">"
                    + row.Field<decimal>("CANTIDAD") + ">"
                    + row.Field<decimal>("MONTO") + "&";
            }
            return items;
        }

        // FUNCIONES CRUD
        
        public bool insert(Prestamo prestamo, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_PRESTAMO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_prestamo = cmd.Parameters.Add("suc_prestamo", MySqlDbType.VarChar, 2);
                suc_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter cli_prestamo = cmd.Parameters.Add("cli_prestamo", MySqlDbType.VarChar, 15);
                cli_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter fecha_prestamo = cmd.Parameters.Add("fecha_prestamo", MySqlDbType.Date);
                fecha_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter tipo_prestamo = cmd.Parameters.Add("tipo_prestamo", MySqlDbType.Int32);
                tipo_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter doc_prestamo = cmd.Parameters.Add("doc_prestamo", MySqlDbType.VarChar, 20);
                doc_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter pago_prestamo = cmd.Parameters.Add("pago_prestamo", MySqlDbType.Int32);
                pago_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter tasa_prestamo = cmd.Parameters.Add("tasa_prestamo", MySqlDbType.Decimal);
                tasa_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter plazo_prestamo = cmd.Parameters.Add("plazo_prestamo", MySqlDbType.Int32);
                plazo_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter plazovenc_prestamo = cmd.Parameters.Add("plazovenc_prestamo", MySqlDbType.Int32);
                plazovenc_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter total_prestamo = cmd.Parameters.Add("total_prestamo", MySqlDbType.Decimal);
                total_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter cat_prestamo = cmd.Parameters.Add("cat_prestamo", MySqlDbType.VarChar, 50);
                cat_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter nivel_prestamo = cmd.Parameters.Add("nivel_prestamo", MySqlDbType.Int32);
                nivel_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter nota_prestamo = cmd.Parameters.Add("nota_prestamo", MySqlDbType.VarChar, 100);
                nota_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter items_prestamo = cmd.Parameters.Add("items_prestamo", MySqlDbType.LongText);
                items_prestamo.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_prestamo.Value = prestamo.COD_SUC;
                cli_prestamo.Value = prestamo.COD_CLIENTE;
                fecha_prestamo.Value = prestamo.FECHA.Date;
                tipo_prestamo.Value = (int)prestamo.TIPO;
                doc_prestamo.Value = prestamo.DOCUMENTO;
                pago_prestamo.Value = (int)prestamo.TIPO_PAGO;
                tasa_prestamo.Value = prestamo.TASA_MENSUAL;
                plazo_prestamo.Value = prestamo.PLAZO_CONTRATO;
                plazovenc_prestamo.Value = prestamo.PLAZO_VENC;
                total_prestamo.Value = prestamo.TOTAL;
                cat_prestamo.Value = prestamo.CATEGORIA.ToString();
                nivel_prestamo.Value = (int) prestamo.NIVEL;
                nota_prestamo.Value = prestamo.NOTA;

                items_prestamo.Value = buildItemsPrestamo(prestamo);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("PRESTAMO REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(Prestamo prestamo, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_PRESTAMO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.Int32);
                idprestamo.Direction = ParameterDirection.Input;
                MySqlParameter suc_prestamo = cmd.Parameters.Add("suc_prestamo", MySqlDbType.VarChar, 2);
                suc_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter cli_prestamo = cmd.Parameters.Add("cli_prestamo", MySqlDbType.VarChar, 15);
                cli_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter fecha_prestamo = cmd.Parameters.Add("fecha_prestamo", MySqlDbType.Date);
                fecha_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter tipo_prestamo = cmd.Parameters.Add("tipo_prestamo", MySqlDbType.Int32);
                tipo_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter doc_prestamo = cmd.Parameters.Add("doc_prestamo", MySqlDbType.VarChar, 20);
                doc_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter pago_prestamo = cmd.Parameters.Add("pago_prestamo", MySqlDbType.Int32);
                pago_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter tasa_prestamo = cmd.Parameters.Add("tasa_prestamo", MySqlDbType.Decimal);
                tasa_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter plazo_prestamo = cmd.Parameters.Add("plazo_prestamo", MySqlDbType.Int32);
                plazo_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter plazovenc_prestamo = cmd.Parameters.Add("plazovenc_prestamo", MySqlDbType.Int32);
                plazovenc_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter total_prestamo = cmd.Parameters.Add("total_prestamo", MySqlDbType.Decimal);
                total_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter cat_prestamo = cmd.Parameters.Add("cat_prestamo", MySqlDbType.VarChar, 50);
                cat_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter nivel_prestamo = cmd.Parameters.Add("nivel_prestamo", MySqlDbType.Int32);
                nivel_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter nota_prestamo = cmd.Parameters.Add("nota_prestamo", MySqlDbType.VarChar, 100);
                nota_prestamo.Direction = ParameterDirection.Input;
                MySqlParameter items_prestamo = cmd.Parameters.Add("items_prestamo", MySqlDbType.LongText);
                items_prestamo.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idprestamo.Value = prestamo.ID_PRESTAMO;
                suc_prestamo.Value = prestamo.COD_SUC;
                cli_prestamo.Value = prestamo.COD_CLIENTE;
                fecha_prestamo.Value = prestamo.FECHA.Date;
                tipo_prestamo.Value = (int)prestamo.TIPO;
                doc_prestamo.Value = prestamo.DOCUMENTO;
                pago_prestamo.Value = (int)prestamo.TIPO_PAGO;
                tasa_prestamo.Value = prestamo.TASA_MENSUAL;
                plazo_prestamo.Value = prestamo.PLAZO_CONTRATO;
                plazovenc_prestamo.Value = prestamo.PLAZO_VENC;
                total_prestamo.Value = prestamo.TOTAL;
                cat_prestamo.Value = prestamo.CATEGORIA.ToString();
                nivel_prestamo.Value = (int)prestamo.NIVEL;
                nota_prestamo.Value = prestamo.NOTA;

                items_prestamo.Value = buildItemsPrestamo(prestamo);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("PRESTAMO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool delete(Prestamo prestamo, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_PRESTAMO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.Int32);
                idprestamo.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idprestamo.Value = prestamo.ID_PRESTAMO;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE PRESTAMO ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR PRESTAMO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public string nextContratoPrestamo(string codsuc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_CONTRATO_PRESTAMO(@sucursal)";
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



        public DataTable getItemsPrestamo(Prestamo prestamo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_ITEMS_PRESTAMO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.Int32);
                idprestamo.Direction = ParameterDirection.Input;

                idprestamo.Value = prestamo.ID_PRESTAMO;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL CONSULTAR DETALLE DE PRESTAMO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getKITCO(Prestamo prestamo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_KITCO_PRESTAMO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.Int32);
                idprestamo.Direction = ParameterDirection.Input;

                idprestamo.Value = prestamo.ID_PRESTAMO;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL OBTENER DETALLE KITCO DE PRESTAMO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataRow getContratoByDoc(string documento)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_contratos WHERE DOCUMENTO = @doc;";
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
                MessageBox.Show("ERROR AL OBTENER CONTRATO", "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }
        





    }
}
