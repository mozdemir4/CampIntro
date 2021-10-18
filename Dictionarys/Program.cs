using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Students = new Dictionary<int, string>();
            MyDictionaryList<int, string> Students = new MyDictionaryList<int, string>();
            Students.Add(105, "Muhammet ÖZDEMİR");
            Students.Add(205, "Halil KORKMAZ");

            Console.WriteLine(Students.Count);
         
            
            
        }
    }
}
