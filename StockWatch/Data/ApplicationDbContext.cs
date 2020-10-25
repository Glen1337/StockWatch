using StockWatch.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            modelBuilder.Entity<Portfolio>().HasData(new Portfolio { UserId = "9722240c-3e76-4150-b241-70770531c119", PortfolioId = 2, Title = "Glen's Portfolio 1" });


            // Trades - Required
            modelBuilder.Entity<Trade>().Property(t => t.TradeId).IsRequired();
            modelBuilder.Entity<Trade>().Property(t => t.Price).IsRequired();
            modelBuilder.Entity<Trade>().Property(t => t.Quantity).IsRequired();
            modelBuilder.Entity<Trade>().Property(t => t.Symbol).IsRequired();

            // Trades - Seeds
            modelBuilder.Entity<Trade>().HasData(new Trade { PortfolioId = 1, TradeId = 1, Price = 67.24m, Quantity = 12m, Symbol = "FSLR", Action = "Sell", Type = "Stock" });
            modelBuilder.Entity<Trade>().HasData(new Trade { PortfolioId = 1, TradeId = 2, Price = 27.67m, Quantity = 612m, Symbol = "SNAP", Action = "Buy", Type = "Stock" });
            modelBuilder.Entity<Trade>().HasData(new Trade { PortfolioId = 2, TradeId = 3, Price = 1027.38m, Quantity = 2m, Symbol = "CMG", Action = "Buy", Type = "Stock" });
            modelBuilder.Entity<Trade>().HasData(new Trade { PortfolioId = 2, TradeId = 4, Price = 77.03m, Quantity = 2m, Symbol = "AMD", Action = "Sell", Type = "Stock" });
        }

        public DbSet<Trade> Trades { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
