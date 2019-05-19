using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace FootballManagement.DataLayer
{
    
    public class PlayerRepository<T> : IRepository<T> where T : class
    {
        private MySqlConnection _connection;

        public PlayerRepository(string connection)
        {
            _connection = new MySqlConnection(connection);
        }

        public IEnumerable<T> GetAll()
        {
             var sql = "SELECT * FROM footballmanagementdb.players;";
             MySqlCommand _cmd = new MySqlCommand(sql,_connection);      
                        
            _connection.Open();
            MySqlDataReader rdr = _cmd.ExecuteReader();
            var list = new List<T>();

            while (rdr.Read())
            {
                var player = Activator.CreateInstance<T>();
                player.GetType().GetProperty("Id").SetValue(player, Convert.ToInt32(rdr.GetString("Id")));
                player.GetType().GetProperty("FirstName").SetValue(player, rdr.GetString("PlayerFirstName"));
                player.GetType().GetProperty("LastName").SetValue(player, rdr.GetString("PlayersLastName"));
                list.Add(player);
            }

            return list;                  
        }
    }
}

