using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product (1,"Product1", 1000, 10 );
            Product product2 = new Product (2, "Product 2", 2000, 20 );

            product1.GetDetailsAfterDiscount();
            product2.GetDetailsAfterDiscount();

        }
    }
}
