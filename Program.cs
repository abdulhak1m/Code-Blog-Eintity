using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
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

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song() { Name = "In the end", GroupId = group2.id},
                    new Song() { Name = "Numb", GroupId = group2.id},
                    new Song() { Name = "Multer", GroupId = group2.id}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();
                // Изменение данных
                var s = context.Groups.Single(x => x.id == group.id);
                s.Name = "Test";
                context.SaveChanges();
                foreach (var song in songs)
                {
                    Console.WriteLine($"Songs name: {song.Name}, Group name: {song.Group.Name}");
                }
                Console.ReadKey();
            }
        }
    }
}
