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
    using DDB;
    using MODELO;

    public partial class SucursalesForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static SucursalesForm frmInstance = null;

        public static SucursalesForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new SucursalesForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBUsuario dbUser;
        private DBSucursal dbSucursal;

        private DataTable SUCURSALES;
        private Sucursal SELECTED;


        public SucursalesForm()
        {
            InitializeComponent(); 
            dbUser = new DBUsuario();
            dbSucursal = new DBSucursal();
            tblSUCURSALES.AutoGenerateColumns = false;
            cargarSucursales();
            permisos();
        }

        private void permisos()
        {
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P26")
                {
                    btnAgregar.Visible = p.Field<bool>("REGISTRAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                }
            }
        }

        public void cargarSucursales()
        {
            SUCURSALES = dbSucursal.showSucursalesConfig();
            tblSUCURSALES.DataSource = SUCURSALES;
            btnEliminar.Enabled = false;
        }


        private void SelectedSucursal()
        {
            SELECTED = null;
            if (tblSUCURSALES.CurrentCell != null && tblSUCURSALES.SelectedRows.Count == 1)
            {
                SELECTED = Sucursal.ConverterToSucursal(SUCURSALES.Rows[tblSUCURSALES.CurrentCell.RowIndex]);
                
                btnEliminar.Enabled = true;

            }
        }


        private void AGREGAR(object sender, EventArgs e)
        {
            AgregarSucursal suc = new AgregarSucursal();
            suc.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblSUCURSALES.CurrentCell != null && tblSUCURSALES.SelectedRows.Count == 1)
            {
                SelectedSucursal();
                if (SELECTED != null)
                {
                    AgregarSucursal suc = new AgregarSucursal(SELECTED);
                    suc.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE SUCURSAL A ACTUALIZAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ELIMINAR(object sender, EventArgs e)
        {
            if (tblSUCURSALES.CurrentCell != null && tblSUCURSALES.SelectedRows.Count == 1)
            {
                SelectedSucursal();
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la CONFIGURACIONES DE LA SUCURSAL " + SELECTED.SUCURSAL + " ?", "ELIMINAR SUCURSAL PRENDASAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbSucursal.deleteSucConfig(SELECTED))
                        {
                            cargarSucursales();
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
                MessageBox.Show("SELECCIONE SUCURSAL A ELIMINAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tblSUCURSALES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblSUCURSALES.CurrentCell != null && tblSUCURSALES.SelectedRows.Count == 1)
            {
                SelectedSucursal();
            }
        }


        private void tblSUCURSALES_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (tblSUCURSALES.Columns[e.ColumnIndex].Name)
                {
                    case "FECHA_SISTEMA":
                        GlobalFechaSistema fecha = (GlobalFechaSistema)e.Value;
                        e.Value = fecha.ToString();
                        break;
                }
            }
        }

        







    }
}
