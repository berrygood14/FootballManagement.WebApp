using System.Collections.Generic;

namespace FootballManagement.Domain
{
    public interface IPlayerRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
