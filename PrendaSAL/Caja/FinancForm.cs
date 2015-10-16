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
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class FinancForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static FinancForm frmInstance = null;

        public static FinancForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FinancForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //variables
        private DBUsuario dbUser;
        private MovCashController dbFinanc;
        private eOperacion ACCION;

        private MovCash SELECTED;

        private DataTable FINANCIAMIENTOS;

        public FinancForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbFinanc = new MovCashController();
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
                if (p.Field<string>("CODIGO") == "P9")
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



        private void FinancForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblFinanc.AutoGenerateColumns = false;
            cargarHistoryFinanc();
        }


        public void cargarHistoryFinanc()
        {
            FINANCIAMIENTOS = dbFinanc.FINANC_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().FECHA_SISTEMA);
            tblFinanc.DataSource = FINANCIAMIENTOS;
        }




        private void tblFinanc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblFinanc.Columns[e.ColumnIndex].Name)
                {
                    case "TIPO_MOV":
                        eTipoMovCash tipomov = (eTipoMovCash)e.Value;
                        e.Value = tipomov.ToString();
                        break;
                    case "TIPO_DOC":
                        eTipoDocMovCash tipodoc = (eTipoDocMovCash)e.Value;
                        e.Value = tipodoc.ToString();
                        break;
                }
            }
        }

        private void cargarSelected()
        {
            SELECTED = null;
            if (tblFinanc.CurrentCell != null && tblFinanc.SelectedRows.Count == 1)
            {
                SELECTED = new MovCash();
                SELECTED.ID_MOV = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<int>("ID_MOV");
                SELECTED.TRANSACCION = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("COD_TRANS");
                SELECTED.RESPONSABLE = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("RESPONSABLE");
                SELECTED.SUC_ORIGEN = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("SUC_ORG");
                SELECTED.SUCURSAL_ENVIO = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("SUCURSAL_ORIGEN");
                SELECTED.FECHA = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<DateTime>("FECHA");
                SELECTED.TIPO_MOV = (eTipoMovCash) FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<int>("TIPO_MOV");
                SELECTED.TIPO_DOC = (eTipoDocMovCash)FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<int>("TIPO_DOC");
                SELECTED.DOCUMENTO = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("DOCUMENTO");
                SELECTED.TOTAL = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<decimal>("TOTAL");
                SELECTED.RESPONSABLE_ENVIO = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("ENVIA");
                SELECTED.SUC_DESTINO = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("SUC_DEST");
                SELECTED.SUCURSAL_DESTINO = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("SUCURSAL_DESTINO");
                SELECTED.RESPONSABLE_RECIBE = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("RECIBE");
                SELECTED.NOTA = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<string>("NOTA");
                SELECTED.RECIBIDO = FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<bool>("RECIBIDO");
                SELECTED.ESTADO = (eEstadoMovCash) FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex].Field<int>("ESTADO");
            }
        }


        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            ConfirmarFinanc financ = new ConfirmarFinanc();
            financ.ShowDialog();
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (tblFinanc.CurrentCell != null && tblFinanc.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null && SELECTED.ESTADO != eEstadoMovCash.HISTORICO)
                {
                    ACCION = eOperacion.UPDATE;
                    ConfirmarFinanc financ = new ConfirmarFinanc(SELECTED);
                    financ.ShowDialog();
                }
                else
                {
                    MessageBox.Show("FINANCIAMIENTO HISTORICO O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }





        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblFinanc.CurrentCell != null && tblFinanc.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null && SELECTED.ESTADO != eEstadoMovCash.HISTORICO)
                {
                    ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el FINANCIAMIENTO " + SELECTED.TIPO_DOC.ToString() + " " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR FINANCIAMIENTO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                SELECTED.NOTA_CAMBIO = cambioNota;
                                if (dbFinanc.eliminarMovCashPRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    cargarHistoryFinanc();
                                }
                            }
                            else
                            {
                                MessageBox.Show("INGRESE UNA NOTA ACLARATORIA DE LA ELIMINACION", "REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    MessageBox.Show("FINANCIAMIENTO HISTORICO O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (tblFinanc.CurrentCell != null && tblFinanc.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ACCION = eOperacion.PREVIEW;
                    ImprimirComprobanteFinanc();
                }
            }
        }

        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }


        public void CargarFinanc(string doc)
        {
            foreach(DataGridViewRow row in tblFinanc.Rows)
            {
                if (row.Cells["DOCUMENTO"].Value.ToString() == doc)
                {
                    tblFinanc.Rows[row.Index].Selected = true;
                    tblFinanc.CurrentCell = tblFinanc.Rows[row.Index].Cells[0];
                    cargarSelected();
                    return;
                }
            }
        }



        public void ImprimirComprobanteFinanc()
        {
            viewerCOMPROBANTE.Clear();
            if (SELECTED != null)
            {
                ReportParameter[] parameters = new ReportParameter[7];
                parameters[0] = new ReportParameter("NumTICKET", SELECTED.DOCUMENTO);
                parameters[1] = new ReportParameter("FECHA", SELECTED.FECHA.Date.ToString("dd/MM/yyyy"));
                parameters[2] = new ReportParameter("SUCURSAL", SELECTED.SUCURSAL_ENVIO);
                parameters[3] = new ReportParameter("DESTINO", SELECTED.SUCURSAL_DESTINO);
                parameters[4] = new ReportParameter("CAPITAL", SELECTED.TOTAL.ToString("C2"));
                parameters[5] = new ReportParameter("EMPLEADO", SELECTED.RESPONSABLE_RECIBE);
                parameters[6] = new ReportParameter("ENTREGA", SELECTED.RESPONSABLE_ENVIO);
                parameters[7] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                viewerCOMPROBANTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.TicketFinanc.rdlc";
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




    }
}
