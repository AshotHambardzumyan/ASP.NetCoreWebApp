using System;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreWebApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP.NetCoreWebApp.Data
{
    public class PersonDbContext : IPersonDbContext
    {
        public List<Person> People { get; set; }
        public List<PersonAccount> PersonAccounts { get; set; }

        public PersonDbContext()
        {
            People = new List<Person>();
            PersonAccounts = new List<PersonAccount>();
        }
    }

    public interface IPersonDbContext
    {
        List<Person> People { get; set; }
        List<PersonAccount> PersonAccounts { get; set; }
    }
}