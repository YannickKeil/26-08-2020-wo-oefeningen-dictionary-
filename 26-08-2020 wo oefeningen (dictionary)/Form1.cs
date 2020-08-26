using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_08_2020_wo_oefeningen__dictionary_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            oefening_1 oef1 = new oefening_1();
            oef1.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            Oefening2 oef2 = new Oefening2();
            oef2.Show();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            Oefening3 oef3 = new Oefening3();
            oef3.Show();
        }

        private void btnOef4_Click(object sender, EventArgs e)
        {
            Oefening4 oef4 = new Oefening4();
            oef4.Show();
        }
    }
}
