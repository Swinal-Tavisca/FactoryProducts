using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class CarProduct:Iproduct
    {
        public string getTypeOfProduct()
        {
            return "Car";
        }
        public void Book()
        {
            Console.WriteLine("BOOKING CAR PRODUCT");
        }
        public void Save()
        {
            Console.WriteLine("SAVING CARD PRODUCT");
        }
    }
}
