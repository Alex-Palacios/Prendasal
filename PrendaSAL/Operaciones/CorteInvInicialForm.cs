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
    using LOGICA;
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
        private InventarioController dbInventario;
        private DataTable INVENTARIO;
        private Inventario SELECTED;

        public CorteInvInicialForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new InventarioController();
            tblInventario.AutoGenerateColumns = false;
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
            cargarInventarioInicial();
        }


        public void cargarInventarioInicial()
        {
            INVENTARIO = dbInventario.INVENTARIO_INICIAL_PRENDASAL();
            tblInventario.DataSource = INVENTARIO;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void SelectedArticulo()
        {
            SELECTED = null;
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SELECTED = new Inventario();
                SELECTED.ID_MOV = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<int>("ID_MOV");
                SELECTED.TRANSACCION = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<string>("COD_TRANS");
                SELECTED.FECHA = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<DateTime>("FECHA_INGRESO");
                SELECTED.LINEA = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<int?>("LINEA");
                SELECTED.CODIGO = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<string>("CODIGO");
                SELECTED.CATEGORIA = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<string>("CATEGORIA");
                SELECTED.ARTICULO = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<string>("ARTICULO");
                SELECTED.DESCRIPCION = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<string>("DESCRIPCION");
                SELECTED.CANTIDAD = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<double>("CANTIDAD");
                SELECTED.COSTO = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<decimal>("COSTO");
                SELECTED.PRECIO = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<decimal>("PRECIO");
                SELECTED.INIT_BALANCE = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<bool>("INIT_BALANCE");
                SELECTED.COD_SUC = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<string>("COD_SUC");
                SELECTED.DISPONIBLE = INVENTARIO.Rows[tblInventario.CurrentCell.RowIndex].Field<bool>("DISPONIBLE");

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                
            }
        }



        private void AGREGAR_ARTICULO(object sender, EventArgs e)
        {
            ItemInicial inv = new ItemInicial();
            inv.ShowDialog();
        }



        private void EDITAR_INVENTARIO(object sender, EventArgs e)
        {
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SelectedArticulo();
                ItemInicial inv = new ItemInicial(SELECTED);
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
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el ARTICULO " + SELECTED.CODIGO + "\n " + SELECTED.ARTICULO + "--" + SELECTED.DESCRIPCION + " ?", "ELIMINAR ARTICULO DE INVENTARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbInventario.eliminarInvInicialPrestamoPRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
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

        }

        private void IMPRIMIR(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }









    }
}
