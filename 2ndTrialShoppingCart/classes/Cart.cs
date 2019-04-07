using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{

   public class Cart : API
    {
        public ShoppingCart AddItem(ShoppingCart shcart, CartItem item)
        {
            shcart.Items.Add(item);
            return shcart;
        }

        public ShoppingCart CreateCart()
        {
            return new ShoppingCart();
        }

    }
}
