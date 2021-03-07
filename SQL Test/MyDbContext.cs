using System;
using System.Data.Entity; // подключаем 

namespace SQL_Test
{
    public class MyDbContext : DbContext
    {
        protected MyDbContext() : base("DbConnectionString")
        {
        }

        // указываем все наборы таблиц которые будут использоваться
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
