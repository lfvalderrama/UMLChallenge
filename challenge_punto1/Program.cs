using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            double total = order.setTotal();  
            Console.WriteLine(total);
        }
    }
}
