using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace vendasWebMvc.Models
{
    public class vendasWebMvcContext : DbContext
    {
        public vendasWebMvcContext (DbContextOptions<vendasWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<vendasWebMvc.Models.Departamento> Departamento { get; set; }
    }
}
