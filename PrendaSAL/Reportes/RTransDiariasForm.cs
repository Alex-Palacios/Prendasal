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

    public partial class RTransDiariasForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RTransDiariasForm frmInstance = null;

        public static RTransDiariasForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RTransDiariasForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBReporte dbReportes;
        private DataTable TRANSACCIONES;

        public RTransDiariasForm()
        {
            InitializeComponent();
            dbReportes = new DBReporte();
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

        private void RDiarioForm_Load(object sender, EventArgs e)
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
            dateINICIO.Value = HOME.Instance().FECHA_SISTEMA;
            dateFIN.Value = HOME.Instance().FECHA_SISTEMA;
        }



        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            viewerREPORTE.Clear();
            if (cbxSUCURSAL.SelectedIndex >= 0)
            {
                if (dateINICIO.Value != null && dateFIN.Value != null && dateINICIO.Value.Date <= dateFIN.Value.Date)
                {
                    Sucursal SUC = new Sucursal();
                    if ((string)cbxSUCURSAL.SelectedValue != "00")
                    {
                        SUC = HOME.Instance().getSucursal((string)cbxSUCURSAL.SelectedValue).Copy();
                    }
                    else
                    {
                        SUC.COD_SUC = "00";
                        SUC.SUCURSAL = "TODAS LAS SUCURSALES";
                    }
                    TRANSACCIONES = dbReportes.RptTransDiarias((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date, dateFIN.Value.Date);
                    DataTable KPM = dbReportes.getKPMTransDiarias((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date, dateFIN.Value.Date);
                    dSReporteDiario.Clear();
                    dSKPM.Clear();
                    try
                    {
                        foreach (DataRow row in TRANSACCIONES.Rows)
                        {
                            dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"), row.Field<DateTime>("FECHA"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<string>("RESPONSABLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"));
                        }
                        bsTransacciones.DataSource = dSReporteDiario.TRANSACCIONES;
                        // KPM COMPRA
                        foreach (DataRow row in KPM.Rows)
                        {
                            dSKPM.KPM.AddKPMRow(row.Field<string>("KILATAJE"), row.Field<decimal>("PESO"), row.Field<decimal>("MONTO"));
                        }
                        bsKPM.DataSource = dSKPM.KPM;
                        //PARAMETROS
                        ReportParameter[] parameters = new ReportParameter[4];
                        parameters[0] = new ReportParameter("SUCURSAL", SUC.SUCURSAL);
                        parameters[1] = new ReportParameter("FechaInicio", dateINICIO.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[2] = new ReportParameter("FechaFin", dateFIN.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[3] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                        viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteTrans.rdlc";
                        viewerREPORTE.LocalReport.DataSources.Clear();
                        viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("ITEMS", bsTransacciones));
                        viewerREPORTE.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubInformeKPMHandler);
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
                    MessageBox.Show("Rango de Fechas Invalido", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione sucursal", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }





        private void SubInformeKPMHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("KPM", bsKPM));
        }



    }
}
