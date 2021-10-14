using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 25;
            product1.StockQuantity = 5;
            product1.Comments = "Very sweet an apple";


            Product product2 = new Product();
            product2.Name = "Lemon";
            product2.Price = 10;
            product2.StockQuantity = 5;
            product2.Comments = "Yummy Lemon";


            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

           

            Console.ReadLine();

        }
    }
}
