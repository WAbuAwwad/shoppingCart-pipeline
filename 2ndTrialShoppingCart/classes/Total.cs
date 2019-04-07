using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
   public class Total
    {
        public ShoppingCart Calculate(ShoppingCart shcart)
        {
            double total = 0;
            if (shcart.Discounts.Count == 0)
            {
                foreach (var item in shcart.Items)
                {
                    total += item.Price + item.Price * item.Taxe;
                }
                shcart.Total = total;
            }
            else
            {
                foreach (var Discount in shcart.Discounts)
                {
                    if (Discount == discountType.perCart)
                    {
                        foreach (var item in shcart.Items)
                        {
                            total += item.Price + (item.Price * item.Taxe);
                        }
                        shcart.Total = total - (total * shcart.Discount);
                    }
                    else
                    {
                        foreach (var item in shcart.Items)
                        {
                            total += item.Price - item.Price * item.Discount + item.Price * item.Taxe;
                        }
                        shcart.Total = total;
                    }
                }
            }
            return shcart;

        }

    }
}
