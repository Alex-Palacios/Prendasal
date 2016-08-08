﻿using System;
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

    public class DBInventario
    {
        private DBConexion conn;

        public DBInventario()
        {
            conn = DBConexion.Instance();
        }


        //FUNCIONES CRUD 
        //INVENTARIO INICIAL



        public bool insertInit(InvInicial inv, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_INSERT_INV_INICIAL";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter periodo_inv = cmd.Parameters.Add("periodo_inv", MySqlDbType.Int32);
                periodo_inv.Direction = ParameterDirection.Input;
                MySqlParameter bodega_inv = cmd.Parameters.Add("bodega_inv", MySqlDbType.VarChar, 2);
                bodega_inv.Direction = ParameterDirection.Input;
                MySqlParameter cat_inv = cmd.Parameters.Add("cat_inv", MySqlDbType.VarChar, 50);
                cat_inv.Direction = ParameterDirection.Input;
                MySqlParameter cod_inv = cmd.Parameters.Add("cod_inv", MySqlDbType.VarChar, 50);
                cod_inv.Direction = ParameterDirection.Input;
                MySqlParameter item_inv = cmd.Parameters.Add("item_inv", MySqlDbType.VarChar, 50);
                item_inv.Direction = ParameterDirection.Input;
                MySqlParameter tipo_inv = cmd.Parameters.Add("tipo_inv", MySqlDbType.VarChar, 20);
                tipo_inv.Direction = ParameterDirection.Input;
                MySqlParameter marca_inv = cmd.Parameters.Add("marca_inv", MySqlDbType.VarChar, 50);
                marca_inv.Direction = ParameterDirection.Input;
                MySqlParameter descrip_inv = cmd.Parameters.Add("descrip_inv", MySqlDbType.VarChar, 255);
                descrip_inv.Direction = ParameterDirection.Input;
                MySqlParameter cantidad_inv = cmd.Parameters.Add("cantidad_inv", MySqlDbType.Decimal);
                cantidad_inv.Direction = ParameterDirection.Input;
                MySqlParameter monto_inv = cmd.Parameters.Add("monto_inv", MySqlDbType.Decimal);
                monto_inv.Direction = ParameterDirection.Input;
                MySqlParameter nota_inv = cmd.Parameters.Add("nota_inv", MySqlDbType.VarChar, 255);
                nota_inv.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                periodo_inv.Value = inv.PERIODO;
                bodega_inv.Value = inv.BODEGA;
                cat_inv.Value = inv.CATEGORIA;
                cod_inv.Value = inv.CODIGO;
                item_inv.Value = inv.COD_ITEM;
                tipo_inv.Value = inv.TIPO;
                marca_inv.Value = inv.MARCA;
                descrip_inv.Value = inv.DESCRIPCION.Replace('>', '-').Replace('&', 'y');
                cantidad_inv.Value = inv.CANTIDAD;
                monto_inv.Value = inv.MONTO;
                nota_inv.Value = inv.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ITEM REGISTRADO EN INVENTARIO INICIAL", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL REGISTRADO ARTICULO EN INVENTARIO INICIAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }






        public bool updateInit(InvInicial inv, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_INV_INICIAL";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter idmov = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                idmov.Direction = ParameterDirection.Input;
                MySqlParameter bodega_inv = cmd.Parameters.Add("bodega_inv", MySqlDbType.VarChar, 2);
                bodega_inv.Direction = ParameterDirection.Input;
                MySqlParameter cat_inv = cmd.Parameters.Add("cat_inv", MySqlDbType.VarChar, 50);
                cat_inv.Direction = ParameterDirection.Input;
                MySqlParameter cod_inv = cmd.Parameters.Add("cod_inv", MySqlDbType.VarChar, 50);
                cod_inv.Direction = ParameterDirection.Input;
                MySqlParameter item_inv = cmd.Parameters.Add("item_inv", MySqlDbType.VarChar, 50);
                item_inv.Direction = ParameterDirection.Input;
                MySqlParameter tipo_inv = cmd.Parameters.Add("tipo_inv", MySqlDbType.VarChar, 20);
                tipo_inv.Direction = ParameterDirection.Input;
                MySqlParameter marca_inv = cmd.Parameters.Add("marca_inv", MySqlDbType.VarChar, 50);
                marca_inv.Direction = ParameterDirection.Input;
                MySqlParameter descrip_inv = cmd.Parameters.Add("descrip_inv", MySqlDbType.VarChar, 255);
                descrip_inv.Direction = ParameterDirection.Input;
                MySqlParameter cantidad_inv = cmd.Parameters.Add("cantidad_inv", MySqlDbType.Decimal);
                cantidad_inv.Direction = ParameterDirection.Input;
                MySqlParameter monto_inv = cmd.Parameters.Add("monto_inv", MySqlDbType.Decimal);
                monto_inv.Direction = ParameterDirection.Input;
                MySqlParameter nota_inv = cmd.Parameters.Add("nota_inv", MySqlDbType.VarChar, 255);
                nota_inv.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;


                idmov.Value = inv.ID_MOV;
                bodega_inv.Value = inv.BODEGA;
                cat_inv.Value = inv.CATEGORIA;
                cod_inv.Value = inv.CODIGO;
                item_inv.Value = inv.COD_ITEM;
                tipo_inv.Value = inv.TIPO;
                marca_inv.Value = inv.MARCA;
                descrip_inv.Value = inv.DESCRIPCION.Replace('>', '-').Replace('&', 'y');
                cantidad_inv.Value = inv.CANTIDAD;
                monto_inv.Value = inv.MONTO;
                nota_inv.Value = inv.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ITEM ACTUALIZADO DE INVENTARIO INICIAL", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR ARTICULO DE INVENTARIO INICIAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }




        public bool deleteInit(InvInicial inv, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_DELETE_INV_INICIAL";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter idmov = cmd.Parameters.Add("idmov", MySqlDbType.Int32);
                idmov.Direction = ParameterDirection.Input;
                MySqlParameter cat_inv = cmd.Parameters.Add("cat_inv", MySqlDbType.VarChar, 50);
                cat_inv.Direction = ParameterDirection.Input;
                MySqlParameter cod_inv = cmd.Parameters.Add("cod_inv", MySqlDbType.VarChar, 50);
                cod_inv.Direction = ParameterDirection.Input;
                

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                idmov.Value = inv.ID_MOV;
                cat_inv.Value = inv.CATEGORIA;
                cod_inv.Value = inv.CODIGO;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ITEM ELIMINADO DE INVENTARIO INICIAL", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ELIMINAR ARTICULO DE INVENTARIO INICIAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }


        


        public DataTable getInvInicialByPeriodo(int periodo,string categoria)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_inv_inicial WHERE PERIODO = @anio AND CATEGORIA = @cat;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter anio = cmd.Parameters.Add("anio", MySqlDbType.Int32);
                anio.Direction = ParameterDirection.Input;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 50);
                cat.Direction = ParameterDirection.Input;

                anio.Value = periodo;
                cat.Value = categoria;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR INVENTARIO INICIAL DE "+categoria +" DEL "+ + periodo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }

















        //EXISTENCIAS


        public bool updateArticuloInv(Existencia exist, string sucursal, string empleado, string sistema)
        {
            bool OK = true;
            try
            {
                string sql = "prendasal.SP_UPDATE_ARTICULO_INV";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter cod_inv = cmd.Parameters.Add("cod_inv", MySqlDbType.VarChar, 50);
                cod_inv.Direction = ParameterDirection.Input;
                MySqlParameter suc_inv = cmd.Parameters.Add("suc_inv", MySqlDbType.VarChar, 2);
                suc_inv.Direction = ParameterDirection.Input;
                MySqlParameter cat_inv = cmd.Parameters.Add("cat_inv", MySqlDbType.VarChar, 50);
                cat_inv.Direction = ParameterDirection.Input;
                MySqlParameter item_inv = cmd.Parameters.Add("item_inv", MySqlDbType.VarChar, 50);
                item_inv.Direction = ParameterDirection.Input;
                MySqlParameter tipo_inv = cmd.Parameters.Add("tipo_inv", MySqlDbType.VarChar, 20);
                tipo_inv.Direction = ParameterDirection.Input;
                MySqlParameter marca_inv = cmd.Parameters.Add("marca_inv", MySqlDbType.VarChar, 50);
                marca_inv.Direction = ParameterDirection.Input;
                MySqlParameter descrip_inv = cmd.Parameters.Add("descrip_inv", MySqlDbType.VarChar, 255);
                descrip_inv.Direction = ParameterDirection.Input;
                MySqlParameter precio_inv = cmd.Parameters.Add("precio_inv", MySqlDbType.Decimal);
                precio_inv.Direction = ParameterDirection.Input;
                MySqlParameter nota_inv = cmd.Parameters.Add("nota_inv", MySqlDbType.VarChar, 100);
                nota_inv.Direction = ParameterDirection.Input;

                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter emp = cmd.Parameters.Add("emp", MySqlDbType.VarChar, 15);
                emp.Direction = ParameterDirection.Input;
                MySqlParameter sys = cmd.Parameters.Add("sys", MySqlDbType.VarChar, 20);
                sys.Direction = ParameterDirection.Input;

                cod_inv.Value = exist.CODIGO;
                suc_inv.Value = exist.BODEGA;
                cat_inv.Value = exist.CATEGORIA;
                item_inv.Value = exist.COD_ITEM;
                tipo_inv.Value = exist.TIPO;
                marca_inv.Value = exist.MARCA;
                descrip_inv.Value = exist.DESCRIPCION.Replace('>', '-').Replace('&', 'y');
                precio_inv.Value = exist.PRECIO;
                nota_inv.Value = exist.NOTA;

                suc.Value = sucursal;
                emp.Value = empleado;
                sys.Value = sistema;

                cmd.ExecuteNonQuery();
                MessageBox.Show("ARTICULO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                OK = false;
                MessageBox.Show(e.Message, "ERROR AL ACTUALIZAR ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }










        public DataTable getEXISTENCIAS(string sucursal,string categoria)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_EXISTENCIAS_CATEGORIA;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter suc_exis = cmd.Parameters.Add("suc_exis", MySqlDbType.VarChar, 2);
                suc_exis.Direction = ParameterDirection.Input;
                MySqlParameter cat_exis = cmd.Parameters.Add("cat_exis", MySqlDbType.VarChar, 50);
                cat_exis.Direction = ParameterDirection.Input;

                suc_exis.Value = sucursal;
                cat_exis.Value = categoria;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS DE " + categoria, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }




        public DataTable getEXISTENCIAS_ITEM(string categoria,string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "prendasal.RPT_EXISTENCIAS_CATEGORIA_CODIGO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter cat_exis = cmd.Parameters.Add("cat_exis", MySqlDbType.VarChar, 50);
                cat_exis.Direction = ParameterDirection.Input;
                MySqlParameter cod_exis = cmd.Parameters.Add("cod_exis", MySqlDbType.VarChar, 50);
                cod_exis.Direction = ParameterDirection.Input;

                cat_exis.Value = categoria;
                cod_exis.Value = codigo + "-";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS DE " + categoria, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }






        // INVENTARIO EN CUSTODIA DE VALORES

        public DataTable getInvCustodia(string sucursal, string categoria, string articulo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_inv_custodia WHERE 1=1 ";
                if (sucursal != "00")
                {
                    sql = sql + "AND BODEGA = @suc ";
                }
                if (categoria != "TODAS")
                {
                    sql = sql + "AND CATEGORIA = @cat ";
                }
                if (articulo != null && articulo != "TODAS" && articulo != string.Empty)
                {
                    sql = sql + "AND COD_ITEM = @item ";
                }
                sql = sql + "ORDER BY CATEGORIA,CONTRATO;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter suc = cmd.Parameters.Add("suc", MySqlDbType.VarChar, 2);
                suc.Direction = ParameterDirection.Input;
                MySqlParameter cat = cmd.Parameters.Add("cat", MySqlDbType.VarChar, 2);
                cat.Direction = ParameterDirection.Input;
                MySqlParameter item = cmd.Parameters.Add("item", MySqlDbType.VarChar, 2);
                item.Direction = ParameterDirection.Input;

                suc.Value = sucursal;
                cat.Value = categoria;
                item.Value = articulo;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR INVENTARIO EN CUSTODIA PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }





        public DataTable getInvCustodia(string codigo)
        {
            MySqlDataReader reader;
            DataTable datos = new DataTable();
            try
            {
                string sql = "SELECT * FROM prendasal.view_inv_custodia WHERE CONTRATO LIKE @contrato;";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conection);
                cmd.CommandType = CommandType.Text;
                MySqlParameter contrato = cmd.Parameters.Add("contrato", MySqlDbType.VarChar, 25);
                contrato.Direction = ParameterDirection.Input;

                contrato.Value = codigo + "%";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR AL CONSULTAR EXISTENCIAS PRENDASAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }















    }

}
