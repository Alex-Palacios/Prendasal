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

    public partial class RComprasOroForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RComprasOroForm frmInstance = null;

        public static RComprasOroForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RComprasOroForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBReporte dbReportes;
        private DataTable MESES;
        private DataTable COMPRAS_ORO;

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


        public RComprasOroForm()
        {
            InitializeComponent(); 
            dbReportes = new DBReporte();
        }


        

        private void ComprasOroForm_Load(object sender, EventArgs e)
        {
            permisos();
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
            viewerREPORTE.Clear();
            if (txtANIO.Text.Trim() != string.Empty && cbxMESES.SelectedIndex >= 0 && cbxSUCURSAL.SelectedIndex >= 0)
            {
                string MES = MESES.Rows[cbxMESES.SelectedIndex].Field<string>("NOMBRE");
                string ANIO = txtANIO.Text.Trim();
                COMPRAS_ORO = dbReportes.RptComprasOroByMes((string)cbxSUCURSAL.SelectedValue,txtANIO.Text.Trim(), (string) cbxMESES.SelectedValue);
                dSComprasOro.Clear();
                try
                {
                    foreach (DataRow row in COMPRAS_ORO.Rows)
                    {
                        Sucursal SUC = HOME.Instance().getSucursal(row.Field<string>("COD_SUC")).Copy();
                        dSComprasOro.COMPRAS_ORO.AddCOMPRAS_ORORow(SUC.SUCURSAL, row.Field<int>("ID_COMPRA"), row.Field<string>("DOCUMENTO"), row.Field<DateTime>("FECHA"), row.Field<string>("ARTICULO"), row.Field<string>("COD_ITEM"), row.Field<decimal>("CANTIDAD"), row.Field<decimal>("MONTO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_SUC"));
                    }
                    bsComprasOro.DataSource = dSComprasOro.COMPRAS_ORO;

                    ReportParameter[] parameters = new ReportParameter[3];
                    parameters[0] = new ReportParameter("MES", MES);
                    parameters[1] = new ReportParameter("ANIO", ANIO);
                    parameters[2] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteComprasOro.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("COMPRASKILMES", bsComprasOro));
                    viewerREPORTE.LocalReport.SetParameters(parameters);
                    viewerREPORTE.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR AL GENERAR REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Parametros incompletos", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }
}
