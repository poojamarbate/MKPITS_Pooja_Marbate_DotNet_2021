using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

       
        public Item(int ID ,decimal Price, string Name)
        {
            this.Price = Price;
            this.ItemId = ID;
            this.Name = Name;
        }

        public override string ToString()
        {
            return ItemId+" ,"+Name+" ,"+Price;
        }
        public decimal GetAmount(int Qty)
        {
            return Price * Qty;
        }
        
    }
}
