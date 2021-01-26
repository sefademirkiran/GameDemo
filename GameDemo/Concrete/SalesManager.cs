using System;
using GameDemo.Abstract;
using GameDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager:Campaign
    {
        public void ApplyDiscount(Product product, Campaign campaign)
        {
            double unitPrice = Convert.ToDouble(product.ProductUnitPrice);
            double discountedRate = Convert.ToDouble(campaign.DiscountRate);

            unitPrice = unitPrice - unitPrice * discountedRate;

            Console.WriteLine("Oyun {0} - Birim Fiyatı: {1}\n Kampanya Adı : {2} - İndirim Oranı{3} --> İndirimli Fiyat {4}\n",product.ProductName,product.ProductUnitPrice,campaign.CampaingName,campaign.DiscountRate,unitPrice);
        }
        IManagerService<Product> manager = new ProductManager();
        public decimal ApplyDiscount(List<Product> productList, Campaign campaign)
        {
            double total = 0;
            double discountedAmount = 0;

            manager.GetAll(productList);
            for (int i = 0; i < productList.Count; i++)
            {
                total = total + (double)productList[i].ProductUnitPrice;
                discountedAmount = total - total * (double)campaign.DiscountRate;
            }
            Console.WriteLine("Total Amount: {0}\nDiscounted Amount:{1:F}\n",total,discountedAmount);
            return (decimal)discountedAmount;
        }

    }
}
