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
        private DBInventario dbInventario;
        private DBCatalogo dbCatalogo;
        private DataTable INVENTARIO;


        public RInvResguardoForm()
        {
            InitializeComponent();
            dbCatalogo = new DBCatalogo();
            dbInventario = new DBInventario();
        }


        private void permisos()
        {
            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                cbxSUCURSAL.Enabled = true;
            }
        }



        private void RInvResguardoForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblINVENTARIO.AutoGenerateColumns = false;
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                DataRow R = ((DataTable)cbxSUCURSAL.DataSource).NewRow();
                R.SetField<string>("COD_SUC", "00");
                R.SetField<string>("SUCURSAL", "TODAS LAS SUCURSALES");
                R.SetField<bool>("ACTIVA", false);
                ((DataTable)cbxSUCURSAL.DataSource).Rows.InsertAt(R, 0);
            }

            cbxCATEGORIA.DataSource = Enum.GetValues(new eCategoria().GetType());
            rdbDETALLE.Checked = true;
        }




        private void rdbDETALLE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDETALLE.Checked)
            {
                cbxSUCURSAL.Enabled = true;
                cbxCATEGORIA.Enabled = true;
                cbxARTICULO.Enabled = true;
                txtCODIGO.Text = string.Empty;
                txtCODIGO.ReadOnly = true;
            }
            
            
        }


        private void rdbCODIGO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCODIGO.Checked)
            {
                cbxSUCURSAL.Enabled = false;
                cbxCATEGORIA.Enabled = false;
                cbxARTICULO.Enabled = false;
                txtCODIGO.ReadOnly = false;
            }
        }






        private void cbxCATEGORIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCATEGORIA.SelectedIndex >= 0)
            {
                cbxARTICULO.DataSource = dbCatalogo.showCatalogo((eCategoria) cbxCATEGORIA.SelectedItem);
                if (cbxARTICULO.DataSource != null && ((DataTable)cbxARTICULO.DataSource).Rows.Count > 0)
                {
                    cbxARTICULO.DisplayMember = "COD_ITEM";
                    cbxARTICULO.ValueMember = "COD_ITEM";
                    DataRow R = ((DataTable)cbxARTICULO.DataSource).NewRow();
                    R.SetField<string>("CATEGORIA", "TODAS");
                    R.SetField<string>("COD_ITEM", "TODAS");
                    R.SetField<string>("UNIDAD_MEDIDA", "TODAS");
                    ((DataTable)cbxARTICULO.DataSource).Rows.InsertAt(R, 0);
                }
            }
            
        }





        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (rdbDETALLE.Checked)
            {
                //BUSCAR POR ARTICULO
                if (cbxSUCURSAL.SelectedIndex >= 0 && cbxCATEGORIA.SelectedIndex >= 0 && cbxARTICULO.SelectedIndex >= 0)
                {
                    INVENTARIO = dbInventario.getInvCustodia((string)cbxSUCURSAL.SelectedValue, (string)cbxCATEGORIA.Text, (string)cbxARTICULO.Text);
                    tblINVENTARIO.DataSource = INVENTARIO.Copy();
                    System.Media.SystemSounds.Exclamation.Play();
                }
                else
                {
                    MessageBox.Show("SELECCIONE SUCURSAL Y CATEGORIA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //BUSCAR POR CODIGO
                if (txtCODIGO.Text.Trim() != string.Empty)
                {
                    INVENTARIO = dbInventario.getInvCustodia(txtCODIGO.Text.Trim());
                    tblINVENTARIO.DataSource = INVENTARIO.Copy();
                    System.Media.SystemSounds.Exclamation.Play();
                }
                else
                {
                    MessageBox.Show("INGRESE CODIGO DE ARTICULOS A BUSCAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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




        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (INVENTARIO != null)
            {
                HOME.Instance().exportDataGridViewToExcel("REPORTE DE CUSTODIA", tblINVENTARIO.Columns, INVENTARIO, "ReporteInvCustodia");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }







    }
}
