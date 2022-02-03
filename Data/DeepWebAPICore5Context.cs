using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeepWebAPICore5.Models;

namespace DeepWebAPICore5.Data
{
    public class DeepWebAPICore5Context : DbContext
    {
        public DeepWebAPICore5Context (DbContextOptions<DeepWebAPICore5Context> options)
            : base(options)
        {
        }

        public DbSet<DeepWebAPICore5.Models.Customer> Customer { get; set; }
    }
}
