using Online_Cinema_Core.Context;
using Online_Cinema_Domain.Models;
using Online_Cinema_Domain.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_BLL.Services
{
    public class Test
    {
        private readonly OnlineCinemaContext _context;

        public Test(OnlineCinemaContext context)
        {
            this._context = context;
        }

        public IList<Movie> GetMovies() => _context.Movies.ToList();     
    }
}
