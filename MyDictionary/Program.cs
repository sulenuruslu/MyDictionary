using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> product = new Dictionary<string, int>();
            product.Add("Elbise  "  , 24);
            product.Add("Bluz  "  , 19);
            product.Add("T-Shirt  "  , 7);
            product.Add("Pantolon  "  , 13);

            product.List();
        }
    }
}
