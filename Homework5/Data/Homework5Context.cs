using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Homework5.Models;

namespace Homework5.Data
{
    public class Homework5Context : DbContext
    {
        public Homework5Context (DbContextOptions<Homework5Context> options)
            : base(options)
        {
        }

        public DbSet<Homework5.Models.Cart> Cart { get; set; } = default!;
    }
}
