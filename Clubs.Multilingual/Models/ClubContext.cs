﻿using Microsoft.EntityFrameworkCore;

namespace Clubs.Multilingual.Models
{
    public class ClubContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public ClubContext(DbContextOptions<ClubContext> options)
           : base(options)
        {
            Database.EnsureCreated();

        }
    }
}
