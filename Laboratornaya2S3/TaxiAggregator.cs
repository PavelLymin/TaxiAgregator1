using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    public class TaxiAggregator
    {
        private List<Customer> customers { get; set; }
        private List<TaxiDriver> taxiDrivers { get; set; }
        private List<TaxiDriver> taxiDriversTemp { get; set; }

        public TaxiAggregator()
        {
            customers = new List<Customer>();
            taxiDrivers = new List<TaxiDriver>();
            taxiDriversTemp = new List<TaxiDriver>();
        }

        public void AddNewTaxiDriver(TaxiDriver driver)
        {
            taxiDrivers.Add(driver);
            driver.RespondedToOrder += AddReadyDrivenInTempList;
        }

        public void RemoveTaxiDriver(TaxiDriver driver)
        {
            taxiDrivers.Remove(driver);
            driver.RespondedToOrder -= AddReadyDrivenInTempList;
        }

        private TaxiDriver FindBestDriver()
        {
            TaxiDriver taxiDriver = null;
            double max = 0;
            foreach (TaxiDriver driver in taxiDriversTemp)
            {
                if (driver.Ball > max)
                {
                    max = driver.Ball;
                    taxiDriver = driver;
                }
            }
            return taxiDriver;
        }

        private void AddReadyDrivenInTempList(ArgsOfTaxiDriver driverArgs) /* этот метод вызывается вызовом customer.TakeATaxi();*/
        {
            taxiDriversTemp.Add(driverArgs.TaxiDriver);
        }

        public string CreateAnOrder(Customer customer, Adress departure, Adress destination, bool childSead)
        {
            foreach (var driver in taxiDrivers)
            {
                customer.IWantToTakeATaxi += driver.GoToOrder; /*Я хочу такси и все водители подписались*/
            }
            customers.Add(customer);

            Order order = new Order(departure, destination, childSead);
            customer.tempOrder = order;
            customer.TakeATaxi();

            string itog = "";
            TaxiDriver taxiDriver = FindBestDriver();
            if (taxiDriversTemp.Count > 0)
            {
                taxiDriver.Free = false;
                itog += $"Водитель {taxiDriver.Name} на {taxiDriver.Car.Brand} с гос. номером {taxiDriver.Car.Number} отправилась на заказ: от {customer.tempOrder.Departure.Street} {customer.tempOrder.Departure.Home} до {customer.tempOrder.Destination.Street} {customer.tempOrder.Destination.Home}.";
            }
            else
            {
                itog += "Не найден подходящий водитель.";
            }
            taxiDriversTemp.Clear();
            return itog;
        }
    }
}
