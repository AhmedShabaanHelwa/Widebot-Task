using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //!AhmedShaban: Define the database tables
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<User>().HasData( new List<User> {  
                    new User
                    { Id = 1, email = "george.bluth@reqres.in", first_name = "George", last_name = "Bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg" },
                    new User
                    { Id = 2, email = "janet.weaver@reqres.in", first_name = "Janet", last_name = "Weaver", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/josephstein/128.jpg" },
                    new User
                    { Id = 3, email = "emma.wong@reqres.in", first_name = "Emma", last_name = "Wong", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/olegpogodaev/128.jpg" },
                    new User
                    { Id = 4, email = "eve.holt@reqres.in", first_name = "Eve", last_name = "Holt", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/marcoramires/128.jpg" },
                    new User
                    { Id = 5, email = "charles.morris@reqres.in", first_name = "Charles", last_name = "Morris", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/stephenmoon/128.jpg" },
                    new User
                    { Id = 6, email = "tracey.ramos@reqres.in", first_name = "Tracey", last_name = "Ramos", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/bigmancho/128.jpg" }
                }
                );
        }
    }
}
