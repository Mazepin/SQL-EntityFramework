using System;
using System.Data.Entity; // подключаем 

namespace SQL_Test
{
    public class MyDbContext : DbContext // наследуем от стандартного DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }

        // указываем все наборы таблиц которые будут использоваться
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
 