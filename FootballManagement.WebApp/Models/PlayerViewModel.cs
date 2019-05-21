using FootballManagement.WebApp.Models;
using System.ComponentModel;

namespace FootballManagement.WebApp.Models
{
    public enum Positions
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward,
    }

    public class PlayerViewModel
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Nickname")]
        public string NickName { get; set; }

        [DisplayName("Shirt Number")]
        public int ShirtNumber { get; set; }

        public int Team { get; set; }

        [DisplayName("Position(s)")]
        public Positions Positions { get; set; }
    }
}