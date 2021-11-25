using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Models
{
    public class DataBaseContext: DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options) { }

        /// <summary>
        /// method returning accounts table
        /// </summary>
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// method returning manufacturers table
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; }

        /// <summary>
        /// method returning baskets table
        /// </summary>
        public DbSet<Basket> Baskets { get; set; }

        /// <summary>
        /// method returning guitars table
        /// </summary>
        public DbSet<Guitar> Guitars { get; set; }

    }
}
