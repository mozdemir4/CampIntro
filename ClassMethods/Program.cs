using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Muhammet";
            customer1.Surname = "Özdemir";

            Customer customer2 = new Customer();
            customer2.Name = "Bahar";
            customer2.Surname = "KOÇER";

          

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.ReadLine();
           
        }
    }
}
