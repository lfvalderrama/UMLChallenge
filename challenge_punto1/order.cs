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

        public void addItem(LineItem i)
        {
            this.items.Add(i);
        }

        public double setTotal()
        {
            double total = 0;
            foreach (LineItem item in this.items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
