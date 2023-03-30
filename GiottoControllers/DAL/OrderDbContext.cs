using GiottoControllers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiottoControllers.DAL
{
    public class OrderDbContext : DbContext
    {
        public DbSet<OrderModel> OrderData { get; set; }

        public OrderDbContext()
        {
        }

        public OrderDbContext(DbContextOptions
<OrderDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NAG6CHANDRVAR01; initial catalog=OrderDb;integrated security=true;");
        }
    }
}
