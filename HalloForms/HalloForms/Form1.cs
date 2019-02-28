using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int normaleZahl = 12345;
            int hex = 0xFF00FF;
            int bin = 0b00110011;
        }

        private void buttonKlickMich_Click(object sender, EventArgs e)
        {
            button1.Text = "Autsch";
           
            MessageBox.Show("Hallo Welt");
        }

        private void buttonMehr_Click(object sender, EventArgs e)
        {
            button1.Click += MachNochwas;
        }

        private void MachNochwas(object sender, EventArgs e)
        {
            MessageBox.Show("Nochwas....");
        }

        private void buttonWeniger_Click(object sender, EventArgs e)
        {
            button1.Click -= MachNochwas;

            listBox1.Items.Add("demo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
