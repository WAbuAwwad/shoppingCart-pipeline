using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndTrialShoppingCart
{
  public  class Currency
    {

        public ShoppingCart Change(ShoppingCart shcart, string currency)
        {
            var Total = new Total();
            shcart.Total = Total.Calculate(shcart).Total * ExchangeCurrency(currency);
            return shcart;

        }
        private double ExchangeCurrency(string currency)
        {

            if (currency.ToUpper() == "EUR") return 1.5;
            else if (currency.ToUpper() == "NIS") return 3.5;
            else if (currency.ToUpper() == "AUD") return 5.8;
            else if (currency.ToUpper() == "SAR") return 2.7;
            else return 1;
        }
    }
}
