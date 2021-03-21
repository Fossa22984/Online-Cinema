using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_Domain.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public int DateOfRelease { get; set; }//Дата выпуска 
        public int Duration { get; set; }//Продолжительность 
        public string Author { get; set; }
        public string Actors { get; set; }

        public string Country { get; set; }
        public int AgeLimit { get; set; }//Возрастное ограничение
        public string Description { get; set; }//Описание
        public double CristicsRating { get; set; }//Рейтинг критиков 
        public int UserRating { get; set; }
        public decimal MovieBudget { get; set; }//Бюджет фильма 


        public IList<Genre> Genre { get; set; }//Жанр 
        public IList<Comment> Comments { get; set; }
        public IList<Session> Sessions { get; set; }
        public IList<Room> Rooms { get; set; }
        
        public Movie()
        {
            Comments = new List<Comment>();
            Sessions = new List<Session>();
            Genre = new List<Genre>();
            Rooms= new List<Room>();
        }
        public bool Remote { get; set; }
    }
}
