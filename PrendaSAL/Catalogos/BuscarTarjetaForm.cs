using System;
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

    public partial class BuscarTarjetaForm : Form
    {


        //VARIABLES
        private DBTarjeta dbTarjeta;

        private string formName;
        private Tarjeta SELECTED;
        

        public BuscarTarjetaForm(string form)
        {
            InitializeComponent();
            dbTarjeta = new DBTarjeta();
            formName = form;
        }


        private bool validar(){
            bool OK = true;
            try
            {
                if (!rdbVIP.Checked && !rdbAMIGO.Checked)
                {
                    OK = false;
                    MessageBox.Show("INDIQUE EL TIPO DE TARJETA", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (txtNUMTARJETA.Text.Trim() == "")
                {
                    OK = false;
                    MessageBox.Show("NUMERO DE TRAJETA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL BUSCAR TARJETA", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (rdbAMIGO.Checked)
                {
                    //SELECTED = dbTarjeta.findByNumTarjeta(txtNUMTARJETA.Text.Trim(),eNIVEL.AMIGO);
                    if (SELECTED != null)
                    {
                        switch (SELECTED.ESTADO_TARJETA)
                        {
                            case "VIGENTE":
                                cargarTarjetaSelected();
                                MessageBox.Show("TARJETA AMIGO # " + SELECTED.NUMTARJETA + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case "VENCIDA":
                                MessageBox.Show("TARJETA # " + SELECTED.NUMTARJETA + " VENCIDA EL " + SELECTED.FECHA_VENC.Date.ToString("dd/MM/yyyy"), "VENCIDA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;
                            case "INACTIVA":
                                MessageBox.Show("TARJETA # " + SELECTED.NUMTARJETA + " SE ENCUENTRA INACTIVA COMUNIQUESE CON EL ADMINISTRADOR", "INACTIVA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("TARJETA AMIGO NO ENCONTRADA", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
                else if (rdbVIP.Checked)
                {
                    //SELECTED = dbTarjeta.findByNumTarjetaVIP(txtNUMTARJETA.Text.Trim());
                    if (SELECTED != null)
                    {
                        cargarTarjetaSelected();
                        MessageBox.Show("TARJETA VIP # " + SELECTED.NUMTARJETA + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("TARJETA VIP NO ENCONTRADA", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }




        private void cargarTarjetaSelected()
        {
            if (SELECTED != null)
            {
                switch (formName)
                {
                    case "ComprasForm":
                        
                        this.Close();
                        break;
                    
                }
            }
        }


    }
}
