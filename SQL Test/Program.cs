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

            using (var context = new MyDbContext())
            {

                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park",
                };

                var group3 = new Group()
                {
                    Name = "Prodigy",
                    Year = 1990
                };


                context.Groups.Add(group); // добавляем группу в контекст, но она еще не в базе данных. Нужно еще сохранить
                context.Groups.Add(group2);
                context.Groups.Add(group3);
                context.SaveChanges(); // сохраняем все изменения из локального хранилища в базу данных


                var songs = new List<Song>()
                {
                    new Song() {Name = "In The End", GroupId = group2.Id },
                    new Song() {Name = "Numb", GroupId = group2.Id},
                    new Song() {Name = "Mutter", GroupId = group.Id},
                    new Song() {Name = "Deutschland", GroupId = group.Id},
                    new Song() {Name = "Smack My Bits Up", GroupId = group3.Id}
                };

                context.Songs.AddRange(songs); // добавляем сразу коллекцию
                context.SaveChanges();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, \tGroup name: {song.Group?.Name}");
                }
                Console.ReadKey();
            }
        }
    }
}
