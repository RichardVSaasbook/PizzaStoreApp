using PizzaStoreAppBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreAppBack.Tests {
    public class PizzaStoreAppPizzaDataTests {
        private readonly PizzaStoreAppData data;

        public PizzaStoreAppPizzaDataTests() {
            data = new PizzaStoreAppData();
        }

        [Fact]
        public void Test_ListPizzasInOrder() {
            var actual = data.ListPizzasInOrder(1).Count;

            Assert.True(actual > 0);
        }

        [Fact]
        public void Test_ListSpecialtyPizzaIngredients() {
            var actual = data.ListSpecialtyPizzaIngredients(1).Count;

            Assert.True(actual > 0);
        }
    }
}
