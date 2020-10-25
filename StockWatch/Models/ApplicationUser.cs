using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWatch.Models
{
    public class ApplicationUser : IdentityUser
    {
       // Properties are inherited (but hidden) from IdentityUser
       public List<Portfolio> Portfolios { get; set; }
       
    }
}
