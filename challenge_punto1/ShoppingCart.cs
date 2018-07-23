using System.Collections.Generic;

namespace challenge
{
    class ShoppingCart
    {
        private List<LineItem> items = new List<LineItem>();

        public void addItem(LineItem i)
        {
            this.items.Add(i);
        }

        public void cleanCart()
        {
            this.items = new List<LineItem>();
        }
    }
}