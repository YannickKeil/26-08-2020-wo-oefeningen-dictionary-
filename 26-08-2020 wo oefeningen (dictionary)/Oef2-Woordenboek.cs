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
    public partial class Oef2_Woordenboek : Form
    {
        public Oef2_Woordenboek()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string nederlands;
        public string engels;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNederlands.Text == "")
            {
                epText.SetError(tbNederlands, "Geen tekst ingevuld!");
            }
            if(tbEngels.Text == "")
            {
                epText.SetError(tbEngels, "Geen tekst ingevuld!");
            }
            else
            {
                nederlands = tbNederlands.Text;
                engels = tbEngels.Text;
                this.DialogResult = DialogResult.OK;
                epText.Clear();
            }

        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbNederlands_TextChanged(object sender, EventArgs e)
        {
            if (tbNederlands.Text == "")
            {
                epText.SetError(tbNederlands, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void Oef2_Woordenboek_Load(object sender, EventArgs e)
        {

        }

        private void tbEngels_TextChanged(object sender, EventArgs e)
        {
            if (tbEngels.Text == "")
            {
                epText.SetError(tbEngels, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }
    }
}
