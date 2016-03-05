﻿using System;
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
        public bool UNICO;


        public ItemInicialForm()
        {
            InitializeComponent();
            
        }




        private void ItemInv_Load(object sender, EventArgs e)
        {
            
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
                btnGUARDAR.Focus();
            }
        }

        





        private bool validarDatos()
        {
            bool Ok = true;
            decimal cantidad;
            decimal monto;
            try
            {
                if (txtPERIODO.Text == string.Empty)
                {
                    Ok = false;
                    MessageBox.Show("Periodo no indicado", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxBODEGA.SelectedIndex < 0)
                {
                    Ok = false;
                    MessageBox.Show("Indique bodega de almacenaje del articulo", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtCATEGORIA.Text == string.Empty)
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
                
            }
            catch (Exception ex)
            {
                Ok = false;
                MessageBox.Show("ERROR AL VALIDAR DATOS", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return Ok;
        }



        private void GUARDAR(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }



        private void CANCELAR(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }





    }
}
