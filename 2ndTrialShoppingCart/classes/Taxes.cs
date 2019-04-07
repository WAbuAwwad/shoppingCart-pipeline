using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
    public class Taxes
    {
        public ShoppingCart Calculate(ShoppingCart shcart)
        {
            double taxes = 0;
            foreach (var item in shcart.Items)
            {
                taxes += item.Price * item.Taxe;
            }
            shcart.Taxes = taxes;
            return shcart;
        }
    }
}
