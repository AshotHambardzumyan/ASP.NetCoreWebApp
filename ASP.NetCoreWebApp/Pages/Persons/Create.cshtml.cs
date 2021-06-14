using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP.NetCoreWebApp.Data;
using ASP.NetCoreWebApp.Models;

namespace ASP.NetCoreWebApp.Pages.Persons
{
    public class CreateModel : PageModel
    {
        private readonly IPersonDbContext _context;

        public CreateModel(IPersonDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Person Person { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.People.Add(Person);
            //await _context.SaveChangesAsync();

            Person.Id = _context.People.LastIndexOf(Person);

            return RedirectToPage("./Index");
        }
    }
}
