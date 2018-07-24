using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("sku1", "product1", "product1description");
            LineItem item1 = new LineItem(5, 85000, product1);

            Order order = new Order(DateTime.Now, OrderStatus.DELIVERED, "address1", item1);
            double total = order.setTotal();  
            Console.WriteLine(total);
        }
    }
}
