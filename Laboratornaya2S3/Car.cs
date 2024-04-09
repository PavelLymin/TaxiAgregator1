using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    public class Car
    {
        public string Number { get; set; }
        public string Brand { get; set; }
        public bool ChildSead {  get; set; }

        public Car (string number, string brand, bool childSead)
        {
            Number = number;
            Brand = brand;
            ChildSead = childSead;
        }
    }
}
