using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mehmet V
            IndıvıdualCustomer musteri1 = new IndıvıdualCustomer();
            musteri1.CustomerId = 1;
            musteri1.CustomerNo = "12345";
            musteri1.CustomerFirstName = "Mehmet";
            musteri1.CustomerLastName = "V";
            musteri1.TcNo = "12345678910";

            //Company
            CoorporateCustomer musteri2 = new CoorporateCustomer();
            musteri2.CustomerId = 2;
            musteri2.CustomerNo = "54321";
            musteri2.CompanyName = "Company";
            musteri2.TaxNo = "1234567890";


        }
    }
}