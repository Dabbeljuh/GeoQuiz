using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GeoQuiz
{
    public class Database
    {
        private MySqlConnection con;
        public Database()
        {
            string s = "SERVER=localhost;DATABASE=GeoQuiz;;UID=root;PASSWORD='';";
            con = new MySqlConnection(s);
        }

        //COUNTRIES
        // liest aus Table Country in Country-Liste
        public List<Country> ReadCountry()
        {
            List<Country> liCountry = new List<Country>();

            MySqlCommand com = con.CreateCommand();
            // Datenbank öffnen
            con.Open();
            // Lesen als Befehl
            com.CommandText = "SELECT * FROM Country;";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            // Zeilen einzeln lesen
            while (reader.Read())
            {
                liCountry.Add(
                    new Country(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),       // Country_ID
                            reader.IsDBNull(1) ? "" : reader.GetString(1),      // Country_Name
                            reader.IsDBNull(2) ? "" : reader.GetString(2),      // Country_Capital
                            reader.IsDBNull(3) ? "" : reader.GetString(3)         // Country_Flag
                        ));
            }
            // Lesen ist fertig
            reader.Close();
            // Datenbank schliessen
            con.Close();

            return liCountry;
        }

        // bekommt den Ländernamen von dem übergebnenen Hauptstadt Namen (capital)
        public string CheckCountryAnswer(string capital)
        {
            String answer = "ERROR_1";
            // Befehlsstruktur anlegen
            MySqlCommand com = con.CreateCommand();
            // Datenbank öffnen
            con.Open();
            // Lesen als Befehl
            com.CommandText = "SELECT * FROM country WHERE capital = \"" + capital + "\";";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    answer = reader.IsDBNull(1) ? "" : reader.GetString(1);     // Country_Name
                }
            }

            reader.Close();

            con.Close();

            return answer;
        }

        // bekommt die Hauptstadt von dem übergebenen Ländernamen (country)
        public string CheckCapitalAnswer(string country)
        {
            String answer = "ERROR_2";
            // Befehlsstruktur anlegen
            MySqlCommand com = con.CreateCommand();
            // Datenbank öffnen
            con.Open();
            // Lesen als Befehl
            com.CommandText = "SELECT * FROM country WHERE name = \"" + country + "\";";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    answer = reader.IsDBNull(2) ? "" : reader.GetString(2);     // Country_Capital
                }
            }

            reader.Close();

            con.Close();

            return answer;
        }

        // bekommt den CountryCode für die Bilderdarstellung von dem übergebnen Ländernamen (country)
        public string CheckPictureAnswer(string country)
        {
            String answer = "ERROR_3";
            // Befehlsstruktur anlegen
            MySqlCommand com = con.CreateCommand();
            // Datenbank öffnen
            con.Open();
            // Lesen als Befehl
            com.CommandText = "SELECT * FROM country WHERE name = \"" + country + "\";";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    answer = reader.IsDBNull(3) ? "" : reader.GetString(3);     // Country_Picture
                }
            }

            reader.Close();

            con.Close();

            return answer;

        }

        //USERS
        // liest aus Table User in User-Liste
        //  -> ? eventl nicht notwendig, wird im Moment nicht benutzt
        public List<User> ReadUser()
        {
            List<User> liUser = new List<User>();

            MySqlCommand com = con.CreateCommand();

            con.Open();
            com.CommandText = "SELECT * FROM User;";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            // Zeilen einzeln lesen
            while (reader.Read())
            {
                liUser.Add(
                    new User(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),        // User_ID
                            reader.IsDBNull(1) ? "" : reader.GetString(1)        // Username
                        ));
            }
            reader.Close();
            con.Close();

            return liUser;
        }

        // checks username in Datenbank vorhanden
        public bool CheckUsernameExistence(string username)
        {
            MySqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandText = "SELECT * FROM user WHERE username = \"" + username + "\";";
            MySqlDataReader reader = com.ExecuteReader();

            //TRUE, wenn username in Database
            //FALSE, wenn username nicht vorhanden
            bool var = reader.HasRows;
            reader.Close();
            con.Close();

            return var;
        }

        // Erstellt neuen Nutzer in Datenbank
        public void NewUser(string username)
        {
            MySqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandText = "INSERT INTO User VALUES( null, \"" + username + "\");";
            com.ExecuteNonQuery();
            con.Close();
        }

        // Helper, übersetzt UserID (uid) in den zugehörigen Username
        public string UseridToUsername(int uid)
        {
            string username = "ERROR";
            MySqlCommand com = con.CreateCommand();
            // Datenbank öffnen
            con.Open();
            // Lesen als Befehl
            com.CommandText = "SELECT * FROM user WHERE user_id = \"" + uid + "\";";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    username = reader.IsDBNull(1) ? "" : reader.GetString(1);     // username
                }
            }

            reader.Close();

            con.Close();

            return username;
        }

        // übersetzt den Usernamen in die zugehörige User ID
        public int UsernameToUserid(string username)
        {
            int userid = 0;
            MySqlCommand com = con.CreateCommand();
            // Datenbank öffnen
            con.Open();
            // Lesen als Befehl
            com.CommandText = "SELECT * FROM user WHERE username = \"" + username + "\";";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userid = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);     // user-id
                }
            }

            reader.Close();
            con.Close();
            return userid;
        }
        //SCORES
        // liest aus Table Score in Score-Liste
        //  -> ? eventl nicht notwendig, wird im Moment nicht benutzt
        public List<Score> ReadScore()
        {
            List<Score> liScore = new List<Score>();

            MySqlCommand com = con.CreateCommand();

            con.Open();
            com.CommandText = "SELECT * FROM Score;";
            // DB Zugriff starten, Lesen ausführen
            MySqlDataReader reader = com.ExecuteReader();

            // Zeilen einzeln lesen
            while (reader.Read())
            {
                liScore.Add(
                    new Score(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),           // score_ID
                            reader.IsDBNull(1) ? -1 : reader.GetInt32(1),           // user_ID
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2),           // quiztype_ID
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3),           // score
                            reader.IsDBNull(4) ? "" : reader.GetString(4)           // date
                        ));
            }
            reader.Close();
            con.Close();

            return liScore;
        }

        // Score-Liste von einem spezifischen Nutzer (userid) und quiztype (1 - Country, 2 - Capital, 3 - Flags)
        public List<Score> GetSingleScore(int quiztype, int userid)
        {
            List<Score> liSingleScore = new List<Score>();
            MySqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandText = "SELECT * FROM score where user_id = " + userid + " and quiztype_id = " + quiztype + " order by score desc;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                liSingleScore.Add(
                    new Score(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),           // score_ID
                            reader.IsDBNull(1) ? -1 : reader.GetInt32(1),           // user_ID
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2),           // quiztype_ID
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3),           // score
                            reader.IsDBNull(4) ? "" : reader.GetString(4)           // date
                        ));
            }
            reader.Close();
            con.Close();

            return liSingleScore;
        }

        // Score-Liste von allen Nutzern und quiztype (1 - Country, 2 - Capital, 3 - Flags)
        public List<Score> GetAllScore(int quiztype)
        {
            List<Score> liAllScore = new List<Score>();
            MySqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandText = "SELECT * FROM score where quiztype_id = " + quiztype + " order by score desc;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                liAllScore.Add(
                    new Score(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),           // score_ID
                            reader.IsDBNull(1) ? -1 : reader.GetInt32(1),           // user_ID
                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2),           // quiztype_ID
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3),           // score
                            reader.IsDBNull(4) ? "" : reader.GetString(4)           // date
                        ));
            }
            reader.Close();
            con.Close();

            return liAllScore;
        }

        //Speichert Score in Datenbank (null=Score_id , UserID, QuiztypeID, Score, Datum)
        public void SaveScore(Score sc)
        {
            string s;
            MySqlCommand com = con.CreateCommand();
            con.Open();
            s = string.Format("INSERT INTO Score VALUES( null, {0}, {1}, {2}, '{3}');",
                sc.user_id, sc.quiztype_id, sc.score, sc.date);
            com.CommandText = s;

            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
