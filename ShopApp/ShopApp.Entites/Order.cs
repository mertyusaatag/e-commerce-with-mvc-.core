using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entites
{
    public class Order
    {
        public Order()
        {
            orderItems = new List<OrderItem>();
        }
        public int Id { get; set; }
        public string OrderNumber { get; set; }

        public EnumOrderState orderState { get; set; }
        public DateTime OrderDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<OrderItem> orderItems { get; set; }
    }
    public enum EnumOrderState
    {
        waiting=0,
        Unpaid=1,
        Completed=2
    }
}
