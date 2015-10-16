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

namespace PrendaSAL.Configuracion
{
    using MODELO;
    using DDB;

    public partial class ReglasNegocioForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ReglasNegocioForm frmInstance = null;

        public static ReglasNegocioForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ReglasNegocioForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }



        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;

        private Reglas PRENDASAL;
        private Reglas AMIGO;
        private Reglas VIP;

        public ReglasNegocioForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbPrendasal = new DBPRENDASAL();
        }


        private void permisos()
        {
            CAMBIAR_PRENDASAL.Visible = false;
            GUARDAR_PRENDASAL.Visible = false;
            CANCELAR_PRENDASAL.Visible = false;

            CAMBIAR_AMIGO.Visible = false;
            GUARDAR_AMIGO.Visible = false;
            CANCELAR_AMIGO.Visible = false;

            CAMBIAR_VIP.Visible = false;
            GUARDAR_VIP.Visible = false;
            CANCELAR_VIP.Visible = false;


            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P23")
                {
                    CAMBIAR_PRENDASAL.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_PRENDASAL.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_PRENDASAL.Visible = p.Field<bool>("ACTUALIZAR");

                    CAMBIAR_AMIGO.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_AMIGO.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_AMIGO.Visible = p.Field<bool>("ACTUALIZAR");

                    CAMBIAR_VIP.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_VIP.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_VIP.Visible = p.Field<bool>("ACTUALIZAR");

                }
            }
        }

        private void ReglasNegocioForm_Load(object sender, EventArgs e)
        {
            permisos();
            this.BackColor = Color.Black;
            PRENDASAL = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.PRENDASAL));
            cargarReglas(eNIVEL.PRENDASAL);
            bloquear(eNIVEL.PRENDASAL);
        }


        private void bloquear(eNIVEL nivel)
        {
            switch (nivel)
            {
                case eNIVEL.PRENDASAL:
                    //CLIENTE PRENDASAL
                    TasaMensual_PRENDASAL.Enabled = false;
                    Tasa15_PRENDASAL.Enabled = false;
                    PlazoContrato_PRENDASAL.Enabled = false;
                    PlazoVencido_PRENDASAL.Enabled = false;
                    DescCompras_PRENDASAL.Enabled = false;
                    DescInteres_PRENDASAL.Enabled = false;
                    PuntosDolar_PRENDASAL.Enabled = false;
                    PuntosValor_PRENDASAL.Enabled = false;
                    CAMBIAR_PRENDASAL.Enabled = true;
                    GUARDAR_PRENDASAL.Enabled = false;
                    CANCELAR_PRENDASAL.Enabled = false;
                    break;
                case eNIVEL.AMIGO:
                    //TARJETA AMIGO
                    TasaMensual_AMIGO.Enabled = false;
                    Tasa15_AMIGO.Enabled = false;
                    PlazoContrato_AMIGO.Enabled = false;
                    PlazoVencido_AMIGO.Enabled = false;
                    DescCompras_AMIGO.Enabled = false;
                    DescInteres_AMIGO.Enabled = false;
                    PuntosDolar_AMIGO.Enabled = false;
                    PuntosValor_AMIGO.Enabled = false;
                    CAMBIAR_AMIGO.Enabled = true;
                    GUARDAR_AMIGO.Enabled = false;
                    CANCELAR_AMIGO.Enabled = false;
                    break;
                case eNIVEL.VIP:
                    //TARJETA VIP
                    TasaMensual_VIP.Enabled = false;
                    Tasa15_VIP.Enabled = false;
                    PlazoContrato_VIP.Enabled = false;
                    PlazoVencido_VIP.Enabled = false;
                    DescCompras_VIP.Enabled = false;
                    DescInteres_VIP.Enabled = false;
                    PuntosDolar_VIP.Enabled = false;
                    PuntosValor_VIP.Enabled = false;
                    CAMBIAR_VIP.Enabled = true;
                    GUARDAR_VIP.Enabled = false;
                    CANCELAR_VIP.Enabled = false;
                    break;
            }
            
        }


        private void desbloquear(eNIVEL nivel)
        {
            switch (nivel)
            {
                case eNIVEL.PRENDASAL:
                    //CLIENTE PRENDASAL
                    TasaMensual_PRENDASAL.Enabled = true;
                    Tasa15_PRENDASAL.Enabled = true;
                    PlazoContrato_PRENDASAL.Enabled = true;
                    PlazoVencido_PRENDASAL.Enabled = true;
                    DescCompras_PRENDASAL.Enabled = true;
                    DescInteres_PRENDASAL.Enabled = true;
                    PuntosDolar_PRENDASAL.Enabled = true;
                    PuntosValor_PRENDASAL.Enabled = true;
                    CAMBIAR_PRENDASAL.Enabled = false;
                    GUARDAR_PRENDASAL.Enabled = true;
                    CANCELAR_PRENDASAL.Enabled = true;
                    break;
                case eNIVEL.AMIGO:
                    //TARJETA AMIGO
                    TasaMensual_AMIGO.Enabled = true;
                    Tasa15_AMIGO.Enabled = true;
                    PlazoContrato_AMIGO.Enabled = true;
                    PlazoVencido_AMIGO.Enabled = true;
                    DescCompras_AMIGO.Enabled = true;
                    DescInteres_AMIGO.Enabled = true;
                    PuntosDolar_AMIGO.Enabled = true;
                    PuntosValor_AMIGO.Enabled = true;
                    CAMBIAR_AMIGO.Enabled = false;
                    GUARDAR_AMIGO.Enabled = true;
                    CANCELAR_AMIGO.Enabled = true;
                    break;
                case eNIVEL.VIP:
                    //TARJETA VIP
                    TasaMensual_VIP.Enabled = true;
                    Tasa15_VIP.Enabled = true;
                    PlazoContrato_VIP.Enabled = true;
                    PlazoVencido_VIP.Enabled = true;
                    DescCompras_VIP.Enabled = true;
                    DescInteres_VIP.Enabled = true;
                    PuntosDolar_VIP.Enabled = true;
                    PuntosValor_VIP.Enabled = true;
                    CAMBIAR_VIP.Enabled = false;
                    GUARDAR_VIP.Enabled = true;
                    CANCELAR_VIP.Enabled = true;
                    break;
            }
        }

        


        private void cargarReglas(eNIVEL nivel)
        {
            switch(nivel){
                case eNIVEL.PRENDASAL:
                    lbFechaAuto_PRENDASAL.Text = PRENDASAL.FECHA.Date.ToString("dd/MM/yyyy");
                    lbAuto_PRENDASAL.Text = PRENDASAL.AUTORIZO;
                    TasaMensual_PRENDASAL.Value = (decimal) PRENDASAL.TASA_MENSUAL;
                    PlazoContrato_PRENDASAL.Value = PRENDASAL.PLAZO_CONTRATO;
                    PlazoVencido_PRENDASAL.Value = PRENDASAL.PLAZO_VENCIDO;
                    DescCompras_PRENDASAL.Value = (decimal)PRENDASAL.DESC_COMPRA;
                    DescInteres_PRENDASAL.Value = (decimal)PRENDASAL.DESC_INTERES;
                    PuntosDolar_PRENDASAL.Value = (decimal)PRENDASAL.PUNTOS_DOLAR;
                    PuntosValor_PRENDASAL.Value = PRENDASAL.PUNTOS_VALOR;
                    break;
                case eNIVEL.AMIGO:
                    lbFechaAuto_AMIGO.Text = AMIGO.FECHA.Date.ToString("dd/MM/yyyy");
                    lbAuto_AMIGO.Text = AMIGO.AUTORIZO;
                    TasaMensual_AMIGO.Value = (decimal) AMIGO.TASA_MENSUAL;
                    PlazoContrato_AMIGO.Value = AMIGO.PLAZO_CONTRATO;
                    PlazoVencido_AMIGO.Value = AMIGO.PLAZO_VENCIDO;
                    DescCompras_AMIGO.Value = (decimal)AMIGO.DESC_COMPRA;
                    DescInteres_AMIGO.Value = (decimal)AMIGO.DESC_INTERES;
                    PuntosDolar_AMIGO.Value = (decimal)AMIGO.PUNTOS_DOLAR;
                    PuntosValor_AMIGO.Value = AMIGO.PUNTOS_VALOR;
                    break;
                case eNIVEL.VIP:
                    lbFechaAuto_VIP.Text = VIP.FECHA.Date.ToString("dd/MM/yyyy");
                    lbAuto_VIP.Text = VIP.AUTORIZO;
                    TasaMensual_VIP.Value = (decimal) VIP.TASA_MENSUAL;
                    PlazoContrato_VIP.Value = VIP.PLAZO_CONTRATO;
                    PlazoVencido_VIP.Value = VIP.PLAZO_VENCIDO;
                    DescCompras_VIP.Value = (decimal)VIP.DESC_COMPRA;
                    DescInteres_VIP.Value = (decimal)VIP.DESC_INTERES;
                    PuntosDolar_VIP.Value = (decimal)VIP.PUNTOS_DOLAR;
                    PuntosValor_VIP.Value = VIP.PUNTOS_VALOR;
                    break;

            }
            
        }



        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedTab.Name)
            {
                case "pagPRENDASAL":
                    this.BackColor = Color.Black;
                    PRENDASAL = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.PRENDASAL));
                    cargarReglas(eNIVEL.PRENDASAL);
                    bloquear(eNIVEL.PRENDASAL);
                    break;
                case "pagAMIGO":
                    this.BackColor = Color.DarkGreen;
                    AMIGO = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.AMIGO));
                    cargarReglas(eNIVEL.AMIGO);
                    bloquear(eNIVEL.AMIGO);
                    break;
                case "pagVIP":
                    this.BackColor = Color.DarkBlue;
                    VIP = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.VIP));
                    cargarReglas(eNIVEL.VIP);
                    bloquear(eNIVEL.VIP);
                    break;
            }
        }





        private Reglas buildREGLA(eNIVEL nivel){
            Reglas r = new Reglas();
            switch (nivel)
            {
                case eNIVEL.PRENDASAL:
                    r.NIVEL = eNIVEL.PRENDASAL;
                    r.TASA_MENSUAL = TasaMensual_PRENDASAL.Value;
                    r.PLAZO_CONTRATO = (int)PlazoContrato_PRENDASAL.Value;
                    r.PLAZO_VENCIDO = (int)PlazoVencido_PRENDASAL.Value;
                    r.DESC_COMPRA = DescCompras_PRENDASAL.Value;
                    r.DESC_INTERES = DescInteres_PRENDASAL.Value;
                    r.PUNTOS_DOLAR = (int)PuntosDolar_PRENDASAL.Value;
                    r.PUNTOS_VALOR = PuntosValor_PRENDASAL.Value;
                    break;
                case eNIVEL.AMIGO:
                    r.NIVEL = eNIVEL.AMIGO;
                    r.TASA_MENSUAL = TasaMensual_AMIGO.Value;
                    r.PLAZO_CONTRATO = (int)PlazoContrato_AMIGO.Value;
                    r.PLAZO_VENCIDO = (int)PlazoVencido_AMIGO.Value;
                    r.DESC_COMPRA = DescCompras_AMIGO.Value;
                    r.DESC_INTERES = DescInteres_AMIGO.Value;
                    r.PUNTOS_DOLAR = (int)PuntosDolar_AMIGO.Value;
                    r.PUNTOS_VALOR = PuntosValor_AMIGO.Value;
                    break;
                case eNIVEL.VIP:
                    r.NIVEL = eNIVEL.VIP;
                    r.TASA_MENSUAL = TasaMensual_VIP.Value;
                    r.PLAZO_CONTRATO = (int)PlazoContrato_VIP.Value;
                    r.PLAZO_VENCIDO = (int)PlazoVencido_VIP.Value;
                    r.DESC_COMPRA = DescCompras_VIP.Value;
                    r.DESC_INTERES = DescInteres_VIP.Value;
                    r.PUNTOS_DOLAR = (int)PuntosDolar_VIP.Value;
                    r.PUNTOS_VALOR = PuntosValor_VIP.Value;
                    break;
            }
            return r;
        }






        private void CAMBIAR_PRENDASAL_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.PRENDASAL);
        }



        private void GUARDAR_PRENDASAL_Click(object sender, EventArgs e)
        {
            Reglas nuevaR = new Reglas();
            nuevaR = buildREGLA(eNIVEL.PRENDASAL);
            string autorizacion = Controles.InputBoxPassword("CODIGO","CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                nuevaR.FECHA = HOME.Instance().FECHA_SISTEMA;
                nuevaR.COD_EMPLEADO = HOME.Instance().USUARIO.COD_EMPLEADO;
                if (dbPrendasal.actualizarReglas(nuevaR))
                {
                    PRENDASAL = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.PRENDASAL));
                    cargarReglas(eNIVEL.PRENDASAL);
                    bloquear(eNIVEL.PRENDASAL);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }






        private void CANCELAR_PRENDASAL_Click(object sender, EventArgs e)
        {
            cargarReglas(eNIVEL.PRENDASAL);
            bloquear(eNIVEL.PRENDASAL);
        }














        private void CAMBIAR_AMIGO_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.AMIGO);
        }





        private void GUARDAR_AMIGO_Click(object sender, EventArgs e)
        {
            Reglas nuevaR = new Reglas();
            nuevaR = buildREGLA(eNIVEL.AMIGO);
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                nuevaR.FECHA = HOME.Instance().FECHA_SISTEMA;
                nuevaR.COD_EMPLEADO = HOME.Instance().USUARIO.COD_EMPLEADO;
                if (dbPrendasal.actualizarReglas(nuevaR))
                {
                    AMIGO = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.AMIGO));
                    cargarReglas(eNIVEL.AMIGO);
                    bloquear(eNIVEL.AMIGO);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CANCELAR_AMIGO_Click(object sender, EventArgs e)
        {
            cargarReglas(eNIVEL.AMIGO);
            bloquear(eNIVEL.AMIGO);
        }








        private void CAMBIAR_VIP_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.VIP);
        }



        private void GUARDAR_VIP_Click(object sender, EventArgs e)
        {
            Reglas nuevaR = new Reglas();
            nuevaR = buildREGLA(eNIVEL.VIP);
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                nuevaR.FECHA = HOME.Instance().FECHA_SISTEMA;
                nuevaR.COD_EMPLEADO = HOME.Instance().USUARIO.COD_EMPLEADO;
                if (dbPrendasal.actualizarReglas(nuevaR))
                {
                    VIP = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.VIP));
                    cargarReglas(eNIVEL.VIP);
                    bloquear(eNIVEL.VIP);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }




        private void CANCELAR_VIP_Click(object sender, EventArgs e)
        {
            cargarReglas(eNIVEL.VIP);
            bloquear(eNIVEL.VIP);
        }





    }
}
