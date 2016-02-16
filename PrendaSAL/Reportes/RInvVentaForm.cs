﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Reportes
{
    using DDB;
    using MODELO;


    public partial class RInvVentaForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RInvVentaForm frmInstance = null;

        public static RInvVentaForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RInvVentaForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        //VARIABLES
        private DBInventario dbInventario;
        private DBCatalogo dbCatalogo;
        private DataTable INVENTARIO;
        private DataTable FILTRO;
        private Existencia SELECTED;


        public RInvVentaForm()
        {
            InitializeComponent();
            dbInventario = new DBInventario();
            dbCatalogo = new DBCatalogo();
        }


        private void permisos()
        {
            btnEditar.Visible = false;

            foreach (DataRow p in HOME.Instance().USUARIO.PERMISOS.Rows)
            {
                if (p.Field<string>("CODIGO") == "P19")
                {
                    btnEditar.Visible = p.Field<bool>("ACTUALIZAR");
                }
            }
            if (HOME.Instance().USUARIO.TIPO == eTipoUsuario.ASESOR)
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




        private void RInvVentaForm_Load(object sender, EventArgs e)
        {
            permisos();
            permisos();
            tblINVENTARIO.AutoGenerateColumns = false;
            cbxSUCURSAL.DataSource = HOME.Instance().datSUCURSALES.Copy();
            if (HOME.Instance().datSUCURSALES.Rows.Count > 0)
            {
                cbxSUCURSAL.DisplayMember = "SUCURSAL";
                cbxSUCURSAL.ValueMember = "COD_SUC";
                cbxSUCURSAL.SelectedValue = HOME.Instance().SUCURSAL.COD_SUC;
                DataRow R = ((DataTable)cbxSUCURSAL.DataSource).NewRow();
                R.SetField<string>("COD_SUC", "00");
                R.SetField<string>("SUCURSAL", "TODAS LAS SUCURSALES");
                R.SetField<bool>("ACTIVA", false);
                ((DataTable)cbxSUCURSAL.DataSource).Rows.InsertAt(R, 0);
            }
            cbxARTICULO.DataSource = dbCatalogo.showCatalogo(eCategoria.ARTICULO);
            if (cbxARTICULO.DataSource != null && ((DataTable)cbxARTICULO.DataSource).Rows.Count > 0)
            {
                cbxARTICULO.DisplayMember = "COD_ITEM";
                cbxARTICULO.ValueMember = "COD_ITEM";
                DataRow R = ((DataTable)cbxARTICULO.DataSource).NewRow();
                R.SetField<string>("CATEGORIA", "TODAS");
                R.SetField<string>("COD_ITEM", "TODAS");
                R.SetField<string>("UNIDAD_MEDIDA", "TODAS");
                ((DataTable)cbxARTICULO.DataSource).Rows.InsertAt(R, 0);
                cbxARTICULO.SelectedIndex = 0;
            }

            cargarExistencias();
            
        }



        private void cargarExistencias()
        {
            INVENTARIO = dbInventario.getExistenciasARTICULOS((string)cbxSUCURSAL.SelectedValue);
            System.Media.SystemSounds.Exclamation.Play();
            filtrarDatosExistencias();
        }



        private void filtrarDatosExistencias()
        {
            DataRow[] filtros;
            FILTRO = INVENTARIO.Copy();
            if (FILTRO.Rows.Count > 0)
            {
                if (txtCODIGO.Text.Trim() != string.Empty)
                {
                    filtros = FILTRO.Select("CODIGO LIKE '" + txtCODIGO.Text.Trim() + "%'");
                    if (filtros.Count() > 0)
                    {
                        FILTRO = filtros.CopyToDataTable();
                    }
                    else
                    {
                        FILTRO.Clear();
                    }
                }
                if (cbxARTICULO.Text.Trim() != string.Empty && cbxARTICULO.Text.Trim() != "TODAS")
                {
                    filtros = FILTRO.Select("COD_ITEM LIKE '" + cbxARTICULO.Text.Trim() + "%'");
                    if (filtros.Count() > 0)
                    {
                        FILTRO = filtros.CopyToDataTable();
                    }
                    else
                    {
                        FILTRO.Clear();
                    }
                }

            }
            tblINVENTARIO.DataSource = FILTRO;

           
           
        }





        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            //BUSCAR POR ARTICULO
            if (cbxSUCURSAL.SelectedIndex >= 0 )
            {
                txtCODIGO.Text = string.Empty;
                cbxARTICULO.SelectedIndex = 0;

                cargarExistencias();
            }
            else
            {
                MessageBox.Show("SELECCIONE SUCURSAL ", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


        private void txtCODIGO_TextChanged(object sender, EventArgs e)
        {
            if (INVENTARIO != null)
            {
                filtrarDatosExistencias();
            }
        }

        private void cbxARTICULO_TextChanged(object sender, EventArgs e)
        {
            if (INVENTARIO != null)
            {
                filtrarDatosExistencias();
            }
        }



        private void tblINVENTARIO_DataSourceChanged(object sender, EventArgs e)
        {
            if (tblINVENTARIO.DataSource != null)
            {
                lbNUM_TOTAL.Text = tblINVENTARIO.Rows.Count + " ARTICULOS";
            }
            else
            {
                lbNUM_TOTAL.Text = "0 ARTICULOS";
            }
        }



        public void recargar()
        {
            int index = tblINVENTARIO.CurrentCell.RowIndex;
            btnBUSCAR_Click(null,null);
            if (index >= 0 && index < tblINVENTARIO.Rows.Count)
            {
                tblINVENTARIO.Rows[index].Selected = true;
                tblINVENTARIO.CurrentCell = tblINVENTARIO.Rows[index].Cells["CODIGO"];
            }
        }




        private void SelectedArticulo()
        {
            SELECTED = null;
            if (tblINVENTARIO.CurrentCell != null && tblINVENTARIO.SelectedRows.Count == 1)
            {
                SELECTED = Existencia.ConvertToExistencia(FILTRO.Rows[tblINVENTARIO.CurrentCell.RowIndex]);

                btnEditar.Enabled = true;
            }
        }

        private void tblINVENTARIO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblINVENTARIO.CurrentCell != null && tblINVENTARIO.SelectedRows.Count == 1)
            {
                SelectedArticulo();
            }
        }

        private void EDITAR_ARTICULO(object sender, EventArgs e)
        {
            if (tblINVENTARIO.CurrentCell != null && tblINVENTARIO.SelectedRows.Count == 1)
            {
                SelectedArticulo();
                ArticuloForm inv = new ArticuloForm(SELECTED);
                inv.ShowDialog();
            }
            else
            {
                MessageBox.Show("SELECCIONE ARTICULO A EDITAR", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (FILTRO != null)
            {
                HOME.Instance().exportDataGridViewToExcel("REPORTE DE EXISTENCIA", tblINVENTARIO.Columns, FILTRO, "ReporteExistencias");
            }
        }

    }
}
