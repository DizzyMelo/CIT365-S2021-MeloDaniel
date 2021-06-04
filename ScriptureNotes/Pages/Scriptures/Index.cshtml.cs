using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureNotes.Models;

namespace ScriptureNotes.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureNotesContext _context;

        public IndexModel(ScriptureNotesContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOption { get; set; }
        public SelectList Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        public async Task OnGetAsync()
        {

            IQueryable<string> bookQuery = from s in _context.Scripture
                                    orderby s.Book
                                    select s.Book;
            
            var scriptures = from m in _context.Scripture
                 select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(SortOption))
            {
                switch (SortOption)
                {
                    case "book_desc":
                        scriptures = scriptures.OrderByDescending(s => s.Book);
                        break;
                    case "date_asc":
                        scriptures = scriptures.OrderBy(s => s.DateAdded);
                        break;
                    case "date_desc":
                        scriptures = scriptures.OrderByDescending(s => s.DateAdded);
                        break;
                    default:
                        scriptures = scriptures.OrderBy(s => s.Book);
                        break;
                }
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scriptures.ToListAsync();
        }
    }
}
