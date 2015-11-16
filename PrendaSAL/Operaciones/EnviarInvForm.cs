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
        private DataTable CUSTODIA;
        private DataTable PRESTAMOS;
        private DataTable COMPRAS;
        
        public EnviarInvForm(Traslado traslado)
        {
            InitializeComponent();
            dbInventario = new DBInventario();
            TRASLADO = traslado;
            
        }




        private void EnviarInvForm_Load(object sender, EventArgs e)
        {
            tblCUSTODIA_PRESTAMOS.AutoGenerateColumns = false;
            tblCUSTODIA_COMPRAS.AutoGenerateColumns = false;
            tblREMISION.AutoGenerateColumns = false;
            tabDETALLE.TabPages.Clear();

            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:
                    tabDETALLE.TabPages.Add(pagCUSTODIA);
                    CUSTODIA = dbInventario.getCustodiaBySuc(TRASLADO.SUC_ENVIA);
                    foreach (DataRow row in TRASLADO.CUSTODIA.Rows)
                    {
                        eliminarListadoCV(row.Field<string>("TRANS"), row.Field<int>("ID"));
                    }
                    PRESTAMOS = CUSTODIA.Copy();
                    COMPRAS = CUSTODIA.Copy();
                    if (PRESTAMOS.Rows.Count > 0)
                    {
                        PRESTAMOS.DefaultView.RowFilter = "TRANS LIKE 'PRESTAMO'";
                    }
                    if (COMPRAS.Rows.Count > 0)
                    {
                        COMPRAS.DefaultView.RowFilter = "TRANS LIKE 'COMPRA'";
                    }
                    tblCUSTODIA_PRESTAMOS.DataSource = PRESTAMOS.DefaultView;
                    tblCUSTODIA_COMPRAS.DataSource = COMPRAS.DefaultView;
                    foreach (DataGridViewColumn column in tblCUSTODIA_PRESTAMOS.Columns)
                    {
                        if (column.Name == "CKCVP")
                        {
                            column.ReadOnly = false;
                        }
                        else
                        {
                            column.ReadOnly = true;
                        }
                    }
                    foreach (DataGridViewColumn column in tblCUSTODIA_COMPRAS.Columns)
                    {
                        if (column.Name == "CKCVC")
                        {
                            column.ReadOnly = false;
                        }
                        else
                        {
                            column.ReadOnly = true;
                        }
                    }
                    lbTOTAL_RM.Text = "0 PRESTAMOS                          0 COMPRAS";
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
                    lbTOTAL_RM.Text = "0 ARTICULOS";
                    break;
            }
        }








        //NOTA REMISION
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



        private void ckALLRM_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblREMISION.Rows)
            {
                row.Cells["CKRM"].Value = ckALLRM.Checked;
            }
        }

        private void tblREMISION_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tblREMISION.Columns[e.ColumnIndex].Name == "CKRM" && e.RowIndex >= 0)
            {
                calcularTotales();
            }
        }






        //CUSTODIA VALORES

        private void tblCUSTODIA_COMPRAS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblCUSTODIA_COMPRAS.Columns[e.ColumnIndex].Name)
                {
                    case "NIVEL":
                        eNIVEL nivel = (eNIVEL) (Int64)e.Value;
                        if (nivel == eNIVEL.MAYOREO)
                        {
                            e.Value = "M";
                        }
                        else
                        {
                            e.Value = string.Empty;
                        }
                        break;
                }
            }
        }


        private void eliminarListadoCV(string trans,int id)
        {
            DataRow eliminar = null;
            foreach (DataRow row in CUSTODIA.Rows)
            {
                if (row.Field<string>("TRANS") == trans && row.Field<int>("ID") == id)
                {
                    eliminar = row;
                    break;
                }
            }
            if (eliminar != null)
            {
                CUSTODIA.Rows.Remove(eliminar);
            }
            
        }




        private void ckALLCVP_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
            {
                row.Cells["CKCVP"].Value = ckALLCVP.Checked;
            }
        }

        private void ckALLCVC_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
            {
                row.Cells["CKCVC"].Value = ckALLCVC.Checked;
            }
        }

        private void tblCUSTODIA_PRESTAMOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCUSTODIA_PRESTAMOS.Columns[e.ColumnIndex].Name == "CKCVP" && e.RowIndex >= 0)
            {
                calcularTotales();
            }
        }

        private void tblCUSTODIA_COMPRAS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCUSTODIA_COMPRAS.Columns[e.ColumnIndex].Name == "CKCVC" && e.RowIndex >= 0)
            {
                calcularTotales();
            }
        }


        private void calcularTotales()
        {
            int seleccionados = 0;
            int seleccionados_prestamos = 0;
            int seleccionados_compras = 0;
            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:
                    foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
                    {
                        if ((bool)row.Cells["CKCVP"].FormattedValue)
                        {
                            seleccionados_prestamos++;
                        }
                    }
                    foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
                    {
                        if ((bool)row.Cells["CKCVC"].FormattedValue)
                        {
                            seleccionados_compras++;
                        }
                    }
                    lbTOTAL_RM.Text = seleccionados_prestamos + " PRESTAMOS                          "+seleccionados_compras + " COMPRAS";
                    break;



                case eTipoTraslado.NOTA_REMISION:
                    foreach (DataGridViewRow row in tblREMISION.Rows)
                    {
                        if ((bool)row.Cells["CKRM"].FormattedValue)
                        {
                            seleccionados++;
                        }
                    }
                    lbTOTAL_RM.Text = seleccionados + " ARTICULOS";
                    break;
            }
        }





        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:
                    foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
                    {
                        if ((bool)row.Cells["CKCVP"].FormattedValue)
                        {
                            TRASLADO.CUSTODIA.Rows.Add(PRESTAMOS.DefaultView.ToTable().Rows[row.Index].Field<string>("TRANS"), PRESTAMOS.DefaultView.ToTable().Rows[row.Index].Field<string>("CONTRATO"), PRESTAMOS.DefaultView.ToTable().Rows[row.Index].Field<string>("CATEGORIA"), PRESTAMOS.DefaultView.ToTable().Rows[row.Index].Field<Int64>("NIVEL"), PRESTAMOS.DefaultView.ToTable().Rows[row.Index].Field<int>("ID"));
                        }
                    }
                    foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
                    {
                        if ((bool)row.Cells["CKCVC"].FormattedValue)
                        {
                            TRASLADO.CUSTODIA.Rows.Add(COMPRAS.DefaultView.ToTable().Rows[row.Index].Field<string>("TRANS"), COMPRAS.DefaultView.ToTable().Rows[row.Index].Field<string>("CONTRATO"), COMPRAS.DefaultView.ToTable().Rows[row.Index].Field<string>("CATEGORIA"), COMPRAS.DefaultView.ToTable().Rows[row.Index].Field<Int64>("NIVEL"), COMPRAS.DefaultView.ToTable().Rows[row.Index].Field<int>("ID"));
                        }
                    }
                    TrasladoForm.Instance().updateTblCUSTODIA();
                    break;



                case eTipoTraslado.NOTA_REMISION:
                    foreach (DataGridViewRow row in tblREMISION.Rows)
                    {
                        if ((bool)row.Cells["CKRM"].FormattedValue)
                        {
                            TRASLADO.REMISION.Rows.Add(ARTICULOS.Rows[row.Index].Field<string>("CODIGO"), ARTICULOS.Rows[row.Index].Field<decimal>("CANTIDAD"), ARTICULOS.Rows[row.Index].Field<string>("COD_ITEM"), ARTICULOS.Rows[row.Index].Field<string>("DESCRIPCION"), ARTICULOS.Rows[row.Index].Field<decimal>("PRECIO"), null);
                        }
                    }
                    TrasladoForm.Instance().updateTblREMISION();
                    break;
            }
            this.Close();
        }

       

        


    }
}
