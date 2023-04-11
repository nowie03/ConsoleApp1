using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SportsManagementSystem
    {
        private  string _connectionString = "Data Source=5CG9410FHX;Initial Catalog=\"sports management system\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private SqlConnection connection;
        
        public static void Main(string[] args)
        {
            SportsManagementSystem sportsManagementSystem = new();
            //Console.WriteLine(sportsManagementSystem.AddTournament("tourney by c# one", "university", "skct"));
            try
            {
                Console.WriteLine(sportsManagementSystem.AddSportInTournament("cycling", "tourney by c#"));
            }
            catch (Exception e)
            {
                Console.WriteLine("MC "+e.Message);
            }
        }

        public SportsManagementSystem()
        {
            
            connection = new SqlConnection(_connectionString);
            connection.Open();
        }

        ~SportsManagementSystem()
        {
            connection.Close();
        }


        private  int _queryHelper(string query)
        {
            SqlCommand command =connection.CreateCommand();
            command.CommandText = query+ "SELECT SCOPE_IDENTITY()";

            int idOfCreatedElement = 0;
            try
            {
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        idOfCreatedElement = (int)reader.GetDecimal(0);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return idOfCreatedElement;
        }

        private  string _getStringHelper(string query)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            string name = "";
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
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

        private  int _getIntHelper(string query)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            int result = -1;
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return result;

        }
        private  string _getSportName(int sportId)
        {
            string query = $"SELECT name from sports where sport_id={sportId};";

            return _getStringHelper(query);

        }

        private  string _getTournamentName(int tournamentId)
        {
            string query = $"SELECT name from tournament where tournament_id={tournamentId};";

            return _getStringHelper(query);

        }

        private  string _getPlayerName(int playerId)
        {
            string query = $"SELECT name from player where player_id={playerId};";

            return _getStringHelper(query);

        }

        private  string _getTeamName(int teamId)
        {
            string query = $"SELECT name from team where team_id={teamId};";

            return _getStringHelper(query);

        }

        private  string _getSportType(int sportId)
        {
            string query = $"SELECT type from sports where id={sportId}";

            return _getStringHelper(query);
        }

        private  int _getSportId(string name)
        {
            string query = $"SELECT sport_id from sports where name='{name}'";

            return _getIntHelper(query);
        }

        private  int _getTournamentId(string name)
        {
            string query = $"SELECT tournament_id from tournament where name='{name}'";

            return _getIntHelper(query);
        }

        private  int _getPlayerId(string name)
        {
            string query = $"SELECT player_id from player where name='{name}'";

            return _getIntHelper(query);
        }

        private  int _getTeamId(string name)
        {
            string query = $"SELECT team_id from player where name='{name}'";

            return _getIntHelper(query);
        }

        private  bool _sportExistsTournament(int sportId)
        {
            
            string query = $"SELECT COUNT(*) FROM sports_in_tournament where sport_id={sportId};";


            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            bool flag = false;

            try
            {
                object value = command.ExecuteScalar();
                Console.WriteLine(value);
                flag = value.Equals(1);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return flag;

        }



        private  bool _SportExists(string name)
        {
            name = name.ToLower().Trim();
            string query = $"SELECT COUNT(*) FROM sports where name='{name}';";


            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            bool flag = false;

            try
            {
                object value = command.ExecuteScalar();
                Console.WriteLine(value);
                flag = value.Equals(1) ; 
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return flag;
        }



        public  int AddSport(string sportName, string type)
        {
            sportName = sportName.ToLower();
            type = type.ToLower();

            string query = $"INSERT INTO sports VALUES('{sportName}','{type}');";

            return _queryHelper(query);
        }

        public  int AddTournament(string name, string type, string host)
        {
            name = name.ToLower();
            type = type.ToLower();
            host = host.ToLower();

            string query = $"INSERT INTO tournament VALUES ('{name}','{type}','{host}')";


            return _queryHelper(query);

        }

        public  int AddSportInTournament(string sportName, string tournamentName)
        {
            // check if this name is in sports table
            if (!_SportExists(sportName))
                throw new Exception($"given sport {sportName} doesnt exists");

            int sportId = _getSportId(sportName);

            if (sportId == -1)
                throw new Exception($"Error When fetching sport Id of given sport name {sportName}");


            int tournamentId = _getTournamentId(tournamentName);

            if (tournamentId == -1)
                throw new Exception($"Error when fetching tournament id of given tournament name {tournamentName}");
            
            string query = $"INSERT INTO sports_in_tournament VALUES({tournamentId},{sportId});";

            return _queryHelper(query);
        }

        public  int AddPlayer(string name, string college, string tournamentName, string sportName)
        {
            int sportId = _getSportId(sportName);

            if (sportId == -1)
                throw new Exception($"Error When fetching sport Id of given sport name {sportName}");


            int tournamentId = _getTournamentId(tournamentName);

            if (tournamentId == -1)
                throw new Exception($"Error when fetching tournament id of given tournament name {tournamentName}");

            int playerId=Convert.ToInt32( DateTime.Now.ToString("yyMMddHHmmssff"));

            string query = $"INSERT INTO player VALUES('{playerId},{name}','{college}',{tournamentId},{sportId});";
            return _queryHelper(query);
        }

        public  int AddTeam(string name, string college, string tournamentName, string sportName)
        {

            //add id
            int sportId = _getSportId(sportName);

            if (sportId == -1)
                throw new Exception($"Error When fetching sport Id of given sport name {sportName}");


            int tournamentId = _getTournamentId(tournamentName);

            if (tournamentId == -1)
                throw new Exception($"Error When fetching tournament Id of given sport name {tournamentName}");


            int teamId=Convert.ToInt32( DateTime.Now.ToString("yyMMddHHmmssff"));

            string query = $"INSERT INTO team VALUES({teamId},'{name}','{college}',{tournamentId},{sportId});";
            return _queryHelper(query);
        }

        public  KeyValuePair<int, int> AddMatch(string sportName, string tournamentName)
        {
            //add id

            int sportId = _getSportId(sportName);

            if (sportId == -1)
                throw new Exception($"Error When fetching sport Id of given sport name {sportName}");

            int tournamentId = _getTournamentId(tournamentName);

            if (tournamentId == -1)
                throw new Exception($"Error when fetching tournament id of given tournament name {tournamentName}");

            int matchId = Convert.ToInt32(DateTime.Now.ToString("yyMMddHHmmssff"));

            string query = $"INSERT INTO match VALUES({matchId},{sportId},{tournamentId});";

            int idOfMatchAdded = _queryHelper(query);

            int idOfScoreBoardAdded = AddScoreBoard(idOfMatchAdded, tournamentId);

            return new KeyValuePair<int, int>(idOfMatchAdded, idOfScoreBoardAdded);
        }

        public  int AddPlayerInMatch(int playerId, int matchId)
        {
            string query = $"INSERT INTO players_in_match VALUES({playerId},{matchId});";

            return _queryHelper(query);
        }

        public  int AddTeamsInMatch(int teamId, int matchId)
        {
            string query = $"INSERT INTO players_in_match VALUES({teamId},{matchId});";

            return _queryHelper(query);
        }
        public  int AddScoreBoard(int matchId, int tournamentId)
        {
            //add id
            int scoreBoardId=Convert.ToInt32( DateTime.Now.ToString("yyMMddHHmmssff")); 

            string query = $"INSERT INTO scoreboard VALUES({scoreBoardId},{matchId},{tournamentId});";

            return _queryHelper(query);
        }

        public  int EditScoreBoard(int scoreBoardId, string result)
        {
            string query = $"UPDATE scoreboard SET result='{result}' where scoreboard_id={scoreBoardId};";
            return _queryHelper(query);
        }


        public  int RemoveSport(string sportName)
        {
            if (!_SportExists(sportName))
                throw new Exception($"Sport {sportName} doesnt exists");

            int sportId = _getSportId(sportName);

            if (sportId == -1)
                throw new Exception($"Error When fetching sport Id of given sport name {sportName}");

            string query = $"DELETE FROM sports where id={sportId}";

            return _queryHelper(query);

        }

        public  int RemoveTournament(string name)
        {
            int tournamentId = _getTournamentId(name);

            if (tournamentId == -1)
                throw new Exception($"Tournament with {name} doesnt exists");

            string query = $"DELETE FROM tournament where tournament_id={tournamentId}";

            return _queryHelper(query);
        }

        public  int MakePaymentPlayer(string playerName,string tournamentName,string sportName)
        {
            int tournamentId = _getTournamentId(tournamentName);

            if (tournamentId == -1)
                throw new Exception($"Tournament with name {tournamentName} doesnt exists");

            int sportId=_getSportId(sportName);
            if (sportId == -1)
                throw new Exception($"Sport with {sportName} doesnt exist");

            if(!_sportExistsTournament(sportId))
                throw new Exception($"Sport with {sportName} doesnt exist in tournament {tournamentName}");

            int playerId = _getPlayerId(playerName);

            if (playerId == -1)
                throw new Exception($"player with {playerName} doesnt exist");

            string query = $"INSERT INTO enroll values({tournamentId},{playerId},{null},{sportId},paid);";

            return _queryHelper(query);
        }

        

        public  int MakePaymentTeam(string teamName, string tournamentName, string sportName)
        {
            int tournamentId = _getTournamentId(tournamentName);

            if (tournamentId == -1)
                throw new Exception($"Tournament with name {tournamentName} doesnt exists");

            int sportId = _getSportId(sportName);
            if (sportId == -1)
                throw new Exception($"Sport with {sportName} doesnt exist");

            if (!_sportExistsTournament(sportId))
                throw new Exception($"Sport with {sportName} doesnt exist in tournament {tournamentName}");

            int teamId = _getTeamId(teamName);

            if (teamId == -1)
                throw new Exception($"Team with {teamName} doesnt exist");

            string query = $"INSERT INTO enroll values({tournamentId},{null},{teamId},{sportId},paid);";

            return _queryHelper(query);
        }








    }
}
