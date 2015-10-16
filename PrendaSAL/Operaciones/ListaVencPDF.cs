using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;
    using Microsoft.Reporting.WinForms;
    using ControlesPersonalizados;

    public partial class ListaVencPDF : Form
    {

        //VARIABLES 
        private DBVencidos dbVencidos;
        private Vencidos SELECTED;




        public ListaVencPDF(Vencidos cierre)
        {
            InitializeComponent();
            dbVencidos = new DBVencidos();
            SELECTED = cierre;
        }



        private void ListaCierre_Load(object sender, EventArgs e)
        {
            cargarListaCierre();
        }

        


        private void cargarListaCierre()
        {
            //viewerCIERRE.Clear();
            //if (SELECTED != null)
            //{
            //    this.Text = "LISTA DE CIERRE #" + SELECTED.DOCUMENTO;
            //    try
            //    {
            //        string cat = "";
            //        dSCierre.Clear();
            //        dSKPM.Clear();
            //        DataTable KPM = dbVencidos.getKPMVencidos(SELECTED);
            //        foreach (DataRow row in SELECTED.CONTRATOS_VENCIDOS)
            //        {
            //            if (row.Field<string>("ARTICULO").StartsWith("ORO"))
            //            {
            //                cat = "ORO";
            //            }
            //            else
            //            {
            //                cat = "ARTICULO";
            //            }
            //            dSCierre.LISTA_CIERRE.AddLISTA_CIERRERow(row.Field<bool>("REACTIVADO"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), cat, row.Field<string>("ARTICULO"), row.Field<decimal>("TOTAL"), row.Field<decimal>("SALDO"), row.Field<DateTime>("FECHA_VENC"), row.Field<int>("DIAS_TRANS"));
            //        }
            //        bsListaCierre.DataSource = dSCierre.LISTA_CIERRE;

            //        foreach (DataRow row in KPM.Rows)
            //        {
            //            dSKPM.KPM.AddKPMRow(row.Field<string>("KILATAJE"), row.Field<double>("PESO"), row.Field<decimal>("MONTO"));
            //        }
            //        bsKPM.DataSource = dSKPM.KPM;

            //        ReportParameter[] parameters = new ReportParameter[5];
            //        parameters[0] = new ReportParameter("SUCURSAL", SELECTED.SUCURSAL);
            //        parameters[1] = new ReportParameter("numCIERRE", SELECTED.NUMCIERRE);
            //        parameters[2] = new ReportParameter("fechaCierre", SELECTED.FECHA_CIERRE.ToString("dd/MM/yyyy"));
            //        parameters[3] = new ReportParameter("responsableCierre", SELECTED.RESPONSABLE);
            //        parameters[4] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));
            //        viewerCIERRE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ListaCierre.rdlc";
            //        viewerCIERRE.LocalReport.DataSources.Clear();
            //        viewerCIERRE.LocalReport.DataSources.Add(new ReportDataSource("CONTRATOS", bsListaCierre));
            //        viewerCIERRE.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubInformeKPMHandler);
            //        viewerCIERRE.LocalReport.SetParameters(parameters);
            //        viewerCIERRE.RefreshReport();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("ERROR al generar reporte : Lista de cierre .... intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }


        

        private void SubInformeKPMHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("KPM", bsKPM));
        }





        

    }
}
