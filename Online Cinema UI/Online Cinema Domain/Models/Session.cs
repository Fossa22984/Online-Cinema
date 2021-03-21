using Online_Cinema_Domain.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_Domain.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public IList<User> ViewersList  { get; set; }
        public Session()
        {
            ViewersList = new List<User>();
        }

        public bool Remote { get; set; }
    }
}
