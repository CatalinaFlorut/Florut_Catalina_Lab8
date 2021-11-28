using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Florut_Catalina_Lab8.Models;

namespace Florut_Catalina_Lab8.Data
{
    public class Florut_Catalina_Lab8Context : DbContext
    {
        public Florut_Catalina_Lab8Context (DbContextOptions<Florut_Catalina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Florut_Catalina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Florut_Catalina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Florut_Catalina_Lab8.Models.Category> Category { get; set; }
    }
}
