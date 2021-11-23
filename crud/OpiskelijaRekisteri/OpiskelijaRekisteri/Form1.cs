using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OpiskelijaRekisteri
{
    public partial class Form1 : Form
    {
        Opiskelija opiskelija = new Opiskelija();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            opiskelijaNroTB.Text = "";
            emailTB.Text = "";
            puhelinTB.Text = "";
            IdTB.Text = "";
            nimiTB.Text = "";
            sNimiTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = nimiTB.Text;
            String snimi = sNimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = emailTB.Text;
            int onro = Int32.Parse(opiskelijaNroTB.Text);

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || 
                puhelin.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                if(lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijan lisääminen epäonnistui", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = nimiTB.Text;
            String snimi = sNimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = emailTB.Text;
            int onro = Int32.Parse(opiskelijaNroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") ||
                puhelin.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijan päivittäminen epäonnistui", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            nimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sNimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijaNroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if(opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijan poistaminen epäonnistui", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }
    }
}
