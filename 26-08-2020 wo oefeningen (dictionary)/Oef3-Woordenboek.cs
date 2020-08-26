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
    public partial class Oef3_Woordenboek : Form
    {
        public Oef3_Woordenboek()
        {
            InitializeComponent();
        }
        public string nederlands;
        public string engels;
        public string frans;
        public string duits;
        public string japanees;
        public string spaans;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNederlands.Text == "")
            {
                epText.SetError(tbNederlands, "Geen tekst ingevuld!");
            }
            if (tbEngels.Text == "")
            {
                epText.SetError(tbEngels, "Geen tekst ingevuld!");
            }
            if (tbFrans.Text == "")
            {
                epText.SetError(tbFrans, "Geen tekst ingevuld!");
            }
            if (tbDuits.Text == "")
            {
                epText.SetError(tbDuits, "Geen tekst ingevuld!");
            }
            if (tbJapanees.Text == "")
            {
                epText.SetError(tbJapanees, "Geen tekst ingevuld!");
            }
            if (tbSpaans.Text == "")
            {
                epText.SetError(tbSpaans, "Geen tekst ingevuld!");
            }
            else
            {
                nederlands = tbNederlands.Text;
                engels = tbEngels.Text;
                frans = tbFrans.Text;
                duits = tbDuits.Text;
                japanees = tbJapanees.Text;
                spaans = tbSpaans.Text;
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

        private void tbFrans_TextChanged(object sender, EventArgs e)
        {
            if (tbFrans.Text == "")
            {
                epText.SetError(tbFrans, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void tbDuits_TextChanged(object sender, EventArgs e)
        {
            if (tbDuits.Text == "")
            {
                epText.SetError(tbDuits, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void tbJapanees_TextChanged(object sender, EventArgs e)
        {
            if (tbJapanees.Text == "")
            {
                epText.SetError(tbJapanees, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void tbSpaans_TextChanged(object sender, EventArgs e)
        {
            if (tbSpaans.Text == "")
            {
                epText.SetError(tbSpaans, "Geen tekst ingevuld!");
            }
            else
            {
                epText.Clear();
            }
        }

        private void Oef3_Woordenboek_Load(object sender, EventArgs e)
        {

        }
    }
}
