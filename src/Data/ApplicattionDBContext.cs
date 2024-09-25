using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simulacro.src.Models;

namespace simulacro.src.Data
{
    public class ApplicattionDBContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions) 
    {
        public DbSet<Product> Products = null!;
    }
}