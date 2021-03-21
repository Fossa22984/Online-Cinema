using Online_Cinema_Domain.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_Domain.Models
{
   public  class Subscription
    {
        public int Id { get; set; }
        public string SubscriptionName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public IList<User> Users { get; set; }

        public Subscription()
        {
            Users = new List<User>();
        }

        public bool Remote { get; set; }
    }
}