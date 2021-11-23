using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OpiskelijaRekisteri
{
    class Yhdista
    {
        public string yhteyslause()
        {
            return "datasource=localhost; port=3306; username=root; password=; database=Opiskelijat";
        }

        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port=3306; username=root; password=; database=Opiskelijat");

        // funktio yhteyttä varten
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        // funktio yhteyden avaamista varten
        public void avaaYhteys()
        {
            if(yhteys.State != ConnectionState.Open)
            {
                yhteys.Open();
            }
        }

        // funktio yhteyden sulkua varten
        public void suljeYhteys()
        {
            if (yhteys.State != ConnectionState.Closed)
            {
                yhteys.Close();
            }
        }
    }
}
