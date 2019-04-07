using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
  public  class CartItem
    {
        private int id;
        private double price;
        private double taxe;
        private double discount;
        public int Id { get { return id; } }
        public double Taxe { get { return taxe; } }
        public double Price { get { return price; } }
        public double Discount { get { return discount; } }
        
        public CartItem(int Id , double Price,double Taxe, double Discount)
        {
            id = Id;
            price = Price;
            taxe = Taxe;
            discount = Discount;
        }

    }
}
