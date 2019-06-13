using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaAcad.Models
{
    public class SistemaAcadContext : DbContext
    {
        public SistemaAcadContext (DbContextOptions<SistemaAcadContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAcad.Models.Categoria> Categoria { get; set; }
    }
}
