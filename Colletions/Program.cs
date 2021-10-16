using System;
using System.Collections.Generic;

namespace Colletions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Elif", "Fatma", "Muhammet", "Semiha" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            List<string> names2 = new List<string> { "Elif","Fatma","Caner","Kerem"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ahmet");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            



        }
    }
}
