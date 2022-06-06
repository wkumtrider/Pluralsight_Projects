using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    internal class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            productId = productId;
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (CurrentPrice <= 0) isValid = false;
            return isValid;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        
    }
}
