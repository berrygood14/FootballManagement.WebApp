using System.Collections.Generic;

namespace FootballManagement.DataLayer
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
