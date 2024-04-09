using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya2S3
{
    //параметризация события RespondedToOder
    public class ArgsOfTaxiDriver: EventArgs
    {
        public TaxiDriver TaxiDriver { get; set; }
        
        public ArgsOfTaxiDriver(TaxiDriver driver)
        {
            TaxiDriver = driver;
        }
    }
}
