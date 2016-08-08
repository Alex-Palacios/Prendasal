using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Catalogos
{
    using MODELO;
    using DDB;
    using Microsoft.Reporting.WinForms;

    public partial class RptCuponesCanjesForm : Form
    {
        private DBCupones dbCupon;
        private Cupon CUPON;

        public RptCuponesCanjesForm(Cupon x)
        {
            InitializeComponent();
            CUPON = x;
            dbCupon = new DBCupones();
        }



        private void RptCuponesCanjesForm_Load(object sender, EventArgs e)
        {
            imprimirReporteCanjeo();
        }


        private void imprimirReporteCanjeo()
        {
            viewerRpt.Clear();
            if (CUPON != null)
            {
                try
                {
                    DataTable CANJEOS = dbCupon.getCanjeos(CUPON);
                    dSCanjeos.Clear();

                    foreach (DataRow row in CANJEOS.Rows)
                    {
                        dSCanjeos.CANJEO.AddCANJEORow(row.Field<DateTime>("FECHA"), row.Field<string>("COD_SUC"), row.Field<string>("CONTRATO"), row.Field<string>("CLIENTE"), row.Field<decimal>("INTERES"), row.Field<decimal>("DESCUENTO"), row.Field<decimal>("ABONO"), row.Field<decimal>("TOTAL"), row.Field<int>("NUMERO"));
                    }
                    bsCANJEOS.DataSource = dSCanjeos.CANJEO;

                    if (dSCanjeos.CANJEO.Count > 0)
                    {
                        ReportParameter[] parameters = new ReportParameter[8];
                        parameters[0] = new ReportParameter("DESDE", CUPON.DESDE.ToString());
                        parameters[1] = new ReportParameter("HASTA", CUPON.HASTA.ToString());
                        parameters[2] = new ReportParameter("FECHA_EXP", CUPON.FECHA_EXP.ToShortDateString());
                        parameters[3] = new ReportParameter("FECHA_VENC", CUPON.FECHA_VENC.ToShortDateString());
                        parameters[4] = new ReportParameter("DESC_INTERES", CUPON.DESC_INTERES.ToString("C2"));
                        parameters[5] = new ReportParameter("DESC_VENTA", CUPON.DESC_VENTA.ToString("C2"));
                        parameters[6] = new ReportParameter("TIPO", CUPON.TIPO.ToString());
                        parameters[7] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                        viewerRpt.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.RptCanjeos.rdlc";
                        viewerRpt.LocalReport.SetParameters(parameters);
                        viewerRpt.LocalReport.DataSources.Clear();
                        viewerRpt.LocalReport.DataSources.Add(new ReportDataSource("CANJEOS", bsCANJEOS));
                        viewerRpt.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("No se han realizado canjes de este tiraje","CANJEO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR al generar Reporte de CANJEOS", "GENERAR REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }
}
