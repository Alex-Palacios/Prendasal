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

    public partial class UsuariosForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static UsuariosForm frmInstance = null;

        public static UsuariosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new UsuariosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbUser;

        private DataTable USUARIOS;
        private Usuario SELECTED;

        public UsuariosForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            permisos();
            tblUSUARIOS.AutoGenerateColumns = false;
            cargarUsuarios();
        }

        private void permisos()
        {
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P28")
                {
                    btnAgregar.Visible = p.Field<bool>("REGISTRAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                }
            }
        }

        public void cargarUsuarios()
        {
            USUARIOS = dbUser.showUsuarios(HOME.Instance().SISTEMA);
            tblUSUARIOS.DataSource = USUARIOS;
            btnEliminar.Enabled = false;
        }



        private void SelectedUsuario()
        {
            SELECTED = null;
            if (tblUSUARIOS.CurrentCell != null && tblUSUARIOS.SelectedRows.Count == 1)
            {
                SELECTED = Usuario.ConvertToUsuario(USUARIOS.Rows[tblUSUARIOS.CurrentCell.RowIndex]);
                btnEliminar.Enabled = true;

            }
        }





        private void AGREGAR(object sender, EventArgs e)
        {
            AgregarUser user = new AgregarUser();
            user.ShowDialog();
        }



        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblUSUARIOS.CurrentCell != null && tblUSUARIOS.SelectedRows.Count == 1)
            {
                SelectedUsuario();
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar al USUARIO " + SELECTED.COD_EMPLEADO + " del empleado " + SELECTED.NOMBRE + " ?", "ELIMINAR USUARIO PRENDASAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbUser.delete(HOME.Instance().SISTEMA, SELECTED))
                        {
                           cargarUsuarios();
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE ARTICULO A ELIMINAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tblUSUARIOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblUSUARIOS.CurrentCell != null && tblUSUARIOS.SelectedRows.Count == 1)
            {
                SelectedUsuario();
            }
        }


        private void tblUSUARIOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblUSUARIOS.Columns[e.ColumnIndex].Name)
                {
                    case "TIPO_USER":
                        eTipoUsuario tipo = (eTipoUsuario)e.Value;
                        e.Value = tipo.ToString();
                        break;
                }
            }
        }



        private void tblUSUARIOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = tblUSUARIOS.Columns[e.ColumnIndex].Name;
                switch (name)
                {
                    case "RESET":
                        if (tblUSUARIOS.CurrentCell != null && tblUSUARIOS.SelectedRows.Count == 1)
                        {
                            SelectedUsuario();
                            DialogResult reset = MessageBox.Show("¿Está seguro que desea RESETEAR contraseña del USUARIO " + SELECTED.COD_EMPLEADO + "\n para el empleado " + SELECTED.NOMBRE + " ?", "RESETEAR PASSWORD DE USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (reset == DialogResult.Yes)
                            {
                               if (dbUser.changePassword(HOME.Instance().SISTEMA,SELECTED,SELECTED.COD_EMPLEADO))
                               {
                                  MessageBox.Show("CONTRASEÑA RECUPERADA", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                  cargarUsuarios();
                               }
                            }
                        }
                        break;
                    case "ACTIVE":
                        if (tblUSUARIOS.CurrentCell != null && tblUSUARIOS.SelectedRows.Count == 1)
                        {
                            SelectedUsuario();
                            string msg = "";
                            if (SELECTED.ACTIVO)
                            {
                                msg = "Seguro que desea DESACTIVAR al Usuario: " + SELECTED.COD_EMPLEADO + "\n del empleado : " + SELECTED.NOMBRE + " ?";
                            }
                            else
                            {
                                msg = "Seguro que desea DESACTIVAR al Usuario: " + SELECTED.COD_EMPLEADO + "\n del empleado : " + SELECTED.NOMBRE + " ?";
                            }
                            DialogResult active = MessageBox.Show(msg, "ACTIVAR/DESACTIVAR  DE USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (active == DialogResult.Yes)
                            {
                                if (dbUser.activeChange(HOME.Instance().SISTEMA,SELECTED))
                                {
                                    MessageBox.Show("ESTADO DE USUARIO ACTUALIZADO", "OPERACION FINALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarUsuarios();
                                }
                            }
                        }
                        break;
                }
            }
        }




    }
}
