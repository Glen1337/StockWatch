using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWatch.Models
{
    public class Trade
    {
        // ID
        public long TradeId { get; set; }

        // Cost per share
        public decimal Price { get; set; }
        
        // Quantity bought/sold
        public decimal Quantity { get; set; }

        // Ticker
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
