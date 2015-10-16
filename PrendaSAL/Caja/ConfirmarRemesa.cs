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

namespace PrendaSAL.Caja
{
    using MODELO;
    using LOGICA;
    using DDB;

    public partial class ConfirmarRemesa : Form
    {

        private DBUsuario dbUser;
        private MovCashController dbRemesa;
        private DBSucursal dbSucursal;

        private MovCash SELECTED;
        private decimal TOTAL;
        private eOperacion ACCION;

        public ConfirmarRemesa()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbRemesa = new MovCashController();
            dbSucursal = new DBSucursal();
            ACCION = eOperacion.INSERT;
        }


        public ConfirmarRemesa(MovCash m)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbRemesa = new MovCashController();
            dbSucursal = new DBSucursal();
            ACCION = eOperacion.UPDATE;
            SELECTED = m;
        }

        private void ConfirmarRemesa_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            dateRemesa.Value = HOME.Instance().FECHA_SISTEMA;
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "CODIGO";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxTIPODOC.DataSource = Enum.GetValues(new eTipoDocMovCash().GetType());
            TOTAL = (decimal)0.00;
            txtTOTAL.Text = "0.00";
            lbENVIADO.Text = HOME.Instance().USUARIO.NOMBRE;
            DataTable sucAdm = HOME.Instance().datSUCURSALES;
            cbxDESTINO.DataSource = sucAdm;
            if (sucAdm.Rows.Count > 0)
            {
                cbxDESTINO.DisplayMember = "SUCURSAL";
                cbxDESTINO.ValueMember = "COD_SUC";
            }
            txtTOTAL.Focus();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    nextComprobanteRemesa();
                    break;
                case eOperacion.UPDATE:
                    cargarDatos();
                    break;
            }
        }




        private void nextComprobanteRemesa()
        {
            txtDOCUMENTO.Text = dbRemesa.NEXT_COMPROBANTE_REMESA((string)cbxSUCURSAL.SelectedValue);
        }

        private void cargarDatos()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.SUC_ORIGEN;
                dateRemesa.Value = SELECTED.FECHA;
                cbxTIPODOC.SelectedItem = SELECTED.TIPO_DOC;
                txtDOCUMENTO.Text = SELECTED.DOCUMENTO;
                TOTAL = SELECTED.TOTAL;
                txtTOTAL.Text = TOTAL.ToString();
                lbENVIADO.Text = SELECTED.RESPONSABLE_ENVIO;
                cbxDESTINO.SelectedValue = SELECTED.SUC_DESTINO;
                txtENTREGADO.Text = SELECTED.RESPONSABLE_RECIBE;
                txtNOTA.Text = SELECTED.NOTA;
            }
        }



        private bool validar()
        {
            bool OK = true;
            if (cbxSUCURSAL.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("ELIJA SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (cbxDESTINO.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("INDIQUE SUCURSAL DE DESTINO DE LA REMESA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (txtDOCUMENTO.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("NUMERO DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (txtENTREGADO.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("ESPECIFIQUE NOMBRE DEL PERSONAL QUE RETIRA LA REMESA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (TOTAL <= 0)
            {
                OK = false;
                MessageBox.Show("TOTAL DE REMESA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }


        private MovCash buildREMESA()
        {
            MovCash f = new MovCash();
            f.TIPO_MOV = eTipoMovCash.REMESA;
            f.SUC_ORIGEN = (string)cbxSUCURSAL.SelectedValue;
            f.FECHA = dateRemesa.Value;
            f.TIPO_DOC = (eTipoDocMovCash)cbxTIPODOC.SelectedItem;
            f.DOCUMENTO = txtDOCUMENTO.Text;
            f.TOTAL = TOTAL;
            f.SUC_DESTINO = (string)cbxDESTINO.SelectedValue;
            f.RESPONSABLE_ENVIO = lbENVIADO.Text;
            f.RESPONSABLE_RECIBE = txtENTREGADO.Text;
            f.NOTA = txtNOTA.Text;
            f.RECIBIDO = true;
            return f;
        }



        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MovCash remesa = new MovCash();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        remesa = buildREMESA();
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbRemesa.registrarMovCashPRENDASAL(remesa, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                RemesasForm.Instance().cargarHistoryRemesa();
                                RemesasForm.Instance().CargarRemesa(remesa.DOCUMENTO);
                                RemesasForm.Instance().ImprimirComprobanteRemesa();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;
                case eOperacion.UPDATE:
                    if (validar())
                    {
                        remesa = buildREMESA();
                        remesa.ID_MOV = SELECTED.ID_MOV;
                        remesa.ESTADO = SELECTED.ESTADO;
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                remesa.NOTA_CAMBIO = cambioNota;
                                if (dbRemesa.editarMovCashPRENDASAL(remesa, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    RemesasForm.Instance().cargarHistoryRemesa();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("INGRESE UNA NOTA ACLARATORIA DE LA MODIFICACION", "REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;
            }
        }




        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtTOTAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto
            if (e.KeyChar == 46 && txtTOTAL.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }
        }


        private void txtTOTAL_Leave(object sender, EventArgs e)
        {
            TOTAL = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtTOTAL.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                TOTAL = Decimal.Round(valor, 2);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTOTAL.Text = TOTAL.ToString();
        }


    }
}
