using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyScriptureJournal.Data
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext (DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.Scripture> Scripture { get; set; } = default!;
    }
}
