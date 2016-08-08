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

    public partial class RContratosDiaForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RContratosDiaForm frmInstance = null;

        public static RContratosDiaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RContratosDiaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES 
        private DBReporte dbReporte;
        private DataTable CONTRATOS;

        public RContratosDiaForm()
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

            numDESDE.Value = 30;
            numHASTA.Value = 60;

        }




        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.SelectedIndex >= 0 && numHASTA.Value >= numDESDE.Value)
            {
                CONTRATOS = dbReporte.RptContratosVigentesDias((string)cbxSUCURSAL.SelectedValue,(int) numDESDE.Value,(int)numHASTA.Value);
                tblCONTRATOS.DataSource = CONTRATOS;
                MessageBox.Show("CONTRATOS CARGADOS", "Reporte Vigentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
