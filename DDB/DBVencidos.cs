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

    public class DBVencidos
    {
        private DBConexion conn;

        public DBVencidos()
        {
            conn = DBConexion.Instance();
        }


        private string buildItemsVencidos(Vencidos venc)
        {
            string items = "";
            foreach (DataRow row in venc.CONTRATOS_VENCIDOS.Rows)
            {
                items = items + row.Field<int>("ID_PRESTAMO") + ">" 
                            + row.Field<string>("COD_TRANS") + ">"
                            + row.Field<DateTime>("FECHA") + ">" 
                            + row.Field<string>("DOCUMENTO") + ">"
                            + row.Field<string>("COD_SUC") + "&";
            }
            return items;
        }



        public bool insert(Vencidos venc, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_LISTAVENC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_venc = cmd.Parameters.Add("suc_venc", MySqlDbType.VarChar, 2);
                suc_venc.Direction = ParameterDirection.Input;
                MySqlParameter fecha_venc = cmd.Parameters.Add("fecha_venc", MySqlDbType.Date);
                fecha_venc.Direction = ParameterDirection.Input;
                MySqlParameter doc_venc = cmd.Parameters.Add("doc_venc", MySqlDbType.VarChar, 20);
                doc_venc.Direction = ParameterDirection.Input;
                MySqlParameter nota_venc = cmd.Parameters.Add("nota_venc", MySqlDbType.VarChar, 100);
                nota_venc.Direction = ParameterDirection.Input;

                MySqlParameter items_venc = cmd.Parameters.Add("items_venc", MySqlDbType.LongText);
                items_venc.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_venc.Value = venc.COD_SUC;
                fecha_venc.Value = venc.FECHA.Date;
                doc_venc.Value = venc.DOCUMENTO;
                nota_venc.Value = venc.NOTA;

                items_venc.Value = buildItemsVencidos(venc);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("LISTA DE VENCIDOS GENERADA CORRECTAMENTE", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL GENERAR LISTA DE VENCIDOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool update(Vencidos venc, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_LISTAVENC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idvenc = cmd.Parameters.Add("idvenc", MySqlDbType.Int32);
                idvenc.Direction = ParameterDirection.Input;
                MySqlParameter suc_venc = cmd.Parameters.Add("suc_venc", MySqlDbType.VarChar, 2);
                suc_venc.Direction = ParameterDirection.Input;
                MySqlParameter fecha_venc = cmd.Parameters.Add("fecha_venc", MySqlDbType.Date);
                fecha_venc.Direction = ParameterDirection.Input;
                MySqlParameter doc_venc = cmd.Parameters.Add("doc_venc", MySqlDbType.VarChar, 20);
                doc_venc.Direction = ParameterDirection.Input;
                MySqlParameter nota_venc = cmd.Parameters.Add("nota_venc", MySqlDbType.VarChar, 100);
                nota_venc.Direction = ParameterDirection.Input;

                MySqlParameter items_venc = cmd.Parameters.Add("items_venc", MySqlDbType.LongText);
                items_venc.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idvenc.Value = venc.ID_VENC;
                suc_venc.Value = venc.COD_SUC;
                fecha_venc.Value = venc.FECHA.Date;
                doc_venc.Value = venc.DOCUMENTO;
                nota_venc.Value = venc.NOTA;

                items_venc.Value = buildItemsVencidos(venc);

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("LISTA DE VENCIDOS ACTUALIZADA CORRECTAMENTE", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL GENERAR LISTA DE VENCIDOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool delete(Vencidos venc, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_LISTAVENC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idvenc = cmd.Parameters.Add("idvenc", MySqlDbType.Int32);
                idvenc.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idvenc.Value = venc.ID_VENC;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("LISTA DE VENCIDOS ELIMINADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR LISTA DE VENCIDO \n" + e.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public string nextListaVencidos(string codsuc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_LISTAVENC(@sucursal)";
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




        public DataTable getItemsVencidos(Vencidos venc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_vencidos WHERE ID_VENC LIKE @idvenc;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter idvenc = cmd.Parameters.Add("idvenc", MySqlDbType.Int32);
                idvenc.Direction = ParameterDirection.Input;
                idvenc.Value = venc.ID_VENC;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR LISTA DE VENCIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        public DataTable getKPMVencidos(Vencidos venc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_KPM_LISTAVENC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idvenc = cmd.Parameters.Add("idvenc", MySqlDbType.Int32);
                idvenc.Direction = ParameterDirection.Input;

                idvenc.Value = venc.ID_VENC;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL OBTENER DETALLE KMP EN LISTA DE VENCIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataRow getListaVencByDoc(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "prendasal.SP_GET_LISTAVENC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter doc_venc = cmd.Parameters.Add("doc_venc", MySqlDbType.VarChar, 20);
                doc_venc.Direction = ParameterDirection.Input;


                doc_venc.Value = doc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL BUSCAR LISTA DE VENCIDO # " + doc + "\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }







        public void reactivarContrato(string contrato,DateTime fechaR, string sucursal, string empleado, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_REACTIVAR_CONTRATO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter prestamo = cmd.Parameters.Add("contrato", MySqlDbType.VarChar,20);
                prestamo.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fechaR", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                prestamo.Value = contrato;
                fecha.Value = fechaR.Date;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CONTRATO #"+contrato+" HA SIDO REACTIVADO", "REACTIVACION DE CONTRATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL REACTIVAR CONTRATO #" + contrato + "\nDetalle: " + e.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



    }
}
