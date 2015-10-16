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

    public partial class CambiarPassword : Office2007Form
    {

        //VARIABLES
        private DBUsuario dbUser;

        public CambiarPassword()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtActual.Border.BackColor = Color.Empty;
            txtNuevo.Border.BackColor = Color.Empty;
            txtConfirmar.Border.BackColor = Color.Empty;
            if (DBPRENDASAL.md5(txtActual.Text) == HOME.Instance().USUARIO.PASSWORD && txtActual.Text.Trim() != string.Empty)
            {
                if (DBPRENDASAL.md5(txtNuevo.Text) == DBPRENDASAL.md5(txtConfirmar.Text) && (txtNuevo.Text.Trim() != string.Empty && txtConfirmar.Text.Trim() != string.Empty))
                {
                    DialogResult cambiar = MessageBox.Show("¿Está seguro que desea cambiar su contraseña ?..\n Tenga en cuenta que los cambios surtiran efecto la proxima vez que inicie sesion?", "CAMBIAR PASSWORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cambiar == DialogResult.Yes)
                    {
                        if (dbUser.changePassword(HOME.Instance().SISTEMA, HOME.Instance().USUARIO, txtNuevo.Text))
                        {
                            MessageBox.Show("CREDENCIALES ACTUALIZADAS \nLos cambios afectaran al iniciar sesion nuevamente", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNuevo.Border.BackColor = Color.Red;
                            this.Close();
                        }
                    
                    }
                    
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden.... o son invalidas", "Error de Passowrd", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNuevo.Border.BackColor = Color.Red;
                    txtConfirmar.Border.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Password Actual Inválido","Error de Validacion",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtActual.Border.BackColor = Color.Red;
            }
        }
    }
}
