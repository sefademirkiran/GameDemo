using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CustomerManager : IManagerService<Customer>
    {
        public void Add(Customer entity)
        {
            Console.WriteLine("{0} {1} Müşterisi eklendi.", entity.CustomerFirsName,entity.CustomerLastName);
        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("{0} {1} Müşterisi silindi.", entity.CustomerFirsName,entity.CustomerLastName);
        }
        public void Update(Customer entity)
        {
            Console.WriteLine("{0} {1} Müşterisi güncellendi.", entity.CustomerFirsName, entity.CustomerLastName);
        }

        public void Get(Customer entity)
        {
            Console.WriteLine("Müşteri Kimlik : {0} - Müşteri Adı: {1} - Müşteri Soyadı : {2}\n",entity.CustomerId,entity.CustomerFirsName,entity.CustomerLastName);
        }

        public void GetAll(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("Müşteri Kimlik: {0} - Müşteri Adı: {1} - Müşteri Soyadı: {2}\n",item.CustomerId,item.CustomerFirsName,item.CustomerLastName);
            }
            Console.WriteLine();
        }

        
    }
}
