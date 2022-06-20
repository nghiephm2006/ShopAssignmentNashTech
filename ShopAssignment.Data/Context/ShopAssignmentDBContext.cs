using Microsoft.EntityFrameworkCore;
using ShopAssignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAssignment.Data.Context
{
    public class ShopAssignmentDBContext : DbContext
    {
        public ShopAssignmentDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
