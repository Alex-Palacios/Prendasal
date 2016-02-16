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
    using MODELO;
    using DDB;

    public partial class RecibirTrasladoForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RecibirTrasladoForm frmInstance = null;

        public static RecibirTrasladoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RecibirTrasladoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBTraslado dbTraslado;
        private Traslado SELECTED;
        private Traslado TRASLADO;



        public RecibirTrasladoForm()
        {
            InitializeComponent();
            dbTraslado = new DBTraslado();
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

            tblCUSTODIA_PRESTAMOS.AutoGenerateColumns = false;
            tblCUSTODIA_COMPRAS.AutoGenerateColumns = false;
            tblREMISION.AutoGenerateColumns = false;

            cbxENVIA_RM.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxENVIA_RM.DisplayMember = "SUCURSAL";
                cbxENVIA_RM.ValueMember = "COD_SUC";
                cbxENVIA_RM.SelectedIndex = 0;
            }

            cbxDESTINO_RM.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO_RM.DisplayMember = "SUCURSAL";
                cbxDESTINO_RM.ValueMember = "COD_SUC";
                cbxDESTINO_RM.SelectedIndex = 0;
            }

            cbxENVIA_CV.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxENVIA_CV.DisplayMember = "SUCURSAL";
                cbxENVIA_CV.ValueMember = "COD_SUC";
                cbxENVIA_CV.SelectedIndex = 0;
            }

            cbxDESTINO_CV.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO_CV.DisplayMember = "SUCURSAL";
                cbxDESTINO_CV.ValueMember = "COD_SUC";
                cbxDESTINO_CV.SelectedIndex = 0;
            }
            tabDETALLE.SelectedIndex = -1;
            tabDETALLE.SelectedIndex = 0;

        }


        private void tabDETALLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDETALLE.SelectedIndex >= 0)
            {
                switch (tabDETALLE.SelectedTab.Name)
                {
                    case "pagREMISION":
                        limpiarDatosTrasladoRM();
                        bloquearRM();
                        break;

                    case "pagCUSTODIA":
                        limpiarDatosTrasladoCV();
                        bloquearCV();
                        break;
                }
            }
        }


        public bool buscarTraslado(eTipoTraslado tipo, string doc)
        {
            bool OK = false;
            SELECTED = Traslado.ConvertToTraslado(dbTraslado.getTrasladoByDocTipoSucDEST(tipo, doc,HOME.Instance().SUCURSAL.COD_SUC));
            if (SELECTED != null)
            {
                switch (SELECTED.TIPO)
                {
                    case eTipoTraslado.NOTA_REMISION:
                        SELECTED.DETALLE_TRASLADO = dbTraslado.getItemsTraslado(SELECTED);
                        TRASLADO = SELECTED.Copy();
                        cargarDatosTrasladoRM();
                        OK = true;

                        break;

                    case eTipoTraslado.CUSTODIA_VALORES:
                        SELECTED.DETALLE_TRASLADO = dbTraslado.getItemsTraslado(SELECTED);
                        TRASLADO = SELECTED.Copy();
                        cargarDatosTrasladoCV();
                        OK = true;

                        break;

                }
            }
            else
            {
                OK = false;
            }
            return OK;
        }


        //NOTA DE REMISION
        private void bloquearRM()
        {
            ckALLRM.Enabled = false;
            tblREMISION.Columns["OK_RM"].ReadOnly = true;
            txtNOTA_RM.ReadOnly = true;
            btnRECIBIR_REMISION.Enabled = false;
        }


        private void desbloquearRM()
        {
            ckALLRM.Enabled = true;
            tblREMISION.Columns["OK_RM"].ReadOnly = false;
            txtNOTA_RM.ReadOnly = false;
            btnRECIBIR_REMISION.Enabled = true;
        }



        private void limpiarDatosTrasladoRM()
        {
            dateEnvio_RM.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO_RM.Text = string.Empty;
            txtASESOR_RM.Text = string.Empty;
            txtTRASLADA_RM.Text = string.Empty;
            txtRECIBE_RM.Text = string.Empty;
            txtNOTA_RM.Text = string.Empty;
            txtTOTAL_RM.Text = string.Empty;

            ckALLRM.Checked = false;
        }



        private void txtDOCUMENTO_RM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtDOCUMENTO_RM.Text.Trim() != string.Empty)
            {
                if (buscarTraslado(eTipoTraslado.NOTA_REMISION,txtDOCUMENTO_RM.Text.Trim()))
                {
                    MessageBox.Show("NOTA DE REMISION # " + SELECTED.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NOTA DE REMISION NO ENCONTRADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtDOCUMENTO_RM.SelectAll();
                e.Handled = true;
            }
        }


       
        private void cargarDatosTrasladoRM()
        {
            limpiarDatosTrasladoRM();
            if (TRASLADO != null)
            {
                cbxENVIA_RM.SelectedValue = TRASLADO.SUC_ENVIA;
                cbxDESTINO_RM.SelectedValue = TRASLADO.SUC_DEST;
                txtDOCUMENTO_RM.Text = TRASLADO.DOCUMENTO;
                dateEnvio_RM.Value = TRASLADO.FECHA;
                txtASESOR_RM.Text = TRASLADO.ENVIA;
                txtTRASLADA_RM.Text = TRASLADO.TRASLADA;
                txtRECIBE_RM.Text = TRASLADO.RECIBE;
                txtNOTA_RM.Text = TRASLADO.NOTA;
                lbESTADO_RM.Text = TRASLADO.ESTADO_TRASLADO.ToString();

                switch (TRASLADO.ESTADO_TRASLADO)
                {
                    case eEstadoTraslado.RECIBIDO:
                        lbESTADO_RM.ForeColor = Color.Blue;
                        bloquearRM();
                        break;
                    case eEstadoTraslado.PENDIENTE:
                        lbESTADO_RM.ForeColor = Color.Crimson;
                        desbloquearRM();
                        break;
                }

                tblREMISION.DataSource = TRASLADO.DETALLE_TRASLADO;
                calcularTotalesRM();

            }
        }




        public void calcularTotalesRM()
        {
            decimal total = TRASLADO.DETALLE_TRASLADO.AsEnumerable().Select(r => r.Field<decimal>("PRECIO")).Sum();
            txtTOTAL_RM.Text = total.ToString("C2");
        }


        


        private void ckALLRM_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblREMISION.Rows)
            {
                row.Cells["OK_RM"].Value = ckALLRM.Checked;
            }
        }



        private void btnRECIBIR_REMISION_Click(object sender, EventArgs e)
        {
            if (TRASLADO != null)
            {
                TRASLADO.NOTA = txtNOTA_RM.Text.Trim();
                TRASLADO.RECIBE = HOME.Instance().USUARIO.NOMBRE;
                foreach (DataGridViewRow row in tblREMISION.Rows)
                {
                    recibirItemTrasladoOK(row.Cells["CODIGO"].FormattedValue.ToString(), (bool)row.Cells["OK_RM"].FormattedValue);
                }
                string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                {
                    if (dbTraslado.recibir(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                    {
                        buscarTraslado(TRASLADO.TIPO, TRASLADO.DOCUMENTO);
                    }
                }
                else
                {
                    MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("CARGUE TRASLADO A RECIBIR", "ERROE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        //CUSTODIA DE VALORES
        private void bloquearCV()
        {
            ckALLCVP.Enabled = false;
            ckALLCVC.Enabled = false;
            tblCUSTODIA_PRESTAMOS.Columns["OK_CVP"].ReadOnly = true;
            tblCUSTODIA_COMPRAS.Columns["OK_CVC"].ReadOnly = true;
            txtNOTA_CV.ReadOnly = true;
            btnRECIBIR_CUSTODIA.Enabled = false;
        }


        private void desbloquearCV()
        {
            ckALLCVP.Enabled = true;
            ckALLCVC.Enabled = true;
            tblCUSTODIA_PRESTAMOS.Columns["OK_CVP"].ReadOnly = false;
            tblCUSTODIA_COMPRAS.Columns["OK_CVC"].ReadOnly = false;
            txtNOTA_CV.ReadOnly = false;
            btnRECIBIR_CUSTODIA.Enabled = true;
        }



        private void limpiarDatosTrasladoCV()
        {
            dateEnvio_CV.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO_CV.Text = string.Empty;
            txtASESOR_CV.Text = string.Empty;
            txtTRASLADA_CV.Text = string.Empty;
            txtRECIBE_CV.Text = string.Empty;
            txtNOTA_CV.Text = string.Empty;

            ckALLCVP.Checked = false;
            ckALLCVC.Checked = false;
        }



        private void txtDOCUMENTO_CV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtDOCUMENTO_CV.Text.Trim() != string.Empty)
            {
                if (buscarTraslado(eTipoTraslado.CUSTODIA_VALORES, txtDOCUMENTO_CV.Text.Trim()))
                {
                    MessageBox.Show("CUSTODIA DE VALORES # " + SELECTED.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CUSTODIA DE VALORES NO ENCONTRADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtDOCUMENTO_CV.SelectAll();
                e.Handled = true;
            }
        }



        private void cargarDatosTrasladoCV()
        {
            limpiarDatosTrasladoCV();
            if (TRASLADO != null)
            {
                cbxENVIA_CV.SelectedValue = TRASLADO.SUC_ENVIA;
                cbxDESTINO_CV.SelectedValue = TRASLADO.SUC_DEST;
                txtDOCUMENTO_CV.Text = TRASLADO.DOCUMENTO;
                dateEnvio_CV.Value = TRASLADO.FECHA;
                txtASESOR_CV.Text = TRASLADO.ENVIA;
                txtTRASLADA_CV.Text = TRASLADO.TRASLADA;
                txtRECIBE_CV.Text = TRASLADO.RECIBE;
                txtNOTA_CV.Text = TRASLADO.NOTA;
                lbESTADO_CV.Text = TRASLADO.ESTADO_TRASLADO.ToString();

                switch (TRASLADO.ESTADO_TRASLADO)
                {
                    case eEstadoTraslado.RECIBIDO:
                        lbESTADO_CV.ForeColor = Color.Blue;
                        bloquearCV();
                        break;
                    case eEstadoTraslado.PENDIENTE:
                        lbESTADO_CV.ForeColor = Color.Crimson;
                        desbloquearCV();
                        break;
                }

                tblCUSTODIA_PRESTAMOS.DataSource = TRASLADO.CUSTODIA_PRESTAMOS;
                tblCUSTODIA_COMPRAS.DataSource = TRASLADO.CUSTODIA_COMPRAS;

            }
        }




        private void ckALLCVP_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
            {
                if (row.Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString() == "ORO")
                {
                    row.Cells["OK_CVP"].Value = ckALLCVP.Checked;
                }
            }
        }



        private void ckALLCVC_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
            {
                if (row.Cells["CATEGORIA_COMPRA"].FormattedValue.ToString() == "ORO")
                {
                    row.Cells["OK_CVC"].Value = ckALLCVC.Checked;
                }
            }
        }



        private void btnRECIBIR_CUSTODIA_Click(object sender, EventArgs e)
        {
            if (TRASLADO != null)
            {
                TRASLADO.NOTA = txtNOTA_CV.Text.Trim();
                TRASLADO.RECIBE = HOME.Instance().USUARIO.NOMBRE;
                foreach (DataGridViewRow row in tblCUSTODIA_PRESTAMOS.Rows)
                {
                    recibirItemTrasladoOK(row.Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), (bool)row.Cells["OK_CVP"].FormattedValue);
                }
                foreach (DataGridViewRow row in tblCUSTODIA_COMPRAS.Rows)
                {
                    recibirItemTrasladoOK(row.Cells["CODIGO_COMPRA"].FormattedValue.ToString(), (bool)row.Cells["OK_CVC"].FormattedValue);
                }
                string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                {
                    if (dbTraslado.recibir(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                    {
                        buscarTraslado(TRASLADO.TIPO, TRASLADO.DOCUMENTO);
                    }
                }
                else
                {
                    MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("CARGUE TRASLADO A RECIBIR", "ERROE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void recibirItemTrasladoOK(string codigo,bool ok)
        {
            foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
            {
                if (row.Field<string>("CODIGO") == codigo)
                {
                   row.SetField<bool>("RECIBIDO", ok);
                }
            }
        }


    }
}
