using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ControlesPersonalizados;

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;

    public partial class CustodiaForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static CustodiaForm frmInstance = null;

        public static CustodiaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CustodiaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLE
        private DBUsuario dbUser;
        private DBInventario dbInventario;
        public DataTable CUSTODIA_VALORES;
        private eOperacion ACCION;
        private Traslado SELECTED;
        private decimal TOTAL;

        public CustodiaForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            tblCustodia.AutoGenerateColumns = false;
        }

        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnLog.Visible = false;
            btnReimprimir.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P16")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscar.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }
        }





        private void CustodiaForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCustodia.AutoGenerateColumns = false;

            cbxSUC_ORG.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUC_ORG.DisplayMember = "SUCURSAL";
                cbxSUC_ORG.ValueMember = "CODIGO";
                cbxSUC_ORG.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxSUC_DEST.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUC_DEST.DisplayMember = "SUCURSAL";
                cbxSUC_DEST.ValueMember = "CODIGO";
            }

            List<eTipoDocTraslado> doc = new List<eTipoDocTraslado>();
            doc.Add(eTipoDocTraslado.ENVIO);
            cbxTIPODOC.DataSource = doc;
        }


        public void limpiar()
        {
            txtNUMERO.Text = "";
            txtEnvia.Text = "";
            txtNOTA.Text = "";
            dateTraslado.Value = HOME.Instance().FECHA_SISTEMA;
            txtTraslada.Text = "";
        }

        public void desbloquear()
        {
            txtTraslada.ReadOnly = false;
            cbxSUC_DEST.Enabled = true;
            txtNOTA.ReadOnly = false;
        }

        public void bloquear()
        {
            txtTraslada.ReadOnly = true;
            cbxSUC_DEST.Enabled = false;
            txtNOTA.ReadOnly = true;
        }



        public void cargarTrasladoSelected()
        {
            if (SELECTED != null)
            {
                limpiar();
                bloquear();
                cbxTIPODOC.SelectedItem = (eTipoDocTraslado) SELECTED.TIPO_DOC;
                txtNUMERO.Text = SELECTED.DOCUMENTO;
                dateTraslado.Value = SELECTED.FECHA;
                txtEnvia.Text = SELECTED.ENVIA;
                txtTraslada.Text = SELECTED.TRASLADA;
                cbxSUC_ORG.SelectedValue = SELECTED.SUC_ORG;
                cbxSUC_DEST.SelectedValue = SELECTED.SUC_DEST;
                txtNOTA.Text = SELECTED.NOTA;
                //tblCustodia.DataSource = dbInventario.GET_ITEMS_TRASLADO(SELECTED);

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
            }
        }

        private void tblCustodia_DataSourceChanged(object sender, EventArgs e)
        {
            calcularTotalCustodia();
        }



        private void calcularTotalCustodia()
        {
            TOTAL = (decimal)0.00;
            TOTAL = tblCustodia.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["VALOR"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL.Text = TOTAL.ToString("C2");
        }


        public void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            limpiar();
            cbxTIPODOC.SelectedItem = eTipoDocTraslado.ENVIO;
            //txtNUMERO.Text = dbInventario.NEXT_CUSTODIA_VALORES(HOME.Instance().SUCURSAL.COD_SUC);
            dateTraslado.Value = HOME.Instance().FECHA_SISTEMA;
            txtEnvia.Text = HOME.Instance().USUARIO.NOMBRE;
            cbxSUC_ORG.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            tblCustodia.DataSource = CUSTODIA_VALORES;
            desbloquear();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;
        }




        private bool validarTraslado()
        {
            bool OK = true;
            if (CUSTODIA_VALORES == null || CUSTODIA_VALORES.Rows.Count == 0)
            {
                OK = false;
                MessageBox.Show("NO SE HAN SELECCIONADO ARTICULOS A ENVIAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTraslada.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("INDIQUE RESPONSABLE DE TRASLADO DE BIENES", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxSUC_ORG.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("Seleccione sucursal que remite los bienes", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxSUC_DEST.SelectedIndex < 0 )
            {
                OK = false;
                MessageBox.Show("Seleccione sucursal de Destino", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }

        private Traslado buildTRASLADO()
        {
            Traslado t = new Traslado();
            t.TIPO_DOC = (eTipoDocTraslado)cbxTIPODOC.SelectedItem;
            t.DOCUMENTO = txtNUMERO.Text;
            t.FECHA = dateTraslado.Value;
            t.ENVIA = txtEnvia.Text;
            t.TRASLADA = txtTraslada.Text.Trim();
            t.SUC_ORG = (string)cbxSUC_ORG.SelectedValue;
            t.SUC_DEST = (string)cbxSUC_DEST.SelectedValue;
            t.NOTA = txtNOTA.Text;
            t.ARTICULOS = CUSTODIA_VALORES.Rows;
            return t;
        }


        private void GUARDAR(object sender, EventArgs e)
        {
            Traslado t = new Traslado();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarTraslado())
                    {
                        t = buildTRASLADO();
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            t.RECIBIDO = false;
                            //if (dbInventario.REGISTRAR_CUSTODIA_PRENDASAL(t, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            //{
                            //    SELECTED = dbInventario.findCustodiaValoresByDocPRENDASAL(t.DOCUMENTO);
                            //    cargarTrasladoSelected();
                            //    ImprimirCustodiaValores();
                            //}
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;
            }

        }



        private void CANCELAR(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    this.Close();
                    break;
                default:
                    NUEVO(null, null);
                    break;
            }
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la " + SELECTED.TIPO_DOC.ToString().Replace('_',' ') + " #"+SELECTED.DOCUMENTO +" realizada el "+ SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR TRASLADO DE BIENES REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        //if (dbInventario.ELIMINAR_CUSTODIA_PRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        //{
                        //    NUEVO(null, null);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }



        private void BUSCAR(object sender, EventArgs e)
        {
            string documento = Controles.InputBox("CUSTODIA DE VALORE #:", "BUSCAR");
            if (documento.Trim() != "")
            {
                //SELECTED = dbInventario.findCustodiaValoresByDocPRENDASAL(documento.Trim());
                if (SELECTED != null)
                {
                    cargarTrasladoSelected();
                    MessageBox.Show("TRASLADO DE " + SELECTED.TIPO_DOC.ToString().Replace('_',' ') + " #"+SELECTED.DOCUMENTO +" CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("TRASLADO NO ENCONTRADO", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.PREVIEW;
                ImprimirCustodiaValores();
            }
        }

        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }






        public void ImprimirCustodiaValores()
        {
            viewerCUSTODIA.Clear();
            try
            {
                if (SELECTED != null && tblCustodia.DataSource != null)
                {
                    articuloMov.Clear();
                    foreach (DataGridViewRow row in tblCustodia.Rows)
                    {
                        articuloMov.ARTICULO_MOV.AddARTICULO_MOVRow(row.Cells["CODIGO"].Value.ToString(), row.Cells["CATEGORIA"].Value.ToString(), row.Cells["ARTICULO"].Value.ToString(), Double.Parse(row.Cells["CANTIDAD"].Value.ToString()), row.Cells["DESCRIPCION"].Value.ToString(), Decimal.Parse(row.Cells["VALOR"].Value.ToString()));
                    }
                    bindingTraslado.DataSource = articuloMov.ARTICULO_MOV;

                    ReportParameter[] parameters = new ReportParameter[7];
                    parameters[0] = new ReportParameter("FechaImp", "Impresion: "+ HOME.Instance().FECHA_SISTEMA.Date.ToString("dd/MM/yyyy"));
                    parameters[1] = new ReportParameter("numENVIO", SELECTED.DOCUMENTO);
                    parameters[2] = new ReportParameter("fechaEnvio", SELECTED.FECHA.Date.ToString("dd/MM/yyyy"));
                    parameters[3] = new ReportParameter("origenSUC", cbxSUC_ORG.Text);
                    parameters[4] = new ReportParameter("destinoSUC", cbxSUC_DEST.Text);
                    parameters[5] = new ReportParameter("ENVIA", SELECTED.ENVIA);
                    parameters[6] = new ReportParameter("TRASLADA", SELECTED.TRASLADA);

                    viewerCUSTODIA.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.CustodiaValores.rdlc";
                    viewerCUSTODIA.LocalReport.DataSources.Clear();
                    viewerCUSTODIA.LocalReport.DataSources.Add(new ReportDataSource("ARTICULO", bindingTraslado));
                    viewerCUSTODIA.LocalReport.SetParameters(parameters);
                    viewerCUSTODIA.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al generar nota de envio .... intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
            
        }





        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerCUSTODIA.PrintDialog();
            }
        }

       


    }
}
