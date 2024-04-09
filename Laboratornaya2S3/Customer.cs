using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    //делегат
    public delegate void NotificationOfCustomer(ArgsOfTaxiOrder argsOfTaxiOrder);

    public class Customer
    {
        public string Name { get; set; }
        public Order tempOrder { get; set; }

        public Customer(string name, Order tempOrder)
        {
            Name = name;
            this.tempOrder = tempOrder;
        }
        
        //событие
        public event NotificationOfCustomer IWantToTakeATaxi;

        //Функция, инициирующая событие
        //При вызове события отправляем параметр ArgsOfTaxiOrder(tempOrder) - Место назначения, место отправление, детское сиденье и дистанция  
        public void TakeATaxi()
        {
            IWantToTakeATaxi?.Invoke(new ArgsOfTaxiOrder(tempOrder));
        }
    }
}
