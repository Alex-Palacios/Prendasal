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
        private DBCorteDiario dbCorte;
        private DBUsuario dbUser;

        private DateTime FECHA;
        private CorteDiario SELECTED;
        private DataTable CORTES_DIARIOS;

        private eOperacion ACCION;





        public CorteDiarioForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbCorte = new DBCorteDiario();
        }


        private void permisos()
        {
            
            btnGUARDAR.Visible = false;
            btnELIMINAR.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P12")
                {
                    btnGUARDAR.Enabled = p.Field<bool>("REGISTRAR");
                    btnELIMINAR.Enabled = p.Field<bool>("ELIMINAR");
                }
            }

            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.Enabled = true;
            }
        }



        private void CorteDiarioForm_Load(object sender, EventArgs e)
        {
            permisos();
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            //PERSONALIZAR FORMATO
            calendarCORTE.Colors.Today.TextColor = Color.Red;
            calendarCORTE.Colors.DayMarker.IsBold = true;
            calendarCORTE.Colors.DayMarker.TextColor = Color.Blue;
            FECHA = HOME.Instance().FECHA_SISTEMA;
            calendarCORTE.TodayDate = FECHA;
            calendarCORTE.SelectedDate = FECHA;
            listarCortesDiarios();

        }



        private void listarCortesDiarios()
        {
            CORTES_DIARIOS = dbCorte.getCorteDiarioBySucAnio((string)cbxSUCURSAL.SelectedValue, FECHA.Year);
            calendarCORTE.RemoveAllMarkedDates();
            List<DateTime> marcas = new List<DateTime>(); 
            foreach(DataRow row in CORTES_DIARIOS.Rows)
            {
                marcas.Add(row.Field<DateTime>("FECHA"));
            }
            calendarCORTE.MarkedDates = marcas.ToArray();
            calendarCORTE.UpdateMarkedDates();
            btnGUARDAR.Visible = false;
            btnELIMINAR.Visible = false;
            
        }



        private void calendarCORTE_DateSelected(object sender, DateRangeEventArgs e)
        {
            FECHA = e.Start;
        }


        private void calendarCIERRE_MonthChanged(object sender, EventArgs e)
        {

            if (calendarCORTE.DisplayMonth.Year != FECHA.Year)//CAMBIO DE AÑO
            {
                FECHA = calendarCORTE.DisplayMonth;
                listarCortesDiarios();
            }
            else if (calendarCORTE.DisplayMonth.Month != FECHA.Month)//CAMBIO DE MES
            {
                FECHA = calendarCORTE.DisplayMonth;
            }
            calendarCORTE.SelectedDate = FECHA;
        }


        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != string.Empty && cbxSUCURSAL.SelectedIndex >= 0)
            {
                listarCortesDiarios();
            }
        }




        private void calendarCORTE_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            viewerREPORTE.Clear();
            HOME.Instance().progress.Value = 0;
            viewerREPORTE.ShowToolBar = false;
            try
            {
                SELECTED = null;
                foreach (DataRow row in CORTES_DIARIOS.Rows)
                {
                    if (FECHA == row.Field<DateTime>("FECHA"))
                    {
                        SELECTED = CorteDiario.ConvertToCorteDiario(row);
                        if (SELECTED != null)
                        {
                            SELECTED.MOVIMIENTOS = dbCorte.getItemsCorteDiario(SELECTED);
                            SELECTED.KPM = dbCorte.getKPMCorteDiario(SELECTED);
                        }
                        break;
                    }
                }
                HOME.Instance().progress.Value = 10;
                if (SELECTED == null)
                {
                    ACCION = eOperacion.INSERT;
                    btnGUARDAR.Visible = true;
                    btnELIMINAR.Visible = false;
                    viewerREPORTE.ShowToolBar = false;
                    NUEVO();
                }
                else
                {
                    ACCION = eOperacion.UPDATE;
                    btnGUARDAR.Visible = false;
                    btnELIMINAR.Visible = true;
                    viewerREPORTE.ShowToolBar = true;

                    cargarCorteDiarioSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL CARGAR REPORTE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HOME.Instance().progress.Value = 100;
            HOME.Instance().progress.Value = 0;
        }






        private void NUEVO()
        {
            SELECTED = new CorteDiario();
            SELECTED.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
            SELECTED.FECHA = FECHA;
            SELECTED.COD_EMPLEADO = HOME.Instance().USUARIO.COD_EMPLEADO;
            SELECTED.SALDO_INICIAL = dbCorte.getSaldoInicial(SELECTED.COD_SUC,SELECTED.FECHA);
            SELECTED.SALDO_FINAL = SELECTED.SALDO_INICIAL;
            HOME.Instance().progress.Value = 20;
            SELECTED.MOVIMIENTOS = dbCorte.getItemsCorteDiario(SELECTED);
            HOME.Instance().progress.Value = 30;
            SELECTED.KPM = dbCorte.getKPMCorteDiario(SELECTED);
            HOME.Instance().progress.Value = 40;
            cargarCorteDiarioSelected();

        }




        private void cargarCorteDiarioSelected()
        {
            viewerREPORTE.Clear();
            if (SELECTED != null)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(SELECTED.COD_SUC).Copy();
                    dSReporteDiario.Clear();
                    dSKPM.Clear();
                    // MOVIMIENTOS
                    foreach (DataRow row in SELECTED.MOVIMIENTOS.Rows)
                    {
                        if (ACCION == eOperacion.INSERT)
                        {
                            SELECTED.SALDO_FINAL = SELECTED.SALDO_FINAL + row.Field<decimal>("INGRESO") - row.Field<decimal>("EGRESO");
                        }
                        dSReporteDiario.TRANSACCIONES.AddTRANSACCIONESRow(row.Field<string>("CONCEPTO"), row.Field<string>("COD_TRANS"), row.Field<string>("COD_SUC"), row.Field<DateTime>("FECHA"), row.Field<string>("DOCUMENTO"), row.Field<string>("CLIENTE"), row.Field<string>("DETALLE"), row.Field<string>("RESPONSABLE"), row.Field<decimal>("INGRESO"), row.Field<decimal>("EGRESO"));
                    }
                    bsReporteDiario.DataSource = dSReporteDiario.TRANSACCIONES; 
                    HOME.Instance().progress.Value = 75;
                    // KPM COMPRA
                    foreach (DataRow row in SELECTED.KPM.Rows)
                    {
                        dSKPM.KPM.AddKPMRow(row.Field<string>("KILATAJE"), row.Field<decimal>("PESO"), row.Field<decimal>("MONTO"));
                    }
                    bsKPM.DataSource = dSKPM.KPM;
                    HOME.Instance().progress.Value = 90;
                    ReportParameter[] parameters = new ReportParameter[7];
                    parameters[0] = new ReportParameter("SUCURSAL", SUC.COD_SUC + "-" + SUC.SUCURSAL);
                    parameters[1] = new ReportParameter("DireccionSUC", SUC.DIRECCION);
                    parameters[2] = new ReportParameter("TelSUC", "TELEFONO: " + SUC.TEL);
                    parameters[3] = new ReportParameter("FECHA", SELECTED.FECHA.ToShortDateString());
                    parameters[4] = new ReportParameter("SALDO_INICIAL", SELECTED.SALDO_INICIAL.ToString("C2"));
                    parameters[5] = new ReportParameter("SALDO_FINAL", SELECTED.SALDO_FINAL.ToString("C2"));
                    parameters[6] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteDiario.rdlc";
                    viewerREPORTE.LocalReport.DataSources.Clear();
                    viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("ITEMS", bsReporteDiario));
                    viewerREPORTE.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubInformeKPMHandler);
                    viewerREPORTE.LocalReport.SetParameters(parameters);
                    viewerREPORTE.RefreshReport();

                    btnGUARDAR.Text = "GUARDAR CORTE DEL " + SELECTED.FECHA.ToShortDateString();
                    btnELIMINAR.Text = "DESHACER CORTE DEL " + SELECTED.FECHA.ToShortDateString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL CARGAR REPORTE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void SubInformeKPMHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("KPM", bsKPM));
        }




        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (SELECTED != null && ACCION == eOperacion.INSERT)
            {
                DialogResult guardar = MessageBox.Show("¿REALIZAR CORTE DIARIO DEL " + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + "\nTenga en cuenta que al cerrar del dia no se podra modificar la informacion ingresada .... asegurese que los datos sean validos ", "CORTE DIARIO DEL " + SELECTED.FECHA.Date.ToString("dd/MM/yyyy"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (guardar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbCorte.insert(SELECTED,HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            listarCortesDiarios();

                            viewerREPORTE.ShowToolBar = true;
                            btnGUARDAR.Visible = false;
                            btnELIMINAR.Visible = true;
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
                MessageBox.Show("CARGUE PRIMERO EL REPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (SELECTED != null && ACCION == eOperacion.UPDATE)
            {
                DialogResult eliminar = MessageBox.Show("¿ABRIR CAJA DEL " + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + "\n", "REAPERTURAR CAJA DEL " + SELECTED.FECHA.Date.ToString("dd/MM/yyyy"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbCorte.delete(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            listarCortesDiarios();
                            ACCION = eOperacion.INSERT;
                            viewerREPORTE.ShowToolBar = false;
                            btnGUARDAR.Visible = true;
                            btnELIMINAR.Visible = false;
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
                MessageBox.Show("CARGUE PRIMERO EL REPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
