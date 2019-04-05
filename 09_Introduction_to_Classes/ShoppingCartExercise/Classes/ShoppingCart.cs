using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        public int TotalNumberOfItems { get; private set; }
        public decimal TotalAmountOwed { get; private set; }

        public ShoppingCart()
        {
            this.TotalNumberOfItems = 0;
            this.TotalAmountOwed = 0.0m;
        }

        public decimal GetAveragePricePerItem()
        {
            if (TotalNumberOfItems > 0)
            {
                return this.TotalAmountOwed / this.TotalNumberOfItems;
            }
            return this.TotalAmountOwed;
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            this.TotalNumberOfItems = numberOfItems;
            this.TotalAmountOwed += pricePerItem * numberOfItems;
        }

        public void Empty()
        {
            this.TotalNumberOfItems = 0;
            this.TotalAmountOwed = 0.0m;
        }
       
    }
}
