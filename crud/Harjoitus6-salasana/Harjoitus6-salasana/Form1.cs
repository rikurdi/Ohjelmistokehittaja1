namespace Harjoitus6_salasana
{
    public partial class SalasananTarkastus : Form
    {
        public SalasananTarkastus()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(kayttajaTB.Text == "Jyri" && salasanaTB.Text == "Ja@kk0Ku1ta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                virheLB.Text = "K�ytt�j�tunnus tai salasana virheellinen!";
                virheLB.Visible = true;
            }
        }
    }
}