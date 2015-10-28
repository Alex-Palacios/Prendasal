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
    using Informes;

    public partial class CanceladosForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static CanceladosForm frmInstance = null;

        public static CanceladosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CanceladosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBReporte dbReportes;
        private DBUsuario dbUser;
        private DataTable SUCURSALES;
        private DataTable CANCELADOS;


        public CanceladosForm()
        {
            InitializeComponent();
            dbReportes = new DBReporte();
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

        private void CanceladosForm_Load(object sender, EventArgs e)
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
                    CANCELADOS = dbReportes.CONTRATOS_CANCELADOS_PRENDASAL((string)cbxSUCURSAL.SelectedValue, dateINICIO.Value.Date, dateFIN.Value.Date);
                    dSCancelados.Clear();
                    try
                    {
                        foreach (DataRow row in CANCELADOS.Rows)
                        {
                            dSCancelados.CANCELADOS.AddCANCELADOSRow(row.Field<string>("SUCURSAL"), row.Field<string>("CONTRATO"), row.Field<string>("CLIENTE"),  row.Field<string>("CATEGORIA"),row.Field<string>("ARTICULO"), row.Field<string>("TELEFONO"), row.Field<DateTime>("FECHA"));
                        }

                        bindingReporte.DataSource = dSCancelados.CANCELADOS;

                        ReportParameter[] parameters = new ReportParameter[3];
                        parameters[0] = new ReportParameter("FechaInicio", dateINICIO.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[1] = new ReportParameter("FechaFin", dateFIN.Value.Date.ToString("dd/MM/yyyy"));
                        parameters[2] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                        viewerCANCEL.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ContratosCancelados.rdlc";
                        viewerCANCEL.LocalReport.DataSources.Clear();
                        viewerCANCEL.LocalReport.DataSources.Add(new ReportDataSource("CANCELADOS", bindingReporte));
                        viewerCANCEL.LocalReport.SetParameters(parameters);
                        viewerCANCEL.RefreshReport();
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



    }
}
