using FootballManagement.DataLayer;
using System.Collections.Generic;

namespace FootballManagement.Logic
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        IRepository<Player> _repo;

        public Player(string connection)
        {
            _repo = new PlayerRepository<Player>(connection);
        }

        public IEnumerable<Player> GetAllPlayers()
        {
           return _repo.GetAll();
        }

    }
}
