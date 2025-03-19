using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RezorPagesApp.Data;
using RezorPagesApp.Models;

namespace RezorPagesApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RezorPagesApp.Data.RezorPagesAppContext _context;

        public IndexModel(RezorPagesApp.Data.RezorPagesAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
