using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Models
{
    public class DBContent:DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Game> Games { set; get; }
        public DbSet<Genre> Genres { set; get; }
    }
}
