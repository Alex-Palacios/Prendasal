using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Operaciones
{
    using LOGICA;
    using MODELO;
    using DDB;
    using ControlesPersonalizados;

    public partial class ListaVencidosForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ListaVencidosForm frmInstance = null;

        public static ListaVencidosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ListaVencidosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLE
        private DBUsuario dbUser;
        private DBPrestamo dbPrestamo;
        private DBVencidos dbVencidos;

        private eOperacion ACCION;

        private Vencidos LISTA;
        private Vencidos SELECTED;





        public ListaVencidosForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbVencidos = new DBVencidos();
        }


        private void permisos()
        {
            btnNuevo.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnLog.Visible = false;
            btnReimprimir.Visible = false;
            btnLISTAR.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P14")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnGuardar.Visible = p.Field<bool>("REGISTRAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscar.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                    btnLISTAR.Visible = p.Field<bool>("REGISTRAR");
                }
            }

            if (HOME.Instance().USUARIO.TIPO != eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = true;
            }
            else
            {
                cbxSUCURSAL.Enabled = true;
            }
        }



        private void ListaVencidosForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCONTRATOS.AutoGenerateColumns = false;

            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            NUEVO(null, null);
        }


        public void desbloquear()
        {
            txtNOTA.ReadOnly = false;
        }

        public void bloquear()
        {
            txtNOTA.ReadOnly = true;
        }

        public void limpiarDatosListaVencidos()
        {
            cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            dateVencidos.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO.Text = string.Empty;
            txtResponsable.Text = string.Empty;
            txtNOTA.Text = string.Empty;

            tblCONTRATOS.DataSource = null;
            tblKPM.DataSource = null;
        }

        





        public void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            LISTA = new Vencidos();
            LISTA.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
            LISTA.DOCUMENTO = dbVencidos.nextListaVencidos(LISTA.COD_SUC);
            LISTA.FECHA = HOME.Instance().FECHA_SISTEMA;
            LISTA.RESPONSABLE = HOME.Instance().USUARIO.NOMBRE;
            LISTA.NOTA = string.Empty;

            cargarListaVencido();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;
            
        }




        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            VencidosForm verVencidos = new VencidosForm();
            verVencidos.ShowDialog(this);
        }


        public void cargarListaVencido()
        {
            if (LISTA != null)
            {
                txtDOCUMENTO.Text = LISTA.DOCUMENTO;
                dateVencidos.Value = LISTA.FECHA;
                cbxSUCURSAL.SelectedValue = LISTA.COD_SUC;
                txtResponsable.Text = LISTA.RESPONSABLE;
                txtNOTA.Text = LISTA.NOTA;
                tblCONTRATOS.DataSource = LISTA.CONTRATOS_VENCIDOS;

                lbCONTRATOS.Text = LISTA.VENCIDOS + " VENCIDOS";
                lbREACTIVADOS.Text = LISTA.REACTIVADOS + " REACTIVADOS";
                lbTOTAL.Text = LISTA.TOTAL + " CONTRATOS";
                //cargar KPM


            }
            else
            {
                limpiarDatosListaVencidos();
            }
        }


        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != "" && cbxSUCURSAL.SelectedIndex >= 0)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        LISTA.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
                        LISTA.DOCUMENTO = dbVencidos.nextListaVencidos(LISTA.COD_SUC);
                        txtDOCUMENTO.Text = LISTA.DOCUMENTO;
                        break;

                }
            }
        }




        private bool validarLista()
        {
            bool OK = true;
            if (LISTA.CONTRATOS_VENCIDOS.Rows.Count <= 0)
            {
                OK = false;
                MessageBox.Show("NO SE HAN LISTADO CONTRATOS A VENCER", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxSUCURSAL.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }









        private void GUARDAR(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarLista())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbVencidos.insert(LISTA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                SELECTED = Vencidos.ConvertToVencidos(dbVencidos.getListaVencByDoc(LISTA.DOCUMENTO));
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;
            }
            
        }








        private void CANCELAR(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    this.Close();
                    break;
                default:
                    NUEVO(null, null);
                    break;
            }
        }








        private void ELIMINAR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar el Cierre # " + SELECTED.DOCUMENTO + " realizado el: " + SELECTED.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR LISTA DE VENCIDO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbVencidos.delete(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            NUEVO(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }




        private void BUSCAR(object sender, EventArgs e)
        {
            ACCION = eOperacion.SEARCH;
            string numLIST = Controles.InputBox("LISTA DE VENCIDOS #: ", "BUSCAR");
            if (numLIST != "")
            {
                if (buscarListaVencidos(numLIST))
                {
                    MessageBox.Show("LISTA DE VENCIDOS CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("LISTA DE VENCIDOS NO ENCONTRADA", "NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }



        public bool buscarListaVencidos(string documento)
        {
            bool OK = false;
            SELECTED = Vencidos.ConvertToVencidos(dbVencidos.getListaVencByDoc(documento));
            if (SELECTED != null)
            {
                SELECTED.CONTRATOS_VENCIDOS = dbVencidos.getItemsVencidos(SELECTED);
                LISTA = SELECTED.Copy();
                cargarListaVencido();
                bloquear();
                OK = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }



        private void IMPRIMIR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ListaVencPDF printerLista = new ListaVencPDF(SELECTED);
                printerLista.MdiParent = HOME.Instance();
                printerLista.Show();
                if (printerLista.WindowState == FormWindowState.Minimized)
                {
                    printerLista.WindowState = FormWindowState.Normal;
                }
            }
        }




        private void LOG(object sender, EventArgs e)
        {

        }

        private void AYUDA(object sender, EventArgs e)
        {

        }


    }
}
