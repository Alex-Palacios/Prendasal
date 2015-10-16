﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Catalogos
{
    using DDB;
    using MODELO;

    public partial class BuscarCliente : Form
    {
        private DBCliente dbCliente;
        private DataTable FILTRO;


        public BuscarCliente()
        {
            InitializeComponent();
            dbCliente = new DBCliente();
            rdbDOC.Checked = true;
            cbmTIPODOC.DataSource = Enum.GetValues(new eTipoDocCliente().GetType());
        }


        private void rdbCODIGO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCODIGO.Checked)
            {
                txtCODIGO.Text = "";
                txtCODIGO.Enabled = true;
                txtNOMBRE.Enabled = false;
                cbmTIPODOC.Enabled = false;
                txtDOC.Enabled = false;
            }
        }

        private void rdbNOMBRE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNOMBRE.Checked)
            {
                txtNOMBRE.Text = "";
                txtNOMBRE.Enabled = true;
                txtCODIGO.Enabled = false;
                cbmTIPODOC.Enabled = false;
                txtDOC.Enabled = false;
            }
            
        }

        private void rdbDOC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDOC.Checked)
            {
                txtDOC.Text = "";
                cbmTIPODOC.Enabled = true;
                txtDOC.Enabled = true;
                txtCODIGO.Enabled = false;
                txtNOMBRE.Enabled = false;
            }
            
        }

        private bool validar()
        {
            bool OK = true;
            if (rdbCODIGO.Checked && txtCODIGO.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("CODIGO VACIO", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rdbNOMBRE.Checked && txtNOMBRE.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("NOMBRE VACIO", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rdbDOC.Checked && txtDOC.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("DOCUMENTO VACIO", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (rdbCODIGO.Checked)
                {
                    FILTRO = dbCliente.findByCodigoLIKE(txtCODIGO.Text);
                }
                else if (rdbNOMBRE.Checked)
                {
                    FILTRO = dbCliente.findByNombreLIKE(txtNOMBRE.Text);
                }
                else if (rdbDOC.Checked)
                {
                    switch((eTipoDocCliente) cbmTIPODOC.SelectedItem){
                        case eTipoDocCliente.DUI:
                            FILTRO = dbCliente.findByDuiLIKE(txtDOC.Text);
                            break;
                        case eTipoDocCliente.LICENCIA:
                            FILTRO = dbCliente.findByLicenciaLIKE(txtDOC.Text);
                            break;
                        case eTipoDocCliente.PASAPORTE:
                            FILTRO = dbCliente.findByPasaporteLIKE(txtDOC.Text);
                            break;
                        case eTipoDocCliente.CARNET:
                            FILTRO = dbCliente.findByCarnetLIKE(txtDOC.Text);
                            break;
                    }
                }
                ClientesForm.Instance().CARTERA = FILTRO;
                ClientesForm.Instance().cargarDatos();
                this.Close();
            }
        }






        private void txtCODIGO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(null, null);
            }
        }

        


        private void txtNOMBRE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(null, null);
            }
        }

        



        private void txtDOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(null, null);
            }
        }
    }
}
