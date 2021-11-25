using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nagy_Norbert_Lab8.Models;

namespace Nagy_Norbert_Lab8.Data
{
    public class Nagy_Norbert_Lab8Context : DbContext
    {
        public Nagy_Norbert_Lab8Context (DbContextOptions<Nagy_Norbert_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Nagy_Norbert_Lab8.Models.Book> Book { get; set; }

        public DbSet<Nagy_Norbert_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Nagy_Norbert_Lab8.Models.Category> Category { get; set; }
    }
}
