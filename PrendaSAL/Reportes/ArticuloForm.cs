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
        private Inventario SELECTED;

        private eOperacion ACCION;

        public ArticuloForm(Inventario item)
        {
            InitializeComponent();
            ACCION = eOperacion.UPDATE;
            SELECTED = item;
            dbUser = new DBUsuario();
            dbInventario = new DBInventario();
        }



        private void ArticuloForm_Load(object sender, EventArgs e)
        {
            cargarItemSelected();
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


        private void cargarItemSelected()
        {
            if (SELECTED != null)
            {
                txtCATEGORIA.Text = SELECTED.CATEGORIA;
                txtARTICULO.Text = SELECTED.ARTICULO;
                txtUBICACION.Text = SELECTED.UBICACION;
                txtCODIGO.Text = SELECTED.CODIGO;
                txtCANTIDAD.Text = SELECTED.CANTIDAD.ToString("N1");
                txtDESCRIPCION.Text = SELECTED.DESCRIPCION;
                txtPRECIO.Text = SELECTED.PRECIO.ToString("N2");
            }
        }

        private void CANCELAR(object sender, EventArgs e)
        {
            this.Close();
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





        private void GUARDAR(object sender, EventArgs e)
        {
            if (validarITEM())
            {
                        
                string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                {
                    SELECTED.DESCRIPCION = txtDESCRIPCION.Text.Trim();
                    SELECTED.PRECIO = Decimal.Parse(txtPRECIO.Text.Trim());
                    //if (dbInventario.updateArticuloVentaPRENDASAL(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                    //{
                    //    RInvVentaForm.Instance().recargar();
                    //    this.Close();
                    //}
                }
                else
                {
                    MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
              

        }



        private void btnSCAN_Click(object sender, EventArgs e)
        {
            FotoArticuloForm foto = new FotoArticuloForm(SELECTED.ID_MOV.ToString());
            foto.ShowDialog();
        }






    }
}
