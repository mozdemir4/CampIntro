using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public static void Add(Product product)
        {
            Console.WriteLine(product.ProductName +" "+"added.");
        }
        public static void Update(Product product)
        {
            Console.WriteLine(product.ProductName +" "+"updated.");
        }

     
    }
}
