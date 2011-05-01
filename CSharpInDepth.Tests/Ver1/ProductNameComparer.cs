using System.Collections;

namespace CSharpInDepth.Tests.Ver1
{
    public class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product) x;

            Product second = (Product) y;

            return first.Name.CompareTo((second.Name));
        }
        
    }
}