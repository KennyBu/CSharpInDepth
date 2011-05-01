using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Ver2
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void can_sort_products()
        {
            List<Product> products = Product.GetSampleProducts();

            products.Sort(new ProductNameComparer());

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

            Predicate<Product> test = delegate(Product p)
                                          {
                                              return p.Price > 10m;
                                          };
            
            List<Product> matches = products.FindAll(test);

            Action<Product> print = Console.WriteLine;

            matches.ForEach(print);

            Assert.IsTrue(true);
        }
    }
}
