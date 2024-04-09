using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    public class Adress
    {
        public (double, double) Coordinates {  get; set; }
        public string Street { get; set; }
        public int Home {  get; set; }

        public Adress((double, double) coordinates, string street, int home)
        {
            Coordinates = coordinates;
            Street = street;
            Home = home;
        }
    }
}
