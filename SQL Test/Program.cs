using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using(var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };

                context.Groups.Add(group); // добавляем группу в контекст, но она еще не в базе данных. Нужно еще сохранить
                context.SaveChanges(); // сохраняем все изменения из локального хранилища в базу данных

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
                Console.ReadKey();
            }
        }
    }
}
