using System;
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
    public partial class RConsolidadoForm : Form
    {

        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RConsolidadoForm frmInstance = null;

        public static RConsolidadoForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RConsolidadoForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        public RConsolidadoForm()
        {
            InitializeComponent();
        }
    }
}
