﻿using System;
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
    public partial class InputBoxPasswordDialog : Form
    {
        //VARIABLES
        string inputResponse = string.Empty;


        public InputBoxPasswordDialog(string prompt, string title)
        {
            InitializeComponent();
            this.txtInput.PasswordChar = '*';
            this.lblPrompt.Text = prompt;
            this.Text = title;
        }


        private void InputBoxPS_Load(object sender, EventArgs e)
        {
            this.txtInput.Focus();
        }

        public string InputResponse
        {
            get { return inputResponse; }
            set { inputResponse = value; }
        } // property InputResponse

        void BtnOKClick(object sender, EventArgs e)
        {
            InputResponse = this.txtInput.Text;
            this.Close();
        }

        void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputResponse = this.txtInput.Text;
                this.Close();
            }
        }
    }
}