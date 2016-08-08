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

namespace PrendaSAL.Reportes
{
    using MODELO;
    using DDB;

    public partial class RCarteraVigenteForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RCarteraVigenteForm frmInstance = null;

        public static RCarteraVigenteForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RCarteraVigenteForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        private DBReporte dbReportes;
        private DataTable RESUMEN;

        public RCarteraVigenteForm()
        {
            InitializeComponent();
            dbReportes = new DBReporte();
        }

        private void permisos()
        {

        }




        private void RCarteraVigenteForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblSUCURSALES.AutoGenerateColumns = false;
            tblSUCURSALES.Columns["CKSUC"].ReadOnly = false;
            tblSUCURSALES.Columns["COD_SUC"].ReadOnly = true;
            tblSUCURSALES.Columns["SUCURSAL"].ReadOnly = true;
            tblSUCURSALES.DataSource = HOME.Instance().datSUCURSALES.Copy();
            ckMostrarGraficos.Checked = true;
        }





        private void ckAllSucursales_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblSUCURSALES.Rows)
            {
                row.Cells["CKSUC"].Value = ckAllSucursales.Checked;
            }
        }











        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            viewerREPORTE.Clear();
            string sucursales = string.Empty;
            foreach (DataGridViewRow sucRow in tblSUCURSALES.Rows)
            {
                if ((bool)sucRow.Cells["CKSUC"].FormattedValue)
                {
                    if (sucursales == string.Empty)
                    {
                        sucursales = sucursales + sucRow.Cells["COD_SUC"].Value;
                    }
                    else
                    {
                        sucursales = sucursales + "," + sucRow.Cells["COD_SUC"].Value;
                    }
                }
            }
            if (sucursales != string.Empty)
            {
                RESUMEN = dbReportes.RptCarteraVigente(sucursales);
                dSCarteraVigente.Clear();
                try
                {
                    foreach (DataRow row in RESUMEN.Rows)
                    {
                        dSCarteraVigente.RESUMEN.AddRESUMENRow(row.Field<string>("COD_SUC"), row.Field<string>("SUCURSAL"), row.Field<Int64>("CANTIDAD"), row.Field<decimal>("MONTOS"), row.Field<decimal>("SALDOS"));
                    }
                    bsCarteraVigente.DataSource = dSCarteraVigente.RESUMEN;

                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("mostrarGraficos", ckMostrarGraficos.Checked.ToString());
                    parameters[1] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.RptCarteraVigente.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("RESUMEN", bsCarteraVigente));
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
                MessageBox.Show("Seleccione al menos una SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }









    }
}
