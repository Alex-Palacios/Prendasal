using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlesPersonalizados;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;

    public partial class EnviarTrasladoForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static EnviarTrasladoForm frmInstance = null;

        public static EnviarTrasladoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new EnviarTrasladoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBTraslado dbTraslado;
        private Traslado TRASLADO;
        private Traslado SELECTED;

        private eOperacion ACCION;

        private void permisos()
        {
            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P16")
                {
                    btnNuevoRM.Visible = p.Field<bool>("REGISTRAR");
                    btnEditarRM.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnularRM.Visible = p.Field<bool>("ANULAR");
                    btnEliminarRM.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscarRM.Visible = p.Field<bool>("BUSCAR");
                    btnLogRM.Visible = p.Field<bool>("LOG");
                    btnImprimirRM.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }

        }




        public EnviarTrasladoForm()
        {
            InitializeComponent();
            dbTraslado = new DBTraslado();
        }

        

        private void EnviarInvForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCUSTODIA_PRESTAMOS.AutoGenerateColumns = false;
            tblCUSTODIA_COMPRAS.AutoGenerateColumns = false;
            tblREMISION.AutoGenerateColumns = false;

            cbxDESTINO_RM.DataSource = HOME.Instance().getSucursalesException(HOME.Instance().SUCURSAL.COD_SUC).Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO_RM.DisplayMember = "SUCURSAL";
                cbxDESTINO_RM.ValueMember = "COD_SUC";
                cbxDESTINO_RM.SelectedIndex = 0;
            }

            cbxDESTINO_CV.DataSource = HOME.Instance().getSucursalesException(HOME.Instance().SUCURSAL.COD_SUC).Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO_CV.DisplayMember = "SUCURSAL";
                cbxDESTINO_CV.ValueMember = "COD_SUC";
                cbxDESTINO_CV.SelectedIndex = 0;
            }
            tabDETALLE.SelectedIndex = -1;
            tabDETALLE.SelectedIndex = 0;
        }




        private void tabDETALLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDETALLE.SelectedIndex >= 0)
            {
                switch (tabDETALLE.SelectedTab.Name)
                {
                    case "pagREMISION":
                        toolsCV.Visible = false;
                        toolsRM.Visible = true;
                        bloquearRM();
                        NUEVO_RM(null, null);
                        break;

                    case "pagCUSTODIA":
                        toolsCV.Visible = true;
                        toolsRM.Visible = false;
                        bloquearCV();
                        NUEVO_CV(null, null);
                        break;
                }
            }
        }




        //NOTA DE REMISION
        private void bloquearRM()
        {
            grbTrasladoRM.Enabled = false;
            tblREMISION.ReadOnly = true;
            btnADD_RM.Enabled = false;
            btnDEL_RM.Enabled = false;
            txtNOTA_RM.ReadOnly = true;
        }


        private void desbloquearRM()
        {
            grbTrasladoRM.Enabled = true;
            tblREMISION.ReadOnly = false;
            btnADD_RM.Enabled = true;
            btnDEL_RM.Enabled = true;
            txtNOTA_RM.ReadOnly = false;
        }



        private void limpiarDatosTrasladoRM()
        {
            dateEnvio_RM.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO_RM.Text = string.Empty;
            txtASESOR_RM.Text = string.Empty;
            txtTRASLADA_RM.Text = string.Empty;
            txtRECIBE_RM.Text = string.Empty;
            txtNOTA_RM.Text = string.Empty;
            txtTOTAL_RM.Text = string.Empty;
        }



        private void NUEVO_RM(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            TRASLADO = new Traslado();
            TRASLADO.FECHA = HOME.Instance().FECHA_SISTEMA;
            TRASLADO.TIPO = eTipoTraslado.NOTA_REMISION;
            TRASLADO.SUC_ENVIA = HOME.Instance().SUCURSAL.COD_SUC;
            TRASLADO.SUC_DEST = (string)cbxDESTINO_RM.SelectedValue;
            TRASLADO.DOCUMENTO = dbTraslado.nextNotaTraslado(TRASLADO.TIPO, TRASLADO.SUC_ENVIA);
            TRASLADO.ENVIA = HOME.Instance().USUARIO.NOMBRE;

            cargarDatosTrasladoRM();
            desbloquearRM();
            txtTRASLADA_RM.Focus();

            btnGuardarRM.Enabled = true;
            btnCancelarRM.Enabled = true;
            btnEditarRM.Enabled = false;
            btnEliminarRM.Enabled = false;
            btnLogRM.Enabled = false;
            btnImprimirRM.Enabled = false;

        }


        





        private void cargarDatosTrasladoRM()
        {
            limpiarDatosTrasladoRM();
            if (TRASLADO != null)
            {
                txtSUCURSAL_RM.Text = (HOME.Instance().getSucursal(TRASLADO.SUC_ENVIA)).SUCURSAL;
                cbxDESTINO_RM.SelectedValue = TRASLADO.SUC_DEST;
                txtDOCUMENTO_RM.Text = TRASLADO.DOCUMENTO;
                dateEnvio_RM.Value = TRASLADO.FECHA;
                txtASESOR_RM.Text = TRASLADO.ENVIA;
                txtTRASLADA_RM.Text = TRASLADO.TRASLADA;
                txtRECIBE_RM.Text = TRASLADO.RECIBE;
                txtNOTA_RM.Text = TRASLADO.NOTA;
                lbESTADO_RM.Text = TRASLADO.ESTADO_TRASLADO.ToString();

                switch (TRASLADO.ESTADO_TRASLADO)
                {
                    case eEstadoTraslado.RECIBIDO:
                        lbESTADO_RM.ForeColor = Color.Blue;
                        break;
                    case eEstadoTraslado.PENDIENTE:
                        lbESTADO_RM.ForeColor = Color.Crimson;
                        break;
                }

                tblREMISION.DataSource = TRASLADO.DETALLE_TRASLADO;
                calcularTotalesRM();
                
            }
        }


        

        public void calcularTotalesRM()
        {
            decimal total = TRASLADO.DETALLE_TRASLADO.AsEnumerable().Select(r => r.Field<decimal>("PRECIO")).Sum();
            txtTOTAL_RM.Text = total.ToString("C2");
        }





        private void getArticulosTraslado(object sender, EventArgs e)
        {
            ListarTrasladoForm detalle = new ListarTrasladoForm(eTipoDetalleTraslado.ARTICULO,TRASLADO);
            detalle.ShowDialog();
        }





        public void updateTblREMISION()
        {
            tblREMISION.DataSource = TRASLADO.DETALLE_TRASLADO;
            calcularTotalesRM();
        }


        


        private void removeItemTrasladoRM(object sender, EventArgs e)
        {
            if (TRASLADO.DETALLE_TRASLADO.Rows.Count > 0)
            {
                TRASLADO.DETALLE_TRASLADO.Rows.RemoveAt(tblREMISION.CurrentCell.RowIndex);
                calcularTotalesRM();
            }
            
        }



        private void tblREMISION_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && tblREMISION.Columns[e.ColumnIndex].Name == "NUM_RM") {
                e.Value = e.RowIndex + 1;
            }
        }


        private bool validarTrasladoRM()
        {
            bool OK = true;
            if (TRASLADO.DOCUMENTO == null && TRASLADO.DOCUMENTO.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxDESTINO_RM.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL DE DESTINO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTRASLADA_RM.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("INGRESE PERSONA RESPONSABLE DEL TRASLADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TRASLADO.DETALLE_TRASLADO.Rows.Count <= 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE ARTICULOS A TRASLADAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }




        private void GUARDAR_RM(object sender, EventArgs e)
        {
            TRASLADO.SUC_ENVIA = HOME.Instance().SUCURSAL.COD_SUC;
            TRASLADO.SUC_DEST = (string)cbxDESTINO_RM.SelectedValue;
            TRASLADO.FECHA = dateEnvio_RM.Value;
            TRASLADO.TRASLADA = txtTRASLADA_RM.Text.Trim();
            TRASLADO.NOTA = txtNOTA_RM.Text.Trim();

            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarTrasladoRM())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbTraslado.insert(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                if (buscarTraslado(TRASLADO.TIPO,TRASLADO.DOCUMENTO))
                                {
                                    IMPRIMIR_RM(null,null);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;


                case eOperacion.UPDATE:
                    if (validarTrasladoRM())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbTraslado.update(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                if (buscarTraslado(TRASLADO.TIPO, TRASLADO.DOCUMENTO))
                                {
                                    //
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




        private void CANCELAR_RM(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    NUEVO_RM(null, null);
                    break;
                case eOperacion.UPDATE:
                    ACCION = eOperacion.SEARCH;
                    TRASLADO = SELECTED.Copy();
                    cargarDatosTrasladoRM();
                    bloquearRM();

                    btnGuardarRM.Enabled = false;
                    btnCancelarRM.Enabled = false;
                    btnEditarRM.Enabled = true;
                    btnEliminarRM.Enabled = true;
                    btnLogRM.Enabled = true;
                    btnImprimirRM.Enabled = true;
                    break;
            }
        }



        private void EDITAR_RM(object sender, EventArgs e)
        {
            if (TRASLADO != null)
            {
                ACCION = eOperacion.UPDATE;
                desbloquearRM();
                btnGuardarRM.Enabled = true;
                btnCancelarRM.Enabled = true;
                btnEditarRM.Enabled = false;
                btnEliminarRM.Enabled = false;
                btnLogRM.Enabled = false;
                btnImprimirRM.Enabled = false;
            }
            else
            {
                MessageBox.Show("TRASLADO NO CARGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ELIMINAR_RM(object sender, EventArgs e)
        {
            if (TRASLADO != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la NOTA DE REMISION # " + TRASLADO.DOCUMENTO + " con FECHA:" + TRASLADO.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR NOTA DE REMISION REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbTraslado.delete(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            NUEVO_RM(null, null);
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
                MessageBox.Show("NOTA DE REMISION NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void BUSCAR_RM(object sender, EventArgs e)
        {
            string numRM = Controles.InputBox("NOTA DE REMISION #: ", "BUSCAR");
            if (numRM != "")
            {
                if (buscarTraslado(eTipoTraslado.NOTA_REMISION,numRM))
                {
                    MessageBox.Show("NOTA DE REMISION # " + TRASLADO.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NOTA DE REMISION NO ENCONTRADA", "NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        public bool buscarTraslado(eTipoTraslado tipo,string doc)
        {
            bool OK = false;
            SELECTED = Traslado.ConvertToTraslado(dbTraslado.getTrasladoByDocTipoSucENVIA(tipo,doc,HOME.Instance().SUCURSAL.COD_SUC));
            if (SELECTED != null)
            {
                switch(SELECTED.TIPO)
                {
                    case eTipoTraslado.NOTA_REMISION:
                        SELECTED.DETALLE_TRASLADO = dbTraslado.getItemsTraslado(SELECTED);
                        TRASLADO = SELECTED.Copy();
                        cargarDatosTrasladoRM();
                        bloquearRM();
                        OK = true;

                        btnGuardarRM.Enabled = false;
                        btnCancelarRM.Enabled = false;
                        btnEditarRM.Enabled = true;
                        btnEliminarRM.Enabled = true;
                        btnLogRM.Enabled = true;
                        btnImprimirRM.Enabled = true;
                        break;

                    case eTipoTraslado.CUSTODIA_VALORES:
                        SELECTED.DETALLE_TRASLADO = dbTraslado.getItemsTraslado(SELECTED);
                        TRASLADO = SELECTED.Copy();
                        cargarDatosTrasladoCV();
                        bloquearCV();
                        OK = true;

                        btnGuardarCV.Enabled = false;
                        btnCancelarCV.Enabled = false;
                        btnEditarCV.Enabled = true;
                        btnEliminarCV.Enabled = true;
                        btnLogCV.Enabled = true;
                        btnImprimirCV.Enabled = true;
                        break;

                }
            }
            else
            {
                OK = false;
            }
            return OK;
        }





        private void IMPRIMIR_RM(object sender, EventArgs e)
        {
            viewerREMISION.Clear();
            if (TRASLADO != null)
            {
                try
                {
                    Sucursal DE = HOME.Instance().getSucursal(TRASLADO.SUC_ENVIA).Copy();
                    Sucursal HACIA = HOME.Instance().getSucursal(TRASLADO.SUC_DEST).Copy();
                    dSTraslado.Clear();
                    // ARTICULOS
                    foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
                    {
                        dSTraslado.TRASLADO.AddTRASLADORow(row.Field<Int32>("TIPO"), row.Field<string>("CODIGO"), row.Field<decimal>("CANTIDAD"), row.Field<string>("COD_ITEM"), row.Field<string>("DESCRIPCION"), row.Field<decimal>("PRECIO"));
                    }
                    bsTraslado.DataSource = dSTraslado.TRASLADO;
                   
                    ReportParameter[] parameters = new ReportParameter[7];
                    parameters[0] = new ReportParameter("numREMISION", TRASLADO.DOCUMENTO);
                    parameters[1] = new ReportParameter("fechaEnvio", TRASLADO.FECHA.Date.ToShortDateString());
                    parameters[2] = new ReportParameter("origenSUC", DE.SUCURSAL);
                    parameters[3] = new ReportParameter("destinoSUC", HACIA.SUCURSAL);
                    parameters[4] = new ReportParameter("ENVIA", TRASLADO.ENVIA);
                    parameters[5] = new ReportParameter("TRASLADA", TRASLADO.TRASLADA);
                    parameters[6] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerREMISION.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.NotaRemision.rdlc";
                    viewerREMISION.LocalReport.DataSources.Clear();
                    viewerREMISION.LocalReport.DataSources.Add(new ReportDataSource("TRASLADO", bsTraslado));
                    viewerREMISION.LocalReport.SetParameters(parameters);
                    viewerREMISION.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR NOTA DE REMISION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        


        private void ShowPrintDialogREMISION(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerREMISION.PrintDialog();
            }
        }




















        //CUSTODIA DE VALORES
        private void bloquearCV()
        {
            grbTrasladoCV.Enabled = false;
            tblCUSTODIA_PRESTAMOS.ReadOnly = true;
            tblCUSTODIA_COMPRAS.ReadOnly = true;
            btnADD_P.Enabled = false;
            btnADD_C.Enabled = false;
            btnDEL_P.Enabled = false;
            btnDEL_C.Enabled = false;
            txtNOTA_CV.ReadOnly = true;
        }


        private void desbloquearCV()
        {
            grbTrasladoCV.Enabled = true;
            tblCUSTODIA_PRESTAMOS.ReadOnly = false;
            tblCUSTODIA_COMPRAS.ReadOnly = false;
            btnADD_P.Enabled = true;
            btnADD_C.Enabled = true;
            btnDEL_P.Enabled = true;
            btnDEL_C.Enabled = true;
            txtNOTA_CV.ReadOnly = false;
        }



        private void limpiarDatosTrasladoCV()
        {
            dateEnvio_CV.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO_CV.Text = string.Empty;
            txtASESOR_CV.Text = string.Empty;
            txtTRASLADA_CV.Text = string.Empty;
            txtRECIBE_CV.Text = string.Empty;
            txtNOTA_CV.Text = string.Empty;
        }



        private void NUEVO_CV(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            TRASLADO = new Traslado();
            TRASLADO.FECHA = HOME.Instance().FECHA_SISTEMA;
            TRASLADO.TIPO = eTipoTraslado.CUSTODIA_VALORES;
            TRASLADO.SUC_ENVIA = HOME.Instance().SUCURSAL.COD_SUC;
            TRASLADO.SUC_DEST = (string)cbxDESTINO_CV.SelectedValue;
            TRASLADO.DOCUMENTO = dbTraslado.nextNotaTraslado(TRASLADO.TIPO, TRASLADO.SUC_ENVIA);
            TRASLADO.ENVIA = HOME.Instance().USUARIO.NOMBRE;

            cargarDatosTrasladoCV();
            desbloquearCV();
            txtTRASLADA_CV.Focus();

            btnGuardarCV.Enabled = true;
            btnCancelarCV.Enabled = true;
            btnEditarCV.Enabled = false;
            btnEliminarCV.Enabled = false;
            btnLogCV.Enabled = false;
            btnImprimirCV.Enabled = false;

        }








        private void cargarDatosTrasladoCV()
        {
            limpiarDatosTrasladoCV();
            if (TRASLADO != null)
            {
                txtSUCURSAL_CV.Text = (HOME.Instance().getSucursal(TRASLADO.SUC_ENVIA)).SUCURSAL;
                cbxDESTINO_CV.SelectedValue = TRASLADO.SUC_DEST;
                txtDOCUMENTO_CV.Text = TRASLADO.DOCUMENTO;
                dateEnvio_CV.Value = TRASLADO.FECHA;
                txtASESOR_CV.Text = TRASLADO.ENVIA;
                txtTRASLADA_CV.Text = TRASLADO.TRASLADA;
                txtRECIBE_CV.Text = TRASLADO.RECIBE;
                txtNOTA_CV.Text = TRASLADO.NOTA;
                lbESTADO_CV.Text = TRASLADO.ESTADO_TRASLADO.ToString();

                switch (TRASLADO.ESTADO_TRASLADO)
                {
                    case eEstadoTraslado.RECIBIDO:
                        lbESTADO_CV.ForeColor = Color.Blue;
                        break;
                    case eEstadoTraslado.PENDIENTE:
                        lbESTADO_CV.ForeColor = Color.Crimson;
                        break;
                }

                tblCUSTODIA_COMPRAS.DataSource = TRASLADO.CUSTODIA_COMPRAS;
                tblCUSTODIA_PRESTAMOS.DataSource = TRASLADO.CUSTODIA_PRESTAMOS;

            }
        }





        private void getPrestamosTraslado(object sender, EventArgs e)
        {
            ListarTrasladoForm detalle = new ListarTrasladoForm(eTipoDetalleTraslado.PRESTAMO,TRASLADO);
            detalle.ShowDialog();
        }





        public void updateTblCUSTODIA()
        {
            tblCUSTODIA_COMPRAS.DataSource = TRASLADO.CUSTODIA_COMPRAS;
            tblCUSTODIA_PRESTAMOS.DataSource = TRASLADO.CUSTODIA_PRESTAMOS;
        }



        private void removeItemTrasladoPrestamoCV(object sender, EventArgs e)
        {
            DataRow del = null;
            if (TRASLADO.DETALLE_TRASLADO.Rows.Count > 0)
            {
                foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
                {
                    if (row.Field<int>("TIPO") == (int)eTipoDetalleTraslado.PRESTAMO && row.Field<string>("CODIGO") == tblCUSTODIA_PRESTAMOS.Rows[tblCUSTODIA_PRESTAMOS.CurrentCell.RowIndex].Cells["CODIGO_PRESTAMO"].Value.ToString())
                    {
                        del = row;
                        break;
                    }
                }
            }
            if (del != null)
            {
                TRASLADO.DETALLE_TRASLADO.Rows.Remove(del);
                tblCUSTODIA_PRESTAMOS.DataSource = TRASLADO.CUSTODIA_PRESTAMOS;
            }

        }



        private void tblCUSTODIA_PRESTAMO_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && tblCUSTODIA_PRESTAMOS.Columns[e.ColumnIndex].Name == "NUM_CVP")
            {
                e.Value = e.RowIndex + 1;
            }
        }


        private bool validarTrasladoCV()
        {
            bool OK = true;
            if (TRASLADO.DOCUMENTO == null && TRASLADO.DOCUMENTO.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxDESTINO_CV.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL DE DESTINO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTRASLADA_CV.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("INGRESE PERSONA RESPONSABLE DEL TRASLADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TRASLADO.DETALLE_TRASLADO.Rows.Count <= 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE CONTRATOS Y/O COMPRAS A TRASLADAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TRASLADO.CUSTODIA_COMPRAS.Rows.Count > 20)
            {
                OK = false;
                MessageBox.Show("NUMERO DE PRESTAMOS EXCEDE EL LIMITE DE ENVIO POR CUSTODIA DE 20", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TRASLADO.CUSTODIA_PRESTAMOS.Rows.Count > 30)
            {
                OK = false;
                MessageBox.Show("NUMERO DE COMPRAS EXCEDE EL LIMITE DE ENVIO POR CUSTODIA DE 30", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return OK;
        }



        private void getComprasTraslado(object sender, EventArgs e)
        {
            ListarTrasladoForm detalle = new ListarTrasladoForm(eTipoDetalleTraslado.COMPRA, TRASLADO);
            detalle.ShowDialog();
        }






        private void removeItemTrasladoCompraCV(object sender, EventArgs e)
        {
            DataRow del = null;
            if (TRASLADO.DETALLE_TRASLADO.Rows.Count > 0)
            {
                foreach (DataRow row in TRASLADO.DETALLE_TRASLADO.Rows)
                {
                    if (row.Field<int>("TIPO") == (int)eTipoDetalleTraslado.COMPRA && row.Field<string>("CODIGO") == tblCUSTODIA_COMPRAS.Rows[tblCUSTODIA_COMPRAS.CurrentCell.RowIndex].Cells["CODIGO_COMPRA"].Value.ToString())
                    {
                        del = row;
                        break;
                    }
                }
            }
            if (del != null)
            {
                TRASLADO.DETALLE_TRASLADO.Rows.Remove(del);
                tblCUSTODIA_COMPRAS.DataSource = TRASLADO.CUSTODIA_COMPRAS;
            }

        }



        private void tblCUSTODIA_COMPRAS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && tblCUSTODIA_COMPRAS.Columns[e.ColumnIndex].Name == "NUM_CVC")
            {
                e.Value = e.RowIndex + 1;
            }
            if (e.RowIndex >= 0 && tblCUSTODIA_COMPRAS.Columns[e.ColumnIndex].Name == "NIVEL_COMPRA")
            {
                eNIVEL nivel = (eNIVEL)Decimal.ToInt32((decimal) e.Value);
                if (nivel == eNIVEL.MAYOREO)
                {
                    e.Value = "SI";
                }
                else
                {
                    e.Value = "NO";
                }
                
            }
        }



        private void GUARDAR_CV(object sender, EventArgs e)
        {
            TRASLADO.SUC_ENVIA = HOME.Instance().SUCURSAL.COD_SUC;
            TRASLADO.SUC_DEST = (string)cbxDESTINO_CV.SelectedValue;
            TRASLADO.FECHA = dateEnvio_CV.Value;
            TRASLADO.TRASLADA = txtTRASLADA_CV.Text.Trim();
            TRASLADO.NOTA = txtNOTA_CV.Text.Trim();

            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarTrasladoCV())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbTraslado.insert(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                if (buscarTraslado(TRASLADO.TIPO, TRASLADO.DOCUMENTO))
                                {
                                    IMPRIMIR_CV(null, null);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    break;


                case eOperacion.UPDATE:
                    if (validarTrasladoCV())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbTraslado.update(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                if (buscarTraslado(TRASLADO.TIPO, TRASLADO.DOCUMENTO))
                                {
                                    //
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



        private void CANCELAR_CV(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    NUEVO_CV(null,null);
                    break;
                case eOperacion.UPDATE:
                    ACCION = eOperacion.SEARCH;
                    TRASLADO = SELECTED.Copy();
                    cargarDatosTrasladoCV();
                    bloquearCV();

                    btnGuardarCV.Enabled = false;
                    btnCancelarCV.Enabled = false;
                    btnEditarCV.Enabled = true;
                    btnEliminarCV.Enabled = true;
                    btnLogCV.Enabled = true;
                    btnImprimirCV.Enabled = true;
                    break;
            }
        }



        private void EDITAR_CV(object sender, EventArgs e)
        {
            if (TRASLADO != null)
            {
                ACCION = eOperacion.UPDATE;
                desbloquearCV();

                btnGuardarCV.Enabled = true;
                btnCancelarCV.Enabled = true;
                btnEditarCV.Enabled = false;
                btnEliminarCV.Enabled = false;
                btnLogCV.Enabled = false;
                btnImprimirCV.Enabled = false;
            }
            else
            {
                MessageBox.Show("CUSTODIA NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void ELIMINAR_CV(object sender, EventArgs e)
        {
            if (TRASLADO != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la NOTA DE REMISION # " + TRASLADO.DOCUMENTO + " con FECHA:" + TRASLADO.FECHA.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR NOTA DE REMISION REGISTRADA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        if (dbTraslado.delete(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                        {
                            NUEVO_CV(null, null);
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
                MessageBox.Show("NOTA DE REMISION NO CARGADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void BUSCAR_CV(object sender, EventArgs e)
        {
            string numCV = Controles.InputBox("CUSTODIA DE VALORES #: ", "BUSCAR");
            if (numCV != "")
            {
                if (buscarTraslado(eTipoTraslado.CUSTODIA_VALORES, numCV))
                {
                    MessageBox.Show("CUSTODIA DE VALORES # " + TRASLADO.DOCUMENTO + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CUSTODIA DE VALORES NO ENCONTRADA", "NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        


        private void IMPRIMIR_CV(object sender, EventArgs e)
        {
            viewerCUSTODIA.Clear();
            if (TRASLADO != null)
            {
                try
                {
                    Sucursal DE = HOME.Instance().getSucursal(TRASLADO.SUC_ENVIA).Copy();
                    Sucursal HACIA = HOME.Instance().getSucursal(TRASLADO.SUC_DEST).Copy();
                    dSCustodia.Clear();
                    dSCustodia.CUSTODIA_PRESTAMO.Clear();
                    dSCustodia.CUSTODIA_COMPRA.Clear();

                    // CUSTODIA PRESTAMOS
                    for (int i = 0; i < tblCUSTODIA_PRESTAMOS.Rows.Count; i = i + 3)
                    {
                        if (i + 2 < tblCUSTODIA_PRESTAMOS.Rows.Count)
                        {
                            dSCustodia.CUSTODIA_PRESTAMO.AddCUSTODIA_PRESTAMORow(tblCUSTODIA_PRESTAMOS.Rows[i].Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), tblCUSTODIA_PRESTAMOS.Rows[i].Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString(),
                                tblCUSTODIA_PRESTAMOS.Rows[i + 1].Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), tblCUSTODIA_PRESTAMOS.Rows[i + 1].Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString(),
                                tblCUSTODIA_PRESTAMOS.Rows[i + 2].Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), tblCUSTODIA_PRESTAMOS.Rows[i + 2].Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString());
                        }
                        else if (i + 1 < tblCUSTODIA_PRESTAMOS.Rows.Count)
                        {
                            dSCustodia.CUSTODIA_PRESTAMO.AddCUSTODIA_PRESTAMORow(tblCUSTODIA_PRESTAMOS.Rows[i].Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), tblCUSTODIA_PRESTAMOS.Rows[i].Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString(),
                                tblCUSTODIA_PRESTAMOS.Rows[i + 1].Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), tblCUSTODIA_PRESTAMOS.Rows[i + 1].Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString(), null, null);
                        }
                        else
                        {
                            dSCustodia.CUSTODIA_PRESTAMO.AddCUSTODIA_PRESTAMORow(tblCUSTODIA_PRESTAMOS.Rows[i].Cells["CODIGO_PRESTAMO"].FormattedValue.ToString(), tblCUSTODIA_PRESTAMOS.Rows[i].Cells["CATEGORIA_PRESTAMO"].FormattedValue.ToString(),
                                null,null, null, null);
                        }
                        
                         
                    }
                    // CUSTODIA COMPRAS
                    for (int i = 0; i < tblCUSTODIA_COMPRAS.Rows.Count; i = i + 2)
                    {
                        if (i + 1 < tblCUSTODIA_COMPRAS.Rows.Count)
                        {
                            dSCustodia.CUSTODIA_COMPRA.AddCUSTODIA_COMPRARow(tblCUSTODIA_COMPRAS.Rows[i].Cells["CODIGO_COMPRA"].FormattedValue.ToString(), tblCUSTODIA_COMPRAS.Rows[i].Cells["CATEGORIA_COMPRA"].FormattedValue.ToString(), tblCUSTODIA_COMPRAS.Rows[i].Cells["NIVEL_COMPRA"].FormattedValue.ToString(),
                                    tblCUSTODIA_COMPRAS.Rows[i+1].Cells["CODIGO_COMPRA"].FormattedValue.ToString(), tblCUSTODIA_COMPRAS.Rows[i+1].Cells["CATEGORIA_COMPRA"].FormattedValue.ToString(), tblCUSTODIA_COMPRAS.Rows[i+1].Cells["NIVEL_COMPRA"].FormattedValue.ToString());
                        }
                        else
                        {
                            dSCustodia.CUSTODIA_COMPRA.AddCUSTODIA_COMPRARow(tblCUSTODIA_COMPRAS.Rows[i].Cells["CODIGO_COMPRA"].FormattedValue.ToString(), tblCUSTODIA_COMPRAS.Rows[i].Cells["CATEGORIA_COMPRA"].FormattedValue.ToString(), tblCUSTODIA_COMPRAS.Rows[i].Cells["NIVEL_COMPRA"].FormattedValue.ToString(),null,null,null);
                        }
                        
                        

                    }
                    bsCustodiaPrestamo.DataSource = dSCustodia.CUSTODIA_PRESTAMO;
                    bsCustodiaCompra.DataSource = dSCustodia.CUSTODIA_COMPRA;


                    ReportParameter[] parameters = new ReportParameter[7];
                    parameters[0] = new ReportParameter("numCUSTODIA", TRASLADO.DOCUMENTO);
                    parameters[1] = new ReportParameter("fechaEnvio", TRASLADO.FECHA.Date.ToShortDateString());
                    parameters[2] = new ReportParameter("origenSUC", DE.SUCURSAL);
                    parameters[3] = new ReportParameter("destinoSUC", HACIA.SUCURSAL);
                    parameters[4] = new ReportParameter("ENVIA", TRASLADO.ENVIA);
                    parameters[5] = new ReportParameter("TRASLADA", TRASLADO.TRASLADA);
                    parameters[6] = new ReportParameter("FechaImp", "Impresion: " + HOME.Instance().FECHA_SISTEMA.ToString("dd/MM/yyyy"));

                    viewerCUSTODIA.LocalReport.ReportEmbeddedResource = "PrendaSAL.Informes.CustodiaValores.rdlc";
                    viewerCUSTODIA.LocalReport.DataSources.Clear();
                    viewerCUSTODIA.LocalReport.DataSources.Add(new ReportDataSource("CUSTODIA_PRESTAMO", bsCustodiaPrestamo));
                    viewerCUSTODIA.LocalReport.DataSources.Add(new ReportDataSource("CUSTODIA_COMPRA", bsCustodiaCompra));

                    viewerCUSTODIA.LocalReport.SetParameters(parameters);
                    viewerCUSTODIA.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detalle: \n" + ex.Message, "ERROR AL IMPRIMIR CUSTODIA DE VALORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }




        private void ShowPrintDialogCUSTODIA(object sender, RenderingCompleteEventArgs e)
        {
            if (e != null)
            {
                viewerCUSTODIA.PrintDialog();
            }
        }




    }
}
