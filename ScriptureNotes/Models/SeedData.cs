using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ScriptureNotes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureNotesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureNotesContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Note = "Nephi and his brothers go back to Jerusalem",
                        DateAdded = DateTime.Parse("2021-05-20"),
                        Chapter = "4",
                        Verse = "1"
                    },

                    new Scripture
                    {
                        Book = "2 Nephi",
                        Note = "Baptism is required to enter the kingdom of God",
                        DateAdded = DateTime.Parse("2021-05-22"),
                        Chapter = "31",
                        Verse = "4-5"
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Note = "Alma teaches his son to keep the commandments",
                        DateAdded = DateTime.Parse("2021-05-23"),
                        Chapter = "37",
                        Verse = "18"
                    },

                    new Scripture
                    {
                        Book = "Moroni",
                        Note = "By the power of the Holy Ghost we can know all truth",
                        DateAdded = DateTime.Parse("2021-05-25"),
                        Chapter = "10",
                        Verse = "5"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}