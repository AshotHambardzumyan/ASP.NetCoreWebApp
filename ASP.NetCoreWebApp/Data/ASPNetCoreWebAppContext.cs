using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NetCoreWebApp.Models;

namespace ASP.NetCoreWebApp.Data
{
    public class ASPNetCoreWebAppContext : DbContext
    {
        public ASPNetCoreWebAppContext(DbContextOptions<ASPNetCoreWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
