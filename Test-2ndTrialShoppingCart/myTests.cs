using System;
using Xunit;
using _2ndTrialShoppingCart;
using System.Collections.Generic;

namespace Test_2ndTrialShoppingCart
{
   public class myTests
    {
        [Fact]
        public void pipeline()
        {
            //Fixture setup
            var item = new CartItem(1, 17.5,.03, 0);
            var sut = new Total().Calculate(
                new Discount().Add(
                new Taxes().Calculate(
                new Total().Calculate(
                      new Item().Add(
                      new ShoppingCart().CreateCart(), item)
                                      )
                                      )
                ,discountType.perCart,.15)
                );

            var expected = 15.32125;
            //Excercise system
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual, expected);
            Assert.Equal(.525, sut.Taxes);
            Assert.Equal(0.15, sut.Discount);
            //Teardown
        }
    }
}
