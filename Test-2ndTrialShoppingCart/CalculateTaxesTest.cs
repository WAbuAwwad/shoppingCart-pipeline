using System;
using Xunit;
using _2ndTrialShoppingCart;
using System.Collections.Generic;

namespace Test_2ndTrialShoppingCart
{
    public class CalculateTaxesTest
    {
        [Fact]
        public void CalculateTaxes_ShouldReturnCorrectResult_WhenZeroItems()
        {
            //Fixture setup
            var cart = new ShoppingCart();
            var sut = cart.CreateCart();
            var Taxes= new Taxes();
            var expected = 0;
            //Excercise system
            sut = Taxes.Calculate(sut);
            var actual = sut.Taxes;
            //Verify outcome
            Assert.Equal(actual, expected);
            //Teardown
        }
        [Fact]
        public void CalculateTaxes_ShouldReturnCorrectResult_WhenOneItemAdded()
        {
            //Fixture setup
            var cart = new ShoppingCart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            var Item = new Item();
            Item.Add(sut, item);
            var Taxes = new Taxes();
            var expected = 0.525;
            //Excercise system
            sut = Taxes.Calculate(sut);
            var actual =sut.Taxes;
            //Verify outcome
            Assert.Equal(actual, expected);
            //Teardown
        }

        [Fact]
        public void CalculateTaxes_ShouldReturnCorrectResult_WhenMoreThanOneItemAdded()
        {
            //Fixture setup
            var cart = new ShoppingCart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            var Item = new Item();
            Item.Add(sut, item);
            Item.Add(sut, item);
            Item.Add(sut, item);
            var Taxes = new Taxes();
            var expected = 1.575;

            //Excercise system
            sut = Taxes.Calculate(sut);
            var actual = sut.Taxes;
            //Verify outcome
            Assert.Equal(actual.ToString(), expected.ToString());
            //Teardown
        }

    }
}
