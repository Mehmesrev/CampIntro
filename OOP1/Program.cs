using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatagoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 10;

            Product product2 = new Product {Id = 2, CatagoryId = 5, ProductName = "Sandalye", UnitPrice = 50, UnitInStock = 25};

            //PascalCase   //CamelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
            

        }
    }
}
