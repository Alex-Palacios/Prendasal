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

    public partial class ConfirmarContrato : Form
    {
        private DBUsuario dbUser;
        private DBPrestamo dbContrato;
        private Prestamo PRESTAMO;
        private eOperacion ACCION;

        public ConfirmarContrato(Prestamo p , eOperacion operacion)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbContrato = new DBPrestamo();
            ACCION = operacion;
            PRESTAMO = p;
            mostrarDatos();
        }



        private void mostrarDatos()
        {
            if (PRESTAMO != null)
            {
                lbCONTRATO.Text = PRESTAMO.DOCUMENTO;
                lbFECHA.Text = PRESTAMO.FECHA.ToString("dd/MM/yyyy");
                lbCLIENTE.Text = PRESTAMO.CLIENTE;
                lbTIPO.Text = PRESTAMO.TIPO.ToString();
                lbTOTAL.Text = PRESTAMO.TOTAL.ToString("C2");
                lbMENSUAL.Text = PRESTAMO.TASA_MENSUAL + " %";
                lbINTERES.Text = PRESTAMO.INTERES_MENSUAL.ToString("C2");
                lbPLAZO.Text = PRESTAMO.PLAZO_CONTRATO + " DIAS";
                lbFECHA_VENC.Text = PRESTAMO.FECHA_VENC_INIT.ToString("dd/MM/yyyy");
                lbNIVEL.Text = PRESTAMO.NIVEL.ToString();
                switch (PRESTAMO.NIVEL)
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

                        if (dbContrato.insert(PRESTAMO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            ContratosForm.Instance().buscarContrato(PRESTAMO.DOCUMENTO);
                            ContratosForm.Instance().ImprimirContratoPrestamo_Plantilla_2();
                            this.Close();
                        }
                        break;
                    case eOperacion.UPDATE:
                        if (dbContrato.update(PRESTAMO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            ContratosForm.Instance().buscarContrato(PRESTAMO.DOCUMENTO);
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
