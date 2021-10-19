using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer 
            {
                Id = 1,
                CustomerNumber = "2132145",
                FirstName = "Muhammet",
                LastName = "ÖZDEMİR",
                IdentityNumber = "12345678910"
            };

            CorparationCustomer customer2 = new CorparationCustomer
            {
                Id = 2,
                CustomerNumber = "5135795",
                CompanyName = "KODLAMAIO",
                TaxNo = "579826"
            };

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorparationCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
