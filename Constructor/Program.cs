using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {   //DEFAULT CONSTRUCTOR
            Customer customer1 = new Customer {Id = 1, FirstName = "Mehmet", LastName = "V"};
            Customer customer2 = new Customer();
                customer2.Id = 2;
                customer2.FirstName = "Semih";
                customer2.LastName = "V";  

            //SPECİAL CONSTRUCTOR
            Customer customer3 = new Customer(3, "Yusuf", "V");
            //special constructor ile customer eklemenin ikinci yolu ama bunun için (x) kısmı yazılmalı
            customer3.Id = 3;
            customer3.FirstName = "Yusuf";
            customer3.LastName = "V";
        }
    }
    class Customer
    {
        public Customer() //DEFAULT CONSTRUCTOR 
        {
            Console.WriteLine("default constructor çalıştı.");
        }

        public Customer(int id, string firstName, string lastName) //SPECİAL CONSTRUCTOR
        {   //(x) proplar bu şekilde parametreler ile eşleştrilmeli
            Id = id;
            FirstName = firstName;
            LastName = lastName;

            Console.WriteLine("special constructor çalıştı.");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
