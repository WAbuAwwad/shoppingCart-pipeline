using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
  public  class Item
    {
        public ShoppingCart Add(ShoppingCart shcart, CartItem item)
        {
            shcart.Items.Add(item);
            return shcart;
        }
    }
}
