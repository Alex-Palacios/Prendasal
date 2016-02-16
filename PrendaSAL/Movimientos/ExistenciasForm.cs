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
            EXISTENCIAS = dbExistencias.getExistenciasARTICULOS(HOME.Instance().SUCURSAL.COD_SUC);
            tblEXISTENCIAS.DataSource = EXISTENCIAS;
        }



        private void txtCODIGO_TextChanged(object sender, EventArgs e)
        {
            if (txtCODIGO.Text.Trim() != string.Empty)
            {
                if (EXISTENCIAS.Rows.Count > 0)
                {
                    EXISTENCIAS.DefaultView.RowFilter = "CODIGO LIKE '" + txtCODIGO.Text.Trim() + "%'";
                }
                tblEXISTENCIAS.DataSource = EXISTENCIAS.DefaultView;
            }
            else
            {
                tblEXISTENCIAS.DataSource = EXISTENCIAS.Copy();
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
                Existencia exist = Existencia.ConvertToExistencia(EXISTENCIAS.Rows[tblEXISTENCIAS.CurrentCell.RowIndex]);
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
