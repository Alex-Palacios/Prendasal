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

namespace PrendaSAL.Movimientos
{
    using MODELO;
    using DDB;

    public partial class ConfirmarCompra : Form
    {
        private DBUsuario dbUser;
        private DBCompra dbCompra;

        private Compra COMPRA;
        private eOperacion ACCION;


        public ConfirmarCompra(Compra c, eOperacion operacion)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbCompra = new DBCompra();
            ACCION = operacion;
            COMPRA = c;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (COMPRA != null)
            {
                lbCONTRATO.Text = COMPRA.DOCUMENTO;
                lbFECHA.Text = COMPRA.FECHA.ToString("dd/MM/yyyy");
                lbCLIENTE.Text = COMPRA.CLIENTE;
                lbSUMAS.Text = COMPRA.TOTAL.ToString("C2");
                lbTOTAL.Text = COMPRA.TOTAL.ToString("C2");
                lbNIVEL.Text = COMPRA.NIVEL.ToString();
                switch (COMPRA.NIVEL)
                {
                    case eNIVEL.PRENDASAL:
                        lbNIVEL.ForeColor = Color.Black;
                        break;
                    case eNIVEL.AMIGO:
                        lbNIVEL.ForeColor = Color.DarkGreen;
                        break;
                    case eNIVEL.VIP:
                        lbNIVEL.ForeColor = Color.DarkBlue;
                        break;
                    case eNIVEL.MAYOREO:
                        lbNIVEL.ForeColor = Color.DarkGoldenrod;
                        break;
                }
            }
        }







        private void GUARDAR_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:

                        if (dbCompra.insert(COMPRA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            if (ComprasForm.Instance().buscarCompra(COMPRA.DOCUMENTO))
                            {
                                ComprasForm.Instance().ImprimirContratoCompra_Plantilla_2();
                            }
                            this.Close();
                        }
                        break;
                    case eOperacion.UPDATE:
                        if (dbCompra.update(COMPRA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            ComprasForm.Instance().buscarCompra(COMPRA.DOCUMENTO);
                            this.Close();
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
