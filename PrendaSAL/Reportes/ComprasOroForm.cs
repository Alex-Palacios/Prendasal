using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Globalization; 

namespace PrendaSAL.Reportes
{
    using MODELO;
    using DDB;
    using Informes;

    public partial class ComprasOroForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ComprasOroForm frmInstance = null;

        public static ComprasOroForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ComprasOroForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBReporte dbReportes;
        private DBUsuario dbUser;
        private DataTable MESES;
        private DataTable COMPRAS_KILMES;

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


        public ComprasOroForm()
        {
            InitializeComponent(); 
            dbReportes = new DBReporte();
            dbUser = new DBUsuario();
        }


        

        private void ComprasOroForm_Load(object sender, EventArgs e)
        {
            DataTable SUCURSALES = HOME.Instance().datSUCURSALES.Copy();
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

            MESES = new DataTable();
            MESES.Columns.Add("MES").DataType = System.Type.GetType("System.String");
            MESES.Columns.Add("NOMBRE").DataType = System.Type.GetType("System.String");

            List<string> meses = new List<string>();
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            for(int i =1;i <= 12; i++)
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

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            if (txtANIO.Text.Trim() != string.Empty && cbxMESES.SelectedIndex >= 0 && cbxSUCURSAL.SelectedIndex >= 0)
            {
                string MES = MESES.Rows[cbxMESES.SelectedIndex].Field<string>("NOMBRE");
                string ANIO = txtANIO.Text.Trim();
                COMPRAS_KILMES = dbReportes.COMPRAS_KILMES((string)cbxSUCURSAL.SelectedValue, (string) cbxMESES.SelectedValue, txtANIO.Text.Trim());
                dSComprasKilMes.Clear();
                try
                {
                    foreach (DataRow row in COMPRAS_KILMES.Rows)
                    {
                        dSComprasKilMes.COMPRASKIL.AddCOMPRASKILRow(row.Field<string>("SUCURSAL"), row.Field<int>("ID_COMPRA"), row.Field<string>("DOCUMENTO"), row.Field<DateTime>("FECHA"), row.Field<string>("ARTICULO"), row.Field<string>("COD_ITEM"), row.Field<double>("CANTIDAD"), row.Field<decimal>("MONTO"), row.Field<string>("RESPONSABLE"));
                    }

                    bindingReporte.DataSource = dSComprasKilMes.COMPRASKIL;

                    ReportParameter[] parameters = new ReportParameter[3];
                    parameters[0] = new ReportParameter("MES", MES);
                    parameters[1] = new ReportParameter("ANIO", ANIO);
                    parameters[2] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteComprasKILMES.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("COMPRASKIL", bindingReporte));
                    viewerREPORTE.LocalReport.SetParameters(parameters);
                    viewerREPORTE.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR al generar reporte .... verifique parametros de entrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Parametros incompletos", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }
}
