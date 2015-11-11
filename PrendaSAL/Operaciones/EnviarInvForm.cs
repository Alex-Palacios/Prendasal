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
    using MODELO;
    using DDB;

    public partial class EnviarInvForm : Form
    {
        private DBInventario dbInventario;
        private Traslado TRASLADO;
        private DataTable ARTICULOS;
        
        public EnviarInvForm(Traslado traslado)
        {
            InitializeComponent();
            dbInventario = new DBInventario();
            TRASLADO = traslado;
            
        }




        private void EnviarInvForm_Load(object sender, EventArgs e)
        {
            tblCUSTODIA.AutoGenerateColumns = false;
            tblREMISION.AutoGenerateColumns = false;
            tabDETALLE.TabPages.Clear();
            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:
                    tabDETALLE.TabPages.Add(pagCUSTODIA);
                    tblCUSTODIA.DataSource = dbInventario.getCustodiaBySuc(TRASLADO.SUC_ENVIA);
                    break;
                case eTipoTraslado.NOTA_REMISION:
                    tabDETALLE.TabPages.Add(pagREMISION);
                    ARTICULOS = dbInventario.getExistenciasARTICULOSbySuc(TRASLADO.SUC_ENVIA);
                    foreach (DataRow row in TRASLADO.REMISION.Rows)
                    {
                        eliminarListadoRM(row.Field<string>("CODIGO"));
                    }
                    tblREMISION.DataSource = ARTICULOS;
                    foreach (DataGridViewColumn column in tblREMISION.Columns)
                    {
                        if (column.Name == "CKRM")
                        {
                            column.ReadOnly = false;
                        }
                        else
                        {
                            column.ReadOnly = true;
                        }
                    }
                    lbTOTAL_RM.Text = "0 SELECCIONADOS";
                    break;
            }
        }



        private void eliminarListadoRM(string codigo)
        {
            DataRow eliminar = null;
            foreach(DataRow row in ARTICULOS.Rows)
            {
                if (row.Field<string>("CODIGO") == codigo)
                {
                    eliminar = row;
                    break;
                }
            }
            if (eliminar != null)
            {
                ARTICULOS.Rows.Remove(eliminar);
            }
        }




        private void tblREMISION_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tblREMISION.Columns[e.ColumnIndex].Name == "CKRM" && e.RowIndex >= 0)
            {
                calcularTotales();
            }
        }




        private void ckALL_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblREMISION.Rows)
            {
                row.Cells["CKRM"].Value = ckALLRM.Checked;
            }
        }





        private void calcularTotales()
        {
            int seleccionados = 0;
            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:

                    break;
                case eTipoTraslado.NOTA_REMISION:
                    foreach (DataGridViewRow row in tblREMISION.Rows)
                    {
                        if ((bool)row.Cells["CKRM"].FormattedValue)
                        {
                            seleccionados++;
                        }
                    }
                    
                    break;
            }
            lbTOTAL_RM.Text = seleccionados + " SELECCIONADOS";
        }





        private void btnOK_RM_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblREMISION.Rows)
            {
                if ((bool)row.Cells["CKRM"].FormattedValue)
                {
                    TRASLADO.REMISION.Rows.Add(ARTICULOS.Rows[row.Index].Field<string>("CODIGO"), ARTICULOS.Rows[row.Index].Field<decimal>("CANTIDAD"), ARTICULOS.Rows[row.Index].Field<string>("COD_ITEM"), ARTICULOS.Rows[row.Index].Field<string>("DESCRIPCION"), ARTICULOS.Rows[row.Index].Field<decimal>("PRECIO"),null);
                }
            }
            TrasladoForm.Instance().updateTblREMISION();
            this.Close();
        }



        


    }
}
