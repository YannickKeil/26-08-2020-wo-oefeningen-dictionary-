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
    public partial class oefening_1 : Form
    {
        public oefening_1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> getallen = new Dictionary<int, string>();
        private void oefening_1_Load(object sender, EventArgs e)
        {
            
            getallen.Add(1, "Een");
            getallen.Add(2, "Twee");
            getallen.Add(3, "Drie");
            getallen.Add(4, "Vier");
            getallen.Add(5, "Vijf");
            getallen.Add(6, "Zes");
            getallen.Add(7, "Zeven");
            getallen.Add(8, "Acht");
            getallen.Add(9, "Negen");
            getallen.Add(10, "Tien");

            foreach (KeyValuePair<int,string> item in getallen)
            {
                cbGetal.Items.Add(item.Key);
            }
            cbGetal.SelectedIndex = 0;
        }

        private void cbGetal_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> item in getallen)
            {
                if (Convert.ToInt32(cbGetal.SelectedItem) == item.Key)
                {
                    lGetal.Text = item.Value;
                }   
            }
        }
    }
}
