using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ControlesPersonalizados;

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;

    public partial class CorteInvInicialForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static CorteInvInicialForm frmInstance = null;

        public static CorteInvInicialForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CorteInvInicialForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;
        private DBInventario dbInventario;
        private DataTable INVENTARIO;
        private InvInicial SELECTED;

        private int ANIO;

        public CorteInvInicialForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
        }




        private void permisos()
        {
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P17")
                {
                    btnAgregar.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                }
            }
        }




        private void CorteInvInicialForm_Load(object sender, EventArgs e)
        {
            permisos();
            ANIO = HOME.Instance().FECHA_SISTEMA.Year;
            tblInventario.AutoGenerateColumns = false;
            cargarInventarioInicial();
        }


        public void cargarInventarioInicial()
        {
            INVENTARIO = dbInventario.getInvInicialByPeriodo(ANIO);
            tblInventario.DataSource = INVENTARIO;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void tblInventario_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblInventario.DataSource != null)
            {
                lbNUM_TOTAL.Text = tblInventario.Rows.Count + " ARTICULOS";
            }
            else
            {
                lbNUM_TOTAL.Text = "0 ARTICULOS";
            }
        }

        private void SelectedArticulo()
        {
            SELECTED = null;
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SELECTED = InvInicial.ConvertToInvInicial(INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex]);

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                
            }
        }



        private void AGREGAR_ARTICULO(object sender, EventArgs e)
        {
            ItemInicialForm inv = new ItemInicialForm(ANIO);
            inv.ShowDialog();
        }



        private void EDITAR_INVENTARIO(object sender, EventArgs e)
        {
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SelectedArticulo();
                ItemInicialForm inv = new ItemInicialForm(SELECTED);
                inv.ShowDialog();
            }
            else
            {
                MessageBox.Show("SELECCIONE ARTICULO A EDITAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


        private void ELIMINAR_ARTICULO(object sender, EventArgs e)
        {
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SelectedArticulo();
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el ARTICULO " + SELECTED.CODIGO + "\n " + SELECTED.COD_ITEM + "--" + SELECTED.DESCRIPCION + " ?", "ELIMINAR ARTICULO DE INVENTARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbInventario.deleteInit(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            cargarInventarioInicial();
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
                MessageBox.Show("SELECCIONE ARTICULO A ELIMINAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void tblInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SelectedArticulo();
            }
        }



        private void BUSCAR(object sender, EventArgs e)
        {
            string anio = Controles.InputBox("PERIODO ", "CONSULTAR INVENTARIO INICIAL");
            if (anio != null && anio != string.Empty)
            {
                ANIO = Int32.Parse(anio);
                INVENTARIO = dbInventario.getInvInicialByPeriodo(ANIO);
                tblInventario.DataSource = INVENTARIO;

                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }



        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (INVENTARIO != null)
            {
                HOME.Instance().exportDataGridViewToExcel("INVENTARIO INICIAL", tblInventario.Columns, INVENTARIO, "InventarioInicial");
            }
        }


        private void AYUDA(object sender, EventArgs e)
        {

        }










    }
}
