using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Models
{
    public class DataBaseContext: DbContext
    {
        //database context constructor
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        //returns guitars table
        public DbSet<Guitar> Guitars { get; set; }

        //returns manufacturers table
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
