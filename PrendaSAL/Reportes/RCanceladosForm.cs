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

    public partial class RCanceladosForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RCanceladosForm frmInstance = null;

        public static RCanceladosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RCanceladosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBReporte dbReportes;
        private DataTable CANCELADOS;


        public RCanceladosForm()
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

        private void CanceladosForm_Load(object sender, EventArgs e)
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
            viewerCANCEL.Clear();
            if (cbxSUCURSAL.SelectedIndex >= 0)
            {
                if (dateINICIO.Value != null && dateFIN.Value != null && dateINICIO.Value.Date <= dateFIN.Value.Date)
                {
                    CANCELADOS = dbReportes.RptContratosCancelados((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date, dateFIN.Value.Date);
                    dSCancelados.Clear();
                    try
                    {
                        foreach (DataRow row in CANCELADOS.Rows)
                        {
                            Sucursal SUC = HOME.Instance().getSucursal(row.Field<string>("COD_SUC")).Copy();
                            dSCancelados.CANCELADOS.AddCANCELADOSRow(SUC.SUCURSAL, row.Field<string>("CONTRATO"), row.Field<string>("CLIENTE"),  row.Field<string>("CATEGORIA"),row.Field<string>("ARTICULO"), row.Field<string>("TELEFONO"), row.Field<DateTime>("FECHA_CANCELADO"));
                        }

                        bindingReporte.DataSource = dSCancelados.CANCELADOS;

                        ReportParameter[] parameters = new ReportParameter[3];
                        parameters[0] = new ReportParameter("FechaInicio", dateINICIO.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[1] = new ReportParameter("FechaFin", dateFIN.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[2] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                        viewerCANCEL.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ReporteCancelados.rdlc";
                        viewerCANCEL.LocalReport.DataSources.Clear();
                        viewerCANCEL.LocalReport.DataSources.Add(new ReportDataSource("CANCELADOS", bindingReporte));
                        viewerCANCEL.LocalReport.SetParameters(parameters);
                        viewerCANCEL.RefreshReport();
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
                MessageBox.Show("Seleccione Sucursal", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }



    }
}
