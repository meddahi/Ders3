using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    class ProductManager
    {
        //ENCAPSULATION
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }


    }  
}
