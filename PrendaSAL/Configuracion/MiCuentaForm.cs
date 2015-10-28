using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PrendaSAL.Configuracion
{
    using MODELO;
    using DDB;

    public partial class MiCuentaForm : Office2007Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static MiCuentaForm frmInstance = null;

        public static MiCuentaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new MiCuentaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;

        public MiCuentaForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
        }


        private void permisos()
        {
            btnCambiarPassword.Visible = false;
            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P27")
                {
                    btnCambiarPassword.Visible = p.Field<bool>("ACTUALIZAR");
                }
            }
        }


        private void MiCuentaForm_Load(object sender, EventArgs e)
        {
            
            cbxTipoUsuario.DataSource = Enum.GetValues(new eTipoUsuario().GetType());
            permisos();
            cargarUsuario();
        }

        private void limpiar()
        {
            txtCodEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
        }

        private void cargarUsuario()
        {
            if (HOME.Instance().USUARIO != null)
            {
                txtCodEmpleado.Text = HOME.Instance().USUARIO.COD_EMPLEADO;
                txtNombreEmpleado.Text = HOME.Instance().USUARIO.NOMBRE;
                cbxTipoUsuario.SelectedItem = HOME.Instance().USUARIO.TIPO;
            }
            else
            {
                limpiar();
            }
        }


        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            CambiarPassword cambiar = new CambiarPassword();
            cambiar.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
