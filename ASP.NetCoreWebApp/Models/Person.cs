using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ASP.NetCoreWebApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public List<PersonAccount> PersonAccounts { get; set; }
    }
}