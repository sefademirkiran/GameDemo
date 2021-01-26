using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
     class CampaignManager : IManagerService<Campaign>

    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("{0} kampanya eklendi.", entity.CampaingName);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("{0} kampanyası silindi. ", entity.CampaingName);
        }
        public void Update(Campaign entity)
        {
            Console.WriteLine("{0} kampanyası güncellendi. ", entity.CampaingName);
        }

        public void Get(Campaign entity)
        {
            Console.WriteLine("Kampanya Kimliği:{0} - Kampanya Adı: {1} - İndirim Oranı:{2}\n", entity.CampaingId, entity.CampaingName, entity.DiscountRate);
        }

        public void GetAll(List<Campaign> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("Kampanya Kimlik: {0} - Kampanya Adı: {1} - İndirim Oranı:{2}\n", item.CampaingId, item.CampaingName, item.DiscountRate);
            }
            Console.WriteLine();
        }
    }
      
        
    }

   

