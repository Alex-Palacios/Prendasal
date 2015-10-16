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

    public partial class ConfirmarVenta : Form
    {
        private DBUsuario dbUser;
        private VentaController dbVenta;
        private Venta VENTA;
        private eOperacion ACCION;


        public ConfirmarVenta(Venta v, eOperacion operacion)
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbVenta = new VentaController();
            ACCION = operacion;
            VENTA = v;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (VENTA != null)
            {
                lbDOCUMENTO.Text = VENTA.TIPO_DOC.ToString() + " " +VENTA.DOCUMENTO;
                lbFECHA.Text = VENTA.FECHA.ToString("dd/MM/yyyy");
                lbCLIENTE.Text = VENTA.CLIENTE.CLIENTE;
                lbSUMAS.Text = VENTA.SUMAS.ToString("C2");
                lbDESCUENTO.Text = VENTA.DESCUENTO.ToString("C2");
                lbTOTAL.Text = VENTA.TOTAL.ToString("C2");
                lbNIVEL.Text = VENTA.NIVEL.ToString();
                switch (VENTA.NIVEL)
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

                        if (dbVenta.registrarVentaPRENDASAL(VENTA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            VentasForm.Instance().buscarVenta(VENTA.FECHA,VENTA.TIPO_DOC,VENTA.DOCUMENTO);
                            VentasForm.Instance().ImprimirFactura();
                            this.Close();
                        }
                        break;
                    case eOperacion.UPDATE:
                        string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                        if (cambioNota.Trim() != "")
                        {
                            VENTA.NOTA_CAMBIO = cambioNota;
                            if (dbVenta.editarVentaPRENDASAL(VENTA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                VentasForm.Instance().buscarVenta(VENTA.FECHA,VENTA.TIPO_DOC,VENTA.DOCUMENTO);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("INGRESE UNA NOTA ACLARATORIA DE LA MODIFICACION", "REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
