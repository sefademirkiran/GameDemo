using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** Kimlik Kontrol ****************");

            CustomerTcNoService customerTcNoService = new CustomerTcNoService(new Customer
            {
                CustomerId = 1,
                CustomerFirsName = "Sefa",
                CustomerLastName = "Demirkıran",
                BirthOfYear = 1994,
                TcNo = "12312312312"

            });
            Customer customer1 = new Customer { CustomerId = 1, CustomerFirsName = "Hatice", CustomerLastName = "Demirkıran", BirthOfYear = 1960, TcNo = "1122334455667" };
            Customer customer2 = new Customer { CustomerId = 2, CustomerFirsName = "Ahmet", CustomerLastName = "Demirkıran", BirthOfYear = 1961, TcNo = "1452365214523" };
            Customer customer3 = new Customer { CustomerId = 3, CustomerFirsName = "Seda", CustomerLastName = "Ucur", BirthOfYear = 1984, TcNo = "12589245245" };

            Product product1 = new Product { ProductId = 50, ProductName = "Gta", ProductUnitPrice = 299 };
            Product product2 = new Product { ProductId = 51, ProductName = "CsGo", ProductUnitPrice = 399 };
            Product product3 = new Product { ProductId = 52, ProductName = "Forizon", ProductUnitPrice = 199 };

            Campaign campaign1 = new Campaign { CampaingId = 101, CampaingName = "Şahane Pazar", DiscountRate = 10.5 };
            Campaign campaign2 = new Campaign { CampaingId = 102, CampaingName = "Çılgın Cuma", DiscountRate = 9.5 };
            Campaign campaign3 = new Campaign { CampaingId = 103, CampaingName = "Son Fırsat", DiscountRate = 5.5 };


            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            SalesManager sales = new SalesManager();


            Console.WriteLine("");
            Console.WriteLine("************ Oyuncular **********\n");
            List<Customer> customerList = new List<Customer> { customer1, customer2, customer3 };

            customerManager.GetAll(customerList);

            Console.WriteLine("**************** Oyunlar ************\n");
            List<Product> productsList = new List<Product> { product1, product2, product3 };
            productManager.GetAll(productsList);

            Console.WriteLine("************ Kampanyalar ************\n");
            List<Campaign> campaignsList = new List<Campaign> { campaign1, campaign2, campaign3 };
            campaignManager.GetAll(campaignsList);

            Console.WriteLine("************ Oyuncu Ekle - Oyuncu Sil - Oyuncu Güncelle *********\n");
            Customer customer4 = new Customer { CustomerId = 4, CustomerFirsName = "Merve", CustomerLastName = "Akay", BirthOfYear = 1992, TcNo = "125845641865" };
            customerManager.Add(customer4);
            Customer customer5 = new Customer { CustomerId = 5, CustomerFirsName = "Murat", CustomerLastName = "Kekilli", BirthOfYear = 1971, TcNo = "41845444845" };
            customerManager.Add(customer5);

            customerManager.Delete(customer3);
            _ = new Customer { CustomerId = 2, CustomerFirsName = "Sercan", CustomerLastName = "Yımaz", BirthOfYear = 1993, TcNo = "5150210620" };
            customerManager.Update(customer2);

            Console.WriteLine("");
            Console.WriteLine("**************** Oyun Ekle - Oyun Sil - Oyun Güncelle ***************");

            Product product4 = new Product { ProductId = 4, ProductName = "Pubg", ProductUnitPrice = 199 };
            productManager.Add(product4);

            productManager.Delete(product2);
            productManager.Update(product1);
            Console.WriteLine("");

            Console.WriteLine("************* Kampanya Güncelleme ***********\n");
            
            campaignManager.Update(campaign1);
            Console.WriteLine("");

            Console.WriteLine("******* İndirim Uygulama *********\n");
            sales.ApplyDiscount(product1, campaign3);
        }
    }
}
