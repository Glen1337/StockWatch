using StockWatch.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace StockWatch.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Portoflio - FK
            //modelBuilder.Entity<Portfolio>()

            // Portfolio - Seeds
            modelBuilder.Entity<Portfolio>().HasData(new Portfolio { UserId = "53ab1a2c-b170-4232-9958-a1266114803c", PortfolioId = 1, Title = "Glen's Portfolio 1"});
            modelBuilder.Entity<Portfolio>().HasData(new Portfolio { UserId = "9722240c-3e76-4150-b241-70770531c119", PortfolioId = 2, Title = "NOT Glen's portfolio" });


            // Holdings - Required Fields
            //modelBuilder.Entity<Holding>().Property(t => t.HoldingId).IsRequired();
            //modelBuilder.Entity<Holding>().Property(t => t.CostBasis).IsRequired();
            //modelBuilder.Entity<Holding>().Property(t => t.Quantity).IsRequired();
            //modelBuilder.Entity<Holding>().Property(t => t.Symbol).IsRequired();

            // Holdings - Seeds
            modelBuilder.Entity<Holding>().HasData(new Holding { PortfolioId = 1, HoldingId = 1, CostBasis = 67.24m, Quantity = 12m, Symbol = "FSLR", Action = "Sell", Type = "Stock" });
            modelBuilder.Entity<Holding>().HasData(new Holding { PortfolioId = 1, HoldingId = 2, CostBasis = 27.67m, Quantity = 612m, Symbol = "SNAP", Action = "Buy", Type = "Stock" });
            modelBuilder.Entity<Holding>().HasData(new Holding { PortfolioId = 2, HoldingId = 3, CostBasis = 1027.38m, Quantity = 2m, Symbol = "CMG", Action = "Buy", Type = "Stock" });
            modelBuilder.Entity<Holding>().HasData(new Holding { PortfolioId = 2, HoldingId = 4, CostBasis = 77.03m, Quantity = 2m, Symbol = "AMD", Action = "Sell", Type = "Stock" });
        }

        public DbSet<Holding> Holdings { get; set; }
        // TODO : create list of holdings that make up the current image of a portfolio. Trade should only be used as a transaction history
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
