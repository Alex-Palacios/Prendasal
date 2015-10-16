using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Movimientos
{
    using LOGICA;
    using MODELO;

    public partial class ExistenciasForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ExistenciasForm frmInstance = null;

        public static ExistenciasForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ExistenciasForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private InventarioController dbInventario;
        private DataTable INVENTARIO;
        private DataTable PRODUCTOS;
        public string SUC;

        public ExistenciasForm()
        {
            InitializeComponent();
            tblINVENTARIO.AutoGenerateColumns = false;
            dbInventario = new InventarioController();

            tblINVENTARIO.AutoGenerateColumns = false;
            PRODUCTOS = new DataTable();
            PRODUCTOS.Columns.Add("ID").DataType = System.Type.GetType("System.Int32");
            PRODUCTOS.Columns.Add("CAT").DataType = System.Type.GetType("System.String");
            PRODUCTOS.Columns.Add("CODIGO").DataType = System.Type.GetType("System.String");
            PRODUCTOS.Columns.Add("CANTIDAD").DataType = System.Type.GetType("System.Double");
            PRODUCTOS.Columns.Add("ARTICULO").DataType = System.Type.GetType("System.String");
            PRODUCTOS.Columns.Add("DESCRIPCION").DataType = System.Type.GetType("System.String");
            PRODUCTOS.Columns.Add("PRECIO").DataType = System.Type.GetType("System.Decimal");
        }

        private void CarritoCompraForm_Load(object sender, EventArgs e)
        {
            tblINVENTARIO.AutoGenerateColumns = false;
            PRODUCTOS.Clear();
            txtCODIGO.Text = "";
            INVENTARIO = dbInventario.EXISTENCIAS_BY_VENTA_PRENDASAL(SUC);
            if (INVENTARIO.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY EXISTENCIAS ", "EXISTENCIAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tblINVENTARIO.DataSource = INVENTARIO.Copy();
            }
            else
            {
                quitarListadosEnVenta();
                tblINVENTARIO.DataSource = INVENTARIO.Copy();
            }
            lbSELECT.Text = PRODUCTOS.Rows.Count.ToString();
            desbloquear();
        }


        private void quitarListadosEnVenta()
        {
            List<DataRow> listados = new List<DataRow>();
            //VERIFICAR EXISTENCIA
            foreach (DataRow row in INVENTARIO.Rows)
            {
                if (isListadoVENTA(row.Field<int>("ID_MOV")))
                {
                    listados.Add(row);
                }
            }
            //ELIMINAR EXISTENCIA
            foreach(DataRow r in listados){
                INVENTARIO.Rows.Remove(r);
            }
            if (INVENTARIO.Rows.Count == 0)
            {
                MessageBox.Show("YA SE LISTARON PRODUCTOS EN LA VENTA ", "EXISTENCIAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void desbloquear()
        {
            tblINVENTARIO.ReadOnly = false;
            tblINVENTARIO.Columns["CHECK"].ReadOnly = false;
            tblINVENTARIO.Columns["CODIGO"].ReadOnly = true;
            tblINVENTARIO.Columns["CANTIDAD"].ReadOnly = true;
            tblINVENTARIO.Columns["ARTICULO"].ReadOnly = true;
            tblINVENTARIO.Columns["DESCRIPCION"].ReadOnly = true;
            tblINVENTARIO.Columns["PRECIO"].ReadOnly = true;
        }



        private void txtCODIGO_TextChanged(object sender, EventArgs e)
        {
            if (txtCODIGO.Text.Trim() != string.Empty)
            {
                INVENTARIO.DefaultView.RowFilter = "CODIGO LIKE '" + txtCODIGO.Text.Trim() + "%'";
                tblINVENTARIO.DataSource = INVENTARIO.DefaultView;
            }
            else
            {
                tblINVENTARIO.DataSource = INVENTARIO.Copy();
            }
        }




        private void tblINVENTARIO_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tblINVENTARIO.IsCurrentCellDirty)
            {
                tblINVENTARIO.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void tblINVENTARIO_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = tblINVENTARIO.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "CHECK":
                    DataGridViewRow row = tblINVENTARIO.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["CHECK"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    listarProductos();
                    break;
            }
        }




        private void listarProductos()
        {
            PRODUCTOS.Clear();
            foreach (DataGridViewRow row in tblINVENTARIO.Rows)
            {
                bool LISTAR = (bool)row.Cells["CHECK"].FormattedValue;
                if (LISTAR)
                {
                    if (!isListado(Int32.Parse(row.Cells["ID_MOV"].FormattedValue.ToString(), System.Globalization.NumberStyles.AllowThousands)))
                    {
                        PRODUCTOS.Rows.Add(INVENTARIO.Rows[row.Index].Field<int>("ID_MOV"),  INVENTARIO.Rows[row.Index].Field<string>("CATEGORIA"),INVENTARIO.Rows[row.Index].Field<string>("CODIGO"), INVENTARIO.Rows[row.Index].Field<double>("CANTIDAD"), INVENTARIO.Rows[row.Index].Field<string>("ARTICULO"), INVENTARIO.Rows[row.Index].Field<string>("DESCRIPCION"), INVENTARIO.Rows[row.Index].Field<decimal>("PRECIO"));
                    }
                }
            }
            lbSELECT.Text = PRODUCTOS.Rows.Count.ToString();
        }



        private bool isListado(int id)
        {
            bool OK = false;
            foreach (DataRow row in PRODUCTOS.Rows)
            {
                int idMov = row.Field<int>("ID");
                if (idMov == id)
                {
                    return true;
                }
            }
            return OK;
        }





        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            int listados = 0;
            foreach (DataRow row in PRODUCTOS.Rows)
            {
                if (VentasForm.Instance().ITEMS_VENTA != null && !isListadoVENTA(row.Field<int>("ID")))
                {
                    decimal monto = row.Field<decimal>("PRECIO") / (decimal)row.Field<double>("CANTIDAD");
                    monto = Decimal.Round(monto, 2);
                    VentasForm.Instance().ITEMS_VENTA.Rows.Add(row.Field<string>("CAT"), row.Field<string>("ARTICULO"), row.Field<double>("CANTIDAD"), row.Field<string>("DESCRIPCION"), row.Field<decimal>("PRECIO"), monto, null, 0, row.Field<decimal>("PRECIO"), monto, row.Field<int>("ID"), row.Field<decimal>("PRECIO"));
                    listados = listados + 1;
                }
                
            }
            if (listados > 0)
            {
                this.Hide();
                VentasForm.Instance().cargarItems();
                MessageBox.Show(listados + " ARTICULOS AGREGADOS A LA VENTA");
            }
            else
            {
                MessageBox.Show("NO HAY ARTICULOS PARA LISTAR .. O YA SE ENCUENTRAN LISTADOS", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private bool isListadoVENTA(int id)
        {
            bool OK = false;
            foreach (DataRow row in VentasForm.Instance().ITEMS_VENTA.Rows)
            {
                int idMov = row.Field<int>("INV");
                if (idMov == id)
                {
                    return true;
                }
            }
            return OK;
        }





    }
}
