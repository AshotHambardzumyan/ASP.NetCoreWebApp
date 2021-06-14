using System;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreWebApp.Data;
using ASP.NetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NetCoreWebApp.Pages.Persons
{
    public class DetailsModel : PageModel
    {
        private readonly IPersonDbContext _context;

        public DetailsModel(IPersonDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public Task OnGet(int? id)
        {
            if (id == null)
            {
                return Task.FromResult(NotFound());
            }

            Person = _context.People.FirstOrDefault(m => m.Id == id);

            if (Person == null)
            {
                return Task.FromResult(NotFound());
            }
            return Task.FromResult(Page());
        }
    }
}