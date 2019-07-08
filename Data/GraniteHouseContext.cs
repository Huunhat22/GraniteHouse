using System;
using System.Collections.Generic;
using System.Text;
using Granite_House.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Granite_House.Data
{
    public class GraniteHouseContext : IdentityDbContext
    {
        public GraniteHouseContext(DbContextOptions<GraniteHouseContext> options)
            : base(options)
        {
        }
        public DbSet<ProductType> productTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductType>().ToTable("ProductType");
        }
    }
}
