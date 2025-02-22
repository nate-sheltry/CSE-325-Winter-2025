using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyScriptureJournalContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyScriptureJournalContext>>()))
        {
            if (context == null || context.Scripture == null)
            {
                throw new ArgumentNullException("Null MyScriptureJournalContext");
            }

            // Look for any movies.
            if (context.Scripture.Any())
            {
                return;   // DB has been seeded
            }

            context.Scripture.AddRange(
                new Scripture
                {
                    Book = "Abraham",
                    Range = "1:7",
                    Notes = "I love abraham, this is such a good read",
                    DateAdded = DateTime.Parse("2010-2-12"),
                },

                new Scripture
                {
                    Book = "Genesis",
                    Range = "39:22",
                    Notes = "The power of the sun in the palm of my hand.",
                    DateAdded = DateTime.Parse("2012-6-1"),
                },

                new Scripture
                {
                    Book = "Leviticus",
                    Range = "17:5",
                    Notes = "It's pizza time.",
                    DateAdded = DateTime.Parse("2007-5-30"),
                }
            );
            context.SaveChanges();
        }
    }
}