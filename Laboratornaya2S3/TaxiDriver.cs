using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    //делегат
    public delegate void NotificationOfDriver(ArgsOfTaxiDriver argsOfTaxiDriver);

    //Класс наблюдатель
    public class TaxiDriver
    {   
        public string Name { get; set; }
        public (double, double) CurrentLocation { get; set; }
        public double Ball { get; set; }
        public bool Free { get; set; }
        public Car Car { get; set; }

        public TaxiDriver(string name, (double, double) currentLocation, double ball, bool free, Car car)
        {
            Name = name;
            CurrentLocation = currentLocation;
            Ball = ball;
            Free = free;
            Car = car;
        }

        //событие
        public event NotificationOfDriver RespondedToOrder;

        public void GoToOrder(ArgsOfTaxiOrder argsOfTaxiOrder)
        {
            double AB = Math.Sqrt(Math.Pow((CurrentLocation.Item1 - argsOfTaxiOrder.Order.Destination.Coordinates.Item1), 2) + Math.Pow((CurrentLocation.Item2 - argsOfTaxiOrder.Order.Destination.Coordinates.Item2), 2));
            if (Free && (Car.ChildSead == argsOfTaxiOrder.Order.ChildSead) && (argsOfTaxiOrder.Order.Distance < 1))
            {
                RespondedToOrder?.Invoke(new ArgsOfTaxiDriver(this));
                Ball += AB;
            }
        }
    }
}
