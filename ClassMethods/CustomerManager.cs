using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public static void List(Customer[] customer)
        {
            Console.WriteLine("Customer List");
            for (int i = 0; i < customer.Length; i++)
            {
                Console.WriteLine("Customer Name: " + customer[i].Name + "\n" + "Customer Surname: " + customer[i].Surname);
            }
                 
        }
        public static void Add(Customer customer)
        {
            Console.WriteLine("Customer added!" + "\n" + "Customer Name: " + customer.Name);
            Console.WriteLine("-----");
        }

        public static int Delete(Customer c)
        {
            Console.WriteLine("Deleted by Admin" + "\n" + "Customer Id: " + c.Id);
            return c.Id;
        }
        

        
    }
}
