using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    public class Order
    {
        public Adress Destination { get; set; }
        public Adress Departure {  get; set; }
        public bool ChildSead { get; set; }
        public double Distance { get; set; }

        public Order(Adress destination, Adress departure, bool childSead, double distance) : this(destination, departure, childSead)
        {
            Distance = distance;
        }

        public Order(Adress destination, Adress departure, bool childSead)
        {
            Destination = destination;
            Departure = departure;
            ChildSead = childSead;
        }
    }
}
