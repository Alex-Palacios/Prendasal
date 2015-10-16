using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Configuracion
{
    using System.Xml;
    using DDB;
    using MODELO;

    public partial class ConfigForm : Form
    {
        
        //VARIABLES
        private DBSucursal dbSucursal;
        private DataTable sucursales;
        private XmlDocument configXml = new XmlDocument();


        private bool INIT;

        public ConfigForm(bool init)
        {
            InitializeComponent();
            dbSucursal = new DBSucursal();
            INIT = init;
        }



        private void permisos()
        {
            if (HOME.Instance().USUARIO != null && HOME.Instance().USUARIO.PERMISOS != null)
            {
                btnGUARDAR.Visible = false;
                btnCANCELAR.Visible = false;
                foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
                {
                    if (p.Field<string>("CODIGO") == "P24")
                    {
                        btnGUARDAR.Visible = p.Field<bool>("ACTUALIZAR");
                        btnCANCELAR.Visible = p.Field<bool>("ACTUALIZAR");
                    }
                }
            }
        }

        private void cargarDatos(object sender, EventArgs e)
        {
            txtSERVER.Text = Properties.Settings.Default.SERVER;
            txtPUERTO.Text = Properties.Settings.Default.PUERTO;
            txtDB.Text = Properties.Settings.Default.DATABASE;
            txtUSER.Text = Properties.Settings.Default.USERDB;
            txtPASSWORD.Text = Properties.Settings.Default.PASSWORD;
            cargarSucursales();
            permisos();
        }



        private void cargarSucursales()
        {
            sucursales = dbSucursal.showSucursales();
            if (sucursales.Rows.Count == 0)
            {
                sucursales.Columns.Add("COD_SUC");
                sucursales.Columns.Add("SUCURSAL");
                sucursales.Columns.Add("TEL");
                sucursales.Columns.Add("COD_MUNICIPIO");
                sucursales.Columns.Add("DIRECCION");
                sucursales.Columns.Add("ACTIVA");
            }
            DataRow R = sucursales.NewRow();
            R.SetField<string>("COD_SUC", "00");
            R.SetField<string>("SUCURSAL", "sin asignar");
            R.SetField<bool>("ACTIVA", false);
            sucursales.Rows.InsertAt(R, 0);
            cbxSUCURSAL.DataSource = sucursales;
            if (sucursales.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = Properties.Settings.Default.SUCURSAL;
            }
        }




        private void guardarCAMBIOS(object sender, EventArgs e)
        {
            string ficConfig;
            //CARGAR ARCHIVO XML
            ficConfig = Application.ExecutablePath + ".config";
            configXml.Load(ficConfig);
            if (!System.IO.File.Exists(ficConfig) == false)
            {
                DialogResult reiniciar = MessageBox.Show("¿Está seguro que desea CAMBIAR la configuraciones actuales? \n NOTA: La Aplicacion se Reiniciará para aplicar cambios", "Configuraciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reiniciar == DialogResult.Yes)
                {
                    //GUARDAR NUEVOS VALORES
                    cfgSetValue("configuration/applicationSettings/PrendaSAL.Properties.Settings", "SERVER", this.txtSERVER.Text);
                    cfgSetValue("configuration/applicationSettings/PrendaSAL.Properties.Settings", "PUERTO", this.txtPUERTO.Text);
                    cfgSetValue("configuration/applicationSettings/PrendaSAL.Properties.Settings", "DATABASE", this.txtDB.Text);
                    cfgSetValue("configuration/applicationSettings/PrendaSAL.Properties.Settings", "USERDB", this.txtUSER.Text);
                    cfgSetValue("configuration/applicationSettings/PrendaSAL.Properties.Settings", "PASSWORD", this.txtPASSWORD.Text);
                    cfgSetValue("configuration/applicationSettings/PrendaSAL.Properties.Settings", "SUCURSAL", (string)cbxSUCURSAL.SelectedValue);

                    configXml.Save(ficConfig);
                    
                    MessageBox.Show("CONFIGURACION GUARDADA .. \nLA APLICACION SE REINICIARA", "CONFIGURACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                    
                }
            }
            else
            {
                MessageBox.Show("ARCHIVO DE CONFIGURACION NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //  El método para guardar los valores
        private void cfgSetValue(string seccion, string clave, string valor)
        {
            XmlNode n;
            n = configXml.SelectSingleNode(seccion + "/setting[@name=\"" + clave + "\"]");
            if (n != null)
            {
                n.InnerXml = "<value>" + valor + "</value>";
            }
        }

        private void CANCELAR(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (INIT)
            {
                Application.Exit();
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            DDB.DBConexion conn = new DDB.DBConexion(Properties.Settings.Default.DRIVER, txtSERVER.Text, txtPUERTO.Text , txtDB.Text, txtUSER.Text, txtPASSWORD.Text);
            if (conn.conection.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion Exitosa", "CONEXION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Conexion Fallo", "ERROR DE CONEXION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        






    }
}
