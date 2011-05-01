using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Ver4
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void can_sort_products()
        {
            List<Product> products = Product.GetSampleProducts();

            products.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Assert.IsTrue(true);
        }
    }
}
