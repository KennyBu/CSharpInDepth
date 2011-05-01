using System.Collections.Generic;

namespace CSharpInDepth.Tests.Ver2
{
    public class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }

    }
}