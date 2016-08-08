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

namespace PrendaSAL.Operaciones
{
    using DDB;
    using MODELO;

    public partial class VencidosList : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static VencidosList frmInstance = null;
        private string formName;

        public static VencidosList Instance(string form)
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new VencidosList();
            }
            frmInstance.formName = form;
            frmInstance.BringToFront();
            return frmInstance;
        }


        public static VencidosList Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new VencidosList();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;
        private DBVencidos dbVencidos;

        public DataTable LISTAS;
        private int YEAR;

        private eOperacion ACCION;

        public VencidosList()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
            dbVencidos = new DBVencidos();
        }




        private void ClientesForm_Load(object sender, EventArgs e)
        {
            tblLISTAS.AutoGenerateColumns = false;
            ACCION = eOperacion.INSERT;
            YEAR = HOME.Instance().FECHA_SISTEMA.Year;
            cargarDatos();

        }



        public void cargarDatos()
        {
            LISTAS = dbVencidos.showListaVencByYear(YEAR);
            tblLISTAS.DataSource = LISTAS.Copy();
        }









        private void btnSearch_Click(object sender, EventArgs e)
        {
            string anioConsulta = Controles.InputBox("ANIO:","BUSCAR POR");
            if (anioConsulta != null && anioConsulta != string.Empty)
            {
                try
                {
                    int yearQuery = Int32.Parse(anioConsulta);
                    YEAR = yearQuery;
                    cargarDatos();
                }
                catch (Exception ex) { MessageBox.Show("Parámetro Inválido .. Intente nuevamente","ERROR DE VALIDACION",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Parámetro Inválido .. Intente nuevamente", "ERROR DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }




     

        private void tblCLIENTES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblLISTAS.CurrentCell != null && tblLISTAS.CurrentCell.RowIndex >= 0 && tblLISTAS.SelectedRows.Count == 1)
            {
                Operaciones.ListaVencidosForm.Instance().buscarListaVencidos((string)tblLISTAS.CurrentRow.Cells["DOCUMENTO"].Value);
                this.Close();
            }
        }




        private void btnLog_Click(object sender, EventArgs e)
        {
            if (tblLISTAS.SelectedRows.Count == 1)
            {
               
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }



    }
}
