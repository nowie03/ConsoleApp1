using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SportsManagementSystem
    {
        private static string _connectionString = "Data Source=5CG9410FHX;Initial Catalog=\"sports management system\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        SqlConnection connection ;
        public SportsManagementSystem()
        {
            connection=new SqlConnection( _connectionString );
            connection.Open();
        }

        ~SportsManagementSystem()
        {
            connection.Close();
        }
        private static string _getNameHelper(string query)
        {
            SqlCommand command = new SqlCommand(_connectionString);
            command.CommandText = query;

            string name = "";
            try
            {
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name += reader.GetString(0);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return name;

        }
        private static string _getSportName(int sportId)
        {
            string query = $"SELECT name from sports where id={sportId};";

        }
        private static int _queryHelper(string query)
        {
            SqlCommand command = new SqlCommand(_connectionString);
            command.CommandText = query;

            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return rowsAffected;
        }
        
        public static int AddSports(string sportName,string type)
        {
            sportName=sportName.ToLower();
            type=type.ToLower();

            string query = $"INSERT INTO sports VALUES('{sportName}','{type}');";

            return _queryHelper(query);
        }

        public static int AddTournamnet(string name,string type,string host)
        {
            name = name.ToLower();
            type = type.ToLower();
            host = host.ToLower();

            string query = $"INSERT INTO tournament VALUES ('{name}','{type}','{host}')";
            

            return _queryHelper(query);

        }

        public static int AddSportsInTournament(int tournamentId,int sportsId)
        {
            string query = $"INSERT INTO sports_in_tournament VALUES({tournamentId},{sportsId});";

            return _queryHelper(query);
        }

        public static int AddPlayer(string name, string college, int tournamentId, int sportId)
        {
            string query = $"INSERT INTO player VALUES('{name}','{college}',{tournamentId},{sportId});";
            return _queryHelper(query);
        }

        public static int AddTeam(string name, string college, int tournamentId, int sportId)
        {
            string query = $"INSERT INTO team VALUES('{name}','{college}',{tournamentId},{sportId});";
            return _queryHelper(query);
        }

        public static int AddMatch(int sportId,int tournamentId)
        {
            string query = $"INSERT INTO match VALUES({sportId},{tournamentId});";

            return _queryHelper(query);
        }

        public static int AddPlayersInMatch(int playerId,int matchId)
        {
            string query = $"INSERT INTO players_in_match VALUES({playerId},{matchId});";

            return _queryHelper(query);
        }

        public static int AddTeamsInMatch(int teamId, int matchId)
        {
            string query = $"INSERT INTO players_in_match VALUES({teamId},{matchId});";

            return _queryHelper(query);
        }
        public static int AddScoreBoard(int matchId,int tournamentId)
        {
            string query = $"INSERT INTO scoreboard VALUES({matchId},{tournamentId});";

            return _queryHelper(query);
        }

        public static int EditScoreBoard(int scoreBoardId,string result)
        {
            string query = $"UPDATE scoreboard SET result='{result}' where scoreboard_id={scoreBoardId};";
            return _queryHelper(query);
        }

        





    }
}
