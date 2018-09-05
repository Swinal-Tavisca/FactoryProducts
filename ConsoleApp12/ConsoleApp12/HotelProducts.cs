using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class HotelProducts: Iproduct
    {
        public string getTypeOfProduct()
        {
            return "Hotel";
        }
        public void Book()
        {
            Console.WriteLine("BOOKING HOTEL PRODUCT");
        }
        public void Save()
        {
            Console.WriteLine("SAVING HOTEL PRODUCT");
        }
    }
}
