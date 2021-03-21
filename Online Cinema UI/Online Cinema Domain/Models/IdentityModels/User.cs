using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Online_Cinema_Domain.Models.IdentityModels
{
    public class User : IdentityUser<Guid>
    {
        public string Status { get; set; }
        public int Age { get; set; }

        public int? SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }

        public IList<User> Friends { get; set; }
        public IList<Session> SessionHistory { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Room> Rooms { get; set; }

        public User()
        {
            Friends = new List<User>();
            SessionHistory = new List<Session>();
            Comments = new List<Comment>();
            Rooms= new List<Room>();
        }

    }
}
