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

    using LOGICA;
    using MODELO;
    using DDB;

    public partial class AgregarUser : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static AgregarUser frmInstance = null;

        public static AgregarUser Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new AgregarUser();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;

        private DataTable EMPLEADOS;

        public AgregarUser()
        {
            InitializeComponent();
            dbPrendasal = new DBPRENDASAL();
            dbUser = new DBUsuario();
        }



        private void AgregarUser_Load(object sender, EventArgs e)
        {
            cbxTipoUser.DataSource = Enum.GetValues(new eTipoUsuario().GetType());
            cargarEmpleados();
        }
        

        private void cargarEmpleados()
        {
            EMPLEADOS = dbUser.showNoUser(HOME.Instance().SISTEMA);
            Fill(listEmpleados,EMPLEADOS);

        }


         public static void Fill(ListView listView, DataTable data)
         {
            if (data == null) throw new ArgumentNullException("Es necesario enviar una tabla.");
            if (data.Columns.Count == 0) return;
            if (data.Rows.Count == 0) return;
            data.Columns.Cast<DataColumn>().ToList().ForEach(column => listView.Columns.Add(column.Caption));
            
            data.AsEnumerable().ToList().ForEach(row=>
            {
                 ListViewItem item = new ListViewItem(Convert.ToString(row[0]));
                   row.ItemArray.ToList().Skip(1).ToList().ForEach(value =>
                       item.SubItems.Add(Convert.ToString(value)));
                   listView.Items.Add(item);
            });
         }

         private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (listEmpleados.SelectedIndices.Count == 1)
             {
                 limpiar();
                 txtEmpleado.Text = listEmpleados.SelectedItems[0].SubItems[1].Text;
                 txtUsername.Text = listEmpleados.SelectedItems[0].SubItems[0].Text;
             }
         }


         private void limpiar()
         {
             txtEmpleado.Text = "";
             txtUsername.Text = "";
             ckActivo.Checked = true;
             cbxTipoUser.SelectedItem = eTipoUsuario.ASESOR;
         }


         private void CANCELAR(object sender, EventArgs e)
         {
             this.Close();
         }


        private bool validarUser()
        {
            bool OK = true;
            try
            {
                if (txtUsername.Text.Trim() == string.Empty)
                {
                    OK = false;
                    MessageBox.Show("Elija Empleado", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return OK;
                }

            }
            catch (Exception ex)
            {
                OK = false;
                MessageBox.Show("ERROR AL VALIDAR USUARIO", "ERROR VALIDAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return OK;
        }

        private Usuario buildUSER()
        {
            Usuario user = new Usuario();
            user.COD_EMPLEADO = txtUsername.Text;
            user.PASSWORD = txtUsername.Text;
            user.TIPO = (eTipoUsuario)cbxTipoUser.SelectedItem;
            user.ACTIVO = ckActivo.Checked;
            return user;
        }

         private void GUARDAR(object sender, EventArgs e)
         {

             if (validarUser())
             {
                 Usuario user = buildUSER();
                 string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
                 if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
                 {
                     if (dbUser.insert(HOME.Instance().SISTEMA,user))
                     {
                         UsuariosForm.Instance().cargarUsuarios();
                         this.Close();
                     }
                 }
                 else
                 {
                     MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 }
             }
         }





    }
}
