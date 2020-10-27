using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockWatch.Models
{
    public class Holding
    {
        // ID
        public long HoldingId { get; set; }

        // Cost per share
        public decimal CostBasis { get; set; }
        
        // Quantity bought/sold
        public decimal Quantity { get; set; }

        // Ticker
        //[Required]
        //[StringLength(8, ErrorMessage = "Symbol is limited to 8 characters")]
        public string Symbol { get; set; }

        // Date/Time when transaction occured
        public DateTime TransactionStamp { get; set; }

        // Buy/Sell
        public string Action { get; set; }

        // Stock/Options
        public string Type { get; set; }

        public long PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; }

    }
}
