namespace Harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DTButton_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            DateTime birthday = DTPicker.Value;

            double erotus = Math.Round((dateNow - birthday).TotalDays);
            VuodetLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            KuukaudetLB.Text = Math.Ceiling(erotus * 12/365.25) + " kuukautta";
            MinuutitLB.Text = (erotus * 1440) + " minuuttia";
            SekunnitLB.Text = (erotus * 86400) + " sekuntia";
            TunnitLB.Text = (erotus * 24) + " tuntia";


            PaivatLB.Text = (erotus + " p‰iv‰‰").ToString();
            PaivatLB.Visible = true;
            VuodetLB.Visible = true;
            KuukaudetLB.Visible = true;
            MinuutitLB.Visible = true;
            SekunnitLB.Visible = true;
            TunnitLB.Visible = true;

        }
    }
}