using System;
using System.Collections.Generic;

namespace challenge
{
    class Order
    {
        private int id;
        private DateTime modified;
        private OrderStatus status;
        private string shippingAddress;
        private double total;
        private List<LineItem> items = new List<LineItem>();

        public Order(DateTime modified, OrderStatus status, string shippingAddress, List<LineItem> items)
        {
            this.Modified = modified;
            this.Status = status;
            this.ShippingAddress = shippingAddress;
            this.Items = items;
        }

        public DateTime Modified { get => modified; set => modified = value; }
        public OrderStatus Status { get => status; set => status = value; }
        public string ShippingAddress { get => shippingAddress; set => shippingAddress = value; }
        public double Total { get => total; set => total = value; }
        internal List<LineItem> Items { get => Items1; set => Items1 = value; }
        internal List<LineItem> Items1 { get => items; set => items = value; }

        public void addItem(LineItem i)
        {
            this.Items.Add(i);
        }

        public double setTotal()
        {
            double total = 0;
            foreach (LineItem item in this.Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}
