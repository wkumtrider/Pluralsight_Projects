﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    internal class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }



        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }

    }  
}
