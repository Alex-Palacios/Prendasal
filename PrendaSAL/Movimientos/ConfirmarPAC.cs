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
    using LOGICA;
    using DDB;

    public partial class ConfirmarPAC : Form
    {
        private DBUsuario dbUser;
        private DBPac dbPAC;
        private Pac PAC;
        private eOperacion ACCION;

        public ConfirmarPAC(Pac a , eOperacion operacion)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbPAC = new DBPac();
            ACCION = operacion;
            PAC = a;
            mostrarDatos();
        }


        private void mostrarDatos()
        {
            if (PAC != null)
            {
                PAC.NUEVO_SALDO = PAC.CONTRATO.SALDO - PAC.ABONO;
                PAC.HASTA = PAC.CONTRATO.ULTIMA_PRORROGA.AddMonths(PAC.MESES).AddDays(PAC.DIAS);
                
                lbRECIBO.Text = PAC.RECIBO;
                lbFECHA.Text = PAC.FECHA.ToString("dd/MM/yyyy");
                lbCONTRATO.Text = PAC.CONTRATO.DOCUMENTO;
                lbCLIENTE.Text = PAC.CONTRATO.CLIENTE;
                lbTIPO_MOV.Text = PAC.TIPO.ToString();
                lbINTERES.Text = PAC.INTERES.ToString("C2");
                lbDESCUENTO.Text = PAC.DESCUENTO.ToString("C2");
                lbABONO.Text = PAC.ABONO.ToString("C2");
                lbTOTAL.Text = PAC.TOTAL.ToString("C2");

                lbSaldoActual.Text = PAC.SALDO_ANTERIOR.ToString("C2");
                lbNuevoSaldo.Text = PAC.NUEVO_SALDO.ToString("C2");
                lbNuevoInteres.Text = PAC.NUEVO_INTERES.ToString("C2");

                lbFECHA_PROX.Text = PAC.PROXIMO_PAGO.ToString("dd/MM/yyyy");

                switch (PAC.NIVEL)
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
                lbNIVEL.Text = PAC.NIVEL.ToString();
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
                        PAC.DOCUMENTO = PAC.RECIBO;
                        PAC.IVA = Decimal.Round(PAC.INTERES * Properties.Settings.Default.IVA / 100, 2, MidpointRounding.AwayFromZero);
                        PAC.IVA_DESC = Decimal.Round(PAC.DESCUENTO * Properties.Settings.Default.IVA / 100, 2, MidpointRounding.AwayFromZero);
                        if (dbPAC.insert(PAC, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            PACForm.Instance().IMPRIMIR(PAC);
                            this.Close();
                        }
                        break;
                    case eOperacion.UPDATE:
                        PAC.IVA = Decimal.Round(PAC.INTERES * Properties.Settings.Default.IVA / 100, 2, MidpointRounding.AwayFromZero);
                        PAC.IVA_DESC = Decimal.Round(PAC.DESCUENTO * Properties.Settings.Default.IVA / 100, 2, MidpointRounding.AwayFromZero);
                        break;

                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
