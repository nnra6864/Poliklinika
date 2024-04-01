using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Poliklinika.Classes
{
    public class PopulateDataGrid
    {
        public void PopulateSpecijalizacije(string conString, BindingList<string> specijalizacije)
        {
            specijalizacije.Clear();
            specijalizacije.Add("Sve");

            SqlConnection con = new SqlConnection(conString);
            try { con.Open(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            SqlCommand sqlCommand = con.CreateCommand();
            sqlCommand.CommandText = "SELECT Tip FROM Tip_Lekara;";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                specijalizacije.Add(sqlDataReader.GetString(0));
            }
            con.Close();
        }

        public void PopulateLekari(string conString, int specijalizacija, BindingList<Lekar> lekari)
        {
            lekari.Clear();
            lekari.Add(new Lekar { ImeIPrezime = "Svi", ID = 0 });

            SqlConnection con = new SqlConnection(conString);
            try { con.Open(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            SqlCommand sqlCommand = con.CreateCommand();

            try
            {
                if (specijalizacija == 0)
                {
                    sqlCommand.CommandText = "SELECT Ime, Prezime, LekarID FROM Lekar;";
                }

                else
                {
                    sqlCommand.CommandText = $"SELECT Ime, Prezime, LekarID FROM Lekar WHERE TipLekaraID = { specijalizacija };";
                }

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lekari.Add(new Lekar { ImeIPrezime = $"{ sqlDataReader.GetString(0) } { sqlDataReader.GetString(1) }", ID = sqlDataReader.GetInt32(2) });
                }

                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
        }

        public void PopulateGrid(string conString, int lekarID, BindingList<Angazovanja> angazovanja)
        {
            angazovanja.Clear();

            SqlConnection con = new SqlConnection(conString);
            try { con.Open(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            SqlCommand sqlCommand = con.CreateCommand();

            if (lekarID == 0)
            {
                sqlCommand.CommandText =
                "SELECT G.Grad, P.Naziv, S.Aktivan, LekarID " +
                "FROM Poliklinika P " +
                "JOIN Grad G ON P.GradID = G.GradID " +
                "JOIN Poliklinika_Specijalista S ON P.PoliklinikaID = S.PoliklinikaID;";
            }

            else
            {
                sqlCommand.CommandText =
                "SELECT G.Grad, P.Naziv, S.Aktivan, LekarID " +
                "FROM Poliklinika P " +
                "JOIN Grad G ON P.GradID = G.GradID " +
                "JOIN Poliklinika_Specijalista S ON P.PoliklinikaID = S.PoliklinikaID " +
                $"WHERE S.LekarID = { lekarID };";
            }

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                angazovanja.Add(new Angazovanja { Grad = sqlDataReader.GetString(0), Klinika = sqlDataReader.GetString(1), Status = sqlDataReader.GetBoolean(2), LekarID = sqlDataReader.GetInt32(3) });
            }
            con.Close();
        }

        public void UpdateDatabase(string conString, BindingList<Angazovanja> angazovanja, int lekarID, int specijalizacijaID)
        {
            SqlConnection con = new SqlConnection(conString);
            try { con.Open(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            SqlCommand sqlCommand = con.CreateCommand();
            
            foreach (var a in angazovanja) 
            {
                try 
                {
                    if (specijalizacijaID == 0)
                    {
                        sqlCommand.CommandText =
                        "UPDATE PKS " +
                        $"SET Aktivan = { (a.Status ? 1 : 0) } " +
                        "FROM Poliklinika_Specijalista PKS " +
                        "JOIN Poliklinika P " +
                        "ON P.PoliklinikaID = PKS.PoliklinikaID " +
                        $"WHERE PKS.LekarID = { a.LekarID } AND P.Naziv = '{ a.Klinika }';";
                    }
                    else
                    {
                        sqlCommand.CommandText =
                        "UPDATE PKS " +
                        $"SET Aktivan = { (a.Status ? 1 : 0) } " +
                        "FROM Poliklinika_Specijalista PKS " +
                        "JOIN Poliklinika P " +
                        "ON P.PoliklinikaID = PKS.PoliklinikaID " +
                        "JOIN Lekar L " +
                        "ON L.LekarID = PKS.LekarID " +
                        $"WHERE PKS.LekarID = { a.LekarID } AND L.TipLekaraID = { specijalizacijaID } AND P.Naziv = '{ a.Klinika }';";
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            con.Close();
        }
    }
}
