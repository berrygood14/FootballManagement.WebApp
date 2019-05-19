using System;
using FootballManagement.DataLayer;
using FootballManagement.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballManagement.Datalayer.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPlayersFine()
        {
            string connStr = "Server=localhost;Database=footballmanagementdb;Uid=root;Pwd=Stark123!";
            IRepository<Player> players = new PlayerRepository<Player>(connStr);
            var test = players.GetAll();

            var test1 = "dongs";

        }
    }
}
