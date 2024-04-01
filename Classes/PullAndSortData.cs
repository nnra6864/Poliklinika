using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Poliklinika.Classes
{
    public class PullAndSortData
    {
        public void SortByCity(SqlCommand sqlCommand, string sortOrder, string fromDate, string toDate)
        {
            if (sortOrder == "Po Broju Naviše")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "G.Grad, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Grad G " +
                "ON P.GradID = G.GradID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY G.Grad " +
                "ORDER BY BrojPacijenata DESC) AS Grad " +
                "ORDER BY Grad.BrojPacijenata ASC;";
            }
            else if (sortOrder == "Po Broju Naniže")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "G.Grad, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Grad G " +
                "ON P.GradID = G.GradID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY G.Grad " +
                "ORDER BY BrojPacijenata DESC) AS Grad " +
                "ORDER BY Grad.BrojPacijenata DESC;";
            }
            else if (sortOrder == "Po Nazivu Naviše")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "G.Grad, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Grad G " +
                "ON P.GradID = G.GradID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY G.Grad " +
                "ORDER BY BrojPacijenata DESC) AS Grad " +
                "ORDER BY Grad.Grad ASC;";
            }
            else if (sortOrder == "Po Nazivu Naniže")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "G.Grad, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Grad G " +
                "ON P.GradID = G.GradID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY G.Grad " +
                "ORDER BY BrojPacijenata DESC) AS Grad " +
                "ORDER BY Grad.Grad DESC;";
            }
        }

        public void SortByClinic(SqlCommand sqlCommand, string sortOrder, string fromDate, string toDate)
        {
            if (sortOrder == "Po Broju Naviše")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "P.Naziv, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY P.Naziv " +
                "ORDER BY BrojPacijenata DESC) AS Klinika " +
                "ORDER BY Klinika.BrojPacijenata ASC;";
            }
            if (sortOrder == "Po Broju Naniže")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "P.Naziv, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY P.Naziv " +
                "ORDER BY BrojPacijenata DESC) AS Klinika " +
                "ORDER BY Klinika.BrojPacijenata DESC;";
            }
            if (sortOrder == "Po Nazivu Naviše")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "P.Naziv, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY P.Naziv " +
                "ORDER BY BrojPacijenata DESC) AS Klinika " +
                "ORDER BY Klinika.Naziv ASC;";
            }
            else if (sortOrder == "Po Nazivu Naniže")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "P.Naziv, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY P.Naziv " +
                "ORDER BY BrojPacijenata DESC) AS Klinika " +
                "ORDER BY Klinika.Naziv DESC;";
            }
        }

        public void SortBySpecialisation(SqlCommand sqlCommand, string sortOrder, string fromDate, string toDate)
        {
            if (sortOrder == "Po Broju Naviše")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "S.Tip, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Lekar L " +
                "ON Z.LekarID = L.LekarID " +
                "JOIN Tip_Lekara S " +
                "ON L.TipLekaraID = S.TipLekaraID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY S.Tip " +
                "ORDER BY BrojPacijenata DESC) AS Specijalizacija " +
                "ORDER BY Specijalizacija.BrojPacijenata ASC;";
            }
            else if (sortOrder == "Po Broju Naniže")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "S.Tip, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Lekar L " +
                "ON Z.LekarID = L.LekarID " +
                "JOIN Tip_Lekara S " +
                "ON L.TipLekaraID = S.TipLekaraID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY S.Tip " +
                "ORDER BY BrojPacijenata DESC) AS Specijalizacija " +
                "ORDER BY Specijalizacija.BrojPacijenata DESC;";
            }
            else if (sortOrder == "Po Nazivu Naviše")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "S.Tip, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Lekar L " +
                "ON Z.LekarID = L.LekarID " +
                "JOIN Tip_Lekara S " +
                "ON L.TipLekaraID = S.TipLekaraID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY S.Tip " +
                "ORDER BY BrojPacijenata DESC) AS Specijalizacija " +
                "ORDER BY Specijalizacija.Tip ASC;";
            }
            else if (sortOrder == "Po Nazivu Naniže")
            {
                sqlCommand.CommandText =
                "SELECT * " +
                "FROM(SELECT TOP 10 " +
                "S.Tip, " +
                "COUNT(Z.PacijentID) AS BrojPacijenata " +
                "FROM Poliklinika P " +
                "JOIN Zakazivanje Z " +
                "ON P.PoliklinikaID = Z.PoliklinikaID " +
                "JOIN Lekar L " +
                "ON Z.LekarID = L.LekarID " +
                "JOIN Tip_Lekara S " +
                "ON L.TipLekaraID = S.TipLekaraID " +
                $"WHERE Z.DatumZakazivanja BETWEEN '{fromDate}' AND '{toDate}'" +
                "GROUP BY S.Tip " +
                "ORDER BY BrojPacijenata DESC) AS Specijalizacija " +
                "ORDER BY Specijalizacija.Tip DESC;";
            }
        }

        public void PopulateList(string conString, string sortBy, string sortOrder, string fromDate, string toDate, List<Zakazivanje> listaZakazivanja)
        {
            listaZakazivanja.Clear();
            listaZakazivanja.Add(new Zakazivanje { Name = "", Count = 0 });

            SqlConnection con = new SqlConnection(conString);
            try { con.Open(); } catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            try
            {
                SqlCommand sqlCommand = con.CreateCommand();

                switch (sortBy)
                {
                    case "Po Gradovima":
                        SortByCity(sqlCommand, sortOrder, fromDate, toDate);
                        break;
                    case "Po Klinikama":
                        SortByClinic(sqlCommand, sortOrder, fromDate, toDate);
                        break;
                    case "Po Specijalizacijama":
                        SortBySpecialisation(sqlCommand, sortOrder, fromDate, toDate);
                        break;
                    default:
                        sqlCommand.CommandText = "";
                        break;
                }
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    listaZakazivanja.Add(new Zakazivanje { Name = sqlDataReader.GetString(0), Count = sqlDataReader.GetInt32(1) });
                }

                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
        }
    }
}
