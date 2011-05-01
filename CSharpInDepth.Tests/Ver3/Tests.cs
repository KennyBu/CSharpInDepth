using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Ver3
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void can_sort_products()
        {
            List<Product> products = Product.GetSampleProducts();

            products.Sort(delegate(Product x, Product y)
                              {
                                  return x.Name.CompareTo(y.Name);
                              });

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void can_loop_products()
        {
            List<Product> products = Product.GetSampleProducts();

            foreach (var product in products.Where(p => p.Price > 10))
            {
                Console.WriteLine(product);
            }

            Assert.IsTrue(true);
        }
    }
}
