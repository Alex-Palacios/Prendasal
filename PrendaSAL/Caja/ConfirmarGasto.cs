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

    public partial class ConfirmarGasto : Form
    {
        private DBUsuario dbUser;
        private GastoController dbGasto;

        private Gasto SELECTED;
        private decimal TOTAL;
        private eOperacion ACCION;


        public ConfirmarGasto()
        {
            InitializeComponent(); 
            dbUser = new DBUsuario();
            dbGasto = new GastoController();
            ACCION = eOperacion.INSERT;
        }


        public ConfirmarGasto(Gasto g)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbGasto = new GastoController();

            ACCION = eOperacion.UPDATE;
            SELECTED = g;
        }



        private void ConfirmarGasto_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            dateGasto.Value = HOME.Instance().FECHA_SISTEMA;
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "CODIGO";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxTIPODOC.DataSource = Enum.GetValues(new eTipoDocGasto().GetType());
            TOTAL = (decimal)0.00;
            txtTOTAL.Text = TOTAL.ToString();
            txtDOCUMENTO.Focus();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    break;
                case eOperacion.UPDATE:
                    cargarDatos();
                    break;
            }
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
                TOTAL = SELECTED.TOTAL;
                txtTOTAL.Text = TOTAL.ToString();
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
            else if (txtDOCUMENTO.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("NUMERO DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (txtDESCRIPCION.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("DESCRIBA EL GASTO REALIZADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            else if (TOTAL <= 0)
            {
                OK = false;
                MessageBox.Show("TOTAL DE GASTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }


        private Gasto buildGASTO()
        {
           Gasto g = new Gasto();
           switch (ACCION)
           {
               case eOperacion.INSERT:
                   if (cbxSUCURSAL.SelectedIndex >= 0)
                   {
                       g.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
                   }
                   g.FECHA = dateGasto.Value;
                   g.TIPO_DOC = (eTipoDocGasto)cbxTIPODOC.SelectedItem;
                   g.DOCUMENTO = txtDOCUMENTO.Text;
                   g.DESCRIPCION = txtDESCRIPCION.Text;
                   g.SUMAS = TOTAL;
                   g.TOTAL = TOTAL;
                   g.TOTAL_IMP = g.TOTAL;
                   break;
               case eOperacion.UPDATE:
                   g = SELECTED;
                   g.FECHA = dateGasto.Value;
                   g.TIPO_DOC = (eTipoDocGasto)cbxTIPODOC.SelectedItem;
                   g.DOCUMENTO = txtDOCUMENTO.Text;
                   g.DESCRIPCION = txtDESCRIPCION.Text;
                   g.SUMAS = TOTAL;
                   g.TOTAL = TOTAL;
                   g.TOTAL_IMP = g.TOTAL;
                   break;
           }
           return g;
        }



        private void GUARDAR_Click(object sender, EventArgs e)
        {
            Gasto gasto = new Gasto();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        gasto = buildGASTO();
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbGasto.registrarGastoPRENDASAL(gasto, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
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
                        gasto = buildGASTO();
                        gasto.ID_GASTO = SELECTED.ID_GASTO;
                        gasto.INIT_BALANCE = SELECTED.INIT_BALANCE;
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                gasto.NOTA_CAMBIO = cambioNota;
                                if (dbGasto.editarGastoPRENDASAL(gasto, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                {
                                    GastosForm.Instance().cargarHistoryGastos();
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
