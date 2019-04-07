using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
  public  class Discount
    {
        public ShoppingCart Add(ShoppingCart shcart, discountType discount, double discountAmount)
        {
            shcart.Discounts.Add(discount);
            shcart.Discount = discountAmount;
            return shcart;
        }
    }
}
