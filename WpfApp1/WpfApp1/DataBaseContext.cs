using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1
{
   public class DataBaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = users.db");
        }
    }
}