using System.Collections.Generic;

namespace CSharpInDepth.Tests.Ver4
{
    public class Product
    {
        readonly string name;
        readonly decimal price;

        public string Name { get { return name; } }
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        Product() { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
                       {
                           new Product(name: "West Side Story", price:9.99m),
                           new Product(name: "Assasians", price: 14.99m),
                           new Product(name: "Frogs", price: 13.99m),
                           new Product(name: "Sweeney Todd", price :10.99m)
                       };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }

    }
}