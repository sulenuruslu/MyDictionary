using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<T1,T2>
    {
        T1[] productName;
        T2[] unitsInStock;

        public Dictionary()
        {
            productName = new T1[0];
            unitsInStock = new T2[0];
        }
        public void Add(T1 item1, T2 item2)
        {
            T1[] tempProductName = productName;
            T2[] tempUnitsInStock = unitsInStock;

            productName = new T1[productName.Length + 1];
            unitsInStock = new T2[unitsInStock.Length + 1];

            for (int i = 0; i < tempProductName.Length; i++)
            {
                productName[i] = tempProductName[i];
                unitsInStock[i] = tempUnitsInStock[i];
            }

            productName[productName.Length - 1] = item1;
            unitsInStock[unitsInStock.Length - 1] = item2;
        }

            public void List()
            {
                Console.WriteLine("List of Products");
                for (int i = 0; i < productName.Length; i++)
                {
                    Console.WriteLine("Product Name: " + productName[i] );
                    Console.WriteLine("Units In Stock: " + unitsInStock[i]);
                    Console.WriteLine("-------------------------------------" );
                }
            }



        
    }
}
