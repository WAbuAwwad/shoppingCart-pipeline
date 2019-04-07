using System;
using Xunit;
using _2ndTrialShoppingCart;
using System.Collections.Generic;


namespace Test_2ndTrialShoppingCart
{
    public class CalculateTotalTest
    {
        [Fact]
        public void CalculateTotal_ShouldReturnCorrectResult_WhenZeroItems()
        {
            //Fixture setup
            var cart = new Cart();
            var sut = cart.CreateCart();
            var expected = 0;
            //Excercise system
            sut = cart.CalculateTotal(sut);
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual, expected);
            //Teardown
        }
        [Fact]
        public void CalculateTotal_ShouldReturnCorrectResult_WhenOneItemAdded()
        {
            //Fixture setup
            var cart = new Cart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            cart.AddItem(sut, item);
            var expected = 18.025;
            //Excercise system
            sut = cart.CalculateTotal(sut);
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual, expected);
            //Teardown
        }

        [Fact]
        public void CalculateTotal_ShouldReturnCorrectResult_WhenMoreThanOneItemAdded()
        {
            //Fixture setup
            var cart = new Cart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            cart.AddItem(sut, item);
            cart.AddItem(sut, item);
            cart.AddItem(sut, item);
            var expected = 54.075;
            //Excercise system
            sut = cart.CalculateTotal(sut);
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual.ToString(), expected.ToString());
            //Teardown
        }

        [Fact]
        public void CalculateTotal_ShouldReturnCorrectResult_WhenDiscountPerCart()
        {
            //Fixture setup
            var cart = new Cart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            cart.AddItem(sut, item);
            cart.AddItem(sut, item);
            cart.AddDiscount(sut, discountType.perCart, 0.25);
            var expected = 27.0375;
            //Excercise system
            sut = cart.CalculateTotal(sut);
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual.ToString(), expected.ToString());
            //Teardown
        }

        [Fact]
        public void CalculateTotal_ShouldReturnCorrectResult_WhenDiscountPerItem()
        {
            //Fixture setup
            var cart = new Cart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0.15);
            cart.AddItem(sut, item);
            cart.AddItem(sut, item);
            cart.AddDiscount(sut, discountType.perItem, 0.25);
            var expected = 30.8;
            //Excercise system
            sut = cart.CalculateTotal(sut);
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual.ToString(), expected.ToString());
            //Teardown
        }


        [Fact]
        public void getTotalwithDiffCurrency_ShouldReturnCorrectResult()
        {
            //Fixture setup
            var cart = new Cart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            cart.AddItem(sut, item);
            cart.AddItem(sut, item);
            cart.AddItem(sut, item);
            var expected = 81.1125;
            //Excercise system
            sut = cart.getTotalInDiffCurrency(sut, "Eur");
            var actual = sut.Total;
            //Verify outcome
            Assert.Equal(actual.ToString(), expected.ToString());
            //Teardown
        }
    }
}
