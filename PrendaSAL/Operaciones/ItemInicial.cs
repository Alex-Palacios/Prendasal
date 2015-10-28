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

    public partial class ItemInicial : Office2007Form
    {

        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private DBInventario dbInventario;
        private DBCatalogo dbCatalogo;
        private Inventario SELECTED;

        private DataTable ITEMS;
        private eOperacion ACCION;


        public ItemInicial()
        {
            InitializeComponent();
            ACCION = eOperacion.INSERT;
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
        }


        public ItemInicial(Inventario item)
        {
            InitializeComponent();
            ACCION = eOperacion.UPDATE;
            dbPrendasal = new DBPRENDASAL();
            SELECTED = item;
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
            
        }


        private void ItemInv_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "CODIGO";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            cbxCATEGORIA.DataSource = Enum.GetValues(new eCategoria().GetType());
            

            switch (ACCION)
            {
                case eOperacion.INSERT:
                    limpiar();
                    break;
                case eOperacion.UPDATE:
                    cargarItemSelected();
                    break;
            }
        }


        private void limpiar()
        {
            txtCODIGO.Text = "";
            txtCANTIDAD.Text = "0.00";
            txtDESCRIPCION.Text = "";
            txtCOSTO.Text = "0.00";
            txtPRECIO.Text = "0.00";
        }



        private void cbxCATEGORIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCATEGORIA.SelectedIndex >= 0)
            {
                ITEMS = dbCatalogo.showCatalogo((eCategoria) cbxCATEGORIA.SelectedItem);
                cbxITEM.DataSource = ITEMS;
                if (ITEMS.Rows.Count > 0)
                {
                    cbxITEM.DisplayMember = "COD_ITEM";
                    cbxITEM.ValueMember = "COD_ITEM";
                }
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






        private void CANCELAR(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cargarItemSelected()
        {
            if (SELECTED != null)
            {
                cbxCATEGORIA.Text = SELECTED.CATEGORIA;
                cbxITEM.Text = SELECTED.ARTICULO;
                cbxSUCURSAL.SelectedValue = SELECTED.COD_SUC;
                txtCODIGO.Text = SELECTED.CODIGO;
                txtCANTIDAD.Text = SELECTED.CANTIDAD.ToString("N2");
                txtDESCRIPCION.Text = SELECTED.DESCRIPCION;
                txtCOSTO.Text = SELECTED.COSTO.ToString("N2");
                txtPRECIO.Text = SELECTED.PRECIO.ToString("N2");
            }
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
                else if (cbxCATEGORIA.SelectedIndex < 0)
                {
                    OK = false;
                    MessageBox.Show("ESCOJA CATEGORIA DEL ARTICULO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (cbxITEM.SelectedIndex < 0)
                {
                    OK = false;
                    MessageBox.Show("SELECCIONE EL ARTICULO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if( txtCANTIDAD.Text.Trim() == string.Empty || Double.Parse(txtCANTIDAD.Text) <= 0)
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
                else if (txtCOSTO.Text.Trim() == string.Empty || Double.Parse(txtCOSTO.Text) < 0)
                {
                    OK = false;
                    MessageBox.Show("COSTO ARTICULO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (txtPRECIO.Text.Trim() == string.Empty || Double.Parse(txtPRECIO.Text) < 0)
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


        private Inventario buildITEM()
        {
            Inventario i = new Inventario();
            i.FECHA = HOME.Instance().FECHA_SISTEMA;
            i.CODIGO = txtCODIGO.Text.Trim();
            i.ARTICULO = (string)cbxITEM.SelectedValue;
            i.CANTIDAD = Double.Parse(txtCANTIDAD.Text.Trim());
            i.DESCRIPCION = txtDESCRIPCION.Text;
            i.COSTO = Decimal.Parse(txtCOSTO.Text.Trim());
            i.PRECIO = Decimal.Parse(txtPRECIO.Text.Trim());
            i.COD_SUC = (string) cbxSUCURSAL.SelectedValue;
            return i;
        }



        private void GUARDAR(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            string autorizacion;
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarITEM())
                    {
                        i = buildITEM();
                        autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            //if (dbInventario.insertInvInicialPRENDASAL(i, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            //{
                            //    CorteInvInicialForm.Instance().cargarInventarioInicial();
                            //    this.Close();
                            //}
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;
                case eOperacion.UPDATE:

                    i = buildITEM();
                    i.ID_MOV = SELECTED.ID_MOV;
                    i.INIT_BALANCE = SELECTED.INIT_BALANCE;
                    i.DISPONIBLE = SELECTED.DISPONIBLE;
                   autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        //if (dbInventario.updateInvInicialPRENDASAL(i, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        //{
                        //    CorteInvInicialForm.Instance().cargarInventarioInicial();
                        //    this.Close();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                   
                   
                    break;

            }

        }






    }
}
