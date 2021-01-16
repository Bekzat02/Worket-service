using EmailService;
using Microsoft.EntityFrameworkCore;
using Stazhirovka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<GenreReference> GenreReferences { get; set; }
    }
}
