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

    public class DBPac
    {
        private DBConexion conn;

        public DBPac()
        {
            conn = DBConexion.Instance();
        }

        
        // FUNCIONES CRUD        
        public bool insert(Pac pac, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_PAC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter suc_pac = cmd.Parameters.Add("suc_pac", MySqlDbType.VarChar, 2);
                suc_pac.Direction = ParameterDirection.Input;
                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.VarChar, 15);
                idprestamo.Direction = ParameterDirection.Input;
                MySqlParameter fecha_pac = cmd.Parameters.Add("fecha_pac", MySqlDbType.Date);
                fecha_pac.Direction = ParameterDirection.Input;
                MySqlParameter tipo_pac = cmd.Parameters.Add("tipo_pac", MySqlDbType.Int32);
                tipo_pac.Direction = ParameterDirection.Input;
                MySqlParameter recibo_pac = cmd.Parameters.Add("recibo_pac", MySqlDbType.VarChar, 20);
                recibo_pac.Direction = ParameterDirection.Input;
                MySqlParameter doc_pac = cmd.Parameters.Add("doc_pac", MySqlDbType.VarChar, 20);
                doc_pac.Direction = ParameterDirection.Input;
                MySqlParameter pago_pac = cmd.Parameters.Add("pago_pac", MySqlDbType.Int32);
                pago_pac.Direction = ParameterDirection.Input;
                MySqlParameter meses_pac = cmd.Parameters.Add("meses_pac", MySqlDbType.Int32);
                meses_pac.Direction = ParameterDirection.Input;
                MySqlParameter dias_pac = cmd.Parameters.Add("dias_pac", MySqlDbType.Int32);
                dias_pac.Direction = ParameterDirection.Input;
                MySqlParameter interes_pac = cmd.Parameters.Add("interes_pac", MySqlDbType.Decimal);
                interes_pac.Direction = ParameterDirection.Input;
                MySqlParameter desc_pac = cmd.Parameters.Add("desc_pac", MySqlDbType.Decimal);
                desc_pac.Direction = ParameterDirection.Input;
                MySqlParameter abono_pac = cmd.Parameters.Add("abono_pac", MySqlDbType.Decimal);
                abono_pac.Direction = ParameterDirection.Input;
                MySqlParameter total_pac = cmd.Parameters.Add("total_pac", MySqlDbType.Decimal);
                total_pac.Direction = ParameterDirection.Input;
                MySqlParameter imp_interes = cmd.Parameters.Add("imp_interes", MySqlDbType.Decimal);
                imp_interes.Direction = ParameterDirection.Input;
                MySqlParameter imp_desc = cmd.Parameters.Add("imp_desc", MySqlDbType.Decimal);
                imp_desc.Direction = ParameterDirection.Input;
                MySqlParameter nivel_pac = cmd.Parameters.Add("nivel_pac", MySqlDbType.Int32);
                nivel_pac.Direction = ParameterDirection.Input;
                MySqlParameter nota_pac = cmd.Parameters.Add("nota_pac", MySqlDbType.VarChar, 100);
                nota_pac.Direction = ParameterDirection.Input;

                MySqlParameter idcupon = cmd.Parameters.Add("idcupon", MySqlDbType.Int32);
                idcupon.Direction = ParameterDirection.Input;
                MySqlParameter numcupon = cmd.Parameters.Add("numcupon", MySqlDbType.Int32);
                numcupon.Direction = ParameterDirection.Input;

                MySqlParameter items_pac = cmd.Parameters.Add("items_pac", MySqlDbType.LongText);
                items_pac.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                suc_pac.Value = pac.COD_SUC;
                idprestamo.Value = pac.ID_PRESTAMO;
                fecha_pac.Value = pac.FECHA.Date;
                recibo_pac.Value = pac.RECIBO;
                pago_pac.Value = (int)pac.TIPO_PAGO;
                doc_pac.Value = pac.DOCUMENTO;
                tipo_pac.Value = (int) pac.TIPO;
                meses_pac.Value = pac.MESES;
                dias_pac.Value = pac.DIAS;
                interes_pac.Value = pac.INTERES;
                desc_pac.Value = pac.DESCUENTO;
                abono_pac.Value = pac.ABONO;
                total_pac.Value = pac.TOTAL;
                imp_interes.Value = pac.IVA;
                imp_desc.Value = pac.IVA_DESC;
                nivel_pac.Value = (int)pac.NIVEL;
                nota_pac.Value = pac.NOTA;

                if (pac.CUPON_CANJE != null)
                {
                    idcupon.Value = pac.CUPON_CANJE.ID_CUPON;
                    numcupon.Value = pac.CUPON_CANJE.NUMCUPON;
                }

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();

                MessageBox.Show("P.A.C REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR P.A.C", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public void changeFCF(int pac,string fcf)
        {
            try
            {
                string sql = "prendasal.SP_CHANGE_FCF_PAC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idpac = cmd.Parameters.Add("idpac", MySqlDbType.Int32);
                idpac.Direction = ParameterDirection.Input;
                MySqlParameter factura = cmd.Parameters.Add("fcf", MySqlDbType.VarChar, 20);
                factura.Direction = ParameterDirection.Input;

                idpac.Value = pac;
                factura.Value = fcf;

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR FACTURA P.A.C", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




        public bool delete(Pac pac, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_PAC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idpac = cmd.Parameters.Add("idpac", MySqlDbType.Int32);
                idpac.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idpac.Value = pac.ID_PAC;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE P.A.C ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR P.A.C ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }







        public string nextReciboPAC(string codsuc)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_RECIBO_PAC(@sucursal)";
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



        public DataTable getHistorialPAC(Prestamo contrato)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_pac WHERE ID_PRESTAMO = @idprestamo AND ESTADO != 0; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter idprestamo = cmd.Parameters.Add("idprestamo", MySqlDbType.Int32);
                idprestamo.Direction = ParameterDirection.Input;

                idprestamo.Value = contrato.ID_PRESTAMO;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR HISTORIAL DE CONTRATO # " + contrato.DOCUMENTO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        


    }
}
