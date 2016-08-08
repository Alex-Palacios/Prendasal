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
    using MODELO;
    using DDB;

    public partial class TirajeCuponForm : Form
    {
        //VARIABLES
        private DBCupones dbCupon;
        private eOperacion ACCION;
        private Cupon SELECTED;

        public TirajeCuponForm()
        {
            InitializeComponent();
            ACCION = eOperacion.INSERT;
            SELECTED = new Cupon();
            dbCupon = new DBCupones();
            SELECTED.FECHA_EXP = HOME.Instance().FECHA_SISTEMA;
            SELECTED.FECHA_VENC = HOME.Instance().FECHA_SISTEMA.AddMonths(3);

            
        }

        public TirajeCuponForm(Cupon cupon)
        {
            InitializeComponent();
            ACCION = eOperacion.UPDATE;
            dbCupon = new DBCupones();
            SELECTED = cupon;

        }

        private void TirajeCuponForm_Load(object sender, EventArgs e)
        {
            cbxTIPO.DataSource =  Enum.GetValues(new eTipoCupon().GetType());
            cargarCuponSelected();
        }

        private void cargarCuponSelected()
        {
            dateEXP.Value = SELECTED.FECHA_EXP;
            cbxTIPO.SelectedItem = SELECTED.TIPO;
            numDESDE.Value = SELECTED.DESDE;
            numHASTA.Value = SELECTED.HASTA;
            dateVENC.Value = SELECTED.FECHA_VENC;
            numDescInteres.Value = SELECTED.DESC_INTERES;
            numDescVenta.Value = SELECTED.DESC_VENTA;
            ckESTADO.Checked = SELECTED.ACTIVA;
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private bool validarTiraje()
        {
            bool OK = true;
            if (dateEXP.Value >= dateVENC.Value)
            {
                OK = false;
                MessageBox.Show("FECHAS INVALIDAS", "VALIDACION DE TIRAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numDESDE.Value >= numHASTA.Value)
            {
                OK = false;
                MessageBox.Show("RANGO INVALIDO", "VALIDACION DE TIRAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (numDescInteres.Value == 0 && numDescVenta.Value == 0)
            {
                OK = false;
                MessageBox.Show("INGRESE AL MENOS UN PORCENTAJE DE DESCUENTO", "VALIDACION DE TIRAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }


        private void GUARDAR_Click(object sender, EventArgs e)
        {
            if (validarTiraje())
            {
                SELECTED.FECHA_EXP = dateEXP.Value;
                SELECTED.TIPO = (eTipoCupon)cbxTIPO.SelectedItem;
                SELECTED.DESDE = (int)numDESDE.Value;
                SELECTED.HASTA = (int)numHASTA.Value;
                SELECTED.FECHA_VENC = dateVENC.Value;
                SELECTED.DESC_INTERES = numDescInteres.Value;
                SELECTED.DESC_VENTA = numDescVenta.Value;
                SELECTED.ACTIVA = ckESTADO.Checked;

                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        if (dbCupon.insert(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            CuponesForm.Instance().cargarTirajes();
                            this.Close();
                        }
                        break;
                    case eOperacion.UPDATE:
                        if (dbCupon.update(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            CuponesForm.Instance().cargarTirajes();
                            this.Close();
                        }
                        break;
                }
                
            }

        }






    }
}
