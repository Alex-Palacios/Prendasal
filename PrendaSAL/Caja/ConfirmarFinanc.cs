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

    public partial class ConfirmarFinanc : Form
    {
        private DBUsuario dbUser;
        private MovCashController dbFinanc;
        private DBSucursal dbSucursal;

        private MovCash SELECTED;
        private decimal TOTAL;
        private eOperacion ACCION;

        public ConfirmarFinanc()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbFinanc = new MovCashController();
            dbSucursal = new DBSucursal();
            ACCION = eOperacion.INSERT;
            
        }





        public ConfirmarFinanc(MovCash m)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbFinanc = new MovCashController();
            dbSucursal = new DBSucursal();
            ACCION = eOperacion.UPDATE;
            SELECTED = m;
        }


        private void ConfirmarFinanc_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            dateFinanc.Value = HOME.Instance().FECHA_SISTEMA;
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "CODIGO";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxTIPODOC.DataSource = Enum.GetValues(new eTipoDocMovCash().GetType());
            TOTAL = (decimal)0.00;
            txtTOTAL.Text = TOTAL.ToString();
            lbRECIBIDO.Text = HOME.Instance().USUARIO.NOMBRE;
            DataTable sucAdm = HOME.Instance().datSUCURSALES;
            cbxORIGEN.DataSource = sucAdm;
            if (sucAdm.Rows.Count > 0)
            {
                cbxORIGEN.DisplayMember = "SUCURSAL";
                cbxORIGEN.ValueMember = "COD_SUC";
            }
            txtTOTAL.Focus();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    nextComprobanteFinanc();
                    break;
                case eOperacion.UPDATE:
                    cargarDatos();
                    break;
            }
        }




        private void nextComprobanteFinanc()
        {
            txtDOCUMENTO.Text = dbFinanc.NEXT_COMPROBANTE_FINANC((string)cbxSUCURSAL.SelectedValue);
        }

        private void cargarDatos()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.SUC_ORIGEN;
                dateFinanc.Value = SELECTED.FECHA;
                cbxTIPODOC.SelectedItem = SELECTED.TIPO_DOC;
                txtDOCUMENTO.Text = SELECTED.DOCUMENTO;
                TOTAL = SELECTED.TOTAL;
                txtTOTAL.Text = TOTAL.ToString();
                lbRECIBIDO.Text = SELECTED.RESPONSABLE_ENVIO;
                cbxORIGEN.SelectedValue = SELECTED.SUC_DESTINO;
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
            else if (cbxORIGEN.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("INDIQUE SUCURSAL DE PROCEDENCIA DEL FINANCIAMIENTO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("ESPECIFIQUE NOMBRE DEL PERSONAL QUE ENTREGA EL FINANCIAMIENTO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (TOTAL <= 0)
            {
                OK = false;
                MessageBox.Show("TOTAL DE FINANCIAMIENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }


        private MovCash buildFINANC()
        {
            MovCash f = new MovCash();
            f.TIPO_MOV = eTipoMovCash.FINANCIAMIENTO;
            f.SUC_DESTINO = (string)cbxSUCURSAL.SelectedValue;
            f.FECHA = dateFinanc.Value;
            f.TIPO_DOC = (eTipoDocMovCash)cbxTIPODOC.SelectedItem;
            f.DOCUMENTO = txtDOCUMENTO.Text;
            f.TOTAL = TOTAL;
            f.SUC_ORIGEN = (string)cbxORIGEN.SelectedValue;
            f.RESPONSABLE_ENVIO = txtENTREGADO.Text;
            f.RESPONSABLE_RECIBE = lbRECIBIDO.Text;
            f.NOTA = txtNOTA.Text;
            f.RECIBIDO = true;
            return f;
        }



        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MovCash financ = new MovCash();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        financ = buildFINANC();
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbFinanc.registrarMovCashPRENDASAL(financ, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                FinancForm.Instance().cargarHistoryFinanc();
                                FinancForm.Instance().CargarFinanc(financ.DOCUMENTO);
                                //FinancForm.Instance().ImprimirComprobanteFinanc();
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
                        financ = buildFINANC();
                        financ.ID_MOV = SELECTED.ID_MOV;
                        financ.ESTADO = SELECTED.ESTADO;
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                financ.NOTA_CAMBIO = cambioNota;
                                if (dbFinanc.editarMovCashPRENDASAL(financ, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    FinancForm.Instance().cargarHistoryFinanc();
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
