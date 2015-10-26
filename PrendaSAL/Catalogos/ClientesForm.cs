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
using ControlesPersonalizados;

namespace PrendaSAL.Catalogos
{
    using DDB;
    using MODELO;

    public partial class ClientesForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ClientesForm frmInstance = null;
        private string formName;

        public static ClientesForm Instance(string form)
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ClientesForm();
            }
            frmInstance.formName = form;
            frmInstance.BringToFront();
            return frmInstance;
        }


        public static ClientesForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ClientesForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private DBCliente dbCliente;

        public DataTable CARTERA;
        private Cliente SELECTED;

        private eOperacion ACCION;

        public ClientesForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbCliente = new DBCliente();
            dbPrendasal = new DBPRENDASAL();
        }



        private void permisos()
        {
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnSearch.Visible = false;
            btnLog.Visible = false;
            foreach(DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P1")
                {
                    btnNew.Visible = p.Field<bool>("REGISTRAR");
                    btnEdit.Visible = p.Field<bool>("ACTUALIZAR");
                    btnDelete.Visible = p.Field<bool>("ELIMINAR");
                    btnSearch.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                }
            }
        }


        private void ClientesForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCLIENTES.AutoGenerateColumns = false;
            ACCION = eOperacion.INSERT;
            cargarDatos();
            bloquear();

        }


        private void bloquear()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnLog.Enabled = false;
        }

        public void cargarDatos()
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    CARTERA = dbCliente.findByFechaInicio(HOME.Instance().FECHA_SISTEMA, HOME.Instance().SUCURSAL.COD_SUC);
                    tblCLIENTES.DataSource = CARTERA.Copy();
                    break;
                case eOperacion.UPDATE:
                    tblCLIENTES.DataSource = CARTERA.Copy();
                    break;
                case eOperacion.DELETE:
                    CARTERA = dbCliente.findByFechaInicio(HOME.Instance().FECHA_SISTEMA, HOME.Instance().SUCURSAL.COD_SUC);
                    tblCLIENTES.DataSource = CARTERA.Copy();
                    break;
                case eOperacion.SEARCH:
                    tblCLIENTES.DataSource = CARTERA.Copy();
                    break;
            }
            bloquear();
        }






        private void cargarSelected(){
            SELECTED = new Cliente();
            if (tblCLIENTES.CurrentCell != null )
            {
                SELECTED = Cliente.ConvertToCliente(CARTERA.Rows[tblCLIENTES.CurrentCell.RowIndex]);
                
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnLog.Enabled = true;
            }
        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            RegistrarClienteForm nuevo = new RegistrarClienteForm();
            nuevo.ShowDialog(this);
        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tblCLIENTES.SelectedRows.Count == 1)
            {
                ACCION = eOperacion.UPDATE;
                cargarSelected();
                RegistrarClienteForm nuevo = new RegistrarClienteForm(SELECTED);
                nuevo.ShowDialog(this);
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tblCLIENTES.SelectedRows.Count == 1)
            {
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar al cliente " + SELECTED.CLIENTE + " de la Cartera ?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        ACCION = eOperacion.DELETE;
                        cargarSelected();
                        string codigo = SELECTED.COD_CLIENTE;
                        if (dbCliente.delete(codigo, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            cargarDatos();
                        }
                     }
                     else
                     {
                         MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     }
                }
            }
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            ACCION = eOperacion.SEARCH;
            BuscarCliente nuevo = new BuscarCliente();
            nuevo.ShowDialog(this);
        }




        private void btnLog_Click(object sender, EventArgs e)
        {
            if (tblCLIENTES.SelectedRows.Count == 1)
            {
                cargarSelected();
                string codigo = SELECTED.COD_CLIENTE;
                //DataTable log = dbPrendasal.GET_LOG_CLIENTE(SELECTED.CODIGO , HOME.Instance().SISTEMA);
                //if (log.Rows.Count > 0)
                //{
                //    Controles.ShowLogDialog("LOG CLIENTE :" + SELECTED.CODIGO, log);
                //}
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }



        private void tblCLIENTES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCLIENTES.CurrentCell != null && tblCLIENTES.CurrentCell.RowIndex >= 0)
            {
                cargarSelected();
            }
        }






        private void tblCLIENTES_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblCLIENTES.DataSource != null)
            {
                lbNUM.Text = tblCLIENTES.Rows.Count.ToString();
            }
        }



        private void tblCLIENTES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCLIENTES.CurrentCell != null && tblCLIENTES.CurrentCell.RowIndex >= 0 && tblCLIENTES.SelectedRows.Count == 1)
            {
                cargarSelected();
                switch (formName)
                {
                    case "ComprasForm":
                        Movimientos.ComprasForm.Instance().cargarDatosCliente(SELECTED);
                        this.Close();
                        break;
                    case "ContratosForm":
                        Movimientos.ContratosForm.Instance().cargarDatosCliente(SELECTED);
                        this.Close();
                        break;
                    case "VentasForm":
                        Movimientos.VentasForm.Instance().cargarDatosCliente(SELECTED);
                        this.Close();
                        break;
                }
            }
        }







    }
}
