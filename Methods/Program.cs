using Methods;
using System;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Name = "Dondurma";
            urun1.Price = 15;
            urun1.Description = "Maraş dondurması";

            Product urun2 = new Product();
            urun2.Name = "Çay";
            urun2.Price = 50;
            urun2.Description = "Rize çayı";

            Product[] Products = new Product[] { urun1, urun2 };

            foreach (var theProduct in Products)
            {
                Console.WriteLine(theProduct.Name);
                Console.WriteLine(theProduct.Price);
                Console.WriteLine(theProduct.Description);
                Console.WriteLine("---------------");
            }

            CartManager cartManager = new CartManager();
            cartManager.Add(urun1);
            cartManager.Add(urun2);







            Console.ReadLine();
        }

    }
}