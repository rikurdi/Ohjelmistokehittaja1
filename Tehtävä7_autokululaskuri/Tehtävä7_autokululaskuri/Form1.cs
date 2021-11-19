using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä7_autokululaskuri
{
    public partial class AutokuluLaskuri : Form
    {
        public AutokuluLaskuri()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutukset, muut, polttoneste, pesut, huollot, renkaat, kilsat, kustannukset;
            laina = Convert.ToDouble(lyhennysTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            vakuutukset = Convert.ToDouble(vakuutuksetTB.Text);
            muut = Convert.ToDouble(muutTB.Text);
            polttoneste = Convert.ToDouble(polttonesteTB.Text);
            pesut = Convert.ToDouble(pesutTB.Text);
            huollot = Convert.ToDouble(huollotTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            kilsat = Convert.ToDouble(kilsatCB.Text);
            kustannukset = (laina + nesteet + vakuutukset + muut + polttoneste + pesut + huollot + renkaat) / (kilsat / 12);
            kustannukset = Math.Round(kustannukset, 2);
            KustannuksetLB.Text = Convert.ToString(kustannukset) + "€";
            KustannuksetLB.Visible = true;
        }
    }
}
