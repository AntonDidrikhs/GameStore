using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GameStore.Data;
using System;
using System.Linq;

namespace GameStore.Models
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw = "")
        {
            using (var context = new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                SeedDB(context, testUserPw);
            }
        }

            public static void SeedDB(ApplicationDbContext context, string adminID)
            {
                if (context.Game.Any())
                {
                    return;
                }
                context.Game.AddRange(
                    new Game
                    {
                        Title = "Among Us",
                        Descriprion = "Sus, soosy baka, amogus... SUS",
                        ReleaseDate = DateTime.Parse("2018-11-13"),
                        Genre = "Psychological Horror",
                        Price = 19.99M,
                        Studio = "Antichrist Inc."
                    },
                    new Game
                    {
                        Title = "CS:GO",
                        Descriprion = "A popular tactical FPS",
                        ReleaseDate = DateTime.Parse("2016-7-13"),
                        Genre = "FPS",
                        Price = 39.99M,
                        Studio = "Valve"
                    }
                    );
                context.SaveChanges();
            }

        }
}
