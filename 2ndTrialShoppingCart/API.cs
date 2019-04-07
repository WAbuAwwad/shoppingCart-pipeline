using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
    public interface API
    {
     ShoppingCart CreateCart();
     ShoppingCart AddItem(ShoppingCart shcart ,CartItem item);
    }
}
