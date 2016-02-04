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
    using DDB;

    public partial class ConfirmarGasto : Form
    {
        private DBUsuario dbUser;
        private DBGasto dbGasto;

        private Gasto SELECTED;

        private eOperacion ACCION;


        public ConfirmarGasto()
        {
            InitializeComponent(); 
            dbUser = new DBUsuario();
            dbGasto = new DBGasto();
            ACCION = eOperacion.INSERT;
            SELECTED = new Gasto();
            SELECTED.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            SELECTED.FECHA = HOME.Instance().FECHA_SISTEMA;
            SELECTED.TIPO_DOC = eTipoFactura.CCF;
        }


        public ConfirmarGasto(Gasto g)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbGasto = new DBGasto();
            ACCION = eOperacion.UPDATE;
            SELECTED = g.Copy();
        }

        private void permisos()
        {
            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.Enabled = true;
            }
        }



        private void ConfirmarGasto_Load(object sender, EventArgs e)
        {
            permisos();
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            eOperacion op = ACCION;
            ACCION = eOperacion.PREVIEW;
            cbxTIPODOC.DataSource = Enum.GetValues(new eTipoFactura().GetType());
            txtDOCUMENTO.Focus();
            cargarDatos();
            ACCION = op;
        }




        private void cargarDatos()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.COD_SUC;
                dateGasto.Value = SELECTED.FECHA;
                cbxTIPODOC.SelectedItem = SELECTED.TIPO_DOC;
                txtDOCUMENTO.Text = SELECTED.DOCUMENTO;
                txtDESCRIPCION.Text = SELECTED.DESCRIPCION;
                txtSUBTOTAL.Text = SELECTED.SUBTOTAL.ToString("C2");
                txtIVA.Text = SELECTED.IVA.ToString("C2"); 
                lbTOTAL.Text = SELECTED.TOTAL.ToString("C2");
                txtNOTA.Text = SELECTED.NOTA;
            }
        }



        private void cbxTIPODOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTIPODOC.SelectedIndex >= 0 && ACCION != eOperacion.PREVIEW)
            {
                SELECTED.TIPO_DOC = (eTipoFactura)cbxTIPODOC.SelectedItem;
                SELECTED.IVA = (decimal)0.00;
                SELECTED.calcularTotales();
                switch (SELECTED.TIPO_DOC)
                {
                    case eTipoFactura.CCF:
                        txtIVA.ReadOnly = false;
                        break;
                    default:
                        txtIVA.ReadOnly = true;
                        break;
                }
                txtSUBTOTAL.Text = SELECTED.SUBTOTAL.ToString("C2");
                txtIVA.Text = SELECTED.IVA.ToString("C2");
                lbTOTAL.Text = SELECTED.TOTAL.ToString("C2");
            }
        }



        private void txtSUBTOTAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un $
            if (e.KeyChar == 36 && txtSUBTOTAL.Text.IndexOf('$') != -1)
            {
                e.Handled = true;
                return;
            }
            //Impide introducir mas de un punto
            if (e.KeyChar == 46 && txtSUBTOTAL.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos y el signo de dolar
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 36 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }
        }



        private void txtSUBTOTAL_Leave(object sender, EventArgs e)
        {
            SELECTED.SUBTOTAL = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtSUBTOTAL.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                SELECTED.SUBTOTAL = Decimal.Round(valor, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SELECTED.calcularTotales();
            txtSUBTOTAL.Text = SELECTED.SUBTOTAL.ToString("C2");
            txtIVA.Text = SELECTED.IVA.ToString("C2");
            lbTOTAL.Text = SELECTED.TOTAL.ToString("C2");
        }



        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un $
            if (e.KeyChar == 36 && txtIVA.Text.IndexOf('$') != -1)
            {
                e.Handled = true;
                return;
            }
            //Impide introducir mas de un punto
            if (e.KeyChar == 46 && txtIVA.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos y el signo de dolar
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 36 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }
        }




        private void txtIVA_Leave(object sender, EventArgs e)
        {
            SELECTED.IVA = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtIVA.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                SELECTED.IVA = Decimal.Round(valor, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SELECTED.calcularTotales();
            txtSUBTOTAL.Text = SELECTED.SUBTOTAL.ToString("C2");
            txtIVA.Text = SELECTED.IVA.ToString("C2");
            lbTOTAL.Text = SELECTED.TOTAL.ToString("C2");
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
            else if (SELECTED.DOCUMENTO.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("NUMERO DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.DESCRIPCION.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("DESCRIBA EL GASTO REALIZADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.SUBTOTAL <= 0)
            {
                OK = false;
                MessageBox.Show("SUBTOTAL DE GASTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.IVA <= 0 && SELECTED.TIPO_DOC == eTipoFactura.CCF)
            {
                OK = false;
                MessageBox.Show("IVA DE GASTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.IVA > 0 && SELECTED.TIPO_DOC != eTipoFactura.CCF)
            {
                OK = false;
                MessageBox.Show("IVA INVALIDO VERIFIQUE TIPO DE FACTURA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }







        private void GUARDAR_Click(object sender, EventArgs e)
        {
            SELECTED.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
            SELECTED.TIPO_DOC = (eTipoFactura)cbxTIPODOC.SelectedItem;
            SELECTED.DOCUMENTO = txtDOCUMENTO.Text;
            SELECTED.FECHA = dateGasto.Value;
            SELECTED.DESCRIPCION = txtDESCRIPCION.Text;
            SELECTED.NOTA = txtNOTA.Text;
            
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbGasto.insert(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                GastosForm.Instance().cargarHistoryGastos();
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
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbGasto.update(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                GastosForm.Instance().cargarHistoryGastos();
                                this.Close();
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





        


        







    }
}
