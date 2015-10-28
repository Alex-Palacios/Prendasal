using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Configuracion
{
    using MODELO;
    using DDB;

    public partial class PermisosForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static PermisosForm frmInstance = null;

        public static PermisosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new PermisosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBUsuario dbuser;
        private DataTable PERMISOS;
        private Permiso SELECTED;

        public PermisosForm()
        {
            InitializeComponent();
            dbuser = new DBUsuario();
        }


        private void permisos()
        {
            btnEditar.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P29")
                {
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                }
            }
        }



        private void PermisosForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblPERMISOS.AutoGenerateColumns = false;
            cbxTIPOUSER.DataSource = Enum.GetValues(new eTipoUsuario().GetType());
        }


        public void consultarPermisos()
        {
            PERMISOS = dbuser.getPermisos(HOME.Instance().SISTEMA, (eTipoUsuario)cbxTIPOUSER.SelectedItem);
            tblPERMISOS.DataSource = PERMISOS;
        }

        private void btnObtenerPermisos_Click(object sender, EventArgs e)
        {
            if (cbxTIPOUSER.SelectedIndex >= 0)
            {
                consultarPermisos();
            }
            else
            {
                MessageBox.Show("Seleccione Tipo de Usuario", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void tblPERMISOS_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblPERMISOS.DataSource != null && tblPERMISOS.Rows.Count > 0)
            {
                btnEditar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
            }
        }


        private void cargarSelected()
        {
            SELECTED = null;
            if (tblPERMISOS.CurrentCell != null && tblPERMISOS.SelectedRows.Count == 1)
            {
                SELECTED = Permiso.ConvertToPermiso(PERMISOS.Rows[tblPERMISOS.CurrentCell.RowIndex]);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblPERMISOS.CurrentCell != null && tblPERMISOS.SelectedRows.Count == 1)
            {
                if ((eTipoUsuario)PERMISOS.Rows[tblPERMISOS.CurrentCell.RowIndex].Field<int>("TIPO_USER") != eTipoUsuario.ADMIN)
                {
                    cargarSelected();
                    if (SELECTED != null)
                    {
                        CambiarPermiso permisoUpdate = new CambiarPermiso(SELECTED);
                        permisoUpdate.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE PERMISO A EDITAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void tblPERMISOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tblPERMISOS.Columns[e.ColumnIndex].Name == "TIPO_USER")
                {
                    eTipoUsuario tipo = (eTipoUsuario)e.Value;
                    e.Value = tipo.ToString();
                }
            }
        }






    }
}
