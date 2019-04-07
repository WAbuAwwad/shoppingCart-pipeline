using System.Collections.Generic;

namespace _2ndTrialShoppingCart
{
    public enum discountType
    {
     perItem,
     perCart
    };
    public class ShoppingCart 
    {
        private List<CartItem> items;
        private double taxes;
        private double total;
        private List<discountType> discounts;
        public List<CartItem> Items { get { return items; } }
        public List<discountType> Discounts { get { return discounts; } }
        public double Taxes { get { return taxes; }set { taxes = value; } }
        public double Total { get { return total; } set { total = value; } }

        public ShoppingCart()
        {
           items = new List<CartItem>();
           discounts = new List<discountType>();
            taxes = 0;
            total = 0;
        }
    }
}