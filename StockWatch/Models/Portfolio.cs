using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockWatch.Models
{
    public class Portfolio
    {
        public long PortfolioId { get; set; }
        public string Title { get; set; }
        public ICollection<Holding> Holdings { get; set; }
        public decimal TotalValue { get; set; }
        // FK = UserId
        public string UserId { get; set; }
        //[ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

    }
}
