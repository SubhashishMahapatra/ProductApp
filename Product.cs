using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private int _discountPercent;
        private double _priceAfterDiscount;

        public Product(int productId1, string productName1, double productPrice1, int discountPercent1) 
        {
            _productId = productId1;
            _productName = productName1;
            _productPrice = productPrice1;
            _discountPercent = discountPercent1;

            _priceAfterDiscount = (_productPrice - _productPrice * _discountPercent / 100);

        }
        public void GetDetailsAfterDiscount()
        {
            Console.WriteLine("Product Id: "+ _productId);
            Console.WriteLine("Product Name: " + _productName);
            Console.WriteLine("Product Price: " + _productPrice);
            Console.WriteLine();
            Console.WriteLine("This Product Discount Percent is: " + _discountPercent);
            Console.WriteLine("Product Price after Discount would be: "+_priceAfterDiscount);
            Console.WriteLine();

        }



    }
}
