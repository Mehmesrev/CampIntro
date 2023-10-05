using System;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //(stack) value types: int, decimal, float, enum, boolean... 
            int number1 = 10;
            int number2 = 20;

            number1 = number2;
            number2 = 100;
            //Console.WriteLine(number1); //20


            //(stack ve heap) reference types: array, class, interface...
            int[] numbers1 = { 1, 3, 5, 7, 9 };
            int[] numbers2 = { 2, 4, 6, 8, 0 };

            numbers1 = numbers2;
            numbers2[0] = 11;
            //Console.WriteLine(numbers1[0]); //11


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Mehmet";
            person2 = person1;
            person1.FirstName = "Semih";
            //Console.WriteLine(person2.FirstName); //Semih


            Customer customer = new Customer();
            customer.FirstName = "Yusuf";
            Person person3 = customer;
            //Console.WriteLine(person3.FirstName); //Yusuf


            //Console.WriteLine(((Customer)person3).CCNumber);


            //
            Employee employee = new Employee();
            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
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
    class Customer:Person
    {
        public string CCNumber { get; set; }
    }
    class Employee:Person
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