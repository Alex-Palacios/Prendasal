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

    public partial class RVencidosOroForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RVencidosOroForm frmInstance = null;

        public static RVencidosOroForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RVencidosOroForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBReporte dbReportes;
        private DBVencidos dbVencidos;
        private DataTable LISTAS;
        private DataTable VENCIDOS_ORO;

        private void permisos()
        {
            
        }


        public RVencidosOroForm()
        {
            InitializeComponent(); 
            dbReportes = new DBReporte();
            dbVencidos = new DBVencidos();
        }


        

        private void ComprasOroForm_Load(object sender, EventArgs e)
        {
            permisos();
            dateVenc.Value = HOME.Instance().FECHA_SISTEMA;
            
        }



        private void dateVenc_ValueChanged(object sender, EventArgs e)
        {
            LISTAS = dbVencidos.showListaVencByFecha(dateVenc.Value);
            if (LISTAS.Rows.Count > 0)
            {
                DataRow R = LISTAS.NewRow();
                R.SetField<int>("ID_VENC", 0);
                R.SetField<string>("COD_SUC", "00");
                R.SetField<string>("COD_TRANS", "00000000");
                R.SetField<DateTime>("FECHA", DateTime.Today);
                R.SetField<string>("DOCUMENTO", "TODAS");
                R.SetField<int>("ESTADO", 0);
                R.SetField<bool>("INIT_BALANCE",false);
                LISTAS.Rows.InsertAt(R, 0);
            }
            cbxListas.DataSource = LISTAS;
            if (((DataTable)cbxListas.DataSource).Rows.Count > 0)
            {
                cbxListas.ValueMember = "DOCUMENTO";
                cbxListas.DisplayMember = "DOCUMENTO";
            }
            
        }


        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            viewerREPORTE.Clear();
            if (dateVenc.Value != null && cbxListas.SelectedIndex >= 0)
            {
                DateTime fecha = dateVenc.Value;
                string lista = (string) cbxListas.SelectedValue;
                VENCIDOS_ORO = dbReportes.RptVencidosOroByList(fecha,lista );
                dSVencidosOro.Clear();
                try
                {
                    foreach (DataRow row in VENCIDOS_ORO.Rows)
                    {
                        Sucursal SUC = HOME.Instance().getSucursal(row.Field<string>("COD_SUC")).Copy();
                        dSVencidosOro.VENCIDOS_ORO.AddVENCIDOS_ORORow(SUC.SUCURSAL + " - LISTA #" + row.Field<string>("LISTA") + " - " + row.Field<DateTime>("FECHA_VENC").ToShortDateString(), row.Field<int>("ID_PRESTAMO"), row.Field<string>("CONTRATO"), row.Field<DateTime>("FECHA_CONTRATO"), row.Field<string>("ARTICULO"), row.Field<string>("COD_ITEM"), row.Field<decimal>("CANTIDAD"), row.Field<decimal>("MONTO"), row.Field<string>("RESPONSABLE"), row.Field<decimal>("TOTAL"), row.Field<decimal>("SALDO"));
                    }
                    bsVencidosOro.DataSource = dSVencidosOro.VENCIDOS_ORO;

                    ReportParameter[] parameters = new ReportParameter[1];
                    parameters[0] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteVencidosOro.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("VENCIDOSKIL", bsVencidosOro));
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
