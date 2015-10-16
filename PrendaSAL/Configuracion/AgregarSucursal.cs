using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesPersonalizados;

namespace PrendaSAL.Configuracion
{
    using DDB;
    using MODELO;

    public partial class AgregarSucursal : Form
    {
        
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static AgregarSucursal frmInstance = null;

        public static AgregarSucursal Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new AgregarSucursal();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private DBSucursal  dbSucursal;

        private Sucursal SELECTED;
        private eOperacion ACCION;

        private DataTable SUCURSALES;

        public AgregarSucursal()
        {
            InitializeComponent();
            ACCION = eOperacion.INSERT;
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbSucursal = new DBSucursal();
        }


        public AgregarSucursal(Sucursal SUCURSAL)
        {
            InitializeComponent();
            ACCION = eOperacion.UPDATE;
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbSucursal = new DBSucursal();
            SELECTED = SUCURSAL;
        }


        private void AgregarSucursal_Load(object sender, EventArgs e)
        {
            cbxFECHA_SISTEMA.DataSource = Enum.GetValues(new GlobalFechaSistema().GetType());
            DataTable deptos = dbPrendasal.getDeptos();
            if (deptos.Rows.Count > 0)
            {
                DataRow rowD = deptos.NewRow();
                rowD.SetField<string>("DEPTO", "Seleccione Depto");
                deptos.Rows.InsertAt(rowD, 0);
            }
            else
            {
                deptos.Columns.Add("DEPTO");
                deptos.Rows.Add("Seleccione Depto");
            }
            cbxDEPTO.DataSource = deptos;
            if (deptos.Rows.Count > 0)
            {
                cbxDEPTO.DisplayMember = "DEPTO";
                cbxDEPTO.SelectedIndex = 0;
            }

            switch (ACCION)
            {
                case eOperacion.INSERT:
                    cargarSucursales();
                    listSucursales.Enabled = true;
                    btnGUARDAR.Text = "AGREGAR";
                    break;
                case eOperacion.UPDATE:
                    cargarSelected();
                    listSucursales.Enabled = false;
                    btnGUARDAR.Text = "GUARDAR";
                    break;
            }

        }


        private void cargarSucursales()
        {
            SUCURSALES = dbSucursal.showSucursalesNoConfig();
            foreach (DataRow row in SUCURSALES.Rows)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(row["COD_SUC"]));
                item.SubItems.Add(row.Field<string>("SUCURSAL"));
                item.SubItems.Add(row.Field<string>("MUNICIPIO"));
                listSucursales.Items.Add(item);
            }

        }



        private void cargarSelected()
        {
            if (SELECTED != null)
            {
                txtCodigo.Text = SELECTED.COD_SUC;
                txtSucursal.Text = SELECTED.SUCURSAL;
                ckACTIVA.Checked = SELECTED.ACTIVA;
                txtTEL.Text = SELECTED.TEL;
                if (SELECTED.COD_MUNICIPIO == null || SELECTED.COD_MUNICIPIO == "")
                {
                    cbxDEPTO.SelectedIndex = 0;
                }
                else
                {
                    cbxDEPTO.Text = SELECTED.DEPTO;
                    cbxMUNICIPIO.SelectedValue = SELECTED.COD_MUNICIPIO;
                }
                txtDIRECCION.Text = SELECTED.DIRECCION;
                txtIP.Text = SELECTED.IP;
                txtHOSTNAME.Text = SELECTED.HOSTNAME;
                cbxFECHA_SISTEMA.SelectedItem = SELECTED.FECHA_SISTEMA;
            }
            
        }




        private void listSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSucursales.SelectedIndices.Count == 1)
            {
                limpiar();
                SELECTED = Sucursal.ConverterToSucursal(SUCURSALES.Rows[listSucursales.SelectedIndices[0]]);
                cargarSelected();
               
            }
        }





        private void limpiar()
        {
            txtCodigo.Text = "";
            txtSucursal.Text = "";
            txtIP.Text = "";
            txtHOSTNAME.Text = "";
        }


        private void cbmDEPTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDEPTO.SelectedIndex > 0)
            {
                DataTable MUNI = dbPrendasal.getMunicipios(cbxDEPTO.Text);
                if (MUNI.Rows.Count > 0)
                {
                    DataRow rowM = MUNI.NewRow();
                    rowM.SetField<string>("COD_MUNICIPIO", "XXXX");
                    rowM.SetField<string>("MUNICIPIO", "-------");
                    MUNI.Rows.InsertAt(rowM, 0);
                }
                cbxMUNICIPIO.DataSource = MUNI;
                cbxMUNICIPIO.DisplayMember = "MUNICIPIO";
                try
                {
                    cbxMUNICIPIO.ValueMember = "COD_MUNICIPIO";
                    cbxMUNICIPIO.SelectedIndex = 0;
                }
                catch (Exception ex) { }
            }
            else
            {
                cbxMUNICIPIO.DataSource = null;
            }
        }

        private void CANCELAR(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validarSucursal()
        {
            bool OK = true;
            try
            {
                if (txtCodigo.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Elija Sucursal", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }

            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR SUCURSAL", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }



        private Sucursal buildSUCURSAL()
        {
            Sucursal suc = new Sucursal();
            suc.COD_SUC = txtCodigo.Text;
            suc.SUCURSAL = txtSucursal.Text;
            suc.TEL = txtTEL.Text;
            if (cbxDEPTO.SelectedIndex > 0 && cbxMUNICIPIO.SelectedIndex > 0)
            {
                suc.COD_MUNICIPIO = (string)cbxMUNICIPIO.SelectedValue;
            }
            suc.DIRECCION = txtDIRECCION.Text;
            suc.ACTIVA = ckACTIVA.Checked;
            suc.IP = txtIP.Text;
            suc.HOSTNAME = txtHOSTNAME.Text;
            suc.FECHA_SISTEMA = (GlobalFechaSistema)cbxFECHA_SISTEMA.SelectedItem;
            return suc;
        }




        private void GUARDAR(object sender, EventArgs e)
        {

            if (validarSucursal())
            {
                string autorizacion = "";
                Sucursal suc = buildSUCURSAL();
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbSucursal.insertSucConfig(suc))
                            {
                                SucursalesForm.Instance().cargarSucursales();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        break;
                    case eOperacion.UPDATE:
                        autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbSucursal.updateSucConfig(suc))
                            {
                                SucursalesForm.Instance().cargarSucursales();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        break;
                }
                
            }
        }



    }
}
