using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlesPersonalizados;
using System.Windows.Forms;

namespace PrendaSAL.Operaciones
{
    using MODELO;
    using DDB;

    public partial class TrasladoForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static TrasladoForm frmInstance = null;

        public static TrasladoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new TrasladoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBTraslado dbTraslado;
        private DBInventario dbInventario;
        private Traslado TRASLADO;
        private Traslado SELECTED;

        private eOperacion ACCION;

        public TrasladoForm()
        {
            InitializeComponent();
            dbTraslado = new DBTraslado();
            dbInventario = new DBInventario();
        }

        private void permisos()
        {
            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P16")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnAnular.Visible = p.Field<bool>("ANULAR");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscar.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                    btnReimprimir.Visible = p.Field<bool>("REIMPRIMIR");
                }
            }

            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.Enabled = true;
            }
        
        }

        private void EnviarInvForm_Load(object sender, EventArgs e)
        {
            permisos();
            tblCUSTODIA_PRESTAMOS.AutoGenerateColumns = false;
            tblCUSTODIA_COMPRAS.AutoGenerateColumns = false;
            tblREMISION.AutoGenerateColumns = false;

            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            cbxDESTINO.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxDESTINO.DisplayMember = "SUCURSAL";
                cbxDESTINO.ValueMember = "COD_SUC";
                cbxDESTINO.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            bloquear();
            NUEVO(null, null);
        }



        private void bloquear()
        {
            grbTraslado.Enabled = false;
            tblREMISION.ReadOnly = true;
            btnADD.Enabled = false;
            btnDEL.Enabled = false;
            txtNOTA.ReadOnly = true;
        }


        private void desbloquear()
        {
            grbTraslado.Enabled = true;
            tblREMISION.ReadOnly = false;
            btnADD.Enabled = true;
            btnDEL.Enabled = true;
            txtNOTA.ReadOnly = false;
        }


        private void limpiarDatosTraslado()
        {
            dateEnvio.Value = HOME.Instance().FECHA_SISTEMA;
            txtDOCUMENTO.Text = string.Empty;
            txtASESOR.Text = string.Empty;
            txtTRASLADA.Text = string.Empty;
            txtRECIBE.Text = string.Empty;
            txtNOTA.Text = string.Empty;
        }


        private void cbxSUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.ValueMember != "" && cbxSUCURSAL.SelectedIndex >= 0)
            {
                switch (ACCION)
                {
                    case eOperacion.INSERT:
                        TRASLADO.SUC_ENVIA = (string)cbxSUCURSAL.SelectedValue;
                        TRASLADO.DOCUMENTO = dbTraslado.nextNotaTraslado(TRASLADO.TIPO, TRASLADO.SUC_ENVIA);
                        txtDOCUMENTO.Text = TRASLADO.DOCUMENTO;
                        break;

                }
            }

        }

        private void NUEVO(object sender, EventArgs e)
        {
            ACCION = eOperacion.INSERT;
            TRASLADO = new Traslado();
            TRASLADO.FECHA = HOME.Instance().FECHA_SISTEMA;
            TRASLADO.TIPO = eTipoTraslado.CUSTODIA_VALORES;
            TRASLADO.SUC_ENVIA = HOME.Instance().SUCURSAL.COD_SUC;
            TRASLADO.SUC_DEST = HOME.Instance().SUCURSAL.COD_SUC;
            TRASLADO.DOCUMENTO = dbTraslado.nextNotaTraslado(TRASLADO.TIPO,TRASLADO.SUC_ENVIA);
            TRASLADO.ENVIA = HOME.Instance().USUARIO.NOMBRE;

            cargarDatosTraslado();
            desbloquear();
            txtTRASLADA.Focus();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLog.Enabled = false;
            btnReimprimir.Enabled = false;

        }





        private void cargarDatosTraslado()
        {
            limpiarDatosTraslado();
            if (TRASLADO != null)
            {
                cbxSUCURSAL.SelectedValue = TRASLADO.SUC_ENVIA;
                cbxDESTINO.SelectedValue = TRASLADO.SUC_DEST;
                txtDOCUMENTO.Text = TRASLADO.DOCUMENTO;
                dateEnvio.Value = TRASLADO.FECHA;
                txtASESOR.Text = TRASLADO.ENVIA;
                txtTRASLADA.Text = TRASLADO.TRASLADA;
                txtRECIBE.Text = TRASLADO.RECIBE;
                txtNOTA.Text = TRASLADO.NOTA;
                lbESTADO.Text = TRASLADO.ESTADO_TRASLADO.ToString();

                switch (TRASLADO.ESTADO_TRASLADO)
                {
                    case eEstadoTraslado.RECIBIDO:
                        lbESTADO.ForeColor = Color.Blue;
                        break;
                    case eEstadoTraslado.PENDIENTE:
                        lbESTADO.ForeColor = Color.Crimson;
                        break;
                }

                switch (TRASLADO.TIPO)
                {
                    case eTipoTraslado.CUSTODIA_VALORES:
                        tabDETALLE.SelectedTab = pagCUSTODIA;
                        cargarCustodia();
                        break;
                    case eTipoTraslado.NOTA_REMISION:
                        tabDETALLE.SelectedTab = pagREMISION;
                        tblREMISION.DataSource = TRASLADO.REMISION;
                        break;
                }
                
            }
        }


        private void cargarCustodia()
        {
            DataTable PRESTAMOS = TRASLADO.CUSTODIA.Copy();
            DataTable COMPRAS = TRASLADO.CUSTODIA.Copy();
            if (PRESTAMOS.Rows.Count > 0)
            {
                PRESTAMOS.DefaultView.RowFilter = "TRANS LIKE 'PRESTAMO'";
            }
            if (COMPRAS.Rows.Count > 0)
            {
                COMPRAS.DefaultView.RowFilter = "TRANS LIKE 'COMPRA'";
            }
            tblCUSTODIA_PRESTAMOS.DataSource = PRESTAMOS.DefaultView;
            tblCUSTODIA_COMPRAS.DataSource = COMPRAS.DefaultView;
        }

        public void calcularTotales()
        {
            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:

                    break;
                case eTipoTraslado.NOTA_REMISION:
                    decimal total = TRASLADO.REMISION.AsEnumerable().Select(r => r.Field<decimal>("PRECIO")).Sum();
                    txtTOTAL.Text = total.ToString("C2");
                    break;
            }
        }






        private void tabDETALLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDETALLE.SelectedIndex >= 0)
            {
                switch (tabDETALLE.SelectedTab.Name)
                {
                    case "pagCUSTODIA":
                        TRASLADO.TIPO = eTipoTraslado.CUSTODIA_VALORES;
                        lbDOC.Text = "CUSTODIA";
                        break;
                    case "pagREMISION":
                        TRASLADO.TIPO = eTipoTraslado.NOTA_REMISION;
                        lbDOC.Text = "NOTA REMISION";
                        break;
                }
                calcularTotales();
            }
        }






        private void getDetalleTraslado(object sender, EventArgs e)
        {
            EnviarInvForm detalle = new EnviarInvForm(TRASLADO);
            detalle.ShowDialog();
        }


        public void updateTblREMISION()
        {
            tblREMISION.DataSource = TRASLADO.REMISION;
            calcularTotales();
        }


        public void updateTblCUSTODIA()
        {
            cargarCustodia();
            calcularTotales();
        }


        private void removeItemTraslado(object sender, EventArgs e)
        {
            switch (TRASLADO.TIPO)
            {
                case eTipoTraslado.CUSTODIA_VALORES:
                    
                    break;



                case eTipoTraslado.NOTA_REMISION:
                    if (TRASLADO.REMISION.Rows.Count > 0)
                    {
                        TRASLADO.REMISION.Rows.RemoveAt(tblREMISION.CurrentCell.RowIndex);
                        calcularTotales();
                    }
                    break;
            }
            
        }



        private void tblREMISION_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && tblREMISION.Columns[e.ColumnIndex].Name == "NUM_RM") {
                e.Value = e.RowIndex + 1;
            }
        }


        private bool validarTraslado()
        {
            bool OK = true;
            if (TRASLADO.DOCUMENTO == null && TRASLADO.DOCUMENTO.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("DOCUMENTO INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxSUCURSAL.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL DE ORIGEN", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxDESTINO.SelectedIndex < 0)
            {
                OK = false;
                MessageBox.Show("SELECCIONE SUCURSAL DE DESTINO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTRASLADA.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("INGRESE PERSONA RESPONSABLE DEL TRASLADO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (TRASLADO.TIPO)
                {
                    case eTipoTraslado.CUSTODIA_VALORES:
                        
                        break;
                    case eTipoTraslado.NOTA_REMISION:
                        if (TRASLADO.REMISION.Rows.Count <= 0)
                        {
                            OK = false;
                            MessageBox.Show("SELECCIONE ARTICULOS A TRASLADAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }

            }
            return OK;
        }




        private void GUARDAR(object sender, EventArgs e)
        {
            TRASLADO.SUC_ENVIA = (string)cbxSUCURSAL.SelectedValue;
            TRASLADO.SUC_DEST = (string)cbxDESTINO.SelectedValue;
            TRASLADO.FECHA = dateEnvio.Value;
            TRASLADO.TRASLADA = txtTRASLADA.Text.Trim();
            TRASLADO.NOTA = txtNOTA.Text.Trim();

            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validarTraslado())
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbTraslado.insert(TRASLADO, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                //SELECTED =
                                IMPRIMIR(null, null);
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

        }

        private void EDITAR(object sender, EventArgs e)
        {

        }

        private void ELIMINAR(object sender, EventArgs e)
        {

        }

        private void BUSCAR(object sender, EventArgs e)
        {
            
        }



        public bool buscarTraslado(string doc, eTipoTraslado tipo)
        {
            bool OK = false;
            SELECTED = Traslado.ConvertToTraslado(dbTraslado.getTrasladoByDocTipo(doc,tipo));
            if (SELECTED != null)
            {
                switch(SELECTED.TIPO)
                {
                    case eTipoTraslado.CUSTODIA_VALORES:

                        break;
                    case eTipoTraslado.NOTA_REMISION:
                        SELECTED.REMISION = dbTraslado.getItemsTraslado(SELECTED);
                        break;

                }
               
                TRASLADO = SELECTED.Copy();
                cargarDatosTraslado();
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

        }


        






    }
}
