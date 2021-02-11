using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            Customer customer1 = new Customer();
            customer1.Name = "Serap";
            customer1.Surname = "Cengiz";
            customer1.Id = 123456789;
            customer1.Bakiye = 1200;


            Customer customer2 = new Customer();
            customer2.Name = "Seher";
            customer2.Surname = "Cengiz";
            customer2.Id = 123456987;
            customer2.Bakiye = 1899;

            CustomerManager manager = new CustomerManager();
            manager.Add(customer1,customers);
            manager.Add(customer2,customers);
            manager.Delete(customer1, customers);
            manager.Listele(customers);
            

            Console.ReadLine();

           

        }
    }
}
