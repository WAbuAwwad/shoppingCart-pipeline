using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
    public interface API
    {
     ShoppingCart CreateCart();
     ShoppingCart AddItem(ShoppingCart shcart ,CartItem item);
     ShoppingCart AddDiscount(ShoppingCart shcart, discountType discount, double discountAmount);
     ShoppingCart CalculateTaxes(ShoppingCart shcart);
     ShoppingCart CalculateTotal(ShoppingCart shcart);

    }
}
