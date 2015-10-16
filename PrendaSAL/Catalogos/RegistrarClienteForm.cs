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
    using MODELO;
    using DDB;

    public partial class RegistrarClienteForm : Form
    {
        //VARIABLES
        private DBUsuario dbUser;
        private DBCliente dbCliente;
        private DBSucursal dbSucursal;
        private DBPRENDASAL dbPredasal;

        private Cliente SELECTED;
        private eOperacion ACCION;

        public RegistrarClienteForm()
        {
            InitializeComponent();
            ACCION = eOperacion.INSERT;
            btnSCAN.Enabled = false;
        }

        public RegistrarClienteForm(Cliente cliente)
        {
            InitializeComponent();
            ACCION = eOperacion.UPDATE;
            SELECTED = cliente;
            btnSCAN.Enabled = true;
        }


        private void permisos_FORM()
        {
            switch (HOME.Instance().USUARIO.TIPO)
            {
                case eTipoUsuario.ASESOR:
                    
                    break;
                default:
                    
                    break;
            }
        }

        private void RegistrarClienteForm_Load(object sender, EventArgs e)
        {
            dbPredasal = new DBPRENDASAL();
            dbSucursal = new DBSucursal();
            dbUser = new DBUsuario();
            dbCliente = new DBCliente();

            permisos_FORM();
            
            dateINICIO.Enabled = false;
            cbxTIPODOC.DataSource = Enum.GetValues(new eTipoDocCliente().GetType());
            DataTable deptos = dbPredasal.getDeptos();
            if (deptos.Rows.Count > 0)
            {
                DataRow rowD = deptos.NewRow();
                rowD.SetField<string>("DEPTO", "Seleccione Depto");
                deptos.Rows.InsertAt(rowD, 0);
            }
            else
            {
                deptos.Columns.Add("DEPTO");
                deptos.Rows.Add("Seleccione Depto");
            }
            cbxDEPTO.DataSource = deptos;
            if (deptos.Rows.Count > 0)
            {
                cbxDEPTO.DisplayMember = "DEPTO";
                cbxDEPTO.SelectedIndex = 0;
            }
            DataTable MUNI = dbPredasal.getMunicipios(null);
            if (MUNI.Rows.Count > 0)
            {
                DataRow rowM = MUNI.NewRow();
                rowM.SetField<string>("COD_MUNICIPIO", "XXXX");
                rowM.SetField<string>("MUNICIPIO", "-------");
                MUNI.Rows.InsertAt(rowM, 0);
            }

            cbxEXT.DataSource = MUNI;
            if (MUNI.Rows.Count > 0)
            {
                cbxEXT.DisplayMember = "MUNICIPIO";
                cbxEXT.ValueMember = "COD_MUNICIPIO";
                cbxEXT.SelectedIndex = 0;
            }
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    txtCODIGO.Text = "N/A";
                    dateINICIO.Value = HOME.Instance().FECHA_SISTEMA;
                    dateNAC.Value = HOME.Instance().FECHA_SISTEMA.AddYears(-18);
                    break;
                case eOperacion.UPDATE:
                    cargarCLIENTE();
                    break;
            }
        }



        private bool validar()
        {
            bool OK = true;
            
            if (txtCLIENTE.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Ingrese nombre del cliente","ERROR DE VALIDACION DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return OK;
            }
            if(dateNAC.Value != null){
                int edad = DateTime.Today.AddTicks(-dateNAC.Value.Date.Ticks).Year - 1;
                if (edad < 18)
                {
                    OK = false;
                    MessageBox.Show("Cliente debe ser mayor de edad", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }
            }
            if (txtDOC.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Ingrese documento de identificacion del cliente", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (ckM.Checked && ckF.Checked)
            {
                OK = false;
                MessageBox.Show("Especifique sexo del cliente", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (cbxEXT.SelectedIndex == 0)
            {
                OK = false;
                MessageBox.Show("Indique lugar de Expedicion del documento", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (txtTEL.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Telefono del cliente requerido", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (txtPROFESION.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Especifique Profesion del cliente", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (cbxDEPTO.SelectedIndex == 0 || cbxMUNICIPIO.SelectedIndex == 0)
            {
                OK = false;
                MessageBox.Show("Especifique domicilio actual del cliente", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            if (txtDIRECCION.Text.Trim() == string.Empty)
            {
                OK = false;
                MessageBox.Show("Ingrese direccion actual del cliente", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return OK;
            }
            switch((eTipoDocCliente)cbxTIPODOC.SelectedItem)
            {
                case eTipoDocCliente.DUI:
                    if (txtDOC.Text.Trim().Length != 10)
                    {
                        OK = false;
                        MessageBox.Show("El DUI debe ser un numero de 10 digitos", "ERROR DE VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return OK;
                    }
                    break;
                case eTipoDocCliente.LICENCIA:

                    break;
                case eTipoDocCliente.PASAPORTE:

                    break;
                case eTipoDocCliente.CARNET:

                    break;
            }
            return OK;
        }


        public Cliente buildCLIENTE()
        {
            Cliente c = new Cliente();
            c.FECHA_INICIO = dateINICIO.Value;
            c.CLIENTE = txtCLIENTE.Text;
            if (ckF.Checked) { c.SEXO = eSexo.FEMENINO; }
            else if (ckM.Checked) { c.SEXO = eSexo.MASCULINO; }
            c.PROFESION = txtPROFESION.Text;
            c.FECHA_NAC = dateNAC.Value.Date;
            eTipoDocCliente tipo = (eTipoDocCliente) cbxTIPODOC.SelectedValue;
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    switch ((eTipoDocCliente)cbxTIPODOC.SelectedValue)
                    {
                        case eTipoDocCliente.DUI:
                            c.DUI = txtDOC.Text;
                            break;
                        case eTipoDocCliente.LICENCIA:
                            c.LICENCIA = txtDOC.Text;
                            break;
                        case eTipoDocCliente.PASAPORTE:
                            c.PASAPORTE = txtDOC.Text;
                            break;
                        case eTipoDocCliente.CARNET:
                            c.CARNET = txtDOC.Text;
                            break;
                    }
                    break;
                case eOperacion.UPDATE:
                    switch ((eTipoDocCliente)cbxTIPODOC.SelectedValue)
                    {
                        case eTipoDocCliente.DUI:
                            c.DUI = txtDOC.Text;
                            c.LICENCIA = SELECTED.LICENCIA;
                            c.PASAPORTE = SELECTED.PASAPORTE;
                            c.CARNET = SELECTED.CARNET;
                            break;
                        case eTipoDocCliente.LICENCIA:
                            c.DUI = SELECTED.DUI;
                            c.LICENCIA = txtDOC.Text;
                            c.PASAPORTE = SELECTED.PASAPORTE;
                            c.CARNET = SELECTED.CARNET;
                            break;
                        case eTipoDocCliente.PASAPORTE:
                            c.DUI = SELECTED.DUI;
                            c.LICENCIA = SELECTED.LICENCIA;
                            c.PASAPORTE = txtDOC.Text;
                            c.CARNET = SELECTED.CARNET;
                            break;
                        case eTipoDocCliente.CARNET:
                            c.DUI = SELECTED.DUI;
                            c.LICENCIA = SELECTED.LICENCIA;
                            c.PASAPORTE = SELECTED.PASAPORTE;
                            c.CARNET = txtDOC.Text;
                            break;
                    }
                    break;
            }
            if (cbxEXT.SelectedIndex > 0)
            {
                c.EXT = (string)cbxEXT.SelectedValue;
            }
            c.FECHA_VENC = dateFechaVenc.Value;
            
            c.TEL = txtTEL.Text;
            c.EMAIL = txtEMAIL.Text;
            if (cbxMUNICIPIO.SelectedIndex > 0)
            {
                c.COD_MUNICIPIO = (string)cbxMUNICIPIO.SelectedValue;
            }
            c.DIRECCION = txtDIRECCION.Text;
            c.CONTACTO = txtEMPRESA.Text;
            c.TEL_CONTACTO = txtTELEMP.Text;
            c.NOTA = txtNOTA.Text;
            c.COD_SUC = HOME.Instance().SUCURSAL.COD_SUC;
            return c;
        }



        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void GUARDAR_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            switch (ACCION)
            {
                case eOperacion.INSERT:
                    if (validar())
                    {
                        c = buildCLIENTE();
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            if (dbCliente.insert(c, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                ClientesForm.Instance().cargarDatos();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        
                    }
                    break;
                case eOperacion.UPDATE:
                    if (validar())
                    {
                        c = buildCLIENTE();
                        c.COD_CLIENTE = SELECTED.COD_CLIENTE;
                        string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                        if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                        {
                            c.FECHA_INICIO = HOME.Instance().FECHA_SISTEMA;
                            if (dbCliente.update(c, HOME.Instance().SUCURSAL.COD_SUC, HOME.Instance().USUARIO.COD_EMPLEADO, HOME.Instance().SISTEMA))
                            {
                                //ClientesForm.Instance().CARTERA = dbCliente.findByCodigo(c.COD_CLIENTE);
                                ClientesForm.Instance().cargarDatos();
                                this.Close();
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




        private void cargarCLIENTE()
        {
            if (SELECTED != null)
            {
                txtCODIGO.Text = SELECTED.COD_CLIENTE;
                dateINICIO.Value = SELECTED.FECHA_INICIO;
               
                txtCLIENTE.Text = SELECTED.CLIENTE;
                if (SELECTED.SEXO == null || SELECTED.SEXO == eSexo.MASCULINO)
                {
                    ckM.Checked = true;
                }
                else if (SELECTED.SEXO == eSexo.FEMENINO)
                {
                    ckF.Checked = true;
                }
                if (SELECTED.FECHA_NAC != null)
                {
                    dateNAC.Value = SELECTED.FECHA_NAC.Value;
                }
                else
                {
                    dateNAC.Value = HOME.Instance().FECHA_SISTEMA.AddYears(-18);
                }
                if (SELECTED.DUI != null && SELECTED.DUI != "")
                {
                    cbxTIPODOC.SelectedItem = eTipoDocCliente.DUI;
                    txtDOC.Text = SELECTED.DUI;
                }
                else if (SELECTED.LICENCIA != null && SELECTED.LICENCIA != string.Empty)
                {
                    cbxTIPODOC.SelectedItem = eTipoDocCliente.LICENCIA;
                    txtDOC.Text = SELECTED.LICENCIA;
                }
                else if (SELECTED.PASAPORTE != null && SELECTED.PASAPORTE != string.Empty)
                {
                    cbxTIPODOC.SelectedItem = eTipoDocCliente.PASAPORTE;
                    txtDOC.Text = SELECTED.PASAPORTE;
                }
                else if (SELECTED.CARNET != null && SELECTED.CARNET != string.Empty)
                {
                    cbxTIPODOC.SelectedItem = eTipoDocCliente.CARNET;
                    txtDOC.Text = SELECTED.CARNET;
                }
                if (SELECTED.EXT != null && SELECTED.EXT != string.Empty)
                {
                    cbxEXT.SelectedValue = SELECTED.EXT;
                }
                else
                {
                    cbxEXT.SelectedIndex = 0;
                } 
                if (SELECTED.FECHA_VENC != null)
                {
                    dateFechaVenc.Value = SELECTED.FECHA_VENC.Value;
                }
                else
                {
                    dateFechaVenc.Value = HOME.Instance().FECHA_SISTEMA;
                }
                
                txtTEL.Text = SELECTED.TEL;
                txtPROFESION.Text = SELECTED.PROFESION;
                txtEMPRESA.Text = SELECTED.CONTACTO;
                txtTELEMP.Text = SELECTED.TEL_CONTACTO;
                txtEMAIL.Text = SELECTED.EMAIL;
                if (SELECTED.COD_MUNICIPIO != null)
                {
                    cbxDEPTO.Text = SELECTED.DEPTO;
                    cbxMUNICIPIO.SelectedValue = SELECTED.COD_MUNICIPIO;
                }
                else
                {
                    cbxDEPTO.SelectedIndex = 0;
                }
                txtDIRECCION.Text = SELECTED.DIRECCION;
                txtNOTA.Text = SELECTED.NOTA;
            }
        }




        private void cbmDEPTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDEPTO.SelectedIndex > 0)
            {
                DataTable MUNI = dbPredasal.getMunicipios(cbxDEPTO.Text);
                cbxMUNICIPIO.DataSource = MUNI;
                if (MUNI.Rows.Count > 0)
                {
                    DataRow rowM = MUNI.NewRow();
                    rowM.SetField<string>("COD_MUNICIPIO", "XXXX");
                    rowM.SetField<string>("MUNICIPIO", "-------");
                    MUNI.Rows.InsertAt(rowM, 0);
                    cbxMUNICIPIO.ValueMember = "COD_MUNICIPIO";
                }
                cbxMUNICIPIO.DisplayMember = "MUNICIPIO";
                cbxMUNICIPIO.SelectedIndex = 0;
            }
            else
            {
                cbxMUNICIPIO.DataSource = null;
            }
        }




        private void cbmTIPODOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ACCION)
            {
                case eOperacion.INSERT:

                    break;
                case eOperacion.UPDATE:
                    switch ((eTipoDocCliente)cbxTIPODOC.SelectedValue)
                    {
                        case eTipoDocCliente.DUI:
                            txtDOC.Text = SELECTED.DUI;
                            break;
                        case eTipoDocCliente.LICENCIA:
                            txtDOC.Text = SELECTED.LICENCIA;
                            break;
                        case eTipoDocCliente.PASAPORTE:
                            txtDOC.Text = SELECTED.PASAPORTE;
                            break;
                        case eTipoDocCliente.CARNET:
                            txtDOC.Text = SELECTED.CARNET;
                            break;
                    }
                    break;
            }
        }




    }
}
