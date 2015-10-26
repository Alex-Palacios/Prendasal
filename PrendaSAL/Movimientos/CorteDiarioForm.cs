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
using ControlesPersonalizados;

namespace PrendaSAL.Movimientos
{

    using LOGICA;
    using MODELO;
    using DDB;
    using Informes;

    public partial class CorteDiarioForm : Form
    {


        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static CorteDiarioForm frmInstance = null;

        public static CorteDiarioForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CorteDiarioForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private ReporteController dbReportes;
        private DBUsuario dbUser;
        private DataTable DIAS_ABIERTOS;
        private DataTable CORTE_DIARIO;
        private DateTime FECHA_CORTE;





        public CorteDiarioForm()
        {
            InitializeComponent();
            dbReportes = new ReporteController();
            dbUser = new DBUsuario();
        }


        private void permisos()
        {
            btnCARGAR.Visible = false;
            btnCORTE_DIARIO.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P12")
                {
                    btnCARGAR.Visible = p.Field<bool>("BUSCAR");
                    btnCORTE_DIARIO.Visible = p.Field<bool>("REGISTRAR");
                }
            }
        }



        private void CorteDiarioForm_Load(object sender, EventArgs e)
        {
            permisos();
            btnCORTE_DIARIO.Enabled = false;
            listarDiasAbiertos();
        }



        private void listarDiasAbiertos()
        {
            DIAS_ABIERTOS = dbReportes.DIAS_ABIERTOS_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC);
            cbxCORTE.DataSource = DIAS_ABIERTOS;
            cbxCORTE.DisplayMember = "FECHA";
            FECHA_CORTE = new DateTime();
            lbFECHA_CORTE.Text = "N/A";
            btnCORTE_DIARIO.Enabled = false;
        }



        private void btnCARGAR_Click(object sender, EventArgs e)
        {
            if (cbxCORTE.SelectedIndex >= 0 && HOME.Instance().SUCURSAL != null)
            {
                FECHA_CORTE = DateTime.Parse(cbxCORTE.Text);
                decimal APERTURA = dbReportes.FN_CALCULAR_APERTURA_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC, FECHA_CORTE);
                CORTE_DIARIO = dbReportes.REPORTE_DIARIO_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC, FECHA_CORTE, FECHA_CORTE);
                DataTable COMPRAS_KIL = dbReportes.COMPRAS_KIL_DIARIO(HOME.Instance().SUCURSAL.COD_SUC, FECHA_CORTE, FECHA_CORTE);
                dSReporteDiario.Clear();
                dSKPM.Clear();
                try
                {
                    foreach (DataRow row in CORTE_DIARIO.Rows)
                    {
                        switch (row.Field<string>("CONCEPTO"))
                        {
                            case "PRESTAMO":
                                dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"),row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
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
                                dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                break;
                            case "INTERES":
                                dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"),"R/N°: "+ row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                break;
                            case "ABONO":
                                dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "R/N°: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                break;
                            case "CANCELADO":
                                dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<DateTime>("FECHA"), "R/N°: " + row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"), row.Field<string>("RESPONSABLE"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"));
                                break;
                            
                        }
                    }

                    bsReporteDiario.DataSource = dSReporteDiario.TRANSACCIONES;
                    // INVENTARIO COMPRA
                    foreach (DataRow row in COMPRAS_KIL.Rows)
                    {
                        dSKPM.KPM.AddKPMRow(row.Field<string>("KILATAJE"), row.Field<decimal>("PESO"), row.Field<decimal>("MONTO"));
                    }
                    bsKPM.DataSource = dSKPM.KPM;

                    ReportParameter[] parameters = new ReportParameter[6];
                    parameters[0] = new ReportParameter("Sucursal", DIAS_ABIERTOS.Rows[cbxCORTE.SelectedIndex].Field<string>("COD_SUC")+" - " + DIAS_ABIERTOS.Rows[cbxCORTE.SelectedIndex].Field<string>("SUCURSAL"));
                    parameters[1] = new ReportParameter("DireccionSUC", DIAS_ABIERTOS.Rows[cbxCORTE.SelectedIndex].Field<string>("DIRECCION_SUC"));
                    parameters[2] = new ReportParameter("TelSUC", "TELEFONO: " + DIAS_ABIERTOS.Rows[cbxCORTE.SelectedIndex].Field<string>("TEL_SUC"));
                    parameters[3] = new ReportParameter("Fecha", DIAS_ABIERTOS.Rows[cbxCORTE.SelectedIndex].Field<DateTime>("FECHA").ToString("dd/MM/yyyy"));
                    parameters[4] = new ReportParameter("APERTURA", APERTURA.ToString());
                    parameters[5] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.CorteDiario.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("ITEMS", bsReporteDiario));
                    viewerREPORTE.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubInformeKPMHandler);
                    viewerREPORTE.LocalReport.SetParameters(parameters);
                    viewerREPORTE.RefreshReport();
                    lbFECHA_CORTE.Text = FECHA_CORTE.Date.ToString("dd/MM/yyyy");
                    btnCORTE_DIARIO.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR al recuperar datos .... verifique que fecha inicial sea una fecha valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FECHA_CORTE = new DateTime();
                    lbFECHA_CORTE.Text = "N/A";
                    btnCORTE_DIARIO.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione Fecha y sucursal", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FECHA_CORTE = new DateTime();
                lbFECHA_CORTE.Text = "N/A";
                btnCORTE_DIARIO.Enabled = false;
            }
        }





        private void SubInformeKPMHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("KPM", bsKPM));
        }




        private void btnCORTE_DIARIO_Click(object sender, EventArgs e)
        {
            if (lbFECHA_CORTE.Text != "N/A" && HOME.Instance().SUCURSAL != null)
            {
                DialogResult eliminar = MessageBox.Show("¿REALIZAR CORTE DEL " + FECHA_CORTE.Date.ToString("dd/MM/yyyy") + "\nAl cerrar del dia se contabilizaran las transacciones y no se podra modificar la informacion ingresada .... asegurese que los datos sean validos ", "CORTE DIARIO DEL " + FECHA_CORTE.Date.ToString("dd/MM/yyyy"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbReportes.CERRAR_DIA_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC, FECHA_CORTE, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            listarDiasAbiertos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Fecha t sucursal", "FECHA INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }




    }
}
