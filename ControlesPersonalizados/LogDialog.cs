using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public partial class LogDialog : Form
    {
        public DataTable LOG;

        public LogDialog(string title,DataTable dt)
        {
            InitializeComponent();
            this.Text = title;
            tblLOG.AutoGenerateColumns = false;
            LOG = dt;
            tblLOG.DataSource = LOG;
        }
    }
}
