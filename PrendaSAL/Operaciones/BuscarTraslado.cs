using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Operaciones
{
    using DDB;
    using MODELO;

    public partial class BuscarTraslado : Form
    {


        //VARIABLES
       

        public BuscarTraslado()
        {
            InitializeComponent();
        }





        private bool validar(){
            bool OK = true;
            try
            {
                if (!rdbCV.Checked && !rdbNR.Checked)
                {
                    OK = false;
                    MessageBox.Show("INDIQUE EL TIPO DE TRASLADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (txtDOCUMENTO.Text.Trim() == "")
                {
                    OK = false;
                    MessageBox.Show("NUMERO DE DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL BUSCAR TRASLADO", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }






        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (rdbNR.Checked)
                {
                    if (TrasladoForm.Instance().buscarTraslado(txtDOCUMENTO.Text.Trim(), eTipoTraslado.NOTA_REMISION))
                    {
                        MessageBox.Show("NOTA DE REMISION CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                    else
                    {
                        MessageBox.Show("NOTA DE REMISION NO EXISTE", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (rdbCV.Checked)
                {
                    if (TrasladoForm.Instance().buscarTraslado(txtDOCUMENTO.Text.Trim(), eTipoTraslado.CUSTODIA_VALORES))
                    {
                        MessageBox.Show("CUSTODIA DE VALORES CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CUSTODIA DE VALORES NO EXISTE", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                this.Close();
            }
        }




    }
}
