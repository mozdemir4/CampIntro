using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="Muhammet",LastName="ÖZDEMİR",City="KOCAELİ"};

            Customer customer2 = new Customer(2, "Arzu", "CAN", "MANİSA");
            
        }
    }
    class Customer
    {

        //default constructor // new işlemini yaptığımızda başlangıçta ilgili bloğu yazmasak
        // bile arka planda böyle bir constructor oluşur
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Parametleri yapıcı blog çalıştı."+" "+ FirstName);
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
