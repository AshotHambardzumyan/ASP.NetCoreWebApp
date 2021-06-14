using System;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using ASP.NetCoreWebApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NetCoreWebApp.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly IPersonDbContext _context;

        public IndexModel(IPersonDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; }

        public Task OnGetAsync()
        {
            Person = new List<Person>();

            foreach (var item in _context.People)
            {
                Person.Add(item);
            }

            return Task.CompletedTask;
        }
    }
}