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
                        Descriprion = "A Mafia-like social game based on deseption and deduction",
                        ReleaseDate = DateTime.Parse("2018-11-13"),
                        Genre = "Social Deduction",
                        Price = 19.99M,
                        Studio = "Innersloth"
                    },
                    new Game
                    {
                        Title = "CS:GO",
                        Descriprion = "A popular tactical FPS",
                        ReleaseDate = DateTime.Parse("2016-7-13"),
                        Genre = "FPS",
                        Price = 39.99M,
                        Studio = "Valve"
                    },
                    new Game
                    {
                        Title = "Rust",
                        Descriprion = "The only aim in Rust is to survive. Everything wants you to die - the island’s wildlife and other inhabitants, the environment, other survivors. Do whatever it takes to last another night.",
                        ReleaseDate = DateTime.Parse("2018-2-8"),
                        Genre = "Survival",
                        Price = 39.99M,
                        Studio = "Facepunch Studios"
                    },
                    new Game
                    {
                        Title = "The Forest",
                        Descriprion = "As the lone survivor of a passenger jet crash, you find yourself in a mysterious forest battling to stay alive against a society of cannibalistic mutants.",
                        ReleaseDate = DateTime.Parse("2018-4-30"),
                        Genre = "Survival",
                        Price = 29.99M,
                        Studio = "Endnight Games Ltd"
                    },
                    new Game
                    {
                        Title = "Dragon Age Inqusition",
                        Descriprion = "When the sky opens up and rains down chaos, the world needs heroes. Become the savior of Thedas in Dragon Age: Inquisition. You are the Inquisitor, tasked with saving the world from itself. But the road ahead is paved with difficult decisions. Thedas is a land of strife.",
                        ReleaseDate = DateTime.Parse("2014-11-14"),
                        Genre = "RPG",
                        Price = 49.99M,
                        Studio = "BioWare"
                    },
                    new Game
                    {
                        Title = "The Witcher 3",
                        Descriprion = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.",
                        ReleaseDate = DateTime.Parse("2015-5-18"),
                        Genre = "RPG",
                        Price = 29.99M,
                        Studio = "CD PROJEKT RED"
                    }
                    );
                context.SaveChanges();
            }

        }
}
