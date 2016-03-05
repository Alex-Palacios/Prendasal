using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; 

namespace PrendaSAL.Reportes
{
    using MODELO;
    using DDB;

    public partial class RKardexForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RKardexForm frmInstance = null;

        public static RKardexForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RKardexForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBReporte dbReporte;
        private DBCatalogo dbCatalogo;
        private DataTable KARDEX;
        private DataTable MESES;

        private void permisos()
        {

        }


        public RKardexForm()
        {
            InitializeComponent();
            dbReporte = new DBReporte();
            dbCatalogo = new DBCatalogo();
        }

        private void RKardexForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblKARDEX.AutoGenerateColumns = false;

            MESES = new DataTable();
            MESES.Columns.Add("MES").DataType = System.Type.GetType("System.String");
            MESES.Columns.Add("NOMBRE").DataType = System.Type.GetType("System.String");

            List<string> meses = new List<string>();
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            for (int i = 1; i <= 12; i++)
            {
                string num = "";
                if (i < 10)
                {
                    num = "0" + i;
                }
                else
                {
                    num = i.ToString();
                }
                MESES.Rows.Add(num, formatoFecha.GetMonthName(i).ToUpper());
            }
            cbxMESES.DataSource = MESES;
            cbxMESES.DisplayMember = "NOMBRE";
            cbxMESES.ValueMember = "MES";
            txtANIO.Text = DateTime.Today.Year.ToString();

            cbxItem.DataSource = dbCatalogo.showCatalogo("ORO");
            if (((DataTable)cbxItem.DataSource).Rows.Count > 0)
            {
                cbxItem.DisplayMember = "COD_ITEM";
                cbxItem.ValueMember = "COD_ITEM";
            }


            txtCODIGO.Text = string.Empty;

            rdbKILATAJE.Checked = true;

        }



        private void txtANIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }
        }


        private void rdbCODIGO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCODIGO.Checked)
            {
                txtCODIGO.Text = string.Empty;

                cbxItem.Enabled = false;
                txtCODIGO.ReadOnly = false;
            }
        }

        private void rdbFILTROS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKILATAJE.Checked)
            {
                txtCODIGO.Text = string.Empty;

                cbxItem.Enabled = true;
                txtCODIGO.ReadOnly = true;
            }
        }





        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (rdbKILATAJE.Checked)
            {
                //BUSCAR POR ITEM
                if(txtANIO.Text.Trim() != string.Empty && cbxMESES.SelectedIndex >= 0 && cbxItem.SelectedIndex >= 0)
                {
                    KARDEX = dbReporte.RptKARDEX(txtANIO.Text.Trim(), (string)cbxMESES.SelectedValue, (string)cbxItem.SelectedValue);
                    tblKARDEX.DataSource = KARDEX.Copy();
                }
                else
                {
                    MessageBox.Show("PARAMETROS INVALIDOS", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //BUSCAR POR CODIGO
                if (txtANIO.Text.Trim() != string.Empty && cbxMESES.SelectedIndex >= 0 && txtCODIGO.Text.Trim() != string.Empty)
                {
                    KARDEX = dbReporte.RptKARDEX(txtANIO.Text.Trim(), (string)cbxMESES.SelectedValue, txtCODIGO.Text.Trim());
                    tblKARDEX.DataSource = KARDEX.Copy();
                }
                else
                {
                    MessageBox.Show("PARAMETROS INVALIDOS", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }






        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (KARDEX != null)
            {
                HOME.Instance().exportDataGridViewToExcel("REPORTE KARDEX", tblKARDEX.Columns, KARDEX, "ReporteKardex");
            }
        }

        





    }
}
