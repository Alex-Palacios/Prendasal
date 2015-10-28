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
    using DDB;

    public partial class ConfirmarFinanc : Form
    {
        private DBUsuario dbUser;
        private DBMovCash dbFinanc;

        private MovCash SELECTED;
        private decimal TOTAL;
        private eOperacion ACCION;

        

        public ConfirmarFinanc(MovCash m)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbFinanc = new DBMovCash();
            ACCION = eOperacion.UPDATE;
            SELECTED = m.Copy();
        }


        private void ConfirmarFinanc_Load(object sender, EventArgs e)
        {
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxDESTINO.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO.DisplayMember = "SUCURSAL";
                cbxDESTINO.ValueMember = "COD_SUC";
                cbxDESTINO.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            txtTOTAL.Focus();
            cargarDatos();
        }



        private void cargarDatos()
        {
            if (SELECTED != null)
            {
                cbxSUCURSAL.SelectedValue = SELECTED.SUC_ENVIA;
                cbxDESTINO.SelectedValue = SELECTED.SUC_DEST;
                dateFinanc.Value = SELECTED.FECHA;
                txtDOCUMENTO.Text = SELECTED.DOCUMENTO;
                txtTOTAL.Text = SELECTED.TOTAL.ToString("C2");
                lbRECIBIDO.Text = SELECTED.RECIBE;
                txtTRASLADA.Text = SELECTED.TRASLADA;
                txtNOTA.Text = SELECTED.NOTA;
            }
        }



        private bool validar()
        {
            bool OK = true;
            if (SELECTED.RECIBIDO)
            {
                OK = false;
                MessageBox.Show("FINANCIAMIENTO YA HA SIDO RECIBIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            return OK;
        }


        



        private void GUARDAR_Click(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.UPDATE:
                    if (validar())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbFinanc.recibirFinanc(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                FinancForm.Instance().cargarHistoryFinanc();
                                this.Close();
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




    }
}
