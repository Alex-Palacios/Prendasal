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
    public partial class RKardexForm : Form
    {
        //PARA MANTENER UNA INSTANCIA UNICA DE LA CLASE//
        private static RKardexForm frmInstance = null;

        public static RKardexForm Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RKardexForm();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public RKardexForm()
        {
            InitializeComponent();
        }
    }
}
