using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase4WF
{
    public partial class Form2 : Form
    {
        private bool logued;
        private string[] argumentos;
        public Form2(string[] args)
        {
            logued = false;
            InitializeComponent();
            argumentos = args;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logued = true;
            this.Close();
            argumentos[0] = "true";
        }
    }
}
