using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGYK5_5.Abstract;
using YGYK5_5.Entities;

namespace YGYK5_5.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Customer customer, Campaign campaign, Product product)
        {
            int discount = campaign.CampaignDiscount;
            product.ProductPrice = product.ProductPrice * discount / 100;

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " isimli kullanıcının satın alımı:\n"
                + campaign.CampaignName + " Kampanyası kullanıldı.\n"
                + "Ürün: " + product.ProductName
                + "\nFiyat: " + product.ProductPrice + " TL.");
        }
    }
}
