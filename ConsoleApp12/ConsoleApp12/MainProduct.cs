using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class MainProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER PRODUCT :");
            Console.WriteLine("CAR");
            Console.WriteLine("AIR");
            Console.WriteLine("HOTEL");
            Console.WriteLine();

            string product = Console.ReadLine();
            Console.WriteLine();

            ProductFactory factory = new ConcreteProductFactory();
            Iproduct iproduct = factory.GetProduct(product);
            iproduct.getTypeOfProduct();
            iproduct.Book();
            iproduct.Save();

            Console.ReadKey();
        }
    }
}
