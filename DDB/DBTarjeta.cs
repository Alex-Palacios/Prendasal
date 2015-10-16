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

    public class DBTarjeta
    {
        private DBConexion conn;

        public DBTarjeta()
        {
            conn = DBConexion.Instance();
        }

        public void insert(Tarjeta tarjeta, string suc, string emp, string sys)
        {
            try
            {
                string sql = "prendasal.SP_REGISTRAR_TARJETA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter numero = cmd.Parameters.Add("numero", MySqlDbType.VarChar, 50);
                numero.Direction = ParameterDirection.Input;
                MySqlParameter cliente = cmd.Parameters.Add("cliente", MySqlDbType.VarChar, 15);
                cliente.Direction = ParameterDirection.Input;
                MySqlParameter fechaExp = cmd.Parameters.Add("fechaExp", MySqlDbType.Date);
                fechaExp.Direction = ParameterDirection.Input;
                MySqlParameter tipoT = cmd.Parameters.Add("tipoT", MySqlDbType.Int32);
                tipoT.Direction = ParameterDirection.Input;
                MySqlParameter fechaReno = cmd.Parameters.Add("fechaReno", MySqlDbType.Date);
                fechaReno.Direction = ParameterDirection.Input;
                MySqlParameter fechaVenc = cmd.Parameters.Add("fechaVenc", MySqlDbType.Date);
                fechaVenc.Direction = ParameterDirection.Input; 
                MySqlParameter t_mensual = cmd.Parameters.Add("t_mensual", MySqlDbType.Double);
                t_mensual.Direction = ParameterDirection.Input;
                MySqlParameter t_15 = cmd.Parameters.Add("t_15", MySqlDbType.Double);
                t_15.Direction = ParameterDirection.Input;
                MySqlParameter p_contrato = cmd.Parameters.Add("p_contrato", MySqlDbType.Int32);
                p_contrato.Direction = ParameterDirection.Input;
                MySqlParameter p_vencido = cmd.Parameters.Add("p_vencido", MySqlDbType.Int32);
                p_vencido.Direction = ParameterDirection.Input;
                MySqlParameter descuento_c = cmd.Parameters.Add("descuento_c", MySqlDbType.Double);
                descuento_c.Direction = ParameterDirection.Input;
                MySqlParameter descuento_i = cmd.Parameters.Add("descuento_i", MySqlDbType.Double);
                descuento_i.Direction = ParameterDirection.Input;
                MySqlParameter puntos_d = cmd.Parameters.Add("puntos_d", MySqlDbType.Double);
                puntos_d.Direction = ParameterDirection.Input;
                MySqlParameter puntos_v = cmd.Parameters.Add("puntos_v", MySqlDbType.Decimal);
                puntos_v.Direction = ParameterDirection.Input;
                MySqlParameter activa = cmd.Parameters.Add("activaT", MySqlDbType.Bit);
                activa.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                numero.Value = tarjeta.NUMTARJETA;
                cliente.Value = tarjeta.COD_CLIENTE;
                fechaExp.Value = tarjeta.FECHA_EXP;
                tipoT.Value = (int) tarjeta.TIPO;
                fechaReno.Value = tarjeta.FECHA_RENO;
                fechaVenc.Value = tarjeta.FECHA_VENC;
                t_mensual.Value = tarjeta.TASA_MENSUAL;
                p_contrato.Value = tarjeta.PLAZO_CONTRATO;
                p_vencido.Value = tarjeta.PLAZO_VENCIDO;
                descuento_c.Value = tarjeta.DESC_COMPRA;
                descuento_i.Value = tarjeta.DESC_INTERES;
                puntos_d.Value = tarjeta.PUNTOS_DOLAR;
                puntos_v.Value = tarjeta.PUNTOS_VALOR;
                activa.Value = tarjeta.ACTIVA;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;
                cmd.ExecuteNonQuery();
                MessageBox.Show("TARJETA REGISTRADA", "OPERACION FINALIZADA " + tarjeta.TIPO.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR TARJETA " + tarjeta.TIPO.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }


        public void update(Tarjeta tarjeta, string suc, string emp, string sys)
        {
            try
            {
                string sql = "prendasal.SP_UPDATE_TARJETA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter numero = cmd.Parameters.Add("numero", MySqlDbType.VarChar, 50);
                numero.Direction = ParameterDirection.Input;
                MySqlParameter cliente = cmd.Parameters.Add("cliente", MySqlDbType.VarChar, 15);
                cliente.Direction = ParameterDirection.Input;
                MySqlParameter fechaExp = cmd.Parameters.Add("fechaExp", MySqlDbType.Date);
                fechaExp.Direction = ParameterDirection.Input;
                MySqlParameter tipoT = cmd.Parameters.Add("tipoT", MySqlDbType.Int32);
                tipoT.Direction = ParameterDirection.Input;
                MySqlParameter fechaReno = cmd.Parameters.Add("fechaReno", MySqlDbType.Date);
                fechaReno.Direction = ParameterDirection.Input;
                MySqlParameter fechaVenc = cmd.Parameters.Add("fechaVenc", MySqlDbType.Date);
                fechaVenc.Direction = ParameterDirection.Input;
                MySqlParameter t_mensual = cmd.Parameters.Add("t_mensual", MySqlDbType.Double);
                t_mensual.Direction = ParameterDirection.Input;
                MySqlParameter t_15 = cmd.Parameters.Add("t_15", MySqlDbType.Double);
                t_15.Direction = ParameterDirection.Input;
                MySqlParameter p_contrato = cmd.Parameters.Add("p_contrato", MySqlDbType.Int32);
                p_contrato.Direction = ParameterDirection.Input;
                MySqlParameter p_vencido = cmd.Parameters.Add("p_vencido", MySqlDbType.Int32);
                p_vencido.Direction = ParameterDirection.Input;
                MySqlParameter descuento_c = cmd.Parameters.Add("descuento_c", MySqlDbType.Double);
                descuento_c.Direction = ParameterDirection.Input;
                MySqlParameter descuento_i = cmd.Parameters.Add("descuento_i", MySqlDbType.Double);
                descuento_i.Direction = ParameterDirection.Input;
                MySqlParameter puntos_d = cmd.Parameters.Add("puntos_d", MySqlDbType.Double);
                puntos_d.Direction = ParameterDirection.Input;
                MySqlParameter puntos_v = cmd.Parameters.Add("puntos_v", MySqlDbType.Decimal);
                puntos_v.Direction = ParameterDirection.Input;
                MySqlParameter activa = cmd.Parameters.Add("activaT", MySqlDbType.Bit);
                activa.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;

                numero.Value = tarjeta.NUMTARJETA;
                cliente.Value = tarjeta.COD_CLIENTE;
                fechaExp.Value = tarjeta.FECHA_EXP;
                tipoT.Value = (int)tarjeta.TIPO;
                fechaReno.Value = tarjeta.FECHA_RENO;
                fechaVenc.Value = tarjeta.FECHA_VENC;
                t_mensual.Value = tarjeta.TASA_MENSUAL;
                p_contrato.Value = tarjeta.PLAZO_CONTRATO;
                p_vencido.Value = tarjeta.PLAZO_VENCIDO;
                descuento_c.Value = tarjeta.DESC_COMPRA;
                descuento_i.Value = tarjeta.DESC_INTERES;
                puntos_d.Value = tarjeta.PUNTOS_DOLAR;
                puntos_v.Value = tarjeta.PUNTOS_VALOR;
                activa.Value = tarjeta.ACTIVA;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("DATOS DE TARJETA ACTUALIZADOS", "OPERACION FINALIZADA" + tarjeta.TIPO.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR TARJETA " + tarjeta.TIPO.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }



        public void changeNUMTARJETA(string oldCodigo, string newCodigo, string suc, string emp,string sys)
        {
            try
            {
                string sql = "prendasal.SP_CHANGE_NUM_TARJETA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigoOld = cmd.Parameters.Add("OLDCODIGO", MySqlDbType.VarChar, 50);
                codigoOld.Direction = ParameterDirection.Input;
                MySqlParameter codigoNew = cmd.Parameters.Add("NEWCODIGO", MySqlDbType.VarChar, 50);
                codigoNew.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                codigoOld.Value = oldCodigo;
                codigoNew.Value = newCodigo;


                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CODIGO DE PRODUCTO " + oldCodigo + " CAMBIADO A " + newCodigo, "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CAMBIAR EL CODIGO DEL PRODUCTO " + oldCodigo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }




        public void delete(Tarjeta tarjeta, string suc, string emp, string sys)
        {
            try
            {
                string sql = "prendasal.SP_DELETE_TARJETA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter numero = cmd.Parameters.Add("numero", MySqlDbType.VarChar, 50);
                numero.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;
                MySqlParameter notaCambio = cmd.Parameters.Add("notaCambio", MySqlDbType.VarChar, 100);
                notaCambio.Direction = ParameterDirection.Input;


                numero.Value = tarjeta.NUMTARJETA;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("TARJETA "+tarjeta.TIPO.ToString() +" #: " + tarjeta.NUMTARJETA + " ELIMINADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR TARJETA " + tarjeta.TIPO.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }


        public DataTable findByNumTarjeta(string num ,eNIVEL tipoT)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.SP_GET_TARJETA";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter numero = cmd.Parameters.Add("numero", MySqlDbType.VarChar, 50);
                numero.Direction = ParameterDirection.Input;
                MySqlParameter tipo = cmd.Parameters.Add("tipoT", MySqlDbType.Int32);
                tipo.Direction = ParameterDirection.Input;

                numero.Value = num;
                tipo.Value = (int)tipoT;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR TARJETA "+tipoT.ToString()+"\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



    }
}
