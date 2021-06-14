using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP.NetCoreWebApp.Data;
using ASP.NetCoreWebApp.Models;

namespace ASP.NetCoreWebApp.Pages.Persons
{
    public class DeleteModel : PageModel
    {
        private readonly IPersonDbContext _context;

        public DeleteModel(IPersonDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = _context.People.FirstOrDefault(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = _context.People[(int)id];
            //Person.Id++;

            if (Person != null)
            {
                _context.People.Remove(Person);
                //await _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
