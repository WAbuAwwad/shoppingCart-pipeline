﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{

   public class Cart : API
    {
        public ShoppingCart AddDiscount(ShoppingCart shcart, discountType discount,double discountAmount)
        {
            shcart.Discounts.Add(discount);
            shcart.Discount = discountAmount;
            return shcart;
        }

        public ShoppingCart AddItem(ShoppingCart shcart, CartItem item)
        {
            shcart.Items.Add(item);
            return shcart;
        }

        public ShoppingCart CalculateTaxes(ShoppingCart shcart)
        {
            double taxes = 0;
            foreach (var item in shcart.Items)
            {
                taxes += item.Price * item.Taxe;
            }
            shcart.Taxes = taxes;
            return shcart;
        }

        public ShoppingCart CalculateTotal(ShoppingCart shcart)
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
                        shcart.Total =total-( total * shcart.Discount);
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
       
        public ShoppingCart CreateCart()
        {
            return new ShoppingCart();
        }

    }
}
