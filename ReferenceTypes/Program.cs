using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,double,enum,boolean -- value types.
            //int sayi1 = 10, sayi2=20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı: " + sayi1);

            //// sayı 1 kaçtır. -- 20


            ////arrays, class, interface -- reference types
            //int[] numbers1 = new int[] { 1, 2, 3 };
            //int[] numbers2 = new int[] { 41, 53, 35 };

            //numbers1 = numbers2;
            //numbers2[0] = 1000;
            //Console.WriteLine("Numbers: " + numbers1[0]);


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Muhammet";
            person2 = person1;

            person1.FirstName = "Halis";

            //Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Kemal";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Caner";


            Person person3 = customer;




            // boxing işlemi
            // Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(customer);
            personManager.Add(employee);


        }

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
