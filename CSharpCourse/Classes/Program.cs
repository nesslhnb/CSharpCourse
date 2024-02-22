using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.CustomerFirstName = "Esra";
            customer.CustomerLastName = "Arslan";
            customer.CustomerCityn = "Ordu";

            Customer customer2 = new Customer
            {
                Id = 2, CustomerFirstName = "Neslihan", CustomerLastName = "Bükte", CustomerCityn = "Ordu"
            };
            Console.WriteLine(customer.CustomerFirstName);

        }
    }
    
}
