using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace База_данных
{
    internal class Context: DbContext
    {
        public Context()
        {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=Библиотека;username=postgres;password=123456789");
        }
        public DbSet<Library> Library { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<NameClients> NameClients { get; set; }
        public DbSet<AddBook> AddBooks { get; set; }
    }
}
