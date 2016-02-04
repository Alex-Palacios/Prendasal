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
                            + row.Field<string>("CONTRATO") + "&";
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
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR LISTA DE VENCIDO" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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






        public DataTable getVencidos(string codsuc, int diastrans,eCategoria? categoria)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_VENCIDOS;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter dias = cmd.Parameters.Add("dias", MySqlDbType.Int32);
                dias.Direction = ParameterDirection.Input;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar,20);
                cat.Direction = ParameterDirection.Input;
                
                suc.Value = codsuc;
                dias.Value = diastrans;
                cat.Value = categoria.ToString();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR CONTRATOS VENCIDOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        public DataTable showListaVencByFecha(DateTime fecha)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_SHOW_LISTAVENC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter fecha_venc = cmd.Parameters.Add("fecha_venc", MySqlDbType.Date);
                fecha_venc.Direction = ParameterDirection.Input;


                fecha_venc.Value = fecha.Date;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL CONSULTAR LISTAS DE VENCIDOS\nDetalle:" +e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos; ;
        }





        public bool reactivar(int prestamo,DateTime fecha, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_REACTIVAR_CONTRATO";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.Int32);
                idprestamo.Direction = ParameterDirection.Input;
                MySqlParameter fecha_r = cmd.Parameters.Add("fecha_r", MySqlDbType.Date);
                fecha_r.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idprestamo.Value = prestamo;
                fecha_r.Value = fecha.Date;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CONTRATO HA SIDO REACTIVADO ", "REACTIVACION DE CONTRATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REACTIVAR CONTRATO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



    }
}
