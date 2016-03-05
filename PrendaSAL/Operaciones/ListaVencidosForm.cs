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
    using MODELO;
    using DDB;
    using ControlesPersonalizados;
    using Microsoft.Reporting.WinForms;

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
            LISTA = new Vencidos();
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
                    btnLISTAR.Visible = p.Field<bool>("BUSCAR");
                }
            }

            if (HOME.Instance().USUARIO.TIPO != eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = true;
            }
            else
            {
                cbxSUCURSAL.Enabled = false;
            }
        }



        private void ListaVencidosForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCONTRATOS.AutoGenerateColumns = false;
            tblKPM.AutoGenerateColumns = false;

            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }

            cbxCategorias.DataSource = HOME.Instance().datCATEGORIAS.Copy();
            if (HOME.Instance().datCATEGORIAS.Rows.Count > 0)
            {
                cbxCategorias.DisplayMember = "CATEGORIA";
                cbxCategorias.ValueMember = "CATEGORIA";
            }
            
            NUEVO(null, null);
        }


        public void desbloquear()
        {
            if (HOME.Instance().USUARIO.TIPO != eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = true;
            }
            else
            {
                cbxSUCURSAL.Enabled = false;
            }
            txtNOTA.ReadOnly = false;
        }

        public void bloquear()
        {
            cbxSUCURSAL.Enabled = false;
            txtNOTA.ReadOnly = true;
        }



        public void limpiarDatosListaVencidos()
        {
            cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            dateApertura.Value = HOME.Instance().FECHA_SISTEMA;
            dateCierre.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO.Text = string.Empty;
            txtRespoApertura.Text = string.Empty;
            txtRespoCierre.Text = string.Empty;
            txtNOTA.Text = string.Empty;
            lbESTADO.Text = string.Empty;

            tblCONTRATOS.DataSource = null;
            tblKPM.DataSource = null;
        }

        





        public void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            LISTA = new Vencidos();
            LISTA.COD_SUC = (string)cbxSUCURSAL.SelectedValue;
            LISTA.DOCUMENTO = dbVencidos.nextListaVencidos(LISTA.COD_SUC);
            LISTA.FECHA_APERTURA = HOME.Instance().FECHA_SISTEMA;
            LISTA.RESPONSABLE_APERTURA = HOME.Instance().USUARIO.NOMBRE;
            LISTA.NOTA = string.Empty;
            LISTA.ESTADO_LISTA = eEstadoListaVenc.ABIERTA;
           
            cargarListaVencido();


            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;
            btnCerrar.Enabled = false;

            numDIAS.Enabled = true;
            cbxCategorias.Enabled = true;
            btnLISTAR.Enabled = true;

        }




        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            if (cbxCategorias.Text == "TODAS")
            {
                LISTA.CONTRATOS_VENCIDOS = dbVencidos.getVencidos((string)cbxSUCURSAL.SelectedValue, (int)numDIAS.Value,null);
            }
            else
            {
                LISTA.CONTRATOS_VENCIDOS = dbVencidos.getVencidos((string)cbxSUCURSAL.SelectedValue, (int)numDIAS.Value, (string) cbxCategorias.SelectedValue);
            }
            tblCONTRATOS.DataSource = LISTA.CONTRATOS_VENCIDOS;

        }






        public void cargarListaVencido()
        {
            if (LISTA != null)
            {
                txtDOCUMENTO.Text = LISTA.DOCUMENTO;
                dateApertura.Value = LISTA.FECHA_APERTURA;
                cbxSUCURSAL.SelectedValue = LISTA.COD_SUC;
                txtRespoApertura.Text = LISTA.RESPONSABLE_APERTURA;
                txtNOTA.Text = LISTA.NOTA;
                tblCONTRATOS.DataSource = LISTA.CONTRATOS_VENCIDOS;
                tblKPM.DataSource = LISTA.KPM;
                if (LISTA.FECHA_CIERRE != null)
                {
                    dateCierre.Value = LISTA.FECHA_CIERRE.Value;
                    dateCierre.Visible = true;
                }
                else
                {
                    dateCierre.Visible = false;
                }
                if (LISTA.RESPONSABLE_CIERRE != null)
                {
                    txtRespoCierre.Text = LISTA.RESPONSABLE_CIERRE;
                    txtRespoCierre.Visible = true;
                }
                else
                {
                    txtRespoCierre.Visible = false;
                }

                switch (LISTA.ESTADO_LISTA)
                {
                    case eEstadoListaVenc.ABIERTA:
                        lbESTADO.ForeColor = Color.Blue;
                        break;
                    case eEstadoListaVenc.CERRADA:
                        lbESTADO.ForeColor = Color.Red;
                        break;
                }
                lbESTADO.Text = LISTA.ESTADO_LISTA.ToString();
                
                lbCONTRATOS.Text = LISTA.VENCIDOS + " VENCIDOS";
                lbREACTIVADOS.Text = LISTA.REACTIVADOS + " REACTIVADOS";
                lbTOTAL.Text = (LISTA.VENCIDOS + LISTA.REACTIVADOS)+ " CONTRATOS";
                
            }
            else
            {
                limpiarDatosListaVencidos();
            }
        }




        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != "" && cbxSUCURSAL.SelectedIndex >= 0 )
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
            LISTA.NOTA = txtNOTA.Text;
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
                                if (buscarListaVencidos(LISTA.DOCUMENTO))
                                {
                                    cargarListaVencido();
                                }
                                
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




        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (LISTA != null && LISTA.ESTADO_LISTA == eEstadoListaVenc.ABIERTA)
            {
                DialogResult cerrar = MessageBox.Show("¿Está seguro que desea CERRAR La Lista de Vencidos # " + LISTA.DOCUMENTO + " aperturada el: " + SELECTED.FECHA_APERTURA.Date.ToString("dd/MM/yyyy") + " ? \n\n TENGA EN CUENTA QUE YA NO SE PERMITIRA REACTIVAR CONTRATOS DE ESTA LISTA", "CIERRE DEFINITIVO DE LISTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cerrar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        LISTA.FECHA_CIERRE = HOME.Instance().FECHA_SISTEMA;
                        if (dbVencidos.CERRAR_LISTA(LISTA, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            if (buscarListaVencidos(LISTA.DOCUMENTO))
                            {
                                cargarListaVencido();
                            }
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
                MessageBox.Show("LISTA YA SE ESTA CERRADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }




        private void ELIMINAR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la Lista # " + SELECTED.DOCUMENTO + " aperturada el: " + SELECTED.FECHA_APERTURA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR LISTA DE VENCIDO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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


                    numDIAS.Enabled = false;
                    cbxCategorias.Enabled = false;
                    btnLISTAR.Enabled = false;
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
                SELECTED.KPM = dbVencidos.getKPMVencidos(SELECTED);
                LISTA = SELECTED.Copy();
                cargarListaVencido();
                bloquear();
                OK = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = true;
                btnLog.Enabled = true;
                btnReimprimir.Enabled = true;
                btnCerrar.Enabled = true;
            }
            else
            {
                OK = false;
            }
            return OK;
        }





        private void IMPRIMIR(object sender, EventArgs e)
        {
            viewerLISTAVENC.Clear();
            if (SELECTED != null)
            {
                try
                {
                    Sucursal SUC = HOME.Instance().getSucursal(SELECTED.COD_SUC).Copy();
                    dSListaVenc.Clear();
                    dSKPM.Clear();
                    foreach(DataRow row in SELECTED.CONTRATOS_VENCIDOS.Rows)
                    {
                        dSListaVenc.LISTA_VENC.AddLISTA_VENCRow(row.Field<bool>("REACTIVADO"), row.Field<string>("CONTRATO"), row.Field<string>("CLIENTE"), row.Field<string>("CATEGORIA"), row.Field<string>("ARTICULO"), row.Field<decimal>("PRESTAMO"), row.Field<decimal>("SALDO"), row.Field<string>("ESTADO_CONTRATO"), row.Field<Int64>("DIAS_VENC"));
                    }
                    bsListaVenc.DataSource = dSListaVenc.LISTA_VENC;

                    foreach (DataRow row in SELECTED.KPM.Rows)
                    {
                        dSKPM.KPM.AddKPMRow(row.Field<string>("KILATAJE"), row.Field<decimal>("PESO"), row.Field<decimal>("MONTO"));
                    }
                    bsKPM.DataSource = dSKPM.KPM;

                    ReportParameter[] parameters = new ReportParameter[11];
                    parameters[0] = new ReportParameter("SUCURSAL", SUC.SUCURSAL);
                    parameters[1] = new ReportParameter("docVenc", SELECTED.DOCUMENTO);
                    parameters[2] = new ReportParameter("fechaApertura", SELECTED.FECHA_APERTURA.ToShortDateString());
                    parameters[3] = new ReportParameter("responsableApertura", SELECTED.RESPONSABLE_APERTURA);
                    if (SELECTED.FECHA_CIERRE != null)
                    {
                        parameters[4] = new ReportParameter("fechaCierre", SELECTED.FECHA_CIERRE.Value.ToShortDateString());
                    }
                    else
                    {
                        parameters[4] = new ReportParameter("fechaCierre", "");
                    }
                    parameters[5] = new ReportParameter("responsableCierre", SELECTED.RESPONSABLE_CIERRE);
                    parameters[6] = new ReportParameter("Estado", SELECTED.ESTADO_LISTA.ToString());
                    parameters[7] = new ReportParameter("VENCIDOS", SELECTED.VENCIDOS.ToString());
                    parameters[8] = new ReportParameter("REACTIVADOS", SELECTED.REACTIVADOS.ToString());
                    parameters[9] = new ReportParameter("TOTAL", SELECTED.TOTAL.ToString());
                    parameters[10] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));
                    viewerLISTAVENC.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.ListaVencidos.rdlc";
                    viewerLISTAVENC.LocalReport.DataSources.Clear();
                    viewerLISTAVENC.LocalReport.DataSources.Add(new ReportDataSource("CONTRATOS", bsListaVenc));
                    viewerLISTAVENC.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubInformeKPMHandler);
                    viewerLISTAVENC.LocalReport.SetParameters(parameters);
                    viewerLISTAVENC.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n"+ex.Message , "ERROR AL IMPRIMIR LISTA DE VENCIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void SubInformeKPMHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("KPM", bsKPM));
        }

        private void ShowPrintDialog(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerLISTAVENC.PrintDialog();
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
