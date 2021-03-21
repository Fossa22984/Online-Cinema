using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_Domain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public IList<Movie> Movies { get; set; }

        public Genre()
        {
            Movies = new List<Movie>();
        }

        public bool Remote { get; set; }
    }
}