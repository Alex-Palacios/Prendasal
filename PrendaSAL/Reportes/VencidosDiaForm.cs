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

    public partial class VencidosDiaForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static VencidosDiaForm frmInstance = null;

        public static VencidosDiaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new VencidosDiaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBPrestamo dbContrato;
        private DataTable LISTA_VENCIDOS;
        private DataTable SUCURSALES;


        public VencidosDiaForm()
        {
            InitializeComponent();
            dbContrato = new DBPrestamo();
        }

        private void permisos()
        {
            //PERMISOS FORMULARIO
            if (HOME.Instance().USUARIO.TIPO != eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = true;
            }
            else
            {
                cbxSUCURSAL.Enabled = false;
            }
        }

        private void VencidosDiaForm_Load(object sender, EventArgs e)
        {
            tblVENCIDOS.AutoGenerateColumns = false;
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
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            permisos();
        }




        private void tblVENCIDOS_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblVENCIDOS.DataSource != null)
            {
                lbTOTAL.Text = tblVENCIDOS.Rows.Count + " CONTRATOS";
            }
            else
            {
                lbTOTAL.Text = "0 CONTRATOS";
            }
        }


        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.SelectedIndex >= 0)
            {
               // LISTA_VENCIDOS = dbContrato.CONTRATOS_PLAZO_DIA((string)cbxSUCURSAL.SelectedValue, HOME.Instance().FECHA_SISTEMA);
                tblVENCIDOS.DataSource = LISTA_VENCIDOS;
                if (LISTA_VENCIDOS.Rows.Count == 0)
                {
                    MessageBox.Show("NO HAY CONTRATOS VENCIDOS");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Sucursal", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
