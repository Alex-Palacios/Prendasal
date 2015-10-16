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
    using LOGICA;
    using MODELO;
    using DDB;
    using Informes;

    public partial class RDiarioForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RDiarioForm frmInstance = null;

        public static RDiarioForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RDiarioForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private ReporteController dbReportes;
        private DBUsuario dbUser;
        private DataTable SUCURSALES;
        private DataTable TRANSACCIONES;

        public RDiarioForm()
        {
            InitializeComponent();
            dbReportes = new ReporteController();
            dbUser = new DBUsuario();
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
            dateINICIO.Value = HOME.Instance().FECHA_SISTEMA;
            dateFIN.Value = HOME.Instance().FECHA_SISTEMA;
        }



        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.SelectedIndex >= 0)
            {
                if (dateINICIO.Value != null && dateFIN.Value != null && dateINICIO.Value.Date <= dateFIN.Value.Date)
                {
                    decimal APERTURA = dbReportes.FN_CALCULAR_APERTURA_PRENDASAL((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date);
                    TRANSACCIONES = dbReportes.REPORTE_DIARIO_PRENDASAL((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date, dateFIN.Value.Date);
                    DataTable KPM = dbReportes.COMPRAS_KIL_DIARIO((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date, dateFIN.Value.Date);
                    dSReporteDiario.Clear();
                    dSKPM.Clear();
                    try
                    {
                        foreach (DataRow row in TRANSACCIONES.Rows)
                        {
                            switch (row.Field<string>("CONCEPTO"))
                            {
                                case "PRESTAMO":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "COMPRA":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "GASTO":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), ((eTipoDocGasto)row.Field<int>("TIPO_DOC")).ToString() + row.Field<string>("DOCUMENTO"), "GASTOS DE OFICINA", row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "REMESA":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "TK: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "FINANCIAMIENTO":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "TK: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "VENTA":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), ((eTipoDocVenta)row.Field<int>("TIPO_DOC")).ToString() + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "INTERES":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "R/N°: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "ABONO":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "R/N°: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;
                                case "CANCELADO":
                                    dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "R/N°: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                    break;

                            }
                        }
                        bsTransacciones.DataSource = dSReporteDiario.TRANSACCIONES;
                        // INVENTARIO COMPRA
                        foreach (DataRow row in KPM.Rows)
                        {
                            dSKPM.KPM.AddKPMRow(row.Field<string>("KILATAJE"), row.Field<double>("PESO"), row.Field<decimal>("MONTO"));
                        }
                        bsKPM.DataSource = dSKPM.KPM;
                        //PARAMETROS
                        ReportParameter[] parameters = new ReportParameter[5];
                        parameters[0] = new ReportParameter("Sucursal", SUCURSALES.Rows[cbxSUCURSAL.SelectedIndex].Field<string>("SUCURSAL"));
                        parameters[1] = new ReportParameter("FechaInicio", dateINICIO.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[2] = new ReportParameter("FechaFin", dateFIN.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[3] = new ReportParameter("APERTURA", APERTURA.ToString());
                        parameters[4] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                        viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteDiario.rdlc";
                        viewerREPORTE.LocalReport.DataSources.Clear();
                        viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("ITEMS", bsTransacciones));
                        viewerREPORTE.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubInformeKPMHandler);
                        viewerREPORTE.LocalReport.SetParameters(parameters);
                        viewerREPORTE.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR al recuperar datos .... verifique parametros de entrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
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
