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

    public partial class SFCForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static SFCForm frmInstance = null;

        public static SFCForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new SFCForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //variables
        private DBUsuario dbUser;
        private DBSFCaja dbSFCaja;

        private eOperacion ACCION;
        private SFCaja SELECTED;

        private DataTable SFC;

        public SFCForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbSFCaja = new DBSFCaja();
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
                if (p.Field<string>("CODIGO") == "P37")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                }
            }
        }




        private void SFCForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblSFC.AutoGenerateColumns = false;
            cargarHistorySFC();
        }




        public void cargarHistorySFC()
        {
            SFC = dbSFCaja.getSFCByAnio(HOME.Instance().FECHA_SISTEMA.Year);
            tblSFC.DataSource = SFC;
            calcularTotales();
        }



        private void calcularTotales()
        {
            decimal TOTAL = tblSFC.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["TOTAL"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL.Text = TOTAL.ToString("C2");
        }




        private void tblSFC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblSFC.Columns[e.ColumnIndex].Name)
                {
                    
                    case "TIPO":
                        eTipoSFC tipo = (eTipoSFC)e.Value;
                        e.Value = tipo.ToString();
                        break;
                }
            }
        }



        private void cargarSelected()
        {
            SELECTED = null;
            if (tblSFC.CurrentCell != null && tblSFC.SelectedRows.Count == 1)
            {
                SELECTED = SFCaja.ConvertToSFCaja(SFC.Rows[tblSFC.CurrentCell.RowIndex]);
            }
        }




        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            ConfirmarSFC sfc = new ConfirmarSFC();
            sfc.ShowDialog();
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (tblSFC.CurrentCell != null && tblSFC.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ACCION = eOperacion.UPDATE;
                    ConfirmarSFC sfc = new ConfirmarSFC(SELECTED);
                    sfc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("SELECCIONE SFC A EDITAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblSFC.CurrentCell != null && tblSFC.SelectedRows.Count == 1)
            {
                cargarSelected();
                if (SELECTED != null)
                {
                    ACCION = eOperacion.DELETE;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el " + SELECTED.TIPO.ToString() + " de caja " + SELECTED.DOCUMENTO + " con FECHA:" + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR SFC REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbSFCaja.delete(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                cargarHistorySFC();
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
                    MessageBox.Show("SELECCIONE SFC", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int anio = 0;
            string anioString = Controles.InputBox("AÑO", "CONSULTAR SFC");
            if (anioString != string.Empty && Int32.TryParse(anioString, out anio))
            {
                SFC = dbSFCaja.getSFCByAnio(anio);
                tblSFC.DataSource = SFC;
                calcularTotales();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (SFC != null)
            {
                HOME.Instance().exportDataGridViewToExcel("SFC", tblSFC.Columns, SFC, "SF_Caja");
            }
        }



    }
}
