using ApiRestDivisa.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestDivisa.Data
{
    public class DivisaContext : DbContext
    {
        public DivisaContext(DbContextOptions<DivisaContext> options)
            : base(options)
        {
        }

        public DbSet<Cambio> Cambio { get; set; }
    }
}
