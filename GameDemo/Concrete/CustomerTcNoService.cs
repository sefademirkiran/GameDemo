using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CustomerTcNoService:Customer
    {
        public CustomerTcNoService(Customer customer)
        {
            TcNoService(customer);
        }
        public bool TcNoService(Customer customer)
        {
            if (customer.CustomerFirsName=="Sefa"&&customer.CustomerLastName=="Demirkıran"&& customer.BirthOfYear==1994 && customer.TcNo=="12312312312")
            {
                Console.WriteLine("Kimlik Bilgileri Doğru...");
                return true;
            }
            else
            {
                Console.WriteLine("Kimlik Bilgileri Hatalı.");
                return false;
            }
        }

    }
}
