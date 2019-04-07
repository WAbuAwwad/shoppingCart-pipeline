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
        private List<discountType> discounts;
        public List<CartItem> Items { get { return items; } }
        public List<discountType> Discounts { get { return discounts; } }

        public ShoppingCart()
        {
           items = new List<CartItem>();
           discounts = new List<discountType>();
        }
    }
}