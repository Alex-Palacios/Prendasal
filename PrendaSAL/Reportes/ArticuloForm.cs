using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ControlesPersonalizados;

namespace PrendaSAL.Reportes
{
    using MODELO;
    using DDB;

    public partial class ArticuloForm : Form
    {

        private DBUsuario dbUser;
        private DBInventario dbInventario;
        private DBCatalogo dbCatalogo;
        private Existencia SELECTED;

        private eOperacion ACCION;

        public ArticuloForm(Existencia item)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
            ACCION = eOperacion.UPDATE;
            SELECTED = item;
        }



        private void ArticuloForm_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                DataRow R = ((DataTable)cbxSUCURSAL.DataSource).NewRow();
                R.SetField<string>("COD_SUC", "00");
                R.SetField<string>("SUCURSAL", "TODAS LAS SUCURSALES");
                R.SetField<bool>("ACTIVA", false);
                ((DataTable)cbxSUCURSAL.DataSource).Rows.InsertAt(R, 0);
            }
            cbxTIPO.DataSource = dbCatalogo.getTipoInv("ARTICULO");
            if (cbxTIPO.DataSource != null && ((DataTable)cbxTIPO.DataSource).Rows.Count > 0)
            {
                cbxTIPO.DisplayMember = "TIPO";
                cbxTIPO.ValueMember = "TIPO";
            }
            cbxMARCA.DataSource = dbCatalogo.getMarcaInv("ARTICULO");
            if (cbxMARCA.DataSource != null && ((DataTable)cbxMARCA.DataSource).Rows.Count > 0)
            {
                cbxMARCA.DisplayMember = "MARCA";
                cbxMARCA.ValueMember = "MARCA";
            }

            cargarItemSelected();
        }



        private void cargarItemSelected()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.BODEGA;
                txtCODIGO.Text = SELECTED.CODIGO;
                cbxTIPO.Text = SELECTED.TIPO;
                cbxMARCA.Text = SELECTED.MARCA;
                txtCANTIDAD.Text = SELECTED.CANTIDAD.ToString("N1");
                txtDESCRIPCION.Text = SELECTED.DESCRIPCION;
                txtPRECIO.Text = SELECTED.PRECIO.ToString("C2");
                txtNOTA.Text = SELECTED.NOTA;
            }
        }



        private void txtPRECIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto
            if (e.KeyChar == 46 && txtPRECIO.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            //Solo permite introducir numeros y el carater punto y tambien permite borrar digitos
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }



        private void txtPRECIO_Leave(object sender, EventArgs e)
        {
            SELECTED.PRECIO = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtPRECIO.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                SELECTED.PRECIO = Decimal.Round(valor, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtPRECIO.Text = SELECTED.PRECIO.ToString("C2");
        }




        private bool validarITEM()
        {
            bool OK = true;
            try
            {
                if (txtDESCRIPCION.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("DETALLE ARTICULO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (SELECTED.PRECIO < 0)
                {
                    OK = false;
                    MessageBox.Show("PRECIO VENTA ARTICULO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }

            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR ARTICULO", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }



        private void GUARDAR(object sender, EventArgs e)
        {
            if (validarITEM())
            {   
                string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                {
                    SELECTED.BODEGA = (string)cbxSUCURSAL.SelectedValue;
                    SELECTED.TIPO = (string)cbxTIPO.SelectedValue;
                    SELECTED.MARCA = cbxMARCA.Text.ToUpper().Trim();
                    SELECTED.DESCRIPCION = txtDESCRIPCION.Text.Trim();
                    SELECTED.NOTA = txtNOTA.Text.Trim();
                    if (dbInventario.updateArticuloInv(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                    {
                        RInvVentaForm.Instance().recargar();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
              

        }



        private void CANCELAR(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSCAN_Click(object sender, EventArgs e)
        {
            FotoArticuloForm foto = new FotoArticuloForm(SELECTED.CODIGO.ToString());
            foto.ShowDialog();
        }






    }
}
