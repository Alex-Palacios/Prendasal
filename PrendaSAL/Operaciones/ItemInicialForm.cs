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

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;

    public partial class ItemInicialForm : Office2007Form
    {

        //VARIABLES
        private DBUsuario dbUser;
        private DBInventario dbInventario;
        private DBCatalogo dbCatalogo;
        private InvInicial SELECTED;

        private DataTable ITEMS;
        private eOperacion ACCION;


        public ItemInicialForm()
        {
            InitializeComponent();
            ACCION = eOperacion.INSERT;
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
        }


        public ItemInicialForm(InvInicial item)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
            ACCION = eOperacion.UPDATE;
            SELECTED = item.Copy();
            
        }


        private void ItemInv_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    NUEVO();
                    break;
                case eOperacion.UPDATE:
                    cargarItemSelected();
                    break;
            }
        }

        private void NUEVO()
        {
            limpiar();
            SELECTED = new InvInicial();
            SELECTED.CATEGORIA = eCategoria.ARTICULO;
            SELECTED.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            SELECTED.CANTIDAD = 1;
            cargarItemSelected();
        }

        private void limpiar()
        {
            txtCODIGO.Text = "";
            txtCANTIDAD.Text = "0.00";
            txtDESCRIPCION.Text = "";
            txtCOSTO.Text = "0.00";
            txtPRECIO.Text = "0.00";
        }



        private void cargarItemSelected()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.COD_SUC;
                cbxITEM.DataSource = dbCatalogo.showCatalogo(SELECTED.CATEGORIA);
                if (cbxITEM.DataSource != null)
                {
                    cbxITEM.DisplayMember = "COD_ITEM";
                    cbxITEM.ValueMember = "COD_ITEM";
                }
                txtCATEGORIA.Text = SELECTED.CATEGORIA.ToString();
                cbxITEM.Text = SELECTED.COD_ITEM;
                txtCODIGO.Text = SELECTED.CODIGO;
                txtCANTIDAD.Text = SELECTED.CANTIDAD.ToString("N2");
                txtDESCRIPCION.Text = SELECTED.DESCRIPCION;
                txtCOSTO.Text = SELECTED.COSTO.ToString("N2");
                txtPRECIO.Text = SELECTED.PRECIO.ToString("N2");
                txtNOTA.Text = SELECTED.NOTA;
            }
        }




        private void txtCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto
            if (e.KeyChar == 46 && txtCANTIDAD.Text.IndexOf('.') != -1)
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



        private void txtCANTIDAD_Leave(object sender, EventArgs e)
        {
            SELECTED.CANTIDAD = (decimal)0.0;
            decimal valor;
            if (Decimal.TryParse(txtCANTIDAD.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                SELECTED.CANTIDAD = Decimal.Round(valor, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtCANTIDAD.Text = SELECTED.CANTIDAD.ToString("N1");
        }





        private void txtCOSTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto
            if (e.KeyChar == 46 && txtCOSTO.Text.IndexOf('.') != -1)
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

        private void txtCOSTO_Leave(object sender, EventArgs e)
        {
            SELECTED.COSTO = (decimal)0.00;
            decimal valor;
            if (Decimal.TryParse(txtCOSTO.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                SELECTED.COSTO = Decimal.Round(valor, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                MessageBox.Show("FORMATO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtCOSTO.Text = SELECTED.COSTO.ToString("C2");
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
                if (txtCODIGO.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Ingrese el CODIGO del Articulo", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (cbxSUCURSAL.SelectedIndex < 0)
                {
                    OK = false;
                    MessageBox.Show("ELIJA UBICACION ACTUAL DEL ARTICULO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (cbxITEM.SelectedIndex < 0)
                {
                    OK = false;
                    MessageBox.Show("SELECCIONE EL ARTICULO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if(SELECTED.CANTIDAD <= 0)
                {
                    OK = false;
                    MessageBox.Show("CANTIDAD/PESO INVALIDA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (txtDESCRIPCION.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("DETALLE ARTICULO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (SELECTED.COSTO < 0)
                {
                    OK = false;
                    MessageBox.Show("COSTO ARTICULO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string autorizacion;
            SELECTED.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
            SELECTED.CODIGO = txtCODIGO.Text.Trim();
            SELECTED.COD_ITEM = (string)cbxITEM.SelectedValue;
            SELECTED.DESCRIPCION = txtDESCRIPCION.Text.Trim();
            SELECTED.NOTA = txtNOTA.Text.Trim();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarITEM())
                    {
                        autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbInventario.insertInit(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                CorteInvInicialForm.Instance().cargarInventarioInicial();
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
                   autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbInventario.updateInit(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            CorteInvInicialForm.Instance().cargarInventarioInicial();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                   
                   
                    break;

            }

        }



        private void CANCELAR(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
