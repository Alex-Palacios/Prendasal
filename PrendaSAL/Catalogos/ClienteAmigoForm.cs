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

namespace PrendaSAL.Catalogos
{
    using LOGICA;
    using MODELO;
    using DDB;

    public partial class ClienteAmigoForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static ClienteAmigoForm frmInstance = null;

        public static ClienteAmigoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ClienteAmigoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBUsuario dbUser;
        private DBTarjeta dbTarjeta;
        private DBCliente dbCliente;
        private DBPRENDASAL dbPrendasal;
        private eOperacion ACCION;
        public Cliente CLIENTE;
        public Reglas REGLAS;

        private Tarjeta SELECTED;
        

        public ClienteAmigoForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbTarjeta = new DBTarjeta();
            dbCliente = new DBCliente();
            dbPrendasal = new DBPRENDASAL();
        }

        private void ClienteAmigoForm_Load(object sender, EventArgs e)
        {
            cbxBuscarPorCLI.DataSource = Enum.GetValues(new eTipoDocCliente().GetType());

            NUEVO(null, null);
            txtDocCLI.Focus();
            permisos();
        }

        private void permisos()
        {
            btnNuevo.Visible = false;
            btnEditar.Visible = false;
            btnKey.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnLog.Visible = false;
            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P2")
                {
                    btnNuevo.Visible = p.Field<bool>("REGISTRAR");
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                    btnKey.Visible = p.Field<bool>("CLAVE");
                    btnEliminar.Visible = p.Field<bool>("ELIMINAR");
                    btnBuscar.Visible = p.Field<bool>("BUSCAR");
                    btnLog.Visible = p.Field<bool>("LOG");
                }
            }
        }





        private void bloquear()
        {
            txtDocCLI.ReadOnly = true;
            cbxBuscarPorCLI.Enabled = false;
            btnCLI.Enabled = false;
            txtNUMTARJETA.ReadOnly = true;
            dateExp.Enabled = false;
            dateVenc.Enabled = false;
            dateReno.Enabled = false;
            ckACTIVA.Enabled = false;
            grbPRESTACIONES.Enabled = false;
        }


        private void desbloquear()
        {
            txtDocCLI.ReadOnly = false;
            cbxBuscarPorCLI.Enabled = true;
            btnCLI.Enabled = true;
            txtNUMTARJETA.ReadOnly = false;
        }



        private void limpiarCliente()
        {
            txtCodigoCLI.Text = "";
            txtDocCLI.Text = "";
            txtExpCLI.Text = "";
            txtClienteCLI.Text = "";
            txtEdadCLI.Text = "";
            txtTelCLI.Text = "";
            txtDomicilioCLI.Text = "";
            txtDireccionCLI.Text = "";
        }


        private void limpiarTajeta()
        {
            txtNUMTARJETA.Text = "";
            dateExp.Value = HOME.Instance().FECHA_SISTEMA;
            dateVenc.Value = HOME.Instance().FECHA_SISTEMA.Date.AddYears(1);
            dateReno.Value = HOME.Instance().FECHA_SISTEMA;
            ckACTIVA.Checked = true;
            lbESTADO.Text = "AFILIAR CLIENTE";
            lbESTADO.ForeColor = Color.Black;
            txtPUNTOS_ACUMULADOS.Text = "0 PUNTOS";

        }



        public void cargarCliente()
        {
            if (CLIENTE != null)
            {
                txtCodigoCLI.Text = CLIENTE.COD_CLIENTE;
                txtClienteCLI.Text = CLIENTE.CLIENTE;
                if (CLIENTE.EDAD != null)
                {
                    txtEdadCLI.Text = CLIENTE.EDAD + " AÑOS";
                }
                else
                {
                    txtEdadCLI.Text = "N/A";
                }
                if (CLIENTE.DUI != null && CLIENTE.DUI != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.DUI;
                    txtDocCLI.Text = CLIENTE.DUI;
                }
                else if (CLIENTE.LICENCIA != null && CLIENTE.LICENCIA != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.LICENCIA;
                    txtDocCLI.Text = CLIENTE.LICENCIA;
                }
                else if (CLIENTE.PASAPORTE != null && CLIENTE.PASAPORTE != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.PASAPORTE;
                    txtDocCLI.Text = CLIENTE.PASAPORTE;
                }
                else if (CLIENTE.CARNET != null && CLIENTE.CARNET != "")
                {
                    cbxBuscarPorCLI.SelectedItem = eTipoDocCliente.CARNET;
                    txtDocCLI.Text = CLIENTE.CARNET;
                }
                if (CLIENTE.EXT != null)
                {
                    txtExpCLI.Text = CLIENTE.EXT;
                }
                else
                {
                    txtExpCLI.Text = "N/A";
                }
                txtTelCLI.Text = CLIENTE.TEL;
                if (CLIENTE.COD_MUNICIPIO != null)
                {
                    txtDomicilioCLI.Text = CLIENTE.DOMICILIO;
                }
                else
                {
                    txtDomicilioCLI.Text = "N/A";
                }
                txtDireccionCLI.Text = CLIENTE.DIRECCION;

                cargarParametros();
            }
            else
            {
                limpiarCliente();
                MessageBox.Show("CLIENTE NO ENCONTRADO", "Error al cargar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void cargarParametros()
        {
            REGLAS = Reglas.ConvertToReglas(dbPrendasal.getReglas(eNIVEL.AMIGO));
            if (REGLAS != null)
            {
                TasaMensual_AMIGO.Value = (decimal) REGLAS.TASA_MENSUAL;
                PlazoContrato_AMIGO.Value = REGLAS.PLAZO_CONTRATO;
                PlazoVencido_AMIGO.Value = REGLAS.PLAZO_VENCIDO;
                DescCompras_AMIGO.Value = (decimal)REGLAS.DESC_COMPRA;
                DescInteres_AMIGO.Value = (decimal)REGLAS.DESC_INTERES;
                PuntosDolar_AMIGO.Value = (decimal)REGLAS.PUNTOS_DOLAR;
                PuntosValor_AMIGO.Value = REGLAS.PUNTOS_VALOR;
            }
              
        }



        private void btnCLI_Click(object sender, EventArgs e)
        {
            Catalogos.ClientesForm cartera;
            cartera = Catalogos.ClientesForm.Instance(this.Name);
            cartera.StartPosition = FormStartPosition.CenterParent;
            cartera.ShowDialog(this);
            if (cartera.WindowState == FormWindowState.Minimized)
            {
                cartera.WindowState = FormWindowState.Normal;
            }
        }




        private void txtDocCLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtDocCLI.Text.Trim() != string.Empty)
            {
                CLIENTE = null;
                switch (cbxBuscarPorCLI.SelectedIndex)
                {
                    case 0: //DUI
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByDui(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 0;
                            txtDocCLI.Text = CLIENTE.DUI;
                        }
                        break;
                    case 1: //LICENCIA
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByLicencia(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 1;
                            txtDocCLI.Text = CLIENTE.LICENCIA;
                        }
                        break;
                    case 2://PASAPORTE
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByPasaporte(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 2;
                            txtDocCLI.Text = CLIENTE.PASAPORTE;
                        }
                        break;
                    case 3://CARNET
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByCarnet(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 3;
                            txtDocCLI.Text = CLIENTE.CARNET;
                        }
                        break;
                    case 4: //CODIGO
                        CLIENTE = Cliente.ConvertToCliente(dbCliente.findByCodigo(txtDocCLI.Text.Trim()));
                        cargarCliente();
                        if (CLIENTE != null)
                        {
                            cbxBuscarPorCLI.SelectedIndex = 4;
                            txtDocCLI.Text = CLIENTE.COD_CLIENTE;
                        }
                        break;
                    case 5: //TARJETA

                        break;
                }
                e.Handled = true;
            }
        }


        private void cargarTarjetaSelected()
        {
            if (SELECTED != null)
            {
                limpiarCliente();
                limpiarTajeta();
                bloquear();
               // CLIENTE = SELECTED.CLIENTE;
                cargarCliente();
                txtNUMTARJETA.Text = SELECTED.NUMTARJETA;
                dateExp.Value = SELECTED.FECHA_EXP;
                dateReno.Value = SELECTED.FECHA_RENO;
                dateVenc.Value = SELECTED.FECHA_VENC;
                ckACTIVA.Checked = SELECTED.ACTIVA;
                txtPUNTOS_ACUMULADOS.Text = SELECTED.PUNTOS_ACUMULADOS + " PUNTOS";
                lbESTADO.Text = SELECTED.ESTADO_TARJETA;
                switch (SELECTED.ESTADO_TARJETA)
                {
                    case "VIGENTE":
                        lbESTADO.ForeColor = Color.Green;
                        break;
                    case "VENCIDA":
                        lbESTADO.ForeColor = Color.Red;
                        break;
                    case "INACTIVA":
                        lbESTADO.ForeColor = Color.Orange;
                        break;
                }
                TasaMensual_AMIGO.Value = (decimal)SELECTED.TASA_MENSUAL;
                PlazoContrato_AMIGO.Value = SELECTED.PLAZO_CONTRATO;
                PlazoVencido_AMIGO.Value = SELECTED.PLAZO_VENCIDO;
                DescCompras_AMIGO.Value = (decimal)SELECTED.DESC_COMPRA;
                DescInteres_AMIGO.Value = (decimal)SELECTED.DESC_INTERES;
                PuntosDolar_AMIGO.Value = (decimal)SELECTED.PUNTOS_DOLAR;
                PuntosValor_AMIGO.Value = SELECTED.PUNTOS_VALOR;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }


        public void NUEVO(object sender, EventArgs e)
        {
            SELECTED = null;
            ACCION = eOperacion.INSERT;
            limpiarCliente();
            limpiarTajeta();
            desbloquear();
            cargarParametros();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            dateExp.Enabled = true;
            dateVenc.Enabled = true;
            
        }


        public bool validarTarjeta()
        {
            bool OK = true;
            try
            {
                if (CLIENTE == null || txtCodigoCLI.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Seleccione Cliente AMIGO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                else if (txtNUMTARJETA.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("NUMERO DE TARJETA INVALIDO", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
                
            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR TARJETA AMIGO", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }





        private Tarjeta buildTARJETA()
        {
            Tarjeta t = new Tarjeta();
            t.NUMTARJETA = txtNUMTARJETA.Text;
            t.COD_CLIENTE = CLIENTE.COD_CLIENTE;
            t.FECHA_EXP = dateExp.Value;
            t.TIPO = eNIVEL.AMIGO;
            t.FECHA_RENO = dateReno.Value;
            t.FECHA_VENC = dateVenc.Value;
            t.TASA_MENSUAL = TasaMensual_AMIGO.Value;
            t.PLAZO_CONTRATO = (int)PlazoContrato_AMIGO.Value;
            t.PLAZO_VENCIDO = (int) PlazoVencido_AMIGO.Value;
            t.DESC_COMPRA = DescCompras_AMIGO.Value;
            t.DESC_INTERES = DescInteres_AMIGO.Value;
            t.PUNTOS_DOLAR = (int)PuntosDolar_AMIGO.Value;
            t.PUNTOS_VALOR = PuntosValor_AMIGO.Value;
            t.ACTIVA = ckACTIVA.Checked;
            return t;
        }




        private void GUARDAR(object sender, EventArgs e)
        {
            Tarjeta t = new Tarjeta();
            switch (ACCION)
                {
                    case eOperacion.INSERT:
                        if (validarTarjeta())
                        {
                            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                            {
                                t = buildTARJETA();
                                //if (dbTarjeta.registrarTarjeta(t, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                //{
                                //    buscarTarjeta(t.NUMTARJETA);
                                //}
                            }
                            else
                            {
                                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        break;
                    case eOperacion.UPDATE:
                        if (validarTarjeta())
                        {
                            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                            {
                                t = buildTARJETA();
                                string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                                if (cambioNota.Trim() != "")
                                {
                                    t.NUMTARJETA = SELECTED.NUMTARJETA;
                                    //if (dbTarjeta.editarTarjeta(t, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                    //{
                                    //    buscarTarjeta(t.NUMTARJETA);
                                    //}
                                }
                                else
                                {
                                    MessageBox.Show("INGRESE UNA NOTA ACLARATORIA DE LA MODIFICACION", "REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    NUEVO(null, null);
                    break;
                case eOperacion.UPDATE:
                    cargarTarjetaSelected();
                    bloquear();
                    break;
            }
        }



        private void EDITAR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.UPDATE;
                grbPRESTACIONES.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                desbloquear();
                txtNUMTARJETA.ReadOnly = true;
                dateVenc.Enabled = true;
                ckACTIVA.Enabled = true;
            }
        }



        private void CAMBIAR_KEY(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.UPDATE;
                string newCodigo = Controles.InputBox("CODIGO ACTUAL : " + SELECTED.NUMTARJETA + "\nINGRESE NUEVO CODIGO:","CAMBIO DE NUMERO DE TARJETA");
                if (newCodigo.Trim() != "" )
                {
                    DialogResult r = MessageBox.Show("Seguro que desea cambiar el codigo el numero de la tarjeta ... Tenga en cuenta que se realizará una actuaizacion en CASCADA", "Confirmar Cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                            if (cambioNota.Trim() != "")
                            {
                                //if (dbTarjeta.cambiarNUMTARJETA(SELECTED.NUMTARJETA, newCodigo, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                                //{
                                //    buscarTarjeta(newCodigo);
                                //}
                            }

                        }
                    }
                }
            }
        }




        private void ELIMINAR(object sender, EventArgs e)
        {
            if (SELECTED != null)
            {
                ACCION = eOperacion.DELETE;
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la Tarjeta AMIGO # " + SELECTED.NUMTARJETA.ToString()  +" EXPEDIDA EL:" + SELECTED.FECHA_EXP.Date.ToString("dd/MM/yyyy") + " ?", "ELIMINAR TARJETA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminar == DialogResult.Yes)
                {
                    string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                    if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                    {
                        string cambioNota = Controles.InputBox("NOTA", "CAMBIO DETECTADO");
                        if (cambioNota.Trim() != "")
                        {
                            //if (dbTarjeta.eliminarTarjeta(SELECTED, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            //{
                            //    NUEVO(null, null);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("INGRESE UNA NOTA ACLARATORIA DE LA ELIMINACION", "REQUERIDO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            //}
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }

        }





        public void buscarTarjeta(string numero)
        {
            try
            {
                //SELECTED = dbTarjeta.findByNumTarjetaAMIGO(numero);
                if (SELECTED != null)
                {
                    cargarTarjetaSelected();
                }
            }
            catch (Exception ex) { }
        }



        private void BUSCAR(object sender, EventArgs e)
        {
            string numTAR = Controles.InputBox("NUMERO DE DOCUMENTO :", "AUTORIZACION");
            if (numTAR != "")
            {
                //SELECTED = dbTarjeta.findByNumTarjetaAMIGO(numTAR);
                if (SELECTED != null)
                {
                    cargarTarjetaSelected();
                    MessageBox.Show("TARJETA AMIGO # " + SELECTED.NUMTARJETA + " CARGADA", "ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("TARJETA AMIGO NO ENCONTRADA", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
