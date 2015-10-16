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
        private MovCashController dbRemesa;

        private eOperacion ACCION;

        private MovCash SELECTED;

        private DataTable REMESAS;

        public RemesasForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbRemesa = new MovCashController();
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
            REMESAS = dbRemesa.REMESA_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().FECHA_SISTEMA);
            tblRemesas.DataSource = REMESAS;
        }




        private void tblRemesas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblRemesas.Columns[e.ColumnIndex].Name)
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
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                SELECTED = new MovCash();
                SELECTED.ID_MOV = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<int>("ID_MOV");
                SELECTED.TRANSACCION = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("COD_TRANS");
                SELECTED.RESPONSABLE = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("RESPONSABLE");
                SELECTED.SUC_ORIGEN = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("SUC_ORG");
                SELECTED.SUCURSAL_ENVIO = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("SUCURSAL_ORIGEN");
                SELECTED.FECHA = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<DateTime>("FECHA");
                SELECTED.TIPO_MOV = (eTipoMovCash) REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<int>("TIPO_MOV");
                SELECTED.TIPO_DOC = (eTipoDocMovCash)REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<int>("TIPO_DOC");
                SELECTED.DOCUMENTO = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("DOCUMENTO");
                SELECTED.TOTAL = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<decimal>("TOTAL");
                SELECTED.RESPONSABLE_ENVIO = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("ENVIA");
                SELECTED.SUC_DESTINO = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("SUC_DEST");
                SELECTED.SUCURSAL_DESTINO = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("SUCURSAL_DESTINO");
                SELECTED.RESPONSABLE_RECIBE = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("RECIBE");
                SELECTED.NOTA = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<string>("NOTA");
                SELECTED.RECIBIDO = REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<bool>("RECIBIDO");
                SELECTED.ESTADO = (eEstadoMovCash) REMESAS.Rows[tblRemesas.CurrentCell.RowIndex].Field<int>("ESTADO");
            }
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
                if (SELECTED != null && SELECTED.ESTADO != eEstadoMovCash.HISTORICO)
                {
                    ACCION = eOperacion.UPDATE;
                    ConfirmarRemesa financ = new ConfirmarRemesa(SELECTED);
                    financ.ShowDialog();
                }
                else
                {
                    MessageBox.Show("REMESA HISTORICA O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null && SELECTED.ESTADO != eEstadoMovCash.HISTORICO)
                {
                    ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el REMESAIAMIENTO " + SELECTED.TIPO_DOC.ToString() + " " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR REMESAIAMIENTO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                SELECTED.NOTA_CAMBIO = cambioNota;
                                if (dbRemesa.eliminarMovCashPRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    cargarHistoryRemesa();
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
                    MessageBox.Show("REMESA HISTORICA O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }






        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (tblRemesas.CurrentCell != null && tblRemesas.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ACCION = eOperacion.PREVIEW;
                    ImprimirComprobanteRemesa();
                }
            }
        }



        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }



        public void CargarRemesa(string doc)
        {
            foreach (DataGridViewRow row in tblRemesas.Rows)
            {
                if (row.Cells["DOCUMENTO"].Value.ToString() == doc)
                {
                    tblRemesas.Rows[row.Index].Selected = true;
                    tblRemesas.CurrentCell = tblRemesas.Rows[row.Index].Cells[0];
                    cargarSelected();
                    return;
                }
            }
        }





        public void ImprimirComprobanteRemesa()
        {
            viewerCOMPROBANTE.Clear();
            if (SELECTED != null)
            {
                ReportParameter[] parameters = new ReportParameter[8];
                parameters[0] = new ReportParameter("NumTICKET", SELECTED.DOCUMENTO);
                parameters[1] = new ReportParameter("FECHA", SELECTED.FECHA.Date.ToString("dd/MM/yyyy"));
                parameters[2] = new ReportParameter("SUCURSAL", SELECTED.SUCURSAL_ENVIO);
                parameters[3] = new ReportParameter("DESTINO", SELECTED.SUCURSAL_DESTINO);
                parameters[4] = new ReportParameter("CAPITAL", SELECTED.TOTAL.ToString("C2"));
                parameters[5] = new ReportParameter("EMPLEADO", SELECTED.RESPONSABLE_ENVIO);
                parameters[6] = new ReportParameter("RETIRA", SELECTED.RESPONSABLE_RECIBE);
                parameters[7] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                viewerCOMPROBANTE.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.TicketRemesa.rdlc";
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

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }



    }
}
