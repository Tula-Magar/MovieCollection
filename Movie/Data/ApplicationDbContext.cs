using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore;
using Movie.Models;



namespace Movie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
#nullable enable
        }
        public DbSet<Movie.Models.MoviesModel> Movie { get; set; }
    }
}