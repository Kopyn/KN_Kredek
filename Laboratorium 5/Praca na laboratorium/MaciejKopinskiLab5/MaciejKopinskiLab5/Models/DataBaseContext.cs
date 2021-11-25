using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5.Models
{
    public class DataBaseContext: DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Director> Directors { get; set; }
    }
}
