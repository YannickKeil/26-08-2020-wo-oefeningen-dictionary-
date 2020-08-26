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
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }
        Dictionary<string, string> Woordenboek = new Dictionary<string, string>();
        private void Oefening2_Load(object sender, EventArgs e)
        {
            Woordenboek.Add("Spel", "Game");
            Woordenboek.Add("Toetsenbord", "Keyboard");
            Woordenboek.Add("Muis", "Mouse");
            Woordenboek.Add("Schijf", "Drive");
            Woordenboek.Add("Boot", "Boat");
            Woordenboek.Add("Vliegtuig", "Plane");

            LoadComboBox();
            cbNederlands.SelectedIndex = 0;
        }

        private void cbNederlands_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> item in Woordenboek)
            {
                if (cbNederlands.SelectedItem.ToString() == item.Key)
                {
                    lEngels.Text = item.Value;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Oef2_Woordenboek oefWB = new Oef2_Woordenboek();
            if (oefWB.ShowDialog() == DialogResult.OK )
            {
                Woordenboek.Add(oefWB.nederlands, oefWB.engels);
                LoadComboBox();
            }
        }
        private void LoadComboBox()
        {
            cbNederlands.Items.Clear();
            foreach (KeyValuePair<string, string> item in Woordenboek)
            {
                cbNederlands.Items.Add(item.Key);
            }
            if (cbNederlands.Items.Count != 0)
            {
                cbNederlands.SelectedIndex = 0;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> item in Woordenboek)
            {
                if (cbNederlands.SelectedItem.ToString() == item.Key)
                {
                    Woordenboek.Remove(item.Key);
                    LoadComboBox();
                    break;
                }
            }
        }
    }
}
