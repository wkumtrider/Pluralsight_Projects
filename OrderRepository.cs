using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    internal class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order();
            if (orderId == 2)
            {
                order.CustomerId = "144";
            }

        
        }
        public bool Save(Order order)
        {
            var succes = true;
            if (order.HasChanges)
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

