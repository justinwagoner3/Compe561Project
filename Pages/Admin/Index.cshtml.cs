using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JustBooks.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JustBooks.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly JustBooks.Models.BookContext _context;

        public IndexModel(JustBooks.Models.BookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }
        public IList<Book> Author { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            var books = from m in _context.Book
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.Contains(searchString));
            }

            Book = await books.ToListAsync();

            
        }

    }
}
