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
    using DDB;
    using MODELO;

    public partial class VencidosForm : Form
    {
        
        //VARIABLES
        private DBPrestamo dbContrato;
        private DataTable LISTA_VENCIDOS;
        private DataTable CERRAR;
        private DataTable SUCURSALES;

        public VencidosForm()
        {
            InitializeComponent();
            dbContrato = new DBPrestamo();
        }

        private void permisos()
        {
            if (HOME.Instance().USUARIO.TIPO != eTipoUsuario.ASESOR)
            {
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                cbxSUCURSAL.Enabled = false;
            }
            else
            {
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                cbxSUCURSAL.Enabled = true;
            }
        }



        private void VencidosForm_Load(object sender, EventArgs e)
        {
            tblVENCIDOS.AutoGenerateColumns = false;
            SUCURSALES = HOME.Instance().datSUCURSALES.Copy();
            if (SUCURSALES.Rows.Count == 0)
            {
                SUCURSALES.Columns.Add("CODIGO");
                SUCURSALES.Columns.Add("SUCURSAL");
                SUCURSALES.Columns.Add("ACTIVA");
                SUCURSALES.Columns.Add("ID_RUBRO");
            }
            cbxSUCURSAL.DataSource = SUCURSALES;
            if (SUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
            }
            permisos();
        }




        private void desbloquear()
        {
            tblVENCIDOS.ReadOnly = false;
            tblVENCIDOS.Columns["CHECK"].ReadOnly = false;
            tblVENCIDOS.Columns["FECHA"].ReadOnly = true;
            tblVENCIDOS.Columns["DOCUMENTO"].ReadOnly = true;
            tblVENCIDOS.Columns["CLIENTE"].ReadOnly = true;
            tblVENCIDOS.Columns["ARTICULO"].ReadOnly = true;
            tblVENCIDOS.Columns["TOTAL"].ReadOnly = true;
            tblVENCIDOS.Columns["TELEFONO"].ReadOnly = true;
            tblVENCIDOS.Columns["ESTADO"].ReadOnly = true;
            tblVENCIDOS.Columns["PLAZO_VENC"].ReadOnly = true;
            tblVENCIDOS.Columns["DIAS_TRANS"].ReadOnly = true;
        }




        private void bloquear()
        {
            tblVENCIDOS.ReadOnly = true;
        }


        private void tblVENCIDOS_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblVENCIDOS.DataSource != null)
            {
                lbTOTAL.Text = tblVENCIDOS.Rows.Count +" CONTRATOS";
            }
            else
            {
                lbTOTAL.Text = "0 CONTRATOS";
            }
        }




        private void btnLISTAR_Click(object sender, EventArgs e)
        {
            if (cbxSUCURSAL.SelectedIndex >= 0)
            {
                //LISTA_VENCIDOS = dbContrato.CONTRATOS_VENCIDOS_PLAZO((string)cbxSUCURSAL.SelectedValue, Int32.Parse(numDIAS.Value.ToString()));
                CERRAR = LISTA_VENCIDOS.Copy();
                CERRAR.Clear();
                desbloquear();
                tblVENCIDOS.DataSource = LISTA_VENCIDOS;
                if (LISTA_VENCIDOS.Rows.Count == 0)
                {
                    MessageBox.Show("NO HAY CONTRATOS VENCIDOS");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Sucursal", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void limpiar()
        {
            if (LISTA_VENCIDOS != null)
            {
                LISTA_VENCIDOS.Clear();
            }
            if (CERRAR != null)
            {
                CERRAR.Clear();
            }
        }



        private void listarVencidos()
        {
            CERRAR = LISTA_VENCIDOS.Copy();
            CERRAR.Clear();
            foreach (DataGridViewRow row in tblVENCIDOS.Rows)
            {
                bool LISTAR = (bool)row.Cells["CHECK"].FormattedValue;
                if (LISTAR)
                {
                    DataRow nuevo = CERRAR.NewRow();
                    nuevo.SetField<int>("ID_PRESTAMO", LISTA_VENCIDOS.Rows[row.Index].Field<int>("ID_PRESTAMO"));
                    nuevo.SetField<string>("COD_TRANS", LISTA_VENCIDOS.Rows[row.Index].Field<string>("COD_TRANS"));
                    nuevo.SetField<string>("RESPONSABLE", LISTA_VENCIDOS.Rows[row.Index].Field<string>("RESPONSABLE"));
                    nuevo.SetField<string>("COD_SUC", LISTA_VENCIDOS.Rows[row.Index].Field<string>("COD_SUC"));
                    nuevo.SetField<string>("SUCURSAL", LISTA_VENCIDOS.Rows[row.Index].Field<string>("SUCURSAL"));
                    nuevo.SetField<DateTime>("FECHA", LISTA_VENCIDOS.Rows[row.Index].Field<DateTime>("FECHA"));
                    nuevo.SetField<string>("DOCUMENTO", LISTA_VENCIDOS.Rows[row.Index].Field<string>("DOCUMENTO"));
                    nuevo.SetField<string>("COD_CLIENTE", LISTA_VENCIDOS.Rows[row.Index].Field<string>("COD_CLIENTE"));
                    nuevo.SetField<string>("CLIENTE", LISTA_VENCIDOS.Rows[row.Index].Field<string>("CLIENTE"));
                    nuevo.SetField<string>("ARTICULO", LISTA_VENCIDOS.Rows[row.Index].Field<string>("ARTICULO"));
                    nuevo.SetField<decimal>("TOTAL", LISTA_VENCIDOS.Rows[row.Index].Field<decimal>("TOTAL"));
                    nuevo.SetField<decimal>("SALDO", LISTA_VENCIDOS.Rows[row.Index].Field<decimal>("SALDO"));
                    nuevo.SetField<string>("ESTADO_CONTRATO", LISTA_VENCIDOS.Rows[row.Index].Field<string>("ESTADO_CONTRATO"));
                    nuevo.SetField<int>("PLAZO_VENC", LISTA_VENCIDOS.Rows[row.Index].Field<int>("PLAZO_VENC"));
                    nuevo.SetField<Int64>("DIAS_TRANS", LISTA_VENCIDOS.Rows[row.Index].Field<int>("DIAS_TRANS"));
                    CERRAR.Rows.Add(nuevo);
                }
            }
            lbCheck.Text = CERRAR.Rows.Count + " SELECCIONADOS";
        }



        private bool isListado(int id)
        {
            bool OK = false;
            foreach (DataRow row in CERRAR.Rows)
            {
                int idMov = row.Field<int>("ID_PRESTAMO");
                if (idMov == id)
                {
                    return true;
                }
            }
            return OK;
        }





        private void tblVENCIDOS_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tblVENCIDOS.IsCurrentCellDirty)
            {
                tblVENCIDOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



        private void tblVENCIDOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = tblVENCIDOS.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "CHECK":
                    DataGridViewRow row = tblVENCIDOS.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["CHECK"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    listarVencidos();
                    break;
            }
        }




        private void CIERRE(object sender, EventArgs e)
        {
            //ListaVencidosForm cerrarLista = ListaVencidosForm.Instance();
            //cerrarLista.MdiParent = HOME.Instance();
            //cerrarLista.LISTA_CONTRATOS = CERRAR;
            //if (CERRAR != null && CERRAR.Rows.Count > 0)
            //{
            //    cerrarLista.SUC = CERRAR.Rows[0].Field<string>("COD_SUC");
            //}
            //else
            //{
            //    cerrarLista.SUC = HOME.Instance().SUCURSAL.COD_SUC;
            //}
            //cerrarLista.NUEVO(null, null);
            //cerrarLista.Show();

            //if (cerrarLista.WindowState == FormWindowState.Minimized)
            //{
            //    cerrarLista.WindowState = FormWindowState.Normal;
            //}

            this.Close();
            
        }




        private void AYUDA(object sender, EventArgs e)
        {

        }



        private void ckALL_CheckedChanged(object sender, EventArgs e)
        {
           foreach (DataGridViewRow row in tblVENCIDOS.Rows)
           {
               row.Cells["CHECK"].Value = ckALL.Checked;
           }
           listarVencidos();
        }

    }
}
