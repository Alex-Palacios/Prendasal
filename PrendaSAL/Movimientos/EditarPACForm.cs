using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrendaSAL.Movimientos
{
    using MODELO;
    using DDB;

    public partial class EditarPACForm : Form
    {
        Pac SELECTED;

        public EditarPACForm(Pac recibo)
        {
            InitializeComponent();
            SELECTED = recibo;
        }
    }
}
