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
    using MODELO;
    using DDB;

    public partial class PreciosForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static PreciosForm frmInstance = null;

        public static PreciosForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new PreciosForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        //VARIABLES
        private DBPRENDASAL dbPrendasal;
        private DBUsuario dbUser;

        private DataTable PRENDASAL;
        private DataTable AMIGO;
        private DataTable VIP;
        private DataTable MAYOREO;

        public PreciosForm()
        {
            InitializeComponent();
            dbUser = new DBUsuario();
            dbPrendasal = new DBPRENDASAL();
        }


        private void permisos()
        {
            CAMBIAR_PRENDASAL.Visible = false;
            GUARDAR_PRENDASAL.Visible = false;
            CANCELAR_PRENDASAL.Visible = false;

            CAMBIAR_AMIGO.Visible = false;
            GUARDAR_AMIGO.Visible = false;
            CANCELAR_AMIGO.Visible = false;

            CAMBIAR_VIP.Visible = false;
            GUARDAR_VIP.Visible = false;
            CANCELAR_VIP.Visible = false;

            CAMBIAR_MAYOREO.Visible = false;
            GUARDAR_MAYOREO.Visible = false;
            CANCELAR_MAYOREO.Visible = false;
            

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P22")
                {
                    CAMBIAR_PRENDASAL.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_PRENDASAL.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_PRENDASAL.Visible = p.Field<bool>("ACTUALIZAR");

                    CAMBIAR_AMIGO.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_AMIGO.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_AMIGO.Visible = p.Field<bool>("ACTUALIZAR");

                    CAMBIAR_VIP.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_VIP.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_VIP.Visible = p.Field<bool>("ACTUALIZAR");

                    CAMBIAR_MAYOREO.Visible = p.Field<bool>("ACTUALIZAR");
                    GUARDAR_MAYOREO.Visible = p.Field<bool>("ACTUALIZAR");
                    CANCELAR_MAYOREO.Visible = p.Field<bool>("ACTUALIZAR");
                    
                }
            }
        }


        private void PreciosForm_Load(object sender, EventArgs e)
        {
            permisos();
            this.BackColor = Color.Black;
            tblPrecios_PRENDASAL.AutoGenerateColumns = false;
            tblPrecios_AMIGO.AutoGenerateColumns = false;
            tblPrecios_VIP.AutoGenerateColumns = false;
            tblPrecios_MAYOREO.AutoGenerateColumns = false;

            PRENDASAL = dbPrendasal.getPrecios(eNIVEL.PRENDASAL);
            cargarPrecios(eNIVEL.PRENDASAL);
            bloquear(eNIVEL.PRENDASAL);
        }


        private void bloquear(eNIVEL nivel)
        {
            switch (nivel)
            {
                case eNIVEL.PRENDASAL:
                    //CLIENTE PRENDASAL
                    tblPrecios_PRENDASAL.ReadOnly = true;
                    CAMBIAR_PRENDASAL.Enabled = true;
                    GUARDAR_PRENDASAL.Enabled = false;
                    CANCELAR_PRENDASAL.Enabled = false;
                    break;
                case eNIVEL.AMIGO:
                    //TARJETA AMIGO
                    tblPrecios_AMIGO.ReadOnly = true;
                    CAMBIAR_AMIGO.Enabled = true;
                    GUARDAR_AMIGO.Enabled = false;
                    CANCELAR_AMIGO.Enabled = false;
                    break;
                case eNIVEL.VIP:
                    //TARJETA VIP
                    tblPrecios_VIP.ReadOnly = true;
                    CAMBIAR_VIP.Enabled = true;
                    GUARDAR_VIP.Enabled = false;
                    CANCELAR_VIP.Enabled = false;
                    break;
                case eNIVEL.MAYOREO:
                    //TARJETA MAYOREO
                    tblPrecios_MAYOREO.ReadOnly = true;
                    CAMBIAR_MAYOREO.Enabled = true;
                    GUARDAR_MAYOREO.Enabled = false;
                    CANCELAR_MAYOREO.Enabled = false;
                    break;
            }

        }


        private void desbloquear(eNIVEL nivel)
        {
            switch (nivel)
            {
                case eNIVEL.PRENDASAL:
                    //CLIENTE PRENDASAL
                    tblPrecios_PRENDASAL.ReadOnly = false;
                    tblPrecios_PRENDASAL.Columns["KilatajeN"].ReadOnly = true;
                    CAMBIAR_PRENDASAL.Enabled = false;
                    GUARDAR_PRENDASAL.Enabled = true;
                    CANCELAR_PRENDASAL.Enabled = true;
                    break;
                case eNIVEL.AMIGO:
                    //TARJETA AMIGO
                    tblPrecios_AMIGO.ReadOnly = false;
                    tblPrecios_AMIGO.Columns["KilatajeA"].ReadOnly = true;
                    CAMBIAR_AMIGO.Enabled = false;
                    GUARDAR_AMIGO.Enabled = true;
                    CANCELAR_AMIGO.Enabled = true;
                    break;
                case eNIVEL.VIP:
                    //TARJETA VIP
                    tblPrecios_VIP.ReadOnly = false;
                    tblPrecios_VIP.Columns["KilatajeV"].ReadOnly = true;
                    CAMBIAR_VIP.Enabled = false;
                    GUARDAR_VIP.Enabled = true;
                    CANCELAR_VIP.Enabled = true;
                    break;
                case eNIVEL.MAYOREO:
                    //CLIENTES DE MAYOREO
                    tblPrecios_MAYOREO.ReadOnly = false;
                    tblPrecios_MAYOREO.Columns["KilatajeM"].ReadOnly = true;
                    CAMBIAR_MAYOREO.Enabled = false;
                    GUARDAR_MAYOREO.Enabled = true;
                    CANCELAR_MAYOREO.Enabled = true;
                    break;
            }
        }



        private void cargarPrecios(eNIVEL nivel)
        {
            switch (nivel)
            {
                case eNIVEL.PRENDASAL:
                    lbFechaAuto_PRENDASAL.Text = "";
                    lbAuto_PRENDASAL.Text = "";
                    if (PRENDASAL.Rows.Count > 0)
                    {
                        if (PRENDASAL.Rows[0].Field<DateTime?>("FECHA") != null)
                        {
                            lbFechaAuto_PRENDASAL.Text = PRENDASAL.Rows[0].Field<DateTime>("FECHA").Date.ToString("dd/MM/yyyy");
                        }
                        lbAuto_PRENDASAL.Text = PRENDASAL.Rows[0].Field<string>("AUTORIZO");
                    }
                    tblPrecios_PRENDASAL.DataSource = PRENDASAL.Copy();
                    break;
                case eNIVEL.AMIGO:
                    lbFechaAuto_AMIGO.Text = "";
                    lbAuto_AMIGO.Text = "";
                    if (AMIGO.Rows.Count > 0)
                    {
                        if (AMIGO.Rows[0].Field<DateTime?>("FECHA") != null)
                        {
                            lbFechaAuto_AMIGO.Text = AMIGO.Rows[0].Field<DateTime>("FECHA").Date.ToString("dd/MM/yyyy");
                        }
                        lbAuto_AMIGO.Text = AMIGO.Rows[0].Field<string>("AUTORIZO");
                    }
                    tblPrecios_AMIGO.DataSource = AMIGO.Copy();
                    break;
                case eNIVEL.VIP:
                    lbFechaAuto_VIP.Text = "";
                    lbAuto_VIP.Text = "";
                    if (VIP.Rows.Count > 0)
                    {
                        if (VIP.Rows[0].Field<DateTime?>("FECHA") != null)
                        {
                            lbFechaAuto_VIP.Text = VIP.Rows[0].Field<DateTime>("FECHA").Date.ToString("dd/MM/yyyy");
                        }
                        
                        lbAuto_VIP.Text = VIP.Rows[0].Field<string>("AUTORIZO");
                    }
                    tblPrecios_VIP.DataSource = VIP.Copy();
                    break;
                case eNIVEL.MAYOREO:
                    lbFechaAuto_MAYOREO.Text = "";
                    lbAuto_MAYOREO.Text = "";
                    if (MAYOREO.Rows.Count > 0)
                    {
                        if (MAYOREO.Rows[0].Field<DateTime?>("FECHA") != null)
                        {
                            lbFechaAuto_MAYOREO.Text = MAYOREO.Rows[0].Field<DateTime>("FECHA").Date.ToString("dd/MM/yyyy");
                        }
                        
                        lbAuto_MAYOREO.Text = MAYOREO.Rows[0].Field<string>("AUTORIZO");
                    }
                    tblPrecios_MAYOREO.DataSource = MAYOREO.Copy();
                    break;

            }

        }





        private void tabPrecios_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPrecios.SelectedTab.Name)
            {
                case "pagPRENDASAL":
                    this.BackColor = Color.Black;
                    PRENDASAL = dbPrendasal.getPrecios(eNIVEL.PRENDASAL);
                    cargarPrecios(eNIVEL.PRENDASAL);
                    bloquear(eNIVEL.PRENDASAL);
                    break;
                case "pagAMIGO":
                    this.BackColor = Color.DarkGreen;
                    AMIGO = dbPrendasal.getPrecios(eNIVEL.AMIGO);
                    cargarPrecios(eNIVEL.AMIGO);
                    bloquear(eNIVEL.AMIGO);
                    break;
                case "pagVIP":
                    this.BackColor = Color.DarkBlue;
                    VIP = dbPrendasal.getPrecios(eNIVEL.VIP);
                    cargarPrecios(eNIVEL.VIP);
                    bloquear(eNIVEL.VIP);
                    break;
                case "pagMAYOREO":
                    this.BackColor = Color.Silver;
                    MAYOREO = dbPrendasal.getPrecios(eNIVEL.MAYOREO);
                    cargarPrecios(eNIVEL.MAYOREO);
                    bloquear(eNIVEL.MAYOREO);
                    break;
            }
        }


        // CIENTE PRENDASAL

        private void CAMBIAR_PRENDASAL_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.PRENDASAL);
        }

        private void GUARDAR_PRENDASAL_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                if (dbPrendasal.actualizarPrecios(eNIVEL.PRENDASAL,tblPrecios_PRENDASAL.Rows,HOME.Instance().FECHA_SISTEMA,HOME.Instance().USUARIO.COD_EMPLEADO))
                {
                    PRENDASAL = dbPrendasal.getPrecios(eNIVEL.PRENDASAL);
                    cargarPrecios(eNIVEL.PRENDASAL);
                    bloquear(eNIVEL.PRENDASAL);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CANCELAR_PRENDASAL_Click(object sender, EventArgs e)
        {
            cargarPrecios(eNIVEL.PRENDASAL);
            bloquear(eNIVEL.PRENDASAL);
        }



        private void tblPrecios_PRENDASAL_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tblPrecios_PRENDASAL.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
        }



        private void tblPrecios_PRENDASAL_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = tblPrecios_PRENDASAL.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "PrecioN":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        decimal valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblPrecios_PRENDASAL.Rows[e.RowIndex].ErrorText = "Columna PRECIO Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblPrecios_PRENDASAL.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblPrecios_PRENDASAL.Rows[e.RowIndex].ErrorText = "PRECIO debe ser mayor a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
                
            }
        }

        private void tblPrecios_PRENDASAL_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tblPrecios_PRENDASAL.Rows[e.RowIndex].ErrorText = String.Empty;
        }






        //CLIENTE AMIGO



        private void CAMBIAR_AMIGO_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.AMIGO);
        }

        private void GUARDAR_AMIGO_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                if (dbPrendasal.actualizarPrecios(eNIVEL.AMIGO, tblPrecios_AMIGO.Rows, HOME.Instance().FECHA_SISTEMA, HOME.Instance().USUARIO.COD_EMPLEADO))
                {
                    AMIGO = dbPrendasal.getPrecios(eNIVEL.AMIGO);
                    cargarPrecios(eNIVEL.AMIGO);
                    bloquear(eNIVEL.AMIGO);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CANCELAR_AMIGO_Click(object sender, EventArgs e)
        {
            cargarPrecios(eNIVEL.AMIGO);
            bloquear(eNIVEL.AMIGO);
        }



        private void tblPrecios_AMIGO_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tblPrecios_AMIGO.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
        }



        private void tblPrecios_AMIGO_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = tblPrecios_AMIGO.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "PrecioA":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        decimal valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblPrecios_AMIGO.Rows[e.RowIndex].ErrorText = "Columna PRECIO Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblPrecios_AMIGO.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblPrecios_AMIGO.Rows[e.RowIndex].ErrorText = "PRECIO debe ser mayor a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
                
            }
        }

        private void tblPrecios_AMIGO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tblPrecios_AMIGO.Rows[e.RowIndex].ErrorText = String.Empty;
        }




        //CLIENTE VIP



        private void CAMBIAR_VIP_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.VIP);
        }

        private void GUARDAR_VIP_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                if (dbPrendasal.actualizarPrecios(eNIVEL.VIP, tblPrecios_VIP.Rows, HOME.Instance().FECHA_SISTEMA, HOME.Instance().USUARIO.COD_EMPLEADO))
                {
                    VIP = dbPrendasal.getPrecios(eNIVEL.VIP);
                    cargarPrecios(eNIVEL.VIP);
                    bloquear(eNIVEL.VIP);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CANCELAR_VIP_Click(object sender, EventArgs e)
        {
            cargarPrecios(eNIVEL.VIP);
            bloquear(eNIVEL.VIP);
        }



        private void tblPrecios_VIP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tblPrecios_VIP.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
        }



        private void tblPrecios_VIP_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = tblPrecios_VIP.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "PrecioV":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        decimal valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "Columna PRECIO Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "PRECIO debe ser mayor a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
                case "MargenMinV":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        double valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "Columna MARGEN MIN Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Double.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "MARGEN debe ser mayor o igua a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
                case "MargenMaxV":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        double valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "Columna MARGEN MAX Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Double.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = "MARGEN debe ser mayor o igual a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
            }
        }

        private void tblPrecios_VIP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tblPrecios_VIP.Rows[e.RowIndex].ErrorText = String.Empty;
        }






        //CLIENTE MAYOREO



        private void CAMBIAR_MAYOREO_Click(object sender, EventArgs e)
        {
            desbloquear(eNIVEL.MAYOREO);
        }

        private void GUARDAR_MAYOREO_Click(object sender, EventArgs e)
        {
            string autorizacion = Controles.InputBoxPassword("CODIGO", "CODIGO DE AUTORIZACION");
            if (autorizacion != "" && DBPRENDASAL.md5(autorizacion) == HOME.Instance().USUARIO.PASSWORD)
            {
                if (dbPrendasal.actualizarPrecios(eNIVEL.MAYOREO, tblPrecios_MAYOREO.Rows, HOME.Instance().FECHA_SISTEMA, HOME.Instance().USUARIO.COD_EMPLEADO))
                {
                    MAYOREO = dbPrendasal.getPrecios(eNIVEL.MAYOREO);
                    cargarPrecios(eNIVEL.MAYOREO);
                    bloquear(eNIVEL.MAYOREO);
                }
            }
            else
            {
                MessageBox.Show("CODIGO DE AUTORIZACION INVALIDO", "LISTA VACIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CANCELAR_MAYOREO_Click(object sender, EventArgs e)
        {
            cargarPrecios(eNIVEL.MAYOREO);
            bloquear(eNIVEL.MAYOREO);
        }



        private void tblPrecios_MAYOREO_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tblPrecios_MAYOREO.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                    using (Pen p = new Pen(Color.Red, 1))
                    {
                        Rectangle rect = e.CellBounds;
                        rect.Width -= 2;
                        rect.Height -= 2;
                        e.Graphics.DrawRectangle(p, rect);
                    }
                    e.Handled = true;
                }
            }
        }



        private void tblPrecios_MAYOREO_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = tblPrecios_MAYOREO.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "PrecioM":
                    // Verificar si columna esta vacia
                    if (e.FormattedValue != null)
                    {
                        decimal valor;
                        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            tblPrecios_MAYOREO.Rows[e.RowIndex].ErrorText = "Columna PRECIO Vacia";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (!Decimal.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.Currency, null, out valor))
                        {
                            tblPrecios_MAYOREO.Rows[e.RowIndex].ErrorText = "Formato Invalido";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                        else if (valor < 0)
                        {
                            tblPrecios_MAYOREO.Rows[e.RowIndex].ErrorText = "PRECIO debe ser mayor a 0";
                            System.Media.SystemSounds.Beep.Play();
                            e.Cancel = true;
                        }
                    }
                    break;
                
            }
        }

        private void tblPrecios_MAYOREO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tblPrecios_MAYOREO.Rows[e.RowIndex].ErrorText = String.Empty;
        }

    }
}
