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

    public partial class CuponesForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static CuponesForm frmInstance = null;

        public static CuponesForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CuponesForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;
        private DBCupones dbCupones;

        private eOperacion ACCION;
        private Cupon SELECTED;
        private DataTable CUPONES;



        public CuponesForm()
        {
            InitializeComponent();
            dbCupones = new DBCupones();
        }


        private void CuponesForm_Load(object sender, EventArgs e)
        {
            tblCUPONES.AutoGenerateColumns = false;
            cargarTirajes();
        }


        public void cargarTirajes()
        {
            CUPONES = dbCupones.showCuponesDesc();
            tblCUPONES.DataSource = CUPONES;
        }


        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            TirajeCuponForm tiraje = new TirajeCuponForm();
            tiraje.ShowDialog();
        }





        private void EDITAR(object sender, EventArgs e)
        {
            if (tblCUPONES != null && tblCUPONES.SelectedRows.Count == 1)
            {
                ACCION = eOperacion.UPDATE;
                TirajeCuponForm tiraje = new TirajeCuponForm(Cupon.ConvertToCupon(CUPONES.Rows[tblCUPONES.CurrentCell.RowIndex]));
                tiraje.ShowDialog();
            }
            
        }

        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblCUPONES != null && tblCUPONES.SelectedRows.Count == 1)
            {
                ACCION = eOperacion.DELETE;

                if (dbCupones.delete(Cupon.ConvertToCupon(CUPONES.Rows[tblCUPONES.CurrentCell.RowIndex]), HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                {
                    cargarTirajes();
                }

            }
        }






        private void btnRptCanjes_Click(object sender, EventArgs e)
        {
            if (tblCUPONES != null && tblCUPONES.SelectedRows.Count == 1)
            {
                SELECTED = Cupon.ConvertToCupon(CUPONES.Rows[tblCUPONES.CurrentCell.RowIndex]);
                if (SELECTED != null)
                {
                    ACCION = eOperacion.SEARCH;
                    RptCuponesCanjesForm rpt = new RptCuponesCanjesForm(Cupon.ConvertToCupon(CUPONES.Rows[tblCUPONES.CurrentCell.RowIndex]));
                    rpt.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione tiraje de cupones a consultar", "Seleccionar Cupones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
