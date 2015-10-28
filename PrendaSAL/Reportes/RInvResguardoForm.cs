using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Reportes
{
    using DDB;
    using MODELO;

    public partial class RInvResguardoForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RInvResguardoForm frmInstance = null;

        public static RInvResguardoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RInvResguardoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBInventario dbInventario;
        private DBCatalogo dbCatalogo;
        private DataTable INVENTARIO;
        private DataTable SUCURSALES;
        private DataTable ARTICULOS;


        public RInvResguardoForm()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
        }

        private void permisos()
        {
            
        }

        private void RInvResguardoForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblINVENTARIO.AutoGenerateColumns = false;
            rdbCODIGO.Checked = true;
            rdbDETALLE.Checked = false;
            SUCURSALES = HOME.Instance().datSUCURSALES.Copy();
            if (SUCURSALES.Rows.Count == 0)
            {
                SUCURSALES.Columns.Add("CODIGO");
                SUCURSALES.Columns.Add("SUCURSAL");
                SUCURSALES.Columns.Add("ACTIVA");
                SUCURSALES.Columns.Add("ID_RUBRO");
            }
            DataRow R = SUCURSALES.NewRow();
            R.SetField<string>("CODIGO", "00");
            R.SetField<string>("SUCURSAL", "TODAS LAS SUCURSALES");
            R.SetField<bool>("ACTIVA", false);
            R.SetField<int>("ID_RUBRO", -1);
            SUCURSALES.Rows.InsertAt(R, 0);
            cbxSUCURSAL.DataSource = SUCURSALES;
            if (SUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "CODIGO";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }


            cbxCATEGORIA.DataSource = Enum.GetValues(new eCategoria().GetType());
           
        }

        private void rdbDETALLE_CheckedChanged(object sender, EventArgs e)
        {
            cbxSUCURSAL.Enabled = rdbDETALLE.Checked;
            cbxCATEGORIA.Enabled = rdbDETALLE.Checked;
            cbxARTICULO.Enabled = rdbDETALLE.Checked;
        }

        private void rdbCODIGO_CheckedChanged(object sender, EventArgs e)
        {
            txtCODIGO.ReadOnly = !rdbCODIGO.Checked;
        }


        private void tblINVENTARIO_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblINVENTARIO.DataSource != null)
            {
                lbNUM_TOTAL.Text = tblINVENTARIO.Rows.Count + " ARTICULOS";
            }
            else
            {
                lbNUM_TOTAL.Text = "0 ARTICULOS";
            }
        }





        private void cbxCATEGORIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCATEGORIA.SelectedIndex > 0)
            {
                ARTICULOS = dbCatalogo.showCatalogo((eCategoria) cbxCATEGORIA.SelectedItem);
            }
            
            if (ARTICULOS.Rows.Count == 0)
            {
                ARTICULOS.Columns.Add("COD_ITEM");
            }
            DataRow R = ARTICULOS.NewRow();
            R.SetField<string>("COD_ITEM", "TODAS");
            ARTICULOS.Rows.InsertAt(R, 0);
            cbxARTICULO.DataSource = ARTICULOS;
            if (ARTICULOS.Rows.Count > 0)
            {
                cbxARTICULO.DisplayMember = "COD_ITEM";
                cbxARTICULO.ValueMember = "COD_ITEM";
            }
        }





        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (rdbDETALLE.Checked)
            {
                //BUSCAR POR ARTICULO
                if (cbxSUCURSAL.SelectedIndex >= 0 && cbxCATEGORIA.SelectedIndex >= 0)
                {
                    //INVENTARIO = dbInventario.CUSTODIA_PRENDASAL((string)cbxSUCURSAL.SelectedValue, (string)cbxCATEGORIA.SelectedValue, (string)cbxARTICULO.SelectedValue);
                    tblINVENTARIO.DataSource = INVENTARIO.Copy();
                    System.Media.SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                //BUSCAR POR CODIGO
                if (txtCODIGO.Text.Trim() != string.Empty)
                {
                    //INVENTARIO = dbInventario.CUSTODIA_BY_CODIGO_PRENDASAL(txtCODIGO.Text.Trim());
                    tblINVENTARIO.DataSource = INVENTARIO.Copy();
                    System.Media.SystemSounds.Exclamation.Play();
                }
                else
                {
                    MessageBox.Show("INGRESE CODIGO DE ARTICULOS A BUSCAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }







    }
}
