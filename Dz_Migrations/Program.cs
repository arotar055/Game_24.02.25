using System;
using System.Linq;
using GamesDbContextLibrary;
using GameLibrary;

namespace Dz_Migrations
{
    internal class Program
    {
        static void Main() 
        {
            try
            {
                using (var db = new GamesContext()) 
                {
                    if (!db.Games.Any())
                    {
                        var firstG = new Game
                        {
                            Title = "Fortnite",
                            Publisher = "Epic Games",
                            Genre = " battle royale game",
                            ReleaseDate = new DateTime(2017, 7, 25),
                            GameMode = "Multiplayer",
                            CopiesSold = 10000000
                        };
                        var secondG = new Game
                        {
                            Title = "EA Sports FC 25",
                            Publisher = "EA Sports",
                            Genre = "football simulation games",
                            ReleaseDate = new DateTime(2024, 9, 27),
                            GameMode = "Multiplayer",
                            CopiesSold = 125000000
                        };
                        var third3 = new Game
                        {
                            Title = "Cyberpunk 2077",
                            Publisher = "CD Projekt",
                            Genre = "Action role-playing",
                            ReleaseDate = new DateTime(2020, 10, 12),
                            GameMode = "Singleplayer",
                            CopiesSold = 44000000
                        };

                        db.Games.AddRange(firstG, secondG, third3);
                        db.SaveChanges();
                        Console.WriteLine("Данные добавленны в базу данных!");
                    }
                    else
                    {
                        Console.WriteLine("В базе уже есть жанные.");
                    }
                    var ListG = db.Games.ToList();
                    Console.WriteLine("\nИгры в базе данных:");
                    foreach (var g in ListG)
                    {
                        Console.WriteLine($"Id={g.Id}; Genre={g.Genre}; Title={g.Title}; Publisher={g.Publisher}; ReleaseDate={g.ReleaseDate.ToShortDateString()}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}"); 
            }
            Console.WriteLine("\nЕажмите любую клавишу чтобы выйти");
            Console.ReadKey();
        }
    }
}
