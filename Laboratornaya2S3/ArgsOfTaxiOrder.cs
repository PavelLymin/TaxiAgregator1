using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    //параметризация события IWantToTakeATaxi
    public class ArgsOfTaxiOrder : EventArgs
    {
        public Order Order { get; set; }

        public ArgsOfTaxiOrder(Order order)
        {
            Order = order;
        }
    }
}
