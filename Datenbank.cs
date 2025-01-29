using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaschaKleinen
{
    // Klasse zur Verwaltung der Datenbankverbindungen und -abfragen
    public class Datenbank
    {
        private MySqlConnection con;

        private string connectionString;

        public Datenbank()
        {
            // Initialisiert die Verbindungszeichenfolge mit Server, Datenbank, Benutzer und Passwort
            connectionString = string.Format("SERVER = localhost; DATABASE = flaggenquiz; UID = {0}; PASSWORD = {1}", "root", "");
            con = new MySqlConnection(connectionString);
        }

        #region Connection
        // Verkürzung der DB-Connection Methoden des Nuget Pakets.
        private void Open()
        {
            con.Open();
        }

        private void Close()
        {
            con.Close();
        }
        #endregion

        #region Select All queries
        
        // Spielerdaten holen
        public List<Spieler> getSpieler()
        {
            List<Spieler> liSpieler = new List<Spieler>();
            
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM spieler";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liSpieler.Add(
                        new Spieler(
                            reader.GetInt32(0),
                            reader.GetString(1))
                        );
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Spielerdaten konnten nicht geladen werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }
            
            return liSpieler;
        }

        // Scores holen
        public List<Scores> getScores()
        {
            List<Scores> liScores = new List<Scores>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM scores";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liScores.Add(
                        new Scores(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetDateTime(3)
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Highscores konnten nicht geladen werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }

            return liScores;
        }

        // Kontinente holen
        public List<Kontinente> getKontinente()
        {
            List<Kontinente> liKontinente = new List<Kontinente>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM kontinente";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liKontinente.Add(
                        new Kontinente(
                            reader.GetInt32(0),
                            reader.GetString(1))
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kontinente konnten nicht geladen werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }

            return liKontinente;
        }

        // Laender holen
        public List<Laender> getLaender()
        {
            List<Laender> liLaender = new List<Laender>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM laender";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liLaender.Add(
                        new Laender(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4))
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Länder konnten nicht geladen werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }

            return liLaender;
        }

        #endregion

        #region Insert queries
        
        public void newSpieler(Spieler spieler)
        {

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "INSERT INTO spieler (benutzername) VALUES (@benutzername);";
                com.Parameters.AddWithValue("@benutzername", spieler.Benutzername);
                com.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Spieler konnte nicht hinzugefügt werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }

        }

        public void newScore(Scores score)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("INSERT INTO scores (spielerID, punkte) VALUES ({0}, {1});", score.SpielerID, score.Punkte);
                com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Neuer Score konnte nicht hinzugefügt werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        #endregion

        public List<Kontinente> difKontinente(string kontinente)
        {
            List<Kontinente> liKontinente = new List<Kontinente>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("SELECT * FROM kontinente WHERE name IN ({0}) ORDER BY kontinentID ASC;", kontinente);
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liKontinente.Add(
                        new Kontinente(
                            reader.GetInt32(0),
                            reader.GetString(1))
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kontinente konnten nicht geladen werden" + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }

            return liKontinente;
        }

    }

}
