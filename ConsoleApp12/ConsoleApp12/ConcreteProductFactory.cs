using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class ConcreteProductFactory:ProductFactory
    {
        public override Iproduct GetProduct(string product)
        {
            switch(product)
            {
                case "CAR":
                    return new CarProduct();
                case "AIR":
                    return new AirProducts();
                case "HOTEL":
                    return new HotelProducts();
                default:
                    throw new ApplicationException();
            }
            
        }
    }
}
