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
        private DBCatalogo dbCatalogo;
        private DataTable INVENTARIO;
        private InvInicial SELECTED;

        private int ANIO;
        private DataRow CAT_INV;

        public CorteInvInicialForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
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
            CAT_INV = HOME.Instance().datCATEGORIAS.Rows[0];
            tblInventario.AutoGenerateColumns = false;
            cargarInventarioInicial();
        }


        public void cargarInventarioInicial()
        {
            INVENTARIO = dbInventario.getInvInicialByPeriodo(ANIO, CAT_INV.Field<string>("CATEGORIA"));
            tblInventario.DataSource = INVENTARIO;

            if (CAT_INV.Field<bool>("UNICO"))
            {
                tblInventario.Columns["COD_ITEM"].Visible = false;
                tblInventario.Columns["MARCA"].Visible = true;
            }
            else
            {
                tblInventario.Columns["COD_ITEM"].Visible = true;
                tblInventario.Columns["MARCA"].Visible = false;
            }

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void tblInventario_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblInventario.DataSource != null)
            {
                lbNUM_TOTAL.Text = tblInventario.Rows.Count + " "+CAT_INV.Field<string>("CATEGORIA");
            }
            else
            {
                lbNUM_TOTAL.Text = "0 " + CAT_INV;
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
            ItemInicialForm invForm = new ItemInicialForm();
            //Construir
            var txtPeriodo = invForm.Controls["txtPERIODO"];
            var cbxBodega = (ComboBox)invForm.Controls["cbxBODEGA"];
            var txtCategoria = invForm.Controls["txtCATEGORIA"];
            var txtCodigo = invForm.Controls["txtCODIGO"];
            var lbCodItem = invForm.Controls["lbCODITEM"];
            var cbxCodItem = (ComboBox)invForm.Controls["cbxCODITEM"];
            var cbxTipo = (ComboBox)invForm.Controls["cbxTIPO"];
            var lbMarca = invForm.Controls["lbMARCA"];
            var cbxMarca = (ComboBox)invForm.Controls["cbxMARCA"];
            var txtDescripcion = invForm.Controls["txtDESCRIPCION"];
            var txtCantidad = invForm.Controls["txtCANTIDAD"];
            var txtMonto = invForm.Controls["txtMONTO"];
            var txtNota = invForm.Controls["txtNOTA"];

            invForm.Text = "AGREGAR " + CAT_INV.Field<string>("CATEGORIA");
            invForm.UNICO = CAT_INV.Field<bool>("UNICO");

            if (invForm.UNICO)
            {
                lbCodItem.Visible = false;
                cbxCodItem.Visible = false;
                lbMarca.Visible = true;
                cbxMarca.Visible = true;
            }
            else
            {
                cbxCodItem.DataSource = dbCatalogo.showCatalogo(CAT_INV.Field<string>("CATEGORIA"));
                if (((DataTable)cbxCodItem.DataSource).Rows.Count > 0)
                {
                    cbxCodItem.DisplayMember = "COD_ITEM";
                    cbxCodItem.ValueMember = "COD_ITEM";
                }
                lbCodItem.Visible = true;
                cbxCodItem.Visible = true;
                lbMarca.Visible = false;
                cbxMarca.Visible = false;
            }


            cbxBodega.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (((DataTable)cbxBodega.DataSource).Rows.Count > 0)
            {
                cbxBodega.DisplayMember = "SUCURSAL";
                cbxBodega.ValueMember = "COD_SUC";
                cbxBodega.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            cbxTipo.DataSource = dbCatalogo.getTipoInv(CAT_INV.Field<string>("CATEGORIA"));
            if (((DataTable)cbxTipo.DataSource).Rows.Count > 0)
            {
                cbxTipo.DisplayMember = "TIPO";
                cbxTipo.ValueMember = "TIPO";
            }

            cbxMarca.DataSource = dbCatalogo.getMarcaInv(CAT_INV.Field<string>("CATEGORIA"));
            if (((DataTable)cbxMarca.DataSource).Rows.Count > 0)
            {
                cbxMarca.DisplayMember = "MARCA";
                cbxMarca.ValueMember = "MARCA";
            }

            txtPeriodo.Text = ANIO.ToString();
            txtCategoria.Text = CAT_INV.Field<string>("CATEGORIA");
            txtCodigo.Text = string.Empty;
            txtCantidad.Text = "0.0";
            txtMonto.Text = "0.00";

            if (invForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SELECTED = new InvInicial();
                SELECTED.PERIODO = ANIO;
                SELECTED.CATEGORIA = CAT_INV.Field<string>("CATEGORIA");
                SELECTED.BODEGA = (string)cbxBodega.SelectedValue;
                SELECTED.CODIGO = txtCodigo.Text.Trim();
                SELECTED.COD_ITEM = cbxCodItem.Text.Trim();
                SELECTED.TIPO = cbxTipo.Text.ToUpper().Trim();
                SELECTED.MARCA = cbxMarca.Text.ToUpper().Trim();
                SELECTED.DESCRIPCION = txtDescripcion.Text.Trim();
                SELECTED.CANTIDAD = Decimal.Parse(txtCantidad.Text);
                SELECTED.MONTO = Decimal.Parse(txtMonto.Text);
                SELECTED.NOTA = txtNota.Text;

                if (dbInventario.insertInit(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                {
                    cargarInventarioInicial();
                }

            }
        }



        private void EDITAR_INVENTARIO(object sender, EventArgs e)
        {
            if (tblInventario.CurrentCell != null && tblInventario.SelectedRows.Count == 1)
            {
                SelectedArticulo();
                if (SELECTED != null)
                {
                    ItemInicialForm editarForm = new ItemInicialForm();
                    //Construir
                    var txtPeriodo = editarForm.Controls["txtPERIODO"];
                    var cbxBodega = (ComboBox)editarForm.Controls["cbxBODEGA"];
                    var txtCategoria = editarForm.Controls["txtCATEGORIA"];
                    var txtCodigo = editarForm.Controls["txtCODIGO"];
                    var lbCodItem = editarForm.Controls["lbCODITEM"];
                    var cbxCodItem = (ComboBox)editarForm.Controls["cbxCODITEM"];
                    var cbxTipo = (ComboBox)editarForm.Controls["cbxTIPO"];
                    var lbMarca = editarForm.Controls["lbMARCA"];
                    var cbxMarca = (ComboBox)editarForm.Controls["cbxMARCA"];
                    var txtDescripcion = editarForm.Controls["txtDESCRIPCION"];
                    var txtCantidad = editarForm.Controls["txtCANTIDAD"];
                    var txtMonto = editarForm.Controls["txtMONTO"];
                    var txtNota = editarForm.Controls["txtNOTA"];

                    editarForm.Text = "EDITAR " + CAT_INV.Field<string>("CATEGORIA");
                    editarForm.UNICO = CAT_INV.Field<bool>("UNICO");

                    if (editarForm.UNICO)
                    {
                        lbCodItem.Visible = false;
                        cbxCodItem.Visible = false;
                        lbMarca.Visible = true;
                        cbxMarca.Visible = true;
                    }
                    else
                    {
                        cbxCodItem.DataSource = dbCatalogo.showCatalogo(CAT_INV.Field<string>("CATEGORIA"));
                        if (((DataTable)cbxCodItem.DataSource).Rows.Count > 0)
                        {
                            cbxCodItem.DisplayMember = "COD_ITEM";
                            cbxCodItem.ValueMember = "COD_ITEM";
                            cbxCodItem.Text = SELECTED.COD_ITEM;
                        }
                        lbCodItem.Visible = true;
                        cbxCodItem.Visible = true;
                        lbMarca.Visible = false;
                        cbxMarca.Visible = false;
                    }


                    cbxBodega.DataSource = HOME.Instance().datSUCURSALES.Copy();
                    if (((DataTable)cbxBodega.DataSource).Rows.Count > 0)
                    {
                        cbxBodega.DisplayMember = "SUCURSAL";
                        cbxBodega.ValueMember = "COD_SUC";
                        cbxBodega.SelectedValue = SELECTED.BODEGA;
                    }

                    cbxTipo.DataSource = dbCatalogo.getTipoInv(CAT_INV.Field<string>("CATEGORIA"));
                    if (((DataTable)cbxTipo.DataSource).Rows.Count > 0)
                    {
                        cbxTipo.DisplayMember = "TIPO";
                        cbxTipo.ValueMember = "TIPO";
                        cbxTipo.SelectedValue = SELECTED.TIPO;
                    }

                    cbxMarca.DataSource = dbCatalogo.getMarcaInv(CAT_INV.Field<string>("CATEGORIA"));
                    if (((DataTable)cbxMarca.DataSource).Rows.Count > 0)
                    {
                        cbxMarca.DisplayMember = "MARCA";
                        cbxMarca.ValueMember = "MARCA";
                        cbxMarca.SelectedValue = SELECTED.MARCA;
                    }

                    txtPeriodo.Text = SELECTED.PERIODO.ToString();
                    txtCategoria.Text = SELECTED.CATEGORIA;
                    txtCodigo.Text = SELECTED.CODIGO;
                    txtCantidad.Text = SELECTED.CANTIDAD.ToString();
                    txtDescripcion.Text = SELECTED.DESCRIPCION;
                    txtMonto.Text = SELECTED.MONTO.ToString();
                    txtNota.Text = SELECTED.NOTA;

                    if (editarForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        SELECTED.BODEGA = (string)cbxBodega.SelectedValue;
                        SELECTED.CODIGO = txtCodigo.Text.Trim();
                        SELECTED.COD_ITEM = cbxCodItem.Text.Trim();
                        SELECTED.TIPO = cbxTipo.Text.ToUpper().Trim();
                        SELECTED.MARCA = cbxMarca.Text.ToUpper().Trim();
                        SELECTED.DESCRIPCION = txtDescripcion.Text.Trim();
                        SELECTED.CANTIDAD = Decimal.Parse(txtCantidad.Text);
                        SELECTED.MONTO = Decimal.Parse(txtMonto.Text);
                        SELECTED.NOTA = txtNota.Text;

                        if (dbInventario.updateInit(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            cargarInventarioInicial();
                        }

                    }
                }
                
            }
            else
            {
                MessageBox.Show("SELECCIONE ITEM A EDITAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("SELECCIONE ITEM A ELIMINAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            List<object> AC = Controles.InputComboBoxAC("BUSCAR POR", HOME.Instance().datCATEGORIAS.Copy());
            if (AC != null && AC.Count == 2)
            {
                ANIO = Int32.Parse(AC[0].ToString());
                CAT_INV = (DataRow) AC[1];
                cargarInventarioInicial();
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
