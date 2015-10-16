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

namespace PrendaSAL.Caja
{
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class GastosForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static GastosForm frmInstance = null;

        public static GastosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new GastosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //variables
        private DBUsuario dbUser;
        private GastoController dbGasto;

        private eOperacion ACCION;
        private Gasto SELECTED;

        private DataTable GASTOS;

        public GastosForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbGasto = new GastoController();
        }


        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnAnular.Visible = false;
            btnEliminar.Visible = false;
            btnLog.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P11")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                }
            }
        }




        private void GastosForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblGASTOS.AutoGenerateColumns = false;
            cargarHistoryGastos();
        }




        public void cargarHistoryGastos()
        {
            GASTOS = dbGasto.GASTOS_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().FECHA_SISTEMA);
            tblGASTOS.DataSource = GASTOS;
            calcularTotales();
        }



        private void calcularTotales()
        {
            decimal TOTAL = tblGASTOS.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["TOTAL"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL.Text = TOTAL.ToString("C2");
        }




        private void tblGASTOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblGASTOS.Columns[e.ColumnIndex].Name)
                {
                    
                    case "TIPO_DOC":
                        eTipoDocGasto tipodoc = (eTipoDocGasto)e.Value;
                        e.Value = tipodoc.ToString();
                        break;
                }
            }
        }



        private void cargarSelected()
        {
            SELECTED = null;
            if (tblGASTOS.CurrentCell != null && tblGASTOS.SelectedRows.Count == 1)
            {
                SELECTED = new Gasto();
                SELECTED.ID_GASTO = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<int>("ID_GASTO");
                SELECTED.TRANSACCION = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<string>("COD_TRANS");
                SELECTED.RESPONSABLE = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<string>("RESPONSABLE");
                SELECTED.COD_SUC = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<string>("COD_SUC");
                SELECTED.FECHA = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<DateTime>("FECHA");
                SELECTED.TIPO_DOC = (eTipoDocGasto) GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<int>("TIPO_DOC");
                SELECTED.DOCUMENTO = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<string>("DOCUMENTO");
                SELECTED.DESCRIPCION = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<string>("DESCRIPCION");
                SELECTED.SUMAS = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<decimal>("SUMAS");
                SELECTED.TOTAL = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<decimal>("TOTAL");
                SELECTED.ESTADO =(eEstadoGasto) GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<int>("ESTADO");
                SELECTED.NOTA = GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex].Field<string>("NOTA");
            }
        }


        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            ConfirmarGasto gasto = new ConfirmarGasto();
            gasto.ShowDialog();
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (tblGASTOS.CurrentCell != null && tblGASTOS.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null && !SELECTED.INIT_BALANCE)
                {
                    ACCION = eOperacion.UPDATE;
                    ConfirmarGasto gasto = new ConfirmarGasto(SELECTED);
                    gasto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("GASTO HISTORICO O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblGASTOS.CurrentCell != null && tblGASTOS.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null && ! SELECTED.INIT_BALANCE)
                {
                    ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el GASTO " + SELECTED.TIPO_DOC.ToString() + " " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR GASTO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                SELECTED.NOTA_CAMBIO = cambioNota;
                                if (dbGasto.eliminarGastoPRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    cargarHistoryGastos();
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
                    MessageBox.Show("GASTO HISTORICO O INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void IMPRIMIR(object sender, EventArgs e)
        {

        }

        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }



    }
}
