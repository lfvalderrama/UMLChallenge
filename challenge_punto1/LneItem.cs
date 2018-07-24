namespace challenge
{
    class LineItem{

        private int quantity;
        private double price;
        private Product product;

        public LineItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        internal Product Product { get => product; set => product = value; }
    }
}