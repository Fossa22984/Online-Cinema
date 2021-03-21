using Online_Cinema_Domain.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_Domain.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string Password { get; set; }
        public string CreatorName { get; set; }
        public bool IsOpen { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public IList<User> Participants { get; set; }

        public Room()
        {
            Participants = new List<User>();
        }

        public bool Remote { get; set; }
    }
}
