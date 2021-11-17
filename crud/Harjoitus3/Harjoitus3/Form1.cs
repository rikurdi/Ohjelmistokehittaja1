namespace Harjoitus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LukuKaksiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(LukuYksiTB.Text);
            float luku2 = float.Parse(LukuKaksiTB.Text);
            float vastaus = 0;
            string merkki = LaskutoimituksetCB.Text;

            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                default:
                    vastaus = 0;
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;

        }
    }
}