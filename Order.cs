using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    internal class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        

        public Order Retrieve(int orderID)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();

        }
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;
        }
    } 
}
