using System;
using System.Collections.Generic;

namespace challenge
{
    class Test
    {
        static void Main(string[] args)
        {
            List<LineItem> items = new List<LineItem>(); 
            Product product1 = new Product("sku1", "product1", "product1description");
            LineItem item1 = new LineItem(5, 85000, product1);
            Product product2 = new Product("sku2", "product2", "product2description");
            LineItem item2 = new LineItem(2, 10000, product2);

            Order order = new Order(DateTime.Now, OrderStatus.DELIVERED, "address1", items);
            order.addItem(item1);
            order.addItem(item2);

            double total = order.setTotal();  
            Console.WriteLine(total);
        }
    }
}
