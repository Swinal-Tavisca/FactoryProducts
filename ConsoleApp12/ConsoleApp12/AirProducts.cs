using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class AirProducts:Iproduct
    {
        public string getTypeOfProduct()
        {
            return "Air";
        }
        public void Book()
        {
            Console.WriteLine("BOOKING AIR PRODUCT");
        }
        public void Save()
        {
            Console.WriteLine("SAVING AIR PRODUCT");
        }
    }
}
