using Microsoft.EntityFrameworkCore;
using QandA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions options) : base(options)
        {

        }

        // public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
