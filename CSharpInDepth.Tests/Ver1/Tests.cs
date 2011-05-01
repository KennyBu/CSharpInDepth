using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpInDepth.Tests.Ver1
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void can_sort_products()
        {
            ArrayList products = Product.GetSampleProducts();

            products.Sort(new ProductNameComparer());

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void can_loop_products()
        {
            ArrayList products = Product.GetSampleProducts();

            foreach (Product product in products)
            {
                if( product.Price > 10m)
                    Console.WriteLine(product);
            }

            Assert.IsTrue(true);
        }
    }
}
