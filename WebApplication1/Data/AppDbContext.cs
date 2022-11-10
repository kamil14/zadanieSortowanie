using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Osoba> Osoba { get; set; }
    }
}
