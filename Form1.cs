using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Clase4WF
{
    public partial class Form1 : Form
    {
        Form2 newMDIChild;
        Form3 newMDIChild3;
        public Form1()
        {
            InitializeComponent();
            //newMDIChild = new Form2(new string[1]);
            //newMDIChild3 = new Form3();
            //newMDIChild.MdiParent = this;
            //newMDIChild3.MdiParent = this;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = "hiciste click";
            //DialogResult result = MessageBox.Show("Hola","Boton 2",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //if (result== DialogResult.Yes)
            //    MessageBox.Show("SI");
            //else
            //    MessageBox.Show("NO");
            
            // Set the Parent Form of the Child window.
            
            // Display the new form.
            newMDIChild.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<List<string>> Alojamientos = new List<List<string>>();
            List<string> elementos = new List<string>();
            elementos.Add("Hotel");
            elementos.Add("1000");
            elementos.Add("5");
            List<string> elementos2 = new List<string>();
            elementos2.Add("Cabania");
            elementos2.Add("2000");
            elementos2.Add("7");
            Alojamientos.Add(elementos);
            Alojamientos.Add(elementos2);

            dataGridView1.Rows.Clear();
            foreach(List<string> alojamiento in Alojamientos)
                dataGridView1.Rows.Add(alojamiento.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
