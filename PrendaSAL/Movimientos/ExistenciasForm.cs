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
    using DDB;
    using MODELO;

    public partial class ExistenciasForm : Form
    {
        
        //VARIABLES
        private DBInventario dbExistencias;
        private DataTable EXISTENCIAS;
        private DataTable FILTRO;

        public ExistenciasForm()
        {
            InitializeComponent();
            dbExistencias = new DBInventario();
        }

        private void CarritoCompraForm_Load(object sender, EventArgs e)
        {
            tblEXISTENCIAS.AutoGenerateColumns = false;
            txtCODIGO.Text = "";
            cargarExistencias();
        }


        private void cargarExistencias(){
            EXISTENCIAS = dbExistencias.getEXISTENCIAS(HOME.Instance().SUCURSAL.COD_SUC, "ARTICULO");
            filtrarDatosExistencias();
        }


        private void filtrarDatosExistencias()
        {
            DataRow[] filtros;
            FILTRO = EXISTENCIAS.Copy();
            if (FILTRO.Rows.Count > 0)
            {
                if (txtCODIGO.Text.Trim() != string.Empty)
                {
                    filtros = FILTRO.Select("CODIGO LIKE '" + txtCODIGO.Text.Trim() + "%'");
                    if (filtros.Count() > 0)
                    {
                        FILTRO = filtros.CopyToDataTable();
                    }
                    else
                    {
                        FILTRO.Clear();
                    }
                }

            }
            tblEXISTENCIAS.DataSource = FILTRO;
        }


        private void txtCODIGO_TextChanged(object sender, EventArgs e)
        {
            if (EXISTENCIAS != null)
            {
                filtrarDatosExistencias();
            }
        }




        private void tblINVENTARIO_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tblEXISTENCIAS.IsCurrentCellDirty)
            {
                tblEXISTENCIAS.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }




        private void tblEXISTENCIAS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblEXISTENCIAS.CurrentCell != null && tblEXISTENCIAS.CurrentCell.RowIndex >= 0 && tblEXISTENCIAS.SelectedRows.Count == 1)
            {
                Existencia exist = Existencia.ConvertToExistencia(FILTRO.Rows[tblEXISTENCIAS.CurrentCell.RowIndex]);
                if (exist != null)
                {
                    VentasForm.Instance().addItemVenta(exist);
                    MessageBox.Show("ARTICULO AGREGADO", "ITEM VENTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        

    }
}
