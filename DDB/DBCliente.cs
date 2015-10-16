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

    public class DBCliente
    {
        private DBConexion conn;

        public DBCliente()
        {
            conn = DBConexion.Instance();
        }



        public bool insert(Cliente cliente, string suc, string emp,string sys)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_CLIENTE";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter sucCli = cmd.Parameters.Add("sucCli", MySqlDbType.VarChar, 2);
                sucCli.Direction = ParameterDirection.Input;
                MySqlParameter fechaI = cmd.Parameters.Add("fechaI", MySqlDbType.Date);
                fechaI.Direction = ParameterDirection.Input;
                MySqlParameter nombreCli = cmd.Parameters.Add("nombreCli", MySqlDbType.VarChar, 100);
                nombreCli.Direction = ParameterDirection.Input;
                MySqlParameter sexoCli = cmd.Parameters.Add("sexoCli", MySqlDbType.VarChar, 1);
                sexoCli.Direction = ParameterDirection.Input;
                MySqlParameter fechaN = cmd.Parameters.Add("fechaN", MySqlDbType.Date);
                fechaN.Direction = ParameterDirection.Input;
                MySqlParameter nitCli = cmd.Parameters.Add("nitCli", MySqlDbType.VarChar, 17);
                nitCli.Direction = ParameterDirection.Input;
                MySqlParameter duiCli = cmd.Parameters.Add("duiCli", MySqlDbType.VarChar, 10);
                duiCli.Direction = ParameterDirection.Input;
                MySqlParameter licenciaCli = cmd.Parameters.Add("licenciaCli", MySqlDbType.VarChar, 25);
                licenciaCli.Direction = ParameterDirection.Input;
                MySqlParameter pasaporteCli = cmd.Parameters.Add("pasaporteCli", MySqlDbType.VarChar, 25);
                pasaporteCli.Direction = ParameterDirection.Input;
                MySqlParameter carnetCli = cmd.Parameters.Add("carnetCli", MySqlDbType.VarChar, 25);
                carnetCli.Direction = ParameterDirection.Input;
                MySqlParameter extCli = cmd.Parameters.Add("extCli", MySqlDbType.VarChar, 4);
                extCli.Direction = ParameterDirection.Input;
                MySqlParameter fechaV = cmd.Parameters.Add("fechaV", MySqlDbType.Date);
                fechaV.Direction = ParameterDirection.Input;
                MySqlParameter profesionCli = cmd.Parameters.Add("profesionCli", MySqlDbType.VarChar, 50);
                profesionCli.Direction = ParameterDirection.Input;
                MySqlParameter telCli = cmd.Parameters.Add("telCli", MySqlDbType.VarChar, 20);
                telCli.Direction = ParameterDirection.Input;
                MySqlParameter emailCli = cmd.Parameters.Add("emailCli", MySqlDbType.VarChar, 50);
                emailCli.Direction = ParameterDirection.Input;
                MySqlParameter municipioCli = cmd.Parameters.Add("municipioCli", MySqlDbType.VarChar, 4);
                municipioCli.Direction = ParameterDirection.Input;
                MySqlParameter direccionCli = cmd.Parameters.Add("direccionCli", MySqlDbType.VarChar, 100);
                direccionCli.Direction = ParameterDirection.Input;
                MySqlParameter contactoCli = cmd.Parameters.Add("contactoCli", MySqlDbType.VarChar, 100);
                contactoCli.Direction = ParameterDirection.Input;
                MySqlParameter telContactoCli = cmd.Parameters.Add("telContactoCli", MySqlDbType.VarChar, 20);
                telContactoCli.Direction = ParameterDirection.Input;
                MySqlParameter notaCli = cmd.Parameters.Add("notaCli", MySqlDbType.VarChar, 100);
                notaCli.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                sucCli.Value = cliente.COD_SUC;
                fechaI.Value = cliente.FECHA_INICIO;
                nombreCli.Value = cliente.CLIENTE;
                sexoCli.Value = cliente.SEXO;
                fechaN.Value = cliente.FECHA_NAC;
                nitCli.Value = cliente.NIT;
                duiCli.Value = cliente.DUI;
                pasaporteCli.Value = cliente.PASAPORTE;
                licenciaCli.Value = cliente.LICENCIA;
                carnetCli.Value = cliente.CARNET;
                extCli.Value = cliente.EXT;
                fechaV.Value = cliente.FECHA_VENC;
                profesionCli.Value = cliente.PROFESION;
                telCli.Value = cliente.TEL;
                emailCli.Value = cliente.EMAIL;
                municipioCli.Value = cliente.COD_MUNICIPIO;
                direccionCli.Value = cliente.DIRECCION;
                contactoCli.Value = cliente.CONTACTO;
                telContactoCli.Value = cliente.TEL_CONTACTO;
                notaCli.Value = cliente.NOTA;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CLIENTE REGISTRADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }



        public bool update(Cliente cliente, string suc, string emp, string sys)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_CLIENTE";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                codigo.Direction = ParameterDirection.Input;
                MySqlParameter nombreCli = cmd.Parameters.Add("nombreCli", MySqlDbType.VarChar, 100);
                nombreCli.Direction = ParameterDirection.Input;
                MySqlParameter sexoCli = cmd.Parameters.Add("sexoCli", MySqlDbType.VarChar, 1);
                sexoCli.Direction = ParameterDirection.Input;
                MySqlParameter fechaN = cmd.Parameters.Add("fechaN", MySqlDbType.Date);
                fechaN.Direction = ParameterDirection.Input;
                MySqlParameter nitCli = cmd.Parameters.Add("nitCli", MySqlDbType.VarChar, 17);
                nitCli.Direction = ParameterDirection.Input;
                MySqlParameter duiCli = cmd.Parameters.Add("duiCli", MySqlDbType.VarChar, 10);
                duiCli.Direction = ParameterDirection.Input;
                MySqlParameter licenciaCli = cmd.Parameters.Add("licenciaCli", MySqlDbType.VarChar, 25);
                licenciaCli.Direction = ParameterDirection.Input;
                MySqlParameter pasaporteCli = cmd.Parameters.Add("pasaporteCli", MySqlDbType.VarChar, 25);
                pasaporteCli.Direction = ParameterDirection.Input;
                MySqlParameter carnetCli = cmd.Parameters.Add("carnetCli", MySqlDbType.VarChar, 25);
                carnetCli.Direction = ParameterDirection.Input;
                MySqlParameter extCli = cmd.Parameters.Add("extCli", MySqlDbType.VarChar, 4);
                extCli.Direction = ParameterDirection.Input;
                MySqlParameter fechaV = cmd.Parameters.Add("fechaV", MySqlDbType.Date);
                fechaV.Direction = ParameterDirection.Input;
                MySqlParameter profesionCli = cmd.Parameters.Add("profesionCli", MySqlDbType.VarChar, 50);
                profesionCli.Direction = ParameterDirection.Input;
                MySqlParameter telCli = cmd.Parameters.Add("telCli", MySqlDbType.VarChar, 20);
                telCli.Direction = ParameterDirection.Input;
                MySqlParameter emailCli = cmd.Parameters.Add("emailCli", MySqlDbType.VarChar, 50);
                emailCli.Direction = ParameterDirection.Input;
                MySqlParameter municipioCli = cmd.Parameters.Add("municipioCli", MySqlDbType.VarChar, 4);
                municipioCli.Direction = ParameterDirection.Input;
                MySqlParameter direccionCli = cmd.Parameters.Add("direccionCli", MySqlDbType.VarChar, 100);
                direccionCli.Direction = ParameterDirection.Input;
                MySqlParameter contactoCli = cmd.Parameters.Add("contactoCli", MySqlDbType.VarChar, 100);
                contactoCli.Direction = ParameterDirection.Input;
                MySqlParameter telContactoCli = cmd.Parameters.Add("telContactoCli", MySqlDbType.VarChar, 20);
                telContactoCli.Direction = ParameterDirection.Input;
                MySqlParameter notaCli = cmd.Parameters.Add("notaCli", MySqlDbType.VarChar, 100);
                notaCli.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                codigo.Value = cliente.COD_CLIENTE;
                nombreCli.Value = cliente.CLIENTE;
                sexoCli.Value = cliente.SEXO;
                fechaN.Value = cliente.FECHA_NAC;
                nitCli.Value = cliente.NIT;
                duiCli.Value = cliente.DUI;
                pasaporteCli.Value = cliente.PASAPORTE;
                licenciaCli.Value = cliente.LICENCIA;
                carnetCli.Value = cliente.CARNET;
                extCli.Value = cliente.EXT;
                fechaV.Value = cliente.FECHA_VENC;
                profesionCli.Value = cliente.PROFESION;
                telCli.Value = cliente.TEL;
                emailCli.Value = cliente.EMAIL;
                municipioCli.Value = cliente.COD_MUNICIPIO;
                direccionCli.Value = cliente.DIRECCION;
                contactoCli.Value = cliente.CONTACTO;
                telContactoCli.Value = cliente.TEL_CONTACTO;
                notaCli.Value = cliente.NOTA;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("DATOS DE CLIENTE ACTUALIZADOS", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool delete(string cliente, string suc, string emp, string sys)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_CLIENTE";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter codigo = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                codigo.Direction = ParameterDirection.Input;

                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;
                MySqlParameter empleado = cmd.Parameters.Add("empleado", MySqlDbType.VarChar, 15);
                empleado.Direction = ParameterDirection.Input;
                MySqlParameter system = cmd.Parameters.Add("sistema", MySqlDbType.VarChar, 20);
                system.Direction = ParameterDirection.Input;

                
                codigo.Value = cliente;

                sucursal.Value = suc;
                empleado.Value = emp;
                system.Value = sys;

                cmd.ExecuteNonQuery();
                MessageBox.Show("CLIENTE : " + cliente + " ELIMINADO DE LA CARTERA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }





        public DataTable showClientes()
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LA CARTERA DE CLIENTES" , "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataRow findByCodigo(string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE COD_CLIENTE = @cod;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cod = cmd.Parameters.Add("cod", MySqlDbType.VarChar, 15);
                cod.Direction = ParameterDirection.Input;
                cod.Value = codigo + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }




        public DataRow findByDui(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                if (doc != null && doc != string.Empty)
                {
                    string sql = "SELECT * FROM prendasal.view_clientes WHERE DUI = @dui;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                    cmd.CommandType = CommandType.Text;

                    MySqlParameter dui = cmd.Parameters.Add("dui", MySqlDbType.VarChar, 10);
                    dui.Direction = ParameterDirection.Input;
                    dui.Value = doc;

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        datos.Load(reader);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL OBTENER CLIENTE" , "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }



        public DataRow findByLicencia(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                if (doc != null && doc != string.Empty)
                {
                    string sql = "SELECT * FROM prendasal.view_clientes WHERE LICENCIA = @lic;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                    cmd.CommandType = CommandType.Text;

                    MySqlParameter lic = cmd.Parameters.Add("lic", MySqlDbType.VarChar, 10);
                    lic.Direction = ParameterDirection.Input;
                    lic.Value = doc;

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        datos.Load(reader);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }



        public DataRow findByPasaporte(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE PASAPORTE = @pass;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter pass = cmd.Parameters.Add("pass", MySqlDbType.VarChar, 10);
                pass.Direction = ParameterDirection.Input;
                pass.Value = doc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }




        public DataRow findByCarnet(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            DataRow row = null;
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE CARNET = @cnt;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cnt = cmd.Parameters.Add("cnt", MySqlDbType.VarChar, 10);
                cnt.Direction = ParameterDirection.Input;
                cnt.Value = doc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (datos.Rows.Count == 1)
            {
                row = datos.Rows[0];
            }
            return row;
        }
       


        public DataTable findByFechaInicio(DateTime fechaI , string suc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE FECHA_INICIO = @fecha AND COD_SUC = @sucursal;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter fecha = cmd.Parameters.Add("fecha", MySqlDbType.Date);
                fecha.Direction = ParameterDirection.Input;
                MySqlParameter sucursal = cmd.Parameters.Add("sucursal", MySqlDbType.VarChar, 2);
                sucursal.Direction = ParameterDirection.Input;

                fecha.Value = fechaI.Date.ToString("yyyy-MM-dd");
                sucursal.Value = suc;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR LA CARTERA DE CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable findByNombreLIKE(string nombre)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE CLIENTE LIKE @cliente;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cliente = cmd.Parameters.Add("cliente", MySqlDbType.VarChar, 100);
                cliente.Direction = ParameterDirection.Input;
                cliente.Value = "%" + nombre + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        public DataTable findByCodigoLIKE(string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE COD_CLIENTE LIKE @codigo;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cod = cmd.Parameters.Add("codigo", MySqlDbType.VarChar, 15);
                cod.Direction = ParameterDirection.Input;
                cod.Value = codigo + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datos;
        }



        public DataTable findByDuiLIKE(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE DUI LIKE @dui;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter dui = cmd.Parameters.Add("dui", MySqlDbType.VarChar, 10);
                dui.Direction = ParameterDirection.Input;
                dui.Value = doc + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }


        public DataTable findByLicenciaLIKE(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE LICENCIA LIKE @lic;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter lic = cmd.Parameters.Add("lic", MySqlDbType.VarChar, 10);
                lic.Direction = ParameterDirection.Input;
                lic.Value = doc + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



        public DataTable findByPasaporteLIKE(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE PASAPORTE LIKE @pass;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter pass = cmd.Parameters.Add("pass", MySqlDbType.VarChar, 10);
                pass.Direction = ParameterDirection.Input;
                pass.Value = doc + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable findByCarnetLIKE(string doc)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_clientes WHERE CARNET LIKE @cnt;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;

                MySqlParameter cnt = cmd.Parameters.Add("cnt", MySqlDbType.VarChar, 10);
                cnt.Direction = ParameterDirection.Input;
                cnt.Value = doc + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL FILTRAR CLIENTES\n" + e.Message, "ERROR EN CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }



    




    }
}
