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

    public partial class RConsolidadoForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RConsolidadoForm frmInstance = null;

        public static RConsolidadoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RConsolidadoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBReporte dbReportes;
        private DataTable RESUMEN;


        public RConsolidadoForm()
        {
            InitializeComponent();
            dbReportes = new DBReporte();
        }

        private void permisos()
        {
            
        }

        private void RConsolidadoForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblSUCURSALES.AutoGenerateColumns = false;
            tblMESES.AutoGenerateColumns = false;

            tblMESES.Columns["CKMESES"].ReadOnly = false;
            tblMESES.Columns["NOMBRE"].ReadOnly = true;

            tblSUCURSALES.Columns["CKSUC"].ReadOnly = false;
            tblSUCURSALES.Columns["COD_SUC"].ReadOnly = true;
            tblSUCURSALES.Columns["SUCURSAL"].ReadOnly = true;

            txtANIO.Text = ""+HOME.Instance().FECHA_SISTEMA.Year;
            tblMESES.DataSource = Enum.GetValues(new eMESES().GetType());
            DataTable meses = new DataTable();
            meses.Columns.Add("MES", Enum.GetUnderlyingType(new eMESES().GetType()));
            meses.Columns.Add("NOMBRE", typeof(string));
            //Add the items from the enum:
            foreach (string name in Enum.GetNames(new eMESES().GetType()))
            {
                //Replace underscores with space from caption/key and add item to collection:
                meses.Rows.Add( Enum.Parse(new eMESES().GetType(), name),name.Replace('_', ' '));
            }
            tblMESES.DataSource = meses;
            tblSUCURSALES.DataSource = HOME.Instance().datSUCURSALES.Copy();

            ckPrestamos.Checked = true;
            ckCompras.Checked = true;
            ckVentas.Checked = true;
            ckIntereses.Checked = true;
            ckAbonos.Checked = true;

            ckMostrarGraficos.Checked = true;
        }




        private void ckAllMeses_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblMESES.Rows)
            {
                row.Cells["CKMESES"].Value = ckAllMeses.Checked;
            }
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
            if (txtANIO.Text.Trim() != string.Empty )
            {
                string meses = string.Empty;
                string sucursales = string.Empty;

                foreach (DataGridViewRow mesRow in tblMESES.Rows)
                {
                    if ((bool)mesRow.Cells["CKMESES"].FormattedValue)
                    {
                        if (meses == string.Empty)
                        {
                            meses = meses + mesRow.Cells["MES"].Value;
                        }
                        else
                        {
                            meses = meses + "," + mesRow.Cells["MES"].Value;
                        }
                    }
                    
                }
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

                if(meses != string.Empty)
                {
                    if (sucursales != string.Empty)
                    {
                        if (!(ckPrestamos.Checked == false && ckCompras.Checked == false && ckVentas.Checked == false && ckIntereses.Checked == false && ckAbonos.Checked == false))
                        {
                            RESUMEN = dbReportes.RptConsolidado(txtANIO.Text.Trim(), meses, sucursales, ckPrestamos.Checked, ckCompras.Checked, ckVentas.Checked, ckIntereses.Checked, ckAbonos.Checked);
                            dSConsolidado.Clear();
                            try
                            {
                                foreach (DataRow row in RESUMEN.Rows)
                                {
                                    eMESES MES;
                                    if (row.Table.Columns["MES"].DataType == Type.GetType("System.Int32"))
                                    {
                                        MES = (eMESES)row.Field<Int32>("MES");
                                    }
                                    else
                                    {
                                        MES = (eMESES)row.Field<Int64>("MES");
                                    }

                                    dSConsolidado.RESUMEN.AddRESUMENRow(row.Field<string>("COD_SUC"), row.Field<string>("SUCURSAL"), row.Field<string>("CONCEPTO"), MES.ToString(), row.Field<Int64>("CANTIDAD"), row.Field<decimal>("MONTO"));
                                }
                                bsRptConsolidado.DataSource = dSConsolidado.RESUMEN;

                                ReportParameter[] parameters = new ReportParameter[2];
                                parameters[0] = new ReportParameter("mostrarGraficos", ckMostrarGraficos.Checked.ToString());
                                parameters[1] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                                viewerREPORTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.RptConsolidado.rdlc";
                                viewerREPORTE.LocalReport.DataSources.Clear();
                                viewerREPORTE.LocalReport.DataSources.Add(new ReportDataSource("RESUMEN", bsRptConsolidado));
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
                            MessageBox.Show("Seleccione al menos un tipo de transaccion", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Seleccione al menos una SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione al menos un MES", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Parametros incompletos", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        


    }
}
