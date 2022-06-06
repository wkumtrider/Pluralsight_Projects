using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            productId = productId;
        }
        
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; set; }
        private string _productName;
        public string ProductName
        {
            
            get 
            {
                return _productName.InsertSpaces(); 
            }
            set 
            {
                _productName = value; 
            }
        }

        public string Log() => $"{ProductId}: {ProductName} Detail: {Description} Status: {EntityState.ToString()}";
        public override string ToString()
        {
            return ProductName;
        }


        public override bool Validate()
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
