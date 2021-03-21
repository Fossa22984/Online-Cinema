using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Cinema_Domain.Models;
using Online_Cinema_Domain.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Cinema_Core.Context
{
    public class OnlineCinemaContext : IdentityDbContext<User, Role, Guid>
    {
        public OnlineCinemaContext(DbContextOptions<OnlineCinemaContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Comment> Comments {get;set;}
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
