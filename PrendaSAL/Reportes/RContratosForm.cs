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
        private DBPrestamo dbContrato;
        private DataTable SUCURSALES;
        private DataTable CONTRATOS;

        public RContratosForm()
        {
            InitializeComponent();
            dbContrato = new DBPrestamo();
            tblCONTRATOS.AutoGenerateColumns = false;
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

            permisos();
            cbxESTADOS.DataSource = Enum.GetValues(new eEstadoContrato().GetType());

        }




        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.SelectedIndex >= 0 && cbxESTADOS.SelectedIndex >= 0)
            {
                //CONTRATOS = dbContrato.FIND_BY_ESTADO_CONTRATO((string)cbxSUCURSAL.SelectedValue, (eEstadoContrato)cbxESTADOS.SelectedItem);
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

    }
}
