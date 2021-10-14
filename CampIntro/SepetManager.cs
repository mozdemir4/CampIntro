using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampIntro
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product added :"+product.Name);
            Console.WriteLine("---------");
        }
    }
}
