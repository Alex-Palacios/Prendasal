using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Operaciones
{
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class EnviarInvForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static EnviarInvForm frmInstance = null;

        public static EnviarInvForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new EnviarInvForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;
        private InventarioController dbInventario;
        private DataTable VALORES_CUSTODIA;
        private DataTable INVENTARIO;
        private DataTable SELECCION_CUSTODIA;
        private DataTable SELECCION_REMISION;

        public EnviarInvForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new InventarioController();
        }

        private void permisos()
        {
            btnEnviarCustodia.Visible = false;
            btnEnviarRemision.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P16")
                {
                    btnEnviarCustodia.Visible = p.Field<bool>("REGISTRAR");
                    btnEnviarRemision.Visible = p.Field<bool>("REGISTRAR");
                }
            }
        }

        private void EnviarInvForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCustodia.AutoGenerateColumns = false;
            tblInventario.AutoGenerateColumns = false;
            desbloquear();
            tabControlEnvio.SelectedIndex = -1;
            tabControlEnvio.SelectedIndex = 0;
        }

        private void desbloquear()
        {
            tblCustodia.ReadOnly = false;
            tblCustodia.Columns["CHECK"].ReadOnly = false;
            tblCustodia.Columns["ID_MOV"].ReadOnly = false;
            tblCustodia.Columns["CATEGORIA"].ReadOnly = true;
            tblCustodia.Columns["CONTRATO"].ReadOnly = true;
            tblCustodia.Columns["CANTIDAD"].ReadOnly = true;
            tblCustodia.Columns["ARTICULO"].ReadOnly = true;
            tblCustodia.Columns["DESCRIPCION"].ReadOnly = true;
            tblCustodia.Columns["VALOR"].ReadOnly = true;

            tblInventario.ReadOnly = false;
            tblInventario.Columns["CHECK_RM"].ReadOnly = false;
            tblInventario.Columns["ID_MOV_RM"].ReadOnly = false;
            tblInventario.Columns["CATEGORIA_RM"].ReadOnly = true;
            tblInventario.Columns["CODIGO_RM"].ReadOnly = true;
            tblInventario.Columns["CANTIDAD_RM"].ReadOnly = true;
            tblInventario.Columns["ARTICULO_RM"].ReadOnly = true;
            tblInventario.Columns["DESCRIPCION_RM"].ReadOnly = true;
            tblInventario.Columns["PRECIO_RM"].ReadOnly = true;
        }


        private void tabControlEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlEnvio.SelectedIndex >= 0)
            {
                switch (tabControlEnvio.SelectedTab.Name)
                {
                    case "pagCustodia":
                        VALORES_CUSTODIA = dbInventario.CUSTODIA_BY_SUCURSAL_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC);
                        tblCustodia.DataSource = VALORES_CUSTODIA;
                        break;
                    case "pagRemision":
                        INVENTARIO = dbInventario.EXISTENCIAS_BY_SUCURSAL_PRENDASAL(HOME.Instance().SUCURSAL.COD_SUC);
                        tblInventario.DataSource = INVENTARIO;
                        break;
                }
            }
        }



        // CUSTODIA DE VALORES



        private void txtCodigoCustodia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtCodigoCustodia.Text.Trim() != string.Empty)
            {
                foreach (DataGridViewRow row in tblCustodia.Rows)
                {
                    if (row.Cells["CONTRATO"].Value.ToString().StartsWith(txtCodigoCustodia.Text.Trim().ToUpper()))
                    {
                        tblCustodia.Rows[row.Index].Selected = true;
                        tblCustodia.CurrentCell = tblCustodia.Rows[row.Index].Cells["CHECK"];
                        break;
                    }
                }
                e.Handled = true;
            }
        }



        private void tblCustodia_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tblCustodia.IsCurrentCellDirty)
            {
                tblCustodia.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void tblCustodia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = tblCustodia.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "CHECK":
                    DataGridViewRow row = tblCustodia.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["CHECK"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value)) 
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    contarSeleccionadosCustodia();
                    break;
            }
        }



        private void contarSeleccionadosCustodia()
        {
            SELECCION_CUSTODIA = VALORES_CUSTODIA.Copy();
            SELECCION_CUSTODIA.Clear();
            foreach(DataGridViewRow row in tblCustodia.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CHECK"].Value))
                {
                    DataRow nuevo = SELECCION_CUSTODIA.NewRow();
                    nuevo.SetField<int>("ID_PRESTAMO", VALORES_CUSTODIA.Rows[row.Index].Field<int>("ID_PRESTAMO"));
                    nuevo.SetField<int>("ID_LINEA", VALORES_CUSTODIA.Rows[row.Index].Field<int>("ID_LINEA"));
                    nuevo.SetField<string>("CONTRATO", VALORES_CUSTODIA.Rows[row.Index].Field<string>("CONTRATO"));
                    nuevo.SetField<double>("CANTIDAD", VALORES_CUSTODIA.Rows[row.Index].Field<double>("CANTIDAD"));
                    nuevo.SetField<string>("ARTICULO", VALORES_CUSTODIA.Rows[row.Index].Field<string>("ARTICULO"));
                    nuevo.SetField<string>("DESCRIPCION", VALORES_CUSTODIA.Rows[row.Index].Field<string>("DESCRIPCION"));
                    nuevo.SetField<decimal>("VALOR", VALORES_CUSTODIA.Rows[row.Index].Field<decimal>("VALOR"));

                    nuevo.SetField<string>("COD_TRANS", VALORES_CUSTODIA.Rows[row.Index].Field<string>("COD_TRANS"));
                    nuevo.SetField<int>("TIPO_TRANS", VALORES_CUSTODIA.Rows[row.Index].Field<int>("TIPO_TRANS"));
                    nuevo.SetField<string>("RESPONSABLE", VALORES_CUSTODIA.Rows[row.Index].Field<string>("RESPONSABLE"));
                    nuevo.SetField<string>("CATEGORIA", VALORES_CUSTODIA.Rows[row.Index].Field<string>("CATEGORIA"));
                    nuevo.SetField<string>("COD_SUC", VALORES_CUSTODIA.Rows[row.Index].Field<string>("COD_SUC"));
                    nuevo.SetField<string>("UBICACION", VALORES_CUSTODIA.Rows[row.Index].Field<string>("UBICACION"));
                    SELECCION_CUSTODIA.Rows.Add(nuevo);
                }
            }
            lbSeleccionadosCustodia.Text = SELECCION_CUSTODIA.Rows.Count + " SELECCIONADOS";
        }







        private void ENVIAR_CUSTODIA(object sender, EventArgs e)
        {
            CustodiaForm custodia = CustodiaForm.Instance();
            custodia.CUSTODIA_VALORES = SELECCION_CUSTODIA;
            custodia.NUEVO(null, null);
            custodia.ShowDialog();
        }





        // REMISION DE INVENTARIO



        private void txtCodigoInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtCodigoInv.Text.Trim() != string.Empty)
            {
                foreach (DataGridViewRow row in tblInventario.Rows)
                {
                    if (row.Cells["CODIGO_RM"].Value.ToString().StartsWith(txtCodigoInv.Text.Trim().ToUpper()))
                    {
                        tblInventario.Rows[row.Index].Selected = true;
                        tblInventario.CurrentCell = tblInventario.Rows[row.Index].Cells["CHECK_RM"];
                        break;
                    }
                }
                e.Handled = true;
            }
        }


        private void tblInventario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = tblInventario.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "CHECK_RM":
                    DataGridViewRow row = tblInventario.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["CHECK_RM"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    contarSeleccionadosRemision();
                    break;
            }
        }



        private void contarSeleccionadosRemision()
        {
            SELECCION_REMISION = INVENTARIO.Copy();
            SELECCION_REMISION.Clear();
            foreach (DataGridViewRow row in tblInventario.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CHECK_RM"].Value))
                {
                    DataRow nuevo = SELECCION_REMISION.NewRow();
                    nuevo.SetField<int>("ID_MOV", INVENTARIO.Rows[row.Index].Field<int>("ID_MOV"));
                    nuevo.SetField<string>("CODIGO", INVENTARIO.Rows[row.Index].Field<string>("CODIGO"));
                    nuevo.SetField<double>("CANTIDAD", INVENTARIO.Rows[row.Index].Field<double>("CANTIDAD"));
                    nuevo.SetField<string>("ARTICULO", INVENTARIO.Rows[row.Index].Field<string>("ARTICULO"));
                    nuevo.SetField<string>("DESCRIPCION", INVENTARIO.Rows[row.Index].Field<string>("DESCRIPCION"));
                    nuevo.SetField<decimal>("PRECIO", INVENTARIO.Rows[row.Index].Field<decimal>("PRECIO"));

                    nuevo.SetField<string>("COD_TRANS", INVENTARIO.Rows[row.Index].Field<string>("COD_TRANS"));
                    nuevo.SetField<int>("TIPO_TRANS", INVENTARIO.Rows[row.Index].Field<int>("TIPO_TRANS"));
                    nuevo.SetField<string>("RESPONSABLE", INVENTARIO.Rows[row.Index].Field<string>("RESPONSABLE"));
                    nuevo.SetField<string>("CATEGORIA", INVENTARIO.Rows[row.Index].Field<string>("CATEGORIA"));
                    nuevo.SetField<bool>("INIT_BALANCE", INVENTARIO.Rows[row.Index].Field<bool>("INIT_BALANCE"));
                    nuevo.SetField<string>("COD_SUC", INVENTARIO.Rows[row.Index].Field<string>("COD_SUC"));
                    nuevo.SetField<string>("UBICACION", INVENTARIO.Rows[row.Index].Field<string>("UBICACION"));
                    SELECCION_REMISION.Rows.Add(nuevo);
                }
            }
            lbSeleccionadosRemision.Text = SELECCION_REMISION.Rows.Count + " SELECCIONADOS";
        }



        private void tblInventario_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tblInventario.IsCurrentCellDirty)
            {
                tblInventario.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }




        private void ENVIAR_REMISION(object sender, EventArgs e)
        {
            RemisionForm remision = RemisionForm.Instance();
            remision.ARTICULOS = SELECCION_REMISION;
            remision.NUEVO(null, null);
            remision.ShowDialog();
        }







    }
}
