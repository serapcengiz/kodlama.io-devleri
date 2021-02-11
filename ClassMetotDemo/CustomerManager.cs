using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer, List<Customer> customers)
        {
                Console.WriteLine("Müşteri Eklendi:" + customer.Name + " " + customer.Surname);
            customers.Add(customer);
        }

        public void Delete(Customer customer,List<Customer> customers)
        {
            Console.WriteLine("Müşteri Silindi:"+customer.Name+""+customer.Surname);
            customers.Remove(customer);
        }
        public void Listele(List<Customer> customers)
        {
            foreach (var c in customers )
            {
                Console.WriteLine("Adı:"+c.Name);
                Console.WriteLine("Soyadı:" + c.Surname);
                Console.WriteLine("Id:"+c.Id);
                Console.WriteLine("Bakiyeniz:"+c.Bakiye);
            }

        }
    }
}
