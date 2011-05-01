using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Ver5
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void can_sort_products()
        {
            List<Product> products = Product.GetSampleProducts();

            foreach (Product product in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }

            Assert.IsTrue(true);
        }
    }
}
