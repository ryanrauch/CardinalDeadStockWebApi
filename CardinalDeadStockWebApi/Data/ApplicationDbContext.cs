using System;
using System.Collections.Generic;
using System.Text;
using CardinalDeadStockWebApi.Data.ApplicationDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CardinalDeadStockWebApi.Data
{
    // use Package Manager Console:
    // Add-Migration dbm000
    // Update-Database

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DesiredShoe> DesiredShoes { get; set; }
        public DbSet<ShippingProfile> ShippingProfiles { get; set; }
    }
}
