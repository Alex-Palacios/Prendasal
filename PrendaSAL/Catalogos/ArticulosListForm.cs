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

namespace PrendaSAL.Catalogos
{
    using DDB;
    using MODELO;

    public partial class ArticulosListForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ArticulosListForm frmInstance = null;

        public static ArticulosListForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ArticulosListForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBCatalogo dbCatalogo;

        private DataTable ITEMS;
        
        public ArticulosListForm()
        {
            InitializeComponent();
            dbCatalogo = new DBCatalogo();
        }


        private void ArticulosListForm_Load(object sender, EventArgs e)
        {
            tblArticulos.AutoGenerateColumns = false;
            listCategorias.DataSource = Enum.GetValues(new eCategoria().GetType());
            cargarLista();
            permisos();
        }

        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P4")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                }
            }
        }

        private void cargarLista()
        {
            if (listCategorias.SelectedIndex >= 0)
            {
                ITEMS = dbCatalogo.showCatalogo((eCategoria) listCategorias.SelectedItem);
                tblArticulos.DataSource = ITEMS;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void listCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLista();
        }




        private void NUEVO(object sender, EventArgs e)
        {
            string codigo = Controles.InputBox("INGRESE NOMBRE DE ARTICULO : ","AGREGAR ARTICULO");
            if (codigo.Trim() != "")
            {
                Catalogo item = new Catalogo();
                item.COD_ITEM = codigo.ToUpper().Trim();
                item.CATEGORIA = (eCategoria)listCategorias.SelectedItem;
                if ((eCategoria)listCategorias.SelectedItem == eCategoria.ORO)
                {
                    item.UNIDAD_MEDIDA = eUnidadMedida.GRS;
                }
                else
                {
                    item.UNIDAD_MEDIDA = eUnidadMedida.UDS;
                }
                if (dbCatalogo.insert(item))
                {
                    cargarLista();
                }
            }
        }

        private void EDITAR(object sender, EventArgs e)
        {
            if (tblArticulos.CurrentCell != null && tblArticulos.SelectedRows.Count == 1)
            {
                string oldCodigo = ITEMS.Rows[tblArticulos.CurrentCell.RowIndex].Field<string>("COD_ITEM");
                string newCodigo = Controles.InputBox("CAMBIAR " + oldCodigo + " POR : ", "EDITAR ARTICULO");
                if (newCodigo.Trim() != "")
                {
                    if (dbCatalogo.changeID(oldCodigo, newCodigo.ToUpper().Trim()))
                    {
                        cargarLista();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione ARTICULO a editar", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblArticulos.CurrentCell != null && tblArticulos.SelectedRows.Count == 1)
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el ITEM del Catalogo ?", "ELIMINAR ITEM REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    if (dbCatalogo.delete(Catalogo.ConvertToItem(ITEMS.Rows[tblArticulos.CurrentCell.RowIndex])))
                    {
                        cargarLista();
                    }        
                }
            }
            else
            {
                MessageBox.Show("Seleccione ARTICULO a eliminar", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void AYUDA(object sender, EventArgs e)
        {

        }


        private void tblArticulos_Click(object sender, EventArgs e)
        {
            if (tblArticulos.CurrentCell != null && tblArticulos.SelectedRows.Count == 1)
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione ARTICULO a editar", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }


    }
}
