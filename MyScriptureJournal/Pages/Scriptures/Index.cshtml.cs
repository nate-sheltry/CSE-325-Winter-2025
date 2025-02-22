using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Books { get; set; }
        public SelectList? SortBys { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? EntryBook { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortBy { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from m in _context.Scripture
                                           orderby m.Book
                                            select m.Book;
            var entries = from m in _context.Scripture select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Notes.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(EntryBook))
            {
                entries = entries.Where(x => x.Book == EntryBook);
            }

            if (!string.IsNullOrEmpty(SortBy))
            {
                if (SortBy == "Date Added")
                {
                    entries = entries.OrderBy(item => item.DateAdded);
                }
                else if (SortBy == "Book")
                {
                    entries = entries.OrderBy(item => item.Book);
                }
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            SortBys = new SelectList(new List<string> { "Book", "Date Added" });
            Scripture = await entries.ToListAsync();
        }
    }
}
