using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ASP.NetCoreWebApp.Models
{
    public class PersonAccount
    {
        public int Id { get; set; }
        public long AcoountNumber { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}