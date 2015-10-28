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
        private DBGasto dbGasto;

        private eOperacion ACCION;
        private Gasto SELECTED;

        private DataTable GASTOS;

        public GastosForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbGasto = new DBGasto();
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
            GASTOS = dbGasto.findBySucAnio(HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().FECHA_SISTEMA.Year);
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
                    
                    case "DOCUMENTO":
                        e.Value = GASTOS.Rows[e.RowIndex].Field<string>("TIPO_DOC") + e.Value.ToString();
                        break;
                }
            }
        }



        private void cargarSelected()
        {
            SELECTED = null;
            if (tblGASTOS.CurrentCell != null && tblGASTOS.SelectedRows.Count == 1)
            {
                SELECTED = Gasto.ConvertToGasto(GASTOS.Rows[tblGASTOS.CurrentCell.RowIndex]);
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
                if (SELECTED != null)
                {
                    ACCION = eOperacion.UPDATE;
                    ConfirmarGasto gasto = new ConfirmarGasto(SELECTED);
                    gasto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("SELECCIONE GASTO A EDITAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblGASTOS.CurrentCell != null && tblGASTOS.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el GASTO " + SELECTED.TIPO_DOC.ToString() + " " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR GASTO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbGasto.delete(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                cargarHistoryGastos();
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
                    MessageBox.Show("SELECCIONE GASTO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }



    }
}
