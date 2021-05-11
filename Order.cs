using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        //the DateTimeOffset value type tracks the date, time and time zone offset
// the question mark denotes a nullable type, meaning it can hold the value of the DateTimeOffset or a null 
        public DateTimeOffset? OrderDate { get; set; }

       
        //Validates the order data
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
