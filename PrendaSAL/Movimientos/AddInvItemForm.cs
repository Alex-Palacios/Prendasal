using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Movimientos
{
    using MODELO;
    using DDB;

    public partial class AddInvItemForm : Form
    {
        public bool UNICO;
        public DataTable PRECIOS;
        public decimal LIMITE;



        public AddInvItemForm()
        {
            InitializeComponent();
        }





        private void AddInvItemForm_Load(object sender, EventArgs e)
        {
            
        }



        private void calcularMonto()
        {
            LIMITE = (decimal)0.00;
            decimal precio = getPrecioKIL((string)cbxCODITEM.SelectedValue);
            if(precio > 0)
            {
                decimal cantidad = Decimal.Parse(txtCANTIDAD.Text, System.Globalization.NumberStyles.Currency);
                LIMITE = Decimal.Round(precio * cantidad, 2, MidpointRounding.AwayFromZero);
                txtMONTO.Text = LIMITE.ToString();
            }
        }








        private Decimal getPrecioKIL(string item)
        {
            decimal monto = (decimal)0.00;
            if (PRECIOS != null)
            {
                foreach (DataRow row in PRECIOS.Rows)
                {
                    if (row.Field<string>("KILATAJE") == item)
                    {
                        monto = row.Field<decimal>("PRECIO");
                        break;
                    }
                }
            }
            
            return monto;
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
                return;
            }
        }


        private void txtCANTIDAD_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (Decimal.TryParse(txtCANTIDAD.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                txtCANTIDAD.Text = Decimal.Round(valor, 1, MidpointRounding.AwayFromZero).ToString();
                calcularMonto();
            }
            else
            {
                MessageBox.Show("CANTIDAD INVALIDA", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCANTIDAD.Text = "0.0";
            }
        }


        private void txtCANTIDAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMONTO.Focus();
            }
        }







        private void txtMONTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impide introducir mas de un punto

            if (e.KeyChar == 46 && txtMONTO.Text.IndexOf('.') != -1)
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

        private void txtMONTO_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (Decimal.TryParse(txtMONTO.Text, System.Globalization.NumberStyles.Currency, null, out valor))
            {
                txtMONTO.Text = Decimal.Round(valor, 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                MessageBox.Show("MONTO INVALIDO", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMONTO.Text = "0.00";
            }
        }





        private void txtMONTO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }








        private void cbxCODITEM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCODITEM.SelectedIndex >= 0)
            {
                calcularMonto();
            }
        }




        private bool validarDatos()
        {
            bool Ok = true;
            decimal cantidad;
            decimal monto;
            try
            {
                if (txtCATEGORIA.Text == string.Empty)
                {
                    Ok = false;
                    MessageBox.Show("Categoria no definida", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtCODIGO.Text == string.Empty)
                {
                    Ok = false;
                    MessageBox.Show("Codigo de inventario no establecido", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UNICO == false && cbxCODITEM.SelectedIndex < 0)
                {
                    Ok = false;
                    MessageBox.Show("Seleccione item de inventario", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtDESCRIPCION.Text == string.Empty)
                {
                    Ok = false;
                    MessageBox.Show("Defina descripcion del producto", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Decimal.TryParse(txtCANTIDAD.Text, System.Globalization.NumberStyles.Currency, null, out cantidad) && cantidad <= 0)
                {
                    Ok = false;
                    MessageBox.Show("Cantidad invalida", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Decimal.TryParse(txtMONTO.Text, System.Globalization.NumberStyles.Currency, null, out monto) && monto <= 0)
                {
                    Ok = false;
                    MessageBox.Show("Monto invalido", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (LIMITE > 0 && monto > LIMITE && monto > Decimal.Round(LIMITE, 0, MidpointRounding.AwayFromZero))
                {
                    Ok = false;
                    MessageBox.Show("Monto excede el autorizado", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Ok = false;
                MessageBox.Show("Error al validar datos", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return Ok;
        }




        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }








    }
}
