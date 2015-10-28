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

            cbxTIPODOC.DataSource = Enum.GetValues(new eTipoFactura().GetType());
            txtDOCUMENTO.Focus();
            cargarDatos();
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
                txtTOTAL.Text = SELECTED.TOTAL.ToString("C2");
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
            else if (SELECTED.TOTAL <= 0)
            {
                OK = false;
                MessageBox.Show("TOTAL DE GASTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            switch (SELECTED.TIPO_DOC)
            {
                case eTipoFactura.CCF:
                    SELECTED.IVA = Decimal.Round(SELECTED.TOTAL * Properties.Settings.Default.IVA / 100, 2,MidpointRounding.AwayFromZero);
                    break;
                case eTipoFactura.FCF:
                    SELECTED.IVA = 0;
                    break;
            }
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
            SELECTED.TOTAL = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtTOTAL.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                SELECTED.TOTAL = Decimal.Round(valor, 2,MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTOTAL.Text = SELECTED.TOTAL.ToString("C2");
        }


        







    }
}
