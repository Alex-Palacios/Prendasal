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

    public partial class RContratosForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RContratosForm frmInstance = null;

        public static RContratosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RContratosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES 
        private DBReporte dbReporte;
        private DataTable CONTRATOS;

        public RContratosForm()
        {
            InitializeComponent();
            dbReporte = new DBReporte();
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

        private void RContratosForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCONTRATOS.AutoGenerateColumns = false;
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

            cbxESTADOS.DataSource = Enum.GetValues(new eEstadoContrato().GetType());

        }




        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.SelectedIndex >= 0 && cbxESTADOS.SelectedIndex >= 0)
            {
                CONTRATOS = dbReporte.RptContratosByEstado((string)cbxSUCURSAL.SelectedValue, (eEstadoContrato)cbxESTADOS.SelectedItem);
                tblCONTRATOS.DataSource = CONTRATOS;
            }
            else
            {
                MessageBox.Show("PARAMETROS INVALIDOS", "Error al Generar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void tblCONTRATOS_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblCONTRATOS.DataSource != null)
            {
                lbNUM_TOTAL.Text = tblCONTRATOS.Rows.Count + " CONTRATOS";
            }
        }




        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (CONTRATOS != null)
            {
                HOME.Instance().exportDataGridViewToExcel("REPORTE DE CONTRATOS", tblCONTRATOS.Columns, CONTRATOS, "ReporteContratos");
            }
        }

    }
}
