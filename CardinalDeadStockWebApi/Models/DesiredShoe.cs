using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalDeadStockWebApi.Models
{
    public class DesiredShoe
    {
        public Guid DesiredShoeId { get; set; }
        public string OwnerID { get; set; }        // user ID from AspNetUser table.
        public string Description { get; set; }
        public string URL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ShoeType ShoeType { get; set; }
    }
}
