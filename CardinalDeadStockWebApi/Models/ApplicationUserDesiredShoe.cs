using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalDeadStockWebApi.Models
{
    public class ApplicationUserDesiredShoe
    {
        public Guid ApplicationUserDesiredShoesId { get; set; }
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public Guid DesiredShoeId { get; set; }
        public DesiredShoe DesiredShoe { get; set; }
    }
}
