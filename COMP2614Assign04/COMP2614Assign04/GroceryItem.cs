using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    class GroceryItem : IComparable<GroceryItem>
    {
        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime ExpriationDate { get; set;  }

        public int CompareTo(GroceryItem groceryArgument)
        {
            if (groceryArgument == null)
            {
                return 1;
            }
            return -this.Price.CompareTo(groceryArgument.Price);
        }
    }
}
