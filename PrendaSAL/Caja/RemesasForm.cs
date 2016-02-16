using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesPersonalizados;
using Microsoft.Reporting.WinForms;

namespace PrendaSAL.Caja
{
    using DDB;
    using MODELO;

    public partial class RemesasForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RemesasForm frmInstance = null;

        public static RemesasForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RemesasForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }




        //variables
        private DBUsuario dbUser;
        private DBMovCash dbRemesa;

        private eOperacion ACCION;
        private MovCash SELECTED;
        private DataTable REMESAS;

        public RemesasForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbRemesa = new DBMovCash();
        }


        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnAnular.Visible = false;
            btnEliminar.Visible = false;
            btnLog.Visible = false;
            btnReimprimir.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P10")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }
        }


        private void RemesasForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblRemesas.AutoGenerateColumns = false;
            cargarHistoryRemesa();
        }


        public void cargarHistoryRemesa()
        {
            REMESAS = dbRemesa.getRemesasBySucAnioMes(HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().FECHA_SISTEMA.Year.ToString(), HOME.Instance().FECHA_SISTEMA.Month.ToString(), "00");
            tblRemesas.DataSource = REMESAS;
            calcularTotales();
        }



        private void calcularTotales()
        {
            decimal TOTAL = tblRemesas.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["TOTAL"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL.Text = TOTAL.ToString("C2");
        }



        private void cargarSelected()
        {
            SELECTED = null;
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                SELECTED = MovCash.ConvertToMovCash(REMESAS.Rows[tblRemesas.CurrentCell.RowIndex]);
            }
        }



        private void tblRemesas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblRemesas.Columns[e.ColumnIndex].Name)
                {
                    case "NUM":
                        e.Value = e.RowIndex + 1;
                        break;
                }
            }
        }




        private bool buscarRemesa(string comprobante)
        {
            bool OK = false;
            SELECTED = MovCash.ConvertToMovCash(dbRemesa.findByComprobante(comprobante));
            if (SELECTED != null)
            {
                OK = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }



        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            ConfirmarRemesa financ = new ConfirmarRemesa();
            financ.ShowDialog();
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ACCION = eOperacion.UPDATE;
                    ConfirmarRemesa financ = new ConfirmarRemesa(SELECTED);
                    financ.ShowDialog();
                }
                else
                {
                    MessageBox.Show("SELECCIONE REMESA", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null )
                {
                    ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la REMESA con comprobante # " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR REMESA REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbRemesa.delete(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                cargarHistoryRemesa();
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
                    MessageBox.Show("SELECCIONE REMESA", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }






        public void IMPRIMIR(MovCash REMESA)
        {
            SELECTED = null;
            if (REMESA != null)
            {
                if (buscarRemesa(REMESA.DOCUMENTO))
                {
                    cargarHistoryRemesa();
                    if (SELECTED != null)
                    {
                        ImprimirComprobanteRemesa();
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL IMPRIMIR COMPROBANTE DE MOVIMIENTO DE EFECTIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR AL IMPRIMIR COMPROBANTE DE MOVIMIENTO DE EFECTIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }



        private void REIMPRIMIR(object sender, EventArgs e)
        {
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ImprimirComprobanteRemesa();
                }
            }
        }





        private void ImprimirComprobanteRemesa()
        {
            viewerCOMPROBANTE.Clear();
            if (SELECTED != null)
            {
                Sucursal SUC = HOME.Instance().getSucursal(SELECTED.SUC_ENVIA).Copy();

                ReportParameter[] parameters = new ReportParameter[8];
                parameters[0] = new ReportParameter("TICKET", SELECTED.DOCUMENTO);
                parameters[1] = new ReportParameter("FECHA", SELECTED.FECHA.Date.ToString("dd/MM/yyyy"));
                parameters[2] = new ReportParameter("ENVIA", SUC.SUCURSAL);
                parameters[3] = new ReportParameter("DESTINO", SELECTED.DESTINO);
                parameters[4] = new ReportParameter("TOTAL", SELECTED.TOTAL.ToString("C2"));
                parameters[5] = new ReportParameter("RESPONSABLE", SELECTED.RESPONSABLE);
                parameters[6] = new ReportParameter("TRASLADA", SELECTED.TRASLADA);
                parameters[7] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                viewerCOMPROBANTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.TicketMovCash.rdlc";
                viewerCOMPROBANTE.LocalReport.SetParameters(parameters);
                viewerCOMPROBANTE.RefreshReport();
            }
        }


        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerCOMPROBANTE.PrintDialog();
            }
        }

        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }

        private void ANULAR(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> AMS = Controles.InputComboBoxAMS("BUSCAR POR", HOME.Instance().datSUCURSALES.Copy());
            if (AMS != null && AMS.Count == 3)
            {
                REMESAS = dbRemesa.getRemesasBySucAnioMes(HOME.Instance().SUCURSAL.COD_SUC,AMS[0],AMS[1],AMS[2]);
                tblRemesas.DataSource = REMESAS;
                calcularTotales();
            }
        }


        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (REMESAS != null)
            {
                HOME.Instance().exportDataGridViewToExcel("REMESAS", tblRemesas.Columns, REMESAS, "Remesas");
            }
        }


    }
}
