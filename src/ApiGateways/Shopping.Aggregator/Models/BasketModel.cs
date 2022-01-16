using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Models
{
    public class BasketModel
    {
        public string UserName { get; set; }
        public List<BasketItemExtenndedModel> Items { get; set; } = new List<BasketItemExtenndedModel>();
        public decimal TotalPrice { get; set; }

    }
}
