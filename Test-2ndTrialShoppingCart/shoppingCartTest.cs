using System;
using Xunit;
using _2ndTrialShoppingCart;
using System.Collections.Generic;

namespace Test_2ndTrialShoppingCart
{
    public class shoppingCartTest
    {
        [Fact]
        public void CreateCart_ShouldReturnShoppingCart()
        {
            //Fixture setup
            var cart = new ShoppingCart();
            //Excercise system
            var sut = cart.CreateCart();
            //Verify outcome
            Assert.NotNull(sut);
            Assert.IsType<ShoppingCart>(sut);
            //Teardown
        }

        [Fact]
        public void AddItem_ShouldReturnShoppingCartWithItem()
        {
            //Fixture setup
            var cart = new ShoppingCart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            var expected = new List<CartItem>();
            expected.Add(item);
            //Excercise system
            var Item = new Item();
            Item.Add(sut, item);
            var actual = sut.Items;
            //Verify outcome
            Assert.Equal(actual,expected);
            //Teardown
        }

        [Fact]
        public void AddItem_ShouldReturnShoppingCartWithAddedItems()
        {
            //Fixture setup
            var cart = new ShoppingCart();
            var sut = cart.CreateCart();
            var item = new CartItem(1, 17.5, .03, 0);
            var expected = new List<CartItem>();
            expected.Add(item);
            expected.Add(item);
            //Excercise system
            var Item = new Item();
            Item.Add(sut, item);
            Item.Add(sut, item);
            var actual = sut.Items;
            //Verify outcome
            Assert.Equal(actual, expected);
            //Teardown
        }


    }
}
