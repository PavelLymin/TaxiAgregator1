using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Екатерина", new Order(new Adress((55.994637, 92.798755), "Тверская-Ямская", 36), new Adress((56.004256, 92.772263), "Садовая-Самотечная", 24), true, 0.0281842371725757));
            Customer customer1 = new Customer("Антон", new Order(new Adress((55.994637, 92.798755), "Охотный ряд", 1), new Adress((56.004256, 92.772263), "Петровка", 38), true, 0.0281842371725757));

            TaxiDriver taxiDriver1 = new TaxiDriver("Андрей", (56.008639, 92.799896), 4.5, true, new Car("К236СУ", "Toyota", true));
            TaxiDriver taxiDriver2 = new TaxiDriver("Александр", (56.02319, 92.752024), 4, false, new Car("П566СУ", "Hunday", false));
            TaxiDriver taxiDriver3 = new TaxiDriver("Борис", (56.025049, 92.826508), 4, true, new Car("Б565ЛА", "Kia", true));

            TaxiAggregator aggregator = new TaxiAggregator();
            aggregator.AddNewTaxiDriver(taxiDriver1);
            aggregator.AddNewTaxiDriver(taxiDriver2);
            aggregator.AddNewTaxiDriver(taxiDriver3);

            var itog = aggregator.CreateAnOrder(customer, customer.tempOrder.Departure, customer.tempOrder.Destination, customer.tempOrder.ChildSead);
            var itog1 = aggregator.CreateAnOrder(customer1, customer1.tempOrder.Departure, customer1.tempOrder.Destination, customer1.tempOrder.ChildSead);
            Console.WriteLine(itog);
            Console.WriteLine(itog1);
        }
    }
}
