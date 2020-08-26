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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }
        Dictionary<string, List<string>> Woordenboek = new Dictionary<string, List<string>>();
        private void Oefening3_Load(object sender, EventArgs e)
        {
            Woordenboek.Add("Spel", new List<string> { "Game", "Jeu", "Spiel", "ゲーム", "juego" });
            Woordenboek.Add("Toetsenbord", new List<string> { "Keyboard", "clavier", "Tastatur", "キーボード", "teclado" });
            Woordenboek.Add("Muis", new List<string> { "Mouse", "Souris", "Maus", "マウス", "ratón" });
            Woordenboek.Add("Schijf", new List<string> { "Disk", "disque", "Scheibe", "ディスク", "disco" });
            Woordenboek.Add("Boot", new List<string> { "Boat", "bateau", "Boot", "ボート", "barco" });
            Woordenboek.Add("Vliegtuig", new List<string> { "plane", "avion", "Flugzeug", "飛行機", "avión" });
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            cbNederlands.Items.Clear();
            foreach (KeyValuePair<string, List<string>> item in Woordenboek)
            {
                cbNederlands.Items.Add(item.Key);
            }
            if (cbNederlands.Items.Count != 0)
            {
                cbNederlands.SelectedIndex = 0;
            }

        }

        private void cbNederlands_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<string>> item in Woordenboek)
            {
                if (cbNederlands.SelectedItem.ToString() == item.Key)
                {
                    lEngels.Text = item.Value[0];
                    lFrans.Text = item.Value[1];
                    lDuits.Text = item.Value[2];
                    lJapans.Text = item.Value[3];
                    lSpaans.Text = item.Value[4];
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, List<string>> item in Woordenboek)
            {
                if (cbNederlands.SelectedItem.ToString() == item.Key)
                {
                    Woordenboek.Remove(item.Key);
                    LoadComboBox();
                    break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Oef3_Woordenboek oefWB = new Oef3_Woordenboek();
            if (oefWB.ShowDialog() == DialogResult.OK)
            {
                Woordenboek.Add(oefWB.nederlands, new List<string> { oefWB.engels, oefWB.frans, oefWB.duits, oefWB.japanees, oefWB.spaans });
                LoadComboBox();
            }
        }
    }
}
