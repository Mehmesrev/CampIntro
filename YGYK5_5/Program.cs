using System;
using YGYK5_5.Abstract;
using YGYK5_5.Concrete;
using YGYK5_5.Entities;

namespace YGYK5_5
{
    internal partial class Program
    {
        static void Main(string[] args)
        {   
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Mehmet";
            customer1.LastName = "V";
            customer1.DateOfBirth = "2005";
            customer1.NationalityId = "12345678910";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yaz Sezonu Indirimi";
            campaign1.CampaignDiscount = 50;

            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Starfield";
            product1.ProductPrice = 1000;

            CustomerManager customerManager1 = new CustomerManager(new CustomerCheckManager());
            customerManager1.Add(customer1);

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);

            SaleManager saleManager1 = new SaleManager();
            saleManager1.Sale(customer1, campaign1, product1);
        }
    }
}