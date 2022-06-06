using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    internal class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set";
                product.CurrentPrice = 15.96M;

            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            var succes = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an Insert Stored Proceddure
                    }
                    else
                    {
                        //Call an Update Stored procedure
                    }
                }
                else
                {
                    succes = false;
                }
            }
            return succes;
        }



    }
}
