using System;
using System.CodeDom.Compiler;
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
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }
        public string textLabel;
        private void nudGetal_ValueChanged(object sender, EventArgs e)
        {
            textLabel = "";
            
            if (nudGetal.Value < 15 && nudGetal.Value >= 0)
            {
                    SchrijfGetalExceptions(nudGetal.Value);
            }               
            else if (nudGetal.Value < 101 && nudGetal.Value >= 15)
            {
                    SchrijfGetalOnder100(nudGetal.Value);
            }            
            else if (nudGetal.Value < 1001 && nudGetal.Value >= 101)
            {
                SchrijfGetalOnder1000(nudGetal.Value);
            }           
            else if (nudGetal.Value < 1000001 && nudGetal.Value >= 1001)
            {
                SchrijfGetalOnder1000000(nudGetal.Value);
            }
            else if (nudGetal.Value < 1000000001 && nudGetal.Value >= 1000001)
            {
                SchrijfGetalOnder1000000000(nudGetal.Value);
            }
            else if (nudGetal.Value < 1000000000001 && nudGetal.Value >= 1000000001)
            {
                SchrijfGetalOnder1000000000000(nudGetal.Value);
            }
            lGetal.Text = textLabel;

        }
        public void SchrijfGetalExceptions(decimal getal)
        {
            foreach (KeyValuePair < decimal, string> item in nummers)
            {
                if (getal == item.Key)
                {
                    textLabel += item.Value;
                }
            }
        }
        public void SchrijfGetalOnder100(decimal getal)
        {
            if (getal % 10 == 0)
            {
                SchrijfGetalExceptions(getal);
            }
            else if (getal < 15 && getal >= 0)
            {
                SchrijfGetalExceptions(getal);
            }
            else
            {
                int teller = 0;
                for (decimal i = getal; i > 10; i -= 10)
                {
                    teller++;
                }
                bool tien = false;
                int temp = Convert.ToInt32(getal) - (teller * 10);
                if (teller * 10 == 10)
                    tien = true;
                foreach (KeyValuePair<decimal, string> item in nummers)
                {
                    if (temp == item.Key)
                    {
                        textLabel += item.Value + (tien ? "" : "en") + nummers[teller * 10];
                    }
                }
            }
        }
        public void SchrijfGetalOnder1000(decimal getal)
        {
            if (getal == 1000)
            {
                SchrijfGetalExceptions(getal);
            }
            else if (getal == 0)
            {

            }
            else
            {
                int teller = 0;
                for (decimal i = getal; i >= 100; i -= 100)
                {
                    teller++;
                }
                decimal temp = getal - (teller * 100);
                bool hondert = false;
                if (teller == 1)
                    hondert = true;
                if (teller == 0)
                {
                    SchrijfGetalOnder100(temp);
                }
                else
                {
                    foreach (KeyValuePair<decimal, string> item in nummers)
                    {
                        if (teller == item.Key)
                        {
                            textLabel += (hondert ? "" : item.Value) + nummers[100];
                            if (temp !=0)
                            SchrijfGetalOnder100(temp);
                        }
                    }
                }
            }
        }
        public void SchrijfGetalOnder1000000(decimal getal)
        {
            if (getal == 1000000)
            {
                SchrijfGetalExceptions(getal);
            }
            else
            {
                int teller = 0;
                for (decimal i = getal; i >= 1000; i -= 1000)
                {
                    teller++;
                }
                decimal temp = getal - (teller * 1000);
                bool duizend = false;
                if (teller == 1)
                    duizend = true;
                if (getal == 1000)
                {
                    SchrijfGetalOnder1000(getal);
                }
                else
                {
                    if (!duizend)
                    {
                        SchrijfGetalOnder1000(teller);
                    }
                    if (getal > 999)
                    {
                        textLabel += nummers[1000];
                    }
                    SchrijfGetalOnder1000(temp);
                }
            }
        }
        public void SchrijfGetalOnder1000000000(decimal getal)
        {
            if (getal == 1000000000)
                SchrijfGetalExceptions(getal);
            else
            {
                int teller = 0;
                for (decimal i = getal; i >= 1000000; i -= 1000000)
                {
                    teller++;
                }
                decimal temp = getal - (teller * 1000000);
                bool miljard = false;
                if (teller == 1)
                    miljard = true;
                if (getal == 1000000)
                {
                    SchrijfGetalOnder1000000(getal);
                }
                else
                {
                    if (!miljard)
                    {
                        SchrijfGetalOnder1000(teller);
                    }
                    textLabel += nummers[1000000];
                    SchrijfGetalOnder1000000(temp);
                }
            }
        }
        public void SchrijfGetalOnder1000000000000(decimal getal)
        {
            if (getal == 1000000000000)
                SchrijfGetalExceptions(getal);
            else
            {
                int teller = 0;
                for (decimal i = getal; i >= 1000000000; i -= 1000000000)
                {
                    teller++;
                }
                decimal temp = getal - (teller * 1000000000);
                bool miljard = false;
                if (teller == 1)
                    miljard = true;
                if (getal == 1000000000)
                {
                    SchrijfGetalOnder1000000000(getal);
                }
                else
                {
                    if (!miljard)
                    {
                        SchrijfGetalOnder1000000(teller);
                    }
                    textLabel += nummers[1000000000];
                    SchrijfGetalOnder1000000000(temp);
                }
            }
        }

        Dictionary<decimal, string> nummers = new Dictionary<decimal, string>();
        private void Oefening4_Load(object sender, EventArgs e)
        {
            nummers.Add(0, "nul");
            nummers.Add(1, "een");            
            nummers.Add(2, "twee");
            nummers.Add(3, "drie");
            nummers.Add(4, "vier");
            nummers.Add(5, "vijf");
            nummers.Add(6, "zes");
            nummers.Add(7, "zeven");
            nummers.Add(8, "acht");
            nummers.Add(9, "negen");
            nummers.Add(10, "tien");
            nummers.Add(11, "elf");
            nummers.Add(12, "twaalf");
            nummers.Add(13, "dertien");
            nummers.Add(14, "veertien");
            nummers.Add(20, "twintig");
            nummers.Add(30, "dertig");
            nummers.Add(40, "veertig");
            nummers.Add(50, "vijftig");
            nummers.Add(60, "zestig");
            nummers.Add(70, "zeventig");
            nummers.Add(80, "tachtig");
            nummers.Add(90, "negentig");
            nummers.Add(100, "honderd");
            nummers.Add(1000, "duizend");
            nummers.Add(1000000, "miljoen");
            nummers.Add(1000000000, "miljard");
            nummers.Add(1000000000000, "biljoen");
            nudGetal.Value = 1;
        }
    }
}
