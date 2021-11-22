using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OpiskelijaRekisteri
{
    class Opiskelija
    {
        Yhdista yhteys = new Yhdista();

        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO yhteystiedot " + "(etunimi,sukunimi,puhelin,sahkoposti,opiskelijanumero)" +
                "VALUES (@enm, @snm, @puh, @eml, @ono); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("enm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("enm", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("enm", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("enm", MySqlDbType.VarChar).Value = onro;
        }








        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Oid, etunimi, sukunimi, puhelin, sahkoposti FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;

        }

    }
}
