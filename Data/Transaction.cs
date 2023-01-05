using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTF.api.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public List<Item>? purchasedItems { get; set; }

        public decimal TotalCost
        {
            get
            {
                var grandTotal = purchasedItems.Sum(x => x.Price);
                return grandTotal;
            }
        }
    }
}