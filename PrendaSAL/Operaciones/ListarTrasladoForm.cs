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

    public partial class ListarTrasladoForm : Form
    {
        private DBTraslado dbTraslado;
        private eTipoDetalleTraslado TIPO;
        private Traslado TRASLADO;
        private DataTable ARTICULOS;
        private DataTable PRESTAMOS;
        private DataTable COMPRAS;
        
        public ListarTrasladoForm(eTipoDetalleTraslado tipo,Traslado traslado)
        {
            InitializeComponent();
            dbTraslado = new DBTraslado();
            TRASLADO = traslado;
            TIPO = tipo;
        }




        private void EnviarInvForm_Load(object sender, EventArgs e)
        {
            tblCUSTODIA_PRESTAMOS.AutoGenerateColumns = false;
            tblCUSTODIA_COMPRAS.AutoGenerateColumns = false;
            tblREMISION.AutoGenerateColumns = false;
            tabDETALLE.TabPages.Clear();
            switch (TIPO)
            {
                case eTipoDetalleTraslado.ARTICULO:
                    tabDETALLE.TabPages.Add(pagARTICULOS);
                    ARTICULOS = dbTraslado.getExistenciasTrasladoARTICULOS(TRASLADO.SUC_ENVIA);
                    foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
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
                    lbTOTAL_REMISION.Text = "0 ARTICULOS";
                    break;



                


                case eTipoDetalleTraslado.PRESTAMO:
                    tabDETALLE.TabPages.Add(pagPRESTAMOS);
                    PRESTAMOS = dbTraslado.getCustodiaBySuc(eTipoDetalleTraslado.PRESTAMO, TRASLADO.SUC_ENVIA);
                    foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
                    {
                        eliminarListadoCVP(row.Field<string>("CODIGO"));
                    }
                    tblCUSTODIA_PRESTAMOS.DataSource = PRESTAMOS;
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
                    lbTOTAL_CUSTODIA_PRESTAMO.Text = "0 CONTRATOS";
                    break;



                case eTipoDetalleTraslado.COMPRA:
                    tabDETALLE.TabPages.Add(pagCOMPRAS);
                    COMPRAS = dbTraslado.getCustodiaBySuc(eTipoDetalleTraslado.COMPRA, TRASLADO.SUC_ENVIA);
                    foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
                    {
                        eliminarListadoCVC(row.Field<string>("CODIGO"));
                    }
                    tblCUSTODIA_COMPRAS.DataSource = COMPRAS;
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
                    lbTOTAL_CUSTODIA_COMPRA.Text = "0 COMPRAS";
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
                calcularTotales_REMISION();
            }
        }


        private void calcularTotales_REMISION()
        {
            int seleccionados = 0;
            foreach (DataGridViewRow row in tblREMISION.Rows)
            {
                if ((bool)row.Cells["CKRM"].FormattedValue)
                {
                    seleccionados++;
                }
            }
            lbTOTAL_REMISION.Text = seleccionados + " ARTICULOS";
        }





        private void btnOK_REMISION_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblREMISION.Rows)
            {
                if ((bool)row.Cells["CKRM"].FormattedValue)
                {
                    TRASLADO.DETALLE_TRASLADO.Rows.Add((int)eTipoDetalleTraslado.ARTICULO,ARTICULOS.Rows[row.Index].Field<string>("CODIGO"), ARTICULOS.Rows[row.Index].Field<decimal>("CANTIDAD"), ARTICULOS.Rows[row.Index].Field<string>("COD_ITEM"), ARTICULOS.Rows[row.Index].Field<string>("DESCRIPCION"), ARTICULOS.Rows[row.Index].Field<decimal>("PRECIO"),false);
                }
            }
            EnviarTrasladoForm.Instance().updateTblREMISION();
            this.Close();
        }








        //CUSTODIA VALORES PRESTAMOS

        private void eliminarListadoCVP(string codigo)
        {
            DataRow eliminar = null;
            foreach (DataRow row in PRESTAMOS.Rows)
            {
                if (row.Field<string>("DOCUMENTO") == codigo)
                {
                    eliminar = row;
                    break;
                }
            }
            if (eliminar != null)
            {
                PRESTAMOS.Rows.Remove(eliminar);
            }
        }



        private void ckALLCVP_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
            {
                row.Cells["CKCVP"].Value = ckALLCVP.Checked;
            }
        }



        private void tblCUSTODIA_PRESTAMOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCUSTODIA_PRESTAMOS.Columns[e.ColumnIndex].Name == "CKCVP" && e.RowIndex >= 0)
            {
                calcularTotales_CUSTODIA_PRESTAMOS();
            }
        }


        private void calcularTotales_CUSTODIA_PRESTAMOS()
        {
            int seleccionados = 0;
            foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
            {
                if ((bool)row.Cells["CKCVP"].FormattedValue)
                {
                    seleccionados++;
                }
            }
            lbTOTAL_CUSTODIA_PRESTAMO.Text = seleccionados + " CONTRATOS";
        }





        private void btnOK_CUSTODIA_PRESTAMO_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
            {
                if ((bool)row.Cells["CKCVP"].FormattedValue)
                {
                    TRASLADO.DETALLE_TRASLADO.Rows.Add((int)eTipoDetalleTraslado.PRESTAMO, PRESTAMOS.Rows[row.Index].Field<string>("DOCUMENTO"), (decimal)0.0, PRESTAMOS.Rows[row.Index].Field<string>("CATEGORIA"), "-----", (decimal)0.00,false);
                }
            }
            EnviarTrasladoForm.Instance().updateTblCUSTODIA();
            this.Close();
        }






        //CUSTODIA VALORES COMPRAS

        private void eliminarListadoCVC(string codigo)
        {
            DataRow eliminar = null;
            foreach (DataRow row in COMPRAS.Rows)
            {
                if (row.Field<string>("DOCUMENTO") == codigo)
                {
                    eliminar = row;
                    break;
                }
            }
            if (eliminar != null)
            {
                COMPRAS.Rows.Remove(eliminar);
            }
        }



        private void ckALLCVC_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
            {
                row.Cells["CKCVC"].Value = ckALLCVC.Checked;
            }
        }



        private void tblCUSTODIA_COMPRAS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCUSTODIA_COMPRAS.Columns[e.ColumnIndex].Name == "CKCVC" && e.RowIndex >= 0)
            {
                calcularTotales_CUSTODIA_COMPRAS();
            }
        }


        private void calcularTotales_CUSTODIA_COMPRAS()
        {
            int seleccionados = 0;
            foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
            {
                if ((bool)row.Cells["CKCVC"].FormattedValue)
                {
                    seleccionados++;
                }
            }
            lbTOTAL_CUSTODIA_COMPRA.Text = seleccionados + " COMPRAS";
        }





        private void btnOK_CUSTODIA_COMPRA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
            {
                if ((bool)row.Cells["CKCVC"].FormattedValue)
                {
                    if (TRASLADO.CUSTODIA_COMPRAS.Rows.Count <= 20)
                    {
                        TRASLADO.DETALLE_TRASLADO.Rows.Add((int)eTipoDetalleTraslado.COMPRA, COMPRAS.Rows[row.Index].Field<string>("DOCUMENTO"), (decimal)(int)COMPRAS.Rows[row.Index].Field<int>("NIVEL"), COMPRAS.Rows[row.Index].Field<string>("CATEGORIA"), "-----", (decimal)0.00,false);
                    }
                    
                }
            }
            EnviarTrasladoForm.Instance().updateTblCUSTODIA();
            this.Close();
        }
       

        


    }
}
