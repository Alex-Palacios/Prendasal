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

    public partial class ConfirmarRemesa : Form
    {

        private DBUsuario dbUser;
        private DBMovCash dbRemesa;

        private MovCash SELECTED;
        private eOperacion ACCION;

        public ConfirmarRemesa()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbRemesa = new DBMovCash();
            ACCION = eOperacion.INSERT;
            SELECTED = new MovCash();
            SELECTED.SUC_ENVIA = HOME.Instance().SUCURSAL.COD_SUC;
            SELECTED.FECHA = HOME.Instance().FECHA_SISTEMA;
            SELECTED.DOCUMENTO = dbRemesa.nextComprobanteMovCash(HOME.Instance().SUCURSAL.COD_SUC);
            SELECTED.SUC_DEST = "01";
            SELECTED.RESPONSABLE = HOME.Instance().USUARIO.NOMBRE;
        }


        public ConfirmarRemesa(MovCash m)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbRemesa = new DBMovCash();
            ACCION = eOperacion.UPDATE;
            SELECTED = m.Copy();
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


        private void ConfirmarRemesa_Load(object sender, EventArgs e)
        {
            permisos();
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxDESTINO.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO.DisplayMember = "SUCURSAL";
                cbxDESTINO.ValueMember = "COD_SUC";
                cbxDESTINO.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            txtTOTAL.Focus();
            cargarDatos();
        }


        private void cargarDatos()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.SUC_ENVIA;
                dateRemesa.Value = SELECTED.FECHA;
                txtDOCUMENTO.Text = SELECTED.DOCUMENTO;
                txtTOTAL.Text = SELECTED.TOTAL.ToString("C2");
                lbRESPONSABLE.Text = SELECTED.RESPONSABLE;
                cbxDESTINO.SelectedValue = SELECTED.SUC_DEST;
                txtTRASLADA.Text = SELECTED.TRASLADA;
                txtNOTA.Text = SELECTED.NOTA;
            }
        }



        private bool validar()
        {
            bool OK = true;
            if (cbxSUCURSAL.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL QUE ENVIA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (cbxDESTINO.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL DE DESTINO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.SUC_ENVIA == SELECTED.SUC_DEST)
            {
                OK = false;
                MessageBox.Show("SUCURSAL QUE ENVIA Y DE DESTINO DEBEN SER DISTINTOS", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.DOCUMENTO.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("NUMERO DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.TRASLADA.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("ESPECIFIQUE PERSONA RESPONSABLE DEL TRASLADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (SELECTED.TOTAL <= 0)
            {
                OK = false;
                MessageBox.Show("TOTAL DE REMESA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }




        private void GUARDAR_Click(object sender, EventArgs e)
        {
            SELECTED.SUC_ENVIA = (string)cbxSUCURSAL.SelectedValue;
            SELECTED.FECHA = dateRemesa.Value;
            SELECTED.SUC_DEST = (string)cbxDESTINO.SelectedValue;
            SELECTED.TRASLADA = txtTRASLADA.Text;
            SELECTED.NOTA = txtNOTA.Text;
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbRemesa.insert(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                this.Close();
                                RemesasForm.Instance().IMPRIMIR(SELECTED);
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
                            if (dbRemesa.update(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                RemesasForm.Instance().cargarHistoryRemesa();
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
