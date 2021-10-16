using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // adding process
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Muhammet";
            customer1.Surname = "Özdemir";

            Customer customer2 = new Customer();
            customer1.Id = 2;
            customer2.Name = "Bahar";
            customer2.Surname = "KOÇER";

            CustomerManager.Add(customer1);
            CustomerManager.Add(customer2);

            // customer list
            Customer[] customers = new Customer[] { customer1, customer2 };
            CustomerManager.List(customers);

            // customer deleted
            CustomerManager.Delete(customer1);
            Console.ReadLine();

           
        }
    }
}
