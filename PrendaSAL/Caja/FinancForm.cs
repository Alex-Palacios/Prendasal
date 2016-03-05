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
using Microsoft.Reporting.WinForms;

namespace PrendaSAL.Caja
{
    using MODELO;
    using DDB;

    public partial class FinancForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static FinancForm frmInstance = null;

        public static FinancForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FinancForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //variables
        private DBUsuario dbUser;
        private DBMovCash dbFinanc;
        private eOperacion ACCION;

        private MovCash SELECTED;
        private DataTable FINANCIAMIENTOS;

        public FinancForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbFinanc = new DBMovCash();
        }


        private void permisos()
        {
            btnRecibir.Visible = false;
            btnLog.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P9")
                {
                    btnRecibir.Visible = p.Field<bool>("REGISTRAR");
                    btnLog.Visible = p.Field<bool>("LOG");                
                }
            }
        }



        private void FinancForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblFinanc.AutoGenerateColumns = false;
            cargarHistoryFinanc();
            btnRecibir.Enabled = false;
        }


        public void cargarHistoryFinanc()
        {
            FINANCIAMIENTOS = dbFinanc.getFinancBySucAnioMes(HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().FECHA_SISTEMA.Year.ToString(), HOME.Instance().FECHA_SISTEMA.Month.ToString(),"00");
            tblFinanc.DataSource = FINANCIAMIENTOS;
            calcularTotales();
        }



        private void calcularTotales()
        {
            decimal TOTAL = tblFinanc.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["TOTAL"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL.Text = TOTAL.ToString("C2");
        }



        private void tblFinanc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblFinanc.Columns[e.ColumnIndex].Name)
                {
                    case "NUM":
                        e.Value = e.RowIndex + 1;
                        break;
                    case "RECIBE":
                        if (e.Value == null || e.Value.ToString() == string.Empty)
                        {
                            e.Value = "PENDIENTE";
                            e.CellStyle.ForeColor = Color.Red;
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.Black;
                        }
                        break;
                }
            }
        }



        private void tblFinanc_SelectionChanged(object sender, EventArgs e)
        {
            SELECTED = null;
            if (tblFinanc.CurrentCell != null && tblFinanc.SelectedRows.Count == 1)
            {
                SELECTED = MovCash.ConvertToMovCash(FINANCIAMIENTOS.Rows[tblFinanc.CurrentCell.RowIndex]);
                if (SELECTED != null)
                {
                    if (SELECTED.RECIBIDO)
                    {
                        btnRecibir.Enabled = false;
                    }
                    else
                    {
                        btnRecibir.Enabled = true;
                    }
                }
                else
                {
                    btnRecibir.Enabled = false;
                }
            }
        }



        private void RECIBIR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                if (SELECTED != null)
                {
                    ACCION = eOperacion.UPDATE;
                    SELECTED.RECIBE = HOME.Instance().USUARIO.NOMBRE;
                    ConfirmarFinanc financ = new ConfirmarFinanc(SELECTED);
                    financ.ShowDialog();
                }
                else
                {
                    MessageBox.Show("SELECCIONE FINANCIAMIENTO A RECIBIR", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        

        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> AMS = Controles.InputComboBoxAMS("BUSCAR POR", HOME.Instance().datSUCURSALES.Copy());
            if (AMS != null && AMS.Count ==3)
            {
                FINANCIAMIENTOS = dbFinanc.getFinancBySucAnioMes(HOME.Instance().SUCURSAL.COD_SUC,AMS[0],AMS[1],AMS[2]);
                tblFinanc.DataSource = FINANCIAMIENTOS;
                calcularTotales();
            }
        }




        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (FINANCIAMIENTOS != null)
            {
                HOME.Instance().exportDataGridViewToExcel("FINANCIAMIENTOS", tblFinanc.Columns, FINANCIAMIENTOS, "Financiamientos");
            }
        }


       






    }
}
