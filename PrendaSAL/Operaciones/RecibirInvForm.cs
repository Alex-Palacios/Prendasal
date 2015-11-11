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

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;

    public partial class RecibirInvForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RecibirInvForm frmInstance = null;

        public static RecibirInvForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RecibirInvForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBTraslado dbTraslado;
        private DataTable CUSTODIA;
        private DataTable ARTICULOS;
        private Traslado SELECTED;



        public RecibirInvForm()
        {
            InitializeComponent();
            DBTraslado dbTraslado = new DBTraslado();
        }




        private void permisos()
        {
            btnRECIBIR_CUSTODIA.Visible = false;
            btnRECIBIR_REMISION.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P15")
                {
                    btnRECIBIR_CUSTODIA.Visible = p.Field<bool>("REGISTRAR");
                    btnRECIBIR_REMISION.Visible = p.Field<bool>("REGISTRAR");
                }
            }
        }



        private void RecibirInvForm_Load(object sender, EventArgs e)
        {
            permisos();
            

        }








    }
}
