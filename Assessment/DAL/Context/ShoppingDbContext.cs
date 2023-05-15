using BusinessObject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    internal class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext()
        {
            
        }

        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; } 

        public DbSet<Product> Products { get; set; }

        public DbSet<Role> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (
               @"data source=INW-935;initial catalog=AssessmentEF;integrated security=true;TrustServerCertificate=True"
               );
        }
    }
}
