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


    public class DBMovCash
    {
        private DBConexion conn;

        public DBMovCash()
        {
            conn = DBConexion.Instance();
        }



        // FUNCIONES CRUD
        

        public string nextComprobantePRENDASAL(string suc , eTipoMovCash mov)
        {
            string reader = null;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT prendasal.FN_NEXT_TICKET_MOV_CASH(@tipodoc,@tipomov,@sucursal)";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter tipomov = cmd.Parameters.Add("tipomov", MySqlDbType.Int32);
                tipomov.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;


                tipodoc.Value = (int)eTipoDocMovCash.TICKET;
                tipomov.Value = (int)mov;
                sucursal.Value = suc;

                reader = (string)cmd.ExecuteScalar();
            }
            catch (Exception e)
            { reader = null; }
            return reader;
        }


        public DataTable FinancBySucPRENDASAL(string sucursal, DateTime fecha)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_ingresos_egresos WHERE TIPO_MOV = @tipo AND SUC_DEST = @suc AND YEAR(FECHA) = @fechaF ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter fechaF = cmd.Parameters.Add("fechaF", MySqlDbType.Int32);
                fechaF.Direction = ParameterDirection.Input;
                
                tipo.Value = (int)eTipoMovCash.FINANCIAMIENTO;
                suc.Value = sucursal;
                fechaF.Value = fecha.Date.ToString("yyyy");

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL LISTAR FINANCIAMIENTOS \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable RemesaBySucPRENDASAL(string sucursal, DateTime fecha)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_ingresos_egresos WHERE TIPO_MOV = @tipo AND SUC_ORG = @suc AND YEAR(FECHA) = @fechaR ORDER BY FECHA DESC;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter tipo = cmd.Parameters.Add("tipo", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter fechaR = cmd.Parameters.Add("fechaR", MySqlDbType.Int32);
                fechaR.Direction = ParameterDirection.Input;

                tipo.Value = (int)eTipoMovCash.REMESA;
                suc.Value = sucursal;
                fechaR.Value = fecha.Date.ToString("yyyy");

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL LISTAR REMESAS \n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public void insertPRENDASAL(MovCash mov, string sucursal, string empleado, string sistema)
        {

            try
            {
                string sql = "prendasal.SP_REGISTRAR_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter tipomov = cmd.Parameters.Add("tipomov", MySqlDbType.Int32);
                tipomov.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter documento = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                documento.Direction = ParameterDirection.Input;
                MySqlParameter total = cmd.Parameters.Add("total_mov", MySqlDbType.Decimal);
                total.Direction = ParameterDirection.Input;
                MySqlParameter suc_destino = cmd.Parameters.Add("suc_destino", MySqlDbType.VarChar, 2);
                suc_destino.Direction = ParameterDirection.Input;
                MySqlParameter enviado = cmd.Parameters.Add("enviado", MySqlDbType.VarChar, 50);
                enviado.Direction = ParameterDirection.Input;
                MySqlParameter suc_mov = cmd.Parameters.Add("suc_mov", MySqlDbType.VarChar, 2);
                suc_mov.Direction = ParameterDirection.Input;
                MySqlParameter retirado = cmd.Parameters.Add("retirado", MySqlDbType.VarChar, 50);
                retirado.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado_mov", MySqlDbType.Int32);
                estado.Direction = ParameterDirection.Input;
                MySqlParameter ok = cmd.Parameters.Add("ok", MySqlDbType.Bit);
                ok.Direction = ParameterDirection.Input;
                MySqlParameter nota = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                nota.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                fecha.Value = mov.FECHA.Date.ToString("yyyy-MM-dd");
                tipomov.Value = (int)mov.TIPO_MOV;
                tipodoc.Value = (int)mov.TIPO_DOC;
                documento.Value = mov.DOCUMENTO;
                total.Value = mov.TOTAL;
                suc_destino.Value = mov.SUC_DESTINO;
                suc_mov.Value = mov.SUC_ORIGEN;
                enviado.Value = mov.RESPONSABLE_ENVIO;
                retirado.Value = mov.RESPONSABLE_RECIBE;
                estado.Value = (int)mov.ESTADO;
                ok.Value = mov.RECIBIDO;
                nota.Value = mov.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show(mov.TIPO_MOV.ToString() + " REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL REGISTRAR " + mov.TIPO_MOV.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




        public void updatePRENDASAL(MovCash mov, string sucursal, string empleado, string sistema)
        {
            try
            {

                string sql = "prendasal.SP_EDITAR_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter idmov = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                idmov.Direction = ParameterDirection.Input;
                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter tipomov = cmd.Parameters.Add("tipomov", MySqlDbType.Int32);
                tipomov.Direction = ParameterDirection.Input;
                MySqlParameter tipodoc = cmd.Parameters.Add("tipodoc", MySqlDbType.Int32);
                tipodoc.Direction = ParameterDirection.Input;
                MySqlParameter documento = cmd.Parameters.Add("doc", MySqlDbType.VarChar, 20);
                documento.Direction = ParameterDirection.Input;
                MySqlParameter total = cmd.Parameters.Add("total_mov", MySqlDbType.Decimal);
                total.Direction = ParameterDirection.Input;
                MySqlParameter suc_destino = cmd.Parameters.Add("suc_destino", MySqlDbType.VarChar, 2);
                suc_destino.Direction = ParameterDirection.Input;
                MySqlParameter enviado = cmd.Parameters.Add("enviado", MySqlDbType.VarChar, 50);
                enviado.Direction = ParameterDirection.Input;
                MySqlParameter suc_mov = cmd.Parameters.Add("suc_mov", MySqlDbType.VarChar, 2);
                suc_mov.Direction = ParameterDirection.Input;
                MySqlParameter retirado = cmd.Parameters.Add("retirado", MySqlDbType.VarChar, 50);
                retirado.Direction = ParameterDirection.Input;
                MySqlParameter estado = cmd.Parameters.Add("estado_mov", MySqlDbType.Int32);
                estado.Direction = ParameterDirection.Input;
                MySqlParameter ok = cmd.Parameters.Add("ok", MySqlDbType.Bit);
                ok.Direction = ParameterDirection.Input;
                MySqlParameter nota = cmd.Parameters.Add("observacion", MySqlDbType.VarChar, 100);
                nota.Direction = ParameterDirection.Input;
                MySqlParameter suc = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                idmov.Value = mov.ID_MOV;
                fecha.Value = mov.FECHA.Date.ToString("yyyy-MM-dd");
                tipomov.Value = (int)mov.TIPO_MOV;
                tipodoc.Value = (int)mov.TIPO_DOC;
                documento.Value = mov.DOCUMENTO;
                total.Value = mov.TOTAL;
                suc_destino.Value = mov.SUC_DESTINO;
                suc_mov.Value = mov.SUC_ORIGEN;
                enviado.Value = mov.RESPONSABLE_ENVIO;
                retirado.Value = mov.RESPONSABLE_RECIBE;
                estado.Value = (int)mov.ESTADO;
                ok.Value = mov.RECIBIDO;
                nota.Value = mov.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                system.Value = sistema;


                notaCambio.Value = mov.NOTA_CAMBIO;

                cmd.ExecuteNonQuery();
                MessageBox.Show(mov.TIPO_MOV.ToString() + " ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "ERROR AL ACTUALIZAR " + mov.TIPO_MOV.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public void deletePRENDASAL(MovCash mov, string suc, string emp, string sistema)
        {
            try
            {
                string sql = "prendasal.SP_ELIMINAR_MOV_CASH";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter id = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                MySqlParameter tipo = cmd.Parameters.Add("tipoMov", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                id.Value = mov.ID_MOV;
                tipo.Value = (int) mov.TIPO_MOV;
                notaCambio.Value = mov.NOTA_CAMBIO;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO DE " + mov.ID_MOV.ToString() + " ELIMINADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR " + mov.ID_MOV.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }


    }
}
