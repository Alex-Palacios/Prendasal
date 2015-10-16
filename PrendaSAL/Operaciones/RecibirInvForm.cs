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

namespace PrendaSAL.Operaciones
{
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class RecibirInvForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RecibirInvForm frmInstance = null;

        public static RecibirInvForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RecibirInvForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;
        private InventarioController dbInventario;
        private DataTable VALORES_CUSTODIA;
        private DataTable INVENTARIO;
        private decimal TOTAL_CUSTODIA;
        private decimal TOTAL_REMISION;
        private Traslado SELECTED;

        public RecibirInvForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new InventarioController();
        }

        private void permisos()
        {
            btnRECIBIR_CUSTODIA.Visible = false;
            btnRECIBIR_REMISION.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P15")
                {
                    btnRECIBIR_CUSTODIA.Visible = p.Field<bool>("REGISTRAR");
                    btnRECIBIR_REMISION.Visible = p.Field<bool>("REGISTRAR");
                }
            }
        }

        private void RecibirInvForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCustodia.AutoGenerateColumns = false;
            tblInventario.AutoGenerateColumns = false;
            tabControlEnvio.SelectedIndex = -1;
            tabControlEnvio.SelectedIndex = 0;

            cbxSUC_ORG_Custodia.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUC_ORG_Custodia.DisplayMember = "SUCURSAL";
                cbxSUC_ORG_Custodia.ValueMember = "CODIGO";
            }
            cbxSUC_DEST_Custodia.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUC_DEST_Custodia.DisplayMember = "SUCURSAL";
                cbxSUC_DEST_Custodia.ValueMember = "CODIGO";
            }
            cbxTIPODOC_Custodia.DataSource = Enum.GetValues(new eTipoDocTraslado().GetType());

            cbxSUC_ORG_Remision.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUC_ORG_Remision.DisplayMember = "SUCURSAL";
                cbxSUC_ORG_Remision.ValueMember = "CODIGO";
            }
            cbxSUC_DEST_Remision.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUC_DEST_Remision.DisplayMember = "SUCURSAL";
                cbxSUC_DEST_Remision.ValueMember = "CODIGO";
            }
            cbxTIPODOC_Remision.DataSource = Enum.GetValues(new eTipoDocTraslado().GetType());

        }

        private void limpiarCustodia()
        {
            txtNUMERO_Custodia.Text = "";
            txtEnvia_Custodia.Text = "";
            txtNOTA_Custodia.Text = "";
            dateTraslado_Custodia.Value = HOME.Instance().FECHA_SISTEMA;
            txtTraslada_Custodia.Text = "";
            txtESTADO_Custodia.Text = "";
            txtRecibe_Custodia.Text = HOME.Instance().USUARIO.NOMBRE;
            tblCustodia.DataSource = null;
        }

        private void limpiarRemision()
        {
            txtNUMERO_Remision.Text = "";
            txtEnvia_Remision.Text = "";
            txtNOTA_Remision.Text = "";
            dateTraslado_Remision.Value = HOME.Instance().FECHA_SISTEMA;
            txtTraslada_Remision.Text = "";
            txtESTADO_Remision.Text = "";
            txtRecibe_Remision.Text = HOME.Instance().USUARIO.NOMBRE;
            tblCustodia.DataSource = null;
        }

        private void tabControlEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlEnvio.SelectedIndex >= 0)
            {
                switch (tabControlEnvio.SelectedTab.Name)
                {
                    case "pagCustodia":
                        SELECTED = null;
                        txtRecibe_Custodia.Text = HOME.Instance().USUARIO.NOMBRE;
                        limpiarCustodia();
                        break;
                    case "pagRemision":
                        SELECTED = null;
                        txtRecibe_Custodia.Text = HOME.Instance().USUARIO.NOMBRE;
                        limpiarRemision();
                        break;
                }
            }
        }



        // CUSTODIA DE VALORES


        private void txtNUMERO_Custodia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtNUMERO_Custodia.Text.Trim() != string.Empty)
            {
                SELECTED = dbInventario.findRecibirTrasladoByDocPRENDASAL(eTipoTraslado.MOV_CUSTODIA, eTipoDocTraslado.ENVIO, txtNUMERO_Custodia.Text.Trim().ToUpper(), HOME.Instance().SUCURSAL.COD_SUC);
                cargarCustodia();
                e.Handled = true;
            }
        }


        private void cargarCustodia()
        {
            if (SELECTED != null && SELECTED.TIPO == eTipoTraslado.MOV_CUSTODIA)
            {
                limpiarCustodia();
                cbxTIPODOC_Custodia.SelectedItem = SELECTED.TIPO_DOC;
                txtNUMERO_Custodia.Text = SELECTED.DOCUMENTO;
                dateTraslado_Custodia.Value = SELECTED.FECHA;
                txtEnvia_Custodia.Text = SELECTED.ENVIA;
                cbxSUC_ORG_Custodia.SelectedValue = SELECTED.SUC_ORG;
                txtTraslada_Custodia.Text = SELECTED.TRASLADA;
                cbxSUC_DEST_Custodia.SelectedValue = SELECTED.SUC_DEST;
                txtNOTA_Custodia.Text = SELECTED.NOTA;
                if (SELECTED.RECIBIDO)
                {
                    txtESTADO_Custodia.ForeColor = Color.Green;
                    txtESTADO_Custodia.Text = "RECIBIDO";
                    txtRecibe_Custodia.Text = SELECTED.RECIBE;
                    btnRECIBIR_CUSTODIA.Enabled = false;
                }
                else
                {
                    txtESTADO_Custodia.ForeColor = Color.Red;
                    txtESTADO_Custodia.Text = "PENDIENTE";
                    txtRecibe_Custodia.Text = HOME.Instance().USUARIO.NOMBRE;
                    btnRECIBIR_CUSTODIA.Enabled = true;
                }
                tblCustodia.DataSource = dbInventario.GET_ITEMS_TRASLADO(SELECTED);
                MessageBox.Show("TRASLADO DE " + SELECTED.TIPO_DOC.ToString().Replace('_', ' ') + " #" + SELECTED.DOCUMENTO + " CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("CUSTODIA DE VALORES #" + txtNUMERO_Custodia.Text.Trim().ToUpper() + " NO EXISTE O NO TIENE COMO DESTINO A LA SUCURSAL ACTUAL", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void calcularTotalesCustodia()
        {
            TOTAL_CUSTODIA = (decimal)0.00;
            TOTAL_CUSTODIA = tblCustodia.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["VALOR"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL_CUSTODIA.Text = TOTAL_CUSTODIA.ToString("C2");
            lbARTICULOS_CUSTODIA.Text = tblCustodia.Rows.Count + " ARTICULOS";
        }

        private void tblCustodia_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblCustodia.DataSource != null)
            {
                calcularTotalesCustodia();
            }
            else
            {
                TOTAL_CUSTODIA = (decimal)0.00;
                lbTOTAL_CUSTODIA.Text = TOTAL_CUSTODIA.ToString("C2");
                lbARTICULOS_CUSTODIA.Text = "0 ARTICULOS";
            }
        }

        private void RECIBIR_CUSTODIA(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                DialogResult recibir = MessageBox.Show("AL MARCAR COMO RECIBIDO EL TRASLADO DE "+SELECTED.TIPO_DOC.ToString() +" #"+SELECTED.DOCUMENTO +" \nUSTED ESTA CONFIRMANDO QUE TODOS LOS ARTICULOS LISTADOS HAN LLEGADO A SU DESTINO SATISFACTORIAMENTE\nDesea continuar?", "RECEPCION DE ARTICULOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (recibir == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbInventario.RECIBIR_TRASLADO_PRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            SELECTED = dbInventario.findRecibirTrasladoByDocPRENDASAL(eTipoTraslado.MOV_CUSTODIA, eTipoDocTraslado.ENVIO, txtNUMERO_Custodia.Text.Trim().ToUpper(), HOME.Instance().SUCURSAL.COD_SUC);
                            cargarCustodia();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }








        // REMISION DE ARTICULOS


        private void txtNUMERO_Remision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtNUMERO_Remision.Text.Trim() != string.Empty)
            {
                SELECTED = dbInventario.findRecibirTrasladoByDocPRENDASAL(eTipoTraslado.MOV_INVENTARIO, eTipoDocTraslado.REMISION, txtNUMERO_Remision.Text.Trim().ToUpper(), HOME.Instance().SUCURSAL.COD_SUC);
                cargarRemision();
                e.Handled = true;
            }
        }


        private void cargarRemision()
        {
            if (SELECTED != null && SELECTED.TIPO == eTipoTraslado.MOV_INVENTARIO)
            {
                limpiarRemision();
                cbxTIPODOC_Remision.SelectedItem = SELECTED.TIPO_DOC;
                txtNUMERO_Remision.Text = SELECTED.DOCUMENTO;
                dateTraslado_Remision.Value = SELECTED.FECHA;
                txtEnvia_Remision.Text = SELECTED.ENVIA;
                cbxSUC_ORG_Remision.SelectedValue = SELECTED.SUC_ORG;
                txtTraslada_Remision.Text = SELECTED.TRASLADA;
                cbxSUC_DEST_Remision.SelectedValue = SELECTED.SUC_DEST;
                txtNOTA_Remision.Text = SELECTED.NOTA;
                if (SELECTED.RECIBIDO)
                {
                    txtESTADO_Remision.ForeColor = Color.Green;
                    txtESTADO_Remision.Text = "RECIBIDO";
                    txtRecibe_Remision.Text = SELECTED.RECIBE;
                    btnRECIBIR_REMISION.Enabled = false;
                }
                else
                {
                    txtESTADO_Remision.ForeColor = Color.Red;
                    txtESTADO_Remision.Text = "PENDIENTE";
                    txtRecibe_Remision.Text = HOME.Instance().USUARIO.NOMBRE;
                    btnRECIBIR_REMISION.Enabled = true;
                }
                tblInventario.DataSource = dbInventario.GET_ITEMS_TRASLADO(SELECTED);
                MessageBox.Show("TRASLADO DE " + SELECTED.TIPO_DOC.ToString().Replace('_', ' ') + " #" + SELECTED.DOCUMENTO + " CARGADO", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("REMISION DE ARTICULOS #" + txtNUMERO_Custodia.Text.Trim().ToUpper() + " NO EXISTE O NO TIENE COMO DESTINO A LA SUCURSAL ACTUAL", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void calcularTotalesRemision()
        {
            TOTAL_REMISION = (decimal)0.00;
            TOTAL_REMISION = tblInventario.Rows.Cast<DataGridViewRow>().Sum(x => Decimal.Parse(x.Cells["PRECIO"].FormattedValue.ToString(), System.Globalization.NumberStyles.Currency));
            lbTOTAL_REMISION.Text = TOTAL_REMISION.ToString("C2");
            lbARTICULOS_REMISION.Text = tblInventario.Rows.Count + " ARTICULOS";
        }

        private void tblInventario_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblInventario.DataSource != null)
            {
                calcularTotalesRemision();
            }
            else
            {
                TOTAL_REMISION = (decimal)0.00;
                lbTOTAL_REMISION.Text = TOTAL_REMISION.ToString("C2");
                lbARTICULOS_REMISION.Text = "0 ARTICULOS";
            }
        }

        private void RECIBIR_REMISION(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                DialogResult recibir = MessageBox.Show("AL MARCAR COMO RECIBIDO EL TRASLADO DE " + SELECTED.TIPO_DOC.ToString() + " #" + SELECTED.DOCUMENTO + " \nUSTED ESTA CONFIRMANDO QUE TODOS LOS ARTICULOS LISTADOS HAN LLEGADO A SU DESTINO SATISFACTORIAMENTE\nDesea continuar?", "RECEPCION DE ARTICULOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (recibir == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbInventario.RECIBIR_TRASLADO_PRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            SELECTED = dbInventario.findRecibirTrasladoByDocPRENDASAL(eTipoTraslado.MOV_INVENTARIO, eTipoDocTraslado.REMISION, txtNUMERO_Remision.Text.Trim().ToUpper(), HOME.Instance().SUCURSAL.COD_SUC);
                            cargarRemision();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }





    }
}
