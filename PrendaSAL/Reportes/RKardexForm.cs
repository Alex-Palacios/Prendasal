using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Reportes
{
    using MODELO;
    using DDB;

    public partial class RKardexForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RKardexForm frmInstance = null;

        public static RKardexForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RKardexForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBReporte dbReporte;
        private DBCatalogo dbCatalogo;
        private DataTable KARDEX;


        private void permisos()
        {

        }


        public RKardexForm()
        {
            InitializeComponent();
            dbReporte = new DBReporte();
            dbCatalogo = new DBCatalogo();
        }

        private void RKardexForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblKARDEX.AutoGenerateColumns = false;

            dateFechaInicio.Value = HOME.Instance().FECHA_SISTEMA;
            dateFechaFin.Value = HOME.Instance().FECHA_SISTEMA;

            cbxCategorias.DataSource = Enum.GetValues(new eCategoria().GetType());
            cbxCategorias.SelectedItem = eCategoria.ARTICULO;

            txtCODIGO.Text = string.Empty;
            lbENTRADAS.Text = "0.0";
            lbSALIDAS.Text = "0.0";
            lbINGRESOS.Text = "$0.00";
            lbEGRESOS.Text = "$0.00";
            lbCONSOLIDADO.Text = "$0.00";
            lbCONSOLIDADO.TextAlign = ContentAlignment.MiddleRight;

            rdbFILTROS.Checked = true;
        }



        private void rdbCODIGO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCODIGO.Checked)
            {
                txtCODIGO.Text = string.Empty;

                dateFechaFin.Enabled = false;
                dateFechaInicio.Enabled = false;
                cbxCategorias.Enabled = false;
                cbxItem.Enabled = false;
                txtCODIGO.ReadOnly = false;
            }
        }

        private void rdbFILTROS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFILTROS.Checked)
            {
                txtCODIGO.Text = string.Empty;

                dateFechaFin.Enabled = true;
                dateFechaInicio.Enabled = true;
                cbxCategorias.Enabled = true;
                cbxItem.Enabled = true;
                txtCODIGO.ReadOnly = true;
            }
        }



        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategorias.SelectedIndex >= 0)
            {
                DataTable CATALOGO = dbCatalogo.showCatalogo((eCategoria) cbxCategorias.SelectedItem);
                if (CATALOGO.Rows.Count == 0)
                {
                    CATALOGO.Columns.Add("CATEGORIA");
                    CATALOGO.Columns.Add("COD_ITEM");
                    CATALOGO.Columns.Add("UNIDAD_MEDIDA");
                }
                DataRow R = CATALOGO.NewRow();
                R.SetField<string>("CATEGORIA", "-----");
                R.SetField<string>("COD_ITEM", "TODAS");
                R.SetField<string>("UNIDAD_MEDIDA", "-----");
                CATALOGO.Rows.InsertAt(R, 0);

                cbxItem.DataSource = CATALOGO;
                cbxItem.DisplayMember = "COD_ITEM";
                cbxItem.ValueMember = "COD_ITEM";
            }
        }


        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (rdbFILTROS.Checked)
            {
                //BUSCAR POR ARTICULO
                if (dateFechaFin.Value >= dateFechaInicio.Value)
                {
                    KARDEX = dbReporte.RptKARDEX(null,dateFechaInicio.Value,dateFechaFin.Value,(string) cbxCategorias.Text,(string) cbxItem.SelectedValue);
                    tblKARDEX.DataSource = KARDEX.Copy();
                }
                else
                {
                    MessageBox.Show("RANGO DE FECHAS INVALIDA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //BUSCAR POR CODIGO
                if (txtCODIGO.Text.Trim() != string.Empty)
                {
                    KARDEX = dbReporte.RptKARDEX(txtCODIGO.Text.Trim()+"%",null,null,null,null);
                    tblKARDEX.DataSource = KARDEX.Copy();
                }
                else
                {
                    MessageBox.Show("INGRESE CODIGO DE ARTICULOS A BUSCAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            calcularTotales();
        }




        private void calcularTotales()
        {
            if (KARDEX != null)
            {
                decimal entradas = KARDEX.AsEnumerable().Select(r => r.Field<decimal>("ENTRADAS")).Sum();
                decimal salidas = KARDEX.AsEnumerable().Select(r => r.Field<decimal>("SALIDAS")).Sum();
                decimal ingresos = KARDEX.AsEnumerable().Select(r => r.Field<decimal>("INGRESOS")).Sum();
                decimal egresos = KARDEX.AsEnumerable().Select(r => r.Field<decimal>("EGRESOS")).Sum();
                decimal consolidado = ingresos - egresos;
                lbENTRADAS.Text = entradas.ToString("N1");
                lbSALIDAS.Text = salidas.ToString("N1");
                lbINGRESOS.Text = ingresos.ToString("C2");
                lbEGRESOS.Text = egresos.ToString("C2");

                if (consolidado < 0)
                {
                    lbCONSOLIDADO.Text = (consolidado*-1).ToString("C2");
                    lbCONSOLIDADO.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    lbCONSOLIDADO.Text = consolidado.ToString("C2");
                    lbCONSOLIDADO.TextAlign = ContentAlignment.MiddleLeft;
                }
                
            }
            else
            {
                lbCONSOLIDADO.Text = "$0.00";
                lbCONSOLIDADO.TextAlign = ContentAlignment.MiddleRight;
                lbENTRADAS.Text = "0.0";
                lbSALIDAS.Text = "0.0";
                lbINGRESOS.Text = "$0.00";
                lbEGRESOS.Text = "$0.00";
            }
        }



        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (KARDEX != null)
            {
                HOME.Instance().exportDataGridViewToExcel("REPORTE KARDEX", tblKARDEX.Columns, KARDEX, "ReporteKardex");
            }
        }
        





    }
}
