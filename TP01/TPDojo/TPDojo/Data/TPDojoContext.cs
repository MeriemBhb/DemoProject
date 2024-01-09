using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BO;

namespace TPDojo.Data
{
    public class TPDojoContext : DbContext
    {
        public TPDojoContext (DbContextOptions<TPDojoContext> options)
            : base(options)
        {
        }

        public DbSet<BO.Armes> Armes { get; set; } = default!;
    }
}
